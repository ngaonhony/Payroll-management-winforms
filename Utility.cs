using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTL.Models;
using System.Windows.Forms;
namespace QLTL
{
    public static class Utility
    {
        static public string ImagePath =Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Images\Nhanviens\";
 static public bool IsOpeningForm(string formname)
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name == formname)
                    return true;
            return false;
        }
        static internal USER user;
    }
}