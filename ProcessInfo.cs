namespace WpAttach
{
	public class ProcessInfo
	{
		public int PID { get; set; }
		public string Owner { get; set; }
		public EnvDTE.Process EnvDteProcess { get; set; }
	}
}
