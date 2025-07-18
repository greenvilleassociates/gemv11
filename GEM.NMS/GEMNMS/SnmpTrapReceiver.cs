
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NmsService
{
    public class SnmpTrapReceiver
    {
        public void StartListening()
        {
            // Bind to UDP port 162 (SNMP trap port)
            UdpClient udpClient = new UdpClient(10162);
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

            Console.WriteLine("Listening for SNMP traps on port 10162...");

            try
            {
                while (true)
                {
                    // Receive data from sender
                    byte[] receivedBytes = udpClient.Receive(ref remoteEndPoint);

                    // Decode the SNMP trap
                    string trapData = Encoding.UTF8.GetString(receivedBytes);
                    Console.WriteLine($"Received SNMP trap from {remoteEndPoint.Address}:\n{trapData}");

                    // Add custom logic to handle the SNMP trap data
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine($"Socket exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                udpClient.Close();
            }
        }
    }
}
