<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="asp_final_project.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <table>
<tr>

<td>
<asp:Label  Font-Size="Large" ID="connlbl" Text="Connection" runat="server"></asp:Label>
</td>

<td>
<asp:TextBox ID="conntxt" runat="server" Width="760px">data source=; database=; uid=; password=;</asp:TextBox>
</td>

<td>
<asp:Button ID="connbtn" Text="Connect" runat="server" onclick="connbtn_Click" />
</td>

</tr>

</table>

<%--connection table close--%>



<hr size="4" style="background-color: #174F67; height: 5px;" />


<table align="right"   >
<tr>
<td>
<asp:Button ID="searchbtn" Text="Search" runat="server" 
        onclick="searchbtn_Click"  />
</td>
<td>
<asp:TextBox ID="searchtxt" runat="server"></asp:TextBox>
</td>
<td>
    &nbsp;</td>
</tr>
</table>
<br />
<br />

<table border="2" align="center" style="margin-right: 148px">
<tr>
<td >Id</td>
<td>User Name</td>
<td>Password</td>
</tr>

<tr>
<td><asp:TextBox ID="idtxt2" runat="server"></asp:TextBox></td>
<td><asp:TextBox ID="usertxt2" runat="server"></asp:TextBox></td>
<td><asp:TextBox ID="pwdtxt2" runat="server"></asp:TextBox></td>
</tr>
</table>

<table align="center" border="2">
<tr>
<td  colspan="3" align="center"><asp:Button ID="updatebtn" Text="Update" 
        runat="server" onclick="updatebtn_Click" /></td> 
<td><asp:Button ID="Deletebtn" Text="Delete" runat="server" 
        onclick="Deletebtn_Click" /></td>
<td><asp:Button ID="refreshbtn" Text="Refresh" runat="server" 
        onclick="refreshbtn_Click" /></td>
</tr>
</table>



<br />

<hr style="background-color: #174F67" />



&nbsp

<table align="left" border="2">
<tr>
<td colspan="2">
<asp:Label ID="creatuserlbl"   Font-Size="X-Large" Text="Create User" 
        runat="server" Font-Names="Georgia"></asp:Label>
</td>
</tr>
<tr>
<td>
<asp:Label ID="userrname" Text="User Name" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="userrnametxt" runat="server" 
        ontextchanged="userrnametxt_TextChanged"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="pwdlbl" Text="Password" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="pwdtxt"  TextMode="Password" runat="server" 
        ontextchanged="pwdtxt_TextChanged"></asp:TextBox>
</td>
</tr>

<tr>
<td colspan="2"  align="center">
<asp:Button ID="createuserrbtn" Text="Create User" runat="server" 
        onclick="createuserrbtn_Click" Width="88px" />
        
<asp:Button ID="showbtn" Text="Show Data" runat="server" onclick="showbtn_Click" 
        style="margin-left: 0px" />

</td>
</tr>
</table>

<%--------------------------------------------%>




<table align="right" border="2">
<tr>
<td colspan="2">
<asp:Label ID="Label1"   Font-Size="X-Large" Text="Restore Database" runat="server"   ></asp:Label>
</td>
</tr>

<tr>
<td colspan="1">
<asp:Label ID="restore_con_lbl" Text="Connection" runat="server"></asp:Label>
</td>
<td>
<asp:TextBox ID="restore_con_txt" runat="server" Font-Size="Small" Width="232px" 
        TextMode="MultiLine">data source=; database=; uid=; password=;</asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="restorlbl" Text="Select File" runat="server"></asp:Label>
</td>
<td>
<asp:FileUpload ID="selectupld"  runat="server"/>
</td>
</tr>


<%--<tr>
<td colspan="2" align="center">
    &nbsp;</td>
</tr>--%>
<tr>
<td colspan="2" align="center">
<asp:Button ID="restorebtn" Text="Restore" runat="server" 
        onclick="restorebtn_Click1" />
</td>
</tr>
</table>
<br />
<br />
<br />
<br />
<br />
<br />

<br />
<br />
<hr style="background-color: #174F67; height: 3px;" />
<br />

<%---------------------------------------------------------------------%>



<table align="center" border="2">
<asp:Label ID="viewlbl" runat="server"></asp:Label>

<%--<tr>
<td align="center" colspan="3">
<asp:Button ID="hidebtn" Text="Hide" runat="server" onclick="hidebtn_Click" />
</td></tr>--%>

</table>



















</asp:Content>
