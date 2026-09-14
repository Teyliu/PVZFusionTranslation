using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000624 RID: 1572
[Token(Token = "0x2000624")]
public class BedRockSnowZombie : SnowZombie
{
	// Token: 0x06001DBA RID: 7610 RVA: 0x0009FB44 File Offset: 0x0009DD44
	[Token(Token = "0x6001DBA")]
	[Address(RVA = "0x530C30", Offset = "0x52F230", VA = "0x180530C30", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001DBB RID: 7611 RVA: 0x0009FB60 File Offset: 0x0009DD60
	[Token(Token = "0x6001DBB")]
	[Address(RVA = "0x530BD0", Offset = "0x52F1D0", VA = "0x180530BD0", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
		base.SetMindControl(controlLevel);
		Lawnf.SetZombieHealth(this, 0.01f);
		this.theAttackDamage = controlLevel;
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x0009FB88 File Offset: 0x0009DD88
	[Token(Token = "0x6001DBC")]
	[Address(RVA = "0x530B70", Offset = "0x52F170", VA = "0x180530B70", Slot = "22")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
		int num = 0;
		int column = base.Column;
		int num2 = this.board.columnNum;
		num2 -= num;
		float attributeCountDown = this.attributeCountDown;
		int num3 = 0;
		if (attributeCountDown > (float)num3)
		{
			this.attributeCountDown = 0.01f;
		}
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x0009FBD4 File Offset: 0x0009DDD4
	[Token(Token = "0x6001DBD")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x06001DBE RID: 7614 RVA: 0x0009FBE4 File Offset: 0x0009DDE4
	[Token(Token = "0x6001DBE")]
	[Address(RVA = "0x5309F0", Offset = "0x52EFF0", VA = "0x1805309F0", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		int column = base.Column;
		Board board = this.board;
		float value = global::UnityEngine.Random.value;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001DBF RID: 7615 RVA: 0x0009FC2C File Offset: 0x0009DE2C
	[Token(Token = "0x6001DBF")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06001DC0 RID: 7616 RVA: 0x0009FC3C File Offset: 0x0009DE3C
	[Token(Token = "0x6001DC0")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x0009FC4C File Offset: 0x0009DE4C
	[Token(Token = "0x6001DC1")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06001DC2 RID: 7618 RVA: 0x0009FC5C File Offset: 0x0009DE5C
	[Token(Token = "0x6001DC2")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001DC3 RID: 7619 RVA: 0x0009FC6C File Offset: 0x0009DE6C
	[Token(Token = "0x6001DC3")]
	[Address(RVA = "0x530C60", Offset = "0x52F260", VA = "0x180530C60")]
	public BedRockSnowZombie()
	{
	}
}
