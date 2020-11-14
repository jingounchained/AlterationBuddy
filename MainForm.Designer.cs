namespace Alteration_Buddy
{
    partial class MainForm
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
            this.txtTap = new System.Windows.Forms.TextBox();
            this.txtShortTap = new System.Windows.Forms.TextBox();
            this.txtLook = new System.Windows.Forms.TextBox();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lstAlterations = new System.Windows.Forms.ListBox();
            this.alterationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countTap = new System.Windows.Forms.Label();
            this.countLook = new System.Windows.Forms.Label();
            this.countRead = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkElanthipedia = new System.Windows.Forms.LinkLabel();
            this.lnkWitchsWorkshop = new System.Windows.Forms.LinkLabel();
            this.lnkDRServiceInfo = new System.Windows.Forms.LinkLabel();
            this.alterationMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTap
            // 
            this.txtTap.Location = new System.Drawing.Point(61, 38);
            this.txtTap.Name = "txtTap";
            this.txtTap.Size = new System.Drawing.Size(343, 20);
            this.txtTap.TabIndex = 1;
            this.txtTap.TextChanged += new System.EventHandler(this.txtTap_TextChanged);
            // 
            // txtShortTap
            // 
            this.txtShortTap.Location = new System.Drawing.Point(61, 12);
            this.txtShortTap.Name = "txtShortTap";
            this.txtShortTap.Size = new System.Drawing.Size(180, 20);
            this.txtShortTap.TabIndex = 0;
            this.txtShortTap.TextChanged += new System.EventHandler(this.txtShortTap_TextChanged);
            // 
            // txtLook
            // 
            this.txtLook.Location = new System.Drawing.Point(61, 80);
            this.txtLook.Multiline = true;
            this.txtLook.Name = "txtLook";
            this.txtLook.Size = new System.Drawing.Size(343, 96);
            this.txtLook.TabIndex = 2;
            this.txtLook.TextChanged += new System.EventHandler(this.txtLook_TextChanged);
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(61, 195);
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(343, 20);
            this.txtRead.TabIndex = 3;
            this.txtRead.TextChanged += new System.EventHandler(this.txtRead_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Short Tap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Look";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Read";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(61, 239);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(343, 92);
            this.txtResult.TabIndex = 8;
            this.txtResult.TabStop = false;
            // 
            // lstAlterations
            // 
            this.lstAlterations.ContextMenuStrip = this.alterationMenu;
            this.lstAlterations.FormattingEnabled = true;
            this.lstAlterations.Location = new System.Drawing.Point(413, 31);
            this.lstAlterations.Name = "lstAlterations";
            this.lstAlterations.Size = new System.Drawing.Size(322, 329);
            this.lstAlterations.TabIndex = 4;
            this.lstAlterations.DoubleClick += new System.EventHandler(this.lstAlterations_DoubleClick);
            this.lstAlterations.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstAlterations_MouseDown);
            // 
            // alterationMenu
            // 
            this.alterationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.alterationMenu.Name = "alterationMenu";
            this.alterationMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // countTap
            // 
            this.countTap.AutoSize = true;
            this.countTap.BackColor = System.Drawing.Color.Transparent;
            this.countTap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countTap.Location = new System.Drawing.Point(58, 64);
            this.countTap.Name = "countTap";
            this.countTap.Size = new System.Drawing.Size(147, 13);
            this.countTap.TabIndex = 16;
            this.countTap.Text = "80 characters remaining.";
            // 
            // countLook
            // 
            this.countLook.AutoSize = true;
            this.countLook.BackColor = System.Drawing.Color.Transparent;
            this.countLook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLook.Location = new System.Drawing.Point(58, 179);
            this.countLook.Name = "countLook";
            this.countLook.Size = new System.Drawing.Size(154, 13);
            this.countLook.TabIndex = 18;
            this.countLook.Text = "500 characters remaining.";
            // 
            // countRead
            // 
            this.countRead.AutoSize = true;
            this.countRead.BackColor = System.Drawing.Color.Transparent;
            this.countRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countRead.Location = new System.Drawing.Point(58, 218);
            this.countRead.Name = "countRead";
            this.countRead.Size = new System.Drawing.Size(147, 13);
            this.countRead.TabIndex = 20;
            this.countRead.Text = "10 characters remaining.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "15/15/15 article,adjective,noun";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Result";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(61, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Saved Designs - Right Click for Options";
            // 
            // lnkElanthipedia
            // 
            this.lnkElanthipedia.AutoSize = true;
            this.lnkElanthipedia.Location = new System.Drawing.Point(126, 342);
            this.lnkElanthipedia.Name = "lnkElanthipedia";
            this.lnkElanthipedia.Size = new System.Drawing.Size(143, 13);
            this.lnkElanthipedia.TabIndex = 28;
            this.lnkElanthipedia.TabStop = true;
            this.lnkElanthipedia.Text = "Elanthipedia Alteration Guide";
            this.lnkElanthipedia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkElanthipedia_LinkClicked);
            // 
            // lnkWitchsWorkshop
            // 
            this.lnkWitchsWorkshop.AutoSize = true;
            this.lnkWitchsWorkshop.Location = new System.Drawing.Point(288, 342);
            this.lnkWitchsWorkshop.Name = "lnkWitchsWorkshop";
            this.lnkWitchsWorkshop.Size = new System.Drawing.Size(116, 13);
            this.lnkWitchsWorkshop.TabIndex = 29;
            this.lnkWitchsWorkshop.TabStop = true;
            this.lnkWitchsWorkshop.Text = "The Witch\'s Workshop";
            this.lnkWitchsWorkshop.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWitchsWorkshop_LinkClicked);
            // 
            // lnkDRServiceInfo
            // 
            this.lnkDRServiceInfo.AutoSize = true;
            this.lnkDRServiceInfo.Location = new System.Drawing.Point(665, 15);
            this.lnkDRServiceInfo.Name = "lnkDRServiceInfo";
            this.lnkDRServiceInfo.Size = new System.Drawing.Size(70, 13);
            this.lnkDRServiceInfo.TabIndex = 30;
            this.lnkDRServiceInfo.TabStop = true;
            this.lnkDRServiceInfo.Text = "drservice.info";
            this.lnkDRServiceInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDRServiceInfo_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 368);
            this.Controls.Add(this.lnkDRServiceInfo);
            this.Controls.Add(this.lnkWitchsWorkshop);
            this.Controls.Add(this.lnkElanthipedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.countRead);
            this.Controls.Add(this.countLook);
            this.Controls.Add(this.countTap);
            this.Controls.Add(this.lstAlterations);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.txtLook);
            this.Controls.Add(this.txtShortTap);
            this.Controls.Add(this.txtTap);
            this.Name = "MainForm";
            this.Text = "Alteration Buddy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.alterationMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTap;
        private System.Windows.Forms.TextBox txtShortTap;
        private System.Windows.Forms.TextBox txtLook;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ListBox lstAlterations;
        private System.Windows.Forms.Label countTap;
        private System.Windows.Forms.Label countLook;
        private System.Windows.Forms.Label countRead;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip alterationMenu;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkElanthipedia;
        private System.Windows.Forms.LinkLabel lnkWitchsWorkshop;
        private System.Windows.Forms.LinkLabel lnkDRServiceInfo;
    }
}

