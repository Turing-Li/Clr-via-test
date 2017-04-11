using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TestForCLR
{
    public class SerializableHelper
    {
        public static Stream ConvertToMemoryStream(Object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);

            return stream; ;
        }
    }
    [Serializable]
    public class SerializableTest
    {
        public String Str
        {
            get;
            set;
        }
    }
}
