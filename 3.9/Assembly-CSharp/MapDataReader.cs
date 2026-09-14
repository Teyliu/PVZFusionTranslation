using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009EC RID: 2540
[Token(Token = "0x20009EC")]
public static class MapDataReader
{
	// Token: 0x06003405 RID: 13317 RVA: 0x00112C78 File Offset: 0x00110E78
	[Token(Token = "0x6003405")]
	[Address(RVA = "0x7688E0", Offset = "0x766EE0", VA = "0x1807688E0")]
	public static MapData GetMapData(LevelType levelType, int level)
	{
		TextAsset textAsset;
		int num2;
		do
		{
			int num = 0;
			if (levelType == LevelType.Challenge)
			{
				Type typeFromHandle = typeof(ChallengeLevel);
			}
			string name = Enum.GetName(num, "/");
			Type typeFromHandle2 = typeof(LevelType);
			string name2 = Enum.GetName(typeFromHandle2, typeFromHandle2);
			textAsset = Resources.Load<TextAsset>("MapData/" + name2 + "/" + name);
			num2 = 0;
		}
		while (textAsset != num2);
		return JsonUtility.FromJson<MapData>(0);
	}
}
