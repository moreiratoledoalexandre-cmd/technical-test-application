using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StatisticsAPI.Entity;
using StatisticsAPI.Service;

namespace StatisticsAPI.Controller
{
    [ApiController]
    public class StatisticsController:ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IStatisticsService _statisticsService;

        public StatisticsController(IAuthService authService, IStatisticsService statisticsService)
        {
            _authService = authService;
            _statisticsService = statisticsService;
        }

        /// <summary>
        /// Register a new user login on a specific device
        /// </summary>
        [Route("Log/auth")]
        [HttpPost]
        public async Task<ActionResult<string>> InsertAsync([FromBody] DeviceLogRequest request)
        {
            if (request == null)
                return BadRequest(new { message = "Invalid request body." });

            var response = await _authService.DeviceLog(request);

            if (response != "success")
            {
                return BadRequest(new { message = response });
            }

            return Ok(response);
        }
        
        /// <summary>
        /// Get sum of all users login for a specific device type
        /// </summary>
        [Route("Log/auth/statistics")]
        public async Task<ActionResult<DeviceStatisticsResponse>> GetStatistics([FromRoute] string filter)
        {
            var response = _statisticsService.DeviceStatistics(filter); 
            return Ok(response);
        }
    }
}