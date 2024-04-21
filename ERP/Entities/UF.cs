using ERP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities
{
     class UF
    {
        public int codigoUF { get; set; }
        public string descricao { get; set; }
        public string UFAbreviacao { get; set; }
        public UF() { }

        public static List<UF> ConsultaTodas(ConexaoBD conexao)
        {
            List<UF> estados = new List<UF>();
            string sql;
            sql = "SELECT CODIGOUF,DESCRICAO, SIGLA FROM UF";
             
            var dr = conexao.ExecutarConsulta(sql);

            if(dr!= null)
            {
                while(dr.Read()) 
                { 
                    UF uf = new UF();
                    uf.codigoUF =(int)dr["codigoUF"];
                    uf.descricao = dr["descricao"].ToString();
                    uf.UFAbreviacao = dr["sigla"].ToString();
                    estados.Add(uf);
                }
            }

            return estados;
        }

        public static UF ConsultaUFPorCodigo(ConexaoBD conexao, int codUF)
        {
            UF uf = new UF();
            string sql;
            sql = "SELECT CODIGOUF, DESCRICAO, SIGLA FROM UF WHERE CODIGOUF = " + codUF;

            try
            {
                var dr = conexao.ExecutarConsulta(sql);
                if(dr!= null)
                {
                    if (dr.Read())
                    {
                        uf.codigoUF = (int)dr["codigoUF"];
                        uf.descricao = dr["descricao"].ToString();
                        uf.UFAbreviacao = dr["SIGLA"].ToString();
                    }
                }

                return uf;



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }


            
        }
    }
}
