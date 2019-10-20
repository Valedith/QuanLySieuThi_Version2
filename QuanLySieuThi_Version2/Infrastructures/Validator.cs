using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi_Version2.Infrastructures
{
    class Validator
    {
        Dictionary<Tuple<string, string>, Control> controlDictionary = new Dictionary<Tuple<string, string>, Control>();

        public void AddControlDictionary(string modelName, string propertyName, Control control)
        {
            controlDictionary.Add(new Tuple<string, string>(modelName, propertyName), control);
        }

        private Control GetErrorControl(string modelName, string propertyName)
        {
            return controlDictionary[new Tuple<string, string>(modelName, propertyName)];
        }

        public void DisplayModelValidationErrorsAndFocus(Type type)
        {
            foreach (var error in ModelState.ErrorMessages)
                MessageBox.Show(error, "Error"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
            GetErrorControl(type.Name, ModelState.ErrorPropertyName).Focus();
        }

        public static bool IsPhoneNumber(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return true;
            }
            if (input.Length > 11)
            {
                return false;
            }
            const string pattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{3}";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.Match(input).Success;
        }
    }
}
