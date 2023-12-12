using System.Threading;

namespace Working_with_threads
{


    // Form1 - ����� ����� 1
    // Form2 - ����� �����2, ������� ����� ������ ��������� ����� �����
    // ��� ���� ��� ������� ����� 2 ����������� ������� ������ 2 ����� �����, ������� ��������� ������ ( ���� � ���� )  for (int i = 0; i < 100; i++)
    //            {
    //                for (int j = 0; j < 50000000; j++) { } // ��������� ��������, ����� ���������������
    //progressBar.Value = i;
    //lblPrc.Text = i.ToString();
    //            }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///������� ���� �������
        List<Thread> list = new List<Thread>();
        int n = 1; //����������  - ������� �������
        public void ThreadForm() // callback �������, ���������� �� ������� ������ ( ������� )
        {
            Form2 form = new Form2();
            form.Text = "Thread No " + n.ToString();
            n++;
            form.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e) // ������ ������ ��������� ����� �����
        {

            //������� �����
            Thread thread = new Thread(ThreadForm); thread.Start();
            thread.Name = "����� N " + n.ToString(); //��������� ���
            list.Add(thread); // �������� ����� � ������
            clbThread.Items.Add(thread.Name, true); // �������� ��������� �������, ����� ��� ���������� � CheckedListBox(); 
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