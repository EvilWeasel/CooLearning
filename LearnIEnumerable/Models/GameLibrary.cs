using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnIEnumerable.Models
{
  public class GameLibrary
  {
    // behind the scenes, we are just creating an interface around the list-type
    private readonly List<Game> _games = new();
    public void Add(Game game)
    {
      _games.Add(game);
    }
    public void Remove(Game game)
    {
      _games.Remove(game);
    }
    // makes getting item at index possible: var game2 = games[1]
    public Game this[int index] => _games[index];
    public int Count => _games.Count;
  }
}
