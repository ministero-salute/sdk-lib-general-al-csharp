using System;
using System.Collections.Generic;

namespace AccessLayerMdS.Models
{
    /// <summary>
    /// Represents the response of the single operation previously sent.
    /// </summary>
    public class ResultGetInfo
    {
        public string idRun { get; set; }
        public string idClient { get; set; }
        public List<string> idUploads { get; set; }
        public string tipoElaborazione { get; set; }
        public string modOperativa { get; set; }
        public DateTime? dataInizioEsecuzione { get; set; }
        public DateTime? dataFineEsecuzione { get; set; }
        public string statoEsecuzione { get; set; }
        public string fineAssociatiRun { get; set; }
        public string nomeFlusso { get; set; }
        public int numeroRecord { get; set; }
        public int numeroRecordAccettati { get; set; }
        public int numeroRecordScartati { get; set; }
        public string version { get; set; }
        public DateTime? timestampCreazione { get; set; }
        public string utenza { get; set; }
        public string api { get; set; }
        public string identificativoSoggettoAlimentante { get; set; }
        public string tipoAtto { get; set; }
        public string numeroAtto { get; set; }
        public string tipoEsitoMds { get; set; }
        public DateTime? dataRicevutaMds { get; set; }
        public string codiceRegione { get; set; }
        public string annoRiferimento { get; set; }
        public string periodoRiferimento { get; set; }
        public string nomeFileOutputMds { get; set; }
        public string esitoAcquisizioneFlusso { get; set; }
        public string codiceErroreInvioFlusso { get; set; }
        public string testoErroreInvioFlusso { get; set; }

        public string ToLog()
        {
            string log = "";

            log += $"idRun: {idRun} \n";
            log += $"idClient: {idClient} \n";

            if(idUploads != null)
            {
                log += $"idUploads: \n";
                log += String.Join(Environment.NewLine, idUploads);
            }

            log += $"tipoElaborazione: {tipoElaborazione} \n";
            log += $"modOperativa: {modOperativa} \n";
            if (dataInizioEsecuzione.HasValue)
                log += $"dataInizioEsecuzione: {dataInizioEsecuzione} \n";
            if (dataFineEsecuzione.HasValue)
                log += $"dataFineEsecuzione: {dataFineEsecuzione} \n";
            log += $"statoEsecuzione: {statoEsecuzione} \n";
            log += $"fineAssociatiRun: {fineAssociatiRun} \n";
            log += $"nomeFlusso: {nomeFlusso} \n";
            log += $"numeroRecord: {numeroRecord} \n";
            log += $"numeroRecordAccettati: {numeroRecordAccettati} \n";
            log += $"version: {version} \n";
            if (timestampCreazione.HasValue)
                log += $"timestampCreazione: {timestampCreazione} \n";
            log += $"utenza: {utenza} \n";
            log += $"api: {api} \n";
            log += $"identificativoSoggettoAlimentante: {identificativoSoggettoAlimentante} \n";
            log += $"tipoAtto: {tipoAtto} \n";
            log += $"numeroAtto: {numeroAtto} \n";
            log += $"tipoEsitoMds: {tipoEsitoMds} \n";
            if (dataRicevutaMds.HasValue)
                log += $"dataRicevutaMds: {dataRicevutaMds} \n";
            log += $"codiceRegione: {codiceRegione} \n";
            log += $"annoRiferimento: {annoRiferimento} \n";
            log += $"periodoRiferimento: {periodoRiferimento} \n";
            log += $"nomeFileOutputMds: {nomeFileOutputMds} \n";
            log += $"esitoAcquisizioneFlusso: {esitoAcquisizioneFlusso} \n";
            log += $"codiceErroreInvioFlusso: {codiceErroreInvioFlusso} \n";
            log += $"testoErroreInvioFlusso: {testoErroreInvioFlusso} \n";

            return log;
        }
    }
}
