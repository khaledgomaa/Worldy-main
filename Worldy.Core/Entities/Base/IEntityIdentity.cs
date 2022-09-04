namespace Worldy.Core.Entities.Base
{
    internal interface IEntityIdentity<T> where T : struct
    {
        public T Id { get; set; }
    }
}