<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Presentation Layer/Header.Master" CodeBehind="SignUp.aspx.cs" Inherits="auto_insurance.Presentation_Layer.SignUp" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="position: relative; margin-top: 60px;width:px; margin-left: 20px;padding-top:20px;padding-bottom:20px; border-style: ridge;" class="col-md-6 mb-md-0 mb-6">

        <form>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="inputEmail4">Username</label>
                    <asp:TextBox class="form-control" placeholder="Username" ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                <div class="form-group col-md-6">
                    <label for="inputPassword4">Password</label>
                    <asp:TextBox class="form-control" placeholder="Password" ID="TextBox2" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="inputEmail4">Email</label>

                    <asp:TextBox class="form-control" placeholder="Email" ID="TextBox3" runat="server"></asp:TextBox>
                </div>
                <div class="form-group col-md-6">
                    <label for="inputPassword4">Mobile Number</label>
                    <asp:TextBox class="form-control" placeholder="Mobile Number" ID="TextBox5" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="inputEmail4">Date Of birth</label>

                    <asp:TextBox class="form-control" type="Date" placeholder="Date Of Birth" ID="TextBox6" runat="server"></asp:TextBox>
                </div>
                <div class="form-group col-md-6">
                    <label for="inputEmail4">Gender</label>
                    <asp:DropDownList ID="DropDownList1" class="form-control" runat="server">
                        <asp:ListItem>Choose..</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>


            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="inputEmail4">Security Questions</label>
                    <asp:DropDownList ID="DropDownList4" class="form-control" runat="server">
                        <asp:ListItem>Choose..</asp:ListItem>
                        <asp:ListItem>Which is your Birth City</asp:ListItem>
                        <asp:ListItem>Who was Your Childhood Hero</asp:ListItem>
                        <asp:ListItem>Which is your Birth State</asp:ListItem>
                        <asp:ListItem>What was the name of your elementary school</asp:ListItem>
                        <asp:ListItem>What was your favourite toy as a child </asp:ListItem>
                        <asp:ListItem>which is your favourite destination place</asp:ListItem>
                        <asp:ListItem>Which is your favourite book</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group col-md-6">
                    <label for="inputEmail4">Security Answer</label>
                    <asp:TextBox class="form-control" placeholder="Security Answer" ID="TextBox7" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-md-3">
                    <label for="inputCity">State</label>
                    <asp:TextBox class="form-control" placeholder="" ID="TextBox10" runat="server"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <label for="inputCity">City</label>
                    <asp:TextBox class="form-control" placeholder="City" ID="TextBox4" runat="server"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <label for="inputState">Zip Code</label>
                    <asp:TextBox class="form-control" placeholder="Zip Code" ID="TextBox8" runat="server"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <label for="inputZip">Country</label>
                    <asp:TextBox class="form-control" placeholder="Country" ID="TextBox9" runat="server"></asp:TextBox>
                </div>
            </div>
        </form>
        <asp:Button ID="Button2" class="btn btn-primary" runat="server" OnClick="Button2_Click"  Text="Sign Up" />
    </div>
    


        
   


</asp:Content>
