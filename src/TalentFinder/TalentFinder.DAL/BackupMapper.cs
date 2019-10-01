using System.Collections.Generic;
using System.Data.SqlClient;
using TalentFinder.BE;

namespace TalentFinder.DAL
{
	public class BackupMapper
	{
		public int RelizarBackup(Backup backup)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(da.CrearParametro("@PathBackupFile", backup.PathBackupFile));
			f = da.LeerEscalar("RealizarBackup", parametros);
			da.Cerrar();
			return f;
		}

		public int RelizarRestore(Backup backup)
		{
			int f = 0;
			DataAccessManager da = new DataAccessManager();
			da.Abrir();
			string query = "ALTER DATABASE TalentFinder2 SET OFFLINE WITH ROLLBACK IMMEDIATE ";
			query += string.Format(" RESTORE DATABASE TalentFinder2 FROM DISK = '{0}'", backup.PathBackupFile);
			query += " ALTER DATABASE TalentFinder2 SET ONLINE";
			f = da.EscribirCmdText(query);
			da.Cerrar();
			return f;
		}
	}
}
