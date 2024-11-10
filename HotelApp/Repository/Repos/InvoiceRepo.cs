using HotelApp.Repository.Entities;

namespace HotelApp.Repository.Repos
{
    public class InvoiceRepo
    {
        private readonly HotelAppDbContext _context;

        public InvoiceRepo(HotelAppDbContext context)
        {
            _context = context;
        }

        public Invoice CreateInvoice(decimal amount)
        {
            var newInvoice = new Invoice
            {
                Amount = amount,
                DateIssued = DateTime.Now,
                IsPaid = false
            };

            _context.Invoices.Add(newInvoice);
            _context.SaveChanges();

            return newInvoice;
        }

    }

}
