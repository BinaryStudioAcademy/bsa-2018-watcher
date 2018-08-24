namespace Watcher.Common.Enums
{
    public enum OrderBy
    {
        // By default it will sort by id (logic in Repository)
        Name = 0,
        Name_Desc,
        Date,
        Date_Desc
    }
}