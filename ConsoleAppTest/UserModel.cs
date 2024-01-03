using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public class UserModel
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public int Height { get; set; }
        public int Age { get; set; }
    }
}
