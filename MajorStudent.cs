﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV1
{
    internal class MajorStudent : Student
    {
        public string Major { get; set; }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Major: " + Major);
        }
    }
}
