using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServersS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Starting server...");
          
                
            //display prompt for ip address
            //get server ip address to connect to
            Console.Write("Enter server ip address:"); 
            var m1 = Console.ReadLine();

            //display prompt for port number
            //get port number to connect to
            Console.Write("Enter server port number:");
            var m2 = Console.ReadLine();
               
            //define port variable
            //parse it into interger
             int port;
             int.TryParse(m2, out port);           
            
            //assign received ip address
            //parse it
             IPAddress ipAddress = IPAddress.Parse(m1);

            //initialise lister
            //pass ip address and port number
             TcpListener serverSocket = new TcpListener(ipAddress, port);
             int requestCount = 0;
             TcpClient clientSocket = default(TcpClient);
             //start method
             serverSocket.Start();
             Console.WriteLine(" >> Server Started");
             clientSocket = serverSocket.AcceptTcpClient();
             Console.WriteLine(" >> Accept connection from client");
             requestCount = 0;
            

            //loop to check client request
             while ((true))
             {
                 try
                 {
                     requestCount = requestCount + 1;
                     //read data
                     NetworkStream networkStream = clientSocket.GetStream();
                     byte[] bytesFrom = new byte[10025];
                     networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                     string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                     dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                     Console.WriteLine(" >> Data from client - " + dataFromClient);
                     string serverResponse = "Last Message from client" + dataFromClient;
                     Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                     networkStream.Write(sendBytes, 0, sendBytes.Length);
                     networkStream.Flush();
                     Console.WriteLine(" >> " + serverResponse);
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine(ex.ToString());
                 }
                clientSocket.Close();
                serverSocket.Stop();
                Console.WriteLine(" >> exit");
                Console.ReadLine();
            }

            
        }
    }
}
