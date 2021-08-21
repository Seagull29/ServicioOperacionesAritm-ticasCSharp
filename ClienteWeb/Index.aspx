<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ClienteWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNro1" runat="server"></asp:TextBox>
        </div>
        <asp:TextBox ID="txtNro2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnSumar" runat="server" OnClick="btnSumar_Click" Text="Sumar" />
            <asp:Button ID="btnRestar" runat="server" OnClick="btnRestar_Click" Text="Restar" />
            <asp:Button ID="btnMultiplicar" runat="server" OnClick="btnMultiplicar_Click" Text="Multiplicar" />
        </p>
        <p>
            <asp:Button ID="btnDividir" runat="server" OnClick="btnDividir_Click" Text="Dividir" />
            <asp:Button ID="btnPotencia" runat="server" OnClick="btnPotencia_Click" Text="Potencia" />
            <asp:Button ID="btnFactorial" runat="server" OnClick="btnFactorial_Click" Text="Factorial" />
        </p>
        <p>
            <asp:Button ID="btnSeno" runat="server" OnClick="btnSeno_Click" Text="Seno" />
            <asp:Button ID="btnTangente" runat="server" OnClick="btnTangente_Click" Text="Tangente" />
            <asp:Button ID="btnInverso" runat="server" OnClick="btnInverso_Click" Text="Inverso" />
        </p>
        <p>
            <asp:Button ID="btnRaizC" runat="server" OnClick="btnRaizC_Click" Text="Raiz Cuadrada" />
            <asp:Button ID="btnRaizEn" runat="server" OnClick="btnRaizEn_Click" Text="Raiz Enesima" />
        </p>
        <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
    </form>
</body>
</html>
