<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MasterFooter.aspx.cs" Inherits="auto_insurance.Presentation_Layer.MasterFooter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />

    <title></title>
</head>
<body>
    <form style="background-color: #2196f3;" id="form1" runat="server">
        <!-- Footer -->
        <footer class="page-footer font-small blue pt-4">

            <!-- Footer Links -->
            <div class="container-fluid text-center text-md-left">

                <!-- Grid row -->
                <div class="row">

                    <!-- Grid column -->
                    <div class="col-md-6 mt-md-0 mt-3">

                        <!-- Content -->
                        <h5 class="text-uppercase">Footer Content</h5>
                        <p style="color: white;">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting.</p>


                    </div>
                    <!-- Grid column -->

                    <hr class="clearfix w-100 d-md-none pb-3">
                    <div class="col-md-2 mb-md-0 mb-2">
                        </div>
                    <!-- Grid column -->
                    <div class="col-md-2 mb-md-0 mb-2">

                        <!-- Links -->


                        <ul class="list-unstyled">
                            <li>
                                <asp:LinkButton Style="color:yellow;" ID="LinkButton5" runat="server">Home &nbsp &nbsp &nbsp</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton Style="color:yellow;" ID="LinkButton6" runat="server">Login &nbsp &nbsp &nbsp</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton Style="color:yellow;" ID="LinkButton7" runat="server">Track Your Claim &nbsp &nbsp &nbsp</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton Style="color:yellow;" ID="LinkButton8" runat="server">Contact Us &nbsp &nbsp &nbsp</asp:LinkButton>
                            </li>
                        </ul>

                    </div>

                      <div class="col-md-2 mb-md-0 mb-2">

                        <!-- Links -->


                        <ul class="list-unstyled">
                            <li>
                                <asp:LinkButton Style="color:yellow;" ID="LinkButton1" runat="server">About Us &nbsp &nbsp &nbsp</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton Style="color:yellow;" ID="LinkButton2" runat="server">FAQ &nbsp &nbsp &nbsp</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton Style="color:yellow;" ID="LinkButton3" runat="server">Why Us &nbsp &nbsp &nbsp</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton Style="color:yellow;" ID="LinkButton4" runat="server">Assure Insurance &nbsp &nbsp &nbsp</asp:LinkButton>
                            </li>
                        </ul>

                    </div>

                    <!-- Grid colu
      
      <!-- Grid column -->

                </div>
                <!-- Grid row -->

            </div>
            <!-- Footer Links -->

            <!-- Copyright -->
            <div style="background-color: #1a78c2; color: white;" class="footer-copyright text-center py-3">
                © 2019 Copyright:
    <a style="background-color: #1a78c2; color: white;" href="#">www.assureinsurance.com</a>
            </div>
            <!-- Copyright -->

        </footer>
        <!-- Footer -->
    </form>
</body>
</html>
