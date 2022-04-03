using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LI1_RegionChanger
{
    public partial class LIRChange : Form
    {
        RegistryKey LIPath;
        string LIPathSet;
        bool Warn = false;

        public LIRChange()
        {
            InitializeComponent();
            PathRefresh();

            // Make labels transparent
            titleText.BackColor = System.Drawing.Color.Transparent;
            descText.BackColor = System.Drawing.Color.Transparent;
            pathsTitle.BackColor = System.Drawing.Color.Transparent;
            CDLabel.BackColor = System.Drawing.Color.Transparent;
            diskPathL.BackColor = System.Drawing.Color.Transparent;
            desB.BackColor = System.Drawing.Color.Transparent;
            //
        }

        private void cdpathButton_Click(object sender, EventArgs e)
        {
            //cd drive label selection
            OpenFileDialog filed = new OpenFileDialog();
            filed.Title = "Select the ROOT of the LEGO Island CD.";
            filed.Filter = "LEGO1.DLL|LEGO1.DLL";
            DialogResult cdRoot = filed.ShowDialog();

            //set cdpath registry value
            if (cdRoot == DialogResult.OK)
            {
                string cdResult = filed.FileName;
                cdResult = cdResult.Replace("\\LEGO1.DLL", "");
                Registry.SetValue(LIPathSet, "cdpath", cdResult);
                PathRefresh();
            }
                // Testing the button, commented it out instead of deleting it because screw being a good coder! B)
                //   cdpathButton.Text = "this did something!";
            }

        public void PathRefresh()
        {
            //Set the Registry key path for Lego Island based on if the OS is 64-Bit or 32-Bit, something I didn't consider in the original version of this.
            if (Environment.Is64BitOperatingSystem)
            {
                LIPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Mindscape\LEGO Island", false);
                LIPathSet = "HKEY_LOCAL_MACHINE" + "\\SOFTWARE\\WOW6432Node\\Mindscape\\LEGO Island";
            }
            else
            {
                LIPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Mindscape\LEGO Island", false);
                LIPathSet = "HKEY_LOCAL_MACHINE" + "\\SOFTWARE\\Mindscape\\LEGO Island";
            }

            //Grab the CDPath and DiskPath values
            String cdpath = (String)LIPath.GetValue("cdpath");
            String diskpath = (String)LIPath.GetValue("diskpath");

            //Check if the registry key even exists
            if (cdpath == null && Warn == false)
            {
                // If it doesn't, warn the user that the program is essentially useless (warn bool used so that the message doesn't appear every time it's refreshed if it's just a mistake)
                Warn = true;
                DialogResult res = MessageBox.Show("WARNING: LEGO Island doesn't appear to be installed on this machine." + "\n" + "The functionality of this program may be affected." + "\n" + "\n" + "Continue anyways?", "LEGO Island Region Changer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                {
                    Application.Exit();
                }
            }

            CDLabel.Text = cdpath;
            diskPathL.Text = diskpath;
        }

        private void installPathB_Click(object sender, EventArgs e)
        {
            //game install directory selection, yes this is just edited from the cd path button i can copy my own code shut up
            OpenFileDialog filed2 = new OpenFileDialog();
            filed2.Title = "Select the install directory of LEGO Island.";
            filed2.Filter = "ISLE.EXE|ISLE.EXE";
            DialogResult PathRoot = filed2.ShowDialog();

            //set cdpath registry value
            if (PathRoot == DialogResult.OK)
            {
                string PResult = filed2.FileName;
                PResult = PResult.Replace("\\ISLE.EXE", "");
                Registry.SetValue(LIPathSet, "diskpath", PResult);
                Registry.SetValue(LIPathSet, "moviespath", PResult);
                if (savecheck.Checked)
                {
                    OpenFileDialog filed3 = new OpenFileDialog();
                    filed3.Title = "Select the new save path.";
                    filed3.Filter = "All Files(*)|*";
                    DialogResult SaveRoot = filed3.ShowDialog();
                    if (SaveRoot == DialogResult.OK)
                    {
                        string SResult = filed3.FileName;
                        SResult = SResult.Replace("\\" + filed3.SafeFileName, "");
                        Registry.SetValue(LIPathSet, "savepath", SResult);
                    }
                }
                else
                {
                    Registry.SetValue(LIPathSet, "savepath", PResult);
                }
                PathRefresh();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //it's an exit button... it exits the program... what? you want me to write a funny comment? no i dont feel like it today sorry
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
