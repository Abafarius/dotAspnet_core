namespace LifeTime
{
	public class Context
	{
		public int DataRow { get; set; }
		public Context()
		{
			DataRow = new Random().Next();
		}
	}
}
