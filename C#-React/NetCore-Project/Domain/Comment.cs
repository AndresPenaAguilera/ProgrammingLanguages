namespace Domain
{
    public class Comment
    {
        public int CommentId {get; set;}
        public string Student {get; set;}
        public int Score{get; set;}
        public string TextComment {get; set;}
        public int CurseId {get; set;}
        public Course Course{get; set;}
    }
}