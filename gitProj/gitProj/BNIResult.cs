using System;
using System.Collections.Generic;
using System.Text;

namespace gitProj
{
    internal class BNIResult
    {
        private static int LastID;
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public string Result { get; set; }

        public BNIResult(int iD, string title, DateTime date, float height, float width, string result)
        {
            ID = iD;
            Title = title;
            Date = date;
            Height = height;
            Width = width;
            Result = result;
        }
    }
}
