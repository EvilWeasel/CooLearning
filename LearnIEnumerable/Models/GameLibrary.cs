using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnIEnumerable.Models
{
  public class GameLibrary : IEnumerable<Game>
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
    /**
      This is what makes a collection foreach-able.
      We need to return an Enumerator.
      Because we are just wrapping a generic List,
        we could just call _games.GetEnumerator().
      This example shows how to also implement the IEnumerable-Interface.
    */
    public IEnumerator<Game> GetEnumerator()
    {
      /*
        return either _games.GetEnumerator() from the generic list we use,
          or create a custom enumerator
      */
      return new GameEnumerator(this);
    }
    /*
      Because of backwards-compatability (this is Microsoft-Java after all...),
      we also need a version, that is returning a non-generic Enumerator.
      FYI: C# introduced generics in 2005
    */
    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    /*
      makes getting item at index possible: var game2 = games[1]
      this has not much todo with the implementation of IEnumerable,
        but we need to access the current element somehow :)
    */
    public Game this[int index] => _games[index];
    public int Count => _games.Count;
  }
  public class GameEnumerator : IEnumerator<Game>
  {
    /*
      Enumerator needs to keep track of our Collection,
        therefore we save a reference to it
    */
    private GameLibrary _games;
    // tracks the current position
    private int _index;
    public GameEnumerator(GameLibrary games)
    {
      _games = games;
      /*
        on first iteration, we call MoveNext, which we expect to be the element 0
        therefore we initiate with -1, so the first MoveNext-Call increments to 0
      */
      _index = -1;
    }
    // returns the element at the current index
    public Game Current => _games[_index];
    // non-generic version for compatibility with dotnet versions < 2.0
    object IEnumerator.Current => Current;
    // part of the interface, so we need to implement dispose()
    public void Dispose()
    {
      Console.WriteLine("Garbage-Collecting: We don't really need to do anything here, at least for our purposes...");
    }
    /*
      MoveNext() first increments the index and then checks,
        if we reached the end of the collection.
      returns true, as long as current is smaller than collection.Count
    */
    public bool MoveNext()
    {
      return ++_index < _games.Count;
    }
    // Resets the index to -1, so we can iterate from beginning again
    public void Reset()
    {
      _index = -1;
    }
  }
}
