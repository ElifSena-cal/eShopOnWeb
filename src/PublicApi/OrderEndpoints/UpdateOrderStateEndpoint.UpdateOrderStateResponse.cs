using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using Microsoft.eShopWeb.PublicApi.OrderEndpoints;

namespace Microsoft.eShopWeb.PublicApi.OrderEnpoints;

public class UpdateOrderStateResponse : BaseResponse
{
    public OrdersDTO Order { get; set; }
}
