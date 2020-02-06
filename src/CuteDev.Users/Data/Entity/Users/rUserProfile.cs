/* Author: Volkan Sendag - vsendag@gmail.com */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CuteDev.Entity.Parameters;

namespace CuteDev.Users.Data.Entity.Users
{

    /// <summary>
    /// Users sonuç varlığı (volkansendag - 02.08.2016)
    /// </summary>
    public class rUserProfile : rUsers
    {
        public dynamic meta { get; set; }
    }
}
