<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="asp_final_project._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2 >
        LOGIN
    </h2>
  <table style="width: 303px">
  <tr>
  <td >
  <asp:Label id="userlbl" text="USER NAME" runat="server"></asp:Label>
  </td>
  <td>
  <asp:TextBox ID="userrtxt" runat="server"></asp:TextBox>
  </td>
  </tr>


  <tr>
  <td>
  <asp:Label id="pwdlbl" Text="Password" runat="server"></asp:Label>
  </td>
  <td>
  <asp:TextBox ID="pwdtxt"  TextMode="Password" runat="server"></asp:TextBox>
  </td>
  </tr>
   

   <tr >
   <td colspan="2"  align="center">
   <asp:Button ID="loginbtn" Text="Login" runat="server" onclick="loginbtn_Click" />
   <asp:Button ID="adminbtn" Text="Admin" runat="server" onclick="adminbtn_Click" />
   &nbsp
   </td>
   </tr>
  </table>
  <%-- <login closed>--%>


   <hr  style="background-color:#174F67"/>
  <br />

  <asp:Label ID="welcome_koreanlbl" Text="Welcome to KOREAN COMPUTER ACADEMY" 
        runat="server" Font-Bold="True" Font-Names="Georgia" Font-Size="Large"></asp:Label>

  <br />
  <br />
  <asp:Label ID="infolbl" 
        Text="KCA was established in 1989 to enhance the organizational and individual effectiveness, KCA is a constellation of leading technologists, educationists and professionals. Guided by the noble mission of helping others in actualizing their limitless human potential utilizing advanced technologies.
An unparalleled faculty, conducive learning environment, lively classroom atmosphere, unmatched delegate resource person interaction, robust delegate-management relationship, and problem-solving demeanor, augmented with cutting-edge developments teaching and training methodologies, are the integral characteristics of KCA." 
        runat="server" Font-Bold="False" Font-Names="Ebrima" 
        Font-Size="Medium"></asp:Label>
 <br />
 <br />

 <table border="1" align="center">
 <tr>
 <td class="style1">
 <img src = "images for icons and for design/watching.jpg" 
         style="width: 910px; height: 480px" />
 </td>
 </tr>
 </table>
    



 </asp:Content>
