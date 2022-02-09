using AutoMapper;
using BookStore.Data;
using BookStore.Model;

namespace BookStore.Helper
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Books, BookModel>().ReverseMap();
        }
    }
}
