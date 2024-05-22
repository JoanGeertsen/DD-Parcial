using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DD_Parcial
{
    public partial class FAcercaDe : Form
    {
        #region Atributos //Los uso poder mover la ventana del formulario.
        private bool isDragging;
        private Point startPoint;
        #endregion

        public FAcercaDe()
        {
            InitializeComponent();
            isDragging = false;
            startPoint = new Point(0, 0);
        }

        #region Botones
        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Links
        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/JoanGeertsen/";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void linkLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.linkedin.com/in/joan-geertsen-8165a8248/";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        #endregion

        #region Movimiento de formulario
        private void FAcercaDe_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }


        private void FAcercaDe_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void FAcercaDe_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        #endregion        
    }
}
