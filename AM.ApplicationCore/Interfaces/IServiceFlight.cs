using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        public IEnumerable<DateTime> getFlightDates(String Destination);
        public void GetFlights(string filterValue, Func<string, Flight, Boolean> func);
        public void ShowFlightDetails(Plane plane);
        public int ProgrammedFlightNumber(DateTime startDate);
        public float DurationAverage(string destination);
        public IList<Flight> OrderedDurationFlights();
        public IList<Traveller> SeniorTravellers(Flight flight);
        public IList<IGrouping<String, Flight>> DestinationGroupedFlights();
    }

 
}
