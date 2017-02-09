namespace dpr_strategyPattern_diskManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_run = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_example = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_algorithm = new System.Windows.Forms.ComboBox();
            this.tb_disk = new System.Windows.Forms.TrackBar();
            this.lb_disk = new System.Windows.Forms.ListBox();
            this.tb_processed = new System.Windows.Forms.TextBox();
            this.timerRun = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tb_disk)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_run
            // 
            this.bt_run.Location = new System.Drawing.Point(265, 98);
            this.bt_run.Name = "bt_run";
            this.bt_run.Size = new System.Drawing.Size(75, 23);
            this.bt_run.TabIndex = 0;
            this.bt_run.Text = "Run";
            this.bt_run.UseVisualStyleBackColor = true;
            this.bt_run.Click += new System.EventHandler(this.bt_run_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_example
            // 
            this.bt_example.Location = new System.Drawing.Point(265, 127);
            this.bt_example.Name = "bt_example";
            this.bt_example.Size = new System.Drawing.Size(156, 23);
            this.bt_example.TabIndex = 2;
            this.bt_example.Text = "Example";
            this.bt_example.UseVisualStyleBackColor = true;
            this.bt_example.Click += new System.EventHandler(this.bt_example_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Disk Scheduling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Algorithms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Requests:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Disk Tracks";
            // 
            // cb_algorithm
            // 
            this.cb_algorithm.FormattingEnabled = true;
            this.cb_algorithm.Location = new System.Drawing.Point(265, 71);
            this.cb_algorithm.Name = "cb_algorithm";
            this.cb_algorithm.Size = new System.Drawing.Size(121, 21);
            this.cb_algorithm.TabIndex = 9;
            this.cb_algorithm.SelectedIndexChanged += new System.EventHandler(this.cb_algorithm_SelectedIndexChanged);
            // 
            // tb_disk
            // 
            this.tb_disk.Location = new System.Drawing.Point(44, 117);
            this.tb_disk.Name = "tb_disk";
            this.tb_disk.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb_disk.Size = new System.Drawing.Size(45, 344);
            this.tb_disk.TabIndex = 11;
            // 
            // lb_disk
            // 
            this.lb_disk.FormattingEnabled = true;
            this.lb_disk.Location = new System.Drawing.Point(129, 117);
            this.lb_disk.Name = "lb_disk";
            this.lb_disk.Size = new System.Drawing.Size(95, 342);
            this.lb_disk.TabIndex = 12;
            // 
            // tb_processed
            // 
            this.tb_processed.Location = new System.Drawing.Point(129, 82);
            this.tb_processed.Name = "tb_processed";
            this.tb_processed.Size = new System.Drawing.Size(95, 20);
            this.tb_processed.TabIndex = 13;
            // 
            // timerRun
            // 
            this.timerRun.Interval = 1000;
            this.timerRun.Tick += new System.EventHandler(this.timerRun_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 514);
            this.Controls.Add(this.tb_processed);
            this.Controls.Add(this.lb_disk);
            this.Controls.Add(this.tb_disk);
            this.Controls.Add(this.cb_algorithm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_example);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_run);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tb_disk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_run;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_example;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_algorithm;
        private System.Windows.Forms.TrackBar tb_disk;
        private System.Windows.Forms.ListBox lb_disk;
        private System.Windows.Forms.TextBox tb_processed;
        private System.Windows.Forms.Timer timerRun;
    }
}

