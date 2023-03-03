using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight:IServiceFlight
       
    {
     
        public List<Flight> listFlights { get; set; } = TestData.Flights;
        public static int MyProperty { get; set; }
        
        public IEnumerable<DateTime> getFlightDates(string Destination)
        {
         //   List<DateTime> dates = new List<DateTime>();
 /*           for (int i = 0; i < listFlights.Count; i++)
            {
                if (listFlights[i].Destination == Destination)
                {
                    dates.Add(listFlights[i].FlightDate);
                }
            }
 */
            foreach (Flight flight in listFlights)
            {
                if (flight.Destination== Destination)
                {
                    yield return flight.FlightDate;
                }
            }
           
        }

        public void GetFlights(string filterValue, Func<string, Flight, Boolean> func)
        {
            Func<string,Flight,Boolean> condition = func;
            foreach (Flight item in listFlights)
            {
                if (condition(filterValue, item))
                {
                    Console.WriteLine(item);
                }
            }
        }

		public void ShowFlightDetails(Plane plane)
		{
			throw new NotImplementedException();
		}

		public int ProgrammedFlightNumber(DateTime startDate)
		{
			throw new NotImplementedException();
		}

		public float DurationAverage(string destination)
		{
			throw new NotImplementedException();
		}

		public IList<Flight> OrderedDurationFlights()
		{
			throw new NotImplementedException();
		}

		public IList<Traveller> SeniorTravellers(Flight flight)
		{
			throw new NotImplementedException();
		}

		public IList<IGrouping<string, Flight>> DestinationGroupedFlights()
		{
			throw new NotImplementedException();
		}
	}
    //linq 
    public IEnumerable<DateTime> getFlightDates(string destinaqtion){
        //     var query =from f in Flights
        //                where f.Destination ==destination 
        //                select f.FlightDate;
        //        return query.ToList;

        var query = listFlights.where(from => from.Destination == destinaqtion).
            Select(f => f.FlightDate);
        return query.toList();


    }

    public void  ShowFlightDetails(Plane plane)
    {
        //var req = from f in Flights
        //          where (f.MyPlane == plane)
        //          select new { F.FlightDate, f.Destination };
        //foreach(var item in req)
        //{
        //    Console.WriteLine(item.Destination=""+item.FlightDate);
        //}

        var req = Flights
            .where(f => f.MyPlane == plane)
            .Select(f => new { F.FlightDate, f.Destination });
            foreach (var item in req)
        {
            Console.WriteLine(item.Destination = "" + item.FlightDate);
        }
    }
    public int ProgrammedFlightNumber(DateTime startDate)
    {
        //var req = from f in Flights
        //  where f.FlightDate > startDate && f.FlightDate < startDate.AddDays(7)
        //  where f.FlightDate > startDate && (f.FlightDate -startDate).TotalDays<7
        //          select f;
        //  return req.count();
        return Flights
              .where(f => f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7)
              .count();  
    }

    public Float DurationAverage(string destination)
    {
        //var query = from f in Flights
        //            where f.Destination == destination
        //            select f.EstimatedDuration;
        //return query.Average();

        var  query =from f in Flights 
                    .where (f=>f.Destination == destination)
                    .Average(f=>f.EstimatedDuration);
    }
    public IList<Flight> OrderedDurationFlights()
    {
        //var query = from f in Flights 
        //            oredrby f.EstimatedDuration descending
        //            select f;
        //return query.ToList();


        return Flights
            .OrederByDescending(from => f.EstimatedDuration).Tolist();

    }
    public IList<Traveller> SeniorTravellers(Flight flight)
    {
        var query =( from f in Flights
                    where f.FlightId == flight.FlightId
                    select f).Single();
        return query.passengers
            .ofType<Traveller>().ToList().orderBy(p=>p.BirthDate).Take(3).ToList();
    }
    public IList<IGrouping<String,Flight>> DestinationGroupedFlights()
    {
        var req = Flights
            .GroupBy(f => f.Destination).Tolist();
        foreach(var item in req)
        {
            console.Writeline("Destination :"+item.Key);
            foreach (var item2 in item)
            {
                console.Writeline("Decollage :" + item2.FlightDate);
            }
        }
    }

}
