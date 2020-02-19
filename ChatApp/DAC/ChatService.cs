using ChatApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.DAC
{
    public interface IChatService
    {
        Task InsertChat(Chat chat);
        Task<List<Chat>> GetChats();
    }
    public class ChatService : IChatService
    {
        private ChatContext _chatContext;

        public ChatService(ChatContext context)
        {
            _chatContext = context;
        }
        public async Task<List<Chat>> GetChats()
        {
            return  await Task.Run(()=> _chatContext.Chat.Where(c => c.ID > 0).ToList());
        }

        public async Task InsertChat(Chat chat)
        {
            try
            {

                await _chatContext.AddAsync(chat);
                _chatContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
