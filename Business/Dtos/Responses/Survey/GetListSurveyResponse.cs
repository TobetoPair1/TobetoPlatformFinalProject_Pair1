﻿namespace Business.Dtos.Responses.Survey
{
	public class GetListSurveyResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FormUrl { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
