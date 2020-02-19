using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChatApp.DAC;
using ChatApp.Model;

namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : Controller
    {
        private IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }
        // GET: api/values
        [HttpPost("Send")]
        public async Task Send([FromBody]Chat chat)
        {
            await _chatService.InsertChat(chat);
        }

        // GET api/values/5
        [HttpGet("Recieve")]
        public async Task<List<Chat>> Recieve()
        {
            return await _chatService.GetChats();
        }
    }
}
