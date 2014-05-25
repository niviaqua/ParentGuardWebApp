<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterPhone.aspx.cs" Inherits="ParentGuardWebApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Register Phone</h2>
    <p>The IMEI no. can be accessed by dialing <b>*#06#</b> from the device</p>
     <br/>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="IMEI" CssClass="col-md-2 control-label">IMEI</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="IMEI" CssClass="form-control"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="IMEI"
                    CssClass="text-danger" ErrorMessage="The IMEI field is required." />
            </div>
        </div>
        
        <div class="form-group">
           
            <asp:Label runat="server" AssociatedControlID="ChildName" CssClass="col-md-2 control-label">Child's Name</asp:Label>
            <div class="col-md-10">
               
                <asp:TextBox runat="server" ID="ChildName" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ChildName"
                    CssClass="text-danger" ErrorMessage="The child name is required." />
            </div>
            
        </div>
      <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="Save_Click" Text="Save" CssClass="btn btn-default" />
            </div>
        </div>

</asp:Content>
