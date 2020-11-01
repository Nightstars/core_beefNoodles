using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_beefNoodles.Models
{
    public class NoodleRepository : INoodleRepository
    {
        private readonly AppDbContext _appDbContext;

        public NoodleRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Noodle> GetAllNoodles()
        {
            return _appDbContext.Noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return _appDbContext.Noodles.FirstOrDefault(n => n.Id == id);
        }
    }
}
