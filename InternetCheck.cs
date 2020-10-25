using System.Net;
using System.Net.NetworkInformation;

namespace InternetMonitor
{
    public class InternetCheck
    {
        public static bool CheckForInternetConnection(int timeout_per_host_millis = 1000, string[] hosts_to_ping = null)
        {
            bool network_available = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

            if (network_available)
            {
                string[] hosts = hosts_to_ping ?? new string[] {"8.8.8.8", "www.google.com", "www.facebook.com"};

                Ping p = new Ping();

                foreach (string host in hosts)
                {
                    try
                    {
                        PingReply r = p.Send(host, timeout_per_host_millis);

                        if (r.Status == IPStatus.Success)
                            return true;
                    }
                    catch
                    {
                    }
                }
            }

            return false;
        }

        public static bool CheckForInternetConnection_V1()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}