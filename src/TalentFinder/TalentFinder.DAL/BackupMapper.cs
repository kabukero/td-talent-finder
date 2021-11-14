using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using TalentFinder.BE;

namespace TalentFinder.DAL
{
	public class BackupMapper
	{
		private const string DATE_FORMAT_FOR_FILE = "yyyy_MM_dd_HH_mm_ss";
		private string RUTA_BACKUPS;

		public List<Backup> GetAllBackups()
		{
			string[] archivos = Directory.GetFiles(RUTA_BACKUPS, "*.bak");

			List<Backup> backups = new List<Backup>();
			for(int i = 0; i < archivos.Length; i++)
			{
				string nombreArchivo = Path.GetFileNameWithoutExtension(archivos[i]);
				if(DateTime.TryParseExact(nombreArchivo, DATE_FORMAT_FOR_FILE, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaBackup))
				{
					backups.Add(new Backup
					{
						FechaCreacion = fechaBackup,
						NombreArchivo = nombreArchivo
					});
				}
			}
			return backups;
		}

		public int RelizarBackup(Backup backup)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir(true);
			string nombreBd = ConfigurationManager.AppSettings["nombreBdPrincipal"].ToString();
			string query = "BACKUP DATABASE " + nombreBd + " TO DISK = @ubicacion";
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@ubicacion", RUTA_BACKUPS + backup.NombreArchivo));
			da.EscribirCmdText(query, parametros);
			da.Cerrar();
			return f;
		}

		public int RelizarRestore(Backup backup)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			/*string query = "ALTER DATABASE TalentFinder SET OFFLINE WITH ROLLBACK IMMEDIATE ";
			query += string.Format(" RESTORE DATABASE TalentFinder FROM DISK = '{0}'", backup.PathBackupFile);
			query += " ALTER DATABASE TalentFinder SET ONLINE";*/
			string nombreBd = ConfigurationManager.AppSettings.Get("nombreBdPrincipal");
			string query = "ALTER DATABASE " + nombreBd + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
				"RESTORE DATABASE " + nombreBd + " FROM DISK = @ubicacion WITH REPLACE; " +
				"ALTER DATABASE " + nombreBd + " SET MULTI_USER;";
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@ubicacion", RUTA_BACKUPS +  backup.NombreArchivo + ".bak"));
			f = da.EscribirCmdText(query, parametros);
			da.Cerrar();
			return f;
		}

		private void CrearCarpetaBackup(string path)
		{
			if(!Directory.Exists(path))
				Directory.CreateDirectory(path);
		}

		public BackupMapper()
		{
			RUTA_BACKUPS = Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings["PathBackupFiles"].ToString());
			CrearCarpetaBackup(RUTA_BACKUPS);
		}
	}
}
