using TalentFinder.BE;
using TalentFinder.DAL;
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
			UsuarioMapper mapper = new UsuarioMapper();

			// validar si el usuario esta registrado
			Usuario UsuarioEncontrado = mapper.GetUsuario(usuario.UserName);
			if(UsuarioEncontrado == null)
				return false;

			// validar password
			if(!EncryptorManager.VerifyPasswordHash(usuario.UserPassword, UsuarioEncontrado.UserPassword))
				return false;

			// set id usuario
			usuario.Id = UsuarioEncontrado.Id;

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

		public bool SuperoMaximoIntentosLogin(Usuario usuario)
		{
			bool r = CantidadIntentosLogin == CantidadMaximaIntentos;
			if(r)
				DeshabilitarUsuario(usuario);
			return r;
		}

		public int DeshabilitarUsuario(Usuario usuario)
		{
			UsuarioMapper mapper = new UsuarioMapper();
			int f = mapper.ExisteUsuario(usuario);
			if(f > 0)
				f = mapper.DeshabilitarUsuario(usuario);
			return f;
		}
	}
}
