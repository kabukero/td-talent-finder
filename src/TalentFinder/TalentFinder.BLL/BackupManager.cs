using System;
using System.Collections.Generic;
using System.Configuration;
using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	public class BackupManager
	{
		private const string DATE_FORMAT_FOR_FILE = "yyyy_MM_dd_HH_mm_ss";
		BackupMapper backupMapper = new BackupMapper();

		public string GetNombreArchivoBackup()
		{
			return DateTime.Now.ToString(DATE_FORMAT_FOR_FILE) + ".bak";
		}

		public List<Backup> GetAllBackups()
		{
			return backupMapper.GetAllBackups();
		}

		public int RelizarBackup(Backup backup)
		{
			return backupMapper.RelizarBackup(backup);
		}

		public int RelizarRestore(Backup backup)
		{
			return backupMapper.RelizarRestore(backup);
		}
	}
}
