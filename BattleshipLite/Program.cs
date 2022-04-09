using BattleshipLite;
using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;

Greetings.WelcomeToGame();

List<PlayerModel> players = new List<PlayerModel>();
players = SetUp.BuildPlayers(2);

GetInput.SetupBoard(players);



Console.ReadLine();