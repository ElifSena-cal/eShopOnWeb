using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace Microsoft.eShopWeb.ApplicationCore.Specifications;
public class OrdersWithItemsSpecification : Specification<Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.Order>
{
    public OrdersWithItemsSpecification()
    {
        Query.Include(o => o.OrderItems);
    }
}
