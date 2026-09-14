using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000687 RID: 1671
[Token(Token = "0x2000687")]
public class IronGargantuar : Zombie
{
	// Token: 0x06002023 RID: 8227 RVA: 0x000AA448 File Offset: 0x000A8648
	[Token(Token = "0x6002023")]
	[Address(RVA = "0x5522E0", Offset = "0x5508E0", VA = "0x1805522E0")]
	public void LoseIronHead()
	{
		List<GameObject> theUniqueItems = this.theUniqueItems;
		int num = 0;
		global::UnityEngine.Object.Destroy(theUniqueItems[num]);
		global::UnityEngine.Object.Destroy(this.theUniqueItems[1]);
		List<GameObject> theUniqueItems2 = this.theUniqueItems;
		int num2 = 0;
		int num3 = 0;
		theUniqueItems2[num3] = num2;
		this.theUniqueItemType = (Zombie.UniqueItemType)((ulong)0L);
		Transform transform = base.transform;
		int num4 = 0;
		SpriteRenderer component = transform.GetChild(num4).GetComponent<SpriteRenderer>();
		int num5 = 0;
		component.enabled = num5 != 0;
		Transform transform2 = base.transform;
		int num6 = 0;
		Transform child = transform2.GetChild(num6);
		int num7 = 0;
		child.GetChild(num7).GetComponent<SpriteRenderer>().enabled = true;
		SpriteRenderer component2 = base.transform.GetChild(1).GetComponent<SpriteRenderer>();
		int num8 = 0;
		component2.enabled = num8 != 0;
		Transform child2 = base.transform.GetChild(1);
		int num9 = 0;
		child2.GetChild(num9).GetComponent<SpriteRenderer>().enabled = true;
		SpriteRenderer component3 = base.transform.GetChild(2).GetComponent<SpriteRenderer>();
		int num10 = 0;
		component3.enabled = num10 != 0;
		Transform child3 = base.transform.GetChild(2);
		int num11 = 0;
		child3.GetChild(num11).GetComponent<SpriteRenderer>().enabled = true;
		SpriteRenderer component4 = base.transform.GetChild(3).GetComponent<SpriteRenderer>();
		int num12 = 0;
		component4.enabled = num12 != 0;
		Transform child4 = base.transform.GetChild(3);
		int num13 = 0;
		child4.GetChild(num13).GetComponent<SpriteRenderer>().enabled = true;
	}

