using MiniFootBall_App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniFootBall_App.Page
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginUser user = new loginUser
            {
                Email = textBoxEmail.Text,
                Password = textBoxPassword.Text
            };
           var result= Model_Validation.Validate(user);
            if (result.Item1)
            {
                User currentUser = null;
                using (MiniFootballContext db=new MiniFootballContext())
                {
                     currentUser = db.Players.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();

                }
                if (currentUser!=null)
                {
                    if (currentUser.Status==Status.Admin)
                    {
                        new AdminPage().ShowDialog();
                    }
                    else
                    {
                        new UserPage().ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
        }
    }
}
