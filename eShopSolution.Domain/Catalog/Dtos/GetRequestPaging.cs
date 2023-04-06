using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Domain.Catalog.Dtos
{
    public class GetRequestPaging : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategotyId { get; set; }
    }
}
