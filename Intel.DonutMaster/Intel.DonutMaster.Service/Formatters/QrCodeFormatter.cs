using Intel.DonutMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Intel.DonutMaster.Service.Formatters
{
    public class QrCodeFormatter : MediaTypeFormatter
    {
        public QrCodeFormatter()
        {
            SupportedMediaTypes
                .Add(new System.Net.Http.Headers.MediaTypeHeaderValue("image/png"));
        }

        public override bool CanReadType(Type type)
        {
            return false;
        }

        public override bool CanWriteType(Type type)
        {
            return type == typeof(Product);
        }

        public override async Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
        {
            var product = value as Product;

            var uri = $"https://chart.googleapis.com/chart?cht=qr&chs=300x300&chl={product.Symbol}";

            using (var client = new WebClient())
            {
                // client.Proxy = new WebProxy("http://proxy-chain.intel.com:911");

                var data = await client.DownloadDataTaskAsync(uri);

                await writeStream.WriteAsync(data, 0, data.Length);
            }

        }
    }
}