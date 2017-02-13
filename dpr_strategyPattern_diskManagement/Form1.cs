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

            tb_disk.TickStyle = TickStyle.Both;
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
            try
            {
                int removed = disk.AlgorithmGetNext(tb_disk);
                if (removed == -1)
                {
                    timerRun.Enabled = false;
                    tb_processed.Text = string.Empty;
                }
                else
                {
                    tb_processed.Text = removed.ToString();
                    tb_disk.Value = removed;
                    UpdateList();
                }
            }
            catch (System.NullReferenceException ex)
            {
                timerRun.Enabled = false;
                MessageBox.Show("You need to choose algorithm from \"Algorithm dropdown menu\" \n Exception message: " + ex.Message);
            }
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
                    disk.algorithmStrategy = new FIFOStrategy();
                    break;
                case Algorithm.SCAN :
                    disk.algorithmStrategy = new ScanStrategy(tb_disk.Value, DiskScheduler.diskSize);
                    break;
                case Algorithm.SSTF :
                    disk.algorithmStrategy = new SSTFStrategy(tb_disk.Value);
                    break;
                default:
                    MessageBox.Show("Not implemented algorithm");
                    break;
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int numb = Convert.ToInt32(tb_add.Text);
                if (numb < 0 || numb > DiskScheduler.diskSize)
                {
                    MessageBox.Show("Number is out of range: 0 - " + DiskScheduler.diskSize.ToString());
                    return;
                }
                disk.AddToQueue(numb);
                UpdateList();
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
