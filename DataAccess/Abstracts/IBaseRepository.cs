namespace DataAccess.Abstracts;

public interface IBaseRepository<Entity> where Entity : BaseEntity
{
    void Create(Entity entity);

    List<Entity> GetAll();

    Entity GetById(int id);

    void Update(Entity entity);

    void Delete(Entity entity);
}
