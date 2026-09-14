using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005AA RID: 1450
[Token(Token = "0x20005AA")]
public class SuperGatling : SuperSnowGatling
{
	// Token: 0x06001AC8 RID: 6856 RVA: 0x0008F89C File Offset: 0x0008DA9C
	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0x549090", Offset = "0x547690", VA = "0x180549090", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		float timer = this.timer;
		int num = 0;
		if (timer <= (float)num)
		{
		}
		List<BulletType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int num2 = list._size;
		num2 = global::UnityEngine.Random.Range(0, num2);
		return list[num2];
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x0008F90C File Offset: 0x0008DB0C
	[Token(Token = "0x6001AC9")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SuperGatling()
	{
	}
}
