namespace RegisztracioAlkalmazas
{
    partial class RegisztracioAlkalmazas
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
            this.hobbiListBox = new System.Windows.Forms.ListBox();
            this.HozzaAdButton = new System.Windows.Forms.Button();
            this.lblSzuldat = new System.Windows.Forms.Label();
            this.FradioButton = new System.Windows.Forms.RadioButton();
            this.szuldatTextBox = new System.Windows.Forms.TextBox();
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.lblNev = new System.Windows.Forms.Label();
            this.NradioButton = new System.Windows.Forms.RadioButton();
            this.lblNem = new System.Windows.Forms.Label();
            this.mentesButton = new System.Windows.Forms.Button();
            this.betoltButton = new System.Windows.Forms.Button();
            this.ujHobbiTextBox = new System.Windows.Forms.TextBox();
            this.lblUjhobbi = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblKedvencHobbi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hobbiListBox
            // 
            this.hobbiListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hobbiListBox.FormattingEnabled = true;
            this.hobbiListBox.ItemHeight = 16;
            this.hobbiListBox.Items.AddRange(new object[] {
            "Úszás",
            "Horgászat",
            "Futás"});
            this.hobbiListBox.Location = new System.Drawing.Point(260, 28);
            this.hobbiListBox.Name = "hobbiListBox";
            this.hobbiListBox.Size = new System.Drawing.Size(120, 84);
            this.hobbiListBox.TabIndex = 0;
            // 
            // HozzaAdButton
            // 
            this.HozzaAdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HozzaAdButton.Location = new System.Drawing.Point(277, 147);
            this.HozzaAdButton.Name = "HozzaAdButton";
            this.HozzaAdButton.Size = new System.Drawing.Size(75, 23);
            this.HozzaAdButton.TabIndex = 1;
            this.HozzaAdButton.Text = "Hozzáad";
            this.HozzaAdButton.UseVisualStyleBackColor = true;
            this.HozzaAdButton.Click += new System.EventHandler(this.HozzaAdButton_Click);
            // 
            // lblSzuldat
            // 
            this.lblSzuldat.AutoSize = true;
            this.lblSzuldat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzuldat.Location = new System.Drawing.Point(12, 9);
            this.lblSzuldat.Name = "lblSzuldat";
            this.lblSzuldat.Size = new System.Drawing.Size(112, 17);
            this.lblSzuldat.TabIndex = 2;
            this.lblSzuldat.Text = "Születési dátum:";
            // 
            // FradioButton
            // 
            this.FradioButton.AutoSize = true;
            this.FradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FradioButton.Location = new System.Drawing.Point(135, 67);
            this.FradioButton.Name = "FradioButton";
            this.FradioButton.Size = new System.Drawing.Size(34, 21);
            this.FradioButton.TabIndex = 3;
            this.FradioButton.TabStop = true;
            this.FradioButton.Text = "F";
            this.FradioButton.UseVisualStyleBackColor = true;
            // 
            // szuldatTextBox
            // 
            this.szuldatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szuldatTextBox.Location = new System.Drawing.Point(135, 9);
            this.szuldatTextBox.Name = "szuldatTextBox";
            this.szuldatTextBox.Size = new System.Drawing.Size(100, 23);
            this.szuldatTextBox.TabIndex = 4;
            // 
            // nevTextBox
            // 
            this.nevTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nevTextBox.Location = new System.Drawing.Point(135, 38);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(100, 23);
            this.nevTextBox.TabIndex = 5;
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNev.Location = new System.Drawing.Point(87, 41);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(37, 17);
            this.lblNev.TabIndex = 6;
            this.lblNev.Text = "Név:";
            // 
            // NradioButton
            // 
            this.NradioButton.AutoSize = true;
            this.NradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NradioButton.Location = new System.Drawing.Point(187, 67);
            this.NradioButton.Name = "NradioButton";
            this.NradioButton.Size = new System.Drawing.Size(36, 21);
            this.NradioButton.TabIndex = 7;
            this.NradioButton.TabStop = true;
            this.NradioButton.Text = "N";
            this.NradioButton.UseVisualStyleBackColor = true;
            // 
            // lblNem
            // 
            this.lblNem.AutoSize = true;
            this.lblNem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNem.Location = new System.Drawing.Point(83, 69);
            this.lblNem.Name = "lblNem";
            this.lblNem.Size = new System.Drawing.Size(41, 17);
            this.lblNem.TabIndex = 8;
            this.lblNem.Text = "Nem:";
            // 
            // mentesButton
            // 
            this.mentesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesButton.Location = new System.Drawing.Point(160, 232);
            this.mentesButton.Name = "mentesButton";
            this.mentesButton.Size = new System.Drawing.Size(75, 23);
            this.mentesButton.TabIndex = 9;
            this.mentesButton.Text = "Mentés";
            this.mentesButton.UseVisualStyleBackColor = true;
            this.mentesButton.Click += new System.EventHandler(this.mentesButton_Click);
            // 
            // betoltButton
            // 
            this.betoltButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betoltButton.Location = new System.Drawing.Point(277, 232);
            this.betoltButton.Name = "betoltButton";
            this.betoltButton.Size = new System.Drawing.Size(75, 23);
            this.betoltButton.TabIndex = 10;
            this.betoltButton.Text = "Betöltés";
            this.betoltButton.UseVisualStyleBackColor = true;
            this.betoltButton.Click += new System.EventHandler(this.betoltButton_Click);
            // 
            // ujHobbiTextBox
            // 
            this.ujHobbiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujHobbiTextBox.Location = new System.Drawing.Point(266, 118);
            this.ujHobbiTextBox.Name = "ujHobbiTextBox";
            this.ujHobbiTextBox.Size = new System.Drawing.Size(100, 23);
            this.ujHobbiTextBox.TabIndex = 11;
            // 
            // lblUjhobbi
            // 
            this.lblUjhobbi.AutoSize = true;
            this.lblUjhobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUjhobbi.Location = new System.Drawing.Point(188, 150);
            this.lblUjhobbi.Name = "lblUjhobbi";
            this.lblUjhobbi.Size = new System.Drawing.Size(64, 17);
            this.lblUjhobbi.TabIndex = 12;
            this.lblUjhobbi.Text = "Új hobbi:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Szöveges fájlok|*.txt|Minden fájlok|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Szöveges fájlok|*.txt|Minden fájlok|*.*";
            // 
            // lblKedvencHobbi
            // 
            this.lblKedvencHobbi.AutoSize = true;
            this.lblKedvencHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKedvencHobbi.Location = new System.Drawing.Point(257, 8);
            this.lblKedvencHobbi.Name = "lblKedvencHobbi";
            this.lblKedvencHobbi.Size = new System.Drawing.Size(109, 17);
            this.lblKedvencHobbi.TabIndex = 13;
            this.lblKedvencHobbi.Text = "Kedvenc hobbik";
            // 
            // RegisztracioAlkalmazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 267);
            this.Controls.Add(this.lblKedvencHobbi);
            this.Controls.Add(this.lblUjhobbi);
            this.Controls.Add(this.ujHobbiTextBox);
            this.Controls.Add(this.betoltButton);
            this.Controls.Add(this.mentesButton);
            this.Controls.Add(this.lblNem);
            this.Controls.Add(this.NradioButton);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.nevTextBox);
            this.Controls.Add(this.szuldatTextBox);
            this.Controls.Add(this.FradioButton);
            this.Controls.Add(this.lblSzuldat);
            this.Controls.Add(this.HozzaAdButton);
            this.Controls.Add(this.hobbiListBox);
            this.Name = "RegisztracioAlkalmazas";
            this.Text = "Regisztrációs alkalmazás";
            this.Load += new System.EventHandler(this.RegisztracioAlkalmazas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox hobbiListBox;
        private System.Windows.Forms.Button HozzaAdButton;
        private System.Windows.Forms.Label lblSzuldat;
        private System.Windows.Forms.RadioButton FradioButton;
        private System.Windows.Forms.TextBox szuldatTextBox;
        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.RadioButton NradioButton;
        private System.Windows.Forms.Label lblNem;
        private System.Windows.Forms.Button mentesButton;
        private System.Windows.Forms.Button betoltButton;
        private System.Windows.Forms.TextBox ujHobbiTextBox;
        private System.Windows.Forms.Label lblUjhobbi;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblKedvencHobbi;
    }
}

