using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a1 = textBox1.Text;
            int a2 = Convert.ToInt32(textBox2.Text);
            int a3 = Convert.ToInt32(textBox3.Text);
            string a4 = textBox4.Text;
            string a5 = textBox5.Text;
            string a6 = textBox6.Text;

            CPU<string> processor = new CPU<string>(a1, a2, a3, a4, a5, a6);
            processor.DisplayInfo(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a1 = textBox12.Text;
            int a2 = Convert.ToInt32(textBox11.Text);
            int a3 = Convert.ToInt32(textBox10.Text);
            int a4 = Convert.ToInt32(textBox9.Text);
            string a5 = textBox8.Text;
            int a6 = Convert.ToInt32(textBox7.Text);

            Videocard <string> processor = new Videocard <string>(a1, a2, a3, a4, a5, a6);
            processor.DisplayInfo(listBox1);
        }
    }
}
abstract class Components<T>
{
    public T artikul;
    public int price;
    public int date;

    public Components(T AR, int PR, int DaT)
    {
        artikul = AR;
        price = PR;
        date = DaT;
    }

    abstract public void DisplayInfo(ListBox L);

}

class CPU<T> : Components<T>
{
    string cpu_frequency;
    string number_Cores;
    string number_threads;

    string CPU_frequency { get { return cpu_frequency; } set { cpu_frequency = value; } }
    string Number_Cores { get { return number_Cores; } set { number_Cores = value; } }
    string Number_threads { get { return number_threads; } set { number_threads = value; } }

    public CPU(T AR, int PR, int DaT, string FRE, string COR, string THR)
       : base(AR, PR, DaT)
    {
        cpu_frequency = FRE;
        number_Cores = COR;
        number_threads = THR;
    }

    public override void DisplayInfo(ListBox L)
    {
        L.Items.Clear();
        L.Items.Add($"Артикул - {artikul}");
        L.Items.Add($"Дата изготовления - {date}");
        L.Items.Add($"Цена - {price}");
        L.Items.Add($"Частота - {CPU_frequency}");
        L.Items.Add($"Количество ядер - {Number_Cores}");
        L.Items.Add($"Количество потоков - {Number_threads}");
    }


}

class Videocard<T> : Components<T>
{

    int gpu_frequency;
    string maker;
    int memory;

    public int GPU_frequency { get { return gpu_frequency; } }
    public string Maker { get { return maker; } }
    public int Memory { get { return memory; } }

    public Videocard(T AR, int PR, int DaT, int FRE, string MAK, int MEM)
       : base(AR, PR, DaT)
    {
        gpu_frequency = FRE;
        maker = MAK;
        memory = MEM;
    }

    public override void DisplayInfo(ListBox L)
    {
        L.Items.Clear();
        L.Items.Add($"Артикул - {artikul}");
        L.Items.Add($"Дата изготовления - {date}");
        L.Items.Add($"Цена - {price}");
        L.Items.Add($"Частота - {GPU_frequency}");
        L.Items.Add($"Производитель - {Maker}");
        L.Items.Add($"Объём памяти - {Memory}");
    }
}