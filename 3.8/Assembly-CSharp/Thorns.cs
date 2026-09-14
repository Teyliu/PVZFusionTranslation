using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000451 RID: 1105
[Token(Token = "0x2000451")]
public class Thorns : Plant
{
	// Token: 0x06001461 RID: 5217 RVA: 0x00071BE0 File Offset: 0x0006FDE0
	[Token(Token = "0x6001461")]
	[Address(RVA = "0x477F60", Offset = "0x476560", VA = "0x180477F60", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("explode");
	}

	// Token: 0x06001462 RID: 5218 RVA: 0x00071C0C File Offset: 0x0006FE0C
	[Token(Token = "0x6001462")]
	[Address(RVA = "0x477BB0", Offset = "0x4761B0", VA = "0x180477BB0")]
	private void AnimExplode()
	{
		int num = 0;
		int num2 = 0;
		base.Die((Plant.DieReason)num2);
		Transform axis = this.axis;
		CreateBullet instance = CreateBullet.Instance;
		if (18446744073709551612UL > (ulong)4L)
		{
			int attackDamage = this.attackDamage;
			Bullet bullet;
			bullet.Damage = attackDamage;
			PlantType thePlantType = this.thePlantType;
			bullet.fromType = thePlantType;
			Transform transform = bullet.transform;
		}
		int num3 = 0;
		Bullet bullet2;
		bullet2.Damage = num3;
		PlantType thePlantType2 = this.thePlantType;
		int num4 = 0;
		bullet2.fromType = thePlantType2;
		bullet2.transform.rotation = num4;
		num++;
		num += 30;
		ParticleManager instance2 = ParticleManager.Instance;
	}

	// Token: 0x06001463 RID: 5219 RVA: 0x00071CAC File Offset: 0x0006FEAC
	[Token(Token = "0x6001463")]
	[Address(RVA = "0x477F40", Offset = "0x476540", VA = "0x180477F40", Slot = "36")]
	protected override bool OnCrash()
	{
		this.AnimExplode();
		return true;
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x00071CC0 File Offset: 0x0006FEC0
	[Token(Token = "0x6001464")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Thorns()
	{
	}
}
