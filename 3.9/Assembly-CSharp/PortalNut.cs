using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200041B RID: 1051
[Token(Token = "0x200041B")]
public class PortalNut : WallNut
{
	// Token: 0x06001355 RID: 4949 RVA: 0x0006C240 File Offset: 0x0006A440
	[Token(Token = "0x6001355")]
	[Address(RVA = "0x4B2740", Offset = "0x4B0D40", VA = "0x1804B2740", Slot = "33")]
	public override void Die(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (!this.restored && reason == Plant.DieReason.Default)
		{
			this.restored = true;
		}
		base.Die(reason);
	}

	// Token: 0x06001356 RID: 4950 RVA: 0x0006C268 File Offset: 0x0006A468
	[Token(Token = "0x6001356")]
	[Address(RVA = "0x4B27E0", Offset = "0x4B0DE0", VA = "0x1804B27E0", Slot = "69")]
	protected virtual void Revive()
	{
		this.RestoreHealthFromSnapshot();
		base.UpdateText();
		base.ReplaceSprite();
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, thePlantRow, num3 != 0UL, (float)num2);
		this.invincibleTimer = 3f;
		this.flashCountDown = 3f;
	}

	// Token: 0x06001357 RID: 4951 RVA: 0x0006C2D0 File Offset: 0x0006A4D0
	[Token(Token = "0x6001357")]
	[Address(RVA = "0x4B2B00", Offset = "0x4B1100", VA = "0x1804B2B00", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		float num = this.invincibleTimer;
		int num2 = 0;
		if (num <= (float)num2)
		{
			return;
		}
	}

	// Token: 0x06001358 RID: 4952 RVA: 0x0006C2EC File Offset: 0x0006A4EC
	[Token(Token = "0x6001358")]
	[Address(RVA = "0x4B2B30", Offset = "0x4B1130", VA = "0x1804B2B30", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x06001359 RID: 4953 RVA: 0x0006C300 File Offset: 0x0006A500
	[Token(Token = "0x6001359")]
	[Address(RVA = "0x4B28F0", Offset = "0x4B0EF0", VA = "0x1804B28F0", Slot = "70")]
	protected virtual void SnapShot(int health)
	{
		float time = Time.time;
		List<ValueTuple<float, int>> list = this.healthSnapshots;
		float time2 = Time.time;
		int size = list._size;
		ulong num2;
		ulong num = num2 + 1UL;
		list._size = (int)num;
		float time3 = Time.time;
		this.lastSnapshotTime = time3;
		List<ValueTuple<float, int>> list2 = this.healthSnapshots;
		float num3 = Time.time;
		List<ValueTuple<float, int>> list3 = this.healthSnapshots;
		int num4 = 0;
		ValueTuple<float, int> valueTuple = list3[num4];
		if (num3 > 3f)
		{
			List<ValueTuple<float, int>> list4 = this.healthSnapshots;
			int num5 = 0;
			list4.RemoveAt(num5);
			List<ValueTuple<float, int>> list5 = this.healthSnapshots;
		}
		float num6 = this.invincibleTimer;
		int num7 = 0;
		if (num6 > (float)num7)
		{
			num3 = num6;
			float deltaTime = Time.deltaTime;
			this.invincibleTimer = num3;
			this.invincibleTimer = 0f;
		}
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x0006C3D4 File Offset: 0x0006A5D4
	[Token(Token = "0x600135A")]
	[Address(RVA = "0x4B2770", Offset = "0x4B0D70", VA = "0x1804B2770", Slot = "71")]
	protected virtual void RestoreHealthFromSnapshot()
	{
		List<ValueTuple<float, int>> list = this.healthSnapshots;
		int num = 0;
		ValueTuple<float, int> valueTuple = list[num];
		this.thePlantHealth = valueTuple;
	}

	// Token: 0x0600135B RID: 4955 RVA: 0x0006C400 File Offset: 0x0006A600
	[Token(Token = "0x600135B")]
	[Address(RVA = "0x4B2BC0", Offset = "0x4B11C0", VA = "0x1804B2BC0")]
	public PortalNut()
	{
		List<ValueTuple<float, int>> list = new List();
		this.healthSnapshots = list;
		base..ctor();
	}

	// Token: 0x04000CB2 RID: 3250
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CB2")]
	private readonly float snapshotInterval = 0.1f;

	// Token: 0x04000CB3 RID: 3251
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000CB3")]
	private float lastSnapshotTime;

	// Token: 0x04000CB4 RID: 3252
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CB4")]
	[TupleElementNames(new string[] { "time", "health" })]
	protected readonly List<ValueTuple<float, int>> healthSnapshots;

	// Token: 0x04000CB5 RID: 3253
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CB5")]
	private bool restored;

	// Token: 0x04000CB6 RID: 3254
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000CB6")]
	protected float invincibleTimer;
}
