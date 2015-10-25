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

            //var portNames = SerialPort.GetPortNames();

            sp.PortName = "COM3";
            sp.BaudRate = 19200;
            sp.DataBits = 8;
            sp.StopBits = StopBits.Two;
            sp.Parity = Parity.None;

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

            char[] data_in= new char[66];
            string[] vars = new string[14];
             
            while (true)
            {
                sp.Write("a");

                if(sp.BytesToRead>=66)
                {
                    sp.Read(data_in, 0, 66);

                    vars[0] = data_in[0].ToString();
                    for (int i = 0; i < 12; i++ )
                    {
                        vars[i + 1] = data_in[i * 5 + 1].ToString() 
                                    + data_in[i * 5 + 2].ToString() 
                                    + data_in[i * 5 + 3].ToString()
                                    + data_in[i * 5 + 4].ToString()
                                    + data_in[i * 5 + 5].ToString();
                    }
                }

                Console.WriteLine(vars[0] + " " 
                    + vars[1] + " " 
                    + vars[2] + " " 
                    + vars[3] + " " 
                    + vars[4] + " "
                    + vars[5] + " "
                    + vars[6] + " "
                    + vars[7] + " "
                    + vars[8] + " "
                    + vars[9] + " "
                    + vars[10] + " "
                    + vars[11] + " "
                    + vars[12] + " "
                    + vars[13] + " "
                    );
            }
        }
    }
}
