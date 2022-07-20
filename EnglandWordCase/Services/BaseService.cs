using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EnglandWordCase.Services
{
    abstract class BasesController
    {
        protected void Serilaze(string fileName, object items)
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream(fileName,FileMode.OpenOrCreate))
            {   
                formatter.Serialize(fileStream, items);
            }
        }

        protected T Desirilize<T>(string fileName)
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                if (fileStream.Length > 0 && formatter.Deserialize(fileStream) is T items)
                {
                    return items;
                }
                else
                {
                    return default(T);
                }
            }
        }
    }
}
