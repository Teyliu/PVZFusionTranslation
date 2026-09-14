using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B5 RID: 949
[Token(Token = "0x20003B5")]
public class HypnoGarlic : Plant
{
	// Token: 0x06001171 RID: 4465 RVA: 0x00062AA0 File Offset: 0x00060CA0
	[Token(Token = "0x6001171")]
	[Address(RVA = "0x48F270", Offset = "0x48D870", VA = "0x18048F270", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 0.5f;
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x00062AC0 File Offset: 0x00060CC0
	[Token(Token = "0x6001172")]
	[Address(RVA = "0x48F0E0", Offset = "0x48D6E0", VA = "0x18048F0E0", Slot = "39")]
	protected override void AttributeEvent()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
				}
			}
			num++;
		}
		base.AttributeCountdown = 0.5f;
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x00062B18 File Offset: 0x00060D18
	[Token(Token = "0x6001173")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public HypnoGarlic()
	{
	}
}
