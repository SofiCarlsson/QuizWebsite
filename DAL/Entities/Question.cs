namespace Quiz.DAL.Entities
{
    public class Question
    {
        public string QuestionId { get; set; }
        public string QuestionText { get; set; }

        // Foreign Key QuizId
        public string QuizId { get; set; }
        public Quizes Quiz { get; set; }
        public ICollection<Answer> Answers { get; set; }


    }
}
