using System;
using System.Xml.Serialization;

namespace Mobius.Data
{
    [XmlRoot(ElementName = "MasterAttributes")]
    public class MasterAttributes
    {
        [XmlElement(ElementName = "SignUpAttributes")]
        public SignUpAttributes SignUpAttributes { get; set; }
    }
}
