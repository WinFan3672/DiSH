namespace Dish.Util
{
	public static class Chance
	{
		public static Random Rand = new Random();
		public static bool CoinFlip()
		{
			if (Rand.Next(2) == 1)
			{
				return true;
			}
			return false;
		}
	}
}
