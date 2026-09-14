using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006F5 RID: 1781
[Token(Token = "0x20006F5")]
public class RandomGargantuar : Gargantuar
{
	// Token: 0x06002304 RID: 8964 RVA: 0x000B6EE4 File Offset: 0x000B50E4
	[Token(Token = "0x6002304")]
	[Address(RVA = "0x5CE880", Offset = "0x5CCE80", VA = "0x1805CE880", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		long num = this.theHealth;
		num -= (long)theDamage;
		this.theHealth = num;
		int num2 = 0;
		int num3 = 0;
		float num4 = (float)(num2 * (int)0.6666667f);
		int num5 = 0;
		if (global::Core.Lawnf.ValueBetween((float)(num3 * (int)0.33333334f), (float)num5, num4))
		{
			Transform transform = base.transform;
			int num6 = 0;
			SpriteRenderer component = transform.GetChild(num6).GetComponent<SpriteRenderer>();
			int num7 = 0;
			component.enabled = num7 != 0;
			Transform transform2 = base.transform;
			int num8 = 0;
			Transform child = transform2.GetChild(num8);
			int num9 = 0;
			ulong num10;
			child.GetChild(num9).gameObject.SetActive(num10 != 0UL);
			Transform transform3 = base.transform;
			int num11 = 0;
			uint num12;
			GameObject gameObject = transform3.GetChild(num11).GetChild((int)num12).gameObject;
			int num13 = 0;
			gameObject.SetActive(num13 != 0);
			uint num14;
			SpriteRenderer component2 = base.transform.GetChild((int)num14).GetComponent<SpriteRenderer>();
			int num15 = 0;
			component2.enabled = num15 != 0;
			uint num16;
			Transform child2 = base.transform.GetChild((int)num16);
			int num17 = 0;
			ulong num18;
			child2.GetChild(num17).gameObject.SetActive(num18 != 0UL);
			uint num19;
			SpriteRenderer component3 = base.transform.GetChild((int)num19).GetComponent<SpriteRenderer>();
			int num20 = 0;
			component3.enabled = num20 != 0;
			uint num21;
			Transform child3 = base.transform.GetChild((int)num21);
			int num22 = 0;
			ulong num23;
			child3.GetChild(num22).gameObject.SetActive(num23 != 0UL);
		}
		int num24 = 0;
		int num25 = 0;
		if (num24 * (int)0.5f > num25)
		{
			Transform axis = this.axis;
			Board board = this.board;
			Animator anim = this.anim;
			this.theStatus = (ZombieStatus)((ulong)0L);
			anim.SetTrigger("throw");
		}
		int num26 = 0;
		float num27;
		if (num27 > (float)num26)
		{
			Transform transform4 = base.transform;
			int num28 = 0;
			SpriteRenderer component4 = transform4.GetChild(num28).GetComponent<SpriteRenderer>();
			int num29 = 0;
			component4.enabled = num29 != 0;
			Transform transform5 = base.transform;
			int num30 = 0;
			Transform child4 = transform5.GetChild(num30);
			int num31 = 0;
			GameObject gameObject2 = child4.GetChild(num31).gameObject;
			int num32 = 0;
			gameObject2.SetActive(num32 != 0);
			Transform transform6 = base.transform;
			int num33 = 0;
			uint num34;
			ulong num35;
			transform6.GetChild(num33).GetChild((int)num34).gameObject.SetActive(num35 != 0UL);
			uint num36;
			SpriteRenderer component5 = base.transform.GetChild((int)num36).GetComponent<SpriteRenderer>();
			int num37 = 0;
			component5.enabled = num37 != 0;
			uint num38;
			Transform child5 = base.transform.GetChild((int)num38);
			int num39 = 0;
			ulong num40;
			child5.GetChild(num39).gameObject.SetActive(num40 != 0UL);
			uint num41;
			SpriteRenderer component6 = base.transform.GetChild((int)num41).GetComponent<SpriteRenderer>();
			int num42 = 0;
			component6.enabled = num42 != 0;
			uint num43;
			Transform child6 = base.transform.GetChild((int)num43);
			int num44 = 0;
			ulong num45;
			child6.GetChild(num44).gameObject.SetActive(num45 != 0UL);
		}
	}

	// Token: 0x06002305 RID: 8965 RVA: 0x000B719C File Offset: 0x000B539C
	[Token(Token = "0x6002305")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002306 RID: 8966 RVA: 0x000B71AC File Offset: 0x000B53AC
	[Token(Token = "0x6002306")]
	[Address(RVA = "0x5CEEF0", Offset = "0x5CD4F0", VA = "0x1805CEEF0", Slot = "64")]
	protected override void FirstArmorFall()
	{
		if (!this.summon)
		{
			this.summon = true;
			List<ZombieType> list = new List();
			int size = list._size;
			int size2 = list._size;
			int size3 = list._size;
			int size4 = list._size;
			int num = list._size;
			int num2 = 0;
			CreateZombie instance = CreateZombie.Instance;
			num = global::UnityEngine.Random.Range(num2, num);
			ZombieType zombieType = list[num];
			Transform axis = this.axis;
			int num3 = list._size;
			int num4 = 0;
			CreateZombie instance2 = CreateZombie.Instance;
			num3 = global::UnityEngine.Random.Range(num4, num3);
			ZombieType zombieType2 = list[num3];
			Transform axis2 = this.axis;
			base.Die(2);
			Transform axis3 = this.axis;
			ParticleManager instance3 = ParticleManager.Instance;
			int num5 = 0;
			int num6 = 0;
			int theZombieRow = this.theZombieRow;
			ulong num7;
			Particle particle = instance3.SetParticle((ParticleType)((uint)11), num5, theZombieRow, num7 != 0UL, (float)num6);
		}
	}

	// Token: 0x06002307 RID: 8967 RVA: 0x000B7294 File Offset: 0x000B5494
	[Token(Token = "0x6002307")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "31")]
	protected override bool Instead(int damage)
	{
		return false;
	}

	// Token: 0x06002308 RID: 8968 RVA: 0x000B72A4 File Offset: 0x000B54A4
	[Token(Token = "0x6002308")]
	[Address(RVA = "0x5CF2E0", Offset = "0x5CD8E0", VA = "0x1805CF2E0")]
	public RandomGargantuar()
	{
	}

	// Token: 0x040011F0 RID: 4592
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011F0")]
	private bool summon;
}
