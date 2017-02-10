using Nancy;
using HangmanApp.Objects;
using System.Collections.Generic;

namespace HangmanApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/newgame"] = _ => {
        return View["new_game.cshtml"];
      };
      Post["/newgame"] = _ => {


        return View["hangman.cshtml", guessList];
      };
    }
  }
}
