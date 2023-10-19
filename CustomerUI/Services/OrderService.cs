using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CustomerUI.Data;
using Microsoft.JSInterop;

namespace CustomerUI.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;
        //private readonly IJSRuntime _jsRuntime;
/*
        public OrderService(HttpClient httpClient, IJSRuntime jsRuntime)
        {
            _httpClient = httpClient;
            _jsRuntime = jsRuntime;
        }*/

        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        /*
                private async Task<string> GetAccessToken()
                {
                    // Retrieve the access token from local storage
                    return await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "accessToken");
                }*/


        /*public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _httpClient.GetFromJsonAsync<Order[]>("api/Order");
        }*/

        /*  public async Task<IEnumerable<Order>> GetAllOrders()
          {
              var accessToken = await GetAccessToken();
              _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
              return await _httpClient.GetFromJsonAsync<Order[]>("api/order");
          }*/


        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            // Replace "YOUR_ACCESS_TOKEN" with your actual authorization token.
            var accessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6ImFkbWluQHRlc3QuY29tIiwiZ2l2ZW5fbmFtZSI6IkVTQUQgUjUzIiwibmJmIjoxNjk3Njg4MDU4LCJleHAiOjE2OTgyOTI4NTgsImlhdCI6MTY5NzY4ODA1OCwiaXNzIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTI1MCJ9.lkVQ6aL0GhDy-Oh6-gnd4-YRTmVZpUyiRZgaP20aRjY";

            // Add the Authorization header with the Bearer token.
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            return await _httpClient.GetFromJsonAsync<Order[]>("api/Order");
        }

        public async Task<Order> GetOrderById(int orderId)
        {
            return await _httpClient.GetFromJsonAsync<Order>($"api/Order/{orderId}");
        }

        public async Task CreateOrder(Order order)
        {
            await _httpClient.PostAsJsonAsync("api/Order", order);

            /*     var response = await _httpClient.PostAsJsonAsync("api/order", order);
                 return await response.Content.ReadFromJsonAsync<Order>();*/
        }

        public async Task UpdateOrder(Order order)
        {
            await _httpClient.PutAsJsonAsync($"api/Order/{order.OrderId}", order);
        }

        public async Task DeleteOrder(int orderId)
        {
            await _httpClient.DeleteAsync($"api/Order/{orderId}");
        }
    }
}
