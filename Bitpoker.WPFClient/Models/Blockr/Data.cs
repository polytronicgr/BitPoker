﻿using System;
using System.Collections.Generic;

namespace Bitpoker.WPFClient.Models.Blockr
{
    public class Data
    {
        public String address { get; set; }

        public Decimal balance { get; set; }

        public IEnumerable<Tx> txs { get; set; }
    }
}
