using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsThreadApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "진행중";
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100000;
            /*
                        for (int i = 0; i < 100000; i++)
                        {
                            progressBar1.Value = i;
                            Thread.Sleep(50); // 50ms 걸리는 처리할 일이 있음.
                        }*/
            // 스레드로 분리 윈폼의 화면스레드, 처리스레드 분리


            Thread th = new Thread(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    progressBar1.Value = i; 
                    Thread.Sleep(5); // 50ms 걸리는 처리할 일이 있음.
                }

            }); // 람다식으로 익명매서드 생성
            th.IsBackground = true;
            th.Start();

            button1.Text = "Start";
        }
    }
}
