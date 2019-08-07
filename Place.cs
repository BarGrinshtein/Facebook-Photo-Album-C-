using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    class Place
    {
        FormUserPlaceChoice m_anotherChoice = new FormUserPlaceChoice();

        public static Place Create(string i_placeName, string i_myLocation)
        {
            if (i_placeName == "תחנת דלק")
            {
                return new Place_gasStation(i_myLocation);
            }
            if (i_placeName == "סופרמרקט")
            {
                return new Place_supermarket(i_myLocation);
            }
            if (i_placeName == "בית קפה")
            {
                return new Place_coffeHouse(i_myLocation);
            }
            if (i_placeName == "מוסך")
            {
                return new Place_garage(i_myLocation);
            }
            if (i_placeName == "מסעדה")
            {
                return new Place_restaurant(i_myLocation);
            }
            return new Place_other(i_myLocation);
        }

        public class Place_gasStation : Place
        {
            public Place_gasStation(string i_myLocation)
            {
                openUrl(i_myLocation, "gasStation");
            }

        }

        public class Place_coffeHouse : Place
        {
            public Place_coffeHouse(string i_myLocation)
            {
                openUrl(i_myLocation, "coffe house");
            }
        }

        public class Place_supermarket : Place
        {
            public Place_supermarket(string i_myLocation)
            {
                openUrl(i_myLocation, "supermarket");
            }
        }

        public class Place_garage : Place
        {
            public Place_garage(string i_myLocation)
            {
                openUrl(i_myLocation, "garage");
            }
        }

        public class Place_restaurant : Place
        {
            public Place_restaurant(string i_myLocation)
            {
                openUrl(i_myLocation, "restaurant");
            }
        }

        public class Place_other : Place
        {
            public Place_other(string i_myLocation)
            {
                m_anotherChoice.ShowDialog();


                if (m_anotherChoice.userChoice != null)
                {
                    openUrl(i_myLocation, m_anotherChoice.userChoice);
                }
                else
                {
                    throw new Exception();
                }

            }
        }

        public void openUrl(string i_myLocation, string i_placeName)
        {
            string m_urlPlace = "https://www.google.com/maps/search/" + i_myLocation + " " + i_placeName;
            System.Diagnostics.Process.Start(m_urlPlace);
        }
    }
}

