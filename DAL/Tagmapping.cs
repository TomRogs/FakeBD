using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Tagmapping
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int SourceTagId { get; set; }
        public int TargetId { get; set; }
    }
}
