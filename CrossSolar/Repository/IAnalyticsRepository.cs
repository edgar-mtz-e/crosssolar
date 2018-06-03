using System.Collections.Generic;
using CrossSolar.Domain;

namespace CrossSolar.Repository
{
    public interface IAnalyticsRepository : 
        IGenericRepository<OneHourElectricity>
    {
        List<OneHourElectricity> GetPanel(int panelId);
    }
}