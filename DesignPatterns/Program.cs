﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    class Program
    {
        static void ClientProxyPatternTest()
        {
            Console.WriteLine("Init proxy image: ");
            ProxyImage proxyImage = new ProxyImage("https://gpcoder.com/favicon.ico");

            Console.WriteLine("---");
            Console.WriteLine("Call real service 1st: ");
            proxyImage.ShowImage();

            Console.WriteLine("---");
            Console.WriteLine("Call real service 2nd: ");
            proxyImage.ShowImage();
        }

        static void Main(string[] args)
        {
            ClientProxyPatternTest();
        }
    }
}
