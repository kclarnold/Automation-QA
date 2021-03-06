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
    public partial class BaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the BaseResponse class.
        /// </summary>
        public BaseResponse() { }

        /// <summary>
        /// Initializes a new instance of the BaseResponse class.
        /// </summary>
        public BaseResponse(bool? success = default(bool?), string errorMessage = default(string), string errorCode = default(string))
        {
            Success = success;
            ErrorMessage = errorMessage;
            ErrorCode = errorCode;
        }

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
