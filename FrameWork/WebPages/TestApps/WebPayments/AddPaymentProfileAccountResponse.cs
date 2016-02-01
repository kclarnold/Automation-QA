// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace WebPayments.Client.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class AddPaymentProfileAccountResponse
    {
        /// <summary>
        /// Initializes a new instance of the AddPaymentProfileAccountResponse
        /// class.
        /// </summary>
        public AddPaymentProfileAccountResponse() { }

        /// <summary>
        /// Initializes a new instance of the AddPaymentProfileAccountResponse
        /// class.
        /// </summary>
        public AddPaymentProfileAccountResponse(string gatewayPostUrl = default(string), bool? success = default(bool?), string errorMessage = default(string), string errorCode = default(string))
        {
            GatewayPostUrl = gatewayPostUrl;
            Success = success;
            ErrorMessage = errorMessage;
            ErrorCode = errorCode;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GatewayPostUrl")]
        public string GatewayPostUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Success")]
        public bool? Success { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ErrorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ErrorCode")]
        public string ErrorCode { get; set; }

    }
}