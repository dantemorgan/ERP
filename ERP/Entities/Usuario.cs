using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ERP.Services;
using Microsoft.VisualBasic.ApplicationServices;

namespace ERP.Entities
{
    class Usuario
    {
        public double codigo { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }

        public Usuario() { }

        public Usuario(float codigo, string nome, string senha)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.senha = senha;
        }

        public static List<Usuario> ConsultaUsuarios(ConexaoBD conexao)
        {

            List<Usuario> usuarios = new List<Usuario>();
            string sql = "SELECT CODIGO, NOME, SENHA FROM USUARIO";
            var dr = conexao.ExecutarConsulta(sql);

            if (dr != null)
            {
                while (dr.Read())
                {
                    Usuario user = new Usuario();
                    user.codigo = Convert.ToDouble(dr["codigo"]);
                    user.nome = dr["nome"].ToString();
                    user.senha = dr["senha"].ToString();
                    usuarios.Add(user);

                }

                dr.Close();
            }

            return usuarios;
        }

        public static Usuario ConsultaUsuarioPorCodigo(ConexaoBD conexao, double codUsuario)
        {
            try
            {
                string sql = "SELECT CODIGO, NOME, SENHA FROM USUARIO WHERE CODIGO =" + codUsuario.ToString();
                Usuario user = new Usuario();
                var dr = conexao.ExecutarConsulta(sql);
                if (dr != null)
                {

                    user.codigo = Convert.ToDouble(dr["codigo"]);
                    user.nome = dr["nome"].ToString();
                    user.senha = dr["senha"].ToString();
                }
                else
                {
                    return null;
                }

                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar usuário no método ConsultaUsuarioPorCodigo da Classe Usuario", "Erro!");
                return null;
            }
            

        }


    }
}
