<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="asp_final_project.student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 3px;
        }
        .style2
        {
            width: 179px;
        }
        .style3
        {
            width: 136px;
        }
        .style4
        {
            width: 114px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


<table align="right">
<tr>
<td>
<asp:Button ID="searchbtn" Text="Search" runat="server" 
        onclick="searchbtn_Click1" />
</td>
<td>
<asp:TextBox ID="searchnametxt" runat="server" 
        ontextchanged="searchnametxt_TextChanged">
Name</asp:TextBox>
</td>
<td>
<asp:TextBox ID="searchf_nametxt" runat="server">Father Name</asp:TextBox>
</td>
</tr>
</table>
<br />
<br />

<table border="3" align="center">
<tr>
<td class="style1">Id</td>
<td>Date</td>
<td>Name</td>
<td>F.Name</td>
<td class="style3">Address</td>
<td class="style2">Image</td>
</tr>


<tr>
<td class="style1">
<asp:TextBox ID="idtxt2"  runat="server" Width="56px"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="dattxt2" runat="server" Width="78px"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="nametxt2" runat="server" Width="126px"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="f_nametxt2" runat="server"></asp:TextBox>
</td>
<td class="style3">
<asp:TextBox ID="adresstxt2"  runat="server" Width="139px"></asp:TextBox>
</td>
<td class="style2">
<asp:FileUpload ID="imgupld2" runat="server" Width="217px" />
</td>
<td>
<asp:Label  ID="imgshowlbl" runat="server"></asp:Label>
</td>
</tr>

</table>


<table border="3" align="center"> 
<tr>
<td>Qualification</td>
<td>Course</td>
<td>Advance</td>
<td>Cell</td>
<td>Leaving Date</td>
<td class="style4">Remarks</td>
</tr>

<tr>
<td>
<asp:TextBox ID="qualitxt2" runat="server" Width="105px"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="coursetxt2" runat="server" Width="83px"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="advancetxt2"  runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="celtxt2"  runat="server"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="leavingdattxt2" runat="server"></asp:TextBox>
</td>
<td class="style4">
<asp:TextBox ID="remarkstxt2" runat="server" Width="110px"></asp:TextBox>
</td>

</tr>
</table>


<table align="center">
<tr >
<td colspan="2">
<asp:Button ID="updatebtn" Text="Update" runat="server" Height="26px" 
        onclick="updatebtn_Click" Width="101px" />
</td>

<td>
<asp:Button ID="Deletebtn" Text="Delete" runat="server" onclick="Deletebtn_Click" 
        Width="102px" />
</td>

<td>
<asp:Button ID="refreshbtn" Text="Refresh" runat="server" 
        onclick="refreshbtn_Click" Width="92px" />
</td>

</tr>
</table>

<hr size="4" noshade="noshade" style="color: #174F67; background-color: #174F67;" />



<h1 style="font-family: Georgia; font-size: xx-large" align="center">
Register Student
</h1>
<br />


<table align="center">
<tr>
<td colspan="3" align="center">
<asp:Calendar ID="datecal" runat="server" 
        onselectionchanged="datecal_SelectionChanged"></asp:Calendar>
</td>
</tr>
</table>
<br>

<table border="2" align="center">

<tr>
<td>
<asp:Label ID="datlbl" Text="Date" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="dattxt" runat="server" Width="170px" 
        ontextchanged="dattxt_TextChanged"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="namelbl" Text="Name :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="nametxt" runat="server" Width="170px"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="f_namelbl" Text="F.Name :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="f_nametxt" runat="server" Width="170px"></asp:TextBox>
</td>
</tr>




<tr>
<td>
<asp:Label ID="adresstlbl" Text="Address :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="adrestxt" runat="server" Width="170px"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="imglbl" Text="Image" runat="server"></asp:Label>
</td>
<td>
<asp:FileUpload ID="imgupload" runat="server" />
</td>
</tr>


<tr>
<td>
<asp:Label ID="qualilbl" Text="Qualification :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="qualitxt" runat="server" Width="170px"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="courselbl" Text="Course :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="coursetxt" runat="server" Width="170px"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="advancelbl" Text="Advance :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="advancetxt" runat="server" Width="170px"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="celllbl" Text="Cell :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="celltxt" runat="server" Width="170px"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="leave_datlbl" Text="Leaving Date :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="leavedattxt" runat="server" Width="170px"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="remarkslbl" Text="Remarks :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="remarkstxt" runat="server" Width="170px"></asp:TextBox>
</td>
</tr>

<tr>
<td colspan="2" align="center">
<asp:Button ID="registerbtn" Text="Register" runat="server" Font-Bold="True" 
        Font-Names="Georgia" Font-Size="Large" Width="90px" Height="28px" 
        onclick="registerbtn_Click" />
</td>

</tr>

</table>

<hr />
<br />




<table align="center" border="4" >


<asp:Label ID="viewlbl" runat="server"></asp:Label>


</table>










</asp:Content>
