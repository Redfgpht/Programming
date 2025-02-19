using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using Programming_2s_2.Model.Enums;


namespace Programming_2s_2
{
    public partial class MainForm : Form

    {

        private Model.Rectangle[] _rectangles = new Model.Rectangle[5];
        private Model.Rectangle _currentRectangle;
        private Model.Film[] _movies = new Model.Film[5];
        private Model.Film _currentMovie;
        private Model.Ring[] _rings = new Model.Ring[5];

        public MainForm()
        {
            
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Rectangle(
                    new Random().NextDouble() * 100, 
                    new Random().NextDouble() * 100, 
                    "Purple", 
                    new Model.Point2D(new Random().NextDouble() * 100,
                    new Random().NextDouble() * 100));
            }
            for (int i = 0; i < 5; i++)
            {
                _rings[i] = new Model.Ring(
                    new Model.Point2D(new Random().NextDouble() * 100, new Random().NextDouble() * 100),
                    new Random().NextDouble() * 250,
                    new Random().NextDouble() * 10,
                    0);
            }
            setUpMovies();
        }

        public void setUpMovies()
        {
            _movies[0] = new Model.Film("Crew", 138, 2016, Model.Enums.Genre.Thriller, 7.8);
            _movies[1] = new Model.Film("2012", 158, 2009, Model.Enums.Genre.Action, 6.9);
            _movies[2] = new Model.Film("Home alone", 138, 1990, Model.Enums.Genre.Comedy, 8.3);
            _movies[3] = new Model.Film("The Gentlemen", 113, 2019, Model.Enums.Genre.Action, 9);
            _movies[4] = new Model.Film("Drive", 100, 2011, Model.Enums.Genre.Drama, 7.3);
        }

