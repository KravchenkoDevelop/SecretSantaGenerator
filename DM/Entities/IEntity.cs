﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Entities
{
    public interface IEntity
    {
        public Guid Id { get; set; }    
    }
}