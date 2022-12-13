using ReverseProxy.Store.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseProxy.Store.EFCore.Management
{
    public interface IClusterManagement
    {
        IQueryable<Cluster> GetAll();
        Task<Cluster> Find(string id);
        Task<bool> Create(Cluster cluster);
        Task<bool> Update(Cluster cluster);
        Task<bool> Delete(string id);
    }
}
