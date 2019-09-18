using TalentFinder.BE;
using TalentFinder.DAL;

namespace TalentFinder.BLL
{
	public class BackupManager
	{
		BackupMapper backupMapper = new BackupMapper();

		public int RelizarBackup(Backup backup)
		{
			return backupMapper.RelizarBackup(backup);
		}
	}
}
