using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using System.Threading;
 

namespace SocketServidor
{
    class Chat
    {
        TcpClient clienteChat;
        string nombreUsuario;

        public Chat(TcpClient cliente, string nombreUsuario)
        {
            clienteChat = cliente;
            this.nombreUsuario = nombreUsuario;
            Thread ctThread = new Thread(doChat);
            ctThread.Start();
        }
        private void doChat()
        {
            byte[] bytesFrom = new byte[256];
            string mensajeCliente = null;

            while ((true))
            {
                try
                {
                    NetworkStream networkStream = clienteChat.GetStream();

                    networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                    mensajeCliente = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    mensajeCliente = mensajeCliente.Substring(0, mensajeCliente.IndexOf("$"));
                    Form1.DifundirATodos(mensajeCliente, nombreUsuario, true);
                }
                catch (Exception)
                {
                    //Manejo de Excepcion
                }
            }
        }

    }
}
