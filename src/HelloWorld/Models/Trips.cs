using System;
using System.Collections.Generic;

namespace HelloWorld.Models
{
    public partial class Trips
    {
        public Trips()
        {
            Stops = new HashSet<Stops>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Stops> Stops { get; set; }
    }
}
