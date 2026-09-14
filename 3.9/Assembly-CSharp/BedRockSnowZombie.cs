using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000659 RID: 1625
[Token(Token = "0x2000659")]
public class BedRockSnowZombie : SnowZombie
{
	// Token: 0x06001EB9 RID: 7865 RVA: 0x000A4148 File Offset: 0x000A2348
	[Token(Token = "0x6001EB9")]
	[Address(RVA = "0x5877B0", Offset = "0x585DB0", VA = "0x1805877B0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001EBA RID: 7866 RVA: 0x000A4164 File Offset: 0x000A2364
	[Token(Token = "0x6001EBA")]
	[Address(RVA = "0x587750", Offset = "0x585D50", VA = "0x180587750", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
		base.SetMindControl(controlLevel);
		Lawnf.SetZombieHealth(this, 0.01f);
		this.theAttackDamage = controlLevel;
	}

	// Token: 0x06001EBB RID: 7867 RVA: 0x000A418C File Offset: 0x000A238C
	[Token(Token = "0x6001EBB")]
	[Address(RVA = "0x5876F0", Offset = "0x585CF0", VA = "0x1805876F0", Slot = "23")]
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

	// Token: 0x06001EBC RID: 7868 RVA: 0x000A41D8 File Offset: 0x000A23D8
	[Token(Token = "0x6001EBC")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x06001EBD RID: 7869 RVA: 0x000A41E8 File Offset: 0x000A23E8
	[Token(Token = "0x6001EBD")]
	[Address(RVA = "0x587570", Offset = "0x585B70", VA = "0x180587570", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		int column = base.Column;
		Board board = this.board;
		float value = global::UnityEngine.Random.value;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001EBE RID: 7870 RVA: 0x000A4230 File Offset: 0x000A2430
	[Token(Token = "0x6001EBE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06001EBF RID: 7871 RVA: 0x000A4240 File Offset: 0x000A2440
	[Token(Token = "0x6001EBF")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
	}

	// Token: 0x06001EC0 RID: 7872 RVA: 0x000A4250 File Offset: 0x000A2450
	[Token(Token = "0x6001EC0")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06001EC1 RID: 7873 RVA: 0x000A4260 File Offset: 0x000A2460
	[Token(Token = "0x6001EC1")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001EC2 RID: 7874 RVA: 0x000A4270 File Offset: 0x000A2470
	[Token(Token = "0x6001EC2")]
	[Address(RVA = "0x5877E0", Offset = "0x585DE0", VA = "0x1805877E0")]
	public BedRockSnowZombie()
	{
	}
}
