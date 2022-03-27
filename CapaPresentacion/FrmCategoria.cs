using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            this.BtnSave.Visible = false;
        }
        public void mostrarBuscarTablas(String buscar)
        {
            N_Categoria negcio = new N_Categoria();
            tblCategoria.DataSource = negcio.listarCategoria(buscar);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {


            this.BtnSave.Visible = true;
            this.BtnSave.Image = imageList1.Images[0];
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            this.BtnSave.Visible = true;
            this.BtnSave.Image = imageList1.Images[1];
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            this.BtnSave.Visible = true;
            this.BtnSave.Image = imageList1.Images[2];
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            mostrarBuscarTablas("");
        }
    }
}
