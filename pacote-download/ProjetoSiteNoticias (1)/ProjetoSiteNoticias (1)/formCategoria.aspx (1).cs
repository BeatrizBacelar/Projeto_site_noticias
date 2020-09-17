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
    public partial class formCategoria : System.Web.UI.Page
    {
        CategoriaBD categoriaBD = new CategoriaBD(); // obj da classe categoriaBD

        protected void Page_Load(object sender, EventArgs e)
        {
            categoriaBD.conexao = new MySqlConnection(categoriaBD.conn);
            categoriaBD.conexao.Open(); // p/ abrir a conexao
            if (categoriaBD.conexao.State == ConnectionState.Open) // testa se a conexao está funcionando
            {
                PreencheGrid(); // preencher o grid assim que carregar a pagina
              lblNomeCategoria.Text = "OK"; // exibe uma mensagem p/ confirmar se o banco ta ok
            }
        }

        public void PreencheGrid()
        {
            gvCategoria.DataSource = categoriaBD.ListarCategorias(); // jogou tudo que tinha no DataSet para o grid
            gvCategoria.DataBind(); // permite visualizar tudo que esta dentro do grid


        }




        protected void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            
            categoria categorias = new categoria(txtCategoria.Text); // pega o nome da tela e joga dentro do objeto
            int retorno = categoriaBD.IncluirCategoria(categorias); // inclui a categoria que pegou do campo através do objeto // a variavel retorno serve para testar se deu certo a inclusao

            PreencheGrid(); //atualiza o grid para ver a inclusao do obj
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {

            DataSet estado1 = new DataSet();
            estado1 = categoriaBD.ListarCategorias();
            // obj y
            // para excluir o campo 
            int codigoCat = Convert.ToInt32(txtCodigo.Text);
            categoriaBD.ExcluirCategoria(codigoCat);
            
            PreencheGrid(); //atualiza o grid para ver a inclusao do obj 
            // obj y2
            DataSet estado2 = new DataSet();
            estado2 = categoriaBD.ListarCategorias();
            // if se sao iguais 
            if (estado1 == estado2)
            {
                lblMensagem.Text = "ERRO!! Não foi possível excluir a categoria.";
            }
            
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            // para alterar o campo
            int codigoCat = Convert.ToInt32(txtCodigo.Text);

            categoria categorias = new categoria (txtCategoria.Text);

          categoriaBD.AlterarCategoria(categorias,codigoCat);
         PreencheGrid(); //atualiza o grid para ver a inclusao do obj

   
        }

        public void limpar()
        {
            txtCategoria.Text = "";
            txtCategoria.Focus();
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        protected void gvCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
    }
}