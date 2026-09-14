using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000194 RID: 404
[Token(Token = "0x2000194")]
public class Bullet_shulkLeaf_ultimate : Bullet_pierce
{
	// Token: 0x06000717 RID: 1815 RVA: 0x00024B20 File Offset: 0x00022D20
	[Token(Token = "0x6000717")]
	[Address(RVA = "0x6BA0C0", Offset = "0x6B86C0", VA = "0x1806BA0C0", Slot = "9")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.sprite = child;
		throw new NullReferenceException();
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00024B50 File Offset: 0x00022D50
	[Token(Token = "0x6000718")]
	[Address(RVA = "0x7D98C0", Offset = "0x7D7EC0", VA = "0x1807D98C0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)2147483647L);
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00024B70 File Offset: 0x00022D70
	[Token(Token = "0x6000719")]
	[Address(RVA = "0x7DF0A0", Offset = "0x7DD6A0", VA = "0x1807DF0A0", Slot = "17")]
	protected override void MoveDieUpdate(Vector2 currentPosition)
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie == num)
		{
			base.MoveDieUpdate(num);
		}
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00024B98 File Offset: 0x00022D98
	[Token(Token = "0x600071A")]
	[Address(RVA = "0x7DEF50", Offset = "0x7DD550", VA = "0x1807DEF50", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		int num2 = 0;
		zombie.SetCold(15f, 1, num2 != 0);
		int num3 = 0;
		zombie.AddfreezeLevel(1, num3);
		base.PlaySound(zombie);
		Plant from = this.from;
		int num4 = 0;
		if (from != num4)
		{
			Plant from2 = this.from;
			if (from2 != 0)
			{
				from2.Charge();
			}
		}
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00024C14 File Offset: 0x00022E14
	[Token(Token = "0x600071B")]
	[Address(RVA = "0x7DF120", Offset = "0x7DD720", VA = "0x1807DF120", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		bool flag = Lawnf.TravelUltimate((UltiBuff)((uint)32));
		float theExistTime = this.theExistTime;
		if (!flag)
		{
			if (theExistTime <= 5f)
			{
				return;
			}
		}
		else if (theExistTime <= 15f)
		{
			return;
		}
		base.Die();
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x00024C54 File Offset: 0x00022E54
	[Token(Token = "0x600071C")]
	[Address(RVA = "0x7DE860", Offset = "0x7DCE60", VA = "0x1807DE860", Slot = "16")]
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

	// Token: 0x0600071D RID: 1821 RVA: 0x00024CB0 File Offset: 0x00022EB0
	[Token(Token = "0x600071D")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_shulkLeaf_ultimate()
	{
	}

	// Token: 0x04000390 RID: 912
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000390")]
	private Transform sprite;
}
