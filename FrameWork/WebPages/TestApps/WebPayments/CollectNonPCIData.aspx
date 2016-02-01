<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CollectNonPCIData.aspx.cs" Inherits="WebPayments.CollectNonPCIData" Async="true"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="CustomerDetails" runat="server" method="post">
    <div>
         <br />
        PaymentProfileID <br /><asp:TextBox ID="PaymentProfileId" runat="server" ToolTip="Enter 411 if you want, to add a new customer vault ID.  Leave blank for single payment or creation of profile a a later point"></asp:TextBox>
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
    </div>
    </form>
</body>
</html>
