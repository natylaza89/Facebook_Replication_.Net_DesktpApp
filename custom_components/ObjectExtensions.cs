using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DP_Task1.custom_components
{
    public static class ObjectExtensions
    {
        public static T DeepClone<T>(this T i_ToClone)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, i_ToClone);
                stream.Seek(0, SeekOrigin.Begin);
                T theClone = (T)formatter.Deserialize(stream);
                stream.Close();
                return theClone;
            }
        }
    }
}
