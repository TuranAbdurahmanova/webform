<%@ Page MasterPageFile="~/Template.Master" Title="Login Page" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormTaskP405.Forms.Login" %>

<asp:Content runat="server" ContentPlaceHolderID="head">
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="body">
    <div class="form-label-group">
        <label for="Email">Email address</label>
        <input type="email" runat="server" id="txbx_email" name="Email address" class="form-control" />
        <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Email duzgun daxil edin" ID="error_email" runat="server" ControlToValidate="txbx_email"></asp:RequiredFieldValidator>
    </div>
    <div class="form-label-group">
        <label for="Password">Password</label>
        <input runat="server" id="txbx_password" type="password" name="Password" class="form-control" />
        <asp:RequiredFieldValidator ErrorMessage="Password duzgun daxil edin" ID="error_password" runat="server" ControlToValidate="txbx_password" CssClass="text-danger"></asp:RequiredFieldValidator>
    </div>
    <hr class="my-4">
        <asp:ValidationSummary CssClass="text-danger" runat="server"/>
    <asp:Button CssClass="btn btn-lg btn-info btn-block" Text="Login" runat="server" OnClick="login_btn_Click" ID="btn_login" />
    <a href="Register.aspx" class="btn btn-lg btn-block btn-secondary">Register</a>
    <hr class="my-4">
</asp:Content>


