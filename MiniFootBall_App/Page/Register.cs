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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public string file_txt { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result==DialogResult.OK)
            {
                file_txt = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(file_txt);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                Name = NametextBox.Text,
                Surname = SurnametextBox.Text,
                Age = Convert.ToInt16(AgetextBox.Text),
                Email = EmailtextBox.Text,
                Password = PasswordtextBox.Text,
                File = file_txt,
                Status=Status.Player

            };
           var ValidatedModel= Model_Validation.Validate(newUser);
            if (ValidatedModel.Item1)
            {
                using (MiniFootballContext db=new MiniFootballContext())
                {
                    db.Players.Add(newUser);
                    db.SaveChanges();

                }
            }
            else
            {
                foreach (var item in ValidatedModel.Item2)
                {
                    if (item.ErrorMessage.Contains("Name"))
                    {
                        NameValidlabel7.Text = item.ErrorMessage;
                    }
                    if (item.ErrorMessage.Contains("Surname"))
                    {
                        SurnameValidlabel.Text = item.ErrorMessage;
                    }
                    if (item.ErrorMessage.Contains("Age"))
                    {
                        AgeValidlabel.Text = item.ErrorMessage;
                    }
                    if (item.ErrorMessage.Contains("Email"))
                    {
                        EmailValidlabel.Text = item.ErrorMessage;
                    }
                    if (item.ErrorMessage.Contains("Passsword"))
                    {
                        PasswordValidlabel.Text = item.ErrorMessage;
                    }
                    if (item.ErrorMessage.Contains("File"))
                    {
                        filelabel7.Text = item.ErrorMessage;
                    }
                }
            }
        }


    }
}
