using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class CTNhapKhoBE
    {
        private string mactnk;
        private string mank;
        private int masp;
        private int soluong;
        private float giaban;
        private float giamua;

        public string MACTNK
        {
            get { return this.mactnk; }
            set { this.mactnk = value; }
        }
        public string MANK
        {
            get { return this.mank; }
            set { this.mank = value; }
        }
        public int MASP
        {
            get { return this.masp; }
            set { this.masp = value; }
        }
        public int SOLUONG
        {
            get { return this.soluong; }
            set { this.soluong = value; }
        }
        public float GIAMUA
        {
            get { return this.giamua; }
            set { this.giamua = value; }
        }
        public float GIABAN
        {
            get { return this.giaban; }
            set { this.giaban = value; }
        }
    }
}
