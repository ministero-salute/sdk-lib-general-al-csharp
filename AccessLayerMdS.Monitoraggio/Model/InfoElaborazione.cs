using System;
using System.Collections.Generic;
using System.Text;

namespace AccessLayerMdS.Monitoraggio.Model
{
    public class InfoElaborazione
    {
        public string idTransazione { get; set; }
        public string idUpload { get; set; }
        public string idRun { get; set; }
        public string nomeFlusso { get; set; }
        public string timestampElaborazione { get; set; }
        public string version { get; set; }
        public string utenza { get; set; }
        public string esitoElaborazioneMds { get; set; }
        public string codiceErroreElaborazioneMds { get; set; }
        public string testoErroreElaborazioneMds { get; set; }
        public string validationPath { get; set; }
        public string statoDownloadFus { get; set; }
        public string esitoDownloadFus { get; set; }
        public string descrizioneErroreDownload { get; set; }
        public string codiceErroreDownloadFus { get; set; }
    }
}
