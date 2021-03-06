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
    public partial class AddPaymentProfileRequest
    {
        /// <summary>
        /// Initializes a new instance of the AddPaymentProfileRequest class.
        /// </summary>
        public AddPaymentProfileRequest() { }

        /// <summary>
        /// Initializes a new instance of the AddPaymentProfileRequest class.
        /// </summary>
        public AddPaymentProfileRequest(ContactDetails accountHolderDetails = default(ContactDetails), string profileName = default(string), string responsePostUrl = default(string), string paymentGatewayAccountIdentifier = default(string), string paymentProcessor = default(string), string gatewayName = default(string), string userToken = default(string), string applicationIdentifier = default(string), string agencyIdentifier = default(string))
        {
            AccountHolderDetails = accountHolderDetails;
            ProfileName = profileName;
            ResponsePostUrl = responsePostUrl;
            PaymentGatewayAccountIdentifier = paymentGatewayAccountIdentifier;
            PaymentProcessor = paymentProcessor;
            GatewayName = gatewayName;
            UserToken = userToken;
            ApplicationIdentifier = applicationIdentifier;
            AgencyIdentifier = agencyIdentifier;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccountHolderDetails")]
        public ContactDetails AccountHolderDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProfileName")]
        public string ProfileName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsePostUrl")]
        public string ResponsePostUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PaymentGatewayAccountIdentifier")]
        public string PaymentGatewayAccountIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PaymentProcessor")]
        public string PaymentProcessor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GatewayName")]
        public string GatewayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserToken")]
        public string UserToken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ApplicationIdentifier")]
        public string ApplicationIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AgencyIdentifier")]
        public string AgencyIdentifier { get; set; }

    }
}
