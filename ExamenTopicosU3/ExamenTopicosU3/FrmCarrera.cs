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
using MetroFramework.Forms;

namespace ExamenTopicosU3
{
    public partial class FrmCarrera : MetroForm
    {
        bool TerminoProceso1 = false, TerminaCarrera = false;
        Dictionary<string, string> HiloControl = new Dictionary<string, string>();
        List<Thread> hilos = new List<Thread>();
        int Width = 0;
        public FrmCarrera()
        {
            InitializeComponent();
        }

        public FrmCarrera(String texto1, String texto2)
        {
            InitializeComponent();
            lblNumCorr.Text = texto1;
            lblNumVueltas.Text = texto2;
            Width = this.Size.Width;
        }

        public void GetHoraDelegate()
         {
             while (!TerminoProceso1)
             {
                 Invoke(new MethodInvoker(delegate ()
                 {
                     lblReloj.Text = string.Format("{0}:{1}:{2}",
                     System.DateTime.Now.Hour.ToString().PadLeft(2, '0'),
                     System.DateTime.Now.Minute.ToString().PadLeft(2, '0'),
                     System.DateTime.Now.Second.ToString().PadLeft(2, '0'));
                 }));
             }

         }

         private void FrmCarrera_Shown(object sender, EventArgs e)
         {
            bgHora.RunWorkerAsync();
         }

        private void FrmCarrera_Load(object sender, EventArgs e)
        {
            if (lblNumCorr.Text == "1")
            {
                pctSanta1.Visible = true;
                pctSanta2.Visible = false;
                pctSanta3.Visible = false;
            }
            if (lblNumCorr.Text == "2")
            {
                pctSanta1.Visible = true;
                pctSanta2.Visible = true;
                pctSanta3.Visible = false;
            }
            if (lblNumCorr.Text == "3")
            {
                pctSanta1.Visible = true;
                pctSanta2.Visible = true;
                pctSanta3.Visible = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmInicio Regresar = new FrmInicio();
            Regresar.Show();
            this.Hide();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int _contador = 0;
            foreach (Control x in pctTierra.Controls)
            {
                if (x is PictureBox)
                {
                    _contador++;
                    ((PictureBox)x).Name = "pctSanta1" + _contador.ToString();
                    HiloControl.Add("Hilo" + _contador.ToString(), "pctSanta1" + _contador.ToString());
                    Thread t1 = new Thread(() => IniciarMovimiento())
                    { Name = "Hilo" + _contador.ToString() };
                    hilos.Add(t1);
                }
               
            }
           foreach (Thread t in hilos)
                t.Start();
        }
        private void IniciarMovimiento()
        {
            var ThreadName = Thread.CurrentThread.Name;
            TimerThreadName(ThreadName);
        }

        private void TimerThreadName(string NombreHilo)
        {
            this.Invoke((MethodInvoker)delegate
            {
                System.Windows.Forms.Timer _tmr = new System.Windows.Forms.Timer();
                _tmr.Interval = 100;
                _tmr.Tag = NombreHilo;
                _tmr.Tick += timer1_Tick;
                _tmr.Start();
            });
        }

        private void FrmCarrera_SizeChanged(object sender, EventArgs e)
        {
            Width = this.Size.Width;
        }

         private void bgHora_DoWork(object sender, DoWorkEventArgs e)
         {
             getTimer();/////////////////////
         }

         private void getTimer()
         {
             while (!TerminaCarrera)
             {
                 Invoke(new MethodInvoker(delegate ()
                 {
                     lblTimer1.Text = string.Format("{0}",
                     System.DateTime.Now.Second.ToString().PadLeft(2, '0'));
                 }));
             }
         }

        private void bgHora_DoWork_1(object sender, DoWorkEventArgs e)
        {
            GetHoraDelegate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}
