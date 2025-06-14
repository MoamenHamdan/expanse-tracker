﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace expanse_tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        //category id 
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public String?  Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
