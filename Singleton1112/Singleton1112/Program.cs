using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton1112
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Singleton
    {
        private static readonly Object syncRoot = new object();
        private static volatile Singleton _instance;
        private Singleton() { }
        public static Singleton Instance
        {
            get 
            { 
                if(_instance == null)
                {
                    lock (syncRoot)
                    {
                        if(_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }                    
                }
                return _instance;
            }
        }
    }

}
