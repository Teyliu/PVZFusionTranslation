using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200057A RID: 1402
[Token(Token = "0x200057A")]
public class SuperGatling : SuperSnowGatling
{
	// Token: 0x060019E8 RID: 6632 RVA: 0x0008B7B0 File Offset: 0x000899B0
	[Token(Token = "0x60019E8")]
	[Address(RVA = "0x4E9220", Offset = "0x4E7820", VA = "0x1804E9220", Slot = "71")]
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

	// Token: 0x060019E9 RID: 6633 RVA: 0x0008B820 File Offset: 0x00089A20
	[Token(Token = "0x60019E9")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SuperGatling()
	{
	}
}
