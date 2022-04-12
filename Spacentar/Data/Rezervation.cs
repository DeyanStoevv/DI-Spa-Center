using System;

namespace Spacentar.Data
{
    public class Rezervation
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public Client Client { get; set; }  
        public int IdProcedure{ get; set; }
        public Procedure Procedure { get; set; }

        public DateTime DateProcedure { get; set; }
        
        
    }
}
