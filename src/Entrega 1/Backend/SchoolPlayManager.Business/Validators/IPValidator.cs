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
            for (int i = 0; i < _ipsAutorizados.Count; i++)
            {
                if (_ipsAutorizados[i] == ipTentativa)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
