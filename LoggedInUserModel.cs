using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT.Model
{
    /*
    This is a 'LoggedInUser' model. A logged in user will have access to create a new property job, insert a new reference party,
    search a property, and search a reference from the database.
    */

    public class LoggedInUserModel
    {
        public int LoggedInUserID { get; set; }

        public string Username { get; set; }

        public string Password { get; set;}

        public int NewPropertyJobInsertID { get; set; } // A foreign key from the 'NewPropertyJobInsert' identity.

        public int InsertReferencePartyID { get; set; }

        public int PropertySearchID { get; set; }

        public int ReferencePartSearchID { get; set; }
    }
}
