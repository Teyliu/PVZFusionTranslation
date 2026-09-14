using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000542 RID: 1346
[Token(Token = "0x2000542")]
public class PeaMine : PotatoMine
{
	// Token: 0x06001908 RID: 6408 RVA: 0x000877D0 File Offset: 0x000859D0
	[Token(Token = "0x6001908")]
	[Address(RVA = "0x4DB4C0", Offset = "0x4D9AC0", VA = "0x1804DB4C0", Slot = "16")]
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

	// Token: 0x06001909 RID: 6409 RVA: 0x0008785C File Offset: 0x00085A5C
	[Token(Token = "0x6001909")]
	[Address(RVA = "0x4DAFC0", Offset = "0x4D95C0", VA = "0x1804DAFC0", Slot = "76")]
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

	// Token: 0x0600190A RID: 6410 RVA: 0x000878A4 File Offset: 0x00085AA4
	[Token(Token = "0x600190A")]
	[Address(RVA = "0x4DB350", Offset = "0x4D9950", VA = "0x1804DB350")]
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

	// Token: 0x0600190B RID: 6411 RVA: 0x00087908 File Offset: 0x00085B08
	[Token(Token = "0x600190B")]
	[Address(RVA = "0x4DB170", Offset = "0x4D9770", VA = "0x1804DB170", Slot = "52")]
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

	// Token: 0x0600190C RID: 6412 RVA: 0x00087964 File Offset: 0x00085B64
	[Token(Token = "0x600190C")]
	[Address(RVA = "0x4DB0F0", Offset = "0x4D96F0", VA = "0x1804DB0F0", Slot = "74")]
	protected override void BombEffect()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x0600190D RID: 6413 RVA: 0x00087994 File Offset: 0x00085B94
	[Token(Token = "0x600190D")]
	[Address(RVA = "0x42A010", Offset = "0x428610", VA = "0x18042A010")]
	public PeaMine()
	{
	}
}
