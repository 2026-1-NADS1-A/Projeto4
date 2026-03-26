using System;
using System.Security.Cryptography.X509Certificates;

namespace SchoolPlayManager.Business.Models
{
	public class School
	{

		public int SchoolId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public bool IsActive { get; set; }
		public List<string> AuthorizedIPs { get; set; } = new List<string>();
	}
}


