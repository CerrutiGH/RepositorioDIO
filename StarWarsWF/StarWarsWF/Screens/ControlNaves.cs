using System;
using StarWarsWF.Connection;
using StarWarsWF.Extensions;
using System.Windows.Forms;

namespace StarWarsWF.Screens
{
    public partial class ControlNaves : Form
    {
        private readonly PilotoActions _pilotoAction;
        private readonly NaveActions _naveAction;

        public ControlNaves()
        {
            _pilotoAction = new PilotoActions();
            _naveAction = new NaveActions();
            InitializeComponent();
        }

        private void ControlNaves_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estrelaDaMorteDataSet.Naves' table. You can move, or remove it, as needed.
            this.navesTableAdapter.Fill(this.estrelaDaMorteDataSet.Naves);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(!rbtChegando.Checked && !rbtSaindo.Checked)
            {
                MessageBox.Show("É preciso informar se a nave está chegando ou saindo da Estrela da Morte!", "Alerta Jedi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(dgvNaves.Rows.Count == 0 || dgvNaves.Rows.GetCountRowsChecked(1) != 1)
            {
                MessageBox.Show("É preciso selecionar apenas uma nave!", "Aviso Jedi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvPilotos.Rows.Count == 0 || dgvPilotos.Rows.GetCountRowsChecked(1) != 1)
            {
                MessageBox.Show("É preciso selecionar apenas um piloto da nave!", "Aviso Jedi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idPiloto = int.Parse(dgvPilotos.Rows[dgvPilotos.Rows.GetFirstIndexChecked(1)].Cells[0].Value.ToString());
            var idNave = int.Parse(dgvNaves.Rows[dgvNaves.Rows.GetFirstIndexChecked(1)].Cells[0].Value.ToString());
            var frm = new Register(idNave, idPiloto, rbtChegando.Checked);
            frm.ShowDialog();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _naveAction?.Dispose();
            _pilotoAction?.Dispose();
            Dispose();
        }

        private async void btnBuscarNave_Click(object sender, EventArgs e)
        {
            dgvNaves.Rows.Clear();
            dgvNaves.Columns.Clear();

            if (string.IsNullOrEmpty(txtNave.Text))
                return;

            Cursor = Cursors.WaitCursor;
            DataGridViewTextBoxColumn idNaveColumn = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn checkNaveColumn = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn nomeNaveColumn = new DataGridViewTextBoxColumn();

            idNaveColumn.Visible = false;

            idNaveColumn.ReadOnly = true;
            checkNaveColumn.ReadOnly = false;
            nomeNaveColumn.ReadOnly = true;

            nomeNaveColumn.Width = 500;

            dgvNaves.RowHeadersVisible = false;
            dgvNaves.ColumnHeadersVisible = false;
            dgvNaves.Columns.Add(idNaveColumn);
            dgvNaves.Columns.Add(checkNaveColumn);
            dgvNaves.Columns.Add(nomeNaveColumn);

            var naves = await _naveAction.ObterPorNomeLike(txtNave.Text);
            foreach (var nave in naves)
                dgvNaves.Rows.Add(nave.IdNave, false, nave.Nome);

            dgvNaves.PerformLayout();
            Cursor = Cursors.Default;
        }

        private async void btnBuscarPiloto_Click(object sender, EventArgs e)
        {
            dgvPilotos.Rows.Clear();
            dgvPilotos.Columns.Clear();

            if (string.IsNullOrEmpty(txtPiloto.Text))
                return;

            Cursor = Cursors.WaitCursor;
            DataGridViewTextBoxColumn idPilotoColumn = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn checkPilotoColumn = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn nomePilotoColumn = new DataGridViewTextBoxColumn();

            idPilotoColumn.Visible = false;

            idPilotoColumn.ReadOnly = true;
            checkPilotoColumn.ReadOnly = false;
            nomePilotoColumn.ReadOnly = true;

            nomePilotoColumn.Width = 500;

            dgvPilotos.RowHeadersVisible = false;
            dgvPilotos.ColumnHeadersVisible = false;
            dgvPilotos.Columns.Add(idPilotoColumn);
            dgvPilotos.Columns.Add(checkPilotoColumn);
            dgvPilotos.Columns.Add(nomePilotoColumn);

            var pilotos = await _pilotoAction.ObterPorNomeLike(txtPiloto.Text);
            foreach (var piloto in pilotos)
                dgvPilotos.Rows.Add(piloto.IdPiloto, false, piloto.Nome);

            dgvNaves.PerformLayout();
            Cursor = Cursors.Default;
        }
    }
}
