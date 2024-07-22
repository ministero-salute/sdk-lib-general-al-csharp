using AccessLayerMdS.Models.Interfaces;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AccessLayerMdS.DIR
{
    public class Record : IRecord
    {
        public string RegioneErogante { get; set; }
        public int AnnoDiRiferimento { get; set; }
        public int MeseDiRiferimento { get; set; }
        public string CodiceAziendaSanitariaErogante { get; set; }
        public int TipoErogatore { get; set; }
        public string TipoStrutturaErogante { get; set; }
        public string CodiceStrutturaErogante { get; set; }
        public string IdentificativoAssistito { get; set; }
        public int ValiditaCodIdentAssistito { get; set; }
        public int TipologiaCodIdentAssistito { get; set; }
        public string DataNascitaAssistito { get; set; }
        public string SessoAssistito { get; set; }
        public string AslAssistito { get; set; }
        public int Cittadinanza { get; set; }
        public string StatoEsteroDiResidenza { get; set; }
        public string CodiceIstituzioneCompetente { get; set; }
        public string TipoOperazione { get; set; }
        public string TipoCanale { get; set; }
        public string CodiceEsenzione { get; set; }
        public int TipoErogazione { get; set; }
        public int TipoDiEsenzione { get; set; }
        public int TipoContatto { get; set; }
        public string IdContatto { get; set; }
        public string DataErogazione { get; set; }
        public string QuotaFissaAssistito { get; set; }
        public string QuotaPercentualeAssistito { get; set; }
        public string DataPrescrizione { get; set; }
        public string CostoServizioRicetta { get; set; }
        public string CodicePrescrittore { get; set; }
        public string TipoPrescrittore { get; set; }
        public int TipoFarmaco { get; set; }
        public string CodiceFarmaco { get; set; }
        public string Quantita { get; set; }
        public int FattoreDiConversione { get; set; }
        public string Targatura { get; set; }
        public string CostoAcquisto { get; set; }
        public string CostoServizio { get; set; }

        //public string ToJSON()
        //{
        //    return JsonSerializer.Serialize(this);
        //}
    }
}
