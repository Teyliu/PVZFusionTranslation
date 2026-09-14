using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006BD RID: 1725
[Token(Token = "0x20006BD")]
public class RandomGargantuar : Gargantuar
{
	// Token: 0x060021EA RID: 8682 RVA: 0x000B21DC File Offset: 0x000B03DC
	[Token(Token = "0x60021EA")]
	[Address(RVA = "0x56AFA0", Offset = "0x5695A0", VA = "0x18056AFA0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		int num = this.theHealth;
		num -= theDamage;
		this.theHealth = num;
		float num2;
		float num3;
		if (global::Core.Lawnf.ValueBetween(num2, (float)theDamage, num3))
		{
			Transform transform = base.transform;
			int num4 = 0;
			SpriteRenderer component = transform.GetChild(num4).GetComponent<SpriteRenderer>();
			int num5 = 0;
			component.enabled = num5 != 0;
			Transform transform2 = base.transform;
			int num6 = 0;
			Transform child = transform2.GetChild(num6);
			int num7 = 0;
			ulong num8;
			child.GetChild(num7).gameObject.SetActive(num8 != 0UL);
			Transform transform3 = base.transform;
			int num9 = 0;
			uint num10;
			GameObject gameObject = transform3.GetChild(num9).GetChild((int)num10).gameObject;
			int num11 = 0;
			gameObject.SetActive(num11 != 0);
			uint num12;
			SpriteRenderer component2 = base.transform.GetChild((int)num12).GetComponent<SpriteRenderer>();
			int num13 = 0;
			component2.enabled = num13 != 0;
			uint num14;
			Transform child2 = base.transform.GetChild((int)num14);
			int num15 = 0;
			ulong num16;
			child2.GetChild(num15).gameObject.SetActive(num16 != 0UL);
			uint num17;
			SpriteRenderer component3 = base.transform.GetChild((int)num17).GetComponent<SpriteRenderer>();
			int num18 = 0;
			component3.enabled = num18 != 0;
			uint num19;
			Transform child3 = base.transform.GetChild((int)num19);
			int num20 = 0;
			ulong num21;
			child3.GetChild(num20).gameObject.SetActive(num21 != 0UL);
		}
		float num22 = num2 * 0.5f;
		Transform axis = this.axis;
		Board board = this.board;
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)0L);
		anim.SetTrigger("throw");
		Transform transform4 = base.transform;
		int num23 = 0;
		SpriteRenderer component4 = transform4.GetChild(num23).GetComponent<SpriteRenderer>();
		int num24 = 0;
		component4.enabled = num24 != 0;
		Transform transform5 = base.transform;
		int num25 = 0;
		Transform child4 = transform5.GetChild(num25);
		int num26 = 0;
		GameObject gameObject2 = child4.GetChild(num26).gameObject;
		int num27 = 0;
		gameObject2.SetActive(num27 != 0);
		Transform transform6 = base.transform;
		int num28 = 0;
		uint num29;
		ulong num30;
		transform6.GetChild(num28).GetChild((int)num29).gameObject.SetActive(num30 != 0UL);
		uint num31;
		SpriteRenderer component5 = base.transform.GetChild((int)num31).GetComponent<SpriteRenderer>();
		int num32 = 0;
		component5.enabled = num32 != 0;
		uint num33;
		Transform child5 = base.transform.GetChild((int)num33);
		int num34 = 0;
		ulong num35;
		child5.GetChild(num34).gameObject.SetActive(num35 != 0UL);
		uint num36;
		SpriteRenderer component6 = base.transform.GetChild((int)num36).GetComponent<SpriteRenderer>();
		int num37 = 0;
		component6.enabled = num37 != 0;
		uint num38;
		Transform child6 = base.transform.GetChild((int)num38);
		int num39 = 0;
		ulong num40;
		child6.GetChild(num39).gameObject.SetActive(num40 != 0UL);
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x000B2468 File Offset: 0x000B0668
	[Token(Token = "0x60021EB")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x000B2478 File Offset: 0x000B0678
	[Token(Token = "0x60021EC")]
	[Address(RVA = "0x56B600", Offset = "0x569C00", VA = "0x18056B600", Slot = "62")]
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

	// Token: 0x060021ED RID: 8685 RVA: 0x000B2560 File Offset: 0x000B0760
	[Token(Token = "0x60021ED")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "30")]
	protected override bool Instead(int damage)
	{
		return false;
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x000B2570 File Offset: 0x000B0770
	[Token(Token = "0x60021EE")]
	[Address(RVA = "0x56B9F0", Offset = "0x569FF0", VA = "0x18056B9F0")]
	public RandomGargantuar()
	{
	}

	// Token: 0x04001123 RID: 4387
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001123")]
	private bool summon;
}
