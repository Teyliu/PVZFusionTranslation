using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009AF RID: 2479
[Token(Token = "0x20009AF")]
public class RandomVectorGenerator : MonoBehaviour
{
	// Token: 0x060032C8 RID: 13000 RVA: 0x000F667C File Offset: 0x000F487C
	[Token(Token = "0x60032C8")]
	[Address(RVA = "0x7055D0", Offset = "0x7047D0", VA = "0x1807055D0")]
	public static Vector2[] GenerateRandomVectors(int numberOfVectorsToGenerate, float minX, float maxX, float minY, float maxY, float minDistance = 1.2f)
	{
		Vector2[] array = new Vector2[numberOfVectorsToGenerate];
		int num = 0;
		if (numberOfVectorsToGenerate > 0)
		{
			float num2 = global::UnityEngine.Random.Range(minX, minX);
			uint num3;
			if (num3 > (uint)0)
			{
				int num4 = 0;
				if (num4 < array.Length)
				{
					num4++;
				}
			}
			num++;
			array[0] = minY;
			float num5;
			array[0] = num5;
		}
		return array;
	}

	// Token: 0x060032C9 RID: 13001 RVA: 0x000F66D4 File Offset: 0x000F48D4
	[Token(Token = "0x60032C9")]
	[Address(RVA = "0x39B940", Offset = "0x39AB40", VA = "0x18039B940")]
	public RandomVectorGenerator()
	{
	}
}
