namespace Quiz.DAL.Entities
{
    public class Quizes
    {
        public int QuizId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        public string CreatorId { get; set; }
        //Denna ärver userid från ApplicationUser mha Identity.
        public ApplicationUser Creator { get; set; }
        public List<Question> Questions { get; set; }

    }
}
