﻿using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using roosterapi.Models;
using roosterapi.Models.Dashboard;

namespace roosterapi.Services
{
    public class DashboardService : DatabaseServiceBase<DashboardItem>
    {
        public DashboardService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _databaseItems = database.GetCollection<DashboardItem>(settings.CollectionName);
        }       
    }
}
