﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Lab1.WebForm5" %>

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
                 <asp:TextBox ID="SOVM" runat="server" Text="Лицензия" Height="16px" style="margin-left: 3px" Width="243px" />
               <br />
                <br />

             <asp:GridView ID="GvLIZ" runat="server" Font-Size="12" Caption="ЛИЦЕНЗИЯ" style="margin-left: 1px; margin-top: 0px" OnLoad="GvLIZ_Load" Height="155px" Width="268px">
              <Columns>
                       <asp:CommandField ShowSelectButton="true" />
                   </Columns>
             </asp:GridView>
              <br />          
            </Center>
            <asp:TextBox ID="textvvod" runat="server" Font-Size="13pt" text="введите значение"/>
            <asp:Button runat="server" Text="Добавить" id="add" OnClick="add_Click" style="height: 25px"/>
            <asp:Button runat="server" Text="Удалить" id="delete" OnClick="delete_Click"/>
            <asp:Button runat="server" Text="обновить" id="update" OnClick="update_Click"/>
           
        </div>
    </form>
</body>
</html>
