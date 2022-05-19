using System;
using System.Collections.Generic;


namespace AlienCell.Server.Db
{
    public class ChangeSet<T> where T : IModel
    {
        public Dictionary<Ulid, T> Added { get; set; } = new Dictionary<Ulid, T>();
        public Dictionary<Ulid, T> Updated { get; set; } = new Dictionary<Ulid, T>();
        public Dictionary<Ulid, T> Removed { get; set; } = new Dictionary<Ulid, T>();

        public void Add(T model)
        {
            this.Added[model.Id] = model;
        }

        public void Update(T model)
        {
            this.Updated[model.Id] = model;
        }

        public void Remove(T model)
        {
            this.Removed[model.Id] = model;
        }
    }
}

