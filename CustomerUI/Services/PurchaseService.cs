using CustomerUI.Data;
using System.Net.Http;

namespace CustomerUI.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly HttpClient _httpClient;

        public PurchaseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<PurchaseProduct>> GetPurchases()
        {
            return await _httpClient.GetFromJsonAsync<PurchaseProduct[]>("api/Purchase");
        }

        public async Task<PurchaseProduct> GetPurchaseById(int id)
        {
            return await _httpClient.GetFromJsonAsync<PurchaseProduct>($"api/Purchase/{id}");
        }

        public async Task<PurchaseProduct> CreatePurchase(PurchaseProduct purchaseProduct)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Purchase", purchaseProduct);
            return await response.Content.ReadFromJsonAsync<PurchaseProduct>();
        }

        public async Task<PurchaseProduct> UpdatePurchase(int id, PurchaseProduct purchaseProduct)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Purchase/{id}", purchaseProduct);
            return await response.Content.ReadFromJsonAsync<PurchaseProduct>();
        }

        public async Task<PurchaseProduct> UpdatePurchaseQuantity(int id, int quantityChange)
        {
            var response = await _httpClient.PutAsJsonAsync<int>($"api/Purchase/updateQuantity/{id}", quantityChange);
            return await response.Content.ReadFromJsonAsync<PurchaseProduct>();
        }

        public async Task DeletePurchase(int id)
        {
            await _httpClient.DeleteAsync($"api/Purchase/{id}");
        }
    }
}
