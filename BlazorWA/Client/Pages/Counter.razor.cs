﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWA.Client.Pages
{
    public class CounterBase:ComponentBase
    {
        [Inject] protected ServiciosSingleton Singleton { get; set; }
        [Inject] protected ServiciosTransient Transient { get; set; }

        protected int currentCount = 0;

        protected void IncrementCount()
        {
            currentCount++;
            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
        }
    }
}