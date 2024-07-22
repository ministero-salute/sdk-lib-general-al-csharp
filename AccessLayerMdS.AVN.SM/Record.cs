using AccessLayerMdS.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessLayerMdS.AVN.SM
{
    public class Record : IRecord
    {
        public string modalita { get; set; }
        public string tipoTrasmissione { get; set; }
        public string codRegione { get; set; }
        public string idAssistito { get; set; }
        public string tipoErogatore { get; set; }
        public string codStruttura { get; set; }
        public string codCondizioneSanitaria { get; set; }
        public string codCategoriaRischio { get; set; }
        public string codiceAICVaccino { get; set; }
        public string denomVaccino { get; set; }
        public string codTipoFormulazione { get; set; }
        public string viaSomministrazione { get; set; }
        public string lottoVaccino { get; set; }
        public string dataScadenza { get; set; }
        public string modalitaPagamento { get; set; }
        public string dataSomministrazione { get; set; }
        public string sitoInoculazione { get; set; }
        public string codiceComuneSomministrazione { get; set; }
        public string codiceAslSomministrazione { get; set; }
        public string codiceRegioneSomministrazione { get; set; }
        public string statoEsteroSomministrazione { get; set; }
        public string codiceAntigene { get; set; }
        public int dose { get; set; }
        public int validitaCI { get; set; }
        public int tipologiaCI { get; set; }
        public string sesso { get; set; }
        public string dataNascita { get; set; }
        public string codiceComuneResidenza { get; set; }
        public string codiceAslResidenza { get; set; }
        public string codiceRegioneResidenza { get; set; }
        public string statoEsteroResidenza { get; set; }
        public string dataTrasferimentoResidenza { get; set; }
        public string codiceComuneDomicilio { get; set; }
        public string codiceAslDomicilio { get; set; }
        public string codiceRegioneDomicilio { get; set; }
        public string cittadinanza { get; set; }
        public string dataDecesso { get; set; }
    }
}
