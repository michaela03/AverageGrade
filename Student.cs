using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SREDEN_USPEH
{
    class Student
    {
        private string name;
        private int id;
        private string clas;
        private double bEL;
        private double foreign;
        private double mathematik;
        private double informatics;
        private double phys;
        private double bio;
        private double avg;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Clas
        {
            get
            {
                return clas;
            }

            set
            {
                clas = value;
            }
        }

        public double BEL
        {
            get
            {
                return bEL;
            }

            set
            {
                bEL = value;
            }
        }

        public double Foreign
        {
            get
            {
                return foreign;
            }

            set
            {
                foreign = value;
            }
        }

        public double Mathematik
        {
            get
            {
                return mathematik;
            }

            set
            {
                mathematik = value;
            }
        }

        public double Informatics
        {
            get
            {
                return informatics;
            }

            set
            {
                informatics = value;
            }
        }

        public double Phys
        {
            get
            {
                return phys;
            }

            set
            {
                phys = value;
            }
        }

        public double Bio
        {
            get
            {
                return bio;
            }

            set
            {
                bio = value;
            }
        }

        public double Avg
        {
            get
            {
                return avg;
            }

            set
            {
                avg = value;
            }
        }

        public Student(string name, int id, string clas,
            double BEL, double Foreign, double Mathematik, double Informatics, double Phys, double Bio, double avg)
        {
            this.name = name;
            this.id = id;
            this.clas = clas;
            this.bEL = BEL;
            this.foreign = Foreign;
            this.mathematik = Mathematik;
            this.informatics = Informatics;
            this.phys = Phys;
            this.bio = Bio;
            this.avg = avg;

        }

    
    }
}
