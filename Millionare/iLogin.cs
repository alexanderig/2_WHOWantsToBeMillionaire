using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionare
{
    public interface ILoginView
    {
        string UserName { set; get; }
        string Password { set; get; }

        event EventHandler<EventArgs> Login;

        void LetUserLogin();
        void DontLetUserLogin();
    }
}
