using POS.Domain.Entities;
using POS.Infrastructure.Persistences.Context;
using POS.Infrastructure.Persistences.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly PosContext _context;

        public CategoryRepository(PosContext context)
        {
            _context = context;
        }
    }
}
