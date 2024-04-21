using ERP.Services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities
{
    class ClienteImagem
    {
        public int CodCliente { get; set; }
        public byte[] Imagem { get; set; }
        
        
        
        
        
        public ClienteImagem() { }

        public ClienteImagem(int codCliente, byte[] imagem)
        {
            CodCliente = codCliente;
            Imagem = imagem;
        }

        public static ClienteImagem ConsultaImagemPorCodigo(ConexaoBD conexao, int codCliente)
        {
            ClienteImagem clienteImagem = new ClienteImagem();
            string sql;
            sql = "SELECT CodCliente, IMAGEM FROM ImagemCadastro WHERE CodCliente = " + codCliente;

            var dr = conexao.ExecutarConsulta(sql);

            if (dr != null)
            {
                if (dr.Read())
                {
                    clienteImagem.CodCliente = (int)dr["CodCliente"];
                    SqlBytes sqlBytes = dr.GetSqlBytes(dr.GetOrdinal("Imagem"));
                    clienteImagem.Imagem = sqlBytes.Value;

                }
            }

            return clienteImagem;

        }

        public static bool SalvarImagemCliente(ConexaoBD conexao, ClienteImagem clienteImagem)
        {
            try
            {
                string sql = "INSERT INTO ImagemCadastro (CodCliente, Imagem) VALUES(@CodCliente, @Imagem)";

                using (SqlCommand comando = new SqlCommand(sql, conexao.AbrirConexao()))
                {
                    comando.Parameters.AddWithValue("@CodCliente", clienteImagem.CodCliente);
                    comando.Parameters.AddWithValue("@Imagem", clienteImagem.Imagem);

                    comando.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }


        public static bool AlteraImagemCliente(ConexaoBD conexao, ClienteImagem clienteImagem)
        {
            try
            {
                string sql = "UPDATE ImagemCadastro SET Imagem = @Imagem WHERE CodCliente = @CodCliente";

                using (SqlCommand comando = new SqlCommand(sql, conexao.AbrirConexao()))
                {
                    comando.Parameters.AddWithValue("@CodCliente", clienteImagem.CodCliente);
                    comando.Parameters.AddWithValue("@Imagem", clienteImagem.Imagem);

                    comando.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static byte[] BuscaImagemCliente(ConexaoBD conexao, int CodCliente)
        {
            try
            {
                
                string sql = "SELECT Imagem FROM ImagemCadastro WHERE CodCliente = @CodCliente";

                using (SqlCommand command = new SqlCommand(sql, conexao.AbrirConexao()))
                {
                    // Adicione o parâmetro CodCliente
                    command.Parameters.AddWithValue("@CodCliente", CodCliente);

                    // Abra a conexão


                    // Execute a consulta e obtenha o resultado
                    object result = command.ExecuteScalar();

                    // Se o resultado não for nulo, converta-o para um array de bytes e retorne
                    if (result != null)
                    {
                        return (byte[])result;
                    }
                    else
                    {
                        // Se não houver imagem para o CodCliente especificado, retorne null
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {

                
            }
        }

        public static bool ExcluiImagemCliente(ConexaoBD conexao, int codCliente)
        {
            string sql = "DELETE FROM ImagemCadastro WHERE CodCliente = " + codCliente;
            conexao.ExecutarNonQuery(sql);


            return true;
        }

    }
}
