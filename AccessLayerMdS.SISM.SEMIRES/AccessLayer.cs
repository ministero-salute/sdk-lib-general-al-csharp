using AccessLayerMdS.Core;
using AccessLayerMdS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessLayerMdS.SISM.SEMIRES
{
    /// <summary>
    /// A Core logic for interfacing with API Gateway for flux SISM.SEMIRES.
    /// </summary>
    public class AccessLayer : AccessLayerCore
    {
        public AccessLayer() : base("sism-semires")
        {
        }

        /// <summary>
        /// Sending processing of the single record.
        /// </summary>
        /// <param name="IdClient">Identification of the operation client side.</param>
        /// <param name="record">The <see cref="Record"/> single record to be processed.</param>
        /// <param name="mod">Operative mode.</param>
        /// <param name="annoRiferimento">Anno Riferimento.</param>
        /// <param name="periodoRiferimento">Periodo Riferimento.</param>
        /// <param name="codiceRegione">Codice Regione.</param>
        /// <returns>Containing the <see cref="ResultSingleRecord"/> result of operation.</returns>
        public ResultSingleRecord SendSingleRecord(
            int IdClient,
            Record record,
            ModOp mod,
            string annoRiferimento,
            string periodoRiferimento,
            string codiceRegione)
        {
            return base.SendSingleRecord(IdClient, record, mod, annoRiferimento, periodoRiferimento, codiceRegione);
        }
    }
}
