using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Eto
{
    [Serializable]
    public class NewStudentUserEto
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
