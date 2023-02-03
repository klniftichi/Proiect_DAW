namespace Proiect_DAW___Iftichi_Calin.Models.Base
{
    public interface IBaseEntity
    {
        DateTime DataCreated { get; set; }
        DateTime? DataModified { get; set; }

    }
}
