using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class QuizModel
    {
        public List<string> ListResult { get; set; } = new List<string>();
        public int RightAnswersCount { get; set; } = 0;
        public int AnswersCount { get; set; } = 0;
    }
}
