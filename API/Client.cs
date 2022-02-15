using MediaFireSDK;
using MediaFireSDK.Model;
using MediaFireSDK.Model.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProgressBackup.API
{
    internal class Client
    {
        private MediaFireApiConfiguration configuration;
        private MediaFireAgent agent;
        private string SessionKey;
        public bool LogedIn
        {
            get
            {
                return SessionKey != null;
            }
        }
        public Client()
        {
            string appID = Properties.Settings.Default.APIKey.Decrypt(),
                appSecret = Properties.Settings.Default.APISecret.Decrypt();
            if (string.IsNullOrEmpty(appID) || string.IsNullOrEmpty(appSecret))
            {
                if (MessageBox.Show("Error while launching application CODE 0x0000c.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
            configuration = new MediaFireApiConfiguration
                (
                   appId: appID,
                   apiKey: appSecret,
                   apiVersion: "1.4", //desired api version
                   automaticallyRenewToken: true, // Lets the SDK automatically renew the session token.
                   chunkTransferBufferSize: 4096, // The buffer size to be used on Download and Upload operations.
                   useHttpV1: true, //On some platforms, the client will throw the error "The server committed a protocol violation. Section=ResponseStatusLine". In that cases set this property to true. 
                   periodicallyRenewToken: true // The SDK will create a Task that will renew the token every **SessionRenewPeriod**.
                )
            {
                SessionRenewPeriod = TimeSpan.FromMinutes(5)
            };
            agent = new MediaFireAgent(configuration);
            SessionKey = null;
        }
        public async Task<bool> Login(string email, string password)
        {
            SessionKey = await agent.User.GetSessionToken(email, password);
            return SessionKey != null;
        }
        public async Task<bool> Register(string email, string password, string firstName = null, string lastName = null, string displayName = null)
        {
            var Response = await agent.User.Register(email, password, firstName, lastName, displayName);
            return Response.Result != null;
        }
        public async Task<bool> Upload(string fullfilePath)
        {
            using (var fileStream = System.IO.File.OpenRead(fullfilePath))
            {
                string FileName = fileStream.Name;
                var UploadConfig = await agent.Upload.GetUploadConfiguration(FileName, fileStream.Length, folderKey: null, actionOnDuplicate: MediaFireActionOnDuplicate.Replace);
                var uploadDetails = await agent.Upload.Simple(UploadConfig, fileStream);
                do
                {
                    if (uploadDetails.IsComplete && uploadDetails.IsSuccess)
                    {
                        break;
                    }
                    await Task.Delay(1000);
                    uploadDetails = await agent.Upload.PollUpload(uploadDetails.Key);
                } while (true);
                return uploadDetails.IsComplete && uploadDetails.IsSuccess;
            }
        }

        public async Task<MediaFireLinkCollection> GetLinks(string quickKey, MediaFireLinkType linkType = MediaFireLinkType.All)
        {
            var res = await agent.GetAsync<MediaFireGetLinksResponse>(MediaFireApiFileMethods.GetLinks, new Dictionary<string, object>
    {
        {MediaFireApiParameters.QuickKey, quickKey},
        {MediaFireApiParameters.LinkType, linkType.ToApiParameter()},
    });

            var col = new MediaFireLinkCollection(res.Links)
            {
                DirectDownloadFreeBandwidth = res.DirectDownloadFreeBandwidth,
                OneTimeDownloadRequestCount = res.OneTimeDownloadRequestCount,
                OneTimeKeyRequestCount = res.OneTimeKeyRequestCount,
                OneTimeKeyRequestMaxCount = res.OneTimeKeyRequestMaxCount
            };

            return col;
        }
    }
}
