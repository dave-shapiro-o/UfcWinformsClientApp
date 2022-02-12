
namespace UfcWinformsClientApp
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
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchCategoryLabel = new System.Windows.Forms.Label();
            this.searchQueryLabel = new System.Windows.Forms.Label();
            this.minTrackBar = new System.Windows.Forms.TrackBar();
            this.minLabel = new System.Windows.Forms.Label();
            this.minValueLabel = new System.Windows.Forms.Label();
            this.sliderPanel = new System.Windows.Forms.Panel();
            this.sliderCategoryLabel = new System.Windows.Forms.Label();
            this.maxTrackBar = new System.Windows.Forms.TrackBar();
            this.maxValueLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchAllButton = new System.Windows.Forms.Button();
            this.addFighterButton = new System.Windows.Forms.Button();
            this.editFighterButton = new System.Windows.Forms.Button();
            this.deleteFighterButton = new System.Windows.Forms.Button();
            this.websiteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTrackBar)).BeginInit();
            this.sliderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.searchButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(990, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(350, 150);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search For Fighters";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            // searchTextBox
            // 
            this.searchTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Austrian Empire*",
            "Azerbaijan",
            "B",
            "Baden*",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Bavaria*",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin (Dahomey)",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Brunswick and Lüneburg",
            "Bulgaria",
            "Burkina Faso (Upper Volta)",
            "Burma",
            "Burundi",
            "C",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cayman Islands, The",
            "Central African Republic",
            "Central American Federation*",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo Free State, The",
            "Costa Rica",
            "Cote d’Ivoire (Ivory Coast)",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia",
            "Czechoslovakia",
            "D",
            "Democratic Republic of the Congo",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Duchy of Parma, The*",
            "E",
            "East Germany (German Democratic Republic)*",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "England",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "F",
            "Federal Government of Germany (1848-49)*",
            "Fiji",
            "Finland",
            "France",
            "G",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Grand Duchy of Tuscany, The*",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "H",
            "Haiti",
            "Hanover*",
            "Hanseatic Republics*",
            "Hawaii*",
            "Hesse*",
            "Holy See",
            "Honduras",
            "Hungary",
            "I",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "J",
            "Jamaica",
            "Japan",
            "Jordan",
            "K",
            "Kazakhstan",
            "Kenya",
            "Kingdom of Serbia/Yugoslavia*",
            "Kiribati",
            "Korea",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "L",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Lew Chew (Loochoo)*",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mecklenburg-Schwerin*",
            "Mecklenburg-Strelitz*",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "N",
            "Namibia",
            "Nassau*",
            "Nauru",
            "Nepal",
            "Netherlands, The",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North German Confederation*",
            "North German Union*",
            "North Macedonia",
            "Northern Ireland",
            "Norway",
            "O",
            "Oldenburg*",
            "Oman",
            "Orange Free State*",
            "P",
            "Pakistan",
            "Palau",
            "Panama",
            "Papal States*",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Piedmont-Sardinia*",
            "Poland",
            "Portugal",
            "Q",
            "Qatar",
            "R",
            "Republic of Genoa*",
            "Republic of Korea (South Korea)",
            "Republic of the Congo",
            "Romania",
            "Russia",
            "Rwanda",
            "S",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Schaumburg-Lippe",
            "Scotland",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands, The",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "T",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Two Sicilies",
            "U",
            "Uganda",
            "Ukraine",
            "United Arab Emirates, The",
            "United Kingdom, The",
            "United States of America, The",
            "Uruguay",
            "Uzbekistan",
            "V",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "W",
            "Wales",
            "Y",
            "Yemen",
            "Z",
            "Zambia",
            "Zimbabwe"});
            this.searchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchTextBox.Location = new System.Drawing.Point(213, 85);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(316, 31);
            this.searchTextBox.TabIndex = 3;
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
            // searchCategoryLabel
            // 
            this.searchCategoryLabel.AutoSize = true;
            this.searchCategoryLabel.Location = new System.Drawing.Point(6, 30);
            this.searchCategoryLabel.Name = "searchCategoryLabel";
            this.searchCategoryLabel.Size = new System.Drawing.Size(201, 25);
            this.searchCategoryLabel.TabIndex = 5;
            this.searchCategoryLabel.Text = "Select a search category";
            // 
            // searchQueryLabel
            // 
            this.searchQueryLabel.AutoSize = true;
            this.searchQueryLabel.Location = new System.Drawing.Point(39, 85);
            this.searchQueryLabel.Name = "searchQueryLabel";
            this.searchQueryLabel.Size = new System.Drawing.Size(143, 25);
            this.searchQueryLabel.TabIndex = 6;
            this.searchQueryLabel.Text = "Enter your query";
            // 
            // minTrackBar
            // 
            this.minTrackBar.Location = new System.Drawing.Point(109, 12);
            this.minTrackBar.Maximum = 100;
            this.minTrackBar.Name = "minTrackBar";
            this.minTrackBar.Size = new System.Drawing.Size(156, 69);
            this.minTrackBar.TabIndex = 7;
            this.minTrackBar.Value = 50;
            this.minTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
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
            this.sliderPanel.Controls.Add(this.maxTrackBar);
            this.sliderPanel.Controls.Add(this.maxValueLabel);
            this.sliderPanel.Controls.Add(this.maxLabel);
            this.sliderPanel.Controls.Add(this.minLabel);
            this.sliderPanel.Controls.Add(this.minValueLabel);
            this.sliderPanel.Controls.Add(this.minTrackBar);
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
            // maxTrackBar
            // 
            this.maxTrackBar.Location = new System.Drawing.Point(109, 72);
            this.maxTrackBar.Maximum = 100;
            this.maxTrackBar.Name = "maxTrackBar";
            this.maxTrackBar.Size = new System.Drawing.Size(156, 69);
            this.maxTrackBar.TabIndex = 12;
            this.maxTrackBar.Value = 50;
            this.maxTrackBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
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
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.searchQueryLabel);
            this.panel2.Controls.Add(this.searchCategoryLabel);
            this.panel2.Location = new System.Drawing.Point(23, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 159);
            this.panel2.TabIndex = 11;
            // 
            // searchAllButton
            // 
            this.searchAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.searchAllButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchAllButton.ForeColor = System.Drawing.Color.White;
            this.searchAllButton.Location = new System.Drawing.Point(1393, 14);
            this.searchAllButton.Name = "searchAllButton";
            this.searchAllButton.Size = new System.Drawing.Size(350, 150);
            this.searchAllButton.TabIndex = 0;
            this.searchAllButton.Text = "Show All Fighters";
            this.searchAllButton.UseVisualStyleBackColor = false;
            this.searchAllButton.Click += new System.EventHandler(this.searchAllButton_Click);
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
            // websiteButton
            // 
            this.websiteButton.BackColor = System.Drawing.Color.Red;
            this.websiteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.websiteButton.ForeColor = System.Drawing.Color.Yellow;
            this.websiteButton.Location = new System.Drawing.Point(452, 603);
            this.websiteButton.Name = "websiteButton";
            this.websiteButton.Size = new System.Drawing.Size(197, 67);
            this.websiteButton.TabIndex = 12;
            this.websiteButton.Text = "Go To Website";
            this.websiteButton.UseVisualStyleBackColor = false;
            this.websiteButton.Click += new System.EventHandler(this.websiteButton_Click);
            // 
            // SearchForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 732);
            this.Controls.Add(this.websiteButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sliderPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchAllButton);
            this.Controls.Add(this.deleteFighterButton);
            this.Controls.Add(this.editFighterButton);
            this.Controls.Add(this.addFighterButton);
            this.Controls.Add(this.searchButton);
            this.Name = "SearchForm";
            this.Text = "UFC Database App";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTrackBar)).EndInit();
            this.sliderPanel.ResumeLayout(false);
            this.sliderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTrackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label searchCategoryLabel;
        private System.Windows.Forms.Label searchQueryLabel;
        private System.Windows.Forms.TrackBar minTrackBar;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label minValueLabel;
        private System.Windows.Forms.Panel sliderPanel;
        private System.Windows.Forms.TrackBar maxTrackBar;
        private System.Windows.Forms.Label maxValueLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label sliderCategoryLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchAllButton;
        private System.Windows.Forms.Button addFighterButton;
        private System.Windows.Forms.Button editFighterButton;
        private System.Windows.Forms.Button deleteFighterButton;
        private System.Windows.Forms.Button websiteButton;
    }
}

