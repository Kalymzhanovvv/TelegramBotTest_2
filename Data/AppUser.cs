using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TelegramBotTest_2.Data
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        public long TelegramUserId { get; set; }
    }
}
