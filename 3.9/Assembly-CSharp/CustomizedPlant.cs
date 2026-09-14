using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000E0 RID: 224
[Token(Token = "0x20000E0")]
[Serializable]
public class CustomizedPlant
{
	// Token: 0x06000447 RID: 1095 RVA: 0x00015A08 File Offset: 0x00013C08
	[Token(Token = "0x6000447")]
	[Address(RVA = "0x4EEA60", Offset = "0x4ED060", VA = "0x1804EEA60")]
	public void Copy(CustomizedPlant data)
	{
		while (data != 0)
		{
			PlantType plantType = data.thePlantType;
			this.thePlantType = plantType;
			float num = data.attackInterval;
			this.attackInterval = num;
			int num2 = data.attackDamage;
			this.attackDamage = num2;
			int num3 = data.theHealth;
			this.theHealth = num3;
			int num4 = data.cost;
			this.cost = num4;
			float num5 = data.cd;
			this.cd = num5;
			float num6 = data.strikeRate;
			this.strikeRate = num6;
			float num7 = data.strikeDamage;
			this.strikeDamage = num7;
			float num8 = data.damageMultiplier;
			this.damageMultiplier = num8;
			this.empowerments._size = (int)((ulong)0L);
			List<Empowerment> list = data.empowerments;
			bool flag;
			if (flag)
			{
				List<Empowerment> list2 = this.empowerments;
				int num9 = list2._size + 1;
				list2._size = num9;
			}
			ulong num10;
			if (num10 == (ulong)0L)
			{
				break;
			}
		}
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x00015B00 File Offset: 0x00013D00
	[Token(Token = "0x6000448")]
	[Address(RVA = "0x4EEC40", Offset = "0x4ED240", VA = "0x1804EEC40")]
	public CustomizedPlant()
	{
		List<Empowerment> list = new List();
		this.empowerments = list;
		base..ctor();
	}

	// Token: 0x04000253 RID: 595
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000253")]
	public PlantType thePlantType;

	// Token: 0x04000254 RID: 596
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000254")]
	public float attackInterval;

	// Token: 0x04000255 RID: 597
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000255")]
	public int attackDamage;

	// Token: 0x04000256 RID: 598
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000256")]
	public int theHealth;

	// Token: 0x04000257 RID: 599
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000257")]
	public int cost;

	// Token: 0x04000258 RID: 600
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000258")]
	public float cd;

	// Token: 0x04000259 RID: 601
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000259")]
	public float strikeRate;

	// Token: 0x0400025A RID: 602
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400025A")]
	public float strikeDamage;

	// Token: 0x0400025B RID: 603
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400025B")]
	public float damageMultiplier;

	// Token: 0x0400025C RID: 604
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400025C")]
	public List<Empowerment> empowerments;
}
