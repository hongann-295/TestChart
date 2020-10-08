using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestChart.Domain.Request.ChartGender;

namespace TestChart.DAL.Interface
{
    public interface IChartRepository
    {
        Task<IEnumerable<GetGender>> Gets();
    }
}
