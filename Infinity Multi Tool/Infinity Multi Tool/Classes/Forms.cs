using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infinity_Multi_Tool
{
    public class Forms
    {
        public static Launcher Launcher = new Launcher();
        public static AssetDownloader AssetDownloader = new AssetDownloader();
        public static Credits Credit = new Credits();
        public static HashGen HashGen = new HashGen();
        public static DiscCacheDown DiscCache = new DiscCacheDown();
        public static TopMostBoi Boio = new TopMostBoi();
        public static NitroSnipin Snip = new NitroSnipin();
        public static void print(params string[] Str) { Console.WriteLine(string.Join(" ", Str)); }
        public static DialogResult Notify(string Message, bool YN, bool OK)
        {
            return new Notice(Message, YN, OK).ShowDialog();
        }
    }
}
