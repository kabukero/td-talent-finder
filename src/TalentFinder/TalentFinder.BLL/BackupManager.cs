using System;
using System.Collections.Generic;
using System.Configuration;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	/// <summary>
	/// Entidad de negocio para gestionar los backups del sistema
	/// </summary>
	public class BackupManager
	{
		/// <summary>
		/// Abributo que contiene el formato de fecha con el que se creara el archivo de backup
		/// </summary>
		private const string DATE_FORMAT_FOR_FILE = "yyyy_MM_dd_HH_mm_ss";

		/// <summary>
		/// Atributo que contiene el mapper del backup para persistir los datos
		/// </summary>
		BackupMapper backupMapper = new BackupMapper();

		/// <summary>
		/// Método para obtener el nombre del archivo del backup
		/// </summary>
		/// <returns></returns>
		public string GetNombreArchivoBackup()
		{
			return DateTime.Now.ToString(DATE_FORMAT_FOR_FILE) + ".bak";
		}

		/// <summary>
		/// Método para obtener todos los backups
		/// </summary>
		/// <returns>Lista de backups</returns>
		public List<Backup> GetAllBackups()
		{
			return backupMapper.GetAllBackups();
		}

		/// <summary>
		/// Método para crear un backup
		/// </summary>
		/// <param name="backup">Un backup</param>
		/// <returns>valor que indica si se realizó el backup correctamente</returns>
		public int RelizarBackup(Backup backup)
		{
			return backupMapper.RelizarBackup(backup);
		}

		/// <summary>
		/// Mëtodo para realizar un restore de un backup
		/// </summary>
		/// <param name="backup">Un backup del cual se realizará un restore</param>
		/// <returns>valor que indica si se realizó el restore correctamente</returns>
		public int RelizarRestore(Backup backup)
		{
			return backupMapper.RelizarRestore(backup);
		}
	}
}
