using ERP.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;

namespace ERP.ClassesRelatorios
{
    public class ClasseRelatorioClientes
    {
        List<Cliente> ListaClientes { get; set; }

        public ClasseRelatorioClientes(List<Cliente> listaClientes)
        {
            ListaClientes = listaClientes;
        }





        public static void GerarRelatorioClientesCompletoHTML(List<Cliente> clientes, string caminhoHTML, string caminhoPDF)
        {

            caminhoPDF = caminhoPDF.Replace(@"\\", @"\");

            // Valida a lista de clientes
            if (clientes == null || clientes.Count == 0)
            {
                throw new ArgumentException("A lista de clientes está vazia ou nula.");
            }

            // Inicia a construção do HTML
            StringWriter html = new StringWriter();

            // Cabeçalho do documento

            html.WriteLine("<!DOCTYPE html>");
            html.WriteLine("<html>");
            html.WriteLine("<head>");
            html.WriteLine("<meta charset='UTF-8'>");
            html.WriteLine("<title>Listagem de Clientes</title>");
            html.WriteLine("<style>");
            html.WriteLine("body { font-family: Arial, sans-serif; margin: 20px; }");
            html.WriteLine("h1 { text-align: center; color: #333; margin-bottom: 20px; }");
            html.WriteLine("table { width: 100%; border-collapse: collapse; margin-top: 20px; }");
            html.WriteLine("th, td { border: 1px solid #ddd; padding: 8px; text-align: left; }");
            html.WriteLine("th { background-color: #444; color: #fff; text-align: center; }");
            html.WriteLine("tr:nth-child(even) { background-color: #f2f2f2; }"); // Linhas pares com fundo cinza-claro
            html.WriteLine("tr:hover { background-color: #ddd; }"); // Efeito hover para realce
            html.WriteLine(".header { display: flex; align-items: center; margin-bottom: 20px; }");
            html.WriteLine(".logo { max-width: 100px; margin-right: 20px; }");
            html.WriteLine(".header-text { font-size: 24px; font-weight: bold; color: #333; text-align: center; flex-grow: 1; }");

            // Regras para impressão
            html.WriteLine("@media print {");
            html.WriteLine("  th { background-color: #444 !important; color: #fff !important; }"); // Força o cabeçalho colorido na impressão
            html.WriteLine("  tr:nth-child(even) { background-color: #f2f2f2 !important; }"); // Força a cor das linhas pares
            html.WriteLine("  body { -webkit-print-color-adjust: exact; }"); // Ajuste para impressoras que suportam
            html.WriteLine("  @page { margin-top: 0; margin-bottom: 0; margin-left: 0; margin-right: 0; }"); // Remove margens
            html.WriteLine("  @page :first { margin-top: 0; }"); // Remover margens na primeira página também
            html.WriteLine("  body { padding-top: 20px; padding-bottom: 20px; }"); // Adiciona espaçamento manualmente, se necessário
            html.WriteLine("  /* Remove cabeçalhos e rodapés automáticos, mas mantém a data */");
            html.WriteLine("  @page {");
            html.WriteLine("      margin: 0;"); // Remove margens padrões do navegador
            html.WriteLine("      @bottom-left { content: none; }"); // Remove a URL no rodapé
            html.WriteLine("      @bottom-right { content: none; }"); // Remove o nome do arquivo no rodapé");
            html.WriteLine("      @top-center { content: none; }"); // Remove o cabeçalho (nome do arquivo ou URL)");
            html.WriteLine("  }");
            html.WriteLine("}");
            html.WriteLine("</style>");

            html.WriteLine("</head>");
            html.WriteLine("<body>");

            // JavaScript para iniciar a impressão automaticamente
            //html.WriteLine("<script>");
            //html.WriteLine("  window.onload = function() {");
            //html.WriteLine("    window.print();");
            //html.WriteLine("  };");
            //html.WriteLine("</script>");

            // Cabeçalho com logo e título
            html.WriteLine("<div class='header'>");
            html.WriteLine("<img class='logo' src='D:\\ProjetosGit\\ERP\\ERP\\Resources\\Imagens\\Imagem_Relatorios.png' alt='Logo da Empresa'>");
            html.WriteLine("<div class='header-text'>Listagem de Clientes</div>");
            html.WriteLine("</div>");

            // Criação da tabela de clientes
            html.WriteLine("<table>");
            html.WriteLine("<tr>");
            html.WriteLine("<th>Código</th>");
            html.WriteLine("<th>Nome</th>");
            html.WriteLine("<th>Cidade</th>");
            html.WriteLine("<th>CPF/CNPJ</th>");
            html.WriteLine("<th>Telefone</th>");
            html.WriteLine("</tr>");

            // Adiciona os dados dos clientes à tabela
            foreach (var cliente in clientes)
            {
                html.WriteLine("<tr>");
                html.WriteLine($"<td>{cliente.codigo}</td>");
                html.WriteLine($"<td>{cliente.nome}</td>");
                html.WriteLine($"<td>{cliente.cidade}</td>");
                html.WriteLine($"<td>{cliente.cpfCnpj}</td>");
                html.WriteLine($"<td>{cliente.telefone}</td>");
                html.WriteLine("</tr>");
            }

            html.WriteLine("</table>");
            html.WriteLine("</body>");
            html.WriteLine("</html>");





            // Salva o HTML no arquivo especificado
            File.WriteAllText(caminhoHTML, html.ToString());

            AbrirArquivoNoNavegador(caminhoHTML);
            //ConverterHtmlParaPdf(caminhoHTML, caminhoPDF);

            //AbrirArquivo(caminhoPDF);


        }

        private static void AbrirArquivo(string caminhoArquivo)
        {
            try
            {
                var processo = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = caminhoArquivo,
                        UseShellExecute = true
                    }
                };
                processo.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao abrir o arquivo: {ex.Message}");
            }
        }


