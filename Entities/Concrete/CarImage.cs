using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarImage : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }


        private DateTime currentTime = DateTime.Today;
        public DateTime Date
        {
            get { return currentTime; }
            set { currentTime = value; }
        }

    }
}

