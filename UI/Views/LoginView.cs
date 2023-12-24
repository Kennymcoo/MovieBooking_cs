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
    public partial class LoginView : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoginView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void button_logIn_Click(object sender, EventArgs e)
        {
            DashboardView dashboardView = new DashboardView(_unitOfWork);
            dashboardView.Show();
            this.Hide();        
            dashboardView.FormClosed += new FormClosedEventHandler(LoginViewClose);
        }

        private void LoginViewClose(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
