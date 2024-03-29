﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci.Contracts
{
    public abstract class Question
    {
        abstract public void Run();

        public string Name => GetType().ToString();
    }

    public interface IQuestion
    {
        public void Run();
    }
}
