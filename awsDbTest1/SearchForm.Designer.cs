
namespace awsDbTest1
{
    partial class SearchForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.minLabel = new System.Windows.Forms.Label();
            this.minValueLabel = new System.Windows.Forms.Label();
            this.sliderPanel = new System.Windows.Forms.Panel();
            this.sliderCategoryLabel = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.maxValueLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.addFighterButton = new System.Windows.Forms.Button();
            this.editFighterButton = new System.Windows.Forms.Button();
            this.deleteFighterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.sliderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(990, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 150);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search For Fighters";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1728, 385);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 31);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Nickname",
            "Height",
            "Weight",
            "Country"});
            this.comboBox1.Location = new System.Drawing.Point(213, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 33);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter your query";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(109, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(156, 69);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(24, 12);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(88, 25);
            this.minLabel.TabIndex = 8;
            this.minLabel.Text = "Minimum";
            // 
            // minValueLabel
            // 
            this.minValueLabel.AutoSize = true;
            this.minValueLabel.Location = new System.Drawing.Point(293, 17);
            this.minValueLabel.Name = "minValueLabel";
            this.minValueLabel.Size = new System.Drawing.Size(42, 25);
            this.minValueLabel.TabIndex = 9;
            this.minValueLabel.Text = "min";
            // 
            // sliderPanel
            // 
            this.sliderPanel.Controls.Add(this.sliderCategoryLabel);
            this.sliderPanel.Controls.Add(this.trackBar2);
            this.sliderPanel.Controls.Add(this.maxValueLabel);
            this.sliderPanel.Controls.Add(this.maxLabel);
            this.sliderPanel.Controls.Add(this.minLabel);
            this.sliderPanel.Controls.Add(this.minValueLabel);
            this.sliderPanel.Controls.Add(this.trackBar1);
            this.sliderPanel.Location = new System.Drawing.Point(593, 13);
            this.sliderPanel.Name = "sliderPanel";
            this.sliderPanel.Size = new System.Drawing.Size(361, 160);
            this.sliderPanel.TabIndex = 10;
            this.sliderPanel.Visible = false;
            // 
            // sliderCategoryLabel
            // 
            this.sliderCategoryLabel.AutoSize = true;
            this.sliderCategoryLabel.Location = new System.Drawing.Point(156, 134);
            this.sliderCategoryLabel.Name = "sliderCategoryLabel";
            this.sliderCategoryLabel.Size = new System.Drawing.Size(0, 25);
            this.sliderCategoryLabel.TabIndex = 13;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(109, 72);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(156, 69);
            this.trackBar2.TabIndex = 12;
            this.trackBar2.Value = 50;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // maxValueLabel
            // 
            this.maxValueLabel.AutoSize = true;
            this.maxValueLabel.Location = new System.Drawing.Point(293, 72);
            this.maxValueLabel.Name = "maxValueLabel";
            this.maxValueLabel.Size = new System.Drawing.Size(45, 25);
            this.maxValueLabel.TabIndex = 11;
            this.maxValueLabel.Text = "max";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(24, 72);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(91, 25);
            this.maxLabel.TabIndex = 10;
            this.maxLabel.Text = "Maximum";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 159);
            this.panel2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1393, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 150);
            this.button2.TabIndex = 0;
            this.button2.Text = "Show All Fighters";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addFighterButton
            // 
            this.addFighterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addFighterButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addFighterButton.ForeColor = System.Drawing.Color.White;
            this.addFighterButton.Location = new System.Drawing.Point(23, 570);
            this.addFighterButton.Name = "addFighterButton";
            this.addFighterButton.Size = new System.Drawing.Size(350, 150);
            this.addFighterButton.TabIndex = 0;
            this.addFighterButton.Text = "Add Fighter";
            this.addFighterButton.UseVisualStyleBackColor = false;
            this.addFighterButton.Click += new System.EventHandler(this.addFighterButton_Click);
            // 
            // editFighterButton
            // 
            this.editFighterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.editFighterButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editFighterButton.ForeColor = System.Drawing.Color.White;
            this.editFighterButton.Location = new System.Drawing.Point(725, 570);
            this.editFighterButton.Name = "editFighterButton";
            this.editFighterButton.Size = new System.Drawing.Size(350, 150);
            this.editFighterButton.TabIndex = 0;
            this.editFighterButton.Text = "Edit Fighter";
            this.editFighterButton.UseVisualStyleBackColor = false;
            this.editFighterButton.Click += new System.EventHandler(this.editFighterButton_Click);
            // 
            // deleteFighterButton
            // 
            this.deleteFighterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.deleteFighterButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteFighterButton.ForeColor = System.Drawing.Color.White;
            this.deleteFighterButton.Location = new System.Drawing.Point(1393, 570);
            this.deleteFighterButton.Name = "deleteFighterButton";
            this.deleteFighterButton.Size = new System.Drawing.Size(350, 150);
            this.deleteFighterButton.TabIndex = 0;
            this.deleteFighterButton.Text = "Delete Fighter";
            this.deleteFighterButton.UseVisualStyleBackColor = false;
            this.deleteFighterButton.Click += new System.EventHandler(this.deleteFighterButton_Click);
            // 
            // SearchForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 732);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sliderPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deleteFighterButton);
            this.Controls.Add(this.editFighterButton);
            this.Controls.Add(this.addFighterButton);
            this.Controls.Add(this.button1);
            this.Name = "SearchForm";
            this.Text = "UFC Database App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.sliderPanel.ResumeLayout(false);
            this.sliderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label minValueLabel;
        private System.Windows.Forms.Panel sliderPanel;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label maxValueLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label sliderCategoryLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addFighterButton;
        private System.Windows.Forms.Button editFighterButton;
        private System.Windows.Forms.Button deleteFighterButton;
    }
}

