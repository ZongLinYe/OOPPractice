using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WaterBall_1._2
{
    internal class Journey
    {
        private string _name;
        private string _description;
        private decimal _price;

        public Journey(
            string name, 
            string description, 
            decimal price,
            List<Chapter> chapters)
        {
            Name = name;
            Description = description;
            Price = price;
            Chapters = chapters;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name =  value.LimitLength(1, 30);               
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            private set
            {
                _description = value.LimitLength(0, 300);              
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            private set
            {
                _price = value.ShouldBeBiggerThan(1);     
            }
        }

        public List<Chapter> Chapters { get; private set; }

    }
}
