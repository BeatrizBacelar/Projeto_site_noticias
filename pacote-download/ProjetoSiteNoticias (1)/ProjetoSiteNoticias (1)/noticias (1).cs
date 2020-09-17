using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSiteNoticias
{
    public class noticias
    {
        // propriedades 
        public int CodigoNoticia { private set; get; }
        public string Titulo { set; get; }
        public string Noticia { set; get; }
        public  DateTime Data { set; get; }
        public int CodigoCategoria {  set; get; }

        // construtores

        public noticias(int codigoNoticia )
        {
            this.CodigoNoticia = codigoNoticia;
        }

        public noticias(string titulo, string noticia, DateTime data, int codigoCategoria)
        {
            this.Titulo = titulo;
            this.Noticia = noticia;
            this.Data = data;
            this.CodigoCategoria = codigoCategoria;
        }
    }
}