using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Journal
    {
        public int ID { get; set; }

       // [Display(Name = "Scripture")]
        public string Book { get; set; }
        public string Chapter { get; set; }
        public string Verse { get; set; }


        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        public string Note { get; set; }
        //public decimal Price { get; set; }
    }
}
