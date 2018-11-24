<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="Lab1.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <Center>
                <asp:Label ID="Label1" runat="server" Text="СЦ &quot;МобТехСаппорт&quot;" Font-Size="22pt"></asp:Label>
                <br />
                <br />
                 <asp:TextBox ID="SOVM" runat="server" Text="Состояние" Height="16px" style="margin-left: 3px" Width="243px" />
                <br />
                <br />
             
               
             
             
            
              <asp:GridView ID="GvSOST" runat="server" Font-Size="12"  Caption="СОСТОЯНИЕ" style="margin-left: 1px; margin-top: 0px" OnLoad="GvSOST_Load" Width="243px"></asp:GridView>
              <br />   
             
            </Center>
        </div>
    </form>
</body>
</html>
