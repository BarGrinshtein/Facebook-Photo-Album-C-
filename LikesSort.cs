using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    class LikesSort : ISortAlgo
    {
        SortTools m_Tools = new SortTools();

        public void SortDataStructure(ControlCollection i_Structure)
        {
            List<Control> localList = new List<Control>();
            m_Tools.CopyToList(localList, i_Structure);
            int i, j;
            for (i = 0; i < localList.Count - 1; i++)  
                for (j = 0; j < localList.Count - i - 1; j++)
                    if ((localList[j] as PictureBoxAdapter).m_photo.LikedBy.Count >
                        (localList[j+1] as PictureBoxAdapter).m_photo.LikedBy.Count)
                        m_Tools.Swap(localList,j, j+1);
            m_Tools.CopyBackToControls(localList, i_Structure);
        }
    }
}
