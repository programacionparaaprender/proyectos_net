using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace SocketServidor
{
    public partial class Form1 : Form
    {
        private ClaseBlowfish b12 = null;
        private string cipherText;

        private bool bandera = false;
        private TcpListener servidor;

        private static Hashtable clientes_conectados;

        private String _mensajeChat;

        private String mensajeCliente;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                btnIniciar.Enabled = false;
                btnDetener.Enabled = true;

                Thread tarea = new Thread(Tarea);
                tarea.Start();

            }
            catch (Exception ex)
            {
                _mensajeChat = ex.ToString();
                Mensaje();
            }

        }

//traduccion de lo que se dice

        private void Tarea()
        {
            try
            {
                clientes_conectados = new Hashtable();
                servidor = new TcpListener(IPAddress.Parse(txtIP.Text), int.Parse(txtPuerto.Text));
                servidor.Start();
                _mensajeChat = "Servidor Iniciado...";
                while (true)
                {
                    TcpClient cliente = servidor.AcceptTcpClient();
                    Byte[] bytesCliente = new byte[256];
                    NetworkStream streamCliente = cliente.GetStream();
                    streamCliente.Read(bytesCliente, 0, bytesCliente.Length);
                    mensajeCliente = Encoding.ASCII.GetString(bytesCliente, 0, bytesCliente.Length);
                    mensajeCliente = mensajeCliente.Substring(0, mensajeCliente.IndexOf("$"));
                    if (!clientes_conectados.ContainsKey(mensajeCliente))
                    {
                        clientes_conectados.Add(mensajeCliente, cliente);
                        _mensajeChat = string.Format("{0} se ha unido al servidor", mensajeCliente);
                        Mensaje();
                    }

                    string textobox = b12.Decrypt_CBC(mensajeCliente);
                    //DifundirATodos(mensajeCliente, mensajeCliente, false);
                    //Chat chat = new Chat(cliente, mensajeCliente);
                    DifundirATodos(textobox, textobox, false);
                    Chat chat = new Chat(cliente, textobox);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                servidor.Stop();
            }

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (servidor != null && servidor.Server.Connected)
            {
                btnIniciar.Enabled = true;
                btnDetener.Enabled = false;
                bandera = true;
                //servidor.Stop();
            }
        }

        //zona de desencriptacion de los mensajes enviados

        public static void DifundirATodos(string mensaje, string nombre, bool flag)
        {
            try
            {
                foreach (DictionaryEntry Item in clientes_conectados)
                {
                    byte[] bytes = null;
                    TcpClient cliente;
                    cliente = (TcpClient)Item.Value;

       
                    NetworkStream streamCliente = cliente.GetStream();
                    if (flag == true)
                        bytes = Encoding.ASCII.GetBytes(nombre + " dice: " + mensaje);
                        
                    else
                        bytes = Encoding.ASCII.GetBytes(nombre + " se ha conectado");

                    streamCliente.Write(bytes, 0, bytes.Length);
                    streamCliente.Flush();

                }
            }
            catch { }

        }



        public void Mensaje()
        {
            b12 = new ClaseBlowfish("04B915BA43FEB5B6");
            string textobox = b12.Decrypt_CBC(mensajeCliente);

            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(Mensaje));
            else
                //txtChat.Text = txtChat.Text + Environment.NewLine + "->" + mensajeCliente;
                txtChat.Text = txtChat.Text + Environment.NewLine + "->" + textobox;
        }

    }
}
