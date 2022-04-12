using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Classes
{
    public class FeatureCollection
    {
        public string type;

        //This must be a list because it's an array of objects in our json file
        public IList<Features> features;
    }
}
