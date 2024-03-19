using ConsoleApp;

Console.Clear();
Console.WriteLine("Добро пожаловать в игру");
Console.WriteLine("Если хотите выйти из игры, нажмите '0' в любое время.");
Console.WriteLine("Запустить игру? Нажмите enter");
Console.ReadLine();

var gameMaster = new GameMaster();
gameMaster.Start();

Console.ReadLine();