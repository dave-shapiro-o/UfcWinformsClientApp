
namespace UfcWinformsClientApp
{
    partial class FighterUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.localityTextBox = new System.Windows.Forms.TextBox();
            this.associationTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.localityLabel = new System.Windows.Forms.Label();
            this.associationLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 636);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Country";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(145, 80);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(150, 31);
            this.idTextBox.TabIndex = 6;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(145, 140);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 31);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height";
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(145, 208);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(150, 31);
            this.nicknameTextBox.TabIndex = 8;
            this.nicknameTextBox.TextChanged += new System.EventHandler(this.nicknameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nickname";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(145, 274);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(150, 31);
            this.heightTextBox.TabIndex = 9;
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(145, 346);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(150, 31);
            this.weightTextBox.TabIndex = 10;
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "I.D. Number";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(145, 636);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(150, 31);
            this.countryTextBox.TabIndex = 11;
            this.countryTextBox.TextChanged += new System.EventHandler(this.countryTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.localityTextBox);
            this.panel1.Controls.Add(this.associationTextBox);
            this.panel1.Controls.Add(this.classTextBox);
            this.panel1.Controls.Add(this.localityLabel);
            this.panel1.Controls.Add(this.associationLabel);
            this.panel1.Controls.Add(this.classLabel);
            this.panel1.Controls.Add(this.urlTextBox);
            this.panel1.Controls.Add(this.urlLabel);
            this.panel1.Controls.Add(this.countryTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.weightTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.heightTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nicknameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(40, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 702);
            this.panel1.TabIndex = 12;
            // 
            // localityTextBox
            // 
            this.localityTextBox.Location = new System.Drawing.Point(145, 570);
            this.localityTextBox.Name = "localityTextBox";
            this.localityTextBox.Size = new System.Drawing.Size(150, 31);
            this.localityTextBox.TabIndex = 19;
            this.localityTextBox.TextChanged += new System.EventHandler(this.localityTextBox_TextChanged);
            // 
            // associationTextBox
            // 
            this.associationTextBox.Location = new System.Drawing.Point(145, 421);
            this.associationTextBox.Name = "associationTextBox";
            this.associationTextBox.Size = new System.Drawing.Size(150, 31);
            this.associationTextBox.TabIndex = 18;
            this.associationTextBox.TextChanged += new System.EventHandler(this.associationTextBox_TextChanged);
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(145, 493);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(150, 31);
            this.classTextBox.TabIndex = 17;
            this.classTextBox.TextChanged += new System.EventHandler(this.classTextBox_TextChanged);
            // 
            // localityLabel
            // 
            this.localityLabel.AutoSize = true;
            this.localityLabel.Location = new System.Drawing.Point(13, 570);
            this.localityLabel.Name = "localityLabel";
            this.localityLabel.Size = new System.Drawing.Size(71, 25);
            this.localityLabel.TabIndex = 16;
            this.localityLabel.Text = "Locality";
            // 
            // associationLabel
            // 
            this.associationLabel.AutoSize = true;
            this.associationLabel.Location = new System.Drawing.Point(13, 421);
            this.associationLabel.Name = "associationLabel";
            this.associationLabel.Size = new System.Drawing.Size(103, 25);
            this.associationLabel.TabIndex = 15;
            this.associationLabel.Text = "Association";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(13, 493);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(52, 25);
            this.classLabel.TabIndex = 14;
            this.classLabel.Text = "Class";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(145, 15);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(150, 31);
            this.urlTextBox.TabIndex = 13;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(13, 15);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(34, 25);
            this.urlLabel.TabIndex = 12;
            this.urlLabel.Text = "Url";
            // 
            // FighterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FighterUserControl";
            this.Size = new System.Drawing.Size(393, 764);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label localityLabel;
        private System.Windows.Forms.Label associationLabel;
        private System.Windows.Forms.Label classLabel;
        internal System.Windows.Forms.TextBox urlTextBox;
        internal System.Windows.Forms.TextBox idTextBox;
        internal System.Windows.Forms.TextBox nameTextBox;
        internal System.Windows.Forms.TextBox nicknameTextBox;
        internal System.Windows.Forms.TextBox heightTextBox;
        internal System.Windows.Forms.TextBox weightTextBox;
        internal System.Windows.Forms.TextBox countryTextBox;
        internal System.Windows.Forms.TextBox localityTextBox;
        internal System.Windows.Forms.TextBox associationTextBox;
        internal System.Windows.Forms.TextBox classTextBox;
    }
}
