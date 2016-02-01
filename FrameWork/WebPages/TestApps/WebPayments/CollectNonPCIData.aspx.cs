using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.IO;
using WebPayments.Client;
using WebPayments.Client.Models;
using System.Net.Http;
using Microsoft.Rest.Serialization;
using System.Text;
using System.Net.Http.Headers;

namespace WebPayments
{
    public partial class CollectNonPCIData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {

            ContactDetails PayerInformation = new ContactDetails();
            AddressDetails address = new AddressDetails();
            AddPaymentProfileRequest requestDetails = new AddPaymentProfileRequest();
          

            if (string.Format("{0}", Request.Form["BillingAddressFirstName"]) != null)
            {

                if (string.Format("{0}", Request.Form["BillingAddressCity"]) != null)
                {
                    
                    //Address data of customer paying the bill


                    address.FirstName = string.Format("{0}", Request.Form["BillingAddressFirstName"]);
                    address.LastName = string.Format("{0}", Request.Form["BillingAddressLastName"]);
                    address.StreetAddress1 = string.Format("{0}", Request.Form["BillingAddressAddress"]);

                    if (string.Format("{0}", Request.Form["BillingAddressAddress2"]) == null)
                        address.StreetAddress2 = "";
                    else
                        address.StreetAddress2 = string.Format("{0}", Request.Form["BillingAddressAddress2"]);

                    address.City = string.Format("{0}", Request.Form["BillingAddressCity"]);
                    address.State = string.Format("{0}", Request.Form["BillingAddressState"]);
                    address.PostalCode = string.Format("{0}", Request.Form["BillingAddressZip"]);
                    address.Country = string.Format("{0}", Request.Form["BillingAddressCountry"]);

                    PayerInformation.AddressInfo = address; //Set the payers contact information in the Cntact details construct
                    //Phone numbe profileId and email of customer paying the bill  Set the other information in the contact details construct.
                    PayerInformation.EmailAddress = string.Format("{0}", Request.Form["BillingAddressPhone"]);
                    PayerInformation.PhoneNumber = string.Format("{0}", Request.Form["BillingAddressEmail"]);
                    PayerInformation.Id = string.Format("{0}", Request.Form["PaymentProfileId"]);

                    //Set the value of Account holder details
                    requestDetails.AccountHolderDetails = PayerInformation;
                    //Agency data
                    requestDetails.ProfileName = ""; //TODO figure out where this comes from
                    //This is the final page in the sequence so you want to indicate success or failure clearly page needs to process URI provided data.
                    requestDetails.ResponsePostUrl = "https://http://accela-sf-kla.cloudapp.net/testapps/YouSubmitted.aspx";
                    //This is an account Identifier that should be unique to your implementation.
                    requestDetails.PaymentGatewayAccountIdentifier = "";
                    //This should Identify who is submitting the payment for the client
                    requestDetails.PaymentProcessor = "";

                    requestDetails.UserToken = ""; //TODO figure out how to pupulate this locally
                    requestDetails.GatewayName = "NMI";
                    //The only payment gateway currently supported is NMI

                    //Currently hardcoded  TODO expose on form and put in a default value; 
                    //implementers should hardcode their agency Identifier and retrieve application ID from the application.
                    requestDetails.ApplicationIdentifier = "00000001";
                    requestDetails.AgencyIdentifier = "00000001";

                    WebPaymentsClient client = new WebPaymentsClient();
                    PaymentProfile AddPaymentProfile = new PaymentProfile(client);


                    AddPaymentProfile.AddPaymentProfileByRequest(requestDetails);

                }
                else
                { Response.Redirect("YouSubmitted.aspx?text=NOTHING"); }
            }
            else
            { Response.Redirect("YouSubmitted.aspx?text=Masterpage content Not Found"); }
        }//close button submit

    }
}