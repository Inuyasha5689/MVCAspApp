using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCApp.Models;

namespace MVCApp.ViewModels
{
    public class FirstViewViewModel
    {
        public IEnumerable<MyData> MyType { get; set; }
    }
}
