using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceRegistrationAPI.Entity;
using DeviceRegistrationAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace DeviceRegistrationAPI.Controller
{
    [ApiController]
    public class DeviceRegistrationController:ControllerBase
    {
        private readonly IDeviceRegistrationService _deviceRegistrationService;

        public DeviceRegistrationController(IDeviceRegistrationService deviceRegistrationService)
        {
            _deviceRegistrationService = deviceRegistrationService;
        }

        /// <summary>
        /// Register a new device for a specific user
        /// </summary>
        [Route("Device/register")]
        [HttpPost]
        public async Task<ActionResult<string>> InsertAsync([FromBody] DeviceRegistrationRequest request)
        {
            if (request == null)
                return BadRequest(new { message = "Invalid request body." });

            var response = _deviceRegistrationService.RegisterDevice(request);

            if (response != "OK")
            {
                return BadRequest(new { message = response });
            }

            return Ok(response);
        }
    }
}