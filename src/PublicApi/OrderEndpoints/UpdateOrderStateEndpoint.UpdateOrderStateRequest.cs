
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using static BlazorShared.Models.Enum;

namespace Microsoft.eShopWeb.PublicApi.OrderEnpoints;

public class UpdateOrderStateRequest : BaseRequest
{
    public int OrderId { get; set; }
    public OrderStatus OrderStatus { get; set; }
}
