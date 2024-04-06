using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorShared.Interfaces;
using BlazorShared.Models;
using Microsoft.Extensions.Logging;


namespace BlazorAdmin.Services;

public class OrderService : IOrderService
{

    private readonly HttpService _httpService;
    private readonly ILogger<OrderService> _logger;

    public OrderService(
        HttpService httpService,
        ILogger<OrderService> logger)
    {

        _httpService = httpService;
        _logger = logger;
    }

    public async Task<List<OrderDetail>> GetById(int id)
    {
        var response = await _httpService.HttpGet<OrderDetailResponse>($"orders/{id}");

        return response.OrderDetails;
    }




    public async Task<List<Order>> List()
    {
        _logger.LogInformation("Fetching catalog items from API.");
        var response = await _httpService.HttpGet<OrderResponse>($"orders");

        return response.Orders;
    }

    public async Task<Order> UpdateOrderState(UpdateOrderStateRequest request)
    {
        var response = await _httpService.HttpPut<UpdateOrderResponse>($"orders", request);

        return response.Order;
    }


}
