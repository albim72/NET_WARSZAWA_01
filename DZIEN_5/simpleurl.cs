using System.Net;

IPAddress a1 = new IPAddress(new byte[] { 101, 102, 103, 104 });
IPAddress a2 = IPAddress.Parse("101.102.103.104");

Console.WriteLine(a1.Equals(a2));
Console.WriteLine(a1.AddressFamily);

//IPAddress a3 = IPAddress.Parse("[3EA0:FFFF:198A:4FF2:54FA:41BC:8D31]");
//Console.WriteLine(a3.AddressFamily);

IPEndPoint ep = new IPEndPoint(a2, 222);
Console.WriteLine(ep.ToString());

Uri info = new Uri("http://www.domain.com:80/info");
Uri page = new Uri("http://www.domain.com/info/page.html");

Console.WriteLine(info.Host);
Console.WriteLine(info.Port);
Console.WriteLine(page.Port);
Console.WriteLine(info.IsBaseOf(page));

Uri relative = info.MakeRelativeUri(page);
Console.WriteLine(relative.IsAbsoluteUri);
Console.WriteLine(relative.ToString());
