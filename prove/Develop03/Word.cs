public class Word()
{
    private List<string> _listToHide = new List<string>();

    public Word(List<string> listOfWords)
    {
        _listToHide = listOfWords;
    }
    
  
    public void Hide()
    {   
        int lenghtList = _showScripture.Count;
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.Enter)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, lenghtList - 1);

            string inputString = _showScripture[randomNumber];
            int lenghtCharacter = inputString.Length;
            _listToHide[randomNumber] = "";

            for (int i = 0; i < lenghtCharacter; i++)
            {
                _listToHide[randomNumber] += "_";
            }

            setNewHiddenList();

        }

    private void setNewHiddenList(List<string> list)
    {
        _listToHide = list;
    }
}