using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace ERP.Services
{
    public  class ConexaoBD
    {

        private string dadosConexao;


        public ConexaoBD(string servidor, string banco, string user, string senha)
        {

            dadosConexao = $"Server={servidor};Database={banco};User Id={user};Password={senha};";
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                // Criando uma nova conexão com a string de conexão
                SqlConnection conexao = new SqlConnection(dadosConexao);
                conexao.Open(); // Abrindo a conexão
                return conexao; // Retornando a conexão aberta
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar con~exão com o banco de dados." + ex.Message);
                return null; // Retornando null em caso de erro
            }
        }

        public void FecharConexao(SqlConnection conexao)
        {
            try
            {
                conexao.Close(); // Fechando a conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar a conexão!" + ex.Message, "Erro!");
            }
        }

        public SqlDataReader ExecutarConsulta(string query)
        {
            try
            {
                SqlConnection conexao = AbrirConexao();
                SqlCommand comando = new SqlCommand(query, conexao);
                SqlDataReader reader = comando.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar consulta!" + ex.Message, "Erro!");
                return null;
            }
        }

    }


}
