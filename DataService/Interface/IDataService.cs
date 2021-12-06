
namespace DataService.Interface
{
    public interface IDataService<T>
    {

        void ClearData();
        T GetData();
        bool UpdateData(T obj);
        bool AddNewData(T obj);

    }
}
