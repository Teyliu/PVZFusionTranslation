using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000700 RID: 1792
[Token(Token = "0x2000700")]
public class UltimateJacksonDriver : JacksonDriver
{
	// Token: 0x060023B7 RID: 9143 RVA: 0x000BAB18 File Offset: 0x000B8D18
	[Token(Token = "0x60023B7")]
	[Address(RVA = "0x589A80", Offset = "0x588080", VA = "0x180589A80", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(69, 0.5f, 1f);
		Board board = this.board;
		Lawnf.SetZombieHealth(this, 0.5f);
	}

	// Token: 0x060023B8 RID: 9144 RVA: 0x000BAB58 File Offset: 0x000B8D58
	[Token(Token = "0x60023B8")]
	[Address(RVA = "0x589B90", Offset = "0x588190", VA = "0x180589B90", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Animator animator = this.jackson;
		float theSpeed = this.theSpeed;
		animator.SetFloat("Speed", theSpeed);
	}

	// Token: 0x060023B9 RID: 9145 RVA: 0x000BAB8C File Offset: 0x000B8D8C
	[Token(Token = "0x60023B9")]
	[Address(RVA = "0x589710", Offset = "0x587D10", VA = "0x180589710", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[36];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		Transform axis2 = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		Transform axis3 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		Transform axis4 = this.axis;
		CreateZombie instance3 = CreateZombie.Instance;
	}

	// Token: 0x060023BA RID: 9146 RVA: 0x000BAC10 File Offset: 0x000B8E10
	[Token(Token = "0x60023BA")]
	[Address(RVA = "0x589B20", Offset = "0x588120", VA = "0x180589B20", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x060023BB RID: 9147 RVA: 0x000BAC24 File Offset: 0x000B8E24
	[Token(Token = "0x60023BB")]
	[Address(RVA = "0x5890B0", Offset = "0x5876B0", VA = "0x1805890B0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num23;
		do
		{
			int num = this.theHealth;
			num -= theDamage;
			this.theHealth = num;
			num -= theDamage;
			if (num <= 0)
			{
				goto IL_017E;
			}
			bool flag;
			if (!flag)
			{
				List<Transform> changeSprites = this.changeSprites;
				bool flag2;
				if (flag2)
				{
					int num2 = 0;
					SpriteRenderer spriteRenderer;
					spriteRenderer.enabled = num2 != 0;
					int num3 = 0;
					Transform transform;
					GameObject gameObject = transform.GetChild(num3).gameObject;
					int num4 = 0;
					gameObject.SetActive(num4 != 0);
					Transform transform2;
					uint num5;
					ulong num6;
					transform2.GetChild((int)num5).gameObject.SetActive(num6 != 0UL);
				}
				ulong num7;
				if (num7 != (ulong)0L)
				{
					goto IL_01B7;
				}
				Transform transform3;
				uint num8;
				GameObject gameObject2 = transform3.GetChild((int)num8).gameObject;
				int num9 = 0;
				gameObject2.SetActive(num9 != 0);
				Transform transform4;
				uint num10;
				GameObject gameObject3 = transform4.GetChild((int)num10).gameObject;
				int num11 = 0;
				gameObject3.SetActive(num11 != 0);
				Transform transform5;
				uint num12;
				GameObject gameObject4 = transform5.GetChild((int)num12).gameObject;
				int num13 = 0;
				gameObject4.SetActive(num13 != 0);
				Transform transform6;
				uint num14;
				GameObject gameObject5 = transform6.GetChild((int)num14).gameObject;
				int num15 = 0;
				gameObject5.SetActive(num15 != 0);
				Transform transform7;
				uint num16;
				GameObject gameObject6 = transform7.GetChild((int)num16).gameObject;
				int num17 = 0;
				gameObject6.SetActive(num17 != 0);
			}
			List<Transform> changeSprites2 = this.changeSprites;
			bool flag3;
			if (flag3)
			{
				int num18 = 0;
				SpriteRenderer spriteRenderer2;
				spriteRenderer2.enabled = num18 != 0;
				int num19 = 0;
				Transform transform8;
				ulong num20;
				transform8.GetChild(num19).gameObject.SetActive(num20 != 0UL);
				Transform transform9;
				uint num21;
				GameObject gameObject7 = transform9.GetChild((int)num21).gameObject;
				int num22 = 0;
				gameObject7.SetActive(num22 != 0);
			}
		}
		while (num23 != (ulong)0L);
		Transform transform10;
		uint num24;
		GameObject gameObject8 = transform10.GetChild((int)num24).gameObject;
		int num25 = 0;
		gameObject8.SetActive(num25 != 0);
		IL_017E:
		uint num26;
		base.Die((int)num26);
		return;
		IL_01B7:
		throw new NullReferenceException();
	}

	// Token: 0x060023BC RID: 9148 RVA: 0x000BAE18 File Offset: 0x000B9018
	[Token(Token = "0x60023BC")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x060023BD RID: 9149 RVA: 0x000BAE34 File Offset: 0x000B9034
	[Token(Token = "0x60023BD")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060023BE RID: 9150 RVA: 0x000BAE44 File Offset: 0x000B9044
	[Token(Token = "0x60023BE")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060023BF RID: 9151 RVA: 0x000BAE54 File Offset: 0x000B9054
	[Token(Token = "0x60023BF")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060023C0 RID: 9152 RVA: 0x000BAE64 File Offset: 0x000B9064
	[Token(Token = "0x60023C0")]
	[Address(RVA = "0x589A30", Offset = "0x588030", VA = "0x180589A30", Slot = "73")]
	public override void KillByCaltrop()
	{
	}

	// Token: 0x060023C1 RID: 9153 RVA: 0x000BAE74 File Offset: 0x000B9074
	[Token(Token = "0x60023C1")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "49")]
	public override void SetJalaed()
	{
	}

	// Token: 0x060023C2 RID: 9154 RVA: 0x000BAE84 File Offset: 0x000B9084
	[Token(Token = "0x60023C2")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "52")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x060023C3 RID: 9155 RVA: 0x000BAE94 File Offset: 0x000B9094
	[Token(Token = "0x60023C3")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "53")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x060023C4 RID: 9156 RVA: 0x000BAEA4 File Offset: 0x000B90A4
	[Token(Token = "0x60023C4")]
	[Address(RVA = "0x589BF0", Offset = "0x5881F0", VA = "0x180589BF0")]
	public UltimateJacksonDriver()
	{
	}

	// Token: 0x04001199 RID: 4505
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001199")]
	public Animator jackson;
}
