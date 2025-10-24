using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class ip
    {
        // ip consists of 4 segments of ints ( 123.234.566.456  )
        private int[] segments = new int[4];

        // way1 to intialllize segments 
        public ip(int segment1 , int segment2 , int segment3 , int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;
        }
        // way2
        public ip(string segments)
        {
            string[] segs = segments.Split('.');
            for(int i = 0; i < 4; i++)
            {
                this.segments[i] = Convert.ToInt32(segs[i]);
            }
        }

        // this --> refer to current object 
        public int this[int idx]
        {
            set
            {
                if (idx < 0 || idx > 3)
                {
                    return;
                }
                segments[idx] = value;
            }
            get
            {
                if (idx < 0 || idx > 3)
                {
                    return -1;
                }
                return segments[idx];
            }
        }
        public string IP => string.Join('.', segments);
    }
}
