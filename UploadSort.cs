using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    class UploadSort : ISortAlgo
    {
        SortTools m_Tools = new SortTools();

        public void SortDataStructure(Control.ControlCollection i_Structure)
        {
            List<Control> localList = new List<Control>();
            m_Tools.CopyToList(localList, i_Structure);
            int i, j;
            for (i = 0; i < localList.Count - 1; i++)
                for (j = 0; j < localList.Count - i - 1; j++)
                    if ((localList[j] as PictureBoxAdapter).m_photo.CreatedTime.Value.Date >
                        (localList[j + 1] as PictureBoxAdapter).m_photo.CreatedTime.Value.Date)
                        m_Tools.Swap(localList,j, j + 1);
            m_Tools.CopyBackToControls(localList, i_Structure);
        }
    }
}
