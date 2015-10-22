using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace PortCOM_100
{
    class Program
    {
        static SerialPort sp;

        static void Main(string[] args)
        {
            sp = new SerialPort();

            var portNames = SerialPort.GetPortNames();

            Console.WriteLine();

            sp.PortName = "COM3";
            sp.BaudRate = 19200;

            try
            {
                if (!sp.IsOpen)
                {
                    sp.Open();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            while (true)
            {
                if (sp.BytesToRead >= 67)
                {
                    var read = sp.ReadLine();
                    Console.WriteLine();
                }
            }
        }
    }
}
