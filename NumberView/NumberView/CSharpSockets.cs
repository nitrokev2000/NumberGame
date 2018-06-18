using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NumberView
{
    public class CSharpSockets
    {
        private ClientLevel clientLevel = new ClientLevel();
        private LinkedList linkedList = new LinkedList();

        private class ClientLevel {
            private string IP;
            public int received;
            IPEndPoint serverAddress;
            Socket clientSocket;

            public void Recieve(Socket clientSocket)
            {
                // Receiving
                byte[] rcvLenBytes = new byte[4];
                clientSocket.Receive(rcvLenBytes);
                int rcvLen = System.BitConverter.ToInt32(rcvLenBytes, 0);
                byte[] rcvBytes = new byte[rcvLen];
                clientSocket.Receive(rcvBytes);
                string rcv = System.Text.Encoding.ASCII.GetString(rcvBytes);

                Console.WriteLine("received: " + rcv);
                if (rcv.Contains("Test"))
                {
                    rcv = "0";
                }
                else
                {
                    received = int.Parse(rcv);
                }
            }

            public void Close()
            {
                clientSocket.Close();
            }

            public void Send(Socket clientSocket, string toSend)
            {
                // Sending
                int toSendLen = System.Text.Encoding.ASCII.GetByteCount(toSend);
                byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(toSend);
                byte[] toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
                clientSocket.Send(toSendLenBytes);
                clientSocket.Send(toSendBytes);
            }

            public void SetIP(string vIP)
            {
                IP = vIP;
            }

            public string GetIP()
            {
                return IP;
            }

            public Socket GetSocket()
            {
                return clientSocket;
            }

            public IPEndPoint GetAddress()
            {
                return serverAddress;
            }

            public void SetSocket(Socket socket)
            {
                clientSocket = socket;
            }

            public void SetAddress(IPEndPoint endPoint)
            {
                serverAddress = endPoint;
            }

            public int GetRecieved()
            {
                return received;
            }
        }

        public CSharpSockets(string vIP)
        {
            //Initialize
            clientLevel.SetIP(vIP);
            Initialize();
            Console.WriteLine("Connection successful");
            clientLevel.Send(clientLevel.GetSocket(), "Test Connection");
            clientLevel.Recieve(clientLevel.GetSocket());
            clientLevel.Close();
        }

        public void Initialize()
        {
            clientLevel.SetAddress(new IPEndPoint(IPAddress.Parse(clientLevel.GetIP()), 4343));
            clientLevel.SetSocket(new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp));
            clientLevel.GetSocket().Connect(clientLevel.GetAddress());
        }

        public void SendData(string toSend)
        {
            // Send / Recieve Data
            Initialize();
            clientLevel.Send(clientLevel.GetSocket(), toSend);
            clientLevel.Recieve(clientLevel.GetSocket());
            PrintLog();
            clientLevel.Close();
        }

        private void PrintLog()
        {
            // Printing
            Console.WriteLine("====LOG====");
            linkedList.Insert(clientLevel.received);
            linkedList.PrintList();
            Console.WriteLine("===========");
        }

        public int GetRecieved()
        {
            int recieved;
            recieved = clientLevel.GetRecieved();
            return recieved;
        }
    }
}
