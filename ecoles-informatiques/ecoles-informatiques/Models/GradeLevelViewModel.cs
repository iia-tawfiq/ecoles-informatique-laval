using System.ComponentModel.DataAnnotations;

namespace ecoles_informatiques.Models
{
	public class GradeLevelViewModel
	{
		public int Id { get; set; }
		[MaxLength(5)]
		public string ShortLabel { get; set; }
		public string LongLabel { get; set; }

		public string Message { get; set; }
	}
}
