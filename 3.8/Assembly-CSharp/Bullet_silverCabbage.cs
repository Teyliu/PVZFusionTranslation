using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000198 RID: 408
[Token(Token = "0x2000198")]
public class Bullet_silverCabbage : Bullet_cabbage
{
	// Token: 0x06000727 RID: 1831 RVA: 0x00024FE0 File Offset: 0x000231E0
	[Token(Token = "0x6000727")]
	[Address(RVA = "0x7DFC70", Offset = "0x7DE270", VA = "0x1807DFC70", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		this.miusa = false;
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00024FFC File Offset: 0x000231FC
	[Token(Token = "0x6000728")]
	[Address(RVA = "0x7DFB40", Offset = "0x7DE140", VA = "0x1807DFB40", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		if (this.miusa)
		{
			int theFirstArmorHealth = zombie.theFirstArmorHealth;
		}
		PlantType fromType = this.fromType;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00025044 File Offset: 0x00023244
	[Token(Token = "0x6000729")]
	[Address(RVA = "0x7DFA30", Offset = "0x7DE030", VA = "0x1807DFA30", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x00025078 File Offset: 0x00023278
	[Token(Token = "0x600072A")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_silverCabbage()
	{
	}

	// Token: 0x04000392 RID: 914
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000392")]
	public bool miusa;
}
