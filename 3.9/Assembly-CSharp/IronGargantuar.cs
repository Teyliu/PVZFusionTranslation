using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006BD RID: 1725
[Token(Token = "0x20006BD")]
public class IronGargantuar : Zombie
{
	// Token: 0x06002125 RID: 8485 RVA: 0x000AED4C File Offset: 0x000ACF4C
	[Token(Token = "0x6002125")]
	[Address(RVA = "0x5B5E80", Offset = "0x5B4480", VA = "0x1805B5E80")]
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

	// Token: 0x06002126 RID: 8486 RVA: 0x000AEEC4 File Offset: 0x000AD0C4
	[Token(Token = "0x6002126")]
	[Address(RVA = "0x5B5620", Offset = "0x5B3C20", VA = "0x1805B5620", Slot = "30")]
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
			child.GetChild(num9).GetComponent<SpriteRenderer>().enabled = num10 != 0UL;
			uint num11;
			SpriteRenderer component2 = base.transform.GetChild((int)num11).GetComponent<SpriteRenderer>();
			int num12 = 0;
			component2.enabled = num12 != 0;
			uint num13;
			Transform child2 = base.transform.GetChild((int)num13);
			int num14 = 0;
			ulong num15;
			child2.GetChild(num14).GetComponent<SpriteRenderer>().enabled = num15 != 0UL;
			uint num16;
			SpriteRenderer component3 = base.transform.GetChild((int)num16).GetComponent<SpriteRenderer>();
			int num17 = 0;
			component3.enabled = num17 != 0;
			uint num18;
			Transform child3 = base.transform.GetChild((int)num18);
			int num19 = 0;
			ulong num20;
			child3.GetChild(num19).GetComponent<SpriteRenderer>().enabled = num20 != 0UL;
			uint num21;
			SpriteRenderer component4 = base.transform.GetChild((int)num21).GetComponent<SpriteRenderer>();
			int num22 = 0;
			component4.enabled = num22 != 0;
			uint num23;
			Transform child4 = base.transform.GetChild((int)num23);
			int num24 = 0;
			ulong num25;
			child4.GetChild(num24).GetComponent<SpriteRenderer>().enabled = num25 != 0UL;
		}
		int num26 = 0;
		float num27;
		if (num27 > (float)num26)
		{
			this.LoseIronHead();
			int num28 = 0;
			int childCount = base.transform.childCount;
			if (num28 < childCount)
			{
				if (string.Equals(base.transform.GetChild(num28).name, "LoseHead"))
				{
					Transform child5 = base.transform.GetChild(num28);
					base.AnimLoseActive(child5);
				}
				num28++;
				Transform transform3 = base.transform;
			}
		}
	}

	// Token: 0x06002127 RID: 8487 RVA: 0x000AF0A4 File Offset: 0x000AD2A4
	[Token(Token = "0x6002127")]
	[Address(RVA = "0x5B5AD0", Offset = "0x5B40D0", VA = "0x1805B5AD0", Slot = "47")]
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

	// Token: 0x06002128 RID: 8488 RVA: 0x000AF108 File Offset: 0x000AD308
	[Token(Token = "0x6002128")]
	[Address(RVA = "0x5B5CB0", Offset = "0x5B42B0", VA = "0x1805B5CB0", Slot = "29")]
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

	// Token: 0x06002129 RID: 8489 RVA: 0x000AF164 File Offset: 0x000AD364
	[Token(Token = "0x6002129")]
	[Address(RVA = "0x5B6240", Offset = "0x5B4840", VA = "0x1805B6240", Slot = "41")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int theZombieRow = this.theZombieRow;
			int num = global::UnityEngine.Random.Range(8, 10);
		}
	}

	// Token: 0x0600212A RID: 8490 RVA: 0x000AF190 File Offset: 0x000AD390
	[Token(Token = "0x600212A")]
	[Address(RVA = "0x58EE50", Offset = "0x58D450", VA = "0x18058EE50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x0600212B RID: 8491 RVA: 0x000AF1B0 File Offset: 0x000AD3B0
	[Token(Token = "0x600212B")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x0600212C RID: 8492 RVA: 0x000AF1C0 File Offset: 0x000AD3C0
	[Token(Token = "0x600212C")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x0600212D RID: 8493 RVA: 0x000AF1D0 File Offset: 0x000AD3D0
	[Token(Token = "0x600212D")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
	}

	// Token: 0x0600212E RID: 8494 RVA: 0x000AF1E0 File Offset: 0x000AD3E0
	[Token(Token = "0x600212E")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "54")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x0600212F RID: 8495 RVA: 0x000AF1F0 File Offset: 0x000AD3F0
	[Token(Token = "0x600212F")]
	[Address(RVA = "0x5B6360", Offset = "0x5B4960", VA = "0x1805B6360", Slot = "27")]
	public override void SetMindControl(int level = 0)
	{
		if (level > 0)
		{
			base.SetMindControl(level);
			return;
		}
	}

	// Token: 0x06002130 RID: 8496 RVA: 0x000AF20C File Offset: 0x000AD40C
	[Token(Token = "0x6002130")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "61")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x06002131 RID: 8497 RVA: 0x000AF21C File Offset: 0x000AD41C
	[Token(Token = "0x6002131")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "55")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x06002132 RID: 8498 RVA: 0x000AF22C File Offset: 0x000AD42C
	[Token(Token = "0x6002132")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "60")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x06002133 RID: 8499 RVA: 0x000AF23C File Offset: 0x000AD43C
	[Token(Token = "0x6002133")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "51")]
	public override void SetJalaed()
	{
	}

	// Token: 0x06002134 RID: 8500 RVA: 0x000AF24C File Offset: 0x000AD44C
	[Token(Token = "0x6002134")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "52")]
	public override void SetEmbered(bool ulti = false)
	{
	}

	// Token: 0x06002135 RID: 8501 RVA: 0x000AF25C File Offset: 0x000AD45C
	[Token(Token = "0x6002135")]
	[Address(RVA = "0x5B6370", Offset = "0x5B4970", VA = "0x1805B6370")]
	public IronGargantuar()
	{
	}
}
