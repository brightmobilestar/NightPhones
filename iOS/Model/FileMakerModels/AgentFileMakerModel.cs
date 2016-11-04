using System.Runtime.Serialization;

namespace ActivityManagerMobileService.API.Models
{
    [DataContract]
    public class AgentFileMakerModel
    {
        [DataMember]
        public string AgentName { get; set; }
        [DataMember]
        public double CompanyId { get; set; }
    }
}