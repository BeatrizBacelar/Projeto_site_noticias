using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoSiteNoticias
{
    public partial class formPrincipal : System.Web.UI.Page
    {
        NoticiaBD noticiaBD = new NoticiaBD(); // objeto de noticia

        protected void Page_Load(object sender, EventArgs e)
        {
            PreencheGrid(); // carregar todas as informaçoes do grid assim que carregar a pagina
        }

        public void PreencheGrid()
        {
            gvNoticias.DataSource = noticiaBD.ListarNoticia(); // carregou tudo para dentro do grid
            gvNoticias.DataBind(); // o dataBind mostra tudo que esta no grid


        }

        protected void gvNoticias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}