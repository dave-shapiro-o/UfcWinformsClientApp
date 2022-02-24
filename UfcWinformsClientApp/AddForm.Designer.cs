
namespace UfcWinformsClientApp
{
    partial class AddForm
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
            this.fighterUserControl1 = new UfcWinformsClientApp.FighterUserControl();
            this.addFighterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fighterUserControl1
            // 
            this.fighterUserControl1.Location = new System.Drawing.Point(15, 4);
            this.fighterUserControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.fighterUserControl1.Name = "fighterUserControl1";
            this.fighterUserControl1.Size = new System.Drawing.Size(275, 435);
            this.fighterUserControl1.TabIndex = 0;
            // 
            // addFighterButton
            // 
            this.addFighterButton.BackColor = System.Drawing.Color.Fuchsia;
            this.addFighterButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addFighterButton.ForeColor = System.Drawing.Color.Purple;
            this.addFighterButton.Location = new System.Drawing.Point(316, 83);
            this.addFighterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addFighterButton.Name = "addFighterButton";
            this.addFighterButton.Size = new System.Drawing.Size(195, 95);
            this.addFighterButton.TabIndex = 1;
            this.addFighterButton.Text = "Add Fighter";
            this.addFighterButton.UseVisualStyleBackColor = false;
            this.addFighterButton.Click += new System.EventHandler(this.addFighterButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 446);
            this.Controls.Add(this.addFighterButton);
            this.Controls.Add(this.fighterUserControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddForm";
            this.Text = "Add Fighter To Database";
            this.ResumeLayout(false);

        }

        #endregion

        private FighterUserControl fighterUserControl1;
        private System.Windows.Forms.Button addFighterButton;
    }
}