using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using Newtonsoft.Json;

namespace Mids_Reborn
{
    public class MidsJsonBoost
    {
        [JsonProperty("p")]
        public string BoostName;
        [JsonProperty("l")]
        public int? Level;
        [JsonProperty("c")]
        public int? NumCombines;
    }

    public class MidsJsonPower
    {
        [JsonProperty("f")]
        public string PowerFullName;
        [JsonProperty("l")]
        public int? PowerLevelBought;
        [JsonProperty("b")]
        public List<MidsJsonBoost> Boosts;
    }

    public class MidsJsonCharacter
    {
        [JsonProperty("n")]
        public string Name;
        [JsonProperty("c")]
        public string Class;
        [JsonProperty("o")]
        public string Origin;
        [JsonProperty("l")]
        public int? Level;
        [JsonProperty("p")]
        public List<MidsJsonPower> Powers;

        public static MidsJsonCharacter FromString(string text)
        {
            if (!text.StartsWith("MxDj")) return null;

            try
            {
                byte[] gZipBuffer = Convert.FromBase64String(text.Substring(4));
                using (var memoryStream = new MemoryStream())
                {
                    int dataLength = BitConverter.ToInt32(gZipBuffer, 0);
                    memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);

                    var buffer = new byte[dataLength];

                    memoryStream.Position = 0;
                    using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                    {
                        gZipStream.Read(buffer, 0, buffer.Length);
                    }
                    return JsonConvert.DeserializeObject<MidsJsonCharacter>(Encoding.UTF8.GetString(buffer));
                }
            }
            catch { }
            return null;
        }

        override public string ToString()
        {
            byte[] buffer = Encoding.UTF8.GetBytes(
                JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })
            );

            var memoryStream = new MemoryStream();
            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
            {
                gZipStream.Write(buffer, 0, buffer.Length);
            }

            memoryStream.Position = 0;

            var compressedData = new byte[memoryStream.Length];
            memoryStream.Read(compressedData, 0, compressedData.Length);

            var gZipBuffer = new byte[compressedData.Length + 4];
            Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gZipBuffer, 0, 4);
            return "MxDj" + Convert.ToBase64String(gZipBuffer);
        }
    }
}
