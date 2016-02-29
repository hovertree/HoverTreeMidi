using HoverTreeMidi.HtMidi;
using System;
using System.Windows.Forms;

namespace HoverTreeMidi
{
    public partial class FormHoverTreeMidi : Form
    {
        HewenqiMidi _hoverTreeMidi;
        public FormHoverTreeMidi()
        {
            InitializeComponent();
            _hoverTreeMidi = new HewenqiMidi();
            _hoverTreeMidi.Open();
        }

        private void button_shortPlay_Click(object sender, EventArgs e)
        {
            _hoverTreeMidi.ShortPlay(Convert.ToUInt32(numericUpDown_key.Value), Convert.ToUInt32(numericUpDown_volumn.Value), Convert.ToUInt32(numericUpDown_chenel.Value));
        }

        private void linkLabel_hoverTree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://hovertree.com/");
        }
    }
}