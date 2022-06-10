using System;


namespace AlienCell.Server.Db.Models
{
    public interface IModel<TKey>
    {
        TKey Id { get; }
    }
}
