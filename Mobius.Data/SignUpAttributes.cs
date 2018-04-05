using System;
using System.Xml.Serialization;

namespace Mobius.Data
{
    [XmlRoot(ElementName = "SignUpAttributes")]
    public class SignUpAttributes
    {
        [XmlElement(ElementName = "ButtonBackGroundColor")]
        public string ButtonBackGroundColor { get; set; }
        [XmlElement(ElementName = "ButtonTextColor")]
        public string ButtonTextColor { get; set; }
    }
}
