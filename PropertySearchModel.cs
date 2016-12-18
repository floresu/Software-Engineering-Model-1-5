using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT.Model
{
    /* 
    This class is a 'PropertySearch' model. The user will be able to search a property based on the property's name, address, city, state,
    ZIP, township, county, and status.
    */
    public class PropertySearchModel
    {
        public int PropertySearchID { get; set; }

        public string PropertyName { get; set; }

        public string PropertyAddress { get; set; }

        public string PropertyCity { get; set; }

        public string PropertyState { get; set; }

        public string PropertyZIP { get; set; }

        public string PropertyTownship { get; set; }

        public string PropertyCounty { get; set; }

        public string PropertyStatus { get; set; }
    }
}
