using Bruh.DAL;
using System.Collections.Generic;
using System.Linq;

namespace Bruh.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;

        public LayoutServices(AppDbContext context)
        {
            _context = context;
        }

        public Dictionary<string,string> GetSettings()
        {
            return _context.Setting.ToDictionary(s => s.Key, s => s.Value);
        }
            
    }
}
