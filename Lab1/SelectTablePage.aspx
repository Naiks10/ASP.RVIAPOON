<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectTablePage.aspx.cs" Inherits="Lab1.SelectTablePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

    <title></title>
</head>
<body style = "background-color:whitesmoke">
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Button type="button" class="btn btn-outline-info" style="margin-left: 10px" runat="server" id="back" Text="⮪ Назад" Width="103px"  Font-Size="Large" OnClick="back_Click" />
            <br />
            <br />
            <center>
                <asp:Label id="Label" runat="server" Text="Выбор таблиц" Font-Size="XX-Large" />
                <br />
                <br />
                <asp:Button type="button" class="btn btn-outline-primary" ID ="btDock" Text="Документы" runat="server" Height="59px" Width="266px"  Font-Names="Arial Black" style="margin-left: 0px"/>
                 <br />
                   <br />
                <asp:Button type="button" class="btn btn-outline-primary" ID ="btSOVM" Text="Совместимость ПО" runat="server" Height="59px" Width="266px" Font-Names="Arial Black" style="margin-left: 0px"/>
                <asp:Button type="button" class="btn btn-outline-primary" ID ="btSOVMK" Text="Совместимость Комплектующих" runat="server" Height="59px" Width="313px"  Font-Names="Arial Black"  style="margin-left: 0px" OnClick="btSOVMK_Click"/>
            <br />
                   <br />
                <asp:Button type="button" class="btn btn-outline-primary" ID ="btSOST" Text="Состояние" runat="server" Height="59px" Width="266px"  Font-Names="Arial Black"  style="margin-left: 0px"/>
            <br />
                   <br />
                <asp:Button type="button" class="btn btn-outline-primary" ID ="btLIZ" Text="Лицензия" runat="server" Height="59px" Width="266px"  Font-Names="Arial Black"  style="margin-left: 0px"/>
            </center>
        </div>
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

    </form>
</body>
</html>
