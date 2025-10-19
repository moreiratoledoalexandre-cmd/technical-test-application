using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StatisticsAPI.Entity;

namespace StatisticsAPI.Service
{
    public interface IStatisticsService
    {
        DeviceStatisticsResponse DeviceStatistics(string deviceFilter);
    }
}