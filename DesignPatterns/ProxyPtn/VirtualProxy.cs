using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    interface IImage
    {
        void ShowImage();
    }

    public class RealImage : IImage
    {
        public RealImage(string url)
        {
            this.m_url = url;
            Console.WriteLine("Image loaded: " + this.m_url);
        }

        public void ShowImage()
        {
            Console.WriteLine("Image showed: " + this.m_url);
        }
        private string m_url;

    }

    public class ProxyImage : IImage
    {
        public ProxyImage(string url)
        {
            m_url = url;
           Console.WriteLine("Image unloaded: " + m_url);
        }

        public void ShowImage()
        {
            if (m_RealImage == null)
            {
                m_RealImage = new RealImage(m_url);
            }
            else
            {
                Console.WriteLine("Image already exised: " + m_url);
            }
            m_RealImage.ShowImage();
        }

        private string m_url;
        private RealImage m_RealImage;
    }
}
