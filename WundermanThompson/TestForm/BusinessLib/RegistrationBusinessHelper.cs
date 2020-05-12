using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestForm.Models;
using TestForm.Helper;

namespace TestForm.BusinessLib
{
    public class RegistrationFormOperation : IRegistrationForm
    {
        public void SaveRegistration(RegistrationForm reg)
        {
            try
            {
                IDbRepository<RegistrationForm> ProdOperation = new DbRepository<RegistrationForm>();
                ProdOperation.Save(reg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public interface IRegistrationForm
    {
        void SaveRegistration(RegistrationForm reg);
    }
}
