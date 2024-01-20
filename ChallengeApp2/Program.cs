using ChallengeApp2;

Employee user1 = new Employee("kuba", "Kowalczyk", 25);
Employee user2 = new Employee("Monika", "Nowak", 30);
Employee user3 = new Employee("Zuzia", "Grzech", 35);

user1.AddScore(5);
user1.AddScore(7);
user1.AddScore(2);
user1.AddScore(2);
user1.AddScore(1);
var result1 = user1.Result;

user2.AddScore(3);
user2.AddScore(4);
user2.AddScore(5);
user2.AddScore(2);
user2.AddScore(8);
var result2 = user2.Result;

user3.AddScore(6);
user3.AddScore(7);
user3.AddScore(1);
user3.AddScore(8);
user3.AddScore(9);
var result3 = user3.Result;

if (result1 > result2 && result1 > result3)
{
    Console.WriteLine("Najwyzszy wynik ma:");
    Console.WriteLine("Imie: " + user1.Name);
    Console.WriteLine("Nazwisko: " + user1.Surname);
    Console.WriteLine("Wiek: " + user1.Age);
    Console.WriteLine("Wynik: " + result1);
}
else if (result2 > result3 && result2 > result1)
{
    Console.WriteLine("Najwyzszy wynik ma:");
    Console.WriteLine("Imie: " + user2.Name);
    Console.WriteLine("Nazwisko: " + user2.Surname);
    Console.WriteLine("wiek: " + user2.Age);
    Console.WriteLine("Wynik: " + result2);
}
else if (result3 > result1 && result3 > result2)
{
    Console.WriteLine("Najwyzszy wynik ma:");
    Console.WriteLine("Imie: " + user3.Name);
    Console.WriteLine("Nazwisko: " + user3.Surname);
    Console.WriteLine("Wiek: " + user3.Age);
    Console.WriteLine("Wynik: " + result3);
}
