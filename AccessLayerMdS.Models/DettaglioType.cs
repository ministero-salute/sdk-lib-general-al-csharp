using System.Collections.Generic;

namespace AccessLayerMdS.Models
{
    public class DettaglioType
    {
        public List<string> linea { get; set; }

        public string ToLog()
        {
            string log = "";

            if (linea != null)
            {
                foreach (string e in linea)
                    log += $"   linea: {e} \n";
            }

            return log;
        }
    }
}