        public void HeightChanged()
        {
            try
            {
                LengthRectangle.BackColor = ColorTranslator.FromHtml("#ffffff");
                _currentRectangle.setHeight(Double.Parse(LengthRectangle.Text));
            }
            catch (Exception ex)
            {
                LengthRectangle.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }
        public void WidthChanged()
        {
            try
            {
                WidthRectangle.BackColor = ColorTranslator.FromHtml("#ffffff");
                _currentRectangle.setWidth(Double.Parse(WidthRectangle.Text));
            }
            catch (Exception ex)
            {
                WidthRectangle.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }
        public void colorChanged()
        {
            try
            {
                ColorRectangle.BackColor = ColorTranslator.FromHtml("#ffffff");
                _currentRectangle.setColor(ColorRectangle.Text);
            }
            catch (Exception ex)
            {
                ColorRectangle.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        public void duration_TextChanged()
        {
            try
            {
                DurationFilmTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                _currentMovie.setDuration(int.Parse(DurationFilmTextBox.Text));
            }
            catch (Exception ex)
            {
                DurationFilmTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1"); ;
            }
        }

        public void year_TextChanged()
        {
            try
            {
                YearRealiseTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                _currentMovie.setYearOfRelease(int.Parse(YearRealiseTextBox.Text));
            }
            catch (Exception ex)
            {
                YearRealiseTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        public void raiting_TextChanged()
        {
            try
            {
                RatingFilmTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                _currentMovie.setRating(double.Parse(RatingFilmTextBox.Text));
            }
            catch (Exception ex)
            {
                RatingFilmTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        private int findRectangleWithMaxWidth(Model.Rectangle[] rectangles)
        {
            double max = 0;
            int index = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].getWidth() > max)
                {
                    max = rectangles[i].getWidth();
                    index = i;
                }
            }
            return index;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ListBoxItem = EnumsListBox.SelectedItem.ToString();
            ValuesListBox.Items.Clear();

            if (ListBoxItem == "Color")
                foreach (string i in Enum.GetNames(typeof(Programming_2s_2.Model.Enums.Color)))
                    ValuesListBox.Items.Add(i.ToString());

            if (ListBoxItem == "Form_education")
                foreach (string i in Enum.GetNames(typeof(Form_education)))
                    ValuesListBox.Items.Add(i.ToString());

            if (ListBoxItem == "Genre")
                foreach (string i in Enum.GetNames(typeof(Genre)))
                    ValuesListBox.Items.Add(i.ToString());

            if (ListBoxItem == "Season")
                foreach (string i in Enum.GetNames(typeof(Season)))
                    ValuesListBox.Items.Add(i.ToString());

            if (ListBoxItem == "Smartphone_manufacturers")
                foreach (string i in Enum.GetNames(typeof(Smartphone_manufacturers)))
                    ValuesListBox.Items.Add(i.ToString());

            if (ListBoxItem == "Weekday")
                foreach (string i in Enum.GetNames(typeof(Weekday)))
                    ValuesListBox.Items.Add(i.ToString());

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ListBoxItem = EnumsListBox.SelectedItem.ToString();
            textBox1.Text = "";
            string ValuesListBoxItem = ValuesListBox.SelectedItem.ToString();

            if (ListBoxItem == "Color")
                foreach (string i in Enum.GetNames(typeof(Programming_2s_2.Model.Enums.Color)))
                    textBox1.Text = Convert.ToInt32(Enum.Parse(typeof(Programming_2s_2.Model.Enums.Color), ValuesListBoxItem)).ToString();

            if (ListBoxItem == "Form_education")
                foreach (string i in Enum.GetNames(typeof(Form_education)))
                    textBox1.Text = Convert.ToInt32(Enum.Parse(typeof(Form_education), ValuesListBoxItem)).ToString();

            if (ListBoxItem == "Genre")
                foreach (string i in Enum.GetNames(typeof(Genre)))
                    textBox1.Text = Convert.ToInt32(Enum.Parse(typeof(Genre), ValuesListBoxItem)).ToString();

            if (ListBoxItem == "Season")
                foreach (string i in Enum.GetNames(typeof(Season)))
                    textBox1.Text = Convert.ToInt32(Enum.Parse(typeof(Season), ValuesListBoxItem)).ToString();

            if (ListBoxItem == "Smartphone_manufacturers")
                foreach (string i in Enum.GetNames(typeof(Smartphone_manufacturers)))
                    textBox1.Text = Convert.ToInt32(Enum.Parse(typeof(Smartphone_manufacturers), ValuesListBoxItem)).ToString();

            if (ListBoxItem == "Weekday")
                foreach (string i in Enum.GetNames(typeof(Weekday)))
                    textBox1.Text = Convert.ToInt32(Enum.Parse(typeof(Weekday), ValuesListBoxItem)).ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TextWeekday = textBox2.Text;
            foreach (string i in Enum.GetNames(typeof(Weekday)))
                if (TextWeekday == i)
                {
                    LabelWeekday.Text = $"Это день недели ({TextWeekday} = {(Convert.ToInt32(Enum.Parse(typeof(Weekday), TextWeekday)) + 1).ToString()})";
                }
            if (LabelWeekday.Text == "")
            {
                LabelWeekday.Text = "Нет такого дня недели";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeasonBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            string Season = SeasonBox.Text;
            tabPage1.BackColor = ColorTranslator.FromHtml("#ffffff");
            switch (Season)
            {
                case var value when value == "Autumn":
                    tabPage1.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case var value when value == "Spring":
                    tabPage1.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case var value when value == "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case var value when value == "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
            }
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void Rectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[Rectangles.SelectedIndex];
            LengthRectangle.Text = _currentRectangle.getHeight().ToString();
            WidthRectangle.Text = _currentRectangle.getWidth().ToString();
            ColorRectangle.Text = _currentRectangle.getColor();
            Point2DRectangleTextBox.Text = _currentRectangle.getCenter().toString();
            IdRectangle.Text = _currentRectangle.id().ToString();
        }

        private void LengthRectangle_TextChanged(object sender, EventArgs e)
        {
            HeightChanged();
        }

        private void WidthRectangle_TextChanged(object sender, EventArgs e)
        {
            WidthChanged();
        }

        private void ColorRectangle_TextChanged(object sender, EventArgs e)
        {
            colorChanged();
        }

        private void ButtonFindRectangle_Click(object sender, EventArgs e)
        {
            Rectangles.SelectedIndex = findRectangleWithMaxWidth(_rectangles);
        }

        private void IdRectangle_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameFilmTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DurationFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            duration_TextChanged();
        }

        private void YearRealiseTextBox_TextChanged(object sender, EventArgs e)
        {
            year_TextChanged();
        }

        private void GenreFilmTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RatingFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            raiting_TextChanged();
        }

        private void Films_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[Films.SelectedIndex];
            NameFilmTextBox.Text = _currentMovie.getName();
            DurationFilmTextBox.Text = _currentMovie.getDuration().ToString();
            YearRealiseTextBox.Text = _currentMovie.getYearOfRelease().ToString();
            GenreFilmTextBox.Text = _currentMovie.getGenre().ToString();
            RatingFilmTextBox.Text = _currentMovie.getRating().ToString();
        }

        private void MaxRatingFilmTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private string findFilmWithMaxRating(Model.Film[] movies)
        {
            double max = 0;
            int index = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].getRating() > max)
                {
                    max = movies[i].getRating();
                    index = i;
                }
            }
            return index.ToString();
        }

        private void FindMaxRatingFilm_Click(object sender, EventArgs e)
        {
            MaxRatingFilmTextBox.Text = findFilmWithMaxRating(_movies);
        }

        private void Point2DRectangleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
