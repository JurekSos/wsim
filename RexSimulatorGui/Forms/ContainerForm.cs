using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RexSimulatorGui.Forms
{
    public partial class ContainerForm : Form
    {
        private RexBoardForm mBoardForm;

        public ContainerForm(String[] args)
        {
            InitializeComponent();
            if (args.Length == 0)
                mBoardForm = new RexSimulatorGui.Forms.RexBoardForm();
            else
                mBoardForm = new RexSimulatorGui.Forms.RexBoardForm(args[0]);

            mBoardForm.MdiParent = this;
            mBoardForm.Show();
        }
    }
}
