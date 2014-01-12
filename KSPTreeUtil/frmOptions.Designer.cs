namespace KSPTreeUtil
{
    partial class frmOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOptionsCancel = new System.Windows.Forms.Button();
            this.btnOptionsSave = new System.Windows.Forms.Button();
            this.tbKSPDir = new System.Windows.Forms.TextBox();
            this.btnFindKSP = new System.Windows.Forms.Button();
            this.dlgFindKSP = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGameData = new System.Windows.Forms.TextBox();
            this.tbSavesDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KSP Game Directory:";
            // 
            // btnOptionsCancel
            // 
            this.btnOptionsCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptionsCancel.Location = new System.Drawing.Point(598, 122);
            this.btnOptionsCancel.Name = "btnOptionsCancel";
            this.btnOptionsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnOptionsCancel.TabIndex = 1;
            this.btnOptionsCancel.Text = "Cancel";
            this.btnOptionsCancel.UseVisualStyleBackColor = true;
            this.btnOptionsCancel.Click += new System.EventHandler(this.btnOptionsCancel_Click);
            // 
            // btnOptionsSave
            // 
            this.btnOptionsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptionsSave.Location = new System.Drawing.Point(517, 122);
            this.btnOptionsSave.Name = "btnOptionsSave";
            this.btnOptionsSave.Size = new System.Drawing.Size(75, 23);
            this.btnOptionsSave.TabIndex = 2;
            this.btnOptionsSave.Text = "Save";
            this.btnOptionsSave.UseVisualStyleBackColor = true;
            this.btnOptionsSave.Click += new System.EventHandler(this.btnOptionsSave_Click);
            // 
            // tbKSPDir
            // 
            this.tbKSPDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKSPDir.Location = new System.Drawing.Point(126, 16);
            this.tbKSPDir.Name = "tbKSPDir";
            this.tbKSPDir.Size = new System.Drawing.Size(462, 20);
            this.tbKSPDir.TabIndex = 3;
            // 
            // btnFindKSP
            // 
            this.btnFindKSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindKSP.Location = new System.Drawing.Point(598, 14);
            this.btnFindKSP.Name = "btnFindKSP";
            this.btnFindKSP.Size = new System.Drawing.Size(75, 23);
            this.btnFindKSP.TabIndex = 4;
            this.btnFindKSP.Text = "Find KSP";
            this.btnFindKSP.UseVisualStyleBackColor = true;
            this.btnFindKSP.Click += new System.EventHandler(this.btnFindKSP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "GameData:";
            // 
            // tbGameData
            // 
            this.tbGameData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGameData.Location = new System.Drawing.Point(126, 52);
            this.tbGameData.Name = "tbGameData";
            this.tbGameData.ReadOnly = true;
            this.tbGameData.Size = new System.Drawing.Size(547, 20);
            this.tbGameData.TabIndex = 7;
            // 
            // tbSavesDir
            // 
            this.tbSavesDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSavesDir.Location = new System.Drawing.Point(125, 90);
            this.tbSavesDir.Name = "tbSavesDir";
            this.tbSavesDir.ReadOnly = true;
            this.tbSavesDir.Size = new System.Drawing.Size(547, 20);
            this.tbSavesDir.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Game saves:";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 157);
            this.Controls.Add(this.tbSavesDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGameData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFindKSP);
            this.Controls.Add(this.tbKSPDir);
            this.Controls.Add(this.btnOptionsSave);
            this.Controls.Add(this.btnOptionsCancel);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(693, 188);
            this.Name = "frmOptions";
            this.Text = "Options";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOptionsCancel;
        private System.Windows.Forms.Button btnOptionsSave;
        private System.Windows.Forms.TextBox tbKSPDir;
        private System.Windows.Forms.Button btnFindKSP;
        private System.Windows.Forms.FolderBrowserDialog dlgFindKSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGameData;
        private System.Windows.Forms.TextBox tbSavesDir;
        private System.Windows.Forms.Label label3;
    }
}