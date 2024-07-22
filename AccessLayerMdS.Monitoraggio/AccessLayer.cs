using AccessLayerMdS.Monitoraggio.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;

namespace AccessLayerMdS.Monitoraggio
{
    /// <summary>
    /// A Core logic for interfacing with API Gateway for flux Monitoraggio.
    /// </summary>
    public class AccessLayer
    {
        protected string RemotePath { get; set; }
        private string ENDPOINT = "/v1/monitoraggio/flussi";

        public AccessLayer()
        {
        }

        /// <summary>
        /// Init.
        /// </summary>
        /// <param name="host">Remote Path.</param>
        /// <returns></returns>
        public void Init(string host)
        {
            RemotePath = host;
        }

        /// <summary>
        /// Gets information about a previously submitted processing.
        /// </summary>
        /// <param name="IdsUpload">IdsUpload.</param>
        /// <param name="NomeFlusso">NomeFlusso.</param>
        /// <param name="IdRun">Identification of the operation to be verified.</param>
        /// <returns>Containing the <see cref="RisultatoElaborazione"/> result of operation.</returns>
        public RisultatoElaborazione GetInfo(List<string> IdsUpload, string NomeFlusso, int IdRun)
        {

            if (string.IsNullOrEmpty(RemotePath))
                throw new Exception("Access Layer not initialized!");

            RisultatoElaborazione result = new RisultatoElaborazione();

            try
            {
                if (IdsUpload == null || !IdsUpload.Any())
                    return result;

                string url = ENDPOINT;

                url += $"?idsUpload={string.Join(",", IdsUpload)}";

                if (!string.IsNullOrEmpty(NomeFlusso))
                    url += $"&nomeFlusso={NomeFlusso}";
                if (IdRun != 0)
                    url += $"&idRun={IdRun}";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(RemotePath + url);
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                //httpWebRequest.Headers.Add("Authorization", "Bearer " + AccessToken);

                httpWebRequest.Method = "GET";

                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if (httpResponse != null && httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        using (var stream = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            using (var reader = new StreamReader(httpResponse.GetResponseStream()))
                            {
                                var objText = reader.ReadToEnd();


                                result = JsonSerializer.Deserialize<RisultatoElaborazione>(objText);
                            }
                        }
                    }
                }
            }
            catch (Exception excep)
            {
                throw excep;
            }

            return result;
        }

    }
}
