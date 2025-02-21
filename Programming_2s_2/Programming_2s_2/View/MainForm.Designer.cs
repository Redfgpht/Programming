namespace Programming_2s_2
{
    partial class MainForm
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
            Enums = new TabControl();
            tabPage1 = new TabPage();
            SeasonButton = new Button();
            SeasonBox = new ComboBox();
            LabelWeekday = new Label();
            Parse_button = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabPage2 = new TabPage();
            Point2DRectangleTextBox = new TextBox();
            IdRectangle = new TextBox();
            ButtonFindRectangle = new Button();
            ColorRectangle = new TextBox();
            WidthRectangle = new TextBox();
            LengthRectangle = new TextBox();
            Rectangles = new ListBox();
            tabPage3 = new TabPage();
            FindMaxRatingFilm = new Button();
            MaxRatingFilmTextBox = new TextBox();
            Films = new ListBox();
            RatingFilmTextBox = new TextBox();
            GenreFilmTextBox = new TextBox();
            YearRealiseTextBox = new TextBox();
            DurationFilmTextBox = new TextBox();
            NameFilmTextBox = new TextBox();
            tabPage4 = new TabPage();
            RectanglePanel = new Panel();
            RectangleIDTextBoxPanel = new TextBox();
            RectangleXTextBoxPanel = new TextBox();
            RectangleYTextBoxPanel = new TextBox();
            RectangleWidthTextBoxPanel = new TextBox();
            RectangleLengthTextBoxPanel = new TextBox();
            AddRectanglePanelButton = new Button();
            DeleteRectanglePanelButton = new Button();
            RectanglePanelListBox = new ListBox();
            Enums.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // Enums
            // 
            Enums.Controls.Add(tabPage1);
            Enums.Controls.Add(tabPage2);
            Enums.Controls.Add(tabPage3);
            Enums.Controls.Add(tabPage4);
            Enums.Dock = DockStyle.Fill;
            Enums.Location = new Point(0, 0);
            Enums.Name = "Enums";
            Enums.SelectedIndex = 0;
            Enums.Size = new Size(800, 450);
            Enums.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SeasonButton);
            tabPage1.Controls.Add(SeasonBox);
            tabPage1.Controls.Add(LabelWeekday);
            tabPage1.Controls.Add(Parse_button);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(ValuesListBox);
            tabPage1.Controls.Add(EnumsListBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click_1;
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(563, 292);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(75, 23);
            SeasonButton.TabIndex = 8;
            SeasonButton.Text = "Go";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += SeasonButton_Click;
            // 
            // SeasonBox
            // 
            SeasonBox.FormattingEnabled = true;
            SeasonBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            SeasonBox.Location = new Point(426, 292);
            SeasonBox.Name = "SeasonBox";
            SeasonBox.Size = new Size(121, 23);
            SeasonBox.TabIndex = 6;
            SeasonBox.SelectedIndexChanged += SeasonBox_SelectedIndexChanged;
            // 
            // LabelWeekday
            // 
            LabelWeekday.AutoSize = true;
            LabelWeekday.Location = new Point(19, 340);
            LabelWeekday.Name = "LabelWeekday";
            LabelWeekday.Size = new Size(0, 15);
            LabelWeekday.TabIndex = 5;
            // 
            // Parse_button
            // 
            Parse_button.Location = new Point(191, 295);
            Parse_button.Name = "Parse_button";
            Parse_button.Size = new Size(75, 23);
            Parse_button.TabIndex = 4;
            Parse_button.Text = "Parse";
            Parse_button.UseVisualStyleBackColor = true;
            Parse_button.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 295);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(359, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(191, 23);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(162, 199);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Form_education", "Genre", "Season", "Smartphone_manufacturers", "Weekday" });
            EnumsListBox.Location = new Point(19, 23);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(158, 199);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Point2DRectangleTextBox);
            tabPage2.Controls.Add(IdRectangle);
            tabPage2.Controls.Add(ButtonFindRectangle);
            tabPage2.Controls.Add(ColorRectangle);
            tabPage2.Controls.Add(WidthRectangle);
            tabPage2.Controls.Add(LengthRectangle);
            tabPage2.Controls.Add(Rectangles);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Classes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Point2DRectangleTextBox
            // 
            Point2DRectangleTextBox.Location = new Point(349, 45);
            Point2DRectangleTextBox.Name = "Point2DRectangleTextBox";
            Point2DRectangleTextBox.ReadOnly = true;
            Point2DRectangleTextBox.Size = new Size(100, 23);
            Point2DRectangleTextBox.TabIndex = 6;
            Point2DRectangleTextBox.TextChanged += Point2DRectangleTextBox_TextChanged;
            // 
            // IdRectangle
            // 
            IdRectangle.Location = new Point(221, 167);
            IdRectangle.Name = "IdRectangle";
            IdRectangle.Size = new Size(100, 23);
            IdRectangle.TabIndex = 5;
            IdRectangle.TextChanged += IdRectangle_TextChanged;
            // 
            // ButtonFindRectangle
            // 
            ButtonFindRectangle.Location = new Point(221, 207);
            ButtonFindRectangle.Name = "ButtonFindRectangle";
            ButtonFindRectangle.Size = new Size(75, 23);
            ButtonFindRectangle.TabIndex = 4;
            ButtonFindRectangle.Text = "Find";
            ButtonFindRectangle.UseVisualStyleBackColor = true;
            ButtonFindRectangle.Click += ButtonFindRectangle_Click;
            // 
            // ColorRectangle
            // 
            ColorRectangle.Location = new Point(221, 125);
            ColorRectangle.Name = "ColorRectangle";
            ColorRectangle.Size = new Size(100, 23);
            ColorRectangle.TabIndex = 3;
            ColorRectangle.TextChanged += ColorRectangle_TextChanged;
            // 
            // WidthRectangle
            // 
            WidthRectangle.Location = new Point(221, 86);
            WidthRectangle.Name = "WidthRectangle";
            WidthRectangle.Size = new Size(100, 23);
            WidthRectangle.TabIndex = 2;
            WidthRectangle.TextChanged += WidthRectangle_TextChanged;
            // 
            // LengthRectangle
            // 
            LengthRectangle.Location = new Point(221, 45);
            LengthRectangle.Name = "LengthRectangle";
            LengthRectangle.Size = new Size(100, 23);
            LengthRectangle.TabIndex = 1;
            LengthRectangle.WordWrap = false;
            LengthRectangle.TextChanged += LengthRectangle_TextChanged;
            // 
            // Rectangles
            // 
            Rectangles.FormattingEnabled = true;
            Rectangles.ItemHeight = 15;
            Rectangles.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            Rectangles.Location = new Point(45, 45);
            Rectangles.Name = "Rectangles";
            Rectangles.Size = new Size(150, 154);
            Rectangles.TabIndex = 0;
            Rectangles.SelectedIndexChanged += Rectangles_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(FindMaxRatingFilm);
            tabPage3.Controls.Add(MaxRatingFilmTextBox);
            tabPage3.Controls.Add(Films);
            tabPage3.Controls.Add(RatingFilmTextBox);
            tabPage3.Controls.Add(GenreFilmTextBox);
            tabPage3.Controls.Add(YearRealiseTextBox);
            tabPage3.Controls.Add(DurationFilmTextBox);
            tabPage3.Controls.Add(NameFilmTextBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Films";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // FindMaxRatingFilm
            // 
            FindMaxRatingFilm.Location = new Point(379, 97);
            FindMaxRatingFilm.Name = "FindMaxRatingFilm";
            FindMaxRatingFilm.Size = new Size(75, 23);
            FindMaxRatingFilm.TabIndex = 7;
            FindMaxRatingFilm.Text = "Find";
            FindMaxRatingFilm.UseVisualStyleBackColor = true;
            FindMaxRatingFilm.Click += FindMaxRatingFilm_Click;
            // 
            // MaxRatingFilmTextBox
            // 
            MaxRatingFilmTextBox.Location = new Point(370, 55);
            MaxRatingFilmTextBox.Name = "MaxRatingFilmTextBox";
            MaxRatingFilmTextBox.Size = new Size(100, 23);
            MaxRatingFilmTextBox.TabIndex = 6;
            MaxRatingFilmTextBox.TextChanged += MaxRatingFilmTextBox_TextChanged;
            // 
            // Films
            // 
            Films.FormattingEnabled = true;
            Films.ItemHeight = 15;
            Films.Items.AddRange(new object[] { "\"Crew\"", "\"2012\"", "\"Home alone\"", "\"The Gentlemen\"", "\"Drive\"" });
            Films.Location = new Point(33, 55);
            Films.Name = "Films";
            Films.Size = new Size(162, 184);
            Films.TabIndex = 5;
            Films.SelectedIndexChanged += Films_SelectedIndexChanged;
            // 
            // RatingFilmTextBox
            // 
            RatingFilmTextBox.Location = new Point(231, 223);
            RatingFilmTextBox.Name = "RatingFilmTextBox";
            RatingFilmTextBox.Size = new Size(100, 23);
            RatingFilmTextBox.TabIndex = 4;
            RatingFilmTextBox.TextChanged += RatingFilmTextBox_TextChanged;
            // 
            // GenreFilmTextBox
            // 
            GenreFilmTextBox.Location = new Point(231, 181);
            GenreFilmTextBox.Name = "GenreFilmTextBox";
            GenreFilmTextBox.Size = new Size(100, 23);
            GenreFilmTextBox.TabIndex = 3;
            GenreFilmTextBox.TextChanged += GenreFilmTextBox_TextChanged;
            // 
            // YearRealiseTextBox
            // 
            YearRealiseTextBox.Location = new Point(231, 139);
            YearRealiseTextBox.Name = "YearRealiseTextBox";
            YearRealiseTextBox.Size = new Size(100, 23);
            YearRealiseTextBox.TabIndex = 2;
            YearRealiseTextBox.TextChanged += YearRealiseTextBox_TextChanged;
            // 
            // DurationFilmTextBox
            // 
            DurationFilmTextBox.Location = new Point(231, 97);
            DurationFilmTextBox.Name = "DurationFilmTextBox";
            DurationFilmTextBox.Size = new Size(100, 23);
            DurationFilmTextBox.TabIndex = 1;
            DurationFilmTextBox.TextChanged += DurationFilmTextBox_TextChanged;
            // 
            // NameFilmTextBox
            // 
            NameFilmTextBox.Location = new Point(231, 55);
            NameFilmTextBox.Name = "NameFilmTextBox";
            NameFilmTextBox.Size = new Size(100, 23);
            NameFilmTextBox.TabIndex = 0;
            NameFilmTextBox.TextChanged += NameFilmTextBox_TextChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(RectanglePanelListBox);
            tabPage4.Controls.Add(DeleteRectanglePanelButton);
            tabPage4.Controls.Add(AddRectanglePanelButton);
            tabPage4.Controls.Add(RectangleLengthTextBoxPanel);
            tabPage4.Controls.Add(RectangleWidthTextBoxPanel);
            tabPage4.Controls.Add(RectangleYTextBoxPanel);
            tabPage4.Controls.Add(RectangleXTextBoxPanel);
            tabPage4.Controls.Add(RectangleIDTextBoxPanel);
            tabPage4.Controls.Add(RectanglePanel);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Rectangles";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // RectanglePanel
            // 
            RectanglePanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglePanel.Location = new Point(335, 13);
            RectanglePanel.Name = "RectanglePanel";
            RectanglePanel.Size = new Size(449, 401);
            RectanglePanel.TabIndex = 0;
            RectanglePanel.Paint += RectanglePanel_Paint;
            // 
            // RectangleIDTextBoxPanel
            // 
            RectangleIDTextBoxPanel.Location = new Point(65, 207);
            RectangleIDTextBoxPanel.Name = "RectangleIDTextBoxPanel";
            RectangleIDTextBoxPanel.Size = new Size(157, 23);
            RectangleIDTextBoxPanel.TabIndex = 1;
            // 
            // RectangleXTextBoxPanel
            // 
            RectangleXTextBoxPanel.Location = new Point(65, 236);
            RectangleXTextBoxPanel.Name = "RectangleXTextBoxPanel";
            RectangleXTextBoxPanel.Size = new Size(157, 23);
            RectangleXTextBoxPanel.TabIndex = 2;
            // 
            // RectangleYTextBoxPanel
            // 
            RectangleYTextBoxPanel.Location = new Point(65, 265);
            RectangleYTextBoxPanel.Name = "RectangleYTextBoxPanel";
            RectangleYTextBoxPanel.Size = new Size(157, 23);
            RectangleYTextBoxPanel.TabIndex = 3;
            // 
            // RectangleWidthTextBoxPanel
            // 
            RectangleWidthTextBoxPanel.Location = new Point(65, 294);
            RectangleWidthTextBoxPanel.Name = "RectangleWidthTextBoxPanel";
            RectangleWidthTextBoxPanel.Size = new Size(157, 23);
            RectangleWidthTextBoxPanel.TabIndex = 4;
            // 
            // RectangleLengthTextBoxPanel
            // 
            RectangleLengthTextBoxPanel.Location = new Point(65, 323);
            RectangleLengthTextBoxPanel.Name = "RectangleLengthTextBoxPanel";
            RectangleLengthTextBoxPanel.Size = new Size(157, 23);
            RectangleLengthTextBoxPanel.TabIndex = 5;
            // 
            // AddRectanglePanelButton
            // 
            AddRectanglePanelButton.Location = new Point(16, 178);
            AddRectanglePanelButton.Name = "AddRectanglePanelButton";
            AddRectanglePanelButton.Size = new Size(75, 23);
            AddRectanglePanelButton.TabIndex = 6;
            AddRectanglePanelButton.Text = "Add";
            AddRectanglePanelButton.UseVisualStyleBackColor = true;
            // 
            // DeleteRectanglePanelButton
            // 
            DeleteRectanglePanelButton.Location = new Point(185, 178);
            DeleteRectanglePanelButton.Name = "DeleteRectanglePanelButton";
            DeleteRectanglePanelButton.Size = new Size(75, 23);
            DeleteRectanglePanelButton.TabIndex = 7;
            DeleteRectanglePanelButton.Text = "Delete";
            DeleteRectanglePanelButton.UseVisualStyleBackColor = true;
            // 
            // RectanglePanelListBox
            // 
            RectanglePanelListBox.FormattingEnabled = true;
            RectanglePanelListBox.ItemHeight = 15;
            RectanglePanelListBox.Location = new Point(16, 11);
            RectanglePanelListBox.Name = "RectanglePanelListBox";
            RectanglePanelListBox.Size = new Size(244, 139);
            RectanglePanelListBox.TabIndex = 8;
            RectanglePanelListBox.SelectedIndexChanged += RectanglePanelListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Enums);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            Enums.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Enums;
        private TabPage tabPage1;
        private ListBox EnumsListBox;
        private TextBox textBox1;
        private ListBox ValuesListBox;
        private Button Parse_button;
        private TextBox textBox2;
        private Label LabelWeekday;
        private ComboBox SeasonBox;
        private Button SeasonButton;
        private TabPage tabPage2;
        private TextBox LengthRectangle;
        private ListBox Rectangles;
        private Button ButtonFindRectangle;
        private TextBox ColorRectangle;
        private TextBox WidthRectangle;
        private TextBox IdRectangle;
        private TabPage tabPage3;
        private TextBox NameFilmTextBox;
        private TextBox YearRealiseTextBox;
        private TextBox DurationFilmTextBox;
        private ListBox Films;
        private TextBox RatingFilmTextBox;
        private TextBox GenreFilmTextBox;
        private Button FindMaxRatingFilm;
        private TextBox MaxRatingFilmTextBox;
        private TextBox Point2DRectangleTextBox;
        private TabPage tabPage4;
        private Panel RectanglePanel;
        private Button AddRectanglePanelButton;
        private TextBox RectangleLengthTextBoxPanel;
        private TextBox RectangleWidthTextBoxPanel;
        private TextBox RectangleYTextBoxPanel;
        private TextBox RectangleXTextBoxPanel;
        private TextBox RectangleIDTextBoxPanel;
        private ListBox RectanglePanelListBox;
        private Button DeleteRectanglePanelButton;
    }
}
