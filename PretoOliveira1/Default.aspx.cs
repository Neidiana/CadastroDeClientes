using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using PretoOliveira1;

namespace PretoOliveira1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                /* Quando carrega a pagina ja carrega a GridView Com os clientes do Banco */
                CarregaClientes();

            }

        }

        protected void btn_adicionar_Click(object sender, EventArgs e)
        {

            //Testa se os Campos Nome e CPF estao vazios
            if (txt_nome.Text != "" && txt_cpf.Text != "")
            {

                string sqltxt = string.Format("INSERT INTO CLIENTE(CLI_NOME, CLI_LOGRADOURO, CLI_NUMERO, CLI_BAIRRO, CLI_CIDADE, CLI_TELEFONE, CLI_EMAIL, CLI_CPF) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", txt_nome.Text, txt_logradouro.Text, txt_numero.Text, txt_bairro.Text, txt_cidade.Text, txt_telefone.Text, txt_email.Text, txt_cpf.Text);
                SqlCommand cmd = new SqlCommand(sqltxt, new ClsFuncoes().AbrirConexao());
                cmd.ExecuteNonQuery();

                // Limpa os TextBox
                txt_nome.Text = "";
                txt_logradouro.Text = "";
                txt_numero.Text = "";
                txt_bairro.Text = "";
                txt_cidade.Text = "";
                txt_telefone.Text = "";
                txt_email.Text = "";
                txt_cpf.Text = "";

                // Carrega a GridView depois de adicionar um novo Cliente
                CarregaClientes();

            }
            else
            {
                // Alert de campo vazio
                string myStringVariable = string.Empty;

                myStringVariable = "Campo Nome ou CPF em Branco Verifique!!!";


                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);

            }

        }

        /// <summary>
        /// Funcao para carregar a Gridview de Clientes
        /// </summary>
        void CarregaClientes()
        {
           
            ClsFuncoes clsFuncoes = new ClsFuncoes();

            gvw_cliente.DataSource = clsFuncoes.AbrirTabela("SELECT * FROM CLIENTE");
            gvw_cliente.DataBind();

        }

    }

}