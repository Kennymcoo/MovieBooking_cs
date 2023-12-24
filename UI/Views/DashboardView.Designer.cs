namespace UI.Views
{
    partial class DashboardView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_bookSeat = new System.Windows.Forms.Button();
            this.button_manageMovies = new System.Windows.Forms.Button();
            this.button_manageEmployee = new System.Windows.Forms.Button();
            this.button_viewHistory = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            this.comboBox_time = new System.Windows.Forms.ComboBox();
            this.comboBox_movies = new System.Windows.Forms.ComboBox();
            this.label_film = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.dateTimePicker_movie = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 543);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_bookSeat);
            this.panel1.Controls.Add(this.button_manageMovies);
            this.panel1.Controls.Add(this.button_manageEmployee);
            this.panel1.Controls.Add(this.button_viewHistory);
            this.panel1.Controls.Add(this.label_time);
            this.panel1.Controls.Add(this.comboBox_time);
            this.panel1.Controls.Add(this.comboBox_movies);
            this.panel1.Controls.Add(this.label_film);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.dateTimePicker_movie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 537);
            this.panel1.TabIndex = 0;
            // 
            // button_bookSeat
            // 
            this.button_bookSeat.Location = new System.Drawing.Point(19, 407);
            this.button_bookSeat.Name = "button_bookSeat";
            this.button_bookSeat.Size = new System.Drawing.Size(149, 29);
            this.button_bookSeat.TabIndex = 9;
            this.button_bookSeat.Text = "Book Seat";
            this.button_bookSeat.UseVisualStyleBackColor = true;
            // 
            // button_manageMovies
            // 
            this.button_manageMovies.Location = new System.Drawing.Point(19, 452);
            this.button_manageMovies.Name = "button_manageMovies";
            this.button_manageMovies.Size = new System.Drawing.Size(149, 29);
            this.button_manageMovies.TabIndex = 8;
            this.button_manageMovies.Text = "Manage Movies";
            this.button_manageMovies.UseVisualStyleBackColor = true;
            this.button_manageMovies.Click += new System.EventHandler(this.button_manageMovies_Click);
            // 
            // button_manageEmployee
            // 
            this.button_manageEmployee.Location = new System.Drawing.Point(19, 499);
            this.button_manageEmployee.Name = "button_manageEmployee";
            this.button_manageEmployee.Size = new System.Drawing.Size(149, 29);
            this.button_manageEmployee.TabIndex = 7;
            this.button_manageEmployee.Text = "Manage Employee";
            this.button_manageEmployee.UseVisualStyleBackColor = true;
            // 
            // button_viewHistory
            // 
            this.button_viewHistory.Location = new System.Drawing.Point(19, 363);
            this.button_viewHistory.Name = "button_viewHistory";
            this.button_viewHistory.Size = new System.Drawing.Size(149, 29);
            this.button_viewHistory.TabIndex = 6;
            this.button_viewHistory.Text = "View History";
            this.button_viewHistory.UseVisualStyleBackColor = true;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(78, 231);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(33, 15);
            this.label_time.TabIndex = 5;
            this.label_time.Text = "Time";
            // 
            // comboBox_time
            // 
            this.comboBox_time.FormattingEnabled = true;
            this.comboBox_time.Location = new System.Drawing.Point(19, 267);
            this.comboBox_time.Name = "comboBox_time";
            this.comboBox_time.Size = new System.Drawing.Size(149, 23);
            this.comboBox_time.TabIndex = 4;
            // 
            // comboBox_movies
            // 
            this.comboBox_movies.FormattingEnabled = true;
            this.comboBox_movies.Location = new System.Drawing.Point(19, 165);
            this.comboBox_movies.Name = "comboBox_movies";
            this.comboBox_movies.Size = new System.Drawing.Size(149, 23);
            this.comboBox_movies.TabIndex = 3;
            // 
            // label_film
            // 
            this.label_film.AutoSize = true;
            this.label_film.Location = new System.Drawing.Point(78, 130);
            this.label_film.Name = "label_film";
            this.label_film.Size = new System.Drawing.Size(40, 15);
            this.label_film.TabIndex = 2;
            this.label_film.Text = "Movie";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(78, 33);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(31, 15);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "Date";
            // 
            // dateTimePicker_movie
            // 
            this.dateTimePicker_movie.Location = new System.Drawing.Point(19, 61);
            this.dateTimePicker_movie.Name = "dateTimePicker_movie";
            this.dateTimePicker_movie.Size = new System.Drawing.Size(149, 23);
            this.dateTimePicker_movie.TabIndex = 0;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 543);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DashboardView";
            this.Text = "DashboardView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button button_bookSeat;
        private Button button_manageMovies;
        private Button button_manageEmployee;
        private Button button_viewHistory;
        private Label label_time;
        private ComboBox comboBox_time;
        private ComboBox comboBox_movies;
        private Label label_film;
        private Label label_date;
        private DateTimePicker dateTimePicker_movie;
    }
}