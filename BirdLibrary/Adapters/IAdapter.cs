using DuckLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLibrary.Adapters
{
    public interface IAdapter
    {
        void Display();
        void Quack();
    }
}
