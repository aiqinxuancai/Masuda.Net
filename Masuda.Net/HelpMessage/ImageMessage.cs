﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masuda.Net.HelpMessage
{
    public class ImageMessage: MessageBase
    {
        public string Url;
        public ImageMessage(string url)
        {
            //Url = System.Web.HttpUtility.UrlEncode(url); ;
            Url = Uri.EscapeUriString(url); 
            //Url = Uri.UnescapeDataString(url); ;
        }
    }
}
