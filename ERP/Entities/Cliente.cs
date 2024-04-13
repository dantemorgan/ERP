using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Services;

namespace ERP.Entities
{
    public class Cliente
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public int codigoUF { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string cpfCnpj { get; set; }
        public string telefone { get; set; }

        public Cliente() { }

        public Cliente(int codigo, string nome, int codigoUF, string cidade, string bairro, string logradouro, int numero, string cpfCnpj, string telefone)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.codigoUF = codigoUF;
            this.cidade = cidade;
            this.bairro = bairro;
            this.logradouro = logradouro;
            this.numero = numero;
            this.cpfCnpj = cpfCnpj;
            this.telefone = telefone;
        }

        public static List<Cliente> ConsultaTodosClientes(ConexaoBD conexao)
        {
            List<Cliente> clientes = new List<Cliente>();
            string sql;
            sql = "SELECT codigo, nome, codigoUF, cidade,bairro, logradouro,numero,cpfCnpj, telefone from clientes";

            var dr = conexao.ExecutarConsulta(sql);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.codigo = (int)dr["codigo"];
                    cliente.nome = dr["nome"].ToString();
                    cliente.codigoUF = (int)dr["codigoUF"];
                    cliente.cidade = dr["cidade"].ToString();
                    cliente.bairro = dr["bairro"].ToString();
                    cliente.logradouro = dr["logradouro"].ToString();
                    cliente.numero = (int)dr["numero"];
                    cliente.cpfCnpj = dr["cpfCnpj"].ToString();
                    cliente.telefone = dr["telefone"].ToString();

                    clientes.Add(cliente);


                }

                dr.Close();
            }

            return clientes;
        }

        public static Cliente ConsultaClientePorCOdigo(ConexaoBD conexao, int codCliente)
        {
            Cliente cliente = new Cliente();
            string sql = "SELECT codigo, nome, codigoUF, cidade,bairro, logradouro,numero,cpfCnpj, telefone from clientes where codigo = " + codCliente;

            var dr = conexao.ExecutarConsulta(sql);
            if (dr != null)
            {
                if (dr.Read())
                {
                    cliente.codigo = (int)dr["codigo"];
                    cliente.nome = dr["nome"].ToString();
                    cliente.codigoUF = (int)dr["codigoUF"];
                    cliente.cidade = dr["cidade"].ToString();
                    cliente.bairro = dr["bairro"].ToString();
                    cliente.logradouro = dr["logradouro"].ToString();
                    cliente.numero = (int)dr["numero"];
                    cliente.cpfCnpj = dr["cpfCnpj"].ToString();
                    cliente.telefone = dr["telefone"].ToString();
                }
            }


            return cliente;
        }

        public void InserirCliente(ConexaoBD conexao, Cliente cliente)
        {
            //conexao.ExecutarConsulta;
        }
    }
}
