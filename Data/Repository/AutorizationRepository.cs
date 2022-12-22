using ARMDel.Data;
using ARMDel.Domain.Entities;
using System.Security.Cryptography;
using System;
using System.Text;
using System.Reflection;

namespace ARMDel.Data.Repository
{
    public class AutorizationRepository
    {
        public void Authorize(User user)
        {
            DataManager.currentUser = user;
        }
    }
}
