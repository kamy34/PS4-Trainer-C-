﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librpc;

namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    public partial class DSCS : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public DSCS()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "01.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Digimon Story : Cyber Sleuth", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglEXP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglEXP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x44bfff, new byte[] { 0x41, 0x01, 0x46, 0x70 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xac94cf, new byte[] { 0x41, 0x89, 0x46, 0x70 });
                }

            }


        }

        private void tglItems_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglItems.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x45b001, new byte[] { 0x01, 0xca });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x45b001, new byte[] { 0x29, 0xca });
                }

            }


        }

        private void tglInfItems_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglInfItems.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x45b001, new byte[] { 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x45b001, new byte[] { 0x29, 0xca });
                }

            }

        }
    }
}
