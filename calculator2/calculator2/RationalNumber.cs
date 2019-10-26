using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
    class RationalNumber
    {

        public double c = 0;
        public double z = 0;

        public RationalNumber(int c, int z)
        {
            this.c = c;
            this.z = z;
        }
        //slozhenie
        public static RationalNumber operator +(RationalNumber rat1, RationalNumber rat2)
        {
            RationalNumber result = new RationalNumber(1, 1);
            result.c = (rat1.c * rat2.z + rat1.z * rat2.c);
            result.z = rat1.z * rat2.z;

            result.socr(result.c, result.z);

            return result;
        }
        //sokrachenie
        public void socr(double chis, double znam)
        {
            int nod = this.Nod(chis,znam);
            this.c = c / nod;
            this.z = z / nod;
        }

        //naimenshiy obschiy delitel
        private int Nod(double chis, double znam)
        {
            while ((chis != 0) && (znam != 0))
            {
                if (chis > znam)
                    chis -= znam;
                else
                    znam -= chis;
            }

            return Math.Max(Convert.ToInt32(chis), (Convert.ToInt32(znam)));
        }


        public static RationalNumber operator -(RationalNumber rat1, RationalNumber rat2)
        {
            RationalNumber result = new RationalNumber(1, 1);
            result.c = (rat1.c * rat2.z - rat1.z * rat2.c);
            result.z = rat1.z * rat2.z;

            result.socr(result.c, result.z);

            return result;
        }

        public static RationalNumber operator *(RationalNumber rat1, RationalNumber rat2)
        {
            RationalNumber result = new RationalNumber(1, 1);
            result.c = (rat1.c * rat2.c);
            result.z = rat1.z * rat2.z;

            result.socr(result.c, result.z);

            return result;
        }

        public static RationalNumber operator /(RationalNumber rat1, RationalNumber rat2)
        {
            RationalNumber result = new RationalNumber(1, 1);
            result.c = (rat1.c / rat2.c);
            result.z = rat1.z / rat2.z;

            result.socr(result.c, result.z);

            return result;
        }



        
    }
}
