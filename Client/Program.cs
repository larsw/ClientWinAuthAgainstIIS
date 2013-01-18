namespace Client
{
    using System;
    using System.Net;

    class Program
    {
        static void Main()
        {
            using (var wc = new WebClient
                         {
                             Credentials = CredentialCache.DefaultNetworkCredentials
                         })
            { 
                Console.WriteLine(wc.DownloadString("http://localhost/ClientWinAuthAgainstIIS/"));
            }
        }
    }
}
