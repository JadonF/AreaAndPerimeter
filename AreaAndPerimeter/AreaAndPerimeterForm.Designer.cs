namespace AreaAndPerimeter
{
    partial class frmAreaAndPerimeter
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
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.radPerimeter = new System.Windows.Forms.RadioButton();
            this.radArea = new System.Windows.Forms.RadioButton();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLength.Location = new System.Drawing.Point(62, 116);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(117, 26);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (m)";
            this.lblLength.Click += new System.EventHandler(this.lblLength_Click);
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtLength.Location = new System.Drawing.Point(185, 114);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(122, 29);
            this.txtLength.TabIndex = 1;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtWidth.Location = new System.Drawing.Point(185, 180);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(122, 29);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblWidth.Location = new System.Drawing.Point(62, 182);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(107, 26);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width (m)";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(350, 155);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // radPerimeter
            // 
            this.radPerimeter.AutoSize = true;
            this.radPerimeter.Location = new System.Drawing.Point(84, 289);
            this.radPerimeter.Name = "radPerimeter";
            this.radPerimeter.Size = new System.Drawing.Size(69, 17);
            this.radPerimeter.TabIndex = 5;
            this.radPerimeter.TabStop = true;
            this.radPerimeter.Text = "Perimeter";
            this.radPerimeter.UseVisualStyleBackColor = true;
            this.radPerimeter.CheckedChanged += new System.EventHandler(this.radPerimeter_CheckedChanged);
            // 
            // radArea
            // 
            this.radArea.AutoSize = true;
            this.radArea.Location = new System.Drawing.Point(84, 337);
            this.radArea.Name = "radArea";
            this.radArea.Size = new System.Drawing.Size(47, 17);
            this.radArea.TabIndex = 6;
            this.radArea.TabStop = true;
            this.radArea.Text = "Area";
            this.radArea.UseVisualStyleBackColor = true;
            this.radArea.CheckedChanged += new System.EventHandler(this.radArea_CheckedChanged);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPerimeter.Location = new System.Drawing.Point(200, 282);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(107, 26);
            this.lblPerimeter.TabIndex = 7;
            this.lblPerimeter.Text = "Perimeter";
            this.lblPerimeter.Click += new System.EventHandler(this.lblPerimeter_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblArea.Location = new System.Drawing.Point(200, 330);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(58, 26);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area";
            this.lblArea.Click += new System.EventHandler(this.lblArea_Click);
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(500, 24);
            this.mnuMenu.TabIndex = 9;
            this.mnuMenu.Text = "Menu";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmAreaAndPerimeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.radArea);
            this.Controls.Add(this.radPerimeter);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmAreaAndPerimeter";
            this.Text = "Area And Perimeter";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton radPerimeter;
        private System.Windows.Forms.RadioButton radArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

