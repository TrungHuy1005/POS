﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int Total { get; set; }
        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
