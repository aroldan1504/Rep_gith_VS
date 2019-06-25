using System;
using System.Collections.Generic;


namespace Creacional_Singleton
{
    class LoadBalancer

    {
        private static LoadBalancer _instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        // Lock synchronization object

        private static object syncLock = new object();

        // Constructor (protected)

        protected LoadBalancer()
        {
            // List of available servers

            _servers.Add("Servidor I");
            _servers.Add("Servidor II");
            _servers.Add("Servidor III");
            _servers.Add("Servidor IV");
            _servers.Add("Servidor V");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded applications through

            // 'Double checked locking' pattern which (once

            // the instance exists) avoids locking each

            // time the method is invoked

            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        // Simple, but effective random load balancer

        public string Server
        {
            get

            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}
