using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006B7 RID: 1719
[Token(Token = "0x20006B7")]
public class PortalBalloonZombie : IronBalloonZombie
{
	// Token: 0x060021A3 RID: 8611 RVA: 0x000B12DC File Offset: 0x000AF4DC
	[Token(Token = "0x60021A3")]
	[Address(RVA = "0x568AB0", Offset = "0x5670B0", VA = "0x180568AB0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (!this.fake)
		{
			Board board = this.board;
			CreateZombie instance = CreateZombie.Instance;
			int rowNum = board.rowNum;
			int num = global::UnityEngine.Random.Range(0, rowNum);
			Transform axis = this.axis;
			ZombieType theZombieType = this.theZombieType;
			int num2 = 0;
			Zombie zombie;
			if (zombie == 0)
			{
				this.fakeTarget = num2;
			}
			this.fakeTarget = zombie;
			this.fakeTarget.fake = true;
			this.fakeTarget.isSplited = true;
			this.fakeTarget.revived = true;
			PortalBalloonZombie portalBalloonZombie = this.fakeTarget;
			float num3 = portalBalloonZombie.theOriginSpeed * 3f;
			portalBalloonZombie.theOriginSpeed = num3;
		}
	}

	// Token: 0x060021A4 RID: 8612 RVA: 0x000B138C File Offset: 0x000AF58C
	[Token(Token = "0x60021A4")]
	[Address(RVA = "0x568CB0", Offset = "0x5672B0", VA = "0x180568CB0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (!this.fake)
		{
			return;
		}
	}

	// Token: 0x060021A5 RID: 8613 RVA: 0x000B13A4 File Offset: 0x000AF5A4
	[Token(Token = "0x60021A5")]
	[Address(RVA = "0x568370", Offset = "0x566970", VA = "0x180568370", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
		if (!this.fake)
		{
			return;
		}
	}

	// Token: 0x060021A6 RID: 8614 RVA: 0x000B13BC File Offset: 0x000AF5BC
	[Token(Token = "0x60021A6")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x060021A7 RID: 8615 RVA: 0x000B13CC File Offset: 0x000AF5CC
	[Token(Token = "0x60021A7")]
	[Address(RVA = "0x5682D0", Offset = "0x5668D0", VA = "0x1805682D0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060021A8 RID: 8616 RVA: 0x000B140C File Offset: 0x000AF60C
	[Token(Token = "0x60021A8")]
	[Address(RVA = "0x5688B0", Offset = "0x566EB0", VA = "0x1805688B0", Slot = "22")]
	protected override void OnFixedUpdate()
	{
		int num2;
		do
		{
			int num = 0;
			base.OnFixedUpdate();
			if (this.fake)
			{
				goto IL_005A;
			}
			int column = base.Column;
			int theZombieRow = this.theZombieRow;
			List<Plant> list = Lawnf.Get3x3Plants(column, theZombieRow);
			num2 = 0;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (flag2)
				{
				}
				bool flag3 = num.SetEffect((EffectType)((uint)102), 1f, 1f);
			}
		}
		while (num2 != 0);
		if (!this.fake)
		{
			return;
		}
		IL_005A:
		int column2 = base.Column;
		this.Fall();
	}

	// Token: 0x060021A9 RID: 8617 RVA: 0x000B1490 File Offset: 0x000AF690
	[Token(Token = "0x60021A9")]
	[Address(RVA = "0x568390", Offset = "0x566990", VA = "0x180568390", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		PortalBalloonZombie portalBalloonZombie = this.fakeTarget;
		int num = 0;
		if (portalBalloonZombie != num)
		{
			this.fakeTarget.Fall();
		}
	}

	// Token: 0x060021AA RID: 8618 RVA: 0x000B14C8 File Offset: 0x000AF6C8
	[Token(Token = "0x60021AA")]
	[Address(RVA = "0x568430", Offset = "0x566A30", VA = "0x180568430", Slot = "74")]
	public override void Fall()
	{
		this.fall = true;
		if (!this.fake)
		{
			int num = 0;
			base.ChangeStatus((ZombieStatus)num);
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			int num3 = 0;
			if (base.BoxType != BoxType.Water)
			{
				Animator anim = this.anim;
				this.theFirstArmorType = (Zombie.FirstArmorType)((ulong)3L);
				num3 += num3;
				this.theFirstArmorMaxHealth = num3;
				this.theFirstArmorHealth = num3;
				anim.SetTrigger("fall");
				base.UpdateHealthText();
				Transform axis = this.axis;
				ParticleManager instance = ParticleManager.Instance;
				Vector3 vector;
				float z = vector.z;
				int random = ListExtensions.GetRandom<int>(new List());
				int num4 = 0;
				base.KnockBack(0.5f, (Zombie.KnockBackReason)num4);
				uint num5;
				if (global::UnityEngine.Random.Range(0, (int)num5) != 0)
				{
					int theZombieRow = this.theZombieRow;
					int avaliableRow = base.GetAvaliableRow(theZombieRow);
					Transform axis2 = this.axis;
					this.theZombieRow = avaliableRow;
					Mouse instance2 = Mouse.Instance;
				}
				Transform axis3 = this.axis;
				ParticleManager instance3 = ParticleManager.Instance;
				return;
			}
		}
		else
		{
			uint num6;
			GameAPP.PlaySound((int)num6, 0.5f, 1f);
			Transform shoot = this.shoot;
			ParticleManager instance4 = ParticleManager.Instance;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060021AB RID: 8619 RVA: 0x000B15E8 File Offset: 0x000AF7E8
	[Token(Token = "0x60021AB")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "60")]
	public override GameObject DropArmor()
	{
		return null;
	}

	// Token: 0x060021AC RID: 8620 RVA: 0x000B15F8 File Offset: 0x000AF7F8
	[Token(Token = "0x60021AC")]
	[Address(RVA = "0x568CE0", Offset = "0x5672E0", VA = "0x180568CE0")]
	public PortalBalloonZombie()
	{
	}

	// Token: 0x0400111B RID: 4379
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400111B")]
	public bool fake;

	// Token: 0x0400111C RID: 4380
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400111C")]
	public PortalBalloonZombie fakeTarget;
}
