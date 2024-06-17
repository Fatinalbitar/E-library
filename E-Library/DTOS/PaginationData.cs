using E_Library.Models;
using System.Collections.Generic;

namespace E_Library.DTOS
{
    public class PaginationData<T>
    {
        public PaginationData()
        {

        }
        public PaginationData(List<T> suggested, bool hasPreviousPage, bool hasNextPage, int pageIndex)
        {
            Data = suggested;
            HasPreviousPage = hasPreviousPage;
            HasNextPage = hasNextPage;
            PageIndex = pageIndex;
        }
        public List<T> Data { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public int PageIndex { get; set; }

    }
}
