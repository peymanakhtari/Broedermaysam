using Maysam.Models;

namespace Maysam.Data.Repository
{
    public class UnitOfWork : IDisposable   
    {
        private AppDbContext context = new AppDbContext();
        private GenericRepository<Review> _ReviewRepository;
        private bool disposed = false;
        public GenericRepository<Review> ReviewRepository
        {
            get
            {
                if (this._ReviewRepository == null)
                {
                    this._ReviewRepository = new GenericRepository<Review>(context);
                }
                return _ReviewRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
