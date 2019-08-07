 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    public class MyFriend
    {
        public FacebookWrapper.ObjectModel.User Friend { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Friend.FirstName, Friend.LastName);
        }
    }
}
