
class WordHandler 
{
    private Random random = new Random();
    public void HideWords(List<Word> words, int amountOfWords) {

        List<Word> notHidenWords = words.Where(it => !it.IsHidden).ToList();

        if (notHidenWords.Count <= amountOfWords)
        {
            notHidenWords.ForEach(it => 
            {
                it.Words = new string('_', it.Words.Length);
                it.IsHidden = true;
            });
            return;
        }

        for (int i = 0; i < amountOfWords; i++) 
        {
            int index = random.Next(notHidenWords.Count);
            Word word =  notHidenWords[index];
            notHidenWords.RemoveAt(index);
            word.Words = new string('_', word.Words.Length);
            word.IsHidden = true;
        }
    }
}
