using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using MinimalApi.Endpoint;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using Microsoft.eShopWeb.ApplicationCore.Specifications;


namespace Microsoft.eShopWeb.PublicApi.OrderEndpoints;

/// <summary>
/// List Catalog Types
/// </summary>
public class OrderListEndpoint :IEndpoint<IResult, IRepository<Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.Order>>
{
    private readonly IMapper _mapper;

    public OrderListEndpoint(IMapper mapper)
    {
        _mapper = mapper;
    }

    public void AddRoute(IEndpointRouteBuilder app)
    {
        app.MapGet("api/orders",
            async (IRepository<Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.Order> orderRepository) =>
            {
                return await HandleAsync(orderRepository);
            })
        .Produces<ListOrderResponse>()
        .WithTags("OrderEndpoints");
    }

    public async Task<IResult> HandleAsync(IRepository<Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.Order> orderRepository)
    {
        var response = new ListOrderResponse();
        var spec = new OrdersWithItemsSpecification();

        var items = await orderRepository.ListAsync(spec);

        response.Orders.AddRange(items.Select(_mapper.Map<OrdersDTO>));

        return Results.Ok(response);
    }
}
