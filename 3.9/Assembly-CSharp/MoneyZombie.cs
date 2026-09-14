using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006DA RID: 1754
[Token(Token = "0x20006DA")]
public class MoneyZombie : Zombie
{
	// Token: 0x06002222 RID: 8738 RVA: 0x000B3980 File Offset: 0x000B1B80
	[Token(Token = "0x6002222")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x000B3990 File Offset: 0x000B1B90
	[Token(Token = "0x6002223")]
	[Address(RVA = "0x5C42F0", Offset = "0x5C28F0", VA = "0x1805C42F0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		this.flashTime = 0.3f;
	}

	// Token: 0x06002224 RID: 8740 RVA: 0x000B39A8 File Offset: 0x000B1BA8
	[Token(Token = "0x6002224")]
	[Address(RVA = "0x5C4320", Offset = "0x5C2920", VA = "0x1805C4320", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		if (this.existTime > 15f)
		{
			this.beforeDying = true;
		}
	}

	// Token: 0x06002225 RID: 8741 RVA: 0x000B39D0 File Offset: 0x000B1BD0
	[Token(Token = "0x6002225")]
	[Address(RVA = "0x5C4230", Offset = "0x5C2830", VA = "0x1805C4230", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(2);
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x000B39E4 File Offset: 0x000B1BE4
	[Token(Token = "0x6002226")]
	[Address(RVA = "0x5C4240", Offset = "0x5C2840", VA = "0x1805C4240", Slot = "22")]
	protected override void PositionUpdate()
	{
		base.PositionUpdate();
		Transform axis = this.axis;
		float plantMaxVisionX = this.board.plantMaxVisionX;
		Transform axis2 = this.axis;
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x000B3A1C File Offset: 0x000B1C1C
	[Token(Token = "0x6002227")]
	[Address(RVA = "0x5C3F40", Offset = "0x5C2540", VA = "0x1805C3F40", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		Transform axis = this.axis;
		int num = 0;
		Transform axis2 = this.axis;
		CreateItem instance = CreateItem.Instance;
		int num2 = 0;
		int num3 = 0;
		Vector3 vector;
		GameObject gameObject = instance.SetCoin(num3, num2, 36, num, vector, num != 0);
		Transform axis3 = this.axis;
		CreateItem instance2 = CreateItem.Instance;
		int num4 = 0;
		int num5 = 0;
		Vector3 vector2;
		GameObject gameObject2 = instance2.SetCoin(num5, num4, 36, num, vector2, num != 0);
		Transform axis4 = this.axis;
		CreateItem instance3 = CreateItem.Instance;
		int num6 = 0;
		int num7 = 0;
		Vector3 vector3;
		GameObject gameObject3 = instance3.SetCoin(num7, num6, 36, num, vector3, num != 0);
		GameAPP.PlaySound(117, 0.5f, 1f);
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x000B3AC4 File Offset: 0x000B1CC4
	[Token(Token = "0x6002228")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x000B3AD4 File Offset: 0x000B1CD4
	[Token(Token = "0x6002229")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "61")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x000B3AE4 File Offset: 0x000B1CE4
	[Token(Token = "0x600222A")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "54")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x000B3AF4 File Offset: 0x000B1CF4
	[Token(Token = "0x600222B")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "60")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x000B3B04 File Offset: 0x000B1D04
	[Token(Token = "0x600222C")]
	[Address(RVA = "0x5C43A0", Offset = "0x5C29A0", VA = "0x1805C43A0")]
	public MoneyZombie()
	{
	}
}
