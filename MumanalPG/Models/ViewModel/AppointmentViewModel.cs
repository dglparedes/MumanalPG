﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MumanalPG.Models.ViewModel
{
    public class AppointmentViewModel
    {
        public List<Appointments> Appointments { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
