using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PdfGeneration.Models
{
    public class Marks
    {
        public int RollNo
        {
            get;
            set;
        }
        public string Subject
        {
            get;
            set;
        }
        public int FullMarks
        {
            get;
            set;
        }
        public int Obtained { get; set; }
    }
}
