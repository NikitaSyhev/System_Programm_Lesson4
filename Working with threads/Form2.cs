using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Working_with_threads
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            childThread = new Thread(AddProgress);// объявили поток
            childThread.Start(); //создали поток
        }


        public Thread childThread;
        
        public void AddProgress()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 50000000; j++) { } // программа зависает, нужна многопоточность
                progressBar.Value = i;
                lblPrc.Text = i.ToString();
            }
        }
    }
}
