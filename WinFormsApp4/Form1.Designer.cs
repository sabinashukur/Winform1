namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Baku = new System.Windows.Forms.Button();
            this.btn_London = new System.Windows.Forms.Button();
            this.lbl_Clock = new System.Windows.Forms.Label();
            this.btn_Running = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Baku
            // 
            this.btn_Baku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Baku.Location = new System.Drawing.Point(287, 128);
            this.btn_Baku.Name = "btn_Baku";
            this.btn_Baku.Size = new System.Drawing.Size(155, 101);
            this.btn_Baku.TabIndex = 0;
            this.btn_Baku.Text = "Baku";
            this.btn_Baku.UseVisualStyleBackColor = true;
            this.btn_Baku.Click += new System.EventHandler(this.btn_Baku_Click);
            // 
            // btn_London
            // 
            this.btn_London.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_London.Location = new System.Drawing.Point(473, 128);
            this.btn_London.Name = "btn_London";
            this.btn_London.Size = new System.Drawing.Size(158, 101);
            this.btn_London.TabIndex = 1;
            this.btn_London.Text = "London";
            this.btn_London.UseVisualStyleBackColor = true;
            this.btn_London.Click += new System.EventHandler(this.btn_London_Click);
            // 
            // lbl_Clock
            // 
            this.lbl_Clock.AutoSize = true;
            this.lbl_Clock.Location = new System.Drawing.Point(113, 168);
            this.lbl_Clock.Name = "lbl_Clock";
            this.lbl_Clock.Size = new System.Drawing.Size(45, 20);
            this.lbl_Clock.TabIndex = 2;
            this.lbl_Clock.Text = "Clock";
            // 
            // btn_Running
            // 
            this.btn_Running.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Running.Location = new System.Drawing.Point(62, 281);
            this.btn_Running.Name = "btn_Running";
            this.btn_Running.Size = new System.Drawing.Size(296, 76);
            this.btn_Running.TabIndex = 3;
            this.btn_Running.Text = "RunningButton";
            this.btn_Running.UseVisualStyleBackColor = true;
            this.btn_Running.MouseEnter += new System.EventHandler(this.btn_Running_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Running);
            this.Controls.Add(this.lbl_Clock);
            this.Controls.Add(this.btn_London);
            this.Controls.Add(this.btn_Baku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Baku;
        private Button btn_London;
        private Label lbl_Clock;
        private Button btn_Running;
    }
}