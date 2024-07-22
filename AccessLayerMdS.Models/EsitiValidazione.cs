using System.Collections.Generic;

namespace AccessLayerMdS.Models
{
    /// <summary>
    /// Represents the answer of validation.
    /// </summary>
    public class EsitiValidazione
    {
        public string idRun { get; set; }
        public List<Esito> esiti { get; set; }

        public string ToLog()
        {
            string log = "";

            log += $"idRun: {idRun} \n";

            if (esiti != null)
            {
                foreach (Esito e in esiti)
                    log += e.ToLog();
            }

            return log;
        }
    }
}
