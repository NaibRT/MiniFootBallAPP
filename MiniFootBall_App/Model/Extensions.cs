using MiniFootBall_App.Page;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootBall_App.Model
{
   public static class Extensions
    {
        public static void Addfile(this Register form,string imgPath)
        {
            var PATH = Path.Combine(@"C:/Users\naibrt/source\repos/MiniFootBall_App/MiniFootBall_App/img", Path.GetFileName(imgPath));
            File.Copy(imgPath, PATH);
        }
    }
}
