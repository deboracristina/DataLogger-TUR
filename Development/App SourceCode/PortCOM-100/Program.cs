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

            char[] data= new char[66];

            string[] dados = new string[14];

            while (true)
            {
                sp.Write("a");

                if(sp.BytesToRead>=66)
                {
                    sp.Read(data, 0, 66);
                    dados[0] = data[0].ToString();
                    for (int i = 0; i < 12; i++ )
                    {
                        dados[i + 1] = data[i * 5 + 1].ToString() 
                            + data[i * 5 + 2].ToString() 
                            + data[i * 5 + 3].ToString()
                            + data[i * 5 + 4].ToString()
                            + data[i * 5 + 5].ToString();
                    }
                }

                Console.WriteLine(dados[0] + " " 
                    + dados[1] + " " 
                    + dados[2] + " " 
                    + dados[3] + " " 
                    + dados[4] + " "
                    + dados[5] + " "
                    + dados[6] + " "
                    + dados[7] + " "
                    + dados[8] + " "
                    + dados[9] + " "
                    + dados[10] + " "
                    + dados[11] + " "
                    + dados[12] + " "
                    + dados[13] + " "
                    );
                //var b = sp.BytesToRead;
                
                //var c = sp.BytesToRead;
               
                //sp.WriteLine("a");
                //if (sp.BytesToRead >= 1)
                //{
                //    //var read = sp.rea();
                //    //Console.WriteLine();
                //}
            }
        }
    }
}
