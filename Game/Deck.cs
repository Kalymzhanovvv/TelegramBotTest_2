﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBotTest_2.Game
{
    public class Deck
    {
        public Dictionary<string, int> cards = new Dictionary<string, int>
        {
            {"2 черви", 2 }, {"2 бубны", 2 }, {"2 трефы", 2 }, {"2 пики", 2 },
            {"3 черви", 3 }, {"3 бубны", 3 }, {"3 трефы", 3 }, {"3 пики", 3 },
            {"4 черви", 4 }, {"4 бубны", 4 }, {"4 трефы", 4 }, {"4 пики", 4 },
            {"5 черви", 5 }, {"5 бубны", 5 }, {"5 трефы", 5 }, {"5 пики", 5 },
            {"6 черви", 6 }, {"6 бубны", 6 }, {"6 трефы", 6 }, {"6 пики", 6 },
            {"7 черви", 7 }, {"7 бубны", 7 }, {"7 трефы", 7 }, {"7 пики", 7 },
            {"8 черви", 8 }, {"8 бубны", 8 }, {"8 трефы", 8 }, {"8 пики", 8 },
            {"9 черви", 9 }, {"9 бубны", 9 }, {"9 трефы", 9 }, {"9 пики", 9 },
            {"10 черви", 10 }, {"10 бубны", 10 }, {"10 трефы", 10 }, {"10 пики", 10 },
            {"Валет черви", 10 }, {"Валет бубны", 10 }, {"Валет трефы", 10 }, {"Валет пики", 10 },
            {"Дама черви", 10 }, {"Дама бубны", 10 }, {"Дама трефы", 10 }, {"Дама пики", 10 },
            {"Король черви", 10 }, {"Король бубны", 10 }, {"Король трефы", 10 }, {"Король пики", 10 },
            {"Туз черви", 11 }, {"Туз бубны", 11 }, {"Туз трефы", 11 }, {"Туз пики", 11 },
        };
    }
}