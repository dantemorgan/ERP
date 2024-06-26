﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

        public static Cliente ConsultaClientePorCodigo(ConexaoBD conexao, int codCliente)
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

        public static bool InserirCliente(ConexaoBD conexao, Cliente cliente)
        {
            
            try
            {
                string sql = "INSERT INTO CLIENTES (" + Environment.NewLine; 
                sql += "Nome,CodigoUF,Cidade,bairro,logradouro,numero,cpfCnpj,telefone)" + Environment.NewLine;
                sql += "VALUES(" + Environment.NewLine;
                sql += "'" + cliente.nome + "'" + Environment.NewLine;
                sql += "," + cliente.codigoUF + Environment.NewLine;
                sql += ", '" + cliente.cidade + "'" + Environment.NewLine;
                sql += ", '" + cliente.bairro + "'" + Environment.NewLine;
                sql += ", '" + cliente.logradouro + "'" + Environment.NewLine;
                sql += ", " + cliente.numero + Environment.NewLine;
                sql += ", '" + cliente.cpfCnpj + "'" + Environment.NewLine;
                sql += ", '" + cliente.telefone + "'" + Environment.NewLine;
                sql += ")";
                conexao.ExecutarNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            

        }

        public static int BuscaUltimoCodigo(ConexaoBD conexao)
        {
            string sql;
            sql = "SELECT top 1 codigo from clientes order by codigo desc";
            int ultimoCodigo = 0;

            var dr = conexao.ExecutarConsulta(sql);

            if (dr !=null)
            {
                if (dr.Read())
                {
                    ultimoCodigo = (int)dr["codigo"];
                    dr.Close();
                }
            }
            
            return ultimoCodigo;
        }

        public static bool AlteraCliente(ConexaoBD conexao, Cliente cliente)
        {
            string sql;

            sql = "UPDATE CLIENTES SET " + Environment.NewLine;
            sql += "Nome = '" + cliente.nome.ToString() + "'" + Environment.NewLine; ;
            sql += ", CodigoUF = " + cliente.codigoUF.ToString() + Environment.NewLine; ;
            sql += ", Cidade = '" + cliente.cidade.ToString() + "'" + Environment.NewLine; ;
            sql += ", bairro = '" + cliente.bairro.ToString() + "'" + Environment.NewLine; ;
            sql += ", logradouro = '" + cliente.logradouro.ToString() + "'" + Environment.NewLine; ;
            sql += ", numero  = " + cliente.numero.ToString() + Environment.NewLine; ;
            sql += ", cpfCnpj = '" + cliente.cpfCnpj.ToString() + "'" + Environment.NewLine; ;
            sql += ", telefone = '" + cliente.telefone.ToString() + "'" + Environment.NewLine; ;
            sql += " WHERE CODIGO = " + cliente.codigo.ToString();

            conexao.ExecutarNonQuery(sql);

            return true;
        }

        public static bool ExcluirCliente(ConexaoBD conexao, int codCliente)
        {
            string sql;
            if(ClienteImagem.ExcluiImagemCliente(conexao, codCliente))
            {
                sql = "DELETE FROM CLIENTES WHERE CODIGO = " + codCliente;
                conexao.ExecutarNonQuery(sql);
                return true;
            }
            
            return false;
        }
    }
}
