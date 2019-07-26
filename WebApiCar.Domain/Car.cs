using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCar.Domain
{
    [Table("Car")]
    public class Car
    {
        public string ano { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }

        public int id { get; set; }

        public Car(){
        }
    }
}
