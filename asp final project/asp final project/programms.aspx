<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="programms.aspx.cs" Inherits="asp_final_project.programms" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            width: 40px;
        }
        .style3
        {
            width: 111px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


<table align="right"   >
<tr>
<td>
<asp:Button ID="searchbtn" Text="Search" runat="server" onclick="searchbtn_Click" />
</td>
<td>
<asp:TextBox ID="searchtxt" runat="server"></asp:TextBox>
</td>
</tr>
</table>


<br />
<br />



<table border="2" align="center" >

<tr>
<td class="style2">Id</td>
<td>Date</td>
<td>Course</td>
<td>Duration</td>
<td>Monthly Fee</td>
<td>Admission Fee</td>
<td class="style3">Teacher</td>
<td>Timing</td>
</tr>

<tr>
<td class="style2">
<asp:TextBox ID="id2" runat="server" Width="60px"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="datetxt2" runat="server" Width="113px"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="coursetxt2" runat="server" Width="117px"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="durationtxt2" runat="server" Width="100px"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="monfeetxt2" runat="server" Width="88px"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="addfetxt2" runat="server" Width="91px"></asp:TextBox>
</td>
<td class="style3">
<asp:TextBox ID="teachertxt2" runat="server" Width="120px"></asp:TextBox>
</td>
<td>
<asp:TextBox ID="timingtxt2" runat="server" Width="106px"></asp:TextBox>
</td>
</tr>
</table>
<br />
<table align="center">
<tr>
<td colspan="2" > 
<asp:Button ID="Updatebtn" Text="Update" runat="server" Width="124px" 
        onclick="Updatebtn_Click" />
</td>

<td> 
<asp:Button ID="deletebtn" Text="Delete" runat="server" Width="126px" 
        onclick="deletebtn_Click" />
</td>

<td> 
<asp:Button ID="Refresbtn" Text="Refresh" runat="server" Width="126px" 
        onclick="Refresbtn_Click" />
        
</td>


</tr>

</table>
<hr  />



 
 <h1 style="font-family: Georgia; font-size: xx-large;" align="center">
Register Program
</h1>
<br />

<table align="center">
<tr>
<td colspan="2" align="center">
<asp:Calendar ID="datecal" runat="server" 
        onselectionchanged="datecal_SelectionChanged"></asp:Calendar>
</td>
</tr>
</table>
<br />
<table align="center" border="2">
<tr>
<td>
<asp:Label ID="datelbl" Text="Date :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="datetxt" runat="server"></asp:TextBox>
</td>

</tr>

<tr>
<td>
<asp:Label ID="Courselbl" Text="Course :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="coursetxt" runat="server"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="durationlbl" Text="Duration :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="durationtxt" runat="server"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="monfeelbl" Text="Monthly Fees :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="monfeetxt" runat="server"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="admisinlbl" Text="Admission Fees :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="addmisiontxt" runat="server"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="teacherlbl" Text="Teacher :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="teachertxt" runat="server"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="timingslbl" Text="Timings :" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="timingstxt" runat="server"></asp:TextBox>
</td>
</tr>


<tr>
<td colspan="2" align="center">
<asp:Button ID="registerbtn" Text="Register" runat="server" 
        onclick="registerbtn_Click" />
</td>
</tr>

</table>
<hr />
<br />



<table border="3" align="center"       >
<asp:Label ID="viewlbl" runat="server" style="margin-left: 0px" Width="293px"   ></asp:Label>
</table>





</asp:Content>

