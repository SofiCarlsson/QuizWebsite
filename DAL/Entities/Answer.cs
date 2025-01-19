namespace Quiz.DAL.Entities
{
    public class Answer
    {
        public string AnswerId { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }

        // Foreign Key QuestionId
        public string QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
