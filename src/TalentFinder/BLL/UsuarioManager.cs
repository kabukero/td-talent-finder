using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class UsuarioManager
	{
		public int CantidadIntentosLogin { get; set; }

		public UsuarioManager()
		{
			CantidadIntentosLogin = 0;
		}

		public bool Login(Usuario usuario)
		{
			CantidadIntentosLogin++;
			UsuarioMapper mapper = new UsuarioMapper();
			return mapper.Login(usuario);
		}

		public Usuario CrearUsuarioLogin(string usuario, string password)
		{
			return new Usuario() { UserName = usuario, Password = password };
		}

		public bool ValidarLogin(Usuario usuario)
		{
			bool r = true;
			if(string.IsNullOrEmpty(usuario.UserName))
				r = false;

			if(string.IsNullOrEmpty(usuario.Password))
				r = false;

			if(!Login(usuario))
				r = false;

			return r;
		}

		public bool SuperoMaximoIntentosLogin()
		{
			return CantidadIntentosLogin == 3;
		}
	}
}
