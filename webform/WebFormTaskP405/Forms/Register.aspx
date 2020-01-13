<%@ Page MasterPageFile="~/Template.Master" Title="Register Page" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebFormTaskP405.Forms.Register" %>

<asp:Content runat="server" ContentPlaceHolderID="head">
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="body">
    <div class="form-label-group">
        <label for="Name">Name</label>
        <input type="text" runat="server" id="txbx_name" name="Name" class="form-control" />
        <asp:RequiredFieldValidator CssClass="text-danger" Display="Dynamic" ErrorMessage="Name is not valid" ID="name_error" runat="server" ControlToValidate="txbx_name"></asp:RequiredFieldValidator>
    </div>
    <div class="form-label-group">
        <label for="Surname">Surname</label>
        <input type="text" runat="server" id="txbx_surname" name="Surname" class="form-control" />
        <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Surname is not valid" Display="Dynamic" ID="surname_error" runat="server" ControlToValidate="txbx_surname"></asp:RequiredFieldValidator>
    </div>

    <div class="form-label-group">
        <label for="Email">Email</label>
        <input type="email" runat="server" id="txbx_email" name="Email" class="form-control"/>
        <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Email is not valid" Display="Dynamic" ID="email_error" runat="server" ControlToValidate="txbx_email"></asp:RequiredFieldValidator>
    </div>
    <div class="form-label-group">
        <label for="Password">Password</label>
        <input runat="server" id="txbx_password" type="password" name="Password" class="form-control" />
        <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Password is not valid" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ControlToValidate="txbx_password"></asp:RequiredFieldValidator>
    </div>
    <hr class="my-4">
    <asp:ValidationSummary CssClass="text-danger" runat="server" ShowValidationErrors="true" />
    <asp:Button CssClass="btn btn-lg btn-info btn-block" Text="Register" runat="server" OnClick="register_btn_Click" ID="register_btn" />
    <a href="Login.aspx" class="btn btn-lg btn-block btn-secondary">Login</a>
    <hr class="my-4">
</asp:Content>


