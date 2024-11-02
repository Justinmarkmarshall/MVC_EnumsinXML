using System.Xml.Serialization;

namespace SerializationDemo.Models
{
    public class License
    {
        public string ValidUntil { get; set; }

        // we have a nested enum in the dto to test the serialization of nested types
        public ApplicationLicenseState LicenseState { get; set; }
    }

    public enum ApplicationLicenseState
    {
        [XmlEnum("0")]
        Valid = 0,
        [XmlEnum("1")]
        Invalid = 1
    }
}
