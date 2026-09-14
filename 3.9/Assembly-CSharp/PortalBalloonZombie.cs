using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006EF RID: 1775
[Token(Token = "0x20006EF")]
public class PortalBalloonZombie : IronBalloonZombie
{
	// Token: 0x060022BD RID: 8893 RVA: 0x000B5FE4 File Offset: 0x000B41E4
	[Token(Token = "0x60022BD")]
	[Address(RVA = "0x5CC370", Offset = "0x5CA970", VA = "0x1805CC370", Slot = "16")]
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

	// Token: 0x060022BE RID: 8894 RVA: 0x000B6094 File Offset: 0x000B4294
	[Token(Token = "0x60022BE")]
	[Address(RVA = "0x5CC570", Offset = "0x5CAB70", VA = "0x1805CC570", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (!this.fake)
		{
			return;
		}
	}

	// Token: 0x060022BF RID: 8895 RVA: 0x000B60AC File Offset: 0x000B42AC
	[Token(Token = "0x60022BF")]
	[Address(RVA = "0x5CBC30", Offset = "0x5CA230", VA = "0x1805CBC30", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
		if (!this.fake)
		{
			return;
		}
	}

	// Token: 0x060022C0 RID: 8896 RVA: 0x000B60C4 File Offset: 0x000B42C4
	[Token(Token = "0x60022C0")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x060022C1 RID: 8897 RVA: 0x000B60D4 File Offset: 0x000B42D4
	[Token(Token = "0x60022C1")]
	[Address(RVA = "0x5CBB90", Offset = "0x5CA190", VA = "0x1805CBB90", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060022C2 RID: 8898 RVA: 0x000B6114 File Offset: 0x000B4314
	[Token(Token = "0x60022C2")]
	[Address(RVA = "0x5CC170", Offset = "0x5CA770", VA = "0x1805CC170", Slot = "23")]
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

	// Token: 0x060022C3 RID: 8899 RVA: 0x000B6198 File Offset: 0x000B4398
	[Token(Token = "0x60022C3")]
	[Address(RVA = "0x5CBC50", Offset = "0x5CA250", VA = "0x1805CBC50", Slot = "29")]
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

	// Token: 0x060022C4 RID: 8900 RVA: 0x000B61D0 File Offset: 0x000B43D0
	[Token(Token = "0x60022C4")]
	[Address(RVA = "0x5CBCF0", Offset = "0x5CA2F0", VA = "0x1805CBCF0", Slot = "76")]
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

	// Token: 0x060022C5 RID: 8901 RVA: 0x000B62F0 File Offset: 0x000B44F0
	[Token(Token = "0x60022C5")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "62")]
	public override GameObject DropArmor()
	{
		return null;
	}

	// Token: 0x060022C6 RID: 8902 RVA: 0x000B6300 File Offset: 0x000B4500
	[Token(Token = "0x60022C6")]
	[Address(RVA = "0x5CC5A0", Offset = "0x5CABA0", VA = "0x1805CC5A0")]
	public PortalBalloonZombie()
	{
	}

	// Token: 0x040011E8 RID: 4584
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40011E8")]
	public bool fake;

	// Token: 0x040011E9 RID: 4585
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x40011E9")]
	public PortalBalloonZombie fakeTarget;
}
