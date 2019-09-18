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
	}
}
