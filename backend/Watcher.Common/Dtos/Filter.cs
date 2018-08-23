namespace Watcher.Common.Dtos
{
    using Watcher.Common.Enums;
    using Watcher.Common.MoveToFrontend;

    [ExportClassToTypescript]
    public class Filter
    {
        private int page;
        private int pageSize;

        public Filter() { }

        public Filter(string searchString)
        {
            SearchString = searchString;
        }

        public Filter(int page, int pageSize, OrderBy orderBy)
        {
            Page = page;
            PageSize = pageSize;
            OrderBy = orderBy;
        }

        public int PageSize
        {
            get => pageSize == 0 ? 10 : pageSize;
            set => pageSize = value <= 10 ? value : 10;
        }

        public int Page
        {
            get => page == 0 ? 1 : page;
            set => page = value;
        }

        public OrderBy OrderBy { get; set; }

        public string SearchString { get; set; } = string.Empty;
    }
}
