using System;
using System.IO;
using System.Xml.Serialization;

namespace VideoLibrary
{
    public static class XmlSerializeHelper
    {
        public static bool SerializeAndSave(string filename, object objectToSerialize)
        {
            XmlSerializer serializer = new XmlSerializer(objectToSerialize.GetType());
            try
            {
                using (FileStream stream = new FileStream(Path.Combine(FileHelper.GetAppDirectory(), filename), FileMode.Create))
                    serializer.Serialize(stream, objectToSerialize);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static T LoadAndDeserialize<T>(this string filename)
        {
            if (!File.Exists(filename))
                throw new Exception("File not exist");

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            try
            {
                using (FileStream stream = new FileStream(Path.Combine(FileHelper.GetAppDirectory(), filename), FileMode.Open))
                    return (T)serializer.Deserialize(stream);
            }
            catch
            {
                throw new Exception("Error during deserializing");
            }
        }
    }
}