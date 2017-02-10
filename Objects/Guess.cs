using System.Collections.Generic;

namespace HangmanApp.Objects
{
  public class Guess
  {
    private string _guess;
    private int _guessCount;
    private static int _wrongGuess;
    private static List<Guess> _guessList = new List<Guess> {};

    public Guess(string newGuess)
    {
      _guess = newGuess;
      _guessList.Add(this);
      _guessCount = _guessList.Count;
    }

    public string GetGuess()
    {
      return _guess;
    }

    public void SetGuess(string newGuess)
    {
      _guess = newGuess;
    }

    public int GuessCount()
    {
      return _guessCount;
    }

    public void SetGuessCount(int newCount)
    {
      _guessCount = newCount;
    }

    public static List<Guess> GetGuessList()
    {
      return _guessList;
    }

    public static bool CheckGuessList(string newGuess)
    {
      for(var index = 0; index < _guessList.Count; index++)
      {
        if(newGuess == _guessList[index])
        {
          return true;
        }
      }
      return false;
    }

    public static void ClearGuessList()
    {
      _guessList().Clear();
    }
  }
}
