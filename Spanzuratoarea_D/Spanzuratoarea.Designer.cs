namespace Jocul_Spanzuratoarea_D
{
    partial class Jocul_Spanzuratoarea
    {
       
        private System.ComponentModel.IContainer components = null;

       protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.spanzuratoareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incepeJoculToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitJocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLungimeCuv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNrIncercariRamase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLitereIncorecte = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
             
            // menuStrip
            
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spanzuratoareaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(674, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";

            //spanzuratoareaToolStripMenuItem

            this.spanzuratoareaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incepeJoculToolStripMenuItem,
            this.exitJocToolStripMenuItem});
            this.spanzuratoareaToolStripMenuItem.Name = "spanzuratoareaToolStripMenuItem";
            this.spanzuratoareaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.spanzuratoareaToolStripMenuItem.Text = "Optiune:";

            // incepeJoculToolStripMenuItem

            this.incepeJoculToolStripMenuItem.Name = "incepeJoculToolStripMenuItem";
            this.incepeJoculToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.incepeJoculToolStripMenuItem.Text = "Incepe jocul";
            this.incepeJoculToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            
            // exitToolStripMenuItem

            this.exitJocToolStripMenuItem.Name = "exitJocToolStripMenuItem";
            this.exitJocToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitJocToolStripMenuItem.Text = "Exit joc";
            this.exitJocToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            
            // groupBox1
          
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
           
            // flowLayoutPanel1
           
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 191);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(461, 143);
            this.flowLayoutPanel1.TabIndex = 1;
            

            // panel1
            
            this.panel1.Location = new System.Drawing.Point(467, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 307);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            
            // label1
            
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nr. litere";
            
            // txtLungimeCuv
          
            this.txtLungimeCuv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic ,System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLungimeCuv.Location = new System.Drawing.Point(61, 93);
            this.txtLungimeCuv.Name = "txtLungimeCuv";
            this.txtLungimeCuv.ReadOnly = true;
            this.txtLungimeCuv.Size = new System.Drawing.Size(41, 22);
            this.txtLungimeCuv.TabIndex = 5;
            
            // label2
            
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nr. incercari";
            
            // txtGuessesLeft
            
            this.txtNrIncercariRamase.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrIncercariRamase.Location = new System.Drawing.Point(189, 93);
            this.txtNrIncercariRamase.Name = "txtNrIncercariRamase";
            this.txtNrIncercariRamase.ReadOnly = true;
            this.txtNrIncercariRamase.Size = new System.Drawing.Size(39, 22);
            this.txtNrIncercariRamase.TabIndex = 5;
            
            // label3
            
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Litere incorecte";
           
            // txtWrongguesses
            
            this.txtLitereIncorecte.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLitereIncorecte.Location = new System.Drawing.Point(333, 96);
            this.txtLitereIncorecte.Name = "txtLitereIncorecte";
            this.txtLitereIncorecte.ReadOnly = true;
            this.txtLitereIncorecte.Size = new System.Drawing.Size(128, 21);
            this.txtLitereIncorecte.TabIndex = 5;
            
            // lblInfo
            
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(144, 144);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 6;

            // Jocul Spanzuratoarea

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 335);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtLitereIncorecte);
            this.Controls.Add(this.txtNrIncercariRamase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLungimeCuv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Jocul Spanzuratoarea";
            this.Text = "Jocul Spanzuratoarea";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem spanzuratoareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incepeJoculToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitJocToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLungimeCuv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNrIncercariRamase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLitereIncorecte;
        private System.Windows.Forms.Label lblInfo;
    }
}