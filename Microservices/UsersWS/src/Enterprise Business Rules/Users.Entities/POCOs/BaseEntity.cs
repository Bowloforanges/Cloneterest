namespace Users.Entities.POCOs
{

    /// <summary>
    /// Base entity, should be extended by any other POCO file
    /// </summary>
    public abstract class BaseEntity
    {
        public string Id { get; set; }
    }
}
