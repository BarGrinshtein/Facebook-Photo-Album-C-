using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    public class SortTools
    {
        public void CopyBackToControls(List<Control> i_List, Control.ControlCollection i_Structure)
        {
            i_Structure.Clear();
            foreach (Control control in i_List)
            {
                i_Structure.Add(control);
            }
        }

        public void CopyToList(List<Control> i_List, Control.ControlCollection i_Structure)
        {
            foreach (Control control in i_Structure)
            {
                i_List.Add(control);
            }
        }

        public void Swap(List<Control> i_List, int i, int j)
        {
            Control temp = i_List[i];
            i_List[i] = i_List[j];
            i_List[j] = temp;
        }
    }
}
