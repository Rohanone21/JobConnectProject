namespace TestService.Model
{
    public class CandidateTestAttempt
    {
        public int Id { get; set; }

        public int McqTestId { get; set; }

        public string CandidateEmail { get; set; }

        public int Score { get; set; }

        public DateTime SubmittedAt { get; set; }=DateTime.UtcNow;

        public McqTest McqTest { get; set; }
    }
}
