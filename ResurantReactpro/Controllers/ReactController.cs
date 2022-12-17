using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResurantReactpro.Models;
using ResurantReactpro.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResurantReactpro.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ReactController : ControllerBase
    {
        private readonly IAllRepo _IAllRepo;


        public ReactController(IAllRepo IAllRepo)
        {
            _IAllRepo = IAllRepo;

        }
        #region Customers


        [HttpGet]

        [Route("GetCustomersById/{Id}")]
        public IActionResult GetCustomersById(int Id)
        {

            var Hospitality = _IAllRepo.GetCustomersById(Id);
            if (Hospitality == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Hospitality);
            }
        }

        [HttpGet]

        [Route("GetAllCustomers")]
        public IActionResult GetAllCustomers()
        {


            var Hospitality = _IAllRepo.GetAllCustomers();
            if (Hospitality == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Hospitality);
            }
        }

        [HttpPost]
        [Route("DeleteCustomersById/{Id}")]
        public async Task<IActionResult> DeleteCustomersById(int Id)
        {
            if (Id != 0)
            {
                await _IAllRepo.DeleteCustomersById(Id);
                return Ok();
            }
            else
                return NotFound();
        }


        [HttpPost]

        [Route("InsertOrUpdateCustomers")]
        public async Task<IActionResult> InsertOrUpdateCustomers(Customers entity)
        {

            if (entity.CustomerId == 0)
            {
                await _IAllRepo.InsertOrUpdateCustomers(entity);
                return Ok();
            }
            else
                await _IAllRepo.InsertOrUpdateCustomers(entity);
            return Ok(entity.CustomerId);

        }
        #endregion
        #region OrderMasters


        [HttpGet]

        [Route("GetOrderMastersById/{Id}")]
        public IActionResult GetOrderMastersById(int Id)
        {

            var Hospitality = _IAllRepo.GetOrderMastersById(Id);
            if (Hospitality == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Hospitality);
            }
        }

        [HttpGet]

        [Route("GetAllOrderMasters")]
        public IActionResult GetAllOrderMasters()
        {


            var Hospitality = _IAllRepo.GetAllOrderMasters();
            if (Hospitality == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Hospitality);
            }
        }

        [HttpPost]
        [Route("DeleteOrderMastersById/{Id}")]
        public async Task<IActionResult> DeleteOrderMastersById(int Id)
        {
            if (Id != 0)
            {
                await _IAllRepo.DeleteOrderMastersById(Id);
                return Ok();
            }
            else
                return NotFound();
        }


        [HttpPost]

        [Route("InsertOrUpdateOrderMasters")]
        public async Task<IActionResult> InsertOrUpdateOrderMasters(OrderMasters entity)
        {

            if (entity.OrderMasterId == 0)
            {
                await _IAllRepo.InsertOrUpdateOrderMasters(entity);
                return Ok();
            }
            else
                await _IAllRepo.InsertOrUpdateOrderMasters(entity);
            return Ok(entity.OrderMasterId);

        }
        #endregion
        #region OrderDetails


        [HttpGet]

        [Route("GetOrderDetailsById/{Id}")]
        public IActionResult GetOrderDetailsById(int Id)
        {

            var Hospitality = _IAllRepo.GetOrderDetailsById(Id);
            if (Hospitality == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Hospitality);
            }
        }

        [HttpGet]

        [Route("GetAllOrderDetails")]
        public IActionResult GetAllOrderDetails()
        {


            var Hospitality = _IAllRepo.GetAllOrderDetails();
            if (Hospitality == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Hospitality);
            }
        }

        [HttpPost]
        [Route("DeleteOrderDetailsById/{Id}")]
        public async Task<IActionResult> DeleteOrderDetailsById(int Id)
        {
            if (Id != 0)
            {
                await _IAllRepo.DeleteOrderDetailsById(Id);
                return Ok();
            }
            else
                return NotFound();
        }


        [HttpPost]

        [Route("InsertOrUpdateOrderDetails")]
        public async Task<IActionResult> InsertOrUpdateOrderDetails(OrderDetails entity)
        {

            if (entity.OrderDetailsId == 0)
            {
                await _IAllRepo.InsertOrUpdateOrderDetails(entity);
                return Ok();
            }
            else
                await _IAllRepo.InsertOrUpdateOrderDetails(entity);
            return Ok(entity.OrderDetailsId);

        }
        #endregion     
        #region FoodItems


        [HttpGet]

        [Route("GetFoodItemsById/{Id}")]
        public IActionResult GetFoodItemsById(int Id)
        {

            var Hospitality = _IAllRepo.GetFoodItemsById(Id);
            if (Hospitality == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Hospitality);
            }
        }

        [HttpGet]

        [Route("GetAllFoodItems")]
        public IActionResult GetAllFoodItems()
        {


            var Hospitality = _IAllRepo.GetAllFoodItems();
            if (Hospitality == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Hospitality);
            }
        }

        [HttpPost]
        [Route("DeleteFoodItemsById/{Id}")]
        public async Task<IActionResult> DeleteFoodItemsById(int Id)
        {
            if (Id != 0)
            {
                await _IAllRepo.DeleteFoodItemsById(Id);
                return Ok();
            }
            else
                return NotFound();
        }


        [HttpPost]

        [Route("InsertOrUpdateFoodItems")]
        public async Task<IActionResult> InsertOrUpdateFoodItems(FoodItems entity)
        {

            if (entity.FoodItemId == 0)
            {
                await _IAllRepo.InsertOrUpdateFoodItems(entity);
                return Ok();
            }
            else
                await _IAllRepo.InsertOrUpdateFoodItems(entity);
            return Ok(entity.FoodItemId);

        }
        #endregion
    }
}
