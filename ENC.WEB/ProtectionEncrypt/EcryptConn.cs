using Microsoft.AspNetCore.DataProtection;

namespace ENC.WEB.ProtectionEncrypt
{
    public class EcryptConn
    {
        private readonly IDataProtectionProvider _dataProtectionProvider;
        public EcryptConn(IDataProtectionProvider dataProtectionProvider)
        {
            _dataProtectionProvider = dataProtectionProvider;
        }
        public string ProtectConnectionString(string connectionString)
        {
            var protector = _dataProtectionProvider.CreateProtector("ConnectionStringsPurpose");
            return protector.Protect(connectionString);
        }

        public string UnprotectConnectionString(string protectedConnectionString)
        {
            var protector = _dataProtectionProvider.CreateProtector("ConnectionStringsPurpose");
            return protector.Unprotect(protectedConnectionString);
        }

    }
}
