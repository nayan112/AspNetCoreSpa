using System.Security.Cryptography.X509Certificates;

namespace MyCommunity.STS.Services.Certificate
{
    public interface ICertificateService
    {
        X509Certificate2 GetCertificateFromKeyVault(string vaultCertificateName);
    }
}