using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;


namespace seleniumTest.DataExcel
{
    public class TestCaseData
    {
        
        public string TestCaseKey { get; set; }
        public char Runmode { get; set; }
        public string Browser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public char Expectedresult { get; set; }
    }
}
