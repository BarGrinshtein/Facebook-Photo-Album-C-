using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    class RadioButtonWrapper : RadioButton
    {
        public ISortAlgo SortAlgo { get; set; }

        public static ISortAlgo CreateNew(string i_name)
        {
            ISortAlgo sortAlgo = null;
            switch (i_name)
            {
                case "Most Likes":
                    sortAlgo = new LikesSort();
                    break;
                case "First Uploaded":
                    sortAlgo = new UploadSort();
                    break;
                default:
                    throw new Exception("Invalid Type Was Sended");
            }
            return sortAlgo;
        }
    }
}
