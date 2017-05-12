namespace AppGit.Model
{
    public class Repository
    {
        public int Id { get; set; }
        public User Owner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ApiUrl { get; set; }
        public string HtmlUrl { get; set; }
        public bool IsForked { get; set; }
        public bool IsPrivate { get; set; }
    }
}
