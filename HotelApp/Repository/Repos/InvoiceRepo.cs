using HotelApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Repository.Repos
{
    public class InvoiceRepo
    {
        private readonly HotelAppDbContext _context;

        public InvoiceRepo(HotelAppDbContext context)
        {
            _context = context;
        }

        // Get all invoices
        public List<Invoice> GetAllInvoices()
        {
            return _context.Invoices.Include(i => i.Booking).ToList();
        }

        // Add invoice
        public void AddInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
        }

        // Update invoice
        public void UpdateInvoice(Invoice updatedInvoice)
        {
            var originalInvoice = _context.Invoices.SingleOrDefault(i => i.InvoiceId == updatedInvoice.InvoiceId);
            if (originalInvoice != null)
            {
                _context.Entry(originalInvoice).CurrentValues.SetValues(updatedInvoice);
                _context.SaveChanges();
            }
        }

        // Delete invoice
        public void DeleteInvoice(int invoiceId)
        {
            var invoice = _context.Invoices.SingleOrDefault(i => i.InvoiceId == invoiceId);
            if (invoice != null)
            {
                _context.Invoices.Remove(invoice);
                _context.SaveChanges();
            }
        }

        // Mark invoice as paid
        public void MarkInvoiceAsPaid(int invoiceId)
        {
            var invoice = _context.Invoices.SingleOrDefault(i => i.InvoiceId == invoiceId);
            if (invoice != null)
            {
                invoice.IsPaid = true;
                _context.SaveChanges();
            }
        }
    }

}
