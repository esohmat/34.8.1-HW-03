using System.ComponentModel.DataAnnotations;

namespace HomeApi.Contracts.Models.Devices
{
    /// <summary>
    /// Удалить устройство
    /// </summary>
    public class DeleteDeviceRequest
    {
        public string Name { get; set; }
    }
}