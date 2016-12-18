using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT.Model
{
    /*
    This clas is a 'ReferencePartySearch' model. A logged in user will be able to search a refence by the first name, last name, and
    the name of the company.
    */

    public class ReferencePartySearchModel
    {
        public int ReferencePartySearchID { get; set; }

        public string ReferenceFirstName { get; set; }

        public string ReferenceLastName { get; set; }

        public string ReferenceCompany { get; set; }
    }
}
