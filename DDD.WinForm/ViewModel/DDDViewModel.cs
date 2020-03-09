using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD.WinForm.ViewModel
{
    class DDDViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string RunDist { get; set; }
        public string FirstRegist { get; set; }
        public string EngineType { get; set; }
        public string Inspection { get; set; }
        public string Repair { get; set; }

        public void Search(int id)
        {

        }


    }


}
