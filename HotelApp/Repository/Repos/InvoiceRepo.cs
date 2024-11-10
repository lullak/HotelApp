namespace HotelApp.Repository.Repos
{
    public class InvoiceRepo
    {
        private readonly HotelAppDbContext _context;

        public InvoiceRepo(HotelAppDbContext context)
        {
            _context = context;
        }

    }

}
