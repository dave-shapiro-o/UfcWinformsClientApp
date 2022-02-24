
namespace UfcWinformsClientApp
{
    partial class EditForm
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
            this.saveFighterButton = new System.Windows.Forms.Button();
            this.urlLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.associationLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.localityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.localityTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.associationTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveFighterButton
            // 
            this.saveFighterButton.BackColor = System.Drawing.Color.Fuchsia;
            this.saveFighterButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveFighterButton.ForeColor = System.Drawing.Color.Purple;
            this.saveFighterButton.Location = new System.Drawing.Point(342, 308);
            this.saveFighterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveFighterButton.Name = "saveFighterButton";
            this.saveFighterButton.Size = new System.Drawing.Size(195, 95);
            this.saveFighterButton.TabIndex = 2;
            this.saveFighterButton.Text = "Save Fighter";
            this.saveFighterButton.UseVisualStyleBackColor = false;
            this.saveFighterButton.Click += new System.EventHandler(this.saveFighterButton_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(17, 16);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(22, 15);
            this.urlLabel.TabIndex = 7;
            this.urlLabel.Text = "Url";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(17, 54);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 15);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "I.D.";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 94);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(17, 136);
            this.nicknameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(61, 15);
            this.nicknameLabel.TabIndex = 7;
            this.nicknameLabel.Text = "Nickname";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(17, 175);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(43, 15);
            this.heightLabel.TabIndex = 7;
            this.heightLabel.Text = "Height";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(17, 217);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(45, 15);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Weight";
            // 
            // associationLabel
            // 
            this.associationLabel.AutoSize = true;
            this.associationLabel.Location = new System.Drawing.Point(17, 259);
            this.associationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.associationLabel.Name = "associationLabel";
            this.associationLabel.Size = new System.Drawing.Size(68, 15);
            this.associationLabel.TabIndex = 7;
            this.associationLabel.Text = "Association";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(17, 304);
            this.classLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(34, 15);
            this.classLabel.TabIndex = 7;
            this.classLabel.Text = "Class";
            // 
            // localityLabel
            // 
            this.localityLabel.AutoSize = true;
            this.localityLabel.Location = new System.Drawing.Point(17, 346);
            this.localityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.localityLabel.Name = "localityLabel";
            this.localityLabel.Size = new System.Drawing.Size(48, 15);
            this.localityLabel.TabIndex = 7;
            this.localityLabel.Text = "Locality";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(17, 385);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(50, 15);
            this.countryLabel.TabIndex = 7;
            this.countryLabel.Text = "Country";
            // 
            // localityTextBox
            // 
            this.localityTextBox.Location = new System.Drawing.Point(107, 346);
            this.localityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.localityTextBox.Name = "localityTextBox";
            this.localityTextBox.Size = new System.Drawing.Size(227, 23);
            this.localityTextBox.TabIndex = 8;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(107, 54);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(227, 23);
            this.idTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(107, 94);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(227, 23);
            this.nameTextBox.TabIndex = 8;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(107, 136);
            this.nicknameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(227, 23);
            this.nicknameTextBox.TabIndex = 8;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(107, 175);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(227, 23);
            this.heightTextBox.TabIndex = 8;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(107, 217);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(227, 23);
            this.weightTextBox.TabIndex = 8;
            // 
            // associationTextBox
            // 
            this.associationTextBox.Location = new System.Drawing.Point(107, 259);
            this.associationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.associationTextBox.Name = "associationTextBox";
            this.associationTextBox.Size = new System.Drawing.Size(227, 23);
            this.associationTextBox.TabIndex = 8;
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(107, 304);
            this.classTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(227, 23);
            this.classTextBox.TabIndex = 8;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(107, 385);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(227, 23);
            this.countryTextBox.TabIndex = 8;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(107, 16);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(227, 23);
            this.urlTextBox.TabIndex = 8;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 446);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.associationTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.localityTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.localityLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.associationLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.saveFighterButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditForm";
            this.Text = "Edit Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveFighterButton;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label associationLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label localityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox localityTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox associationTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
    }
}