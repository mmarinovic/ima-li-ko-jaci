using System.Collections.Generic;
using System.Linq;
using KisaMetaka.ImaLiKoJaci.Infrastructure.User;

namespace KisaMetaka.ImaLiKoJaci.Web.Helpers
{
    public interface IHubConnectionsStorage
    {
        void Add(UserDto user, string connectionId);
        void Remove(string connectionId);
        IEnumerable<UserDto> GetConnectedUsers();
    }

    public class HubConnectionsStorage : IHubConnectionsStorage
    {
        private static readonly Dictionary<string, UserDto> _connections = new Dictionary<string, UserDto>();

        public void Add(UserDto user, string connectionId)
        {
            lock (_connections)
            {
                if (!_connections.ContainsKey(connectionId))
                {
                    _connections.Add(connectionId, user);
                }
            }
        }

        public void Remove(string connectionId)
        {
            lock (_connections)
            {
                if (_connections.ContainsKey(connectionId))
                {
                    _connections.Remove(connectionId);
                }
            }
        }

        public IEnumerable<UserDto> GetConnectedUsers()
        {
            return _connections.Select(c => c.Value).ToList();
        } 
    }
}