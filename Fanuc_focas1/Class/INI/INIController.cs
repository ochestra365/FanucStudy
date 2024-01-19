using System.Text;
using System.Runtime.InteropServices;
namespace Fanuc_focas1.Class.INI
{
   internal class INIController
   {
      [DllImport("kernel32")]
      private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);
      [DllImport("kernel32")]
      private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

      public static void Write(string _section, string _key, string _value)
      {
         try
         {
            WritePrivateProfileString(_section, _key, _value, Path.Combine(Application.StartupPath, "INI", "setting.ini"));
         }
         catch { } 
      }
      public static string Read(string _section, string _key)
      {
         try
         {
            string path = Path.Combine(Application.StartupPath, "INI", "setting.ini");
            StringBuilder stringBuilder = new StringBuilder();
            GetPrivateProfileString(_section, _key, "(NOREAD)", stringBuilder, 128, path);
            return stringBuilder.ToString().Trim();
         }
         catch { return string.Empty; }
      }
   }
}
