using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Contracts_net_standart2.Models.Devices
{
    /// <summary>
    /// Запрос для удаления подключенного устройства
    /// </summary>
    public class DeleteDeviceRequest
    {
        public Guid id { get; set; }
    }
}
