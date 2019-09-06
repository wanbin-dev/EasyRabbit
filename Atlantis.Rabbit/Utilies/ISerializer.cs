using System.Text;

namespace Atlantis.Rabbit.Utilies
{
    public interface ISerializer
    {
        byte[] Serialize<T>(T data);

        string SerializeStr<T>(T data);

        T Deserialize<T>(byte[] data);
    }
}
