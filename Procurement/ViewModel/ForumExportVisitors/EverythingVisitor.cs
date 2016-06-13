using POEApi.Model;
using Procurement.ViewModel.Filters.ForumExport;
using System.Collections.Generic;

namespace Procurement.ViewModel.ForumExportVisitors
{
    internal class EverythingVisitor : VisitorBase
    {
        private const string TOKEN = "{Everything}";
        public override string Visit(IEnumerable<Item> items, string current)
        {
            return current.Replace(TOKEN, runFilter<Procurement.ViewModel.Filters.EverythingFilter>(items));
        }
    }
}
