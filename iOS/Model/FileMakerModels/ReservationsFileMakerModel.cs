using System;

namespace ActivityManagerMobileService.API.Models.FileMakerModels
{
    public class ReservationsFileMakerModel
    {
        
        public string Activity { get; set; }
        public string ActivityBillAt { get; set; }
        public double ActivityCombo { get; set; }
        public double ActivityId { get; set; }
        public string Agent { get; set; }
        public double City { get; set; }
        public double CompanyId { get; set; }
        public double Confirm { get; set; }
        public double Confirmation { get; set; }
        public DateTime DateOfActivity { get; set; }
        public double Employee { get; set; }
        public double FlightNumber { get; set; }
        public double GArchive { get; set; }
        public int GDataKey { get; set; }
        public string Hotel { get; set; }
        public double HotelId { get; set; }
        public string RecordId { get; set; }
        public DateTime? ReportDate { get; set; }
        public DateTime? ReportPopupDate { get; set; }
        public string TransactionType { get; set; }
        public string Vendor { get; set; }
        public double VendorInvoiceNumber { get; set; }
        public double WaitListed { get; set; }
    }
}