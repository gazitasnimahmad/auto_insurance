<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Presentation Layer/Header.Master" CodeBehind="Login.aspx.cs" Inherits="auto_insurance.Presentation_Layer.Login" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div style="margin-left:400px;margin-bottom:140px; margin-right:400px;margin-top:30px;padding-left:120px;padding-right:120px;padding-top:30px;padding-top:30px;">
        <form class="form-signin">
            <img class="mb-4" src="https://www.bankbazaarinsurance.com/images/common/car-insurance-landing-img.png" style="margin-left:90px;" alt  ="" width="100" height="100">
            <h1 class="h3 mb-3 font-weight-normal">Please sign in</h1>
            <label for="inputEmail" class="sr-only">Email address</label>
            <asp:TextBox ID="TextBox1" type="email" style="margin-bottom:1px;" runat="server" class="form-control" placeholder="Email address" required autofocus></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" type="password" style="margin-bottom:1px;"  class="form-control" placeholder="Password" required></asp:TextBox>
            <label for="inputPassword" class="sr-only">Password</label>
            <asp:DropDownList ID="DropDownList1" style="margin-bottom:8px;" class="form-control" runat="server">
                <asp:ListItem>Choose Your Role</asp:ListItem>
                        <asp:ListItem>User</asp:ListItem>
                        <asp:ListItem>Insurance Officer</asp:ListItem>
                        <asp:ListItem>Claim Officer</asp:ListItem>
                        <asp:ListItem>Assessor</asp:ListItem>
            </asp:DropDownList>
            
            <div class="checkbox mb-3">
                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Forget Password</asp:LinkButton>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Sign in" class="btn btn-lg btn-primary btn-block" type="submit" OnClick="Button1_Click" />
           
        </form>

    </div>
</asp:Content>
