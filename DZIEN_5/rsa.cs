using System.Security.Cryptography;
using System.Text;

using(var rsa = new RSACryptoServiceProvider())
{
    File.WriteAllText("PublicKeyOnly.xml", rsa.ToXmlString(false));
    File.WriteAllText("PublicPrivate.xml", rsa.ToXmlString(true));
}

//szyfrowanie

byte[] data = Encoding.UTF8.GetBytes("wiadomość do zaszyfrowania...");
string publicKeyOnly = File.ReadAllText("PublicKeyOnly.xml");
string publicPrivate = File.ReadAllText("PublicPrivate.xml");

byte[] encrypted, decrypted;
using(var rsaPublicOnly = new RSACryptoServiceProvider())
{
    rsaPublicOnly.FromXmlString(publicKeyOnly);
    encrypted = rsaPublicOnly.Encrypt(data, true);
}

//rozszyfrowanie

using(var rsa = new RSACryptoServiceProvider())
{
    File.WriteAllText("info.xml", rsa.ToXmlString(false));
    rsa.ToXmlString(false);
    Console.WriteLine("plik info.xml");

    File.WriteAllText("pp.xml", rsa.ToXmlString(true));
    rsa.ToXmlString(true);
    Console.WriteLine("plik pp.xml");


}
