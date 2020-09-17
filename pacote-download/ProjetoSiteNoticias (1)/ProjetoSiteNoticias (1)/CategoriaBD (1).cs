using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ProjetoSiteNoticias
{
    public class CategoriaBD
    {
        // classe que vai conter todos os metodos de categoria

        static string sql = "select * from categorias";
        static string sql2 = "select nomeCategoria from categorias";
        public string conn;
        public MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;

        // metodo que vai chamar todas as informacoes do banco
        public CategoriaBD()
        {
            conn = ConfigurationManager.AppSettings["banco"]; // fazendo conexao com o banco

        }

        // insert into nometabela (campos) values (valores)
        // string sql = "INSERT INTO categorias(nomeCategoria) values ('pNomeCategoria')";

        // metodo para listar as categorias

        public DataSet ListarCategorias()
        {
            conexao = new MySqlConnection(conn); // criando nova conexao (objeto)
            comando = new MySqlCommand(sql2, conexao);
            DataSet ds = new DataSet();
            try
            {
                conexao.Open();
                // tabela virtual que fica em memoria, joga todas as info tiradas da tabela
                da = new MySqlDataAdapter(comando); // executa a linha de comando
                da.Fill(ds); // guarda a informaçao no DataSet

                return ds; // retorna o objeto

            }

            catch (MySqlException erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close(); // vai fechar o banco pq ja tem o dataset que é uma tabela em um memoria
            }
        }

        // metodo para incluir categorias

        public int IncluirCategoria(categoria categoria) // está recebendo um representante da categoria para incluir no banco
        {
            conexao = new MySqlConnection(conn);
            string sql = "INSERT INTO categorias(nomeCategoria) values (?pnomeCategoria)";
            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("?pnomeCategoria", categoria.NomeCategoria);

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


        public int AlterarCategoria(categoria categoria,int codigoCat) // está recebendo um representante da categoria para alterar no banco
        {
            conexao = new MySqlConnection(conn);
            string sql = "UPDATE categorias set nomeCategoria= ?pnomeCategoria where codigoCategoria="+codigoCat+"";
            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("?pnomeCategoria", categoria.NomeCategoria);
            

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

        public int ExcluirCategoria (int codigoCat) // está recebendo um representante da categoria para incluir no banco
        {
            conexao = new MySqlConnection(conn);



            string sql = " DELETE FROM categorias WHERE codigoCategoria = "+codigoCat+" and "+codigoCat+" NOT IN (SELECT codigoCategoria FROM noticias)";
            comando = new MySqlCommand(sql, conexao);
            
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