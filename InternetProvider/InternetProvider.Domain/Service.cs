﻿using System;
using System.Collections.Generic;

namespace InternetProvider.Domain
{
    public class Service: IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public IEnumerable<Tariff> Tariff { get; set; }
        public IEnumerable<User> Users { get; set; }
        public bool IsDeleted { get; set; }
    }
}
