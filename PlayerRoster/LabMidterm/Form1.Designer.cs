namespace LabMidterm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbGuard = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.rbForward = new System.Windows.Forms.RadioButton();
            this.numFt = new System.Windows.Forms.NumericUpDown();
            this.numIn = new System.Windows.Forms.NumericUpDown();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblFt = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(390, 299);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(814, 62);
            this.txtName.TabIndex = 0;
            // 
            // rbGuard
            // 
            this.rbGuard.AutoSize = true;
            this.rbGuard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGuard.Location = new System.Drawing.Point(400, 460);
            this.rbGuard.Name = "rbGuard";
            this.rbGuard.Size = new System.Drawing.Size(167, 52);
            this.rbGuard.TabIndex = 1;
            this.rbGuard.TabStop = true;
            this.rbGuard.Text = "Guard";
            this.rbGuard.UseVisualStyleBackColor = true;
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCenter.Location = new System.Drawing.Point(400, 673);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(176, 52);
            this.rbCenter.TabIndex = 2;
            this.rbCenter.TabStop = true;
            this.rbCenter.Text = "Center";
            this.rbCenter.UseVisualStyleBackColor = true;
            // 
            // rbForward
            // 
            this.rbForward.AutoSize = true;
            this.rbForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbForward.Location = new System.Drawing.Point(400, 558);
            this.rbForward.Name = "rbForward";
            this.rbForward.Size = new System.Drawing.Size(204, 52);
            this.rbForward.TabIndex = 3;
            this.rbForward.TabStop = true;
            this.rbForward.Text = "Forward";
            this.rbForward.UseVisualStyleBackColor = true;
            // 
            // numFt
            // 
            this.numFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFt.Location = new System.Drawing.Point(400, 844);
            this.numFt.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numFt.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numFt.Name = "numFt";
            this.numFt.Size = new System.Drawing.Size(120, 55);
            this.numFt.TabIndex = 4;
            this.numFt.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numIn
            // 
            this.numIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIn.Location = new System.Drawing.Point(757, 844);
            this.numIn.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numIn.Name = "numIn";
            this.numIn.Size = new System.Drawing.Size(120, 55);
            this.numIn.TabIndex = 5;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(519, 83);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(358, 122);
            this.lblPlayer.TabIndex = 6;
            this.lblPlayer.Text = "Player";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(144, 302);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(153, 55);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(149, 460);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(194, 55);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "Position";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(154, 844);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(163, 55);
            this.lblHeight.TabIndex = 9;
            this.lblHeight.Text = "Height";
            // 
            // lblFt
            // 
            this.lblFt.AutoSize = true;
            this.lblFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFt.Location = new System.Drawing.Point(545, 856);
            this.lblFt.Name = "lblFt";
            this.lblFt.Size = new System.Drawing.Size(37, 40);
            this.lblFt.TabIndex = 10;
            this.lblFt.Text = "ft";
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.Location = new System.Drawing.Point(902, 859);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(45, 40);
            this.lblIn.TabIndex = 11;
            this.lblIn.Text = "in";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(149, 967);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(1055, 97);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update Player Info";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(149, 83);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(117, 92);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1087, 83);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 92);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 1146);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.lblFt);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.numIn);
            this.Controls.Add(this.numFt);
            this.Controls.Add(this.rbForward);
            this.Controls.Add(this.rbCenter);
            this.Controls.Add(this.rbGuard);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Enter += new System.EventHandler(this.btnUpdate_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numFt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbGuard;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.RadioButton rbForward;
        private System.Windows.Forms.NumericUpDown numFt;
        private System.Windows.Forms.NumericUpDown numIn;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblFt;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}

