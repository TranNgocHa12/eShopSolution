using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModel.Catalog.Common
{
    public class GetRequestPaging : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategotyId { get; set; }
    }
}
