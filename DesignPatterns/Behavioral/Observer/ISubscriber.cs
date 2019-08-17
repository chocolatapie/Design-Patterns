﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    interface ISubscriber
    {
        void Update(IPublisher publisher);
    }
}
