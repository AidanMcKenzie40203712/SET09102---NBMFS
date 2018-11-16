﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SET09120___NBMFS
{
    //[DataContract]
    public class SMS
    {
        // Getters and setters for SMS variables
        public string header { get; set; }
        public string msgSender { get; set; }
        public string body { get; set; }


        public SMS(string headerIn, string senderIn, string bodyIn)
        {
            header = headerIn;
            msgSender = senderIn;
            body = bodyIn;
        }
    }
}
