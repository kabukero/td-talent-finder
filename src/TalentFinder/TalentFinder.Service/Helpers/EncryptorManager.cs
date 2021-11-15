using System;
using System.Security.Cryptography;

namespace TalentFinder.Service.Seguridad
{
	/// <summary>
	/// Clase para gestionar la encriptación / desencriptación de los datos
	/// </summary>
    public class EncryptorManager
    {
		/// <summary>
		/// Atributo que especifica el tamaño del salt de la encriptación
		/// </summary>
		private const int SaltByteSize = 32;
		/// <summary>
		/// Atributo que especifica el tamaño del hash de la encriptación
		/// </summary>
		private const int HashByteSize = 32;
		private const int Iterations = 4096;

		/// <summary>
		/// Método para generar el salt de la encriptación
		/// </summary>
		/// <returns>Salt de la encriptación</returns>
		public static string GetSalt()
		{
			var cryptoProvider = new RNGCryptoServiceProvider();
			byte[] b_salt = new byte[SaltByteSize];
			cryptoProvider.GetBytes(b_salt);
			return Convert.ToBase64String(b_salt);
		}

		/// <summary>
		/// Método para generar hashing de la password del usuario
		/// </summary>
		/// <param name="password">Una password</param>
		/// <returns>Hashing de la password del usuario</returns>
		public static string GetPasswordHash(string password)
		{
			string salt = GetSalt();

			byte[] saltBytes = Convert.FromBase64String(salt);
			byte[] derived = null;

			using(Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, Iterations))
			{
				derived = pbkdf2.GetBytes(HashByteSize);
			}

			return string.Format("{0}:{1}:{2}", Iterations, Convert.ToBase64String(derived), Convert.ToBase64String(saltBytes));
		}

		/// <summary>
		/// Método para verificar la password de un usuario
		/// </summary>
		/// <param name="password"></param>
		/// <param name="hash"></param>
		/// <returns></returns>
		public static bool VerifyPasswordHash(string password, string hash)
		{
			try
			{
				string[] parts = hash.Split(':');
				byte[] saltBytes = Convert.FromBase64String(parts[2]);
				byte[] derived;
				int iterations = Convert.ToInt32(parts[0]);

				using(Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, iterations))
					derived = pbkdf2.GetBytes(HashByteSize);

				string new_hash = string.Format("{0}:{1}:{2}", Iterations, Convert.ToBase64String(derived), Convert.ToBase64String(saltBytes));

				return hash == new_hash;
			}
			catch
			{
				return false;
			}
		}
	}
}
