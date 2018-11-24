<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="Lab1.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:SqlDataSource ID="sds" runat="server"></asp:SqlDataSource>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <%--<asp:Timer ID="Timer1" runat="server" Interval="10" OnTick="Timer1_Tick">
                        </asp:Timer>--%>
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                        <asp:GridView ID="gv" runat="server" />
                    </ContentTemplate>
                </asp:UpdatePanel>
                </center>
        </div>
    </form>
</body>
</html>
