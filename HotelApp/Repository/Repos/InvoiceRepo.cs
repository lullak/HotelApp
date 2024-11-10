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

    }

}
