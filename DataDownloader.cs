using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace gynvael_misja_008
{
    public class DataDownloader
    {
        static string url = "http://gynvael.coldwind.pl/misja008_drone_io/scans/";
        public static string startFile = "68eb1a7625837e38d55c54dc99257a17.txt";

        public static SingleRead readPosition(string fileName)
        {
            string localFilepath = "..\\..\\cache";
            if (!Directory.Exists(localFilepath))
            {
                Directory.CreateDirectory(localFilepath);
            }
            string path = Path.Combine(new string[] { localFilepath, fileName });

            if (!File.Exists(path))
            {
                string fullUrl = url + fileName;
                byte[] fileByteContent = ReadFileFromUrl(fullUrl);
                File.WriteAllBytes(path, fileByteContent);
            }
            string[] fileLines = File.ReadAllLines(path);

            var result = new SingleRead();

            string[] xytmp = fileLines[1].Split(new char[] { ' ' });
            result.x = Convert.ToInt32(xytmp[0]);
            result.y = Convert.ToInt32(xytmp[1]);

            var distTmp = new List<double>();
            for(int i = 0; i < 36; i++)
            {
                if (fileLines[i + 2] != "inf")
                    distTmp.Add(Convert.ToDouble(fileLines[i + 2].Replace('.', ',')));
                else
                    distTmp.Add(-1);
            }
            result.distance = distTmp.ToArray();
            result.MOVE_EAST = fileLines[38].Replace("MOVE_EAST: ", "");
            result.MOVE_WEST = fileLines[39].Replace("MOVE_WEST: ", ""); ;
            result.MOVE_SOUTH = fileLines[40].Replace("MOVE_SOUTH: ", ""); ;
            result.MOVE_NORTH = fileLines[41].Replace("MOVE_NORTH: ", ""); ;

            return result;
        }

        private static byte[] ReadFileFromUrl(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException webEx)
            {
                return new byte[0];
            }

            using (MemoryStream ms = new MemoryStream())
            {
                resp.GetResponseStream().CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
