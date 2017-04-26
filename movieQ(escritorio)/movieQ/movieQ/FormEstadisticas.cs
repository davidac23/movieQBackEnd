using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movieQ
{
    public partial class FormEstadisticas : Form
    {
        public FormEstadisticas()
        {
            InitializeComponent();
        }

        private void buttonEstadisticasUsuarios_Click(object sender, EventArgs e)
        {
            FormEstadisticasUsuarios f = new FormEstadisticasUsuarios();
            f.ShowDialog();
        }

        private void buttonPartida_Click(object sender, EventArgs e)
        {
            FormEstadisticasPreguntas fp = new FormEstadisticasPreguntas();
            fp.ShowDialog();
        }
    }
}
