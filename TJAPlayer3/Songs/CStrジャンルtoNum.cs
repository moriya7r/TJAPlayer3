namespace TJAPlayer3
{
	internal static class CStrジャンルtoNum
	{
		internal static int ForAC8_14(string strジャンル)
		{
			switch (strジャンル)
			{
				case "アニメ":
					return 0;
				case "J-POP":
					return 1;
				case "ゲームミュージック":
					return 2;
				case "ナムコオリジナル":
					return 3;
				case "クラシック":
					return 4;
				case "バーチャルタレントソング":
					return 5;
				case "バラエティ":
					return 6;
				case "ボーカロイド":
				case "VOCALOID":
					return 7;
				default:
					return 8;
			}
		}

		internal static int ForAC15(string strジャンル)
		{
			switch (strジャンル)
			{
				case "ポップス":
					return 0;
				case "アニメ":
					return 1;
				case "ネットミュージック":
					return 2;
				case "バーチャルタレントソング":
					return 3;
				case "バラエティ":
					return 4;
				case "クラシック":
					return 5;
				case "ゲームミュージック":
					return 6;
				case "フリーミュージック":
					return 7;
				default:
					return 8;
			}
		}
	}
}