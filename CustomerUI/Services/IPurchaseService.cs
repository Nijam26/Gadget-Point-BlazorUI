using CustomerUI.Data;

namespace CustomerUI.Services
{
    public interface IPurchaseService
    {
        Task<IEnumerable<PurchaseProduct>> GetPurchases();
        Task<PurchaseProduct> GetPurchaseById(int id);
        Task<PurchaseProduct> CreatePurchase(PurchaseProduct purchaseProduct);
        Task<PurchaseProduct> UpdatePurchase(int id, PurchaseProduct purchaseProduct);
        Task<PurchaseProduct> UpdatePurchaseQuantity(int id, int quantityChange);
        Task DeletePurchase(int id);
    }
}
