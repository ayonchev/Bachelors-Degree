using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndAwait
{
    public partial class MainForm : Form
    {
        const string qotdUrl = @"https://nvp-functions.azurewebsites.net/api/qotd?slow-true";
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQotdSync_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var stream = client.OpenRead(qotdUrl);

            using (StreamReader reader = new StreamReader(stream))
            {
                var s = reader.ReadLine();
                lbQotd.Text = s;
            }
        }

        private void btnQotdThread_Click(object sender, EventArgs e)
        {
            ThreadStart worker = () =>
            {
                WebClient client = new WebClient();
                var stream = client.OpenRead(qotdUrl);

                using (StreamReader reader = new StreamReader(stream))
                {
                    var s = reader.ReadLine();
                    //Making sure the action is executed on the UI thread
                    this.Invoke((Action)
                        (() => lbQotd.Text = s));
                    lbQotd.Text = s;
                }
            };

            Thread aThread = new Thread(worker);
            aThread.Start();
        }

        private void btnQotdAsyncResult_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            client.OpenReadAsync(new Uri(qotdUrl));
            client.OpenReadCompleted += (s, cliEventArgs) =>
            {
                var stream = cliEventArgs.Result;

                using (StreamReader reader = new StreamReader(stream))
                {
                    var line = reader.ReadLine();
                    lbQotd.Text = line;
                }
            };
        }

        private async void btnQotdAsync_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var stream = await client.OpenReadTaskAsync(qotdUrl);

            using (StreamReader reader = new StreamReader(stream))
            {
                var line = await reader.ReadLineAsync();
                lbQotd.Text = line;
            }
        }
    }
}
