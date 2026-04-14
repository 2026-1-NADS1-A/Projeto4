using System;
using System.IO;
using SchoolPlayManager.Business.Models;

namespace SchoolPlayManager.Data.Repositories
{
    public class AccessLogRepository
    {
        // Define o caminho onde o arquivo de texto será salvo (na mesma pasta do executável)
        private readonly string caminhoArquivoLog = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
    "logs_acesso.txt"
    );

        public void RegistrarLog(AccessLog log)
        {
            // Formata a linha que será salva no arquivo
            string linhaLog = $"{log.DataHora:yyyy-MM-dd HH:mm:ss} | IP: {log.IpOrigem} | Status: {log.Status}";

            // O 'true' no StreamWriter significa "Append" (adicionar ao final do arquivo sem apagar o que já tem)
            using (StreamWriter sw = new StreamWriter(caminhoArquivoLog, true))
            {
                sw.WriteLine(linhaLog);
            }
        }
    }
}