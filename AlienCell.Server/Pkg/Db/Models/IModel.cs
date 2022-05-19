using System;


namespace AlienCell.Server.Db
{
    public interface IModel
    {
        Ulid Id { get; set; }
    }
}
