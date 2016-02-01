<%@ Page Async="true" Title="Step One Gather NON PCI data" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPayments._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" Method="POST">

    <div class="jumbotron">
        <h1>Gather NON PCI data</h1>
        <p class="lead">WebPaymenst is a series of Restful servicves that enable an agency to quickly accept Internet Paymenst without getting mired in PCI compliance details.</p>
        <p><a href="http://www.acela.com/WebPayments" class="btn btn-primary btn-lg">Learn more (goes to accela.com/WebPayments) &raquo;</a></p>
    </div>

        <div>
            <h2>Getting started</h2>
            <p>
               So lets collect the customers non sensitive data and make a call to the webpayments API.
            </p>
        </div>
    <p>
        <br />
        PaymentProfileID <br /><asp:TextBox ID="CustomerVaultId" runat="server" ToolTip="Enter 411 if you want, to add a new customer vault ID.  Leave blank for single payment or creation of profile a a later point"></asp:TextBox>
        <br />
        <h3>Enter card holder details First and last as they appear on the card.  Billing address of the card.</h3> 
        <br />
        First Name <br /><asp:TextBox ID="BillingAddressFirstName" runat="server"></asp:TextBox>
        <br />
        Last Name <br /><asp:TextBox ID="BillingAddressLastName" runat="server"></asp:TextBox>
        <br />
        Address <br /><asp:TextBox ID="BillingAddressAddress" runat="server"></asp:TextBox>
         <br />
        Address <br /><asp:TextBox ID="BillingAddressAddress2" runat="server"></asp:TextBox>
        <br />
        City <br /><asp:TextBox ID="BillingAddressCity" runat="server" ></asp:TextBox>
        <br />
        State/Province <br /><asp:TextBox ID="BillingAddressState" runat="server" ></asp:TextBox>
        <br />
        Zip/Postal <br /><asp:TextBox ID="BillingAddressZip" runat="server" ></asp:TextBox>
        <br />
        Country  <br /><asp:TextBox ID="BillingAddressCountry" runat="server" ></asp:TextBox>
        <br />
        Phone Number <br /><asp:TextBox ID="BillingAddressPhone" runat="server"></asp:TextBox>
        <br />
        Email Address <br /><asp:TextBox ID="BillingAddressEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button" runat="server" Text="Submit NON-PCI Data" OnClick="SubmitButton_Click" />
    </p>
</asp:Content>
