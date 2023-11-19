using Microsoft.AspNetCore.Mvc;
using ticketissuesystem.Services.Itemsservice;

namespace ticketissuesystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {

        public readonly IItemService _itemsService;
        public TicketController(IItemService itemservice)
        {

            _itemsService = itemservice;
        }

    }
}
