using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Attributes;

namespace Programare_Clinica.Models
{
    public class Serviciu
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nume { get; set; }
        public int Pret { get; set; }
        public string ServiciuDetails 
        { get { return Nume + "" + Pret;} }

        [OneToMany]
        public List<ServiciuList> ServiciuLists { get; set; }

    }
}
