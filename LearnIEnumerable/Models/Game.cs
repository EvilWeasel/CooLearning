using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnIEnumerable.Models
{
  public class Game
  {
    public string Title { get; set; }
    public string Publisher { get; set; }

    public Game(string title, string publisher)
    {
      Title = title ?? throw new ArgumentNullException(nameof(title));
      Publisher = publisher ?? throw new ArgumentNullException(nameof(publisher));
    }

    public override string ToString()
    {
      return $"{Title} ({Publisher})";
    }
  }
}
