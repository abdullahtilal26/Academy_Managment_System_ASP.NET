<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="asp_final_project.welcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<div id="background"  >


<h1 align="center" style="font-family: Gabriola; font-size: xx-large; text-decoration: blink">
WELCOME
</h1>

<br />
<br />
<br />


<table align="center">
<tr>
<td colspan="7" align="center">
<asp:Button ID="progrmbtn" Text="Programms" runat="server"  align="left"
        onclick="progrmbtn_Click" BackColor="#336699" BorderStyle="Inset" 
        Font-Bold="True" Font-Names="Georgia" Font-Size="XX-Large" Height="56px" 
        Width="233px" />

</td>

 
     
<td>

<asp:Button ID="studentsbtn" Text="Students" runat="server"  align="center" 
        BackColor="#336699" BorderStyle="Inset" Font-Bold="True" Font-Names="Georgia" 
        Font-Size="XX-Large" Height="56px" Width="218px" 
        onclick="studentsbtn_Click" />

</td>
</tr>

     


</table>

</div>
</asp:Content>
