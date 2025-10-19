using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using StatisticsAPI.DBContext;
using StatisticsAPI.Entity;

namespace StatisticsAPI.Service
{
    public class AuthService : IAuthService
    {
        private DeviceRegisterAPIConfig _config;
        private readonly LogHistoryContext _context;
        private IHttpClientFactory _httpClientFactory;

        public AuthService(LogHistoryContext context, IHttpClientFactory httpClientFactory, IOptions<DeviceRegisterAPIConfig> config)
        {
            _context = context;
            _httpClientFactory = httpClientFactory;
            _config = config.Value;
        }


        public async Task<string> DeviceLog(DeviceLogRequest deviceLog)
        {
            try
            {
                DeviceTypes deviceType;    
                
                if (!Enum.TryParse(deviceLog.DeviceType, out deviceType))
                {
                    return "bad_request";
                }
                

                HttpClient client = _httpClientFactory.CreateClient();

                client.BaseAddress = _config.Uri;

                HttpResponseMessage response = await client.PostAsJsonAsync("Device/register", deviceLog);

                if (response.IsSuccessStatusCode)
                {
                    var responseBodySucess = await response.Content.ReadAsStringAsync();
                    var LogAttempt = new LogHistory()
                    {
                        UserKey = deviceLog.UserKey,
                        DevicesType = deviceType,
                        DeviceDescription = deviceLog.DeviceType
                    };
                    _context.LogHistory.Add(LogAttempt);
                    _context.SaveChanges();
                    return "success";    

                }
                else
                {
                    var responseBodyError = await response.Content.ReadAsStringAsync();
                    return "bad_request";
                }
                
                
                
            }
            catch (System.Exception)
            {
                return "bad_request";
            }
        }
    }
}