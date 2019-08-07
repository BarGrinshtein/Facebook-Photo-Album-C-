using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    interface IVisibaleControl 
    {
        void SetLocation(int i_left, int i_top);
        void SetSize(int i_width, int i_height);
        void SetAtherComponents();
        void Invoke(Delegate T);
    }
}
