using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
            
            var request = WebRequest.Create("http://g1.globo.com/dynamo/rss2.xml");

            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            var reader = new StreamReader(dataStream);
        
        }

    }
}
