using AccessLayerMdS.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessLayerMdS.AVN.NSM
{
    public class Record : IRecord
    {
        public string codIdAssistito { get; set; }
        public string modalita { get; set; }
        public string tipoTrasmissione { get; set; }
        public string codRegione { get; set; }
        public int validitaCI { get; set; }
        public int tipologiaCI { get; set; }
        public string sesso { get; set; }
        public string dataNascita { get; set; }
        public string codiceComuneResidenza { get; set; }
        public string codiceAslResidenza { get; set; }
        public string codiceRegioneResidenza { get; set; }
        public string statoResidenza { get; set; }
        public string dataTrasferimentoResidenza { get; set; }
        public string codiceComuneDomicilio { get; set; }
        public string codiceAslDomicilio { get; set; }
        public string codiceRegioneDomicilio { get; set; }
        public string cittadinanza { get; set; }
        public string dataDecesso { get; set; }
        public string codiceAntigene { get; set; }
        public int dose { get; set; }
        public string motivazione { get; set; }
        public string dataNonEffettuazione { get; set; }
    }
}
