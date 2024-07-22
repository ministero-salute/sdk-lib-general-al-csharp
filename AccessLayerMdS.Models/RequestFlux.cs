namespace AccessLayerMdS.Models
{
    /// <summary>
    /// Represents object of the request SendFlux.
    /// </summary>
    public class RequestFlux
    {
        public int idClient { get; set; }
        public string nomeFile { get; set; }
        public string modalitaOperativa { get; set; }
        public string annoRiferimento { get; set; }
        public string periodoRiferimento { get; set; }
        public string codiceRegione { get; set; }
    }
}
