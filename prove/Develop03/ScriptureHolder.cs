 
class ScriptureHolder
{
    private static Random rnd = new Random();

    private List<Scripture> _scriptureList = new List<Scripture>()
    {
        new Scripture(
            new Reference("1 Nephi", 3, 7),
            ToWordsList("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.")
        ),
        new Scripture(
            new Reference("1 Nephi", 3, 8),
            ToWordsList("And it came to pass that when my father had heard these words he was exceedingly glad, for he knew that I had been blessed of the Lord.")
        ),
        new Scripture(
            new Reference("1 Nephi", 3, 9),
            ToWordsList("And I, Nephi, and my brethren took our journey in the wilderness, with our tents, to go up to the land of Jerusalem.")
        ),
        new Scripture(
            new Reference("1 Nephi", 3, 7, 9),
            ToWordsList(@"And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.

                        And it came to pass that when my father had heard these words he was exceedingly glad, for he knew that I had been blessed of the Lord.

                        And I, Nephi, and my brethren took our journey in the wilderness, with our tents, to go up to the land of Jerusalem.

                        And it came to pass that when we had gone up to the land of Jerusalem, I and my brethren did consult one with another.")
        )
    };

    public Scripture GiveScripture()
    {
        int randomIndexElement = rnd.Next(_scriptureList.Count);
        return _scriptureList[randomIndexElement];
    }

    private static List<Word> ToWordsList(String verse) {
        return verse.Split(" ").ToList().Select(it => new Word(it)).ToList();
    }
}
