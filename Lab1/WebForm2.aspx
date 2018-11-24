<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Lab1.WebForm2" %>

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
<body style=" background-color:whitesmoke">
    <form id="form1" runat="server">
        <div class="container">
            <asp:SqlDataSource ID="sds" runat ="server"></asp:SqlDataSource> 
            <br />
            <asp:Button type="button" class="btn btn-outline-info" runat="server" id="back" Text="⮪ Назад" Width="103px" OnClick="back_Click" Font-Size="Large"  />
            <br />
            <br />
            <Center>
                <div class="row">
                <asp:Label style="margin-left: 10%" ID="Label1" runat="server" ForeColor="#17a2b8" Text="СЦ &quot;МобТехСаппорт&quot;" Font-Size="22pt"></asp:Label>
                    </div>
                <br />
                <br />
                <div class="card-columns">
                 <asp:TextBox  class="form-control" ForeColor="#17a2b8" BorderColor="#17a2b8" BackColor="White" ID="SOVM" runat="server" Text="Поиск"  style="margin-left: 3px" Width="243px" />
                <br />
                  <asp:Button type="button" class="btn btn-outline-info" ID="search" runat="server" Text="Поиск" OnClick="search_Click" />
                <asp:Button type="button" class="btn btn-outline-info" ID="filter" runat="server" Text="Фильтр" OnClick="filter_Click"  />
                <br />
                <br />
                   
                    </div>
                <div class="row"
                <p style="margin-left: 10%" class="font-weight-light">СОВМЕСТИМОСТЬ КОМПЛЕКТУЮЩИХ</p>
                    </div>
                    



        
        
        
        
        
        <div class="row">
            

             <asp:GridView  ID="GvSOVMKOMP" runat="server" Font-Size="12pt" style="margin-top: 5px; margin-left: 15%" Font-Strikeout="False" Font-Overline="False" OnLoad="GvSOVMKOMP_Load"  OnSelectedIndexChanged="GvSOVMKOMP_SelectedIndexChanged" OnSorting="GvSOVMKOMP_Sorting" OnRowDataBound="GvSOVMKOMP_RowDataBound" AllowSorting="True">
                  <Columns>
                       <asp:CommandField ShowSelectButton="true" />
                   </Columns>
             </asp:GridView>
            </div>
             
        
        
                <br />
                <br />
                <br />
                <br />
                    </div>
            </Center>
            <asp:TextBox  style="margin-left: 10px" class="form-control"  ForeColor="#17a2b8" BorderColor="#17a2b8" BackColor="White" ID="textvvod" runat="server" Font-Size="13pt" text="введите значение" Width ="300px" margin="20">
            </asp:TextBox>
            <br />

            <asp:Button style="margin-left: 10px" type="button" class="btn btn-outline-success" runat="server" Text=" ⨭ Добавить" id="add" OnClick="add_Click"/>
                
            <asp:Button style="margin-left: 10px" type="button" class="btn btn-outline-danger" runat="server" Text=" x Удалить" id="delete" OnClick="delete_Click"/>
            <asp:Button style="margin-left: 10px" type="button" class="btn btn-outline-warning" runat="server" Text=" ⟳ Обновить" id="update" OnClick="update_Click"/>
            <asp:Button style="margin-left: 10px ; margin-top: 10px" type="button" class="btn btn-outline-warning" runat="server" Text=" Страница" id="Button1" OnClick="Button1_Click" />
        
        </div>    
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

    </form>
</body>
</html>


