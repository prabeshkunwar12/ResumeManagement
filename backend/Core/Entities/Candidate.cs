namespace backend.Core.Entities
{
    public class Candidate
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CoverLetter { get; set; }
        public string ResumeUrl { get; set; }

        // Relations
        public long JobId { get; set; }
        public Job Job { get; set; }
    }
}
