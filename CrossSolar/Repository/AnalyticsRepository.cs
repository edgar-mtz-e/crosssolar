using System.Collections.Generic;
using CrossSolar.Domain;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrossSolar.Repository
{
    // GenericRepository<OneHourElectricity>, IAnalyticsRepository
    public class AnalyticsRepository : 
        GenericRepository<OneHourElectricity>, 
        IAnalyticsRepository
    {
        public AnalyticsRepository(CrossSolarDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public List<OneHourElectricity> GetPanel(int panelId)
        //{
        //    return _dbContext.OneHourElectricitys.
        //        Where(p => p.PanelId == panelId).
        //        OrderBy(date=>date.DateTime).ToList();
        //}
        public Task<List<OneHourElectricity>> GetByPanelId(int panelId)
        {
               return _dbContext.OneHourElectricitys.
                   Where(p => p.PanelId == panelId).
                   OrderBy(date=>date.DateTime).ToListAsync();
        }

        public List<OneHourElectricity> GetPanel(int panelId)
        {
            return _dbContext.OneHourElectricitys.Where(e => e.PanelId == panelId).OrderBy(s => s.DateTime).ToList();
        }
    }
}