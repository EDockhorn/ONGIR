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
    public partial class FrmConsultaAsso : Form
    {
        public int ID;
        public int OPReserva = 1;
        
        FrmOBS obs = new FrmOBS();

        Usuarios User = new Usuarios();
        public string perfil;


        public FrmConsultaAsso()
        {
            InitializeComponent();
        }

        private void FrmConsultaAsso_Load(object sender, EventArgs e)
        {
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
                    btnEditar.Visible = true;
                    btnOBS.Location = new Point(652, 323);
                    btnOBS.Size = new Size(69,51);
                    break;
            }


            PreencheDataGridView PreencheGrid = new PreencheDataGridView();

            dgvClientes.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaASS", "ConsultaASS").Tables[0];
            dgvClientes.AutoResizeColumns();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            lblInfo.Text = "";
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblInfo.Text = "";
            }
            catch
            {
                ID = 0;
                lblInfo.Text = "Clique em um registro para editar!";
            }
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnEditar.Visible ==true) btnEditar_Click(this, e);
            
        }

        private void dgvClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            lblInfo.Text = "";
        }

        private void dgvClientes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (btnEditar.Visible == true) btnEditar_Click(this, e);
        }
        public int RetornaID()
        {
            return ID;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ID != 0 && OPReserva ==1 )
            {
                FrmCadAsso Clieditar = new FrmCadAsso();
                Clieditar.Text = "Editando Associado";
                Clieditar.ID = ID;
                Clieditar.operacao = 2;
                Clieditar.ShowDialog();
                this.dgvClientes.DataSource = null;
                dgvClientes.Rows.Clear();
                dgvClientes.Refresh();

                FrmConsultaAsso_Load(this, e);
            }
            else if (ID != 0 && OPReserva ==2)
            {
                RetornaID();
                this.Close();
            }
            else
                lblInfo.Text = "Clique em um registro para editar!";
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheDataGridView PreencheGrid = new PreencheDataGridView();

            if (rdbNome.Checked) dgvClientes.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaASS WHERE NOME LIKE '%" + txtBuscar.Text + "%'", "ConsultaASS").Tables[0];
            else dgvClientes.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaASS WHERE CPF LIKE '%" + txtBuscar.Text + "%'", "ConsultaASS").Tables[0];
            dgvClientes.AutoResizeColumns();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();

        }
        public void getPerfi(Usuarios usuarios)
        {
            User = usuarios;
        }

        private void btnOBS_Click(object sender, EventArgs e)
        {
            /*      
                AD
                AT
                AD
                PS
                AS
            */

            if (ID != 0)
            {

                obs.ID = ID;
                obs.operacao = 1;
                obs.perfil = User.getID();
                string avl = "Avaliações ";

                switch (perfil)
                {
                case "AD":
                    obs.Text = avl + "Jurídicas";
                    obs.ShowDialog();
                    break;
                case "PS":
                    obs.Text = avl + "do Psicólogo";
                    obs.ShowDialog();
                    break;
                case "AM":
                    obs.Text = avl;
                    obs.ShowDialog();
                    break;
                case "AS":
                    obs.Text = avl + "Assistência Social";
                    obs.ShowDialog();
                    break;
                }
            }
            else if (ID != 0)
            {
                RetornaID();
                this.Close();
            }
            else
                lblInfo.Text = "Clique em um registro para editar!";


            }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        }
   
    }


