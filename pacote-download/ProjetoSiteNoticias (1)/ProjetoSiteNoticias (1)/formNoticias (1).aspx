<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formNoticias.aspx.cs" Inherits="ProjetoSiteNoticias.formNoticias" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label id="lblTitulo" Text="Titulo" runat="server" /> <br/>
    <asp:TextBox id="txtTitulo"  runat="server" /> <br/>  <br/>
    <asp:Label id="lblNoticia" Text="Noticia" runat="server" /> <br/> <br/>
    <asp:TextBox id="txtNoticia" TextMode="Multiline" runat="server" /> <br/> <br/>
     <asp:Label id="lblCategoria" Text="Categoria" runat="server" /> <br/> <br/>
      <asp:DropDownList id="ddlCategoria"  runat="server" 
            onselectedindexchanged="ddlCategoria_SelectedIndexChanged" /> <br/> <br/>
    <asp:Label id="lblData" Text="Data" runat="server" /> <br/> <br/>
   <asp:Calendar id="calData"  runat="server" /> <br/> <br/>
    <asp:Button id="btnNovo" Text="Novo" runat="server" onclick="btnNovo_Click" />  
    <asp:Button id="btnEnviar" Text="Enviar" runat="server" onclick="btnEnviar_Click" /> <br/> <br/>
     <asp:GridView id="gvNoticia" runat="server"    />  <br/> 

      
    </div>
    </form>
</body>
</html>
