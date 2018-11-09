using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNavigation.Models
{
    public class HomeMenuItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
