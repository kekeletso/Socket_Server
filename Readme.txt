Readme
------------------------------------------------------------------------
Name
Server and Client program using Sockets
Available on: https://github.com/kekeletso/Socket_Server
------------------------------------------------------------------------
Description
The program has two files, the client and server. The server is started first and then the client. The client connects to the server and allows user to ping an ip address.
-----------------------------------------------------------------------
Language and namespace
Language: C#
Namespace: System.Net.Sockets, System.Threading, System.Net.NetworkInformation
------------------------------------------------------------------------
Features
Server program
It is a console application.
When run it, it displays on command prompt.
Once started it shows Server started message.

Client Server
It is a Windows Forms Application.
It has one form, which has label for ip address, textbox for ip address, button for execute, label for response and textbox to display results.
------------------------------------------------------------------------
System requirements
Visual Studio (2013)
Command prompt
Notepad
------------------------------------------------------------------------
Source files
1. ServersS.cs
2. ClientS.cs
3. Readme.txt
------------------------------------------------------------------------
Operating instructions
Server program
1. Open ServerS in Visual Studio. 
2. Run ServerS. 
3. It will start the server. 
4. You will be prompted to enter server address and port number.

Client program
1. Open ClientS in Visual Studio.
2. Run ClientS.
3. It will connect to the started server.
4. The interface form will load.
5. User can then enter the IP address that they want to ping.
6. Then click on the button to ping the address
7. In a few seconds the server response will be displayed in the Server respone textbox. 
8. If ping was successful 'Successful' will be displayed in response texbox.
9. If ping was not successful 'Failed' will be displayed in response texbox.
10. A different IP address can be input without exiting the program.
------------------------------------------------------------------------