using System;
using System;
using System.Windows.Forms;
using StarWarsWF.SyncService;

namespace StarWarsWF.Screens
{
    public partial class MenuP : Form
    {
        public MenuP()
        {
            InitializeComponent();
        }

        private async void btnSync_Click(object sender, EventArgs e)
        {
            var sync = new SyncServiceClass();

            Cursor = Cursors.WaitCursor;
            await sync.Sincronizar();
            Cursor = Cursors.Default;

            MessageBox.Show("Império sincronizado!", "Sincronização Jedi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            var FormControl = new ControlNaves();
            FormControl.ShowDialog();
        }
    }
}
