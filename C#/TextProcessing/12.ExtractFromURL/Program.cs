using System;
using System.Collections.Generic;

class ExtractFromURL
{
    static void Main()
    {
        string urlAddress = @"http://www.MyWebsite.com/herewegoagain/index.php";

        int indexOfProtocol = urlAddress.IndexOf("://");
        int indexOfServer = urlAddress.IndexOf('/', indexOfProtocol + 3);

        Console.WriteLine("[protocol]: {0}", urlAddress.Substring(0, indexOfProtocol - 0));
        Console.WriteLine("[server]: {0}", urlAddress.Substring(indexOfProtocol + 3, urlAddress.Length - 3 - indexOfProtocol - indexOfServer));
        Console.WriteLine("[resources]: {0}", urlAddress.Substring(indexOfServer, urlAddress.Length - indexOfServer - indexOfProtocol));
    }
}