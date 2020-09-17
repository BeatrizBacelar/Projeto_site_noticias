using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSiteNoticias
{
    public class categoria
    {
    // propriedades 
        public int CodigoCategoria {private set; get; }
        public string NomeCategoria { set; get; }

    // construtores
  public categoria (int codigoCategoria) {
      this.CodigoCategoria = codigoCategoria;
  }

  public categoria(string nomeCategoria)
  {
      this.NomeCategoria = nomeCategoria;
  }

    }
}