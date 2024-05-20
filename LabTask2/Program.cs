using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    class Date 
    {
        private int dd;
        private int mm;
        private int yy;

        public Date(int dd= 1, int mm=1, int yy=2017)
        {
            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
          
        }

        public Date()
        {
            this.dd = 0;
            this.mm = 0;
            this.yy = 0;

        }

        public void setDate(int a, int b, int c) 
        {
            this.dd = a;
            this.mm = b;
            this.yy = c;
        }

        public int getDD
        {
            get { return dd; }
        }
        public int getMM
        {
            get { return mm; }
        }

        /*
        private string GetMonthName(int monthNumber)
        {
            return new DateTime(yy, monthNumber, 1).ToString("MMMM");
        }
        */

        public int getYY 
        {
            get { return yy; }
        }

    }
}
