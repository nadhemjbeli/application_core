//// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System.Collections;
using AM.ApplicationCore.Services;
//string chaine = Console.ReadLine();
//float age = 0;
//try
//{
//    age = float.Parse(Console.ReadLine());

//}
//catch
//{
//    Console.WriteLine("Erreur");
//}
//Console.WriteLine("Hello" + chaine + "age : " + (age + 1));*


//Personne personne = new Personne();
//personne.Id=0;
//personne.Nom = "xxxx";
//personne.Prenom = "xxxx";
//personne.Password = "0000";
//personne.Email = "xx.xxxxxx@esprit.tn";
//personne.DateNaissance = new DateTime(20, 12, 31, 15, 45, 54);
//Console.WriteLine(personne.ToString());
//Personne personne2 = new Personne(
//    "nom", "prenom", "email", "password", DateTime.Now
//    ) ;
//Personne personne3 = new Personne()
//{
//    Nom = "nom1",
//    Prenom = "prenom",
//    Email = "email",
//    DateNaissance = new DateTime(),
//    Password = "password",
//};
//Personne etudiant = new Etudiant();
//personne.GetMyType();
//etudiant.GetMyType();


//Plane plane1 = new Plane();
//plane1.PlaneId = 1;
//plane1.Capacity = 300;
//plane1.ManufactureDate = new DateTime(2022, 09, 23);
//plane1.PlaneType = PlaneType.Airbus;
//Console.WriteLine(plane1.ToString());
//Plane plane2 = new Plane(PlaneType.Airbus, 500, DateTime.Now);
//Console.WriteLine(plane2.ToString()); 
//Plane p3 = new Plane()
//{ Capacity = 500, PlaneType = PlaneType.Airbus, ManufactureDate = DateTime.Now };
//Console.WriteLine(p3.ToString());
//Passanger pass1 = new Passanger
//{
//    FirstName = "xxxxxx",
//    LastName = "xxxxxxxxx",
//    EmailAddress = "xxxxxxx.xxxxxxx@esprit.tn"


//};

//Console.WriteLine(pass1.CheckProfil("xxxxxxx", "xxxxxxxxx"));
//pass1.PassangerType();
//Staff stf = new Staff();
//stf.PassangerType();

//ArrayList list= new ArrayList();
//list.Add(pass1);
//list.Add(12);
//list.Add("hello");
//foreach
//    (var item in list)
//{
//    Console.WriteLine(item);
//}
//List<int> ints= new List<int>();
//ints.Add(1);
//ints.Add(2);
//List<Plane> planes = new List<Plane>()
//{p3,
// new Plane(){
//   PlaneId=1,
//   PlaneType= PlaneType.Airbus,
//   Capacity = 500,
// }

//};
//ServiceFlight service = new ServiceFlight();
//service.Flights = TestData.Flights;
//Action<string, int> action;
//static void Test(string a, int v) { };
//action = delegate (string a, int b) { };
//action("hello", 2);
//Func<Boolean, string, double> func;
//static double Test2(Boolean a, string b) { return 0; };
//func = (Boolean a, string b) => 10;
//double a = func(true, "abc");
//service.GetFlights("Paris",
//delegate (string a, Flight flight)
//{
//    return flight.Destination == a;
//});
//service.GetFlights("Paris",
// (string a, Flight flight) =>

//     flight.EstimatedDuration == int.Parse(a)
//);


int x = 45;
Console.WriteLine(x.Add(5));

Passanger p = new Passanger()
{
	//LastName = "test",
	//FirstName = "test"
};

p.UpperFullName();

Console.WriteLine(p);





























