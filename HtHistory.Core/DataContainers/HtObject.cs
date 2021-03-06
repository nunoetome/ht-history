﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtHistory.Core.DataContainers
{
    public class HtObject
    {
        protected HtObject(int id) { ID = id; }

        public int ID { get; private set; }

        public override bool Equals(object obj)
        {
			if (obj == null) return false;
			if (ReferenceEquals(this, obj)) return true;

            return this.GetType().Equals(obj.GetType()) && ID.Equals((obj as HtObject).ID);

            // TODO:check with Simba implementation
        }

        public override int GetHashCode()
        {
            return (int) ID;
        }
    }
}
