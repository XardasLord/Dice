namespace Kości
{
    partial class Ustawienia
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
            this.cbTło = new System.Windows.Forms.ComboBox();
            this.btnZatwierdź = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKartka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDźwiękKości = new System.Windows.Forms.CheckBox();
            this.checkBoxDźwiękWyniku = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbTło
            // 
            this.cbTło.FormattingEnabled = true;
            this.cbTło.Items.AddRange(new object[] {
            "Błękitne",
            "Turkusowe",
            "Kremowe",
            "Różowe"});
            this.cbTło.Location = new System.Drawing.Point(127, 28);
            this.cbTło.Name = "cbTło";
            this.cbTło.Size = new System.Drawing.Size(104, 21);
            this.cbTło.TabIndex = 0;
            // 
            // btnZatwierdź
            // 
            this.btnZatwierdź.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnZatwierdź.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnZatwierdź.FlatAppearance.BorderSize = 2;
            this.btnZatwierdź.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnZatwierdź.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnZatwierdź.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatwierdź.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatwierdź.Location = new System.Drawing.Point(82, 215);
            this.btnZatwierdź.Name = "btnZatwierdź";
            this.btnZatwierdź.Size = new System.Drawing.Size(131, 44);
            this.btnZatwierdź.TabIndex = 1;
            this.btnZatwierdź.Text = "Zatwierdź";
            this.btnZatwierdź.UseVisualStyleBackColor = false;
            this.btnZatwierdź.Click += new System.EventHandler(this.btnZatwierdź_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kolor tła:";
            // 
            // cbKartka
            // 
            this.cbKartka.FormattingEnabled = true;
            this.cbKartka.Items.AddRange(new object[] {
            "Jasnobrązowa",
            "Zielona",
            "Biała",
            "Jasnożółta"});
            this.cbKartka.Location = new System.Drawing.Point(127, 65);
            this.cbKartka.Name = "cbKartka";
            this.cbKartka.Size = new System.Drawing.Size(104, 21);
            this.cbKartka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kolor kartki:";
            // 
            // checkBoxDźwiękKości
            // 
            this.checkBoxDźwiękKości.AutoSize = true;
            this.checkBoxDźwiękKości.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBoxDźwiękKości.Checked = true;
            this.checkBoxDźwiękKości.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDźwiękKości.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxDźwiękKości.Location = new System.Drawing.Point(35, 107);
            this.checkBoxDźwiękKości.Name = "checkBoxDźwiękKości";
            this.checkBoxDźwiękKości.Size = new System.Drawing.Size(209, 23);
            this.checkBoxDźwiękKości.TabIndex = 5;
            this.checkBoxDźwiękKości.Text = "Dźwięk przy rzucaniu kośćmi";
            this.checkBoxDźwiękKości.UseVisualStyleBackColor = false;
            // 
            // checkBoxDźwiękWyniku
            // 
            this.checkBoxDźwiękWyniku.AutoSize = true;
            this.checkBoxDźwiękWyniku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBoxDźwiękWyniku.Checked = true;
            this.checkBoxDźwiękWyniku.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDźwiękWyniku.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxDźwiękWyniku.Location = new System.Drawing.Point(35, 133);
            this.checkBoxDźwiękWyniku.Name = "checkBoxDźwiękWyniku";
            this.checkBoxDźwiękWyniku.Size = new System.Drawing.Size(224, 23);
            this.checkBoxDźwiękWyniku.TabIndex = 6;
            this.checkBoxDźwiękWyniku.Text = "Dźwięk przy wpisywaniu wyniku";
            this.checkBoxDźwiękWyniku.UseVisualStyleBackColor = false;
            // 
            // Ustawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Kości.Properties.Resources.ustawienia2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 292);
            this.Controls.Add(this.checkBoxDźwiękWyniku);
            this.Controls.Add(this.checkBoxDźwiękKości);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbKartka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZatwierdź);
            this.Controls.Add(this.cbTło);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ustawienia";
            this.Text = "Ustawienia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ustawienia_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTło;
        private System.Windows.Forms.Button btnZatwierdź;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKartka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDźwiękKości;
        private System.Windows.Forms.CheckBox checkBoxDźwiękWyniku;
    }
}