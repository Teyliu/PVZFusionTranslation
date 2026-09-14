using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000707 RID: 1799
[Token(Token = "0x2000707")]
public class SubmarineZombie : Zombie
{
	// Token: 0x0600236B RID: 9067 RVA: 0x000B8E50 File Offset: 0x000B7050
	[Token(Token = "0x600236B")]
	[Address(RVA = "0x5D5D00", Offset = "0x5D4300", VA = "0x1805D5D00", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.inWater = true;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		this.startPos.z = z;
		Vector3 vector2 = this.startPos;
		float z2 = this.startPos.z;
		this.startPos.z = z2;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)4)))
		{
			float theOriginSpeed = this.theOriginSpeed;
			this.theOriginSpeed = theOriginSpeed;
		}
	}

	// Token: 0x0600236C RID: 9068 RVA: 0x000B8EC8 File Offset: 0x000B70C8
	[Token(Token = "0x600236C")]
	[Address(RVA = "0x5D5C50", Offset = "0x5D4250", VA = "0x1805D5C50", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix = false, PlantType fromType = PlantType.Nothing)
	{
		bool flag;
		if (!flag || !fix)
		{
		}
		long num;
		return num;
	}

	// Token: 0x0600236D RID: 9069 RVA: 0x000B8EE4 File Offset: 0x000B70E4
	[Token(Token = "0x600236D")]
	[Address(RVA = "0x5D5DC0", Offset = "0x5D43C0", VA = "0x1805D5DC0", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		if (Lawnf.EveBalaced())
		{
			Transform transform = base.transform;
			float z = this.startPos.z;
		}
	}

	// Token: 0x0600236E RID: 9070 RVA: 0x000B8F1C File Offset: 0x000B711C
	[Token(Token = "0x600236E")]
	[Address(RVA = "0x5D5480", Offset = "0x5D3A80", VA = "0x1805D5480", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		long num = this.theHealth;
		num -= (long)theDamage;
		long num2 = this.theMaxHealth;
		num2 += num2;
		this.theHealth = num;
		Transform transform = base.transform;
		int num3 = 0;
		ulong num4;
		transform.GetChild(num3).gameObject.SetActive(num4 != 0UL);
		uint num5;
		GameObject gameObject = base.transform.GetChild((int)num5).gameObject;
		int num6 = 0;
		gameObject.SetActive(num6 != 0);
		uint num7;
		GameObject gameObject2 = base.transform.GetChild((int)num7).gameObject;
		int num8 = 0;
		gameObject2.SetActive(num8 != 0);
		uint num9;
		ulong num10;
		base.transform.GetChild((int)num9).gameObject.SetActive(num10 != 0UL);
		uint num11;
		GameObject gameObject3 = base.transform.GetChild((int)num11).gameObject;
		int num12 = 0;
		gameObject3.SetActive(num12 != 0);
		uint num13;
		GameObject gameObject4 = base.transform.GetChild((int)num13).gameObject;
		int num14 = 0;
		gameObject4.SetActive(num14 != 0);
		long num15 = this.theMaxHealth;
		int num16 = 0;
		num15 += num15;
		int num17 = 0;
		if (num16 > num17)
		{
			Transform transform2 = base.transform;
			int num18 = 0;
			GameObject gameObject5 = transform2.GetChild(num18).gameObject;
			int num19 = 0;
			gameObject5.SetActive(num19 != 0);
			uint num20;
			ulong num21;
			base.transform.GetChild((int)num20).gameObject.SetActive(num21 != 0UL);
			uint num22;
			GameObject gameObject6 = base.transform.GetChild((int)num22).gameObject;
			int num23 = 0;
			gameObject6.SetActive(num23 != 0);
			uint num24;
			GameObject gameObject7 = base.transform.GetChild((int)num24).gameObject;
			int num25 = 0;
			gameObject7.SetActive(num25 != 0);
			uint num26;
			ulong num27;
			base.transform.GetChild((int)num26).gameObject.SetActive(num27 != 0UL);
			uint num28;
			GameObject gameObject8 = base.transform.GetChild((int)num28).gameObject;
			int num29 = 0;
			gameObject8.SetActive(num29 != 0);
		}
		int num30 = 0;
		int num31 = 0;
		if (num30 > num31)
		{
			Transform transform3 = base.transform;
			int num32 = 0;
			GameObject gameObject9 = transform3.GetChild(num32).gameObject;
			int num33 = 0;
			gameObject9.SetActive(num33 != 0);
			uint num34;
			GameObject gameObject10 = base.transform.GetChild((int)num34).gameObject;
			int num35 = 0;
			gameObject10.SetActive(num35 != 0);
			uint num36;
			ulong num37;
			base.transform.GetChild((int)num36).gameObject.SetActive(num37 != 0UL);
			uint num38;
			GameObject gameObject11 = base.transform.GetChild((int)num38).gameObject;
			int num39 = 0;
			gameObject11.SetActive(num39 != 0);
			uint num40;
			GameObject gameObject12 = base.transform.GetChild((int)num40).gameObject;
			int num41 = 0;
			gameObject12.SetActive(num41 != 0);
			uint num42;
			ulong num43;
			base.transform.GetChild((int)num42).gameObject.SetActive(num43 != 0UL);
		}
	}

	// Token: 0x0600236F RID: 9071 RVA: 0x000B91B0 File Offset: 0x000B73B0
	[Token(Token = "0x600236F")]
	[Address(RVA = "0x5D5A90", Offset = "0x5D4090", VA = "0x1805D5A90", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[34];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x06002370 RID: 9072 RVA: 0x000B9208 File Offset: 0x000B7408
	[Token(Token = "0x6002370")]
	[Address(RVA = "0x5D5CD0", Offset = "0x5D42D0", VA = "0x1805D5CD0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		Plant plant = base.CrashEntity(collision, true, 1f);
	}

	// Token: 0x06002371 RID: 9073 RVA: 0x000B9224 File Offset: 0x000B7424
	[Token(Token = "0x6002371")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002372 RID: 9074 RVA: 0x000B9234 File Offset: 0x000B7434
	[Token(Token = "0x6002372")]
	[Address(RVA = "0x58EA00", Offset = "0x58D000", VA = "0x18058EA00", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06002373 RID: 9075 RVA: 0x000B9248 File Offset: 0x000B7448
	[Token(Token = "0x6002373")]
	[Address(RVA = "0x5D5E30", Offset = "0x5D4430", VA = "0x1805D5E30")]
	public SubmarineZombie()
	{
	}

	// Token: 0x04001200 RID: 4608
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001200")]
	private Vector3 startPos;
}
