using NorthWind.Entities.ValueObjets;


namespace NorthWind.Entities.Interfaces;

    public interface IUserActionWriter
    {
        void Write (UserAction action);
    }

