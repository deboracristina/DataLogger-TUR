using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR
{
    class ControllerData
    {
        public char[] data_in { get; set; }
        public string categoria { get; set; }
        public string temp_total_arrancada { get; set;}
        public string temp_entrada_lombada { get; set; }
        public string temp_saida_lombada { get; set; }
        public string temp_total_lombada { get; set; }
        public string temp_total_percurso { get; set; }
        public string temp_Marca1_ida { get; set; }
        public string temp_Volta1 { get; set; }
        public string temp_Marca2_ida { get; set; }
        public string temp_Marca3_ida { get; set; }
        public string temp_Marca3_volta { get; set; }
        public string temp_Marca2_volta { get; set; }
        public string temp_Marca1_volta { get; set; }
        public string temp_Volta2 { get; set; }

        public ControllerData()
        {

        }
    }
}
