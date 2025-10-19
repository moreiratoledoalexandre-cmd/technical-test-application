using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceRegistrationAPI.DBContext;
using DeviceRegistrationAPI.Entity;
using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;

namespace DeviceRegistrationAPI.Service
{
    public class DeviceRegistrationService : IDeviceRegistrationService
    {
        private readonly DeviceRegistrationContext _context;

        public DeviceRegistrationService(DeviceRegistrationContext context)
        {
            _context = context;
        }

        public string RegisterDevice(DeviceRegistrationRequest deviceRegistrationRequest)
        {
            try
            {
                if (!Enum.IsDefined(typeof(DeviceTypes), deviceRegistrationRequest.DeviceType))
                {
                    return "Device Type not Recognized";
                }

                var userDevices = new UserDevices();
                userDevices.Devices = new List<string>();

                var registredUser = _context.UserDevices.Find(deviceRegistrationRequest.UserKey);


                if (registredUser == null)
                {
                    userDevices.UserKey = deviceRegistrationRequest.UserKey;
                    userDevices.Devices.Add(deviceRegistrationRequest.DeviceType);
                    _context.UserDevices.Add(userDevices);
                }
                else
                {
                    userDevices = registredUser;
                    userDevices.Devices.Add(deviceRegistrationRequest.DeviceType);
                    _context.UserDevices.Update(userDevices);
                }

                _context.SaveChanges();
                return "OK";
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}