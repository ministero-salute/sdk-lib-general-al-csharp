using AccessLayerMdS.Models.Interfaces;

namespace AccessLayerMdS.Models
{
    /// <summary>
    /// Represents object of the request SendSingleRecord.
    /// </summary>
    public class RequestSingleRecord<R> where R : IRecord
    {
        public string idClient { get; set; }
        public string modalitaOperativa { get; set; }
        public R recordDto { get; set; }
        public string annoRiferimento { get; set; }
        public string periodoRiferimento { get; set; }
        public string codiceRegione { get; set; }
    }
}
