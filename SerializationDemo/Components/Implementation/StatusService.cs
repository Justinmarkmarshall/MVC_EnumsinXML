using SerializationDemo.Components.Interfaces;
using SerializationDemo.Models;

namespace SerializationDemo.Components.Implementation
{
    public class StatusService : IStatusService
    {
        public Status GetStatus()
        {
          
            return new Status() { License = new License() { ValidUntil = "2022-01-01", LicenseState = ApplicationLicenseState.Valid }, Version = "1.0" }; 
        
        }
    }
}
