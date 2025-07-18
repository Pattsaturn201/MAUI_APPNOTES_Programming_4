using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdwinSaaNotesD.Models
{
    internal class About
    {
        public string Title => AppInfo.Name + "\nBy Patrick Saa";
        public string Version => "Version: " + AppInfo.VersionString;
        public string ComidaFavoritaInfoUrl => "https://es.wikipedia.org/wiki/Encebollado";
        public string Message => "Mi nombre es Edwin Saa son fan del futbol y una de mis comidas favoritas es el encebollado.";



    }
}
