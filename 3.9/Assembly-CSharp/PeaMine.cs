using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000570 RID: 1392
[Token(Token = "0x2000570")]
public class PeaMine : PotatoMine
{
	// Token: 0x060019DD RID: 6621 RVA: 0x0008B578 File Offset: 0x00089778
	[Token(Token = "0x60019DD")]
	[Address(RVA = "0x538C40", Offset = "0x537240", VA = "0x180538C40", Slot = "16")]
	protected override void Update()
	{
		float attributeCountdown = this.attributeCountdown;
		int num = 0;
		if (attributeCountdown > (float)num)
		{
			float deltaTime = Time.deltaTime;
			base.AttributeCountdown = attributeCountdown;
		}
		int num2 = 0;
		base.AttributeCountdown = (float)num2;
		this.anim.SetTrigger("rise");
		base.Update();
		GameObject nearestZombie = base.GetNearestZombie();
		int num3 = 0;
		if (!(nearestZombie == num3))
		{
			Transform transform = nearestZombie.transform;
			Transform transform2 = base.transform;
			float num4;
			if (num > (int)num4 || num4 > 1f)
			{
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060019DE RID: 6622 RVA: 0x0008B604 File Offset: 0x00089804
	[Token(Token = "0x60019DE")]
	[Address(RVA = "0x538740", Offset = "0x536D40", VA = "0x180538740", Slot = "75")]
	public virtual Bullet AnimShoot()
	{
		Transform axis = this.axis;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x0008B64C File Offset: 0x0008984C
	[Token(Token = "0x60019DF")]
	[Address(RVA = "0x538AD0", Offset = "0x5370D0", VA = "0x180538AD0")]
	private void SetInterval()
	{
		float num2;
		do
		{
			GameObject nearestZombie = base.GetNearestZombie();
			int num = 0;
			if (nearestZombie == num)
			{
				goto IL_0043;
			}
			Transform transform = nearestZombie.transform;
			Transform transform2 = base.transform;
		}
		while (0 <= (int)num2 && num2 <= 1f);
		float num3 = (float)(0 * (int)(-1f));
		this.thePlantAttackInterval = num3;
		return;
		IL_0043:
		this.thePlantAttackInterval = 1.5f;
	}

	// Token: 0x060019E0 RID: 6624 RVA: 0x0008B6B0 File Offset: 0x000898B0
	[Token(Token = "0x60019E0")]
	[Address(RVA = "0x5388F0", Offset = "0x536EF0", VA = "0x1805388F0", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num = 0;
		Transform axis = this.axis;
		CreateBullet instance = CreateBullet.Instance;
		Transform axis2 = this.axis;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		num += 10;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x0008B70C File Offset: 0x0008990C
	[Token(Token = "0x60019E1")]
	[Address(RVA = "0x538870", Offset = "0x536E70", VA = "0x180538870", Slot = "73")]
	protected override void BombEffect()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x0008B73C File Offset: 0x0008993C
	[Token(Token = "0x60019E2")]
	[Address(RVA = "0x446250", Offset = "0x444850", VA = "0x180446250")]
	public PeaMine()
	{
	}
}
