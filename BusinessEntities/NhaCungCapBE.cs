﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class NhaCungCapBE
    {
        public string mancc;
        public string tenncc;
        public string diachi;
        public string dienthoai;
        public string MANCC
        {
            get { return this.mancc; }
            set { this.mancc = value; }
        }
        public string TENNCC
        {
            get { return this.tenncc; }
            set { this.tenncc = value; }
           
        }
        public string DIACHI
        {
            get { return this.diachi; }
            set { this.diachi = value; }
        }
        public string DIENTHOAI
        {
            get { return this.dienthoai; }
            set { this.dienthoai = value; }
        }
    }
}
