using System.IO;
using System.Net;

namespace UrlNames.Dominio
{
    public class TypeUrl
    {
        public string UrlName { get; set; }

        public TypeUrl(string urlName)
        {
            UrlName = urlName;
        }

        public void GetContentByXML(string urlName)
        {

            var request = WebRequest.Create(urlName);

            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            var reader = new StreamReader(dataStream);

            reader.ReadToEnd();

        }

    }
}
