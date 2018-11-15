using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc
{
    public class thuoc
    {
        string ma;
        string ten;
        string congdung;
        public thuoc()
        {

        }
        public thuoc(string ma, string ten, string congdung)
        {
            this.ma = ma;
            this.ten = ten;
            this.congdung = congdung;
        }

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public string Congdung
        {
            get
            {
                return congdung;
            }

            set
            {
                congdung = value;
            }
        }
    }
}
