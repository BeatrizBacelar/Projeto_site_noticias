using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoSiteNoticias
{
    public partial class formNoticias : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        NoticiaBD noticiaBD = new NoticiaBD(); // obj da classe categoriaBD
        CategoriaBD categoriaBD = new CategoriaBD();
        protected void Page_Load(object sender, EventArgs e)
        {
            
                PreencheGrid();
                if (!IsPostBack)
                {
                    PreencheDDL(); 
                }
                // preencher o grid assim que carregar a pagina
                //  lblNomeCategoria.Text = "OK"; // exibe uma mensagem p/ confirmar se o banco ta ok
            
        }

        public void limpar()
        {
            // limpar o campo titulo
            txtTitulo.Text = "";
            txtTitulo.Focus();
            // limpar o campo noticia
            txtNoticia.Text = "";
            txtTitulo.Focus();
           
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void PreencheDDL()
        {
         ddlCategoria.DataSource = categoriaBD.ListarCategorias();// jogou tudo que tinha no DataSet para o ddl

	    ddlCategoria.DataTextField = "nomeCategoria"; // o que aparece no dropdown
        ddlCategoria.DataValueField = "codigoCategoria"; // campo chave da tabela
        
        ddlCategoria.DataBind(); // permite visualizar tudo que esta dentro da ddl

        }


        public void PreencheGrid()
        {
            gvNoticia.DataSource = noticiaBD.ListarNoticia(); // jogou tudo que tinha no DataSet para o grid
            gvNoticia.DataBind(); // permite visualizar tudo que esta dentro do grid


        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        protected void btnEnviar_Click(object sender, EventArgs e)

        {
        
	int x = Convert.ToInt32(ddlCategoria.SelectedValue);  
	 noticias noticia = new noticias (txtTitulo.Text, txtNoticia.Text, calData.SelectedDate, x); // pega o nome da tela e joga dentro do objeto
            int retorno = noticiaBD.IncluirNoticia(noticia); // inclui a categoria que pegou do campo através do objeto // a variavel retorno serve para testar se deu certo a inclusao

            PreencheGrid(); //atualiza o grid para ver a inclusao do obj

            Response.Redirect("formPrincipal.aspx");
        }
    }
}