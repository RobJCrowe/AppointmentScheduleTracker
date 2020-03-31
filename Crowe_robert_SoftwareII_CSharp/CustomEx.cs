using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    class CustomEx : ApplicationException
    {
        public void NoUserException(string m, string t) { MessageBox.Show(m, t); }

        public void BadPasswordException(string m, string t) { MessageBox.Show(m, t); }

    }
    

}
