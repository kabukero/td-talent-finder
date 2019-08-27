using TalentFinder.BE;
using TalentFinder.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentFinder.Seguridad;

namespace TalentFinder.BLL
{
	public class UsuarioManager
	{
		private const int CantidadMaximaIntentos = 3;
		public int CantidadIntentosLogin { get; set; }

		public UsuarioManager()
		{
			CantidadIntentosLogin = 0;
		}

		public bool ValidarUsuario(Usuario usuario)
		{
			CantidadIntentosLogin++;

			// validar si el usuario esta registrado
			UsuarioMapper mapper = new UsuarioMapper();
			int f = mapper.ExisteUsuario(usuario);

			if(f != 1)
				return false;

			// validar password
			Usuario UsuarioEncontrado = mapper.GetUsuario(usuario.UserName);
			if(UsuarioEncontrado == null)
				return false;

			string hash = EncryptorManager.GetPasswordHash(UsuarioEncontrado.UserPassword);
			if(!EncryptorManager.VerifyPasswordHash(UsuarioEncontrado.UserPassword, hash))
				return false;

			return true;
		}

		public Usuario CrearUsuarioLogin(string usuario, string password)
		{
			return new Usuario() { UserName = usuario, UserPassword = password };
		}

		public bool ValidarLogin(Usuario usuario)
		{
			if(string.IsNullOrEmpty(usuario.UserName) || usuario.UserName.Length > 50)
				return false;

			if(string.IsNullOrEmpty(usuario.UserPassword) || usuario.UserPassword.Length > 50)
				return false;

			if(!ValidarUsuario(usuario))
				return false;

			return true;
		}

		public bool SuperoMaximoIntentosLogin()
		{
			return CantidadIntentosLogin == CantidadMaximaIntentos;
		}
	}
}
