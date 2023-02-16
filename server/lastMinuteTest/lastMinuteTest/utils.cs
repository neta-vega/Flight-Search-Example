using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lastMinuteTest
{
    public class utils
    {
        public static ClientData[] CopyFlightToClientData(Flight[] flights)
        {
            List<ClientData> clientDataList = new List<ClientData>();
            foreach (Flight flight in flights)
            {
                ClientData clientData = new ClientData()
                {
                    ID = flight.ID,
                    Segments = copySegments(flight.Segments),
                    AveragePrice = flight.AveragePrice,
                    CurrencySymbol = flight.CurrencySymbol
                };
                clientDataList.Add(clientData);
            }
            return clientDataList.ToArray();
        }

        public static List<ClientLeg> copyLegs(List<Leg> legs)
        {
            List<ClientLeg> clientLegs = new List<ClientLeg>();
            foreach (Leg leg in legs)
            {
                ClientLeg clientLeg = new ClientLeg()
                {
                    DeparturePoint = leg.DeparturePoint,
                    ArrivalPoint = leg.ArrivalPoint,
                    FlightNumber = leg.FlightNumber,
                    AirlineName = leg.AirlineName,
                    AirlineCode = leg.AirlineCode
                };
                clientLegs.Add(clientLeg);
            }
            return clientLegs;
        }

        public static List<ClientSegment> copySegments(List<Segment> segments)
        {
            List<ClientSegment> clientegments = new List<ClientSegment>();
            foreach (Segment segment in segments)
            {
                ClientSegment clientSegment = new ClientSegment()
                {
                    Legs = copyLegs(segment.Legs),
                    SegmentDuration = segment.SegmentDuration,
                    ValidatingCarrier = segment.ValidatingCarrier
                };
                clientegments.Add(clientSegment);
            }

            return clientegments;
        }
    }
}



