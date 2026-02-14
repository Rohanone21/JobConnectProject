namespace TestService.DTOS
{
    public class SubmitTestDto
    {
        public int McqTestId { get; set; }

        public string CandidateEmail { get; set; }

        public Dictionary<string,int>Answers { get; set; }
    }
}
