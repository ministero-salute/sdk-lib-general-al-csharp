using System;
using System.Collections.Generic;
using System.Text;

namespace AccessLayerMdS.Models.Interfaces
{
    /// <summary>
    /// A generic Core logic for interfacing with API Gateway.
    /// </summary>
    public interface IAccessLayer
    {
        /// <summary>
        /// Sending processing of the entire flow.
        /// </summary>
        /// <param name="path">Path of the csv file that represents the stream to be processed.</param>
        /// <returns>Containing the <see cref="ResultSingleRecord"/> result of operation.</returns>
        ResultSingleRecord SendFlux(string path);
        /// <summary>
        /// Sending processing of the single record.
        /// </summary>
        /// <param name="record">The <see cref="IRecord"/> single record to be processed.</param>
        /// <returns>Containing the <see cref="ResultSingleRecord"/> result of operation.</returns>
        ResultSingleRecord SendSingleRecord<R>(R record) where R : IRecord;
        /// <summary>
        /// Gets information about a previously submitted processing.
        /// </summary>
        /// <param name="IdOp">Identification of the operation to be verified.</param>
        /// <returns>Containing the <see cref="ResultGetInfo"/> result of operation.</returns>
        ResultGetInfo GetInfo(int IdOp);
    }
}
