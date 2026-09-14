using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000400 RID: 1024
[Token(Token = "0x2000400")]
public class PortalNut : WallNut
{
	// Token: 0x060012DF RID: 4831 RVA: 0x0006A40C File Offset: 0x0006860C
	[Token(Token = "0x60012DF")]
	[Address(RVA = "0x45C250", Offset = "0x45A850", VA = "0x18045C250", Slot = "34")]
	public override void Die(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (!this.restored && reason == Plant.DieReason.Default)
		{
			this.restored = true;
		}
		base.Die(reason);
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x0006A434 File Offset: 0x00068634
	[Token(Token = "0x60012E0")]
	[Address(RVA = "0x45C2F0", Offset = "0x45A8F0", VA = "0x18045C2F0", Slot = "70")]
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

	// Token: 0x060012E1 RID: 4833 RVA: 0x0006A49C File Offset: 0x0006869C
	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x45C610", Offset = "0x45AC10", VA = "0x18045C610", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		float num = this.invincibleTimer;
		int num2 = 0;
		if (num <= (float)num2)
		{
			return;
		}
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x0006A4B8 File Offset: 0x000686B8
	[Token(Token = "0x60012E2")]
	[Address(RVA = "0x45C640", Offset = "0x45AC40", VA = "0x18045C640", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x0006A4CC File Offset: 0x000686CC
	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x45C400", Offset = "0x45AA00", VA = "0x18045C400", Slot = "71")]
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

	// Token: 0x060012E4 RID: 4836 RVA: 0x0006A5A0 File Offset: 0x000687A0
	[Token(Token = "0x60012E4")]
	[Address(RVA = "0x45C280", Offset = "0x45A880", VA = "0x18045C280", Slot = "72")]
	protected virtual void RestoreHealthFromSnapshot()
	{
		List<ValueTuple<float, int>> list = this.healthSnapshots;
		int num = 0;
		ValueTuple<float, int> valueTuple = list[num];
		this.thePlantHealth = valueTuple;
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x0006A5CC File Offset: 0x000687CC
	[Token(Token = "0x60012E5")]
	[Address(RVA = "0x45C6D0", Offset = "0x45ACD0", VA = "0x18045C6D0")]
	public PortalNut()
	{
		List<ValueTuple<float, int>> list = new List();
		this.healthSnapshots = list;
		base..ctor();
	}

	// Token: 0x04000C37 RID: 3127
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C37")]
	private readonly float snapshotInterval = 0.1f;

	// Token: 0x04000C38 RID: 3128
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000C38")]
	private float lastSnapshotTime;

	// Token: 0x04000C39 RID: 3129
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C39")]
	[TupleElementNames(new string[] { "time", "health" })]
	protected readonly List<ValueTuple<float, int>> healthSnapshots;

	// Token: 0x04000C3A RID: 3130
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C3A")]
	private bool restored;

	// Token: 0x04000C3B RID: 3131
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000C3B")]
	protected float invincibleTimer;
}
