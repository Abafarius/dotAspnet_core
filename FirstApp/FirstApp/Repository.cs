using FirstApp;

namespace LifeTime
{
    public class Repository
    {
        private readonly Context _context;

        public Repository(Context context)
        {
            _context = context;
        }

        public int DataRow => _context.DataRow;
    }
}
