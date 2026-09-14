using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000738 RID: 1848
[Token(Token = "0x2000738")]
public class UltimateJacksonDriver : JacksonDriver
{
	// Token: 0x060024D2 RID: 9426 RVA: 0x000BF71C File Offset: 0x000BD91C
	[Token(Token = "0x60024D2")]
	[Address(RVA = "0x602890", Offset = "0x600E90", VA = "0x180602890", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(69, 0.5f, 1f);
		Board board = this.board;
		global::Lawnf.SetZombieHealth(this, 0.5f);
	}

	// Token: 0x060024D3 RID: 9427 RVA: 0x000BF75C File Offset: 0x000BD95C
	[Token(Token = "0x60024D3")]
	[Address(RVA = "0x602930", Offset = "0x600F30", VA = "0x180602930", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		Animator animator = this.jackson;
		float theSpeed = this.theSpeed;
		animator.SetFloat("Speed", theSpeed);
	}

	// Token: 0x060024D4 RID: 9428 RVA: 0x000BF790 File Offset: 0x000BD990
	[Token(Token = "0x60024D4")]
	[Address(RVA = "0x602520", Offset = "0x600B20", VA = "0x180602520", Slot = "29")]
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

	// Token: 0x060024D5 RID: 9429 RVA: 0x000BF814 File Offset: 0x000BDA14
	[Token(Token = "0x60024D5")]
	[Address(RVA = "0x5B90D0", Offset = "0x5B76D0", VA = "0x1805B90D0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x060024D6 RID: 9430 RVA: 0x000BF828 File Offset: 0x000BDA28
	[Token(Token = "0x60024D6")]
	[Address(RVA = "0x601EA0", Offset = "0x6004A0", VA = "0x180601EA0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num27;
		do
		{
			long num = this.theHealth;
			num -= (long)theDamage;
			this.theHealth = num;
			num -= (long)theDamage;
			int num2 = 0;
			int num3 = 0;
			if (!global::Core.Lawnf.ValueBetween((float)0, (float)num3, (float)num2))
			{
				int num4 = 0;
				float num5;
				if (num5 <= (float)num4)
				{
					return;
				}
				List<Transform> changeSprites = this.changeSprites;
				bool flag;
				if (flag)
				{
					int num6 = 0;
					SpriteRenderer spriteRenderer;
					spriteRenderer.enabled = num6 != 0;
					int num7 = 0;
					Transform transform;
					GameObject gameObject = transform.GetChild(num7).gameObject;
					int num8 = 0;
					gameObject.SetActive(num8 != 0);
					Transform transform2;
					uint num9;
					ulong num10;
					transform2.GetChild((int)num9).gameObject.SetActive(num10 != 0UL);
				}
				ulong num11;
				if (num11 != (ulong)0L)
				{
					goto IL_01C9;
				}
				Transform transform3;
				uint num12;
				GameObject gameObject2 = transform3.GetChild((int)num12).gameObject;
				int num13 = 0;
				gameObject2.SetActive(num13 != 0);
				Transform transform4;
				uint num14;
				GameObject gameObject3 = transform4.GetChild((int)num14).gameObject;
				int num15 = 0;
				gameObject3.SetActive(num15 != 0);
				Transform transform5;
				uint num16;
				GameObject gameObject4 = transform5.GetChild((int)num16).gameObject;
				int num17 = 0;
				gameObject4.SetActive(num17 != 0);
				Transform transform6;
				uint num18;
				GameObject gameObject5 = transform6.GetChild((int)num18).gameObject;
				int num19 = 0;
				gameObject5.SetActive(num19 != 0);
				Transform transform7;
				uint num20;
				GameObject gameObject6 = transform7.GetChild((int)num20).gameObject;
				int num21 = 0;
				gameObject6.SetActive(num21 != 0);
			}
			List<Transform> changeSprites2 = this.changeSprites;
			bool flag2;
			if (flag2)
			{
				int num22 = 0;
				SpriteRenderer spriteRenderer2;
				spriteRenderer2.enabled = num22 != 0;
				int num23 = 0;
				Transform transform8;
				ulong num24;
				transform8.GetChild(num23).gameObject.SetActive(num24 != 0UL);
				Transform transform9;
				uint num25;
				GameObject gameObject7 = transform9.GetChild((int)num25).gameObject;
				int num26 = 0;
				gameObject7.SetActive(num26 != 0);
			}
		}
		while (num27 != (ulong)0L);
		Transform transform10;
		uint num28;
		GameObject gameObject8 = transform10.GetChild((int)num28).gameObject;
		int num29 = 0;
		gameObject8.SetActive(num29 != 0);
		uint num30;
		base.Die((int)num30);
		return;
		IL_01C9:
		throw new NullReferenceException();
	}

	// Token: 0x060024D7 RID: 9431 RVA: 0x000BFA30 File Offset: 0x000BDC30
	[Token(Token = "0x60024D7")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x060024D8 RID: 9432 RVA: 0x000BFA44 File Offset: 0x000BDC44
	[Token(Token = "0x60024D8")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060024D9 RID: 9433 RVA: 0x000BFA54 File Offset: 0x000BDC54
	[Token(Token = "0x60024D9")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060024DA RID: 9434 RVA: 0x000BFA64 File Offset: 0x000BDC64
	[Token(Token = "0x60024DA")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060024DB RID: 9435 RVA: 0x000BFA74 File Offset: 0x000BDC74
	[Token(Token = "0x60024DB")]
	[Address(RVA = "0x602840", Offset = "0x600E40", VA = "0x180602840", Slot = "75")]
	public override void KillByCaltrop()
	{
	}

	// Token: 0x060024DC RID: 9436 RVA: 0x000BFA84 File Offset: 0x000BDC84
	[Token(Token = "0x60024DC")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "51")]
	public override void SetJalaed()
	{
	}

	// Token: 0x060024DD RID: 9437 RVA: 0x000BFA94 File Offset: 0x000BDC94
	[Token(Token = "0x60024DD")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "54")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x060024DE RID: 9438 RVA: 0x000BFAA4 File Offset: 0x000BDCA4
	[Token(Token = "0x60024DE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "55")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x060024DF RID: 9439 RVA: 0x000BFAB4 File Offset: 0x000BDCB4
	[Token(Token = "0x60024DF")]
	[Address(RVA = "0x602990", Offset = "0x600F90", VA = "0x180602990")]
	public UltimateJacksonDriver()
	{
	}

	// Token: 0x04001263 RID: 4707
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001263")]
	public Animator jackson;
}
