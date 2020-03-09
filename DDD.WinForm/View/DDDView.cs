using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD.WinForm
{
    public partial class DDDView : Form
    {
        public DDDView()
        {
            InitializeComponent();
        }

        private void DDDView_Load(object sender, EventArgs e)
        {
            var textBoxes = new TextBox[]
            {
                carNameTextBox,
                firstRegistTextBox,
                runDistTextBox,
                engineTypeTextBox,
                inspectionTextBox,
                repairTextBox
            };

            textBoxes.ToList().ForEach(box => box.Enabled = false);
        }
    }
}
