using ResurantReactpro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResurantReactpro.Repository
{
    public class AllRepo: IAllRepo
    {
        private readonly New_DataContext Context;
        public AllRepo(New_DataContext repositoryContext)
      
        {
            Context = repositoryContext;
        }

        #region Customers
        public async Task<bool> DeleteCustomersById(int Id)
        {
            if (Id != 0)
            {

                var Customers = Context.Customers.Where(c => c.CustomerId == Id);
                if (Customers != null)
                {
                    Context.Customers.RemoveRange(Customers);
                    await Context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            return false;

        }

        public IQueryable<Customers> GetAllCustomers()
        {
            var Customers = Context.Customers.AsQueryable();
            return Customers;
        }
        public IQueryable<Customers> GetCustomersById(int Id)
        {
            var Customers = Context.Customers.Where(c => c.CustomerId == Id).ToList();

            return Customers.AsQueryable();
        }

        public async Task<bool> InsertOrUpdateCustomers(Customers entity)
        {
            try
            {
                if (entity != null)
                {
                    if (entity.CustomerId == 0)
                        await Context.Customers.AddAsync(entity);
                    else
                        Context.Customers.Update(entity);
                    await Context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

            }
            return false;

        }
        #endregion
        #region OrderMasters
        public async Task<bool> DeleteOrderMastersById(int Id)
        {
            if (Id != 0)
            {

                var OrderMasters = Context.OrderMasters.Where(c => c.OrderMasterId == Id);
                if (OrderMasters != null)
                {
                    Context.OrderMasters.RemoveRange(OrderMasters);
                    await Context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            return false;

        }

        public IQueryable<OrderMasters> GetAllOrderMasters()
        {
            var OrderMasters = Context.OrderMasters.AsQueryable();
            return OrderMasters;
        }
        public IQueryable<OrderMasters> GetOrderMastersById(int Id)
        {
            var OrderMasters = Context.OrderMasters.Where(c => c.OrderMasterId == Id).ToList();

            return OrderMasters.AsQueryable();
        }

        public async Task<bool> InsertOrUpdateOrderMasters(OrderMasters entity)
        {
            try
            {
                if (entity != null)
                {
                    if (entity.CustomerId == 0)
                        await Context.OrderMasters.AddAsync(entity);
                    else
                        Context.OrderMasters.Update(entity);
                    await Context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

            }
            return false;

        }
        #endregion

        #region OrderDetails
        public async Task<bool> DeleteOrderDetailsById(int Id)
        {
            if (Id != 0)
            {

                var OrderDetails = Context.OrderDetails.Where(c => c.OrderDetailsId == Id);
                if (OrderDetails != null)
                {
                    Context.OrderDetails.RemoveRange(OrderDetails);
                    await Context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            return false;

        }

        public IQueryable<OrderDetails> GetAllOrderDetails()
        {
            var OrderDetails = Context.OrderDetails.AsQueryable();
            return OrderDetails;
        }
        public IQueryable<OrderDetails> GetOrderDetailsById(int Id)
        {
            var OrderDetails = Context.OrderDetails.Where(c => c.OrderDetailsId == Id).ToList();

            return OrderDetails.AsQueryable();
        }

        public async Task<bool> InsertOrUpdateOrderDetails(OrderDetails entity)
        {
            try
            {
                if (entity != null)
                {
                    if (entity.OrderDetailsId == 0)
                        await Context.OrderDetails.AddAsync(entity);
                    else
                        Context.OrderDetails.Update(entity);
                    await Context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

            }
            return false;

        }
        #endregion
        #region FoodItems
        public async Task<bool> DeleteFoodItemsById(int Id)
        {
            if (Id != 0)
            {

                var FoodItems = Context.FoodItems.Where(c => c.FoodItemId == Id);
                if (FoodItems != null)
                {
                    Context.FoodItems.RemoveRange(FoodItems);
                    await Context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            return false;

        }

        public IQueryable<FoodItems> GetAllFoodItems()
        {
            var FoodItems = Context.FoodItems.AsQueryable();
            return FoodItems;
        }
        public IQueryable<FoodItems> GetFoodItemsById(int Id)
        {
            var FoodItems = Context.FoodItems.Where(c => c.FoodItemId == Id).ToList();

            return FoodItems.AsQueryable();
        }

        public async Task<bool> InsertOrUpdateFoodItems(FoodItems entity)
        {
            try
            {
                if (entity != null)
                {
                    if (entity.FoodItemId == 0)
                        await Context.FoodItems.AddAsync(entity);
                    else
                        Context.FoodItems.Update(entity);
                    await Context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

            }
            return false;

        }
        #endregion
    }
}
