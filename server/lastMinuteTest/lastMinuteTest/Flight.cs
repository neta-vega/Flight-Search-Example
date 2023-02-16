using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Text.Json;

namespace lastMinuteTest
{
    public class Flight
    {
        public string ID { get; set; }
        public object Key { get; set; }
        public Dictionary<string, PassengerType> PassengersGroupedByType { get; set; }
        public List<Passenger> Passengers { get; set; }
        public List<Segment> Segments { get; set; }
        public double TotalPrice { get; set; }
        public double AveragePrice { get; set; }
        public string CurrencySymbol { get; set; }
        public int AvailableSeat { get; set; }
        public int RouteType { get; set; }
        public object BaggageInfo { get; set; }
        public string ProviderCode { get; set; }
        public object DeepLinkRef { get; set; }
    }

    public class PassengerType
    {
        public int Type { get; set; }
        public string Label { get; set; }
        public int Amount { get; set; }
    }

    public class Passenger
    {
        public double TotalPrice { get; set; }
        public double TotalTax { get; set; }
        public int PaxType { get; set; }
        public object BaggageUpgrade { get; set; }
    }

    public class Segment
    {
        public List<Leg> Legs { get; set; }
        public double SegmentDuration { get; set; }
        public int Direction { get; set; }
        public string ValidatingCarrier { get; set; }
        public BaggageInfo BaggageInfo { get; set; }
        public string Key { get; set; }
        public int Index { get; set; }
    }

    public class Leg
    {
        public DeparturePoint DeparturePoint { get; set; }
        public ArrivalPoint ArrivalPoint { get; set; }
        public string FlightNumber { get; set; }
        public double Duration { get; set; }
        public string OperatingCarrier { get; set; }
        public string Class { get; set; }
        public string AirlineName { get; set; }
        public string AircraftType { get; set; }
        public bool MealIncluded { get; set; }
        public string AirlineCode { get; set; }
    }

    public class DeparturePoint
    {
        public string AirportName { get; set; }
        public string AirportCode { get; set; }
        public string City { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class ArrivalPoint
    {
        public string AirportName { get; set; }
        public string AirportCode { get; set; }
        public string City { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class BaggageInfo
    {
        public Handbag Handbag { get; set; }
        public Laggage Laggage { get; set; }
        public AirCarrierInfoLinks AirCarrierInfoLinks { get; set; }
        public object Notes { get; set; }
    }

    public class Handbag
    {
        public int Status { get; set; }
        public string Text { get; set; }
        public int Quantity { get; set; }
        public string Weight { get; set; }
        public object Volume { get; set; }
    }

    public class Laggage
    {
        public int Status { get; set; }
        public string Text { get; set; }
        public int Quantity { get; set; }
        public string Weight { get; set; }
        public object Volume { get; set; }
    }

    public class AirCarrierInfoLinks
    {
        public string AirFrance { get; set; }
    }

}
