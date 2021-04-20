
namespace Bagolyvar2
{
    partial class Késések
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Késések));
            this.combo_keso = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // combo_keso
            // 
            this.combo_keso.FormattingEnabled = true;
            this.combo_keso.Location = new System.Drawing.Point(57, 34);
            this.combo_keso.Name = "combo_keso";
            this.combo_keso.Size = new System.Drawing.Size(288, 21);
            this.combo_keso.TabIndex = 0;
            this.combo_keso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(57, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 303);
            this.listBox1.TabIndex = 1;
            // 
            // Késések
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 476);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.combo_keso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Késések";
            this.Text = "Késések";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_keso;
        private System.Windows.Forms.ListBox listBox1;
    }
}