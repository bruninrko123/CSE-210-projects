public class Screen
{
    public List<Video> _videos = new List<Video>();



public void DisplayScreen()
{
    foreach (Video v in _videos)
    {
        Console.WriteLine(v.VideoInfo());
        Console.WriteLine();
        foreach (Comment c in v._comments)
        {
            Console.WriteLine(c.displayCommentText());
        }
        Console.WriteLine("\n");
        Console.WriteLine("---------------------------------------------------");
    }
}


}