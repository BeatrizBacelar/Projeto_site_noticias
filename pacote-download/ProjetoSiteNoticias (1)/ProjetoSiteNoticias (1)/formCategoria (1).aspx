<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formCategoria.aspx.cs" Inherits="ProjetoSiteNoticias.formCategoria" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label id="lblNomeCategoria" Text="Nome Categoria" runat="server" />  <br/>
    <asp:TextBox id="txtCategoria"  runat="server" 
            ontextchanged="txtCategoria_TextChanged" /> <br/>
    <asp:TextBox id="txtCodigo"  runat="server" 
            ontextchanged="txtCategoria_TextChanged" />
    <asp:Button id="btnNovo" Text="Novo" runat="server" onclick="btnNovo_Click" /> 
    <asp:Button id="btnSalvar" Text="Salvar" runat="server" onclick="btnSalvar_Click" />  
    <asp:Button id="btnExcluir" Text="Excluir" runat="server" 
            onclick="btnExcluir_Click" />  
   <asp:Button id="btnAlterar" Text="Alterar" runat="server" 
            onclick="btnAlterar_Click" />  <br/>
       <asp:GridView id="gvCategoria" runat="server" 
            onselectedindexchanged="gvCategoria_SelectedIndexChanged" /> <br/>
            <asp:Label id="lblMensagem" Text="  " runat="server" />  <br/>
    </div>
    </form>
</body>
</html>
