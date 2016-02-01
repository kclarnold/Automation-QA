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
    public partial class AddressDetails
    {
        /// <summary>
        /// Initializes a new instance of the AddressDetails class.
        /// </summary>
        public AddressDetails() { }

        /// <summary>
        /// Initializes a new instance of the AddressDetails class.
        /// </summary>
        public AddressDetails(string firstName = default(string), string lastName = default(string), string streetAddress1 = default(string), string streetAddress2 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string country = default(string))
        {
            FirstName = firstName;
            LastName = lastName;
            StreetAddress1 = streetAddress1;
            StreetAddress2 = streetAddress2;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
        }

        /// <summary>
        /// A  that contains the first name of the contact associated with
        /// this address.
        /// </summary>
        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// A  that contains the last name of the contact associated with this
        /// address.
        /// </summary>
        [JsonProperty(PropertyName = "LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// A  that contains the first line of address.
        /// </summary>
        [JsonProperty(PropertyName = "StreetAddress1")]
        public string StreetAddress1 { get; set; }

        /// <summary>
        /// A  that contains the second line of address.
        /// </summary>
        [JsonProperty(PropertyName = "StreetAddress2")]
        public string StreetAddress2 { get; set; }

        /// <summary>
        /// A  that contains the city related to that address.
        /// </summary>
        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }

        /// <summary>
        /// A  that contains the state related to that address.
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// A  that contains the postal code related to that address.
        /// </summary>
        [JsonProperty(PropertyName = "PostalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// A  that contains the country related to that address.
        /// </summary>
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }

    }
}