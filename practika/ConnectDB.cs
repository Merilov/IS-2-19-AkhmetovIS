using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika
{
    class ConnectDB
    {
        public string Connstring = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";
        public string GetConne()
        {
            return Connstring;
        }
    }
}
