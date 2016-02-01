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
    public partial class _Default : Page
    {
     

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            //Designate variable to get ahold of the Masterpage controls
            ContentPlaceHolder MpContentPlaceHolder;
            //Set variables for each of the Masterpage textboxs' so they can each be addressed.
            TextBox MpCustomerVaultIdTextBox;
            TextBox MpBillingAddressFirstNameTextBox;
            TextBox MpBillingAddressLastNameTextBox;
            TextBox MpBillingAddressAddressTextBox;
            TextBox MpBillingAddressAddress2TextBox;
            TextBox MpBillingAddressCityTextBox;
            TextBox MpBillingAddressStateTextBox;
            TextBox MpBillingAddressZipTextBox;
            TextBox MpBillingAddressCountryTextBox;
            TextBox MpBillingAddressPhoneTextBox;
            TextBox MpBillingAddressEmailTextBox;


            ContactDetails PayerInformation = new ContactDetails();
            AddressDetails address = new AddressDetails();
            AddPaymentProfileRequest requestDetails = new AddPaymentProfileRequest();

            MpContentPlaceHolder = (ContentPlaceHolder)Master.FindControl("MainContent");

            if (MpContentPlaceHolder != null)
            {
                MpCustomerVaultIdTextBox = (TextBox)MpContentPlaceHolder.FindControl("CustomerVaultId"); //In web payments this ID is the same as PaymentProfileID
                MpBillingAddressFirstNameTextBox = (TextBox)MpContentPlaceHolder.FindControl("BillingAddressFirstName");
                MpBillingAddressLastNameTextBox = (TextBox)MpContentPlaceHolder.FindControl("BillingAddressLastName");
                MpBillingAddressAddressTextBox = (TextBox)MpContentPlaceHolder.FindControl("BillingAddressAddress");
                MpBillingAddressAddress2TextBox = (TextBox)MpContentPlaceHolder.FindControl("BillingAddressAddress2");
                MpBillingAddressCityTextBox = (TextBox)MpContentPlaceHolder.FindControl("BillingAddressCity");
                MpBillingAddressStateTextBox = (TextBox)MpContentPlaceHolder.FindControl("BillingAddressState");
                MpBillingAddressZipTextBox = (TextBox)MpContentPlaceHolder.FindControl("BillingAddressZip");
                MpBillingAddressCountryTextBox = (TextBox)MpContentPlaceHolder.FindControl("BillingAddressCountry");
                MpBillingAddressPhoneTextBox = (TextBox)MpContentPlaceHolder.FindControl("BillingAddressPhone");
                MpBillingAddressEmailTextBox = (TextBox)MpContentPlaceHolder.FindControl("BillingAddressEmail");

                if (MpBillingAddressFirstNameTextBox != null && MpBillingAddressCityTextBox != null)
                {
                    //Trouble shooting code allowed me to make sure that I was grabbing the correct data.
                    /*
                           string text = MpCustomerVaultIdTextBox.Text + 
                               MpBillingAddressFirstNameTextBox.Text + 
                               MpBillingAddressLastNameTextBox.Text +
                                MpBillingAddressAddressTextBox.Text + 
                                MpBillingAddressCityTextBox.Text + 
                                MpBillingAddressStateTextBox.Text + 
                                MpBillingAddressZipTextBox.Text +
                                MpBillingAddressCountryTextBox.Text + 
                                MpBillingAddressPhoneTextBox.Text + 
                                MpBillingAddressEmailTextBox.Text;
                           Response.Redirect("YouSubmitted.aspx?text=" + text);
                      */

                    //Address data of customer paying the bill


                    address.FirstName = MpBillingAddressFirstNameTextBox.Text;
                    address.LastName = MpBillingAddressLastNameTextBox.Text;
                    address.StreetAddress1 = MpBillingAddressAddressTextBox.Text;

                    if (MpBillingAddressAddress2TextBox.Text == null)
                        address.StreetAddress2 = "";
                    else
                        address.StreetAddress2 = MpBillingAddressAddress2TextBox.Text;

                    address.City = MpBillingAddressCityTextBox.Text;
                    address.State = MpBillingAddressStateTextBox.Text;
                    address.PostalCode = MpBillingAddressZipTextBox.Text;
                    address.Country = MpBillingAddressCountryTextBox.Text;

                    PayerInformation.AddressInfo = address; //Set the payers contact information in the Cntact details construct
                    //Phone numbe profileId and email of customer paying the bill  Set the other information in the contact details construct.
                    PayerInformation.EmailAddress = MpBillingAddressEmailTextBox.Text;
                    PayerInformation.PhoneNumber = MpBillingAddressPhoneTextBox.Text;
                    PayerInformation.Id = MpCustomerVaultIdTextBox.Text;

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


    }//Close public partial class _default

}//Close namespace