using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009B0 RID: 2480
[Token(Token = "0x20009B0")]
public static class MapDataReader
{
	// Token: 0x060032D1 RID: 13009 RVA: 0x0010DC60 File Offset: 0x0010BE60
	[Token(Token = "0x60032D1")]
	[Address(RVA = "0x7033D0", Offset = "0x7019D0", VA = "0x1807033D0")]
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
