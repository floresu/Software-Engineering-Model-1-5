using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AXT.Model
{
    /* 
    This 'NewPropertyJobInsert' model will allow the logged in user to create a new property job. The logged in user will be able to insert
    the property's name, address, city, state, ZIP, township, county, and PIN (Property Identification Number). The logged in user will be able
    to select a reference party.
    */
    [XmlRoot]
    public class NewPropertyJobInsertModel
    {
        [XmlElement]
        public int NewPropertyJobInsertID { get; set; }

        [XmlElement]
        public string AssignJobNumber { get; set; }

        [XmlElement]
        public string InsertPropertyName { get; set; }

        [XmlElement]
        public string InsertPropertyAddress { get; set; }

        [XmlElement]
        public string InsertPropertyCity { get; set; }

        [XmlElement]
        public string InsertPropertyState { get; set;  }

        [XmlElement]
        public string InsertPropertyZIP { get; set; }

        [XmlElement]
        public string InsertPropertyTownship { get; set; }

        [XmlElement]
        public string InsertPropertyCounty { get; set; }

        [XmlElement]
        public string InsertPropertyPIN { get; set; }

        [XmlElement]
        public int ReferencePartySearchID { get; set; } 
    }
}
