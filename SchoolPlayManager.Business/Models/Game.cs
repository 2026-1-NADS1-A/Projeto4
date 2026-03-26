using System;

namespace SchoolPlayManager.Business.Models
{
	public class Game
	{
		public int GameId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Theme { get; set; }
		public string AgeRange { get; set; }
		public bool IsActive { get; set; }
	}
}
