using System;
using System.Linq;
using System.Windows.Forms;

namespace TotoGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TbEredmeny_TextChanged(object sender, EventArgs e)
        {
            cbKarakterSzam.Checked = tbEredmeny.Text.Length != 14;

            cbKarakterSzam.Text = $"Nem megfelelő a karakterek száma ({tbEredmeny.Text.Length})";


            var invalid = "";
            foreach (var c in tbEredmeny.Text)
                if (!"12Xx".Contains(c)) invalid += $"{c};";

            cbHelytelenKarakter.Checked = invalid.TrimEnd(';') != "";

            cbHelytelenKarakter.Text = $"Helytelen karakter az eredményekben ({invalid.TrimEnd(';')})";

            btnMentes.Enabled = (!cbHelytelenKarakter.Checked & !cbKarakterSzam.Checked);
        }
    }
}