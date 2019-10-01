using System;
using System.Configuration;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	public class BackupManager
	{
		BackupMapper backupMapper = new BackupMapper();

		public int RelizarBackup(Backup backup)
		{
			backup.PathBackupFile += string.Format("/{0}-{1}.bak", ConfigurationManager.AppSettings["AppName"].ToString(), DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
			return backupMapper.RelizarBackup(backup);
		}
		public int RelizarRestore(Backup backup)
		{
			return backupMapper.RelizarRestore(backup);
		}
	}
}
