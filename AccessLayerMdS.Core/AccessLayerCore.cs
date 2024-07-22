using AccessLayerMdS.Models;
using AccessLayerMdS.Models.Interfaces;
using System;
using System.IO;
using System.Net;
using System.Text.Json;

namespace AccessLayerMdS.Core
{
    /// <summary>
    /// A generic Core logic for interfacing with API Gateway.
    /// </summary>
    public abstract class AccessLayerCore
    {
        protected string RemotePath { get; set; }
        protected string FluxName { get; set; }
        private string ENDPOINT_FLUX = "/v1/flusso/{nomeFlusso}";
        private string ENDPOINT_SINGLE_RECORD = "/v1/flusso/{nomeFlusso}/record";
        private string ENDPOINT_GET_INFO = "/v1/flusso/{nomeFlusso}/info";
        private bool LogEnabled = false;
        private string FileLog = "Log.txt";

        public AccessLayerCore(string fluxName)
        {
            FluxName = fluxName;
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
        //public void Init(string host, string fileLog)
        //{
        //    RemotePath = host;
        //    FileLog = fileLog;
        //}

        /// <summary>
        /// Sending processing of the entire flow.
        /// </summary>
        /// <param name="IdClient">Identification of the operation client side.</param>
        /// <param name="path">Path of the csv file that represents the stream to be processed.</param>
        /// <param name="mod">Operative mode.</param>
        /// <param name="annoRiferimento">Anno Riferimento.</param>
        /// <param name="periodoRiferimento">Periodo Riferimento.</param>
        /// <param name="codiceRegione">Codice Regione.</param>
        /// <returns>Containing the <see cref="ResultFlux"/> result of operation.</returns>
        public ResultFlux SendFlux(
            int IdClient, 
            string path, 
            ModOp mod, 
            string annoRiferimento,
            string periodoRiferimento,
            string codiceRegione)
        {

            if (string.IsNullOrEmpty(RemotePath))
                throw new Exception("Access Layer not initialized!");

            ResultFlux result = new ResultFlux();

            try
            {
                RequestFlux request = new RequestFlux()
                {
                    idClient = IdClient,
                    nomeFile = path,
                    modalitaOperativa = mod == ModOp.Test ? "T" : "P",
                    annoRiferimento = annoRiferimento,
                    periodoRiferimento = periodoRiferimento,
                    codiceRegione = codiceRegione
                };

                string json = JsonSerializer.Serialize(request);

                ENDPOINT_FLUX = ENDPOINT_FLUX.Replace("{nomeFlusso}", FluxName);

                InsLog("SendFlux", $"host: {RemotePath + ENDPOINT_FLUX}");
                InsLog("SendFlux", $"json: {json}");

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(RemotePath + ENDPOINT_FLUX);
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                //httpWebRequest.Headers.Add("Authorization", "Bearer " + AccessToken);

                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if (httpResponse != null && httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        using (var reader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var objText = reader.ReadToEnd();
                            
                            InsLog("SendFlux", $"Response: {objText}");

                            result = JsonSerializer.Deserialize<ResultFlux>(objText);
                        }
                    }
                    else
                        result.isIniziato = false;
                }
            }
            catch (Exception excep)
            {
                throw excep;
            }

            return result;
        }

        /// <summary>
        /// Sending processing of the single record.
        /// </summary>
        /// <param name="IdClient">Identification of the operation client side.</param>
        /// <param name="record">The <see cref="IRecord"/> single record to be processed.</param>
        /// <param name="mod">Operative mode.</param>
        /// <param name="annoRiferimento">Anno Riferimento.</param>
        /// <param name="periodoRiferimento">Periodo Riferimento.</param>
        /// <param name="codiceRegione">Codice Regione.</param>
        /// <returns>Containing the <see cref="ResultSingleRecord"/> result of operation.</returns>
        protected ResultSingleRecord SendSingleRecord<R>(
            int IdClient, 
            R record, 
            ModOp mod,
            string annoRiferimento,
            string periodoRiferimento,
            string codiceRegione) where R : IRecord
        {

            if (string.IsNullOrEmpty(RemotePath))
                throw new Exception("Access Layer not initialized!");

            ResultSingleRecord result = new ResultSingleRecord();

            try
            {
                RequestSingleRecord<R> request = new RequestSingleRecord<R>()
                {
                    idClient = IdClient.ToString(),
                    modalitaOperativa = mod == ModOp.Test ? "T" : "P",
                    recordDto = record,
                    annoRiferimento = annoRiferimento,
                    periodoRiferimento = periodoRiferimento,
                    codiceRegione = codiceRegione
                };

                string json = JsonSerializer.Serialize(request);

                ENDPOINT_SINGLE_RECORD = ENDPOINT_SINGLE_RECORD.Replace("{nomeFlusso}", FluxName);

                InsLog("SendSingleRecord", $"host: {RemotePath + ENDPOINT_SINGLE_RECORD}");
                InsLog("SendSingleRecord", $"json: {json}");

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(RemotePath + ENDPOINT_SINGLE_RECORD);
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                //httpWebRequest.Headers.Add("Authorization", "Bearer " + AccessToken);

                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if (httpResponse != null && httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        using (var reader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var objText = reader.ReadToEnd();

                            InsLog("SendSingleRecord", $"Response: {objText}");

                            result = JsonSerializer.Deserialize<ResultSingleRecord>(objText);
                        }
                    }
                    else 
                        result.isValidato = false;
                }
            }
            catch (Exception excep)
            {
                throw excep;
            }

            return result;
        }

        /// <summary>
        /// Gets information about a previously submitted processing.
        /// </summary>
        /// <param name="IdClient">Identification of the operation client side.</param>
        /// <param name="IdRun">Identification of the operation to be verified.</param>
        /// <returns>Containing the <see cref="ResultGetInfo"/> result of operation.</returns>
        public ResultGetInfo GetInfo(int IdClient, int IdRun)
        {

            if (string.IsNullOrEmpty(RemotePath))
                throw new Exception("Access Layer not initialized!");

            ResultGetInfo result = new ResultGetInfo();

            try
            {
                if (IdClient == 0 && IdRun == 0)
                    return result;

                string url = ENDPOINT_GET_INFO.Replace("{nomeFlusso}", FluxName);

                if (IdClient != 0 && IdRun != 0)
                    url += $"?idClient={IdClient}&idRun={IdRun}";
                else if (IdClient != 0)
                    url += $"?idClient={IdClient}";
                else if (IdRun != 0)
                    url += $"?idRun={IdRun}";

                InsLog("GetInfo", $"host: {RemotePath + url}");

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

                                InsLog("GetInfo", $"Response: {objText}");

                                result = JsonSerializer.Deserialize<ResultGetInfo>(objText);
                            }
                        }
                    }
                    //else
                    //    result.Error = true;
                }
            }
            catch (Exception excep)
            {
                throw excep;
            }

            return result;
        }

        protected void InsLog(string caller, string msg)
        {
            if (!LogEnabled)
                return;

            string Data = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();

            string log = $"{Data} - {caller} - {msg} \n";
            try
            {
                using (FileStream os = new FileStream(FileLog, FileMode.Append, FileAccess.Write))
                {
                    os.Write(StrToByteArray(log), 0, StrToByteArray(log).Length);
                    os.Flush();
                }
            }
            catch
            {

            }
        }
        private byte[] StrToByteArray(string str)
        {
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            return encoding.GetBytes(str);
        }
    }
}
