using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000471 RID: 1137
[Token(Token = "0x2000471")]
public class Thorns : Plant
{
	// Token: 0x060014F1 RID: 5361 RVA: 0x00073F30 File Offset: 0x00072130
	[Token(Token = "0x60014F1")]
	[Address(RVA = "0x4CF820", Offset = "0x4CDE20", VA = "0x1804CF820", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("explode");
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x00073F5C File Offset: 0x0007215C
	[Token(Token = "0x60014F2")]
	[Address(RVA = "0x4CF470", Offset = "0x4CDA70", VA = "0x1804CF470")]
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

	// Token: 0x060014F3 RID: 5363 RVA: 0x00073FFC File Offset: 0x000721FC
	[Token(Token = "0x60014F3")]
	[Address(RVA = "0x4CF800", Offset = "0x4CDE00", VA = "0x1804CF800", Slot = "35")]
	protected override bool OnCrash()
	{
		this.AnimExplode();
		return true;
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x00074010 File Offset: 0x00072210
	[Token(Token = "0x60014F4")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Thorns()
	{
	}
}
