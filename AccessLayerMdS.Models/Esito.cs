using System.Collections.Generic;

namespace AccessLayerMdS.Models
{
    /// <summary>
    /// Represents the answer of validation.
    /// </summary>
    public class Esito
    {
        public string campo { get; set; }
        public bool valoreEsito { get; set; }
        public List<ErroreValidazione> erroriValidazione { get; set; }

        public string ToLog()
        {
            string log = "";

            log += $"   campo: {campo} \n";
            log += $"   valoreEsito: {valoreEsito} \n";

            if (erroriValidazione != null)
            {
                foreach (ErroreValidazione e in erroriValidazione)
                    log += e.ToLog();
            }

            return log;
        }
    }
}
