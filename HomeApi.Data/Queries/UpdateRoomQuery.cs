using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Data.Queries
{
    public class UpdateRoomQuery
    {
        public string NewName { get; }
        public int? NewArea { get; }
        public bool? NewGasConnected { get; }
        public int? NewVoltage { get; }
        public UpdateRoomQuery(string newName = null,
                               int? newArea = null,
                               bool? newGasConnected = null,
                               int? newVoltage =  null
                                ) 
        {
            NewName= newName;
            NewArea= newArea;
            NewGasConnected= newGasConnected;
            NewVoltage= newVoltage;
        }
    }
}
