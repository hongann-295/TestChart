using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestChart.DAL.Interface;
using TestChart.Domain.Request.ChartGender;

namespace TestChart.DAL
{
    public class ChartRepository : IChartRepository
    {
        public Task<IEnumerable<GetGender>> Gets()
        {
            throw new NotImplementedException();
        }
    }
}
