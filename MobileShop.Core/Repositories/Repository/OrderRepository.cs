﻿using MobileShop.Core.Data;
using MobileShop.Core.Models;
using MobileShop.Core.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Core.Repositories.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository()
        { }

        public OrderRepository(MobileShopDBContext context) : base(context)
        {
        }
    }
}
