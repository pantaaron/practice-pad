namespace PracticePad.Session
{
	public static class LoginSession
	{
		public static string UserName { get; private set; }

		public static Result Login(string username)
		{
			bool isValid = true;
			if (isValid)
			{
				UserName = username;
				return Result.Success;
			}
			return Result.Failure;
		}
	}
}