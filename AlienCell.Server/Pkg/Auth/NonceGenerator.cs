using System.Text;
using System.Security.Cryptography;


namespace AlienCell.Server.Auth
{
    public static class NonceGenerator
    {
        public static string Get(int length)
        {
	        using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
	        {
		        byte[] data = new byte[length];
		        crypto.GetBytes(data);
                return Convert.ToBase64String(data);
            }
        }
    }
}

