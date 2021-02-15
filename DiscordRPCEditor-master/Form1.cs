using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

/*
 * 
 * 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
*
*
*/

namespace Desktop_Wallpaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DiscordRpcClient client;
        bool initialized = false;

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            initialized = true;
            client = new DiscordRpcClient($"{clientID.Text}");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();

            
        }

        private void restart_Click(object sender, EventArgs e)
        {
            if(initialized == false)
            {
                MessageBox.Show("Complete everything to begin!");
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = $"{details.Text}",
                    State = $"{state.Text}",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = $"{lik.Text}",
                        LargeImageText = $"{lit.Text}",
                        SmallImageKey = $"{sik.Text}",
                        SmallImageText = $"{sit.Text}"
                    }
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string dev = "https://discord.com/developers/applications";
            //Process.Start(dev);
            MessageBox.Show("Coming Soon!");
        }
    }
}
