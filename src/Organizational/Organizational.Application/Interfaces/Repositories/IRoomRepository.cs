using Organizational.Domain.Entities;

namespace Organizational.Application.Interfaces.Repositories
{
    public interface IRoomRepository
    {
        public Task<bool> CreateRoom(Room room);
        public Task<IList<Room>> GetAllRooms();
        public Task<bool> UpdateRoom(string name);
        public Task<bool> DeleteRoom(string roomId);
        public Task<Room> GetRoomByName(string name);
        public Task<int> GetRoomCount();
    }
}
