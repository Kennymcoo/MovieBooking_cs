namespace UI.Views
{
    partial class ManageMovieView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.listView_roomName = new System.Windows.Forms.ListView();
            this.button_saveRoomName = new System.Windows.Forms.Button();
            this.textBox_roomName = new System.Windows.Forms.TextBox();
            this.label_roomName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_deleteRoomDetail = new System.Windows.Forms.Button();
            this.button_editRoomDetail = new System.Windows.Forms.Button();
            this.button_saveRoomDeatil = new System.Windows.Forms.Button();
            this.listView_roomDetail = new System.Windows.Forms.ListView();
            this.comboBox_seletcRoomName = new System.Windows.Forms.ComboBox();
            this.comboBox_sessionTime = new System.Windows.Forms.ComboBox();
            this.label_selectSessionTime = new System.Windows.Forms.Label();
            this.textBox_columnName = new System.Windows.Forms.TextBox();
            this.label_columnIndexNumber = new System.Windows.Forms.Label();
            this.textBox_rowNumber = new System.Windows.Forms.TextBox();
            this.label_rowIndexNumber = new System.Windows.Forms.Label();
            this.label_roomNameDetail = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView_movies = new System.Windows.Forms.ListView();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.label_endDate = new System.Windows.Forms.Label();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.label_startDate = new System.Windows.Forms.Label();
            this.textBox_movieName = new System.Windows.Forms.TextBox();
            this.label_enterMovieName = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label_selectMovie = new System.Windows.Forms.Label();
            this.label_selectRoom = new System.Windows.Forms.Label();
            this.listView_movieSession = new System.Windows.Forms.ListView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox_selectRoom = new System.Windows.Forms.ComboBox();
            this.button_saveMovie = new System.Windows.Forms.Button();
            this.button_deleteMovie = new System.Windows.Forms.Button();
            this.button_editMovie = new System.Windows.Forms.Button();
            this.button_saveMovieSession = new System.Windows.Forms.Button();
            this.button_editMovieSession = new System.Windows.Forms.Button();
            this.button_deleteMovieSession = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 609);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_delete);
            this.tabPage1.Controls.Add(this.button_edit);
            this.tabPage1.Controls.Add(this.listView_roomName);
            this.tabPage1.Controls.Add(this.button_saveRoomName);
            this.tabPage1.Controls.Add(this.textBox_roomName);
            this.tabPage1.Controls.Add(this.label_roomName);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rooms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(837, 434);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(718, 434);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 4;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // listView_roomName
            // 
            this.listView_roomName.Location = new System.Drawing.Point(599, 74);
            this.listView_roomName.Name = "listView_roomName";
            this.listView_roomName.Size = new System.Drawing.Size(332, 337);
            this.listView_roomName.TabIndex = 3;
            this.listView_roomName.UseCompatibleStateImageBehavior = false;
            // 
            // button_saveRoomName
            // 
            this.button_saveRoomName.Location = new System.Drawing.Point(599, 434);
            this.button_saveRoomName.Name = "button_saveRoomName";
            this.button_saveRoomName.Size = new System.Drawing.Size(75, 23);
            this.button_saveRoomName.TabIndex = 2;
            this.button_saveRoomName.Text = "Save";
            this.button_saveRoomName.UseVisualStyleBackColor = true;
            // 
            // textBox_roomName
            // 
            this.textBox_roomName.Location = new System.Drawing.Point(70, 148);
            this.textBox_roomName.Name = "textBox_roomName";
            this.textBox_roomName.Size = new System.Drawing.Size(325, 23);
            this.textBox_roomName.TabIndex = 1;
            // 
            // label_roomName
            // 
            this.label_roomName.AutoSize = true;
            this.label_roomName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_roomName.Location = new System.Drawing.Point(70, 113);
            this.label_roomName.Name = "label_roomName";
            this.label_roomName.Size = new System.Drawing.Size(140, 18);
            this.label_roomName.TabIndex = 0;
            this.label_roomName.Text = "Enter room name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_deleteRoomDetail);
            this.tabPage2.Controls.Add(this.button_editRoomDetail);
            this.tabPage2.Controls.Add(this.button_saveRoomDeatil);
            this.tabPage2.Controls.Add(this.listView_roomDetail);
            this.tabPage2.Controls.Add(this.comboBox_seletcRoomName);
            this.tabPage2.Controls.Add(this.comboBox_sessionTime);
            this.tabPage2.Controls.Add(this.label_selectSessionTime);
            this.tabPage2.Controls.Add(this.textBox_columnName);
            this.tabPage2.Controls.Add(this.label_columnIndexNumber);
            this.tabPage2.Controls.Add(this.textBox_rowNumber);
            this.tabPage2.Controls.Add(this.label_rowIndexNumber);
            this.tabPage2.Controls.Add(this.label_roomNameDetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Room Detail";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_deleteRoomDetail
            // 
            this.button_deleteRoomDetail.Location = new System.Drawing.Point(843, 471);
            this.button_deleteRoomDetail.Name = "button_deleteRoomDetail";
            this.button_deleteRoomDetail.Size = new System.Drawing.Size(75, 23);
            this.button_deleteRoomDetail.TabIndex = 15;
            this.button_deleteRoomDetail.Text = "Delete";
            this.button_deleteRoomDetail.UseVisualStyleBackColor = true;
            // 
            // button_editRoomDetail
            // 
            this.button_editRoomDetail.Location = new System.Drawing.Point(697, 471);
            this.button_editRoomDetail.Name = "button_editRoomDetail";
            this.button_editRoomDetail.Size = new System.Drawing.Size(75, 23);
            this.button_editRoomDetail.TabIndex = 14;
            this.button_editRoomDetail.Text = "Edit";
            this.button_editRoomDetail.UseVisualStyleBackColor = true;
            // 
            // button_saveRoomDeatil
            // 
            this.button_saveRoomDeatil.Location = new System.Drawing.Point(539, 471);
            this.button_saveRoomDeatil.Name = "button_saveRoomDeatil";
            this.button_saveRoomDeatil.Size = new System.Drawing.Size(75, 23);
            this.button_saveRoomDeatil.TabIndex = 13;
            this.button_saveRoomDeatil.Text = "Save";
            this.button_saveRoomDeatil.UseVisualStyleBackColor = true;
            // 
            // listView_roomDetail
            // 
            this.listView_roomDetail.Location = new System.Drawing.Point(519, 60);
            this.listView_roomDetail.Name = "listView_roomDetail";
            this.listView_roomDetail.Size = new System.Drawing.Size(420, 390);
            this.listView_roomDetail.TabIndex = 12;
            this.listView_roomDetail.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox_seletcRoomName
            // 
            this.comboBox_seletcRoomName.FormattingEnabled = true;
            this.comboBox_seletcRoomName.Location = new System.Drawing.Point(72, 95);
            this.comboBox_seletcRoomName.Name = "comboBox_seletcRoomName";
            this.comboBox_seletcRoomName.Size = new System.Drawing.Size(251, 23);
            this.comboBox_seletcRoomName.TabIndex = 11;
            // 
            // comboBox_sessionTime
            // 
            this.comboBox_sessionTime.FormattingEnabled = true;
            this.comboBox_sessionTime.Location = new System.Drawing.Point(72, 403);
            this.comboBox_sessionTime.Name = "comboBox_sessionTime";
            this.comboBox_sessionTime.Size = new System.Drawing.Size(251, 23);
            this.comboBox_sessionTime.TabIndex = 9;
            // 
            // label_selectSessionTime
            // 
            this.label_selectSessionTime.AutoSize = true;
            this.label_selectSessionTime.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_selectSessionTime.Location = new System.Drawing.Point(72, 351);
            this.label_selectSessionTime.Name = "label_selectSessionTime";
            this.label_selectSessionTime.Size = new System.Drawing.Size(151, 18);
            this.label_selectSessionTime.TabIndex = 8;
            this.label_selectSessionTime.Text = "Select session time";
            // 
            // textBox_columnName
            // 
            this.textBox_columnName.Location = new System.Drawing.Point(72, 294);
            this.textBox_columnName.Name = "textBox_columnName";
            this.textBox_columnName.Size = new System.Drawing.Size(251, 23);
            this.textBox_columnName.TabIndex = 6;
            // 
            // label_columnIndexNumber
            // 
            this.label_columnIndexNumber.AutoSize = true;
            this.label_columnIndexNumber.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_columnIndexNumber.Location = new System.Drawing.Point(72, 247);
            this.label_columnIndexNumber.Name = "label_columnIndexNumber";
            this.label_columnIndexNumber.Size = new System.Drawing.Size(171, 18);
            this.label_columnIndexNumber.TabIndex = 4;
            this.label_columnIndexNumber.Text = "Enter Column number";
            // 
            // textBox_rowNumber
            // 
            this.textBox_rowNumber.Location = new System.Drawing.Point(72, 186);
            this.textBox_rowNumber.Name = "textBox_rowNumber";
            this.textBox_rowNumber.Size = new System.Drawing.Size(251, 23);
            this.textBox_rowNumber.TabIndex = 3;
            // 
            // label_rowIndexNumber
            // 
            this.label_rowIndexNumber.AutoSize = true;
            this.label_rowIndexNumber.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_rowIndexNumber.Location = new System.Drawing.Point(72, 148);
            this.label_rowIndexNumber.Name = "label_rowIndexNumber";
            this.label_rowIndexNumber.Size = new System.Drawing.Size(143, 18);
            this.label_rowIndexNumber.TabIndex = 2;
            this.label_rowIndexNumber.Text = "Enter row number";
            // 
            // label_roomNameDetail
            // 
            this.label_roomNameDetail.AutoSize = true;
            this.label_roomNameDetail.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_roomNameDetail.Location = new System.Drawing.Point(72, 60);
            this.label_roomNameDetail.Name = "label_roomNameDetail";
            this.label_roomNameDetail.Size = new System.Drawing.Size(102, 18);
            this.label_roomNameDetail.TabIndex = 0;
            this.label_roomNameDetail.Text = "Room Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_editMovie);
            this.tabPage3.Controls.Add(this.button_deleteMovie);
            this.tabPage3.Controls.Add(this.button_saveMovie);
            this.tabPage3.Controls.Add(this.listView_movies);
            this.tabPage3.Controls.Add(this.dateTimePicker_endDate);
            this.tabPage3.Controls.Add(this.label_endDate);
            this.tabPage3.Controls.Add(this.dateTimePicker_startDate);
            this.tabPage3.Controls.Add(this.label_startDate);
            this.tabPage3.Controls.Add(this.textBox_movieName);
            this.tabPage3.Controls.Add(this.label_enterMovieName);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(975, 581);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movies";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView_movies
            // 
            this.listView_movies.Location = new System.Drawing.Point(474, 63);
            this.listView_movies.Name = "listView_movies";
            this.listView_movies.Size = new System.Drawing.Size(401, 359);
            this.listView_movies.TabIndex = 9;
            this.listView_movies.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(69, 399);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(226, 23);
            this.dateTimePicker_endDate.TabIndex = 7;
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_endDate.Location = new System.Drawing.Point(69, 359);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(123, 18);
            this.label_endDate.TabIndex = 6;
            this.label_endDate.Text = "Select end date";
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(69, 239);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(226, 23);
            this.dateTimePicker_startDate.TabIndex = 4;
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_startDate.Location = new System.Drawing.Point(69, 202);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(131, 18);
            this.label_startDate.TabIndex = 3;
            this.label_startDate.Text = "Select start date";
            // 
            // textBox_movieName
            // 
            this.textBox_movieName.Location = new System.Drawing.Point(69, 109);
            this.textBox_movieName.Name = "textBox_movieName";
            this.textBox_movieName.Size = new System.Drawing.Size(226, 23);
            this.textBox_movieName.TabIndex = 1;
            // 
            // label_enterMovieName
            // 
            this.label_enterMovieName.AutoSize = true;
            this.label_enterMovieName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_enterMovieName.Location = new System.Drawing.Point(69, 63);
            this.label_enterMovieName.Name = "label_enterMovieName";
            this.label_enterMovieName.Size = new System.Drawing.Size(145, 18);
            this.label_enterMovieName.TabIndex = 0;
            this.label_enterMovieName.Text = "Enter movie name";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button_deleteMovieSession);
            this.tabPage4.Controls.Add(this.button_editMovieSession);
            this.tabPage4.Controls.Add(this.button_saveMovieSession);
            this.tabPage4.Controls.Add(this.label_selectMovie);
            this.tabPage4.Controls.Add(this.label_selectRoom);
            this.tabPage4.Controls.Add(this.listView_movieSession);
            this.tabPage4.Controls.Add(this.comboBox2);
            this.tabPage4.Controls.Add(this.comboBox_selectRoom);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(975, 581);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Movie Session";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label_selectMovie
            // 
            this.label_selectMovie.AutoSize = true;
            this.label_selectMovie.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_selectMovie.Location = new System.Drawing.Point(111, 275);
            this.label_selectMovie.Name = "label_selectMovie";
            this.label_selectMovie.Size = new System.Drawing.Size(104, 18);
            this.label_selectMovie.TabIndex = 4;
            this.label_selectMovie.Text = "Select movie";
            // 
            // label_selectRoom
            // 
            this.label_selectRoom.AutoSize = true;
            this.label_selectRoom.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_selectRoom.Location = new System.Drawing.Point(111, 84);
            this.label_selectRoom.Name = "label_selectRoom";
            this.label_selectRoom.Size = new System.Drawing.Size(99, 18);
            this.label_selectRoom.TabIndex = 3;
            this.label_selectRoom.Text = "Select room";
            // 
            // listView_movieSession
            // 
            this.listView_movieSession.Location = new System.Drawing.Point(482, 84);
            this.listView_movieSession.Name = "listView_movieSession";
            this.listView_movieSession.Size = new System.Drawing.Size(411, 329);
            this.listView_movieSession.TabIndex = 2;
            this.listView_movieSession.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 311);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(232, 23);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox_selectRoom
            // 
            this.comboBox_selectRoom.FormattingEnabled = true;
            this.comboBox_selectRoom.Location = new System.Drawing.Point(111, 116);
            this.comboBox_selectRoom.Name = "comboBox_selectRoom";
            this.comboBox_selectRoom.Size = new System.Drawing.Size(232, 23);
            this.comboBox_selectRoom.TabIndex = 0;
            // 
            // button_saveMovie
            // 
            this.button_saveMovie.Location = new System.Drawing.Point(474, 451);
            this.button_saveMovie.Name = "button_saveMovie";
            this.button_saveMovie.Size = new System.Drawing.Size(75, 23);
            this.button_saveMovie.TabIndex = 10;
            this.button_saveMovie.Text = "Save";
            this.button_saveMovie.UseVisualStyleBackColor = true;
            // 
            // button_deleteMovie
            // 
            this.button_deleteMovie.Location = new System.Drawing.Point(800, 451);
            this.button_deleteMovie.Name = "button_deleteMovie";
            this.button_deleteMovie.Size = new System.Drawing.Size(75, 23);
            this.button_deleteMovie.TabIndex = 11;
            this.button_deleteMovie.Text = "Delete";
            this.button_deleteMovie.UseVisualStyleBackColor = true;
            // 
            // button_editMovie
            // 
            this.button_editMovie.Location = new System.Drawing.Point(635, 451);
            this.button_editMovie.Name = "button_editMovie";
            this.button_editMovie.Size = new System.Drawing.Size(75, 23);
            this.button_editMovie.TabIndex = 12;
            this.button_editMovie.Text = "Edit";
            this.button_editMovie.UseVisualStyleBackColor = true;
            // 
            // button_saveMovieSession
            // 
            this.button_saveMovieSession.Location = new System.Drawing.Point(504, 446);
            this.button_saveMovieSession.Name = "button_saveMovieSession";
            this.button_saveMovieSession.Size = new System.Drawing.Size(75, 23);
            this.button_saveMovieSession.TabIndex = 5;
            this.button_saveMovieSession.Text = "Save";
            this.button_saveMovieSession.UseVisualStyleBackColor = true;
            // 
            // button_editMovieSession
            // 
            this.button_editMovieSession.Location = new System.Drawing.Point(652, 446);
            this.button_editMovieSession.Name = "button_editMovieSession";
            this.button_editMovieSession.Size = new System.Drawing.Size(75, 23);
            this.button_editMovieSession.TabIndex = 6;
            this.button_editMovieSession.Text = "Edit";
            this.button_editMovieSession.UseVisualStyleBackColor = true;
            // 
            // button_deleteMovieSession
            // 
            this.button_deleteMovieSession.Location = new System.Drawing.Point(798, 446);
            this.button_deleteMovieSession.Name = "button_deleteMovieSession";
            this.button_deleteMovieSession.Size = new System.Drawing.Size(75, 23);
            this.button_deleteMovieSession.TabIndex = 7;
            this.button_deleteMovieSession.Text = "Delete";
            this.button_deleteMovieSession.UseVisualStyleBackColor = true;
            // 
            // ManageMovieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 609);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManageMovieView";
            this.Text = "ManageMovieView";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox textBox_roomName;
        private Label label_roomName;
        private Button button_saveRoomName;
        private ComboBox comboBox_sessionTime;
        private Label label_selectSessionTime;
        private TextBox textBox_columnName;
        private Label label_columnIndexNumber;
        private TextBox textBox_rowNumber;
        private Label label_rowIndexNumber;
        private Label label_roomNameDetail;
        private DateTimePicker dateTimePicker_endDate;
        private Label label_endDate;
        private DateTimePicker dateTimePicker_startDate;
        private Label label_startDate;
        private TextBox textBox_movieName;
        private Label label_enterMovieName;
        private Button button_delete;
        private Button button_edit;
        private ListView listView_roomName;
        private ListView listView_movies;
        private Label label_selectMovie;
        private Label label_selectRoom;
        private ListView listView_movieSession;
        private ComboBox comboBox2;
        private ComboBox comboBox_selectRoom;
        private ComboBox comboBox_seletcRoomName;
        private Button button_deleteRoomDetail;
        private Button button_editRoomDetail;
        private Button button_saveRoomDeatil;
        private ListView listView_roomDetail;
        private Button button_editMovie;
        private Button button_deleteMovie;
        private Button button_saveMovie;
        private Button button_deleteMovieSession;
        private Button button_editMovieSession;
        private Button button_saveMovieSession;
    }
}