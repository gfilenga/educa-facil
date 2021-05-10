﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducaFacil.Domain.Models
{
    public abstract class Entity : IEquatable<Entity>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            Created_at = DateTime.Now;
            Updated_at = DateTime.Now;
        }

        public Guid Id { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }

        public void UpdatedAtData()
        {
            Updated_at = DateTime.Now;
        }
    }
}
