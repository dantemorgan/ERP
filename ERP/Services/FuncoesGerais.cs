using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services
{
    public class FuncoesGerais
    {
        public static bool ValidaCPFCNPJ(string numeroCPFCNPJ)
        {
            
            if (numeroCPFCNPJ.Length == 11)
            {
                // 11 dígitos é CPF. Valida  abaixo. 
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma;
                int resto;
                numeroCPFCNPJ = numeroCPFCNPJ.Trim();
                numeroCPFCNPJ = numeroCPFCNPJ.Replace(".", "").Replace("-", "");
                if (numeroCPFCNPJ.Length != 11)
                    return false;
                tempCpf = numeroCPFCNPJ.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return numeroCPFCNPJ.EndsWith(digito);

            }
            else if (numeroCPFCNPJ.Length == 14)
            {
                //14 Dígitos é CNPJ. Então valida e retorna true ou false
                int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma;
                int resto;
                string digito;
                string tempCnpj;
                numeroCPFCNPJ = numeroCPFCNPJ.Trim();
                numeroCPFCNPJ = numeroCPFCNPJ.Replace(".", "").Replace("-", "").Replace("/", "");
                if (numeroCPFCNPJ.Length != 14)
                    return false;
                tempCnpj = numeroCPFCNPJ.Substring(0, 12);
                soma = 0;
                for (int i = 0; i < 12; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
                resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();
                tempCnpj = tempCnpj + digito;
                soma = 0;
                for (int i = 0; i < 13; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
                resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return numeroCPFCNPJ.EndsWith(digito);
            }
            else
            {

                return false;
            }

        }


    }


}
