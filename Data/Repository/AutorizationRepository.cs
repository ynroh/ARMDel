using ARMDel.Data;
using ARMDel.Domain.Entities;
using System.Security.Cryptography;
using System;
using System.Text;
using System.Reflection;
using ARMDel.Domain.Repository;

namespace ARMDel.Data.Repository
{
    public class AutorizationRepository
    {
        public void Authorize(IUser user)
        {
            DataManager.currentUser = user;
        }
    }
}
