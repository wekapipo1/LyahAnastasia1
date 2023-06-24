using System;

struct Player
{
    public string Name;
    public DateTime DateOfBirth;
    public string Club;
    public string Position;
    public int GamesPlayed;
    public string BirthPlace;
}

class Program
{
    static void Main(string[] args)
    {
        Player[] players = GetPlayers(); 

        Console.WriteLine("Захисники, молодше 20 рокiв, якi зiграли понад 40 матчiв за свiй клуб:");

        foreach (Player player in players)
        {
            if (player.Position == "Захисник" && CalculateAge(player.DateOfBirth) < 20 && player.GamesPlayed > 40)
            {
                Console.WriteLine($"Прiзвище: {player.Name}");
                Console.WriteLine($"Дата народження: {player.DateOfBirth.ToShortDateString()}");
                Console.WriteLine($"Клуб: {player.Club}");
                Console.WriteLine($"Амплуа: {player.Position}");
                Console.WriteLine($"Кiлькiсть iгор: {player.GamesPlayed}");
                Console.WriteLine($"Мiсце народження: {player.BirthPlace}");
                Console.WriteLine();
            }
        }

        Console.ReadLine();
    }

    static Player[] GetPlayers()
    {       

        Player[] players = new Player[5];

        players[0] = new Player
        {
            Name = "Пеле",
            DateOfBirth = new DateTime(1987, 10, 23),
            Club = "Клуб 1",
            Position = "Нападник",
            GamesPlayed = 50,
            BirthPlace = "Бразилiя"
        };

        players[1] = new Player
        {
            Name = "Джонс",
            DateOfBirth = new DateTime(2004, 3, 10),
            Club = "Клуб 2",
            Position = "Захисник",
            GamesPlayed = 47,
            BirthPlace = "Францiя"
        };

        players[2] = new Player
        {
            Name = "Джон",
            DateOfBirth = new DateTime(2000, 8, 25),
            Club = "Клуб 1",
            Position = "Захисник",
            GamesPlayed = 15,
            BirthPlace = "Аргентина"
        };

        players[3] = new Player
        {
            Name = "Шевченко",
            DateOfBirth = new DateTime(2005, 2, 5),
            Club = "Клуб 2",
            Position = "Захисник",
            GamesPlayed = 45,
            BirthPlace = "Україна"
        };

        players[4] = new Player
        {
            Name = "Луіс",
            DateOfBirth = new DateTime(2000, 6, 14),
            Club = "Клуб 3",
            Position = "Воротар",
            GamesPlayed = 45,
            BirthPlace = "Нiмеччина"
        };

        return players;
    }

    static int CalculateAge(DateTime dateOfBirth)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - dateOfBirth.Year;
        if (today < dateOfBirth.AddYears(age))
            age--;
        return age;
    }
}
