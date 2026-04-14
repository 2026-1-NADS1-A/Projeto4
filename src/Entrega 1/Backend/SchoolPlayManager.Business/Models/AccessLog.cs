// SchoolPlayManager.Business\Models\AccessLog.cs
using System;

namespace SchoolPlayManager.Business.Models
{
    public class AccessLog
    {
        public DateTime DataHora { get; set; }
        public string IpOrigem { get; set; }
        public bool AcessoPermitido { get; set; }
        public string Status => AcessoPermitido ? "Autorizado" : "Bloqueado";
    }
}