using MangoFusion_API.Data;
using MangoFusion_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace MangoFusion_API.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ApiResponse _response;
        public OrderController(ApplicationDbContext db)
        {
            _db = db;
            _response = new ApiResponse();
        }


        [HttpGet]
        public ActionResult<ApiResponse> GetOrders(string userId="")
        {
            IEnumerable<OrderHeader> orderHeaderList = _db.OrderHeaders.Include(u=>u.OrderDetails)
                .ThenInclude(u=>u.MenuItem).OrderByDescending(u=>u.OrderHeaderId);

            if (!string.IsNullOrEmpty(userId))
            {
                orderHeaderList = orderHeaderList.Where(u => u.ApplicationUserId == userId);
            }

            _response.Result = orderHeaderList;
            _response.StatusCode=HttpStatusCode.OK;
            return Ok(_response);
        }

        [HttpGet("{orderId:int}")]
        public ActionResult<ApiResponse> GetOrder(int orderId)
        {
            if (orderId == 0)
            {
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.ErrorMessages.Add("Invalid order Id");
                return BadRequest(_response);
            }

            OrderHeader? orderHeader = _db.OrderHeaders.Include(u => u.OrderDetails)
                .ThenInclude(u => u.MenuItem).FirstOrDefault(u => u.OrderHeaderId==orderId);

            if (orderHeader == null)
            {
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.NotFound;
                _response.ErrorMessages.Add("Order not found");
                return NotFound(_response);
            }

            _response.Result = orderHeader;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }
    }
}
