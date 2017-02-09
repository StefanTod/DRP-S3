using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dpr_strategyPattern_diskManagement
{
    public partial class Form1 : Form
    {
        private enum Algorithm { FIFO , SCAN, SSTF }
        private DiskScheduler disk;
        private IAlgorithmStrategy algorithmStrategy;

        public Form1()
        {
            InitializeComponent();
            tb_disk.SetRange(0, DiskScheduler.diskSize);
            tb_disk.Value = DiskScheduler.diskSize / 2;
            cb_algorithm.Items.AddRange(Enum.GetNames(typeof(Algorithm)));
            disk = new DiskScheduler();
            algorithmStrategy = new ScanStrategy(tb_disk.Value, DiskScheduler.diskSize);
        }

        private void bt_run_Click(object sender, EventArgs e)
        {
            timerRun.Enabled = true;
        }

        private void UpdateList()
        {
            lb_disk.DataSource = null;
            lb_disk.DataSource = disk.GetDiskQueue();
        }

        private void timerRun_Tick(object sender, EventArgs e)
        {
            int index = disk.AlgorithmGetNext(algorithmStrategy);
            if (index == -1)
            {
                timerRun.Enabled = false;
                tb_processed.Text = string.Empty;
                return;
            }
            int pos = disk.diskQueue[index];
            tb_processed.Text = pos.ToString();
            disk.diskQueue.RemoveAt(index);
            tb_disk.Value = pos;
            UpdateList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerRun.Enabled = false;
        }

        private void bt_example_Click(object sender, EventArgs e)
        {
            disk.GenerateNumbers();
            UpdateList();
        }

        private void cb_algorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Algorithm)cb_algorithm.SelectedIndex)
            {
                case Algorithm.FIFO :
                    algorithmStrategy = new FIFOStrategy();
                    break;
                case Algorithm.SCAN :
                    algorithmStrategy = new ScanStrategy(tb_disk.Value, DiskScheduler.diskSize);
                    break;
                default:
                    MessageBox.Show("Not implemented algorithm");
                    break;
            }
        }
    }
}