	// Token: 0x06002024 RID: 8228 RVA: 0x000AA5C0 File Offset: 0x000A87C0
	[Token(Token = "0x6002024")]
	[Address(RVA = "0x551A90", Offset = "0x550090", VA = "0x180551A90", Slot = "29")]
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
			child.GetChild(num7).GetComponent<SpriteRenderer>().enabled = num8 != 0UL;
			uint num9;
			SpriteRenderer component2 = base.transform.GetChild((int)num9).GetComponent<SpriteRenderer>();
			int num10 = 0;
			component2.enabled = num10 != 0;
			uint num11;
			Transform child2 = base.transform.GetChild((int)num11);
			int num12 = 0;
			ulong num13;
			child2.GetChild(num12).GetComponent<SpriteRenderer>().enabled = num13 != 0UL;
			uint num14;
			SpriteRenderer component3 = base.transform.GetChild((int)num14).GetComponent<SpriteRenderer>();
			int num15 = 0;
			component3.enabled = num15 != 0;
			uint num16;
			Transform child3 = base.transform.GetChild((int)num16);
			int num17 = 0;
			ulong num18;
			child3.GetChild(num17).GetComponent<SpriteRenderer>().enabled = num18 != 0UL;
			uint num19;
			SpriteRenderer component4 = base.transform.GetChild((int)num19).GetComponent<SpriteRenderer>();
			int num20 = 0;
			component4.enabled = num20 != 0;
			uint num21;
			Transform child4 = base.transform.GetChild((int)num21);
			int num22 = 0;
			ulong num23;
			child4.GetChild(num22).GetComponent<SpriteRenderer>().enabled = num23 != 0UL;
		}
		this.LoseIronHead();
		int num24 = 0;
		int childCount = base.transform.childCount;
		if (num24 < childCount)
		{
			if (string.Equals(base.transform.GetChild(num24).name, "LoseHead"))
			{
				Transform child5 = base.transform.GetChild(num24);
				base.AnimLoseActive(child5);
			}
			num24++;
			Transform transform3 = base.transform;
		}
	}

	// Token: 0x06002025 RID: 8229 RVA: 0x000AA77C File Offset: 0x000A897C
	[Token(Token = "0x6002025")]
	[Address(RVA = "0x551F30", Offset = "0x550530", VA = "0x180551F30", Slot = "45")]
	public override void DestoryZombie()
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[54];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06002026 RID: 8230 RVA: 0x000AA7E0 File Offset: 0x000A89E0
	[Token(Token = "0x6002026")]
	[Address(RVA = "0x552110", Offset = "0x550710", VA = "0x180552110", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		if (reason == 2)
		{
			GameAPP.PlaySound(43, 0.5f, 1f);
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			GameObject gameObject = GameAPP.particlePrefab[54];
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
		}
	}

	// Token: 0x06002027 RID: 8231 RVA: 0x000AA83C File Offset: 0x000A8A3C
	[Token(Token = "0x6002027")]
	[Address(RVA = "0x5526A0", Offset = "0x550CA0", VA = "0x1805526A0", Slot = "39")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int theZombieRow = this.theZombieRow;
			int num = global::UnityEngine.Random.Range(8, 10);
		}
	}

	// Token: 0x06002028 RID: 8232 RVA: 0x000AA868 File Offset: 0x000A8A68
	[Token(Token = "0x6002028")]
	[Address(RVA = "0x538170", Offset = "0x536770", VA = "0x180538170")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06002029 RID: 8233 RVA: 0x000AA888 File Offset: 0x000A8A88
	[Token(Token = "0x6002029")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x000AA898 File Offset: 0x000A8A98
	[Token(Token = "0x600202A")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x0600202B RID: 8235 RVA: 0x000AA8A8 File Offset: 0x000A8AA8
	[Token(Token = "0x600202B")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x000AA8B8 File Offset: 0x000A8AB8
	[Token(Token = "0x600202C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "52")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x0600202D RID: 8237 RVA: 0x000AA8C8 File Offset: 0x000A8AC8
	[Token(Token = "0x600202D")]
	[Address(RVA = "0x5527C0", Offset = "0x550DC0", VA = "0x1805527C0", Slot = "26")]
	public override void SetMindControl(int level = 0)
	{
		if (level > 0)
		{
			base.SetMindControl(level);
			return;
		}
	}

	// Token: 0x0600202E RID: 8238 RVA: 0x000AA8E4 File Offset: 0x000A8AE4
	[Token(Token = "0x600202E")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "59")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x000AA8F4 File Offset: 0x000A8AF4
	[Token(Token = "0x600202F")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "53")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x06002030 RID: 8240 RVA: 0x000AA904 File Offset: 0x000A8B04
	[Token(Token = "0x6002030")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "58")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x06002031 RID: 8241 RVA: 0x000AA914 File Offset: 0x000A8B14
	[Token(Token = "0x6002031")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "49")]
	public override void SetJalaed()
	{
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x000AA924 File Offset: 0x000A8B24
	[Token(Token = "0x6002032")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "50")]
	public override void SetEmbered(bool ulti = false)
	{
	}

	// Token: 0x06002033 RID: 8243 RVA: 0x000AA934 File Offset: 0x000A8B34
	[Token(Token = "0x6002033")]
	[Address(RVA = "0x5527D0", Offset = "0x550DD0", VA = "0x1805527D0")]
	public IronGargantuar()
	{
	}
}
