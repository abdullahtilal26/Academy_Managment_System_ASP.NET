<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="fee form.aspx.cs" Inherits="asp_final_project.fee_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


<h1>Fee Payment</h1>
<asp:Button  ID="serachbtn" Text="Search" runat="server" 
        onclick="serachbtn_Click" />
<asp:TextBox ID="searchtxt" runat="server"></asp:TextBox>

<br />
<hr />

<table>
<tr>
<td colspan="2">
<asp:Calendar ID="dat_calender" runat="server" 
        onselectionchanged="dat_calender_SelectionChanged"></asp:Calendar>
</td>
</tr>

<tr>
<td>
Date
</td>
<td>
<asp:TextBox ID="datetxt" runat="server" ontextchanged="datetxt_TextChanged"></asp:TextBox>
</td>
</tr>

<tr>
<td>
Student Name
</td>
<td>
<asp:TextBox ID="std_nametxt" runat="server"></asp:TextBox>
</td>
</tr>

<tr>
<td>
Father Name
</td>
<td>
<asp:TextBox ID="father_name" runat="server"></asp:TextBox>
</td>
</tr>

<tr>
<td>
Course
</td>
<td>
<asp:TextBox ID="coursetxt" runat="server"></asp:TextBox>
</td>
</tr>

<tr>
<td>
Advance
</td>
<td>
<asp:TextBox ID="advancetxt" runat="server"></asp:TextBox>
</td>
</tr>

<tr>
<td>
Amount
</td>
<td>
<asp:TextBox ID="amounttxt" runat="server"></asp:TextBox>
</td>
</tr>

<tr align="center">
<td colspan="2">
<asp:Button ID="paybtn" Text="Pay" runat="server" Font-Size="Larger" Height="34px" 
        onclick="paybtn_Click" Width="95px" />
</td>
</tr>
</table>
</asp:Content>
