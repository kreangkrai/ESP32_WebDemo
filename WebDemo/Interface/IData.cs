using WebDemo.Models;

namespace WebDemo.Interface
{
    public interface IData
    {
        Task<List<DataModel>?> GetDatas();
    }
}
