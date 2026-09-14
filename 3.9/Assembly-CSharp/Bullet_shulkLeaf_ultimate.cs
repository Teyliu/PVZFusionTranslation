using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200019B RID: 411
[Token(Token = "0x200019B")]
public class Bullet_shulkLeaf_ultimate : Bullet_pierce
{
	// Token: 0x06000724 RID: 1828 RVA: 0x0002445C File Offset: 0x0002265C
	[Token(Token = "0x6000724")]
	[Address(RVA = "0x6E4FB0", Offset = "0x6E35B0", VA = "0x1806E4FB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.sprite = child;
		throw new NullReferenceException();
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x0002448C File Offset: 0x0002268C
	[Token(Token = "0x6000725")]
	[Address(RVA = "0x807150", Offset = "0x805750", VA = "0x180807150", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2147483647L);
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x000244AC File Offset: 0x000226AC
	[Token(Token = "0x6000726")]
	[Address(RVA = "0x80C800", Offset = "0x80AE00", VA = "0x18080C800", Slot = "16")]
	protected override void MoveDieUpdate(Vector2 currentPosition)
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie == num)
		{
			base.MoveDieUpdate(num);
		}
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x000244D4 File Offset: 0x000226D4
	[Token(Token = "0x6000727")]
	[Address(RVA = "0x80C690", Offset = "0x80AC90", VA = "0x18080C690", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int shootingLevel = this.shootingLevel;
		int num = this._damage;
		num -= shootingLevel;
		PlantType fromType = this.fromType;
		int num2 = 0;
		uint num3;
		zombie.SetCold(15f, (int)num3, num2 != 0);
		int num4 = 0;
		uint num5;
		zombie.AddfreezeLevel((int)num5, num4);
		base.PlaySound(zombie);
		Plant from = this.from;
		int num6 = 0;
		if (from != num6)
		{
			Plant from2 = this.from;
			if (from2 != 0)
			{
				from2.Charge();
			}
		}
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00024554 File Offset: 0x00022754
	[Token(Token = "0x6000728")]
	[Address(RVA = "0x80C880", Offset = "0x80AE80", VA = "0x18080C880", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		bool flag = Lawnf.TravelUltimate((UltiBuff)((uint)32));
		float theExistTime = this.theExistTime;
		if (!flag)
		{
			return;
		}
		base.Die();
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00024584 File Offset: 0x00022784
	[Token(Token = "0x6000729")]
	[Address(RVA = "0x80BFD0", Offset = "0x80A5D0", VA = "0x18080BFD0", Slot = "15")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Vector2 velocity = this.rb.velocity;
		Transform transform = this.sprite;
		int num = 0;
		if (velocity <= num)
		{
			float deltaTime = Time.deltaTime;
		}
		float num2 = Time.deltaTime * -600f;
		int num3 = 0;
		int num4 = 0;
		transform.Rotate((float)num4, (float)num3, num2);
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x000245E0 File Offset: 0x000227E0
	[Token(Token = "0x600072A")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_shulkLeaf_ultimate()
	{
	}

	// Token: 0x04000399 RID: 921
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000399")]
	private Transform sprite;
}
