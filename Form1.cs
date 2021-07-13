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

        private void button1_Click(object sender, EventArgs e)

        {
            ulong id = Convert.ToUInt64(channeli_id_tb.Text);
            var chnl = client.GetChannel(id) as IMessageChannel;
            string msg = send_message.Text;
            chnl.SendMessageAsync(msg);

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
             messages_tb.AppendText($"[{msg.Author.ToString()}]: " + msg.Content.ToString() + "\r\n");
            });
            return null;
        }
    }
}
