namespace Game_Start
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
            this.Titlelabel = new System.Windows.Forms.Label();
            this.Easymode = new System.Windows.Forms.Button();
            this.Regularmode = new System.Windows.Forms.Button();
            this.Heroicmode = new System.Windows.Forms.Button();
            this.Legendarymode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.Location = new System.Drawing.Point(223, 43);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(233, 37);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "New Campaign";
            // 
            // Easymode
            // 
            this.Easymode.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easymode.Location = new System.Drawing.Point(259, 128);
            this.Easymode.Name = "Easymode";
            this.Easymode.Size = new System.Drawing.Size(161, 43);
            this.Easymode.TabIndex = 1;
            this.Easymode.Text = "Easy";
            this.Easymode.UseVisualStyleBackColor = true;
            this.Easymode.Click += new System.EventHandler(this.Easymode_Click);
            // 
            // Regularmode
            // 
            this.Regularmode.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regularmode.Location = new System.Drawing.Point(259, 195);
            this.Regularmode.Name = "Regularmode";
            this.Regularmode.Size = new System.Drawing.Size(161, 43);
            this.Regularmode.TabIndex = 2;
            this.Regularmode.Text = "Regular";
            this.Regularmode.UseVisualStyleBackColor = true;
            this.Regularmode.Click += new System.EventHandler(this.Regularmode_Click);
            // 
            // Heroicmode
            // 
            this.Heroicmode.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heroicmode.Location = new System.Drawing.Point(259, 261);
            this.Heroicmode.Name = "Heroicmode";
            this.Heroicmode.Size = new System.Drawing.Size(161, 43);
            this.Heroicmode.TabIndex = 3;
            this.Heroicmode.Text = "Heroic";
            this.Heroicmode.UseVisualStyleBackColor = true;
            this.Heroicmode.Click += new System.EventHandler(this.Heroicmode_Click);
            // 
            // Legendarymode
            // 
            this.Legendarymode.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Legendarymode.Location = new System.Drawing.Point(259, 327);
            this.Legendarymode.Name = "Legendarymode";
            this.Legendarymode.Size = new System.Drawing.Size(161, 43);
            this.Legendarymode.TabIndex = 4;
            this.Legendarymode.Text = "Legendary";
            this.Legendarymode.UseVisualStyleBackColor = true;
            this.Legendarymode.Click += new System.EventHandler(this.Legendarymode_Click);
            this.Legendarymode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Legendarymode_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(656, 469);
            this.Controls.Add(this.Legendarymode);
            this.Controls.Add(this.Heroicmode);
            this.Controls.Add(this.Regularmode);
            this.Controls.Add(this.Easymode);
            this.Controls.Add(this.Titlelabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Button Easymode;
        private System.Windows.Forms.Button Regularmode;
        private System.Windows.Forms.Button Heroicmode;
        private System.Windows.Forms.Button Legendarymode;
    }
}

