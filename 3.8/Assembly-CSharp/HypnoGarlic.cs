using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A1 RID: 929
[Token(Token = "0x20003A1")]
public class HypnoGarlic : Plant
{
	// Token: 0x06001115 RID: 4373 RVA: 0x00061448 File Offset: 0x0005F648
	[Token(Token = "0x6001115")]
	[Address(RVA = "0x43BA20", Offset = "0x43A020", VA = "0x18043BA20", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 0.5f;
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x00061468 File Offset: 0x0005F668
	[Token(Token = "0x6001116")]
	[Address(RVA = "0x43B890", Offset = "0x439E90", VA = "0x18043B890", Slot = "40")]
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

	// Token: 0x06001117 RID: 4375 RVA: 0x000614C0 File Offset: 0x0005F6C0
	[Token(Token = "0x6001117")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public HypnoGarlic()
	{
	}
}
