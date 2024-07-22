namespace AccessLayerMdS.Models
{
    /// <summary>
    /// Represents the answer of the data sending calls of the access layer.
    /// </summary>
    public class ResultSingleRecord
    {
        public bool isValidato { get; set; }
        public EsitiValidazione esitiValidazione { get; set; }
        public string nomeTracciato { get; set; }
        public string idRun { get; set; }
        public string idClient { get; set; }
        public string xmlOutputPath { get; set; }

        public string ToLog()
        {
            string log = "";

            //log += $"idRun: {idRun} \n";
            log += $"idClient: {idClient} \n";
            log += $"isValidato: {isValidato} \n";
            log += $"nomeTracciato: {nomeTracciato} \n";
            log += $"xmlOutputPath: {xmlOutputPath} \n";

            if (esitiValidazione != null)
                log += esitiValidazione.ToLog();

            return log;
        }
    }
}
