using ResurantReactpro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResurantReactpro.Repository
{
   public interface IAllRepo
    {
        #region Customers
        IQueryable<Customers> GetCustomersById(int Id);
        IQueryable<Customers> GetAllCustomers();
        Task<bool> DeleteCustomersById(int Id);
        Task<bool> InsertOrUpdateCustomers(Customers entity);
        #endregion
        #region OrderMasters
        IQueryable<OrderMasters> GetOrderMastersById(int Id);
        IQueryable<OrderMasters> GetAllOrderMasters();
        Task<bool> DeleteOrderMastersById(int Id);
        Task<bool> InsertOrUpdateOrderMasters(OrderMasters entity);
        #endregion
        #region OrderDetails
        IQueryable<OrderDetails> GetOrderDetailsById(int Id);
        IQueryable<OrderDetails> GetAllOrderDetails();
        Task<bool> DeleteOrderDetailsById(int Id);
        Task<bool> InsertOrUpdateOrderDetails(OrderDetails entity);
        #endregion
        #region FoodItems
        IQueryable<FoodItems> GetFoodItemsById(int Id);
        IQueryable<FoodItems> GetAllFoodItems();
        Task<bool> DeleteFoodItemsById(int Id);
        Task<bool> InsertOrUpdateFoodItems(FoodItems entity);
        #endregion
    }
}
