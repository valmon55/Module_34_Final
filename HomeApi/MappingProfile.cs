using AutoMapper;
using HomeApi.Configuration;
using HomeApi.Contracts_net_standart2.Models.Devices;
using HomeApi.Contracts_net_standart2.Models.Home;
using HomeApi.Contracts_net_standart2.Models.Rooms;
using HomeApi.Data.Models;

namespace HomeApi
{
    /// <summary>
    /// Настройки маппинга всех сущностей приложения
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// В конструкторе настроим соответствие сущностей при маппинге
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Address, AddressInfo>();
            CreateMap<HomeOptions, InfoResponse>()
                .ForMember(m => m.AddressInfo,
                    opt => opt.MapFrom(src => src.Address));
            
            // Валидация запросов:
            CreateMap<AddDeviceRequest, Device>()
                .ForMember(d => d.Location,
                    opt => opt.MapFrom(r => r.RoomLocation));
            CreateMap<AddRoomRequest, Room>();
            CreateMap<EditRoomRequest, Room>();
            CreateMap<Device, DeviceView>();
            CreateMap<Room, RoomView>();
        }
    }
}