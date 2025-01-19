namespace Quiz.DAL.Entities
{
    public class UserQuizResult
    {
        public string UserQuizResultId { get; set; }

        //Foreign Key QuizId
        public string QuizId { get; set; }
        public Quizes Quiz { get; set; }

        //Foreign Key UserId
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int Score { get; set; }
    }
}
