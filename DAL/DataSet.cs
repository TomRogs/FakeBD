using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataSet
    {
        public List<Tags> Tags { get; set; }
        public List<Tagmapping> Tagmappings { get; set; }
        public List<Application> Applications { get; set; }

        public DataSet()
        {
            Tags.Add(new DAL.Tags { Id = 1, Key = "key1", Type = "type1", Value = "value1" });
            Tags.Add(new DAL.Tags { Id = 2, Key = "key2", Type = "type2", Value = "value2" });
            Tags.Add(new DAL.Tags { Id = 2, Key = "key3", Type = "type3", Value = "value3" });


        }
    }
}
