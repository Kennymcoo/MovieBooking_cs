using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Views
{
    public partial class DashboardView : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public DashboardView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void button_manageMovies_Click(object sender, EventArgs e)
        {
            ManageMovieView manageMovieView = new ManageMovieView(_unitOfWork);
            manageMovieView.ShowDialog();
        }
    }
}
