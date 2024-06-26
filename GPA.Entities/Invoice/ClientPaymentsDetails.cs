﻿using GPA.Entities;

namespace GPA.Common.Entities.Invoice
{
    public class ClientPaymentsDetails : Entity<Guid>
    {
        public decimal PendingPayment { get; set; }
        public decimal Payment { get; set; }
        public DateTime Date { get; set; }
        public Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}
