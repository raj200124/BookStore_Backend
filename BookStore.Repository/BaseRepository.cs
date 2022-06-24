using BookStore.Models.ViewModels;

namespace BookStore.Repository
{
    public class BaseRepository
    {
        protected readonly mybookstoreContext _context = new mybookstoreContext();
    }
}
