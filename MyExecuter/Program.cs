using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExecuter
{
    public interface text
    {
        void print();
    }
    class format : text
    {
        public void print()
        {
            Console.WriteLine("here the text format");
        }
    }

    public class construcroInjection
    {
        private text _text;

        public construcroInjection(text t1)
        {
            _text = t1;
        }

        public void print()
        {
            _text.print();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
