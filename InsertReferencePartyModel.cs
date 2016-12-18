using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT.Model
{
    /*
    This class is a 'InsertReferenceParty' model. A logged in user will be able to insert the reference party's information such as the
    lawyer's frst name, last name, company name, address, city, state, ZIP, email, phone number, and fax number.
    */
    public class InsertReferencePartyModel
    {
        public int InsertReferencePartyID { get; set; }

        public string ReferenceFirstName { get; set; }

        public string ReferenceLastName { get; set; }

        public string ReferenceCompanyName { get; set; }

        public string ReferenceAddress { get; set; }

        public string ReferenceCity { get; set; }

        public string ReferenceState { get; set; }

        public string ReferenceZIP { get; set; }

        public string ReferenceEmail { get; set; }

        public string ReferencePhoneNumber { get; set; }

        public string ReferenceFaxNumber { get; set; }
    }
}