        private static void ConverterHtmlParaPdf(string caminhoHTML, string caminhoPDF)
        {
            // Substituir as barras invertidas
            caminhoPDF = caminhoPDF.Replace(@"\\", @"\");

            // Verificar se o diretório do PDF existe e criar, se necessário
            string diretorioPDF = Path.GetDirectoryName(caminhoPDF);
            if (!Directory.Exists(diretorioPDF.Trim('"')))
            {
                Directory.CreateDirectory(diretorioPDF);
                Console.WriteLine($"Diretório criado: {diretorioPDF}");
            }

            // Verificar se o arquivo HTML existe
            if (!File.Exists(caminhoHTML))
            {
                Console.WriteLine($"Erro: O arquivo HTML não foi encontrado: {caminhoHTML}");
                return;
            }

            // Configurar o conversor
            DllManager.ConfigurarDll();
            var converter = new SynchronizedConverter(new PdfTools());

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = new GlobalSettings
                {
                    ColorMode = ColorMode.Color,
                    Orientation = DinkToPdf.Orientation.Portrait,
                    PaperSize = PaperKind.A4,
                    Out = caminhoPDF // Salva o PDF no caminho especificado
                },
                Objects = {
            new ObjectSettings
            {
                Page = $"file:///{caminhoHTML.Replace("\\", "/")}" // Corrigir caminho para o HTML
            }
        }
            };

            try
            {
                // Converter o HTML para PDF
                Console.WriteLine($"Iniciando conversão para PDF: {caminhoPDF}");
                converter.Convert(doc);
                Console.WriteLine($"PDF gerado com sucesso em: {caminhoPDF}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao converter HTML para PDF: {ex.Message}");
            }
        }





        private static void AbrirArquivoNoNavegador(string caminhoArquivo)
        {
            try
            {
                // Abre o arquivo no navegador padrão
                Process.Start(new ProcessStartInfo
                {
                    FileName = caminhoArquivo,
                    UseShellExecute = true // Necessário para abrir arquivos locais no navegador padrão
                });

                Thread.Sleep(3000);
                if (File.Exists(caminhoArquivo))
                {
                    File.Delete(caminhoArquivo);

                }

            }
            catch (Exception ex)
            {
                return;
            }
        }



    }
}
