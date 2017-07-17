using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tianyu
{
    class PathHelper
    {
        public static String defaultDirectory = "Images"; //图片默认存储目录
        public static String currentDirectory = Directory.GetCurrentDirectory(); //当前工作目录
        public static String relPathDirectory = "";//相对路径单击单元格是得到
        public static String relPath = "";//数据库中读出的相对路径
    }
}
