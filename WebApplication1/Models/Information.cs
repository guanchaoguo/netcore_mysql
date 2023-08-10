using System;
namespace WebApplication1.Models
{
	public class Information
	{
		public int ID { get; set; }
        public string? Name { get; set; }
		public string? Title { get; set; }
		public string? Summary { get; set; }
		public string[]? Websites { get; set; }
		public string[]? Skills { get; set; }
	}
}
