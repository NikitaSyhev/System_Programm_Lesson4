using System.Threading;

namespace Working_with_threads
{


    // Form1 - поток номер 1
    // Form2 - поток номер2, нажатие кажой кнопки запускает новый поток
    // при этом при запуске Формы 2 запускается внутрри потока 2 новые поток, который запсуакет расчет ( цикл в коде )  for (int i = 0; i < 100; i++)
    //            {
    //                for (int j = 0; j < 50000000; j++) { } // программа зависает, нужна многопоточность
    //progressBar.Value = i;
    //lblPrc.Text = i.ToString();
    //            }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///создаем ЛИСТ потоков
        List<Thread> list = new List<Thread>();
        int n = 1; //переменная  - счетчик потоков
        public void ThreadForm() // callback функция, вызывается из другого метода ( функции )
        {
            Form2 form = new Form2();
            form.Text = "Thread No " + n.ToString();
            n++;
            form.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e) // каждая кнопка запускает новый поток
        {

            //создали поток
            Thread thread = new Thread(ThreadForm); thread.Start();
            thread.Name = "Поток N " + n.ToString(); //присвоили имя
            list.Add(thread); // добавили поток в список
            clbThread.Items.Add(thread.Name, true); // передали названипе потоков, чтобы они выводились в CheckedListBox(); 
        }

        [Obsolete]
        private void btnStop_Click(object sender, EventArgs e)
        {
            foreach (object ItemChecked in clbThread.CheckedItems)
            {
                foreach (Thread thread in list)
                {
                    if (thread.Name == ItemChecked.ToString())
                        thread.Suspend();
                }
            }

        }

        [Obsolete]
        private void btnResume_Click(object sender, EventArgs e)
        {
            foreach (object ItemChecked in clbThread.CheckedItems)
            {
                foreach (Thread thread in list)
                {
                    if (thread.Name == ItemChecked.ToString())
                        thread.Resume();
                }
            }
        }
    }
}