namespace Kości
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
            this.btnGraj = new System.Windows.Forms.Button();
            this.btnWyjście = new System.Windows.Forms.Button();
            this.btnZasadyGry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGraj
            // 
            this.btnGraj.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraj.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnGraj.FlatAppearance.BorderSize = 2;
            this.btnGraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraj.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraj.Location = new System.Drawing.Point(98, 66);
            this.btnGraj.Name = "btnGraj";
            this.btnGraj.Size = new System.Drawing.Size(140, 40);
            this.btnGraj.TabIndex = 0;
            this.btnGraj.Text = "Graj";
            this.btnGraj.UseVisualStyleBackColor = false;
            this.btnGraj.Click += new System.EventHandler(this.btnGraj_Click);
            // 
            // btnWyjście
            // 
            this.btnWyjście.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnWyjście.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWyjście.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnWyjście.FlatAppearance.BorderSize = 2;
            this.btnWyjście.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnWyjście.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnWyjście.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWyjście.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyjście.Location = new System.Drawing.Point(98, 248);
            this.btnWyjście.Name = "btnWyjście";
            this.btnWyjście.Size = new System.Drawing.Size(140, 40);
            this.btnWyjście.TabIndex = 1;
            this.btnWyjście.Text = "Wyjście";
            this.btnWyjście.UseVisualStyleBackColor = false;
            this.btnWyjście.Click += new System.EventHandler(this.btnWyjście_Click);
            // 
            // btnZasadyGry
            // 
            this.btnZasadyGry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnZasadyGry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZasadyGry.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnZasadyGry.FlatAppearance.BorderSize = 2;
            this.btnZasadyGry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZasadyGry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnZasadyGry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZasadyGry.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZasadyGry.Location = new System.Drawing.Point(98, 155);
            this.btnZasadyGry.Name = "btnZasadyGry";
            this.btnZasadyGry.Size = new System.Drawing.Size(140, 40);
            this.btnZasadyGry.TabIndex = 2;
            this.btnZasadyGry.Text = "Zasady gry";
            this.btnZasadyGry.UseVisualStyleBackColor = false;
            this.btnZasadyGry.Click += new System.EventHandler(this.btnZasadyGry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kości.Properties.Resources.kości1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 362);
            this.Controls.Add(this.btnZasadyGry);
            this.Controls.Add(this.btnWyjście);
            this.Controls.Add(this.btnGraj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Gra w kości";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGraj;
        private System.Windows.Forms.Button btnWyjście;
        private System.Windows.Forms.Button btnZasadyGry;
    }
}

