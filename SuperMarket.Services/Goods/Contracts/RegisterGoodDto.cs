using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.Services.Goods.Contracts
{
    public class RegisterGoodDto
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
        public int CategoryId { get; set; }
    }
}
