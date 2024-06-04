namespace LoginDemoServer.Models
{
    public class Grades
    {
        public int Id { get; set; }
        public DateTime ExamDate { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }
        public string UserEmail { get; set; }
        public Users User { get; set; }
    }
}
