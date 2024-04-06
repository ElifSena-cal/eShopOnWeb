using System;
using System.Collections.Generic;
using BlazorShared.Models;

namespace Microsoft.eShopWeb.PublicApi.OrderEndpoints;

public class GetByOrderIdOrderDetailResponse : BaseResponse
{
    public GetByOrderIdOrderDetailResponse(Guid correlationId) : base(correlationId)
    {

    }
    public GetByOrderIdOrderDetailResponse()
    {
    }
    public List<OrderDetailDTO> OrderDetails { get; set; } = new List<OrderDetailDTO>();
}
