namespace WinFormTask
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelx = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.labelz = new System.Windows.Forms.Label();
            this.labelr = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.but = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelx.ForeColor = System.Drawing.Color.Green;
            this.labelx.Location = new System.Drawing.Point(56, 24);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(44, 27);
            this.labelx.TabIndex = 0;
            this.labelx.Text = "x =";
            this.labelx.Click += new System.EventHandler(this.label1_Click);
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labely.ForeColor = System.Drawing.Color.Green;
            this.labely.Location = new System.Drawing.Point(55, 68);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(45, 27);
            this.labely.TabIndex = 0;
            this.labely.Text = "y =";
            // 
            // labelz
            // 
            this.labelz.AutoSize = true;
            this.labelz.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelz.ForeColor = System.Drawing.Color.Green;
            this.labelz.Location = new System.Drawing.Point(55, 116);
            this.labelz.Name = "labelz";
            this.labelz.Size = new System.Drawing.Size(45, 27);
            this.labelz.TabIndex = 0;
            this.labelz.Text = "z =";
            // 
            // labelr
            // 
            this.labelr.AutoSize = true;
            this.labelr.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelr.ForeColor = System.Drawing.Color.Green;
            this.labelr.Location = new System.Drawing.Point(55, 225);
            this.labelr.Name = "labelr";
            this.labelr.Size = new System.Drawing.Size(41, 27);
            this.labelr.TabIndex = 0;
            this.labelr.Text = "r =";
            // 
            // textBoxX
            // 
            this.textBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX.Location = new System.Drawing.Point(134, 24);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(174, 22);
            this.textBoxX.TabIndex = 1;
            // 
            // textBoxY
            // 
            this.textBoxY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxY.Location = new System.Drawing.Point(134, 68);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(174, 22);
            this.textBoxY.TabIndex = 1;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxZ.Location = new System.Drawing.Point(134, 116);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(174, 22);
            this.textBoxZ.TabIndex = 1;
            // 
            // textBoxR
            // 
            this.textBoxR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxR.Location = new System.Drawing.Point(134, 225);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.Size = new System.Drawing.Size(174, 22);
            this.textBoxR.TabIndex = 1;
            // 
            // but
            // 
            this.but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.but.Font = new System.Drawing.Font("Arial", 14F);
            this.but.Location = new System.Drawing.Point(134, 168);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(175, 38);
            this.but.TabIndex = 2;
            this.but.Text = "Обчислити";
            this.but.UseVisualStyleBackColor = false;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(128, 301);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(266, 27);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Кошелєв М. П. КН-19-1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(406, 337);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.but);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelr);
            this.Controls.Add(this.labelz);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.labelx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(621, 557);
            this.MinimumSize = new System.Drawing.Size(330, 330);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практична робота №2. Завдання 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label labelz;
        private System.Windows.Forms.Label labelr;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Button but;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

