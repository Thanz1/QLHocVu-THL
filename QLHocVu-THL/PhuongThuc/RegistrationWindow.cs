using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHocVu_THL.PhuongThuc
{
    public class RegistrationWindow
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        private static string PathFile => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registration_window.json");

        public static RegistrationWindow Load()
        {
            try
            {
                if (!File.Exists(PathFile)) return null;
                var json = File.ReadAllText(PathFile);
                return JsonConvert.DeserializeObject<RegistrationWindow>(json);
            }
            catch { return null; }
        }

        public void Save()
        {
            var json = JsonConvert.SerializeObject(this);
            File.WriteAllText(PathFile, json);
        }

        public bool IsOpenNow() => DateTime.Now >= Start && DateTime.Now <= End;
    }
}
