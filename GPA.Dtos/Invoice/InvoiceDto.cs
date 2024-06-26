﻿using GPA.Common.DTOs.Inventory;

namespace GPA.Common.DTOs.Invoices
{
    public class InvoiceDto
    {
        public Guid? Id { get; set; }
        public int Status { get; set; }
        public decimal Payment { get; set; }
        public int Type { get; set; }
        public DetailedDate Date { get; set; }
        public string? Note { get; set; }
        public Guid? ClientId { get; set; }

        public ICollection<InvoiceDetailDto> InvoiceDetails { get; set; }
    }
}
