public class QueryApplication
{
    public string Status { get; set; }
    public string Priority { get; set; }

    public string Sort { get; set; }




    private const int MaxPageSize = 20;
    private int _pageSize = 10;


    

    public int Number
    {
        get => _pageSize;
        set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
             
    }
}


