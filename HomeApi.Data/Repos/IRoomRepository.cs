using System;
using System.Threading.Tasks;
using HomeApi.Data.Models;
using HomeApi.Data.Queries;

namespace HomeApi.Data.Repos
{
    /// <summary>
    /// Интерфейс определяет методы для доступа к объектам типа Room в базе 
    /// </summary>
    public interface IRoomRepository
    {
        Task<Room[]> GetRooms();
        Task<Room> GetRoomByName(string name);
        Task<Room> GetRoomById(Guid id);
        Task AddRoom(Room room);
        Task UpdateRoom(Room room, UpdateRoomQuery query);
    }
}