using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED___Programa_21.ColasFIFO
{
    public partial class Form1 : Form
    {
        static Random random = new Random(DateTime.Now.Millisecond);
        Cola cola = new Cola();
        int vacio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            for (short i = 0; i < 10; i++)
            {
                Proceso auxiliar = cola.Pop();
                if (auxiliar != null && auxiliar.ciclos != 1)
                    auxiliar.ciclos--;
                else if (auxiliar != null)
                    cola.Dequeue();
                else
                {
                    vacio++;
                }
                if (random.Next(1, 5) == 1)
                {
                    Proceso nuevo = new Proceso();
                    cola.Enqueue(nuevo);
                }
            }
            txtInfo.Text = "Ciclos vacíos: " + vacio.ToString() + Environment.NewLine + cola.ToString() + Environment.NewLine;
        }
    }
}
