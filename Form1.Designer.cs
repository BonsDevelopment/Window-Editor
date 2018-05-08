namespace Window_Editor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yLblEdit = new System.Windows.Forms.Label();
            this.xLblEdit = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hLblEdit = new System.Windows.Forms.Label();
            this.wLblEdit = new System.Windows.Forms.Label();
            this.defaultLblEdit2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            this.editCheckBox = new System.Windows.Forms.CheckBox();
            this.controlTimer = new System.Windows.Forms.Timer(this.components);
            this.defaultLblEdit = new System.Windows.Forms.Label();
            this.editTimer = new System.Windows.Forms.Timer(this.components);
            this.controlGrabber1 = new Window_Editor.Custom_Controls.ControlGrabber();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlGrabber1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yLblEdit);
            this.groupBox1.Controls.Add(this.xLblEdit);
            this.groupBox1.Controls.Add(this.yLabel);
            this.groupBox1.Controls.Add(this.xLabel);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // yLblEdit
            // 
            this.yLblEdit.AutoSize = true;
            this.yLblEdit.Location = new System.Drawing.Point(29, 42);
            this.yLblEdit.Name = "yLblEdit";
            this.yLblEdit.Size = new System.Drawing.Size(10, 13);
            this.yLblEdit.TabIndex = 4;
            this.yLblEdit.Text = "-";
            // 
            // xLblEdit
            // 
            this.xLblEdit.AutoSize = true;
            this.xLblEdit.Location = new System.Drawing.Point(29, 16);
            this.xLblEdit.Name = "xLblEdit";
            this.xLblEdit.Size = new System.Drawing.Size(10, 13);
            this.xLblEdit.TabIndex = 3;
            this.xLblEdit.Text = "-";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(6, 42);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(17, 13);
            this.yLabel.TabIndex = 1;
            this.yLabel.Text = "Y:";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(6, 16);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(17, 13);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hLblEdit);
            this.groupBox2.Controls.Add(this.wLblEdit);
            this.groupBox2.Controls.Add(this.defaultLblEdit2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.hLabel);
            this.groupBox2.Location = new System.Drawing.Point(10, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location";
            // 
            // hLblEdit
            // 
            this.hLblEdit.AutoSize = true;
            this.hLblEdit.Location = new System.Drawing.Point(53, 40);
            this.hLblEdit.Name = "hLblEdit";
            this.hLblEdit.Size = new System.Drawing.Size(10, 13);
            this.hLblEdit.TabIndex = 8;
            this.hLblEdit.Text = "-";
            // 
            // wLblEdit
            // 
            this.wLblEdit.AutoSize = true;
            this.wLblEdit.Location = new System.Drawing.Point(53, 16);
            this.wLblEdit.Name = "wLblEdit";
            this.wLblEdit.Size = new System.Drawing.Size(10, 13);
            this.wLblEdit.TabIndex = 7;
            this.wLblEdit.Text = "-";
            // 
            // defaultLblEdit2
            // 
            this.defaultLblEdit2.AutoSize = true;
            this.defaultLblEdit2.Location = new System.Drawing.Point(6, 70);
            this.defaultLblEdit2.Name = "defaultLblEdit2";
            this.defaultLblEdit2.Size = new System.Drawing.Size(10, 13);
            this.defaultLblEdit2.TabIndex = 6;
            this.defaultLblEdit2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width: ";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(6, 40);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(44, 13);
            this.hLabel.TabIndex = 0;
            this.hLabel.Text = "Height: ";
            // 
            // editCheckBox
            // 
            this.editCheckBox.AutoSize = true;
            this.editCheckBox.Location = new System.Drawing.Point(113, 173);
            this.editCheckBox.Name = "editCheckBox";
            this.editCheckBox.Size = new System.Drawing.Size(44, 17);
            this.editCheckBox.TabIndex = 3;
            this.editCheckBox.Text = "Edit";
            this.editCheckBox.UseVisualStyleBackColor = true;
            this.editCheckBox.CheckedChanged += new System.EventHandler(this.editCheckBox_CheckedChanged);
            // 
            // controlTimer
            // 
            this.controlTimer.Tick += new System.EventHandler(this.controlTimer_Tick);
            // 
            // defaultLblEdit
            // 
            this.defaultLblEdit.AutoSize = true;
            this.defaultLblEdit.Location = new System.Drawing.Point(16, 81);
            this.defaultLblEdit.Name = "defaultLblEdit";
            this.defaultLblEdit.Size = new System.Drawing.Size(10, 13);
            this.defaultLblEdit.TabIndex = 5;
            this.defaultLblEdit.Text = "-";
            // 
            // editTimer
            // 
            this.editTimer.Interval = 1;
            this.editTimer.Tick += new System.EventHandler(this.editTimer_Tick);
            // 
            // controlGrabber1
            // 
            this.controlGrabber1.BackColor = System.Drawing.Color.LightGray;
            this.controlGrabber1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlGrabber1.BackgroundImage")));
            this.controlGrabber1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.controlGrabber1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlGrabber1.Location = new System.Drawing.Point(174, 162);
            this.controlGrabber1.Name = "controlGrabber1";
            this.controlGrabber1.Size = new System.Drawing.Size(30, 28);
            this.controlGrabber1.TabIndex = 2;
            this.controlGrabber1.TabStop = false;
            this.controlGrabber1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlGrabber1_MouseDown);
            this.controlGrabber1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlGrabber1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 195);
            this.Controls.Add(this.defaultLblEdit);
            this.Controls.Add(this.editCheckBox);
            this.Controls.Add(this.controlGrabber1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Window Editor";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlGrabber1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Custom_Controls.ControlGrabber controlGrabber1;
        private System.Windows.Forms.CheckBox editCheckBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.Timer controlTimer;
        private System.Windows.Forms.Label defaultLblEdit;
        private System.Windows.Forms.Label yLblEdit;
        private System.Windows.Forms.Label xLblEdit;
        private System.Windows.Forms.Label defaultLblEdit2;
        private System.Windows.Forms.Label hLblEdit;
        private System.Windows.Forms.Label wLblEdit;
        private System.Windows.Forms.Timer editTimer;
    }
}

