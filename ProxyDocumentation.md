## Overview ##
The TibiaAPI proxy is constructed to be completely asynchronous, meaning it does not block or wait for data to be sent. Each method is called successively _when_ data is sent, and a typically login process follows the pattern below.

## Connection ##
1. Constructor

2. StartClientListener - the proxy listens for the client to connect

3. ClientConnected - the client connects, wait for it to send data

4. ClientLoginReceived - the client has sent data, either a char list login or game world login (RSA encrypted)
  * if client sent a game world login (ctrl+g, etc)
    * ConnectClientToGameWorld - connect the client directly to the game world and wait for data from each
  * else
    * continue

5. CharListReceived - the server sends the character list
  * ProcessCharListPacket - process it to make the client connect to the proxy and save the world data
6. RefreshClientListener - refresh the listener for the client because it will now send data directly to the "game world"

7. ClientReconnected - the client has reconnected to what it thinks is the game world

8. ClientGameLoginReceived - the client sends the username/password/character to the game world (RSA encrypted)
  * ConnectClientToGameWorld - send the login to the game world and wait for data from the client and server

## Forwarding ##
After the initial connection, data needs to be forwarded from the client->proxy->server and from the server->proxy->client. That is the job of ReceiveFromServer and ReceiveFromClient. They are started in ConnectClientToGameWorld and on each successive call begin another read.
  * ReceiveFromServer - data was received from the server, raise events on the data
    * RaiseIncomingEvents - if the event raised returns a null packet, don't send the data to the client
  * ReceiveFromClient - data was received from the client, raise events on the data
    * RaiseOutgoingEvents - if the event raised returns a null packet, don't send the data to the server

## Injecting packets ##
SendToServer and SendToClient allow you to inject packets into the client->server and server->client streams, either to perform actions on behalf of the client or send fake data to the client.
  * SendToServer - send a packet directly to the server (you provide the unencrypted packet)
  * SendToClient - send a packet directly to the client (you provide the unencrypted packet)

## Revised Proxy Flowchart (from the branch code) ##
![http://tibiaapi.googlecode.com/svn/trunk/documentation/proxy-flow-chart.png](http://tibiaapi.googlecode.com/svn/trunk/documentation/proxy-flow-chart.png)