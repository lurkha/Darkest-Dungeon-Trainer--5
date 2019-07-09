using System;
using System.Windows.Forms;
using MemoryManager;
using NHotkey.WindowsForms;


namespace Dota2MemoryScaner
{
    public partial class Form1 : Form
    {
        IntPtr GoldAdr = new IntPtr();
        IntPtr BustAdr = new IntPtr();
        IntPtr HerbAdr = new IntPtr();
        IntPtr DeedAdr = new IntPtr();
        IntPtr PortraitAdr = new IntPtr();
        HotkeyManager Hotkey;
        Manager M;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            M = new Manager("Darkest");
            Hotkey = HotkeyManager.Current;
        }

        private void активироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Gold
            var GoldAddress = M.ReadPointer(M.GetBaseAddressByModuleName("Darkest.exe"), new int[] { 0x01370474, 0x0, 0x1B8 });
            this.GoldAdr = GoldAddress;
            gold.Value = M.VAM.ReadInt32(GoldAdr);
            #endregion
            #region Bust
            var BustAddress = M.ReadPointer(M.GetBaseAddressByModuleName("Darkest.exe"), new int[] { 0x01370474, 0x0, 0x200 });
            this.BustAdr = BustAddress;
            bust.Value = M.VAM.ReadInt32(BustAdr);
            #endregion
            #region Deed
            var DeedAddress = M.ReadPointer(M.GetBaseAddressByModuleName("Darkest.exe"), new int[] { 0x01370494, 0x0, 0x5C, 0x4B4, 0x5D0, 0xD8 });
            this.DeedAdr = DeedAddress;
            deed.Value = M.VAM.ReadInt32(DeedAdr);
            #endregion
            #region Shields
            var ShieldAddress = M.ReadPointer(M.GetBaseAddressByModuleName("Darkest.exe"), new int[] { 0x01370474, 0x4, 0x128});
            this.HerbAdr = ShieldAddress;
            herb.Value = M.VAM.ReadInt32(HerbAdr);
            #endregion
            #region Portraits
            var PortaraitsAddress = M.ReadPointer(M.GetBaseAddressByModuleName("Darkest.exe"), new int[] { 0x01370474, 0x0, 0x248 });
            this.PortraitAdr = PortaraitsAddress;
            portrait.Value = M.VAM.ReadInt32(PortraitAdr);
            #endregion

        }

        private void gold_ValueChanged(object sender, EventArgs e)
        {
            M.VAM.WriteInt32(GoldAdr, (int)gold.Value);
        }

        private void bust_ValueChanged(object sender, EventArgs e)
        {
            M.VAM.WriteInt32(BustAdr, (int)bust.Value);
        }

        private void portrait_ValueChanged(object sender, EventArgs e)
        {
            M.VAM.WriteInt32(PortraitAdr, (int)portrait.Value);
        }

        private void deed_ValueChanged(object sender, EventArgs e)
        {
            M.VAM.WriteInt32(DeedAdr, (int)deed.Value);
        }

        private void herb_ValueChanged(object sender, EventArgs e)
        {
            M.VAM.WriteInt32(HerbAdr, (int)herb.Value);
        }
    }
}
