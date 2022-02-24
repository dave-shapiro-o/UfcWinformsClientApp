
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
            this.components = new System.ComponentModel.Container();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTrackBar)).BeginInit();
            this.sliderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.Fuchsia;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.Color.Purple;
            this.searchButton.Location = new System.Drawing.Point(783, 11);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(245, 110);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search For Fighters";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(16, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1273, 151);
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
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.searchTextBox.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.searchTextBox.Location = new System.Drawing.Point(240, 61);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(222, 26);
            this.searchTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.searchTextBox, "If you know the exact measurement enter it here \r\nOtherwise use the sliders to th" +
        "e right");
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Nickname",
            "Height",
            "Weight",
            "Country"});
            this.comboBox1.Location = new System.Drawing.Point(240, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchCategoryLabel
            // 
            this.searchCategoryLabel.AutoSize = true;
            this.searchCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchCategoryLabel.Location = new System.Drawing.Point(4, 18);
            this.searchCategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchCategoryLabel.Name = "searchCategoryLabel";
            this.searchCategoryLabel.Size = new System.Drawing.Size(208, 20);
            this.searchCategoryLabel.TabIndex = 5;
            this.searchCategoryLabel.Text = "Select a search category";
            // 
            // searchQueryLabel
            // 
            this.searchQueryLabel.AutoSize = true;
            this.searchQueryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchQueryLabel.Location = new System.Drawing.Point(27, 61);
            this.searchQueryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchQueryLabel.Name = "searchQueryLabel";
            this.searchQueryLabel.Size = new System.Drawing.Size(141, 20);
            this.searchQueryLabel.TabIndex = 6;
            this.searchQueryLabel.Text = "Enter your query";
            // 
            // minTrackBar
            // 
            this.minTrackBar.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.minTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minTrackBar.Location = new System.Drawing.Point(94, 2);
            this.minTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.minTrackBar.Maximum = 100;
            this.minTrackBar.Name = "minTrackBar";
            this.minTrackBar.Size = new System.Drawing.Size(109, 45);
            this.minTrackBar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.minTrackBar, "Slide to select a minimum");
            this.minTrackBar.Value = 50;
            this.minTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minLabel.Location = new System.Drawing.Point(2, 7);
            this.minLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(85, 17);
            this.minLabel.TabIndex = 8;
            this.minLabel.Text = "Min Height";
            // 
            // minValueLabel
            // 
            this.minValueLabel.AutoSize = true;
            this.minValueLabel.Location = new System.Drawing.Point(218, 7);
            this.minValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minValueLabel.Name = "minValueLabel";
            this.minValueLabel.Size = new System.Drawing.Size(29, 20);
            this.minValueLabel.TabIndex = 9;
            this.minValueLabel.Text = "50";
            // 
            // sliderPanel
            // 
            this.sliderPanel.BackColor = System.Drawing.Color.Fuchsia;
            this.sliderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sliderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sliderPanel.Controls.Add(this.sliderCategoryLabel);
            this.sliderPanel.Controls.Add(this.maxTrackBar);
            this.sliderPanel.Controls.Add(this.maxValueLabel);
            this.sliderPanel.Controls.Add(this.maxLabel);
            this.sliderPanel.Controls.Add(this.minLabel);
            this.sliderPanel.Controls.Add(this.minValueLabel);
            this.sliderPanel.Controls.Add(this.minTrackBar);
            this.sliderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sliderPanel.ForeColor = System.Drawing.Color.Purple;
            this.sliderPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sliderPanel.Location = new System.Drawing.Point(510, 11);
            this.sliderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sliderPanel.Name = "sliderPanel";
            this.sliderPanel.Size = new System.Drawing.Size(260, 110);
            this.sliderPanel.TabIndex = 10;
            this.sliderPanel.Visible = false;
            // 
            // sliderCategoryLabel
            // 
            this.sliderCategoryLabel.AutoSize = true;
            this.sliderCategoryLabel.Location = new System.Drawing.Point(65, 84);
            this.sliderCategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sliderCategoryLabel.Name = "sliderCategoryLabel";
            this.sliderCategoryLabel.Size = new System.Drawing.Size(0, 20);
            this.sliderCategoryLabel.TabIndex = 13;
            this.sliderCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxTrackBar
            // 
            this.maxTrackBar.Location = new System.Drawing.Point(94, 37);
            this.maxTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.maxTrackBar.Maximum = 100;
            this.maxTrackBar.Name = "maxTrackBar";
            this.maxTrackBar.Size = new System.Drawing.Size(109, 45);
            this.maxTrackBar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.maxTrackBar, "Slide to select maximum ");
            this.maxTrackBar.Value = 50;
            this.maxTrackBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // maxValueLabel
            // 
            this.maxValueLabel.AutoSize = true;
            this.maxValueLabel.Location = new System.Drawing.Point(218, 43);
            this.maxValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxValueLabel.Name = "maxValueLabel";
            this.maxValueLabel.Size = new System.Drawing.Size(29, 20);
            this.maxValueLabel.TabIndex = 11;
            this.maxValueLabel.Text = "50";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxLabel.Location = new System.Drawing.Point(2, 43);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(88, 17);
            this.maxLabel.TabIndex = 10;
            this.maxLabel.Text = "Max Height";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.searchQueryLabel);
            this.panel2.Controls.Add(this.searchCategoryLabel);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(16, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 108);
            this.panel2.TabIndex = 11;
            // 
            // searchAllButton
            // 
            this.searchAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchAllButton.BackColor = System.Drawing.Color.Fuchsia;
            this.searchAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchAllButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchAllButton.FlatAppearance.BorderSize = 10;
            this.searchAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchAllButton.ForeColor = System.Drawing.Color.Purple;
            this.searchAllButton.Location = new System.Drawing.Point(1044, 11);
            this.searchAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchAllButton.Name = "searchAllButton";
            this.searchAllButton.Size = new System.Drawing.Size(245, 110);
            this.searchAllButton.TabIndex = 0;
            this.searchAllButton.Text = "Show All Fighters";
            this.searchAllButton.UseVisualStyleBackColor = false;
            this.searchAllButton.Click += new System.EventHandler(this.searchAllButton_Click);
            // 
            // addFighterButton
            // 
            this.addFighterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addFighterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addFighterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addFighterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.addFighterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.addFighterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addFighterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addFighterButton.ForeColor = System.Drawing.Color.Purple;
            this.addFighterButton.Location = new System.Drawing.Point(510, 329);
            this.addFighterButton.Margin = new System.Windows.Forms.Padding(2);
            this.addFighterButton.Name = "addFighterButton";
            this.addFighterButton.Size = new System.Drawing.Size(260, 99);
            this.addFighterButton.TabIndex = 0;
            this.addFighterButton.Text = "Add Fighter";
            this.addFighterButton.UseVisualStyleBackColor = false;
            this.addFighterButton.Click += new System.EventHandler(this.addFighterButton_Click);
            // 
            // editFighterButton
            // 
            this.editFighterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editFighterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.editFighterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.editFighterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editFighterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editFighterButton.ForeColor = System.Drawing.Color.Purple;
            this.editFighterButton.Location = new System.Drawing.Point(783, 329);
            this.editFighterButton.Margin = new System.Windows.Forms.Padding(2);
            this.editFighterButton.Name = "editFighterButton";
            this.editFighterButton.Size = new System.Drawing.Size(245, 99);
            this.editFighterButton.TabIndex = 0;
            this.editFighterButton.Text = "Edit Fighter";
            this.editFighterButton.UseVisualStyleBackColor = false;
            this.editFighterButton.Click += new System.EventHandler(this.editFighterButton_Click);
            // 
            // deleteFighterButton
            // 
            this.deleteFighterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteFighterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteFighterButton.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.deleteFighterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteFighterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteFighterButton.ForeColor = System.Drawing.Color.Purple;
            this.deleteFighterButton.Location = new System.Drawing.Point(1044, 329);
            this.deleteFighterButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteFighterButton.Name = "deleteFighterButton";
            this.deleteFighterButton.Size = new System.Drawing.Size(245, 99);
            this.deleteFighterButton.TabIndex = 0;
            this.deleteFighterButton.Text = "Delete Fighter";
            this.deleteFighterButton.UseVisualStyleBackColor = false;
            this.deleteFighterButton.Click += new System.EventHandler(this.deleteFighterButton_Click);
            // 
            // websiteButton
            // 
            this.websiteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.websiteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.websiteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.websiteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.websiteButton.Location = new System.Drawing.Point(16, 329);
            this.websiteButton.Margin = new System.Windows.Forms.Padding(2);
            this.websiteButton.Name = "websiteButton";
            this.websiteButton.Size = new System.Drawing.Size(249, 99);
            this.websiteButton.TabIndex = 12;
            this.websiteButton.Text = "Go To Website";
            this.websiteButton.UseVisualStyleBackColor = false;
            this.websiteButton.Click += new System.EventHandler(this.websiteButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Active = false;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.toolTip1.IsBalloon = true;
            // 
            // countLabel
            // 
            this.countLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.countLabel.Location = new System.Drawing.Point(284, 369);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(146, 25);
            this.countLabel.TabIndex = 13;
            this.countLabel.Text = "Records Found";
            this.countLabel.Visible = false;
            // 
            // SearchForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1300, 439);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.websiteButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sliderPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchAllButton);
            this.Controls.Add(this.deleteFighterButton);
            this.Controls.Add(this.editFighterButton);
            this.Controls.Add(this.addFighterButton);
            this.Controls.Add(this.searchButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.PerformLayout();

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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label countLabel;
    }
}

