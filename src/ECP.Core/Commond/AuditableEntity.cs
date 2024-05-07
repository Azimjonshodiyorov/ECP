namespace ECP.Core.Commond;

public class AuditableEntity<T> : BaseEntity<T>
{
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
}