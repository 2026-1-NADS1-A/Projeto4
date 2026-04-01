using System;
using System.Collections.Generic;

namespace SchoolPlayManager.Business.Validators
{
    public class IPValidator
    {
        //Ips para simulação do acesso
        private List<string> _ipsAutorizados = new List<string> { "192.168.1.50", "172.16.0.10" };

        public bool ValidarAcesso(string ipTentativa)
        {
            // Retorna true se o IP de tentativa estiver na lista de IPs autorizados
            return _ipsAutorizados.Contains(ipTentativa);
        }
    }
}
