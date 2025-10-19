using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StatisticsAPI.DBContext;
using StatisticsAPI.Entity;

namespace StatisticsAPI.Service
{
    public class StatisticsService : IStatisticsService
    {
        private readonly LogHistoryContext _context;

        public StatisticsService(LogHistoryContext context)
        {
            _context = context;
        }
        public DeviceStatisticsResponse DeviceStatistics(string deviceFilter)
        {
            DeviceTypes deviceType;
            DeviceStatisticsResponse response = new DeviceStatisticsResponse();

            if (!Enum.TryParse(deviceFilter, out deviceType))
            {
                response.DeviceType = deviceFilter;
                response.Count = -1;
                return response;
            }

            
            response.DeviceType = deviceFilter;
            response.Count = _context.LogHistory.Where(d => d.DevicesType == deviceType).Count();;
            return response;
        }
    }
}