<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formPrincipal.aspx.cs" Inherits="ProjetoSiteNoticias.formPrincipal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">  
    <div>
    <div id="menu">   <%-- criar uma div menu dentro da div geral para adcionar a opção de ir para o form categoria ou noticia --%>
    <a href="formCategoria.aspx" runat="server" >Categorias</a>
    <a  href="formNoticias.aspx" runat="server" >Notícias</a>
    </div>

    <asp:GridView ID="gvNoticias" runat="server" BackColor="White" BorderColor="White" 
            BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" 
            GridLines="None" onselectedindexchanged="gvNoticias_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView> <%-- gridView de noticias--%>

    </div>
    </form>
</body>
</html>
