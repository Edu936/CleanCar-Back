using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCar.Domain.Entities
{
    public abstract class Base
    {
        public Guid Id { get; init; }
        public bool IsActive { get; set; }
        public DateTime DateDelete { get; set;}
        public DateTime DateCreate { get; set;} 
        public DateTime DateUpdate { get; set;}

        public Base()
        {
            IsActive = true;
            Id = Guid.NewGuid();
            DateCreate = DateTime.Now;
        }
    }
}
