using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                //ETicaretAPI class'ında bulunan dsoya yolunu set ediyorum
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretAPI.API"));
                //Bu dosyadaki appsettings.json dosyasısını bu classda görmesini sağlayorum.
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("SQLServerConnect");
            }
        }
    }
}
