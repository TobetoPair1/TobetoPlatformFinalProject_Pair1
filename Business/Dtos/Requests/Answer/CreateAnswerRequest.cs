using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.Answer
{
	public class CreateAnswerRequest
	{
		public Guid QuestionId { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
	}
}
