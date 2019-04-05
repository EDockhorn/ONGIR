using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_DB_LocadoraVeiculos;
using Dll_BS_CPIR;

namespace PIM_ONGIR
{
    public partial class frmConsultaAgenda : Form
    {
        Usuarios User = new Usuarios();
        public string perfil;

        public frmConsultaAgenda()
        {
            InitializeComponent();
        }

        private void frmConsultaAgenda_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            /*      
                AD
                AT
                AD
                PS
                AS
            */

            perfil = User.getID();
            switch (perfil)
            {
                case "AT":
                    btnOBS.Visible = false;
                    break;
                case "AM":
                    btnOBS.Visible = true;
                    break;
                default:
                    //btnOBS.Visible = true;
                    btnEditar.Visible = false;
                    btnOBS.Location = new Point(652, 323);
                    btnOBS.Size = new Size(69, 51);
                    break;
            }

            if (txtBuscar.Text != "") FiltroSelecionado(); else SemFiltroSelecionado();


            
        }


        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            FiltroSelecionado();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FiltroSelecionado()
        {
            PreencheDataGridView PreencheGrid = new PreencheDataGridView();
            if (chkDisponivel.Checked == true)
            {
                if (rdbNome.Checked) dgvClientes.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaAgendamentosAsso WHERE NOME LIKE '%" + txtBuscar.Text + "%' AND CONCLUIDO = 0 ", "ConsultaAgendamentosAsso").Tables[0];
                else dgvClientes.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaAgendamentosAsso WHERE CPF LIKE '%" + txtBuscar.Text + "%' AND concluidoAGE = 0 ", "ConsultaAgendamentosAsso").Tables[0];
                dgvClientes.AutoResizeColumns();
                dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            else
            {
                if (rdbNome.Checked) dgvClientes.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaAgendamentosAsso WHERE NOME LIKE '%" + txtBuscar.Text + "%' AND CONCLUIDO = 1", "ConsultaAgendamentosAsso").Tables[0];
                else dgvClientes.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaAgendamentosAsso WHERE CPF LIKE '%" + txtBuscar.Text + "%' AND CONCLUIDO = 1 ", "ConsultaAgendamentosAsso").Tables[0];
                dgvClientes.AutoResizeColumns();
                dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        private void SemFiltroSelecionado()
        {
            PreencheDataGridView PreencheGrid = new PreencheDataGridView();

            if (chkDisponivel.Checked == true)
            {
                dgvClientes.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaAgendamentosAsso WHERE CONCLUIDO = 1", "ConsultaAgendamentosAsso").Tables[0];
                dgvClientes.AutoResizeColumns();
                dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                dgvClientes.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaAgendamentosAsso WHERE CONCLUIDO = 0", "ConsultaAgendamentosAsso").Tables[0];
                dgvClientes.AutoResizeColumns();
                dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            lblInfo.Text = "";
        }

        private void chkDisponivel_CheckedChanged(object sender, EventArgs e)
        {
            frmConsultaAgenda_Load(this, e);
        }


    }
}
