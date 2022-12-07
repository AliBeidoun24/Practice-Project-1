namespace WindowsFormsApp1
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
            this.EmmettButton = new System.Windows.Forms.Button();
            this.SalehButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.HussienButton = new System.Windows.Forms.Button();
            this.TypePls = new System.Windows.Forms.TextBox();
            this.ReadOnly = new System.Windows.Forms.TextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MCAnswer3 = new System.Windows.Forms.TextBox();
            this.MCAnswer2 = new System.Windows.Forms.TextBox();
            this.MCAnswer1 = new System.Windows.Forms.TextBox();
            this.Reset_Copy = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Page1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmmettButton
            // 
            this.EmmettButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.EmmettButton.Location = new System.Drawing.Point(24, 24);
            this.EmmettButton.Name = "EmmettButton";
            this.EmmettButton.Size = new System.Drawing.Size(356, 244);
            this.EmmettButton.TabIndex = 0;
            this.EmmettButton.Text = "Emmett";
            this.EmmettButton.UseVisualStyleBackColor = true;
            this.EmmettButton.Click += new System.EventHandler(this.EmmettButton_Click);
            // 
            // SalehButton
            // 
            this.SalehButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.SalehButton.Location = new System.Drawing.Point(447, 24);
            this.SalehButton.Name = "SalehButton";
            this.SalehButton.Size = new System.Drawing.Size(356, 244);
            this.SalehButton.TabIndex = 1;
            this.SalehButton.Text = "Saleh";
            this.SalehButton.UseVisualStyleBackColor = true;
            this.SalehButton.Click += new System.EventHandler(this.SalehButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1076, 109);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emmett, Saleh, or Hussien";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page1);
            this.tabControl1.Controls.Add(this.Page2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1242, 659);
            this.tabControl1.TabIndex = 5;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.Reset_Copy);
            this.Page1.Controls.Add(this.MCAnswer2);
            this.Page1.Controls.Add(this.MCAnswer1);
            this.Page1.Controls.Add(this.MCAnswer3);
            this.Page1.Controls.Add(this.panel2);
            this.Page1.Controls.Add(this.panel1);
            this.Page1.Controls.Add(this.Copy);
            this.Page1.Controls.Add(this.ReadOnly);
            this.Page1.Controls.Add(this.TypePls);
            this.Page1.Controls.Add(this.HussienButton);
            this.Page1.Controls.Add(this.EmmettButton);
            this.Page1.Controls.Add(this.SalehButton);
            this.Page1.Controls.Add(this.label1);
            this.Page1.Location = new System.Drawing.Point(4, 22);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(1234, 633);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Page1";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // Page2
            // 
            this.Page2.Location = new System.Drawing.Point(4, 22);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(1232, 614);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "Page2";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // HussienButton
            // 
            this.HussienButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.HussienButton.Location = new System.Drawing.Point(856, 24);
            this.HussienButton.Name = "HussienButton";
            this.HussienButton.Size = new System.Drawing.Size(356, 244);
            this.HussienButton.TabIndex = 5;
            this.HussienButton.Text = "Hussien";
            this.HussienButton.UseVisualStyleBackColor = true;
            this.HussienButton.Click += new System.EventHandler(this.HussienButton_Click);
            // 
            // TypePls
            // 
            this.TypePls.Location = new System.Drawing.Point(464, 481);
            this.TypePls.Name = "TypePls";
            this.TypePls.Size = new System.Drawing.Size(100, 20);
            this.TypePls.TabIndex = 6;
            this.TypePls.TextChanged += new System.EventHandler(this.TypePls_TextChanged);
            // 
            // ReadOnly
            // 
            this.ReadOnly.Location = new System.Drawing.Point(678, 481);
            this.ReadOnly.Name = "ReadOnly";
            this.ReadOnly.ReadOnly = true;
            this.ReadOnly.Size = new System.Drawing.Size(100, 20);
            this.ReadOnly.TabIndex = 7;
            this.ReadOnly.TextChanged += new System.EventHandler(this.ReadOnly_TextChanged);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(570, 481);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(103, 23);
            this.Copy.TabIndex = 8;
            this.Copy.Text = "Copy Text Over";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 20);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(3, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 24);
            this.panel2.TabIndex = 10;
            // 
            // MCAnswer3
            // 
            this.MCAnswer3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MCAnswer3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MCAnswer3.Location = new System.Drawing.Point(447, 408);
            this.MCAnswer3.Margin = new System.Windows.Forms.Padding(0);
            this.MCAnswer3.Name = "MCAnswer3";
            this.MCAnswer3.ReadOnly = true;
            this.MCAnswer3.Size = new System.Drawing.Size(356, 13);
            this.MCAnswer3.TabIndex = 11;
            // 
            // MCAnswer2
            // 
            this.MCAnswer2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MCAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MCAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.MCAnswer2.Location = new System.Drawing.Point(447, 395);
            this.MCAnswer2.Margin = new System.Windows.Forms.Padding(0);
            this.MCAnswer2.Name = "MCAnswer2";
            this.MCAnswer2.ReadOnly = true;
            this.MCAnswer2.Size = new System.Drawing.Size(356, 28);
            this.MCAnswer2.TabIndex = 12;
            this.MCAnswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MCAnswer2.TextChanged += new System.EventHandler(this.MCAnswer2_TextChanged);
            // 
            // MCAnswer1
            // 
            this.MCAnswer1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MCAnswer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MCAnswer1.Location = new System.Drawing.Point(447, 382);
            this.MCAnswer1.Margin = new System.Windows.Forms.Padding(0);
            this.MCAnswer1.Name = "MCAnswer1";
            this.MCAnswer1.ReadOnly = true;
            this.MCAnswer1.Size = new System.Drawing.Size(356, 13);
            this.MCAnswer1.TabIndex = 11;
            // 
            // Reset_Copy
            // 
            this.Reset_Copy.Location = new System.Drawing.Point(570, 509);
            this.Reset_Copy.Name = "Reset_Copy";
            this.Reset_Copy.Size = new System.Drawing.Size(103, 23);
            this.Reset_Copy.TabIndex = 13;
            this.Reset_Copy.Text = "Reset Text Copier";
            this.Reset_Copy.UseVisualStyleBackColor = true;
            this.Reset_Copy.Click += new System.EventHandler(this.Reset_Copy_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.Transparent;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(0, 597);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(1242, 62);
            this.Exit.TabIndex = 14;
            this.Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 659);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmmettButton;
        private System.Windows.Forms.Button SalehButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.Button HussienButton;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.TextBox ReadOnly;
        private System.Windows.Forms.TextBox TypePls;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.TextBox MCAnswer2;
        private System.Windows.Forms.TextBox MCAnswer1;
        private System.Windows.Forms.TextBox MCAnswer3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Reset_Copy;
        private System.Windows.Forms.Button Exit;
    }
}

