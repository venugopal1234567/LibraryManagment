using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Presentation
{
    public class BookListPagination<T> : List<T>
    {
        public int PageIndex { get; set; }
        public int  TotalPages { get; set; }

        public BookListPagination(List<T> items, int count, int pageIndex, int pageSize){
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count/(double)pageSize);
            this.AddRange(items);
        }

        public bool IsPreviousPageAvailable => PageIndex > 1;
        
        public bool IsNextPageAvailable => PageIndex < TotalPages;

        public static BookListPagination<T> Create(IList<T> source, int pageIndex, int pageSize){
            var count = source.Count();
            var items = source.Skip((pageIndex-1) * pageSize).Take(pageSize).ToList();
            return new BookListPagination<T>(items, count, pageIndex, pageSize);
        }
    }
}