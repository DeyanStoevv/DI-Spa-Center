using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spacentar.Data
{
    public class Procedure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProgramId {get; set;}
        public ProgramName ProgramName { get; set; }    
        public int Quantity { get; set;}
        public string Description { get; set; } 
        public string Photo { get; set; }   
      
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }  
         
        public DateTime DateofEntry  { get; set; }
      
        public virtual ICollection<Rezervation> Rezervations { get; set; } 

    }
}