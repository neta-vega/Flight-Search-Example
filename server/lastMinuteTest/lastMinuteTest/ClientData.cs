using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lastMinuteTest
{
    public class ClientData
    {
        public string ID { get; set; }
        public List<ClientSegment> Segments { get; set; }
        public double AveragePrice { get; set; }
        public string CurrencySymbol { get; set; }
    }

    public class ClientDeparturePoint
    {
        public string AirportName { get; set; }
        public string AirportCode { get; set; }
        public string City { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class ClientArrivalPoint
    {
        public string AirportName { get; set; }
        public string AirportCode { get; set; }
        public string City { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class ClientLeg
    {
        public DeparturePoint DeparturePoint { get; set; }
        public ArrivalPoint ArrivalPoint { get; set; }
        public string FlightNumber { get; set; }
        public string AirlineName { get; set; }
        public string AirlineCode { get; set; }
    }

    public class ClientSegment
    {
        public List<ClientLeg> Legs { get; set; }
        public double SegmentDuration { get; set; }
        public string ValidatingCarrier { get; set; }
    }

    
}
