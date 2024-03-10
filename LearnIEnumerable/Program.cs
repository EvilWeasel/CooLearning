using LearnIEnumerable.Models;

var myGames = new GameLibrary();
// adding a few games to the collection
#region AddingGames
myGames.Add(new Game("The Last of Us", "Naughty Dog"));
myGames.Add(new Game("God of War", "Santa Monica Studio"));
myGames.Add(new Game("Uncharted", "Naughty Dog"));
myGames.Add(new Game("Red Dead Redemption 2", "Rockstar Games"));
myGames.Add(new Game("The Witcher 3: Wild Hunt", "CD Projekt Red"));
myGames.Add(new Game("Grand Theft Auto V", "Rockstar Games"));
myGames.Add(new Game("Minecraft", "Mojang Studios"));
myGames.Add(new Game("Assassin's Creed Valhalla", "Ubisoft"));
#endregion

// logging them using a regular boring for-loop
for (int i = 0; i < myGames.Count; i++)
{
  // this works, because we implemented index-getter on GameLibrary
  Console.WriteLine(myGames[i]);
}

// now with a foreach loop
// Error:
// foreach statement cannot operate on ... type 'GameLibrary' because <the type lacks> definition for 'GetEnumerator'
// Aufgabe: Implementiere IEnumerable in der `GameLibratry` Klasse
foreach (var game in myGames)
{
  Console.WriteLine(game);
}
