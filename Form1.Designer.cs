
namespace CRUD_App
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
            this.Dodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Imie_textBox = new System.Windows.Forms.TextBox();
            this.Nazwisko_textBox = new System.Windows.Forms.TextBox();
            this.Id_działu_textBox = new System.Windows.Forms.TextBox();
            this.Pensja_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Id_pracownika_textBox = new System.Windows.Forms.TextBox();
            this.Usuń = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(45, 224);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 0;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id_działu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pensja";
            // 
            // Imie_textBox
            // 
            this.Imie_textBox.Location = new System.Drawing.Point(283, 73);
            this.Imie_textBox.Name = "Imie_textBox";
            this.Imie_textBox.Size = new System.Drawing.Size(200, 20);
            this.Imie_textBox.TabIndex = 6;
            // 
            // Nazwisko_textBox
            // 
            this.Nazwisko_textBox.Location = new System.Drawing.Point(283, 104);
            this.Nazwisko_textBox.Name = "Nazwisko_textBox";
            this.Nazwisko_textBox.Size = new System.Drawing.Size(200, 20);
            this.Nazwisko_textBox.TabIndex = 7;
            // 
            // Id_działu_textBox
            // 
            this.Id_działu_textBox.Location = new System.Drawing.Point(283, 141);
            this.Id_działu_textBox.Name = "Id_działu_textBox";
            this.Id_działu_textBox.Size = new System.Drawing.Size(200, 20);
            this.Id_działu_textBox.TabIndex = 8;
            // 
            // Pensja_textBox
            // 
            this.Pensja_textBox.Location = new System.Drawing.Point(283, 178);
            this.Pensja_textBox.Name = "Pensja_textBox";
            this.Pensja_textBox.Size = new System.Drawing.Size(200, 20);
            this.Pensja_textBox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 214);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Aktualizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Aktualizuj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id_pracownika";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Id_pracownika_textBox
            // 
            this.Id_pracownika_textBox.Location = new System.Drawing.Point(283, 37);
            this.Id_pracownika_textBox.Name = "Id_pracownika_textBox";
            this.Id_pracownika_textBox.Size = new System.Drawing.Size(200, 20);
            this.Id_pracownika_textBox.TabIndex = 14;
            // 
            // Usuń
            // 
            this.Usuń.Location = new System.Drawing.Point(407, 224);
            this.Usuń.Name = "Usuń";
            this.Usuń.Size = new System.Drawing.Size(75, 23);
            this.Usuń.TabIndex = 18;
            this.Usuń.Text = "Usuń";
            this.Usuń.UseVisualStyleBackColor = true;
            this.Usuń.Click += new System.EventHandler(this.Usuń_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 545);
            this.Controls.Add(this.Usuń);
            this.Controls.Add(this.Id_pracownika_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Pensja_textBox);
            this.Controls.Add(this.Id_działu_textBox);
            this.Controls.Add(this.Nazwisko_textBox);
            this.Controls.Add(this.Imie_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dodaj);
            this.Name = "Form1";
            this.Text = "CRUD App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Imie_textBox;
        private System.Windows.Forms.TextBox Nazwisko_textBox;
        private System.Windows.Forms.TextBox Id_działu_textBox;
        private System.Windows.Forms.TextBox Pensja_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Id_pracownika_textBox;
        private System.Windows.Forms.Button Usuń;
    }
}

