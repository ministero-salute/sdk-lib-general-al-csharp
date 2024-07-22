namespace AccessLayerMdS.Models
{
    /// <summary>
    /// Represents the answer of the data sending calls of the access layer.
    /// </summary>
    public class ResultFlux
    {
        public bool isIniziato { get; set; }
        public string descrizioneErrore { get; set; }
        public string idrun { get; set; }
        public string idClient { get; set; }

        public string ToLog()
        {
            string log = "";

            log += $"isIniziato: {isIniziato} \n";
            log += $"descrizioneErrore: {descrizioneErrore} \n";
            log += $"idrun: {idrun} \n";
            log += $"idClient: {idClient} \n";

            return log;
        }
    }
}
