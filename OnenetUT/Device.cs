using Legend.Onenet;
using Legend.Onenet.DependencyInjection;
using Legend.Onenet.Request.Device;
using Legend.Onenet.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OnenetUT
{
    public class Device
    {
        private IServiceCollection _services = new ServiceCollection();
        private readonly IDeviceServices _deviceServices;
        OnenetOptions _onenetOptions = new OnenetOptions();
        public Device()
        {
            var builder = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsetting.json", optional: false, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            var provider = new ServiceCollection()
                      .AddSingleton(configuration)
                      .AddOneNetClient()
                      .BuildServiceProvider();
            _onenetOptions = configuration.GetSection("OnenetOptions").Get<OnenetOptions>();
            _deviceServices = provider.GetService<IDeviceServices>();
        }
        [Fact]
        public async Task SearchMutiAndDelAllDevice()
        {
            List<string> list = new List<string>();
            int page = 1;
            var devices = await _deviceServices.SearchMutiDeviceAsync(new SearchMutiDevicesRequest(_onenetOptions)
            {
                 Auth_info= "869075030",
                Page = page,
                Per_page = 300
            });
            list.AddRange(devices.Data.Devices.Select(t => t.Id));
            page += 1;
            int totalpage = int.Parse(Math.Ceiling(devices.Data.Total_count / double.Parse(devices.Data.Per_page.ToString())).ToString());
            while (page <= totalpage)
            {
                var devices1 = await _deviceServices.SearchMutiDeviceAsync(new SearchMutiDevicesRequest(_onenetOptions)
                {
                    Page = page,
                    Per_page = 300
                });
                page += 1;
                if (devices1.Data.Devices.Count == 0)
                {
                    break;
                }
                list.AddRange(devices1.Data.Devices.Select(t => t.Id));
            }
            var result1 = Parallel.ForEach(list, async (a) =>
              {
                  var result = await _deviceServices.DeleteDeviceAsync(new DeleteDeviceRequest(_onenetOptions)
                  {
                      Device_id = a
                  });
                  if (result.Errno == 0)
                  {
                      Debug.WriteLine($"{a}É¾³ý³É¹¦");
                  }
                  else
                  {
                      Debug.WriteLine($"{a}É¾³ýÊ§°Ü");
                  }
              });
            while (!result1.IsCompleted)
            {
                await Task.Delay(100);
            }
            //string url = HttpUtility.UrlEncode("http://www.baidu.com?tt=aa bb");
            //string url1 = HttpUtility.UrlPathEncode("http://www.baidu.com?tt=aa bb");
        }
    }
}
