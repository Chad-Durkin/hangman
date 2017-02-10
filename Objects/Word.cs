using System.Collections.Generic;

namespace HangmanApp.Objects
{
  public class Word
  {
    private static List<char> _word = new List<char> {};
    private static cha
    public Word(string newWord)
    {
      _wordList.Add(newWord);
    }

    public char[] GetWord()
    {
      return _word;
    }

    public static void ClearWord()
    {
      _word.Clear();
    }

    public static void
    public static bool CheckWord(string newGuess)
    {
      for(var index = 0; index < _word.Length; index++)
      {
        if(newGuess == _word[index])
        {
          return true;
        }
      }
      return false;
    }

  }
}
