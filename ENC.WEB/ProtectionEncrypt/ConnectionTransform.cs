namespace ENC.WEB.ProtectionEncrypt
{
    public class ConnectionTransform
    {
        private readonly EcryptConn _ecryptConn;
        public ConnectionTransform(IServiceProvider serviceProvider)
        {
            _ecryptConn =serviceProvider.GetRequiredService<EcryptConn>();
        }

        public void doDencrypt()
        {
            var protectedConnectionString = "YOUR_ENCRYPTED_CONNECTION_STRING"; // Replace with your encrypted connection string
            var connectionString = _ecryptConn.UnprotectConnectionString(protectedConnectionString);
        }

    }
}
