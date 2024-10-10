public class Comment
{
    public string _name;
    public string _commentText;

    public string displayCommentText()
    {
        string commentToDisplay = $"Name: {_name} \n Comment: {_commentText}";
        return commentToDisplay;
    }
}