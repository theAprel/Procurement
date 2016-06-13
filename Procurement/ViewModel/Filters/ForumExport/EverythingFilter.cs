using POEApi.Model;
using System.Linq;

namespace Procurement.ViewModel.Filters
{
    internal class EverythingFilter : IFilter
    {
        public FilterGroup Group
        {
            get { return FilterGroup.Default; }
        }

        public bool CanFormCategory
        {
            get { return true; }
        }

        public string Keyword
        {
            get { return "Everything"; }
        }

        public string Help
        {
            get { return "Everything"; }
        }

        public bool Applicable(POEApi.Model.Item item)
        {
			return true;
        }
    }
}
