namespace BLL.Interface
{
    public interface IRailRoute
    {
        string From { get; set; }
        string To { get; set; }
        string NumberOfRoute { get; set; }


        int HowMuchReserved();


        ITrain Train { get; }
    }
}
