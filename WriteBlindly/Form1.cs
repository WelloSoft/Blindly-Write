using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WriteBlindly
{
    public partial class Form1 : Form
    {
        string text;

        void DrawStats()
        {
            var words = Regex.Matches(text, @"[\S]+");
            var lines = text.Count(x => x == '\n');
            _words.Text = string.Format("Words: {0}", words.Count);
            _lines.Text = string.Format("Lines: {0}", lines + 1);
        }

        void Upload()
        {
            var r = GetRegPath();
            r.SetValue("LastFile", text);
        }

        void Download()
        {
            var r = GetRegPath();
            text = _txt.Text = (string)r.GetValue("LastFile", "");
        }


        RegistryKey GetRegPath()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);

            key.CreateSubKey("DeadlineCounter");
            return key.OpenSubKey("DeadlineCounter", true);
        }

        public Form1()
        {
            InitializeComponent();
            Download();
        }

        private void _txt_TextChanged(object sender, EventArgs e)
        {
            text = _txt.Text;
            DrawStats();
            Upload();
        }

        private void _mask_Click(object sender, EventArgs e)
        {
            _mask.Checked = !_mask.Checked;
            _txt.UseSystemPasswordChar = !_mask.Checked;
        }

        private void _selectAll_Click(object sender, EventArgs e)
        {
            _txt.SelectAll();
        }
    }
}
