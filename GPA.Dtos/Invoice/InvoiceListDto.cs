﻿using GPA.Common.DTOs.Inventory;
using GPA.Common.DTOs.Invoice;

namespace GPA.Common.DTOs.Invoices
{
    public class InvoiceListDto
    {
        public Guid? Id { get; set; }
        public string Status { get; set; }
        public int Type { get; set; }
        public DetailedDate? ExpirationDate { get; set; }
        public DetailedDate? Date { get; set; }
        public string? Note { get; set; }
        public Guid ClientId { get; set; }
        public ClientDto Client { get; set; }

        public ICollection<InvoiceListDetailDto> InvoiceDetails { get; set; }
    }
}
