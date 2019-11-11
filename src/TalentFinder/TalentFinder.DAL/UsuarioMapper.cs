﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TalentFinder.BE;

namespace TalentFinder.DAL
{
	public class UsuarioMapper
	{
		public int ExisteUsuario(Usuario usuario)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UserName", usuario.UserName));
			int f = da.LeerEscalar("LoginUsuario", parametros);
			da.Cerrar();
			return f;
		}
		public Usuario GetUsuario(string userName)
		{
			Usuario usuario = null;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UserName", userName));
			DataTable tabla = da.Leer("GetUsuario", parametros);
			if(tabla.Rows.Count > 0)
			{
				DataRow registro = tabla.Rows[0];
				usuario = new Usuario();
				usuario.Id = int.Parse(registro["Id"].ToString());
				usuario.UserName = registro["UserName"].ToString();
				usuario.UserPassword = registro["UserPassword"].ToString();
				int TipoUsuarioId = int.Parse(registro["TipoUsuarioId"].ToString());
				UsuarioTipo usuarioTipo = new UsuarioTipo();
				usuarioTipo.Id = int.Parse(registro["TipoUsuarioId"].ToString());
				usuarioTipo.Nombre = registro["Nombre"].ToString();
				usuario.UsuarioTipo = usuarioTipo;
			}
			da.Cerrar();
			return usuario;
		}
		public int DeshabilitarUsuario(Usuario usuario)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UserName", usuario.UserName));
			int f = da.Escribir("DeshabilitarUsuario", parametros);
			da.Cerrar();
			return f;
		}
		public List<Usuario> GetUsuarios()
		{
			List<Usuario> lista = new List<Usuario>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			DataTable tabla = da.Leer("GetUsuarios", null);
			da.Cerrar();

			foreach(DataRow fila in tabla.Rows)
			{
				Usuario usuario = new Usuario();
				usuario.Id = int.Parse(fila["Id"].ToString());
				usuario.UserName = fila["UserName"].ToString();
				usuario.UserPassword = fila["UserPassword"].ToString();
				UsuarioTipo usuarioTipo = new UsuarioTipo();
				usuarioTipo.Id = int.Parse(fila["TipoUsuarioId"].ToString());
				usuarioTipo.Nombre = fila["Nombre"].ToString();
				usuario.UsuarioTipo = usuarioTipo;
				lista.Add(usuario);
			}
			return lista;
		}
		public List<UsuarioTipo> GetUsuarioTipos()
		{
			List<UsuarioTipo> lista = new List<UsuarioTipo>();
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			DataTable tabla = da.Leer("GetAllUsuarioTipos", null);
			da.Cerrar();

			foreach(DataRow fila in tabla.Rows)
			{
				UsuarioTipo tipo = new UsuarioTipo();
				tipo.Id = int.Parse(fila["Id"].ToString());
				tipo.Nombre = fila["Nombre"].ToString();
				lista.Add(tipo);
			}
			return lista;
		}
		public int Agregar(Usuario usuario)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@UserName", usuario.UserName));
			parametros.Add(da.CrearParametro("@UserPassword", usuario.UserPassword));
			parametros.Add(da.CrearParametro("@TipoUsuarioId", usuario.UsuarioTipo.Id));
			int NewId = da.Escribir("AgregarUsuario", parametros);
			da.Cerrar();
			return NewId;
		}
		public int Editar(Usuario usuario)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@Id", usuario.Id));
			parametros.Add(da.CrearParametro("@UserName", usuario.UserName));
			parametros.Add(da.CrearParametro("@UserPassword", usuario.UserPassword));
			parametros.Add(da.CrearParametro("@TipoUsuarioId", usuario.UsuarioTipo.Id));
			int f = da.Escribir("EditarUsuario", parametros);
			da.Cerrar();
			return f;
		}
		public int Eliminar(Usuario usuario)
		{
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@Id", usuario.Id));
			int f = da.Escribir("EliminarUsuario", parametros);
			da.Cerrar();
			return f;
		}
	}
}
