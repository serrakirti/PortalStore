using PortalStore.CoreLayer.IntRepository;
using PortalStore.CoreLayer.IntUnitOfWork;
using PortalStore.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PortalDbContext _db;
        private CategoryRepository _categoryRepository;
        private AdressRepository _adressRepository;
        private CustomerRepository _customerRepository;
        private OrderRepository _orderRepository;
        private OrderItemRepository _orderItemRepository;
        private ProductRepository _productRepository;

        public UnitOfWork(PortalDbContext db)
        {
            _db = db;
        }

        public IAdressRepository Adress => _adressRepository ??= new AdressRepository(_db);

        public ICategoryRepository Category => _categoryRepository ??= new CategoryRepository(_db);

        public IOrderRepository Order => _orderRepository ??= new OrderRepository(_db);

        public IOrderItemRepository OrderItem => _orderItemRepository ??= new OrderItemRepository(_db);

        public IProductRepository Product => _productRepository ??= new ProductRepository(_db);

        public ICustomerRepository Customer => _customerRepository ??= new CustomerRepository(_db);

        public void Commit()
        {
            _db.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _db.SaveChangesAsync();
        }
    }
}
