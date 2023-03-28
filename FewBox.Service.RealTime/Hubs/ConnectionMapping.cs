using System.Collections.Generic;
using System.Linq;

namespace FewBox.Service.RealTime.Hubs
{
    public class ConnectionMapping<T>
    {
        private readonly IDictionary<T, HashSet<string>> Connections = new Dictionary<T, HashSet<string>>();

        public int Count
        {
            get
            {
                return Connections.Count;
            }
        }

        public void Add(T key, string connectionId)
        {
            lock (Connections)
            {
                HashSet<string> connections;
                if (!Connections.TryGetValue(key, out connections))
                {
                    connections = new HashSet<string>();
                    Connections.Add(key, connections);
                }

                lock (connections)
                {
                    connections.Add(connectionId);
                }
            }
        }

        public IEnumerable<string> GetConnections(T key)
        {
            HashSet<string> connections;
            if (Connections.TryGetValue(key, out connections))
            {
                return connections;
            }

            return Enumerable.Empty<string>();
        }

        public void Remove(T key, string connectionId)
        {
            lock (Connections)
            {
                HashSet<string> connections;
                if (!Connections.TryGetValue(key, out connections))
                {
                    return;
                }

                lock (connections)
                {
                    connections.Remove(connectionId);

                    if (connections.Count == 0)
                    {
                        Connections.Remove(key);
                    }
                }
            }
        }
    }
}