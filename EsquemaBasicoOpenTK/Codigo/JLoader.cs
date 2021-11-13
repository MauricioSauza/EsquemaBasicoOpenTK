using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using HelloEscenario;

namespace Escenario
{
    class JLoader
    {
        public static void save(string path, Objeto obj)
        {
            string output = JsonConvert.SerializeObject(obj);
            File.WriteAllText(path, output);
        }
        public static Objeto load(string path)
        {
            string output = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Objeto>(output);
        }
    }
}
