
namespace Bagolyvar2
{
    partial class Kölcsönző
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kölcsönző));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_peldany = new System.Windows.Forms.NumericUpDown();
            this.combo_berlo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_konyv = new System.Windows.Forms.ComboBox();
            this.btn_Tárol = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Rögzítés = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_peldany)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.num_peldany);
            this.groupBox1.Controls.Add(this.combo_berlo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_konyv);
            this.groupBox1.Location = new System.Drawing.Point(34, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kölcsönzési adatok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Példány";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bérlő";
            // 
            // num_peldany
            // 
            this.num_peldany.Location = new System.Drawing.Point(132, 154);
            this.num_peldany.Name = "num_peldany";
            this.num_peldany.Size = new System.Drawing.Size(135, 20);
            this.num_peldany.TabIndex = 3;
            // 
            // combo_berlo
            // 
            this.combo_berlo.FormattingEnabled = true;
            this.combo_berlo.Location = new System.Drawing.Point(79, 98);
            this.combo_berlo.Name = "combo_berlo";
            this.combo_berlo.Size = new System.Drawing.Size(188, 21);
            this.combo_berlo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Könyv";
            // 
            // combo_konyv
            // 
            this.combo_konyv.FormattingEnabled = true;
            this.combo_konyv.Location = new System.Drawing.Point(79, 42);
            this.combo_konyv.Name = "combo_konyv";
            this.combo_konyv.Size = new System.Drawing.Size(188, 21);
            this.combo_konyv.TabIndex = 0;
            // 
            // btn_Tárol
            // 
            this.btn_Tárol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Tárol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Tárol.Location = new System.Drawing.Point(34, 279);
            this.btn_Tárol.Name = "btn_Tárol";
            this.btn_Tárol.Size = new System.Drawing.Size(284, 34);
            this.btn_Tárol.TabIndex = 1;
            this.btn_Tárol.Text = "Listában tárolja az adatot";
            this.btn_Tárol.UseVisualStyleBackColor = false;
            this.btn_Tárol.Click += new System.EventHandler(this.btn_Tárol_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(400, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(342, 277);
            this.listBox1.TabIndex = 2;
            // 
            // btn_Rögzítés
            // 
            this.btn_Rögzítés.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Rögzítés.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Rögzítés.Location = new System.Drawing.Point(221, 367);
            this.btn_Rögzítés.Name = "btn_Rögzítés";
            this.btn_Rögzítés.Size = new System.Drawing.Size(284, 34);
            this.btn_Rögzítés.TabIndex = 3;
            this.btn_Rögzítés.Text = "Rögzítés az adatbázisban";
            this.btn_Rögzítés.UseVisualStyleBackColor = false;
            this.btn_Rögzítés.Click += new System.EventHandler(this.btn_Rögzítés_Click);
            // 
            // Kölcsönző
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.btn_Rögzítés);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Tárol);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kölcsönző";
            this.Text = "Kölcsönző";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_peldany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_peldany;
        private System.Windows.Forms.ComboBox combo_berlo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_konyv;
        private System.Windows.Forms.Button btn_Tárol;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Rögzítés;
    }
}