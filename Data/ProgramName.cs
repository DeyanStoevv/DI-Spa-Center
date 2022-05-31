using System.Collections.Generic;

namespace Spacentar.Data
{
    public class ProgramName
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Procedure> Procedures { get; set; }
    }
}
