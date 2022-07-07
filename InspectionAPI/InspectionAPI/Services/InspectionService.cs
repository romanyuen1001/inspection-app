using InspectionAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace InspectionAPI.Services
{
    public class InspectionService : IInspectionService
    {
        private DataContext _context;

        public InspectionService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<InspectionType>> ReturnWhatever()
        {
            if (_context.InspectionTypes == null)
                return null;

            // return (await _context.InspectionTypes.ToListAsync()).Select(x => new { Id = x.Id });
            return await _context.InspectionTypes.ToListAsync();
        }
    }
}
