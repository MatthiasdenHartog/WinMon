namespace WinMon
{
    partial class CombatScreen
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
            this.btn_attack = new System.Windows.Forms.Button();
            this.btn_defend = new System.Windows.Forms.Button();
            this.btn_openBag = new System.Windows.Forms.Button();
            this.btn_changeMon = new System.Windows.Forms.Button();
            this.chatterBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Round = new System.Windows.Forms.Label();
            this.buttonGrid = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_spaceMaker = new System.Windows.Forms.Panel();
            this.pnl_monList = new System.Windows.Forms.Panel();
            this.tlP_monPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btn_mon1 = new System.Windows.Forms.Button();
            this.btn_mon2 = new System.Windows.Forms.Button();
            this.btn_mon3 = new System.Windows.Forms.Button();
            this.btn_mon4 = new System.Windows.Forms.Button();
            this.btn_mon5 = new System.Windows.Forms.Button();
            this.btn_mon6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.buttonGrid.SuspendLayout();
            this.pnl_monList.SuspendLayout();
            this.tlP_monPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_attack
            // 
            this.btn_attack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_attack.BackColor = System.Drawing.Color.Salmon;
            this.btn_attack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_attack.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attack.Location = new System.Drawing.Point(3, 3);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(176, 80);
            this.btn_attack.TabIndex = 0;
            this.btn_attack.Text = "Angreifen";
            this.btn_attack.UseVisualStyleBackColor = false;
            this.btn_attack.Click += new System.EventHandler(this.btn_attack_Click);
            // 
            // btn_defend
            // 
            this.btn_defend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_defend.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_defend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_defend.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_defend.Location = new System.Drawing.Point(185, 3);
            this.btn_defend.Name = "btn_defend";
            this.btn_defend.Size = new System.Drawing.Size(176, 80);
            this.btn_defend.TabIndex = 1;
            this.btn_defend.Text = "Verteidigen";
            this.btn_defend.UseVisualStyleBackColor = false;
            this.btn_defend.Click += new System.EventHandler(this.btn_defend_Click);
            // 
            // btn_openBag
            // 
            this.btn_openBag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_openBag.BackColor = System.Drawing.Color.LightGreen;
            this.btn_openBag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_openBag.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openBag.Location = new System.Drawing.Point(3, 91);
            this.btn_openBag.Name = "btn_openBag";
            this.btn_openBag.Size = new System.Drawing.Size(176, 80);
            this.btn_openBag.TabIndex = 2;
            this.btn_openBag.Text = "Tasche";
            this.btn_openBag.UseVisualStyleBackColor = false;
            this.btn_openBag.Click += new System.EventHandler(this.btn_openBag_Click);
            // 
            // btn_changeMon
            // 
            this.btn_changeMon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_changeMon.BackColor = System.Drawing.Color.White;
            this.btn_changeMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_changeMon.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeMon.Location = new System.Drawing.Point(185, 91);
            this.btn_changeMon.Name = "btn_changeMon";
            this.btn_changeMon.Size = new System.Drawing.Size(176, 80);
            this.btn_changeMon.TabIndex = 3;
            this.btn_changeMon.Text = "Mon\'s";
            this.btn_changeMon.UseVisualStyleBackColor = false;
            this.btn_changeMon.Click += new System.EventHandler(this.btn_changeMon_Click);
            // 
            // chatterBox
            // 
            this.chatterBox.BackColor = System.Drawing.Color.White;
            this.chatterBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatterBox.Location = new System.Drawing.Point(0, 442);
            this.chatterBox.Multiline = true;
            this.chatterBox.Name = "chatterBox";
            this.chatterBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatterBox.Size = new System.Drawing.Size(399, 119);
            this.chatterBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.lbl_Round);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 30);
            this.panel1.TabIndex = 6;
            // 
            // lbl_Round
            // 
            this.lbl_Round.AutoSize = true;
            this.lbl_Round.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Round.Location = new System.Drawing.Point(485, 11);
            this.lbl_Round.Name = "lbl_Round";
            this.lbl_Round.Size = new System.Drawing.Size(0, 20);
            this.lbl_Round.TabIndex = 0;
            // 
            // buttonGrid
            // 
            this.buttonGrid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonGrid.ColumnCount = 2;
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonGrid.Controls.Add(this.btn_changeMon, 1, 1);
            this.buttonGrid.Controls.Add(this.btn_openBag, 0, 1);
            this.buttonGrid.Controls.Add(this.btn_defend, 1, 0);
            this.buttonGrid.Controls.Add(this.btn_attack, 0, 0);
            this.buttonGrid.Location = new System.Drawing.Point(525, 347);
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.RowCount = 2;
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonGrid.Size = new System.Drawing.Size(364, 175);
            this.buttonGrid.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(895, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 525);
            this.panel2.TabIndex = 9;
            // 
            // pnl_spaceMaker
            // 
            this.pnl_spaceMaker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnl_spaceMaker.Location = new System.Drawing.Point(410, 528);
            this.pnl_spaceMaker.Name = "pnl_spaceMaker";
            this.pnl_spaceMaker.Size = new System.Drawing.Size(479, 33);
            this.pnl_spaceMaker.TabIndex = 10;
            // 
            // pnl_monList
            // 
            this.pnl_monList.BackColor = System.Drawing.Color.White;
            this.pnl_monList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_monList.Controls.Add(this.tlP_monPanel);
            this.pnl_monList.Location = new System.Drawing.Point(0, 61);
            this.pnl_monList.Name = "pnl_monList";
            this.pnl_monList.Size = new System.Drawing.Size(399, 243);
            this.pnl_monList.TabIndex = 11;
            // 
            // tlP_monPanel
            // 
            this.tlP_monPanel.ColumnCount = 3;
            this.tlP_monPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlP_monPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlP_monPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlP_monPanel.Controls.Add(this.btn_mon5, 1, 1);
            this.tlP_monPanel.Controls.Add(this.btn_mon4, 0, 1);
            this.tlP_monPanel.Controls.Add(this.btn_mon3, 2, 0);
            this.tlP_monPanel.Controls.Add(this.btn_mon1, 0, 0);
            this.tlP_monPanel.Controls.Add(this.btn_mon6, 2, 1);
            this.tlP_monPanel.Controls.Add(this.btn_mon2, 1, 0);
            this.tlP_monPanel.Location = new System.Drawing.Point(-1, -1);
            this.tlP_monPanel.Name = "tlP_monPanel";
            this.tlP_monPanel.RowCount = 2;
            this.tlP_monPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlP_monPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlP_monPanel.Size = new System.Drawing.Size(395, 243);
            this.tlP_monPanel.TabIndex = 12;
            // 
            // btn_mon1
            // 
            this.btn_mon1.Location = new System.Drawing.Point(3, 3);
            this.btn_mon1.Name = "btn_mon1";
            this.btn_mon1.Size = new System.Drawing.Size(126, 115);
            this.btn_mon1.TabIndex = 0;
            this.btn_mon1.Text = "button1";
            this.btn_mon1.UseVisualStyleBackColor = true;
            this.btn_mon1.Click += new System.EventHandler(this.btn_mon1_Click);
            // 
            // btn_mon2
            // 
            this.btn_mon2.Location = new System.Drawing.Point(135, 3);
            this.btn_mon2.Name = "btn_mon2";
            this.btn_mon2.Size = new System.Drawing.Size(126, 115);
            this.btn_mon2.TabIndex = 1;
            this.btn_mon2.Text = "button1";
            this.btn_mon2.UseVisualStyleBackColor = true;
            this.btn_mon2.Click += new System.EventHandler(this.btn_mon2_Click);
            // 
            // btn_mon3
            // 
            this.btn_mon3.Location = new System.Drawing.Point(267, 3);
            this.btn_mon3.Name = "btn_mon3";
            this.btn_mon3.Size = new System.Drawing.Size(126, 115);
            this.btn_mon3.TabIndex = 2;
            this.btn_mon3.Text = "button1";
            this.btn_mon3.UseVisualStyleBackColor = true;
            this.btn_mon3.Click += new System.EventHandler(this.btn_mon3_Click);
            // 
            // btn_mon4
            // 
            this.btn_mon4.Location = new System.Drawing.Point(3, 124);
            this.btn_mon4.Name = "btn_mon4";
            this.btn_mon4.Size = new System.Drawing.Size(126, 115);
            this.btn_mon4.TabIndex = 3;
            this.btn_mon4.Text = "button1";
            this.btn_mon4.UseVisualStyleBackColor = true;
            this.btn_mon4.Click += new System.EventHandler(this.btn_mon4_Click);
            // 
            // btn_mon5
            // 
            this.btn_mon5.Location = new System.Drawing.Point(135, 124);
            this.btn_mon5.Name = "btn_mon5";
            this.btn_mon5.Size = new System.Drawing.Size(126, 115);
            this.btn_mon5.TabIndex = 4;
            this.btn_mon5.Text = "button1";
            this.btn_mon5.UseVisualStyleBackColor = true;
            this.btn_mon5.Click += new System.EventHandler(this.btn_mon5_Click);
            // 
            // btn_mon6
            // 
            this.btn_mon6.Location = new System.Drawing.Point(267, 124);
            this.btn_mon6.Name = "btn_mon6";
            this.btn_mon6.Size = new System.Drawing.Size(126, 115);
            this.btn_mon6.TabIndex = 5;
            this.btn_mon6.Text = "button1";
            this.btn_mon6.UseVisualStyleBackColor = true;
            this.btn_mon6.Click += new System.EventHandler(this.btn_mon6_Click);
            // 
            // CombatScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnl_monList);
            this.Controls.Add(this.pnl_spaceMaker);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chatterBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CombatScreen";
            this.Text = "Combat";
            this.Load += new System.EventHandler(this.Combat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.buttonGrid.ResumeLayout(false);
            this.pnl_monList.ResumeLayout(false);
            this.tlP_monPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_attack;
        public System.Windows.Forms.Button btn_defend;
        public System.Windows.Forms.Button btn_changeMon;
        public System.Windows.Forms.TextBox chatterBox;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Round;
        public System.Windows.Forms.Button btn_openBag;
        public System.Windows.Forms.TableLayoutPanel buttonGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_spaceMaker;
        public System.Windows.Forms.Panel pnl_monList;
        public System.Windows.Forms.TableLayoutPanel tlP_monPanel;
        public System.Windows.Forms.Button btn_mon6;
        public System.Windows.Forms.Button btn_mon5;
        public System.Windows.Forms.Button btn_mon4;
        public System.Windows.Forms.Button btn_mon3;
        public System.Windows.Forms.Button btn_mon2;
        public System.Windows.Forms.Button btn_mon1;
    }
}