using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ProjetoSiteNoticias
{
    public class NoticiaBD
    {


         // classe que vai conter todos os metodos de categoria

        static string sql = "select * from noticias";
        public string conn;
        public MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;

        // metodo que vai chamar todas as informacoes do banco
        public NoticiaBD()
        {
            conn = ConfigurationManager.AppSettings["banco"]; // fazendo conexao com o banco, caminho para encontrar o banco

        }

        public DataSet ListarNoticia()
        {
            conexao = new MySqlConnection(conn); // criando nova conexao (objeto)
            comando = new MySqlCommand(sql, conexao);
            try
            {
                DataSet ds = new DataSet(); // tabela virtual que fica em memoria, joga todas as info tiradas da tabela
                da = new MySqlDataAdapter(comando); // executa a linha de comando
                da.Fill(ds); // guarda a informaçao no DataSet


                return ds;

            }

            catch (MySqlException erro)
            {
                throw erro;
            }
        }
        public int IncluirNoticia(noticias noticia) // está recebendo um representante da categoria para incluir no banco
        {
           
            
            
            conexao = new MySqlConnection(conn);
            string sql = "INSERT INTO noticias (titulo,noticia,data, codigoCategoria ) values (?pTitulo,?pNoticia,?pData, ?pCodigoCategoria)";
            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("?pTitulo", noticia.Titulo);
            comando.Parameters.AddWithValue("?pNoticia", noticia.Noticia);
            comando.Parameters.AddWithValue("?pData", noticia.Data);
            comando.Parameters.AddWithValue("?pcodigoCategoria", noticia.CodigoCategoria);


            try
            {
                conexao.Open();
                int quant = comando.ExecuteNonQuery(); // vai executar o comando sql e retornar a quantidade de linhas efetadas
                return quant;
            }
            catch (MySqlException erro)
            {
                throw erro;
            }

        }


     

    }
}