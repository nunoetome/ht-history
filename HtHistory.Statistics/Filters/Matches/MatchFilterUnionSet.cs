﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtHistory.Core.ExtensionMethods;
using HtHistory.Core.DataContainers;

namespace HtHistory.Statistics.Filters.Matches
{
    public class MatchFilterUnionSet : IMatchFilter
    {
        private IEnumerable<IMatchFilter> _filters;

        public MatchFilterUnionSet(IEnumerable<IMatchFilter> filters)
        {
            _filters = filters ?? new List<IMatchFilter>();
        }

        public IEnumerable<MatchDetails> Filter(IEnumerable<MatchDetails> input)
        {
            IEnumerable<MatchDetails> resultSet = new MatchDetails[0];

            foreach (IMatchFilter filter in _filters.SafeEnum())
            {
                resultSet = resultSet.Union(filter.Filter(input));
            }

            return resultSet;
        }
    }
}
