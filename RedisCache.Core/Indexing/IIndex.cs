﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEL.Framework.Redis.Indexing.Writers;

namespace PEL.Framework.Redis.Indexing
{
    internal interface IIndex<TValue>
    {
        IIndexWriter<TValue> IndexWriter { get; }
        

    }
}
