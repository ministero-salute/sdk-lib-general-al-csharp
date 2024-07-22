namespace AccessLayerMdS.Models
{
    /// <summary>
    /// Represents the single error.
    /// </summary>
    public class ErroreValidazione
    {
        public string codice { get; set; }
        public string descrizione { get; set; }

        public string ToLog()
        {
            string log = "";

            log += $"       codice: {codice} \n";
            log += $"       descrizione: {descrizione} \n";

            return log;
        }
    }
}
