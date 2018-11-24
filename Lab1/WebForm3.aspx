<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Lab1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="sds" runat ="server"></asp:SqlDataSource>  
             <Center>
                <asp:Label ID="Label1" runat="server" Text="СЦ &quot;МобТехСаппорт&quot;" Font-Size="22pt"></asp:Label>
                <br />
                <br />
              <asp:TextBox ID="texBox" runat="server" Text ="Соместимость" Width="258px" OnTextChanged="texBox_TextChanged" />
                 <asp:Button ID="FILTR" runat = "server" OnClick="texBox_TextChanged" />
                 <br />
                 <br />
             <asp:GridView ID="GvSOVM" runat="server" Font-Size="12"  Caption="СОВМЕСТИМОСТЬ ПО" style="margin-left: 1px; margin-top: 0px" OnLoad="GvSOVM_Load" Height="186px" Width="276px" OnSelectedIndexChanged="GvSOVM_SelectedIndexChanged">
                 <Columns>
                       <asp:CommandField ShowSelectButton="true" />
                   </Columns>
             </asp:GridView>
              <br />          
            </Center>
            <asp:TextBox ID="textvvod" runat="server" Font-Size="13pt" text="введите значение"/>
            <asp:Button runat="server" Text="Добавить" id="add" OnClick="add_Click"/>
            <asp:Button runat="server" Text="Удалить" id="delete" OnClick="delete_Click"/>
            <asp:Button runat="server" Text="обновить" id="update" OnClick="update_Click"/>
        </div>
    </form>
</body>
</html>
