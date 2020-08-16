using System;
using System.Threading.Tasks;
using DataAccess.Repositories;
using DataAccess.Repositories.BranchRepository;
using DataAccess.Repositories.CertificateRepository;
using DataAccess.Repositories.DiscountRepository;
using DataAccess.Repositories.OrganizationRepository;
using DataAccess.Repositories.RoleClaimRepository;
using DataAccess.Repositories.UserRepository;
using Models.Entities;

namespace DataAccess.UnitofWork
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary> 
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IRepository<T> GetRepository<T>() where T : BaseEntity;

        // Repositories
        IUserRepository UserRepository { get; }
        IRoleClaimRepository RoleClaimRepository { get; }
        IOrganizationRepository OrganizationRepository { get; }
        IDiscountRepository DiscountRepository { get; }
        IBranchRepository BranchRepository { get; }
        ICertificateRepository CertificateRepository { get; }
        ISignOperationRepository SignOperationRepository { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int SaveChanges();

        /// <summary>
        /// 
        /// </summary>
        Task<int> SaveChangesAsync();

        /// <summary>
        /// 
        /// </summary>
        void Begin();

        /// <summary>
        /// 
        /// </summary>
        Task BeginAsync();

        /// <summary>
        /// 
        /// </summary>
        void Commit();

        /// <summary>
        /// 
        /// </summary>
        Task CommitAsync();

        /// <summary>
        /// 
        /// </summary>
        void Rollback();

        /// <summary>
        /// 
        /// </summary>
        Task RollbackAsync();
    }
}
