namespace synes
{
    partial class frmSynes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSynes));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnDebug = new System.Windows.Forms.Button();
            this.cbShowVers = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(19, 118);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(1451, 43);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(569, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbOutput
            // 
            this.pbOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbOutput.Location = new System.Drawing.Point(19, 232);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(1451, 602);
            this.pbOutput.TabIndex = 2;
            this.pbOutput.TabStop = false;
            this.pbOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.pbOutput_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alec\'s scuffed synesthesia translator\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(621, 13);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(718, 100);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = resources.GetString("lblVersion.Text");
            this.lblVersion.Visible = false;
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(42, 38);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 23);
            this.btnDebug.TabIndex = 5;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // cbShowVers
            // 
            this.cbShowVers.AutoSize = true;
            this.cbShowVers.Location = new System.Drawing.Point(499, 67);
            this.cbShowVers.Name = "cbShowVers";
            this.cbShowVers.Size = new System.Drawing.Size(96, 17);
            this.cbShowVers.TabIndex = 6;
            this.cbShowVers.Text = "Show Versions";
            this.cbShowVers.UseVisualStyleBackColor = true;
            this.cbShowVers.CheckedChanged += new System.EventHandler(this.cbShowVers_CheckedChanged);
            // 
            // frmSynes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 846);
            this.Controls.Add(this.cbShowVers);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInput);
            this.Name = "frmSynes";
            this.Text = "Synesthesia";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSynes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.CheckBox cbShowVers;
    }
}

