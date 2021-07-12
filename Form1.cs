using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.WebSocket;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DiscordSocketClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            ulong id = Convert.ToUInt64(channeli_id_tb.Text);
            var chnl = client.GetChannel(id) as IMessageChannel;
            string msg = send_message.Text;
            chnl.SendMessageAsync(msg);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            client = new DiscordSocketClient(new DiscordSocketConfig()
            {
                LogLevel = LogSeverity.Verbose
            });

            client.Log += Log;
            client.MessageReceived += CommandsHaddler;

            try
            {
                await client.LoginAsync(TokenType.Bot, token_tb.Text);
                await client.StartAsync();
            }
            catch
            {
                MessageBox.Show("Error occured while connection your bot", "ERROR");
                return;
            }
            await Task.Delay(1000);
        }

        private Task Log(LogMessage arg)
        {
            Invoke((Action)delegate
            {
                console_output_tb.AppendText(arg + "\n");
            });
            return null;
        }
        public Task CommandsHaddler(SocketMessage msg)
        {
            Invoke((Action)delegate
            {
            string texttomsg = msg.Content.ToString();
             messages_tb.AppendText($"[{msg.Author.ToString()}]: " + texttomsg + "\r\n");
            });
            return null;
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
