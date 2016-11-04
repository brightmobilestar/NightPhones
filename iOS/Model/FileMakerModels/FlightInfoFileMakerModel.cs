using System;

namespace ActivityManagerMobileService.API.Models.FileMakerModels
{
    
    public class FlightInfoFileMakerModel
    {
        public string Activity { get; set; }
        public TimeSpan TourTime { get; set; }
        public DateTime TourDate { get; set; }
        public double WeightAvailable { get; set; }
        public double SeatsAvailable { get; set; }
        public string Pilot { get; set; }
        public string Aircraft { get; set; }
        public string Company { get; set; }

        public double ActivityId { get; set; }
        public double AircraftID { get; set; }
        public double AlertGGNose { get; set; }
        public string ALT { get; set; }
        public string AvailAircraft1 { get; set; }
        public string AvailAircraft2 { get; set; }
        public string AvailAircraft3 { get; set; }
        public string AvailAircraft4 { get; set; }
        public string AvailDate { get; set; }
        public double CGEnd { get; set; }
        public double CGStart { get; set; }
        public DateTime CreateStamp { get; set; }
        public string CreateUser { get; set; }
        public double FlightDuration { get; set; }
        public double FlightNumber { get; set; }
        public double Fuel { get; set; }
        public double FuelWeight { get; set; }
        public double PilotSeat { get; set; }
        public double RearBaggage { get; set; }
        public string Route { get; set; }
        public string SideBaggage { get; set; }
        public double PilotExtra { get; set; }

    }
}