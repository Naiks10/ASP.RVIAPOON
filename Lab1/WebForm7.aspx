<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="Lab1.WebForm7" %>

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
<body style="background-color: whitesmoke">
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:Label id="Label" runat="server" Text="Вход"  Font-Size="40pt"  Font-Bold="True" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Логин" Font-Size="20pt" BorderColor ="Black" BorderWidth=""  />
                <br />
                <asp:TextBox  class="form-control" ID="Login" runat="server"  Width="298px" Font-Size="X-Large" />
                <br />
                <br />
                <asp:Label ID="Pass" runat="server" Text="Пароль" Font-Size="20pt"  />
                <br />
                <asp:TextBox  class="form-control" ID="Pw" runat="server"  Width="298px" Font-Size="X-Large" />
                <br />
                <br />
                <asp:Button type="button" class="btn btn-outline-success"  ID="Enter" runat="server" Text="Вход" Font-Size="X-Large" OnClick="Enter_Click" />
                <asp:Button type="button" class="btn btn-outline-danger" ID="Button1" runat="server" Text="Регистрация" Font-Size="X-Large" OnClick="Button1_Click" />
            </center>
        </div>
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

    </form>
</body>
</html>
