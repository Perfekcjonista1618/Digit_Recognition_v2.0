namespace Digit_Recognition_v2._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTrainNetwork = new System.Windows.Forms.Button();
            this.btnNetworkSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxDigit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTrainFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(119, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.Transparent;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompare.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCompare.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCompare.Location = new System.Drawing.Point(273, 76);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 25);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "Compare !";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(362, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTrainNetwork
            // 
            this.btnTrainNetwork.BackColor = System.Drawing.Color.Transparent;
            this.btnTrainNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrainNetwork.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrainNetwork.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTrainNetwork.Location = new System.Drawing.Point(273, 139);
            this.btnTrainNetwork.Name = "btnTrainNetwork";
            this.btnTrainNetwork.Size = new System.Drawing.Size(166, 49);
            this.btnTrainNetwork.TabIndex = 3;
            this.btnTrainNetwork.Text = "Train Network!";
            this.btnTrainNetwork.UseVisualStyleBackColor = false;
            this.btnTrainNetwork.Click += new System.EventHandler(this.btnTrainNetwork_Click);
            // 
            // btnNetworkSettings
            // 
            this.btnNetworkSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnNetworkSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNetworkSettings.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNetworkSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNetworkSettings.Location = new System.Drawing.Point(296, 231);
            this.btnNetworkSettings.Name = "btnNetworkSettings";
            this.btnNetworkSettings.Size = new System.Drawing.Size(143, 23);
            this.btnNetworkSettings.TabIndex = 4;
            this.btnNetworkSettings.Text = "Network Settings";
            this.btnNetworkSettings.UseVisualStyleBackColor = false;
            this.btnNetworkSettings.Click += new System.EventHandler(this.btnNetworkSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 200);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // txtBoxDigit
            // 
            this.txtBoxDigit.Location = new System.Drawing.Point(120, 55);
            this.txtBoxDigit.Name = "txtBoxDigit";
            this.txtBoxDigit.Size = new System.Drawing.Size(60, 20);
            this.txtBoxDigit.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Digit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Never Used";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(122, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnTrainFile
            // 
            this.btnTrainFile.BackColor = System.Drawing.Color.Transparent;
            this.btnTrainFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrainFile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrainFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTrainFile.Location = new System.Drawing.Point(296, 202);
            this.btnTrainFile.Name = "btnTrainFile";
            this.btnTrainFile.Size = new System.Drawing.Size(143, 23);
            this.btnTrainFile.TabIndex = 10;
            this.btnTrainFile.Text = "Train From File";
            this.btnTrainFile.UseVisualStyleBackColor = false;
            this.btnTrainFile.Click += new System.EventHandler(this.btnTrainFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Digit_Recognition_v2._0.Properties.Resources.bcgColorpng;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 266);
            this.Controls.Add(this.btnTrainFile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxDigit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNetworkSettings);
            this.Controls.Add(this.btnTrainNetwork);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Digit Recognition v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTrainNetwork;
        private System.Windows.Forms.Button btnNetworkSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxDigit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTrainFile;
    }
}

