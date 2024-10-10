public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();

    public int returnNumberOfComments()
    {  
        int commentCounter = 0; 
        foreach (Comment c in _comments)
        {
            commentCounter++;
        }
        return commentCounter;
    }


    public string VideoInfo()
    {
        string videoInfoDisplay = $"Title: {_title}\nauthor: {_author}\nlenght: {_length}s \nNumber of comments: {returnNumberOfComments()}";
        return videoInfoDisplay;
    }
}