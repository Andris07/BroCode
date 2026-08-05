using _45._list_of_objects;

List<Player> players = new List<Player>();

players.Add(new Player("Chad"));
players.Add(new Player("Steve"));
players.Add(new Player("Karen"));

foreach (var player in players)
{
    Console.WriteLine(player);
}

Console.ReadKey();