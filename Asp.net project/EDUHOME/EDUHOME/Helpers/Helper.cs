using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Helpers
{
    public static class Helper
    {
        public static void DeleteFile(string root,string folder,string fileName)
        {
            string path = Path.Combine(root, folder, fileName);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }
    }
    public enum Roles
    {
        Admin,
        Member,
        Moderator
    }
}
