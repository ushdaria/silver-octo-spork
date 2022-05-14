using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2_1;

public class Subscriber
{
    private string name;
    public Subscriber(string name, Countdown cd)
    {
        this.name = name;
        cd.Handler += ShowMessage;
    }

    private void ShowMessage(object? sender, string e)
    {
        Console.WriteLine($"Подписчик {name} реагирует на событие. Издатель говорит: {e}");
    }

}
