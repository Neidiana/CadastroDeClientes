using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace PretoOliveira1
{
    public class ClsFuncoes
    {
        //String de conexao com o banco
        string conexao = @"Data Source=LAPTOP-SK9PBM4E\SQLEXPRESS;Initial Catalog=DbDataUser;Persist Security Info=True;User ID=sa;Password=231805";

        public SqlConnection AbrirConexao()
        {
            SqlConnection cnx = new SqlConnection(conexao);
            cnx.Open();

            return cnx;
        }

        /// <summary>
        /// Método para retornar um Dataset conforme sql passado por parâmetro.
        /// </summary>
        /// <param name="sqltxt">Comando sql para carregar dataset</param>
        /// <returns></returns>
        public DataSet AbrirTabela(string sqltxt)
        {

            SqlDataAdapter adp = new SqlDataAdapter(sqltxt, AbrirConexao());

            DataSet dst = new DataSet();

            adp.Fill(dst);

            return dst;

        }
    }
}