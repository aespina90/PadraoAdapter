using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class RelogioDoSistema : Relogio
    {

        public String hoje() {

            return DateTime.Today.ToString();
        } 
    }
}
