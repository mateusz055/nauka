using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Class4
    {
        public RpteFaenamientoPorcino()
        {
            InitializeComponent();
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
        }

        private void RpteFaenamientoPorcino_Load(object sender, EventArgs e)
        {
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        void GenerarReporte()
        {
            // PROCESO....
            //TUTAJ COŚ ZMIEN
            //TUTAJ COŚ ZMIEN
            //TUTAJ COŚ ZMIEN
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Gjghjghjhgjhghj
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            LblPorcentaje.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                MessageBox.Show("Terminado");
            }
        }
    }
}
}
