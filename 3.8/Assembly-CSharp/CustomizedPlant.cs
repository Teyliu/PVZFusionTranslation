using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000DB RID: 219
[Token(Token = "0x20000DB")]
[Serializable]
public class CustomizedPlant
{
	// Token: 0x0600042C RID: 1068 RVA: 0x00015570 File Offset: 0x00013770
	[Token(Token = "0x600042C")]
	[Address(RVA = "0x4AF3D0", Offset = "0x4AD9D0", VA = "0x1804AF3D0")]
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

	// Token: 0x0600042D RID: 1069 RVA: 0x00015668 File Offset: 0x00013868
	[Token(Token = "0x600042D")]
	[Address(RVA = "0x4AF5B0", Offset = "0x4ADBB0", VA = "0x1804AF5B0")]
	public CustomizedPlant()
	{
		List<Empowerment> list = new List();
		this.empowerments = list;
		base..ctor();
	}

	// Token: 0x04000245 RID: 581
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000245")]
	public PlantType thePlantType;

	// Token: 0x04000246 RID: 582
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000246")]
	public float attackInterval;

	// Token: 0x04000247 RID: 583
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000247")]
	public int attackDamage;

	// Token: 0x04000248 RID: 584
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000248")]
	public int theHealth;

	// Token: 0x04000249 RID: 585
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000249")]
	public int cost;

	// Token: 0x0400024A RID: 586
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400024A")]
	public float cd;

	// Token: 0x0400024B RID: 587
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400024B")]
	public float strikeRate;

	// Token: 0x0400024C RID: 588
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400024C")]
	public float strikeDamage;

	// Token: 0x0400024D RID: 589
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400024D")]
	public float damageMultiplier;

	// Token: 0x0400024E RID: 590
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400024E")]
	public List<Empowerment> empowerments;
}
