using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2_1;

public class Countdown
{
    public event EventHandler<string>? Handler;

    // Произвоит вызов события Handler
    public void EventHappens(int time)
    {
        Thread.Sleep(time);
        Console.WriteLine($"Countdown отправляет сообщение спустя {time} мс");
        if (Handler is not null)
        {
            Handler(this, "Всем привет!");
        }
    }
}
