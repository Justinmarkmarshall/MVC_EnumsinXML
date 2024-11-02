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
        //this will allow the xml response to show the number aswell
        // without this it will show the string value
        [XmlEnum("0")]
        Valid = 0,
        [XmlEnum("1")]
        Invalid = 1
    }
}
