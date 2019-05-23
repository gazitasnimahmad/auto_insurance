<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Presentation Layer/Header.Master" CodeBehind="ForgotPassword.aspx.cs" Inherits="auto_insurance.Presentation_Layer.ForgotPassword" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-left: 400px; margin-bottom: 150px; margin-right: 400px; margin-top: 30px; padding-left: 120px; padding-right: 120px; padding-top: 30px; padding-top: 30px;">
        <form class="form-signin">
            <img class="mb-4" src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAASIAAACuCAMAAAClZfCTAAAAbFBMVEX///8VfcEAcr0Adr4Aeb8Ac73s9fofgMIAd78AcLy0zeVzqNT7/v8Le8DT5PHm8fi91epFkcqCsNiSutxUmM2uy+VrpNLK3e49jchenc+av9/0+fyKtts0icbh7PW40uh6rNakxeLZ5/NkoNCjH8seAAAJjElEQVR4nO2deZuqIBTGryxqJWllWpba8v2/440Dto0L6Thi8vtr7jPU4HvhwFnAf/8MBoPBYDAYDAaDwWAwGAwGg8FgMPwGhziJVg6ezWaI7a7HPBu6Q5qxPKYz7BLGLA5jhGBEotwbul+6YG8sSoQ4z7CbTFE8dOd0IIuQ+1MfCaFpMHQHh8aOELmPGoIpRQhReptz97FE02mPpIRKLZhLyX4zX2a+7WeXIIkchItfof1h6H4Ohr/Dcj6hNLm8/dLe7qmcgQTng/RveHI5Tgg9vesjOCQOZmIgLf64b3pwREwItK6ZR3NLDDR3N8HJFlFhjfd+fbuNMFfEaWj3fVxhdBC32cpIi8XYxDSKsJg+tkrjNRIaKTX+Fo4wy2ik2HwOZos4E3JIchgWdK38gZiCRmGPfdKLjH6oUKER3vTWJ81I+eO6qrNMEMDAQ8ueuqQZG26qye7DTyV86DGnlx7pho/AJ/t4K3glk5lqe/6o9PMYhwfbbDqBlX/JBxG5tvhkDJ+cgLcWwiBq5XHB+ENfP4wyPhTcdhbF5xabfLJXGCUnMLott8mL24cZ/t0ODUx8jnYW4lmfKIlBFo/H8cmx5ffBnvOL4mvBlVKZ92GMuBSFt2cL+J4ItfbZuSH7GjfkzOg9RF+kM7CbRPwZV62/dQ4Kf4U3uyW4LPHDCFiibevvPcBM+4K8kb+irNAEUw4mT0Oqy+4PZtr417RAhu0ZRqtjvsz8bBlsQlokfawuftbZvX3vp+6ddiQibM/obvu8QfTyUEahTx2+fMlnGurYw6E5yrD96mcS9RLyCUjbm6Kb0HznScddNZIgsXiV6xAwTLuFVx0u0ahT2CLyRdIqi3zYdqyICVmnJXF4fFjK3B43dzxq5J77+/7e2ZG+o/DcxyMjjqudwRVP1Rp7dpb5HwdF1uOWyONbaoabd4ZefAwding1Edudtp+4bCOXaOPy5Wbe1CyOMCVF5R7j9XqvO6haeDzETbr1c0Ag0NHko+bpD//2NvLwUVGk/ajNNbjhtD7TtUzpw79lTz+6WO25IQeHTyMtpeEuJqsfRGtUzC+XB5N4dSOWU47hnYpNskRRkkJFiYaAb1AbEjwUhXuYrpLY9viqdtkuCC2q1RSiHKKk5ObgfJbM1QMIKNKavXPGiBguzvl1nsTSwWWz5snmXWWJrVu5g9eXTUPQNBMzirCSJS+TESaksFbZC1kBSEZXk7WvX45toRCtSBXmIkw5U3G/slTUrY1Oo7Q+ZuoQMCGVtspOYQLNlGo/jjPQyBrZwsZHSXUkJ3LBDN0FuCR7h2AnXD9EBQePEaXHjkXd2sjij/w/tjKbDEESRov66q2DXHIbBXxvTdfFh4QTvFf6axcsNkgdO/23oDqJYBFCcsQsHfy8tyZU+lyeY6kHzJaiJmtU0bW6UZRwTbBMwm5m7wkkvBKzCxL+qmVWomByVDVZ4MOW2yJIUzMZJDlROXh4/kgeGSKO0AgK2KpN+itr/hfxOFxaO9hEqxSGQ/m4P+PHnBDhf4s6x+ByWZ5DJIvzxZ6TTzXlJJDDlM37oHjbHc8kCpe0wgfnvqfcVcrgtnNfyPwraCatdA5ilp+a+UFMxzCMvM1Larq8+gxMjLDCMOUs/NJsDjtrJKYX+6RyBMq5NLdGAXvN3Zev2Il7N8JHbj/e64kDKIa1RAPysFqNQOJR75TRScY2GHHxDUJmpd19JOJf7PYDseDBMLrAU6t6qDCDT2273z/eCst9DdsneRzPN+ty7wHfDTmYGvrT1KSPeCWfacq1H2dXfZMwBMKpYjRseCAoURQFoNeKaICw0tCkwRsu+2pt89dgKy2cNvqdfOGR/9V8mS6Lunn4blS4MVKvHHYsjSv7jjDLVM668CEiArZQQUXLQhhcb5GH3uJPkpU8IdK6dLJnlhCOQCoxeXhoWOrgbAMpC0w+kqwBboyAP8EXy1Z17n8AnzIWVcpagESwznPTwVhZm3VLiaC1niGROaSm1ULsbxJZZW3aSrSk2i5p4B5ZanUwvUtU+o1DA8EaVY98mhKdPnGO+pQo1nai8e2I8v6uT4m0Ndc2BGFVN7V9SqTtoh/zxyCqrfuUKNJ16/jZDrhPibR1QGB4n1Rb9yhRpq0bq41EibbBEG0k0jekdv5oHelPoljfwCyUEimP7/4kWukb3gcriVQTWPO+JBJJIk1rQ7H6Wuv5UJu1vyyXS3h8xn964wL7m9PtNxewwLtMRX/IS5aGnzSgKgb9gzwkMt0KhxtFsLuERxtXtkk3TWmQBdF4EKkmTZdO2eWxajCX1juBW82vosFMYRhtUVt9BLTuD4Ah0rl4BrKqDecTg5kcD22AT+Lqcix5LZbGJ4kP0MOSpOEDW+Syseu0QJ7yrwyO56KQr/2J/z/gLOo5ampWwZoSp+UpxsuemztWcbvIUVxj6OhdOAPbNuZWJhoP8Ihp+yUZyrFKF6zLSIqKDyJdjarOhon0fZeHWJUvCX4kS9MtzRXiNRzC1jjlRhsSz53igeDmvF/FE+zvBxz0nmWA1OhmkBd59mNCLTofHBPh3/s/PT8+73Fxk8RIrnfOHNlfgimavQFb38YTjnXYomy4+EJ0Lx69aU/GcrWKd63fHP6GRCWQ2VpTx6yMuOQYZ78S8XL/EVihZ4JwhqscsV+WiL/jYRZuRzSCCuxtlCL+dooXfssW3b+YIic8BiMbQM/Y/is2jwDVSpRHqRMmNXsbkIg+vvHX+zw0i3qJYnjJDnFRdZ7wbdH/PuolymeFgaGV3ryQaISWR5VaibLZwwjTqnE0bYmEDyy3ylWO3KQl8vkgYmkew6n7qhtnJy3RHBenpKKaPMGkJYKEN/ihcU3SctISQcIbVjLIrFUcHJq0REGRiz9A3UJFVGnSEnniRSD7BWQ6qi6FmrRE8gBJcRVWRaNpS/TPebyMsTJbOHGJDvL9eRZB1beITFsiHv4Xb2KqLlScvERiva/L2huJ8qbKZCORkchI1IiRqBEjUSNGokaMRI00S0SNRA0SHfg1LHUNjET/siisrW43EjViJGrESNSIkagRI1Ejk5Co26sWvl6iY+fXKkLMzf2t/mhIUHGznDo7pnxv8TiBV8tYHU5pLNzOpYC6A7fkMnJudQzhEMONiOq3bowSeUjE/VEoqgIVOSTVK5LGStzxUONtmo3jFEMHYlRTtt7MWM55dMLfodbHhwn+blN9J16QNqYIURqO+YWMH3Kw2zB0rw0Gg8FgMBgMBoPBYDAYDAaDwWD4S/4DrPp912sxFFUAAAAASUVORK5CYII=" style="margin-left: 40px;" alt="" width="150" height="150">
            <h1 class="h3 mb-3 font-weight-normal">Set your password</h1>
            <label for="inputEmail" class="sr-only">Email address</label>
            <asp:TextBox ID="TextBox1" type="email" Style="margin-bottom: 1px;" runat="server" class="form-control" placeholder="Email address" required autofocus ></asp:TextBox>

            <div style="padding-left: 0px; padding-right: 0px;margin-bottom:1px;" class="form-group">

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
            <asp:TextBox ID="TextBox4" type="text" Style="margin-bottom: 5px;" runat="server" class="form-control" placeholder="Your Answer" required autofocus Visible="true"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Check" class="btn btn-lg btn-danger btn-block" type="submit" OnClick="Button2_Click" />
            <asp:TextBox ID="TextBox2" Style="margin-bottom: 1px;" class="form-control" placeholder="New password" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="TextBox3"  Style="margin-bottom: 5px;" class="form-control" placeholder="Confirm password" runat="server" Visible="False"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Change" class="btn btn-lg btn-primary btn-block" type="submit" Visible="False" />
        </form>
    </div>
</asp:Content>
