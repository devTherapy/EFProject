using System;
using System.Collections.Generic;
using System.Text;

namespace EfProject.Core
{
    public class GlobalConfig
    {
        public static IRepository AppInstance;
        public static void CreateInstance()
        {
            AppInstance = new Repository();
        }
    }
}
