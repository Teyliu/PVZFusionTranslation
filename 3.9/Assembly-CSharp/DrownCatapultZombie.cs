using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000688 RID: 1672
[Token(Token = "0x2000688")]
public class DrownCatapultZombie : CatapultZombie
{
	// Token: 0x06001FC6 RID: 8134 RVA: 0x000A8C1C File Offset: 0x000A6E1C
	[Token(Token = "0x6001FC6")]
	[Address(RVA = "0x5A1DE0", Offset = "0x5A03E0", VA = "0x1805A1DE0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.basketballNum = (int)((ulong)2L);
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x000A8C38 File Offset: 0x000A6E38
	[Token(Token = "0x6001FC7")]
	[Address(RVA = "0x5A2090", Offset = "0x5A0690", VA = "0x1805A2090", Slot = "77")]
	protected override void CataUpdate()
	{
		float boardMaxX = this.board.boardMaxX;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)17)))
		{
		}
		Transform axis = this.axis;
		base.SearchPlantUpdate();
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x000A8C98 File Offset: 0x000A6E98
	[Token(Token = "0x6001FC8")]
	[Address(RVA = "0x5A1BF0", Offset = "0x5A01F0", VA = "0x1805A1BF0", Slot = "76")]
	protected override void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot");
		int num = 0;
		float num2 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
		float num3 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		this.SetWeapon(num);
		while (transform != 0)
		{
		}
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, 1f);
		this.DestoryWeapon2();
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x000A8D04 File Offset: 0x000A6F04
	[Token(Token = "0x6001FC9")]
	[Address(RVA = "0x5A26F0", Offset = "0x5A0CF0", VA = "0x1805A26F0")]
	protected void SetWeapon(Vector2 position)
	{
		GameObject gameObject = Resources.Load<GameObject>("Zombies/Zombie_drown/weapon");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		DrownProjectile drownProjectile = gameObject2.AddComponent<DrownProjectile>();
		int theZombieRow = this.theZombieRow;
		drownProjectile.theRow = theZombieRow;
		drownProjectile.horizontal = true;
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x000A8D5C File Offset: 0x000A6F5C
	[Token(Token = "0x6001FCA")]
	[Address(RVA = "0x5A2190", Offset = "0x5A0790", VA = "0x1805A2190")]
	protected void DestoryWeapon2()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<GameObject> list = this.weapons2;
			bool flag;
			if (flag)
			{
				global::UnityEngine.Object.Destroy(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x000A8D90 File Offset: 0x000A6F90
	[Token(Token = "0x6001FCB")]
	[Address(RVA = "0x5A1A60", Offset = "0x5A0060", VA = "0x1805A1A60")]
	private void AnimRelodeOver()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<GameObject> list = this.weapons;
			bool flag;
			if (flag)
			{
				global::UnityEngine.Object.Destroy(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x000A8DC4 File Offset: 0x000A6FC4
	[Token(Token = "0x6001FCC")]
	[Address(RVA = "0x5A1E00", Offset = "0x5A0400", VA = "0x1805A1E00", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num6;
		do
		{
			long num = this.theHealth;
			num -= (long)theDamage;
			this.theHealth = num;
			num -= (long)theDamage;
			long num2 = this.theMaxHealth;
			num2 -= (long)theDamage;
			if (num >= num2)
			{
				break;
			}
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				SpriteRenderer spriteRenderer;
				spriteRenderer.enabled = num3 != 0;
				int num4 = 0;
				Transform transform;
				ulong num5;
				transform.GetChild(num4).gameObject.SetActive(num5 != 0UL);
			}
		}
		while (num6 != (ulong)0L);
		uint num7;
		base.Die((int)num7);
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x000A8E60 File Offset: 0x000A7060
	[Token(Token = "0x6001FCD")]
	[Address(RVA = "0x5A2320", Offset = "0x5A0920", VA = "0x1805A2320", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		bool flag;
		if (!flag)
		{
			SpriteRenderer component = this.theFirstArmor.GetComponent<SpriteRenderer>();
			int num = 0;
			component.enabled = num != 0;
			Transform transform = this.theFirstArmor.transform;
			int num2 = 0;
			GameObject gameObject = transform.GetChild(num2).gameObject;
			int num3 = 0;
			gameObject.SetActive(num3 != 0);
			uint num4;
			ulong num5;
			this.theFirstArmor.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
			return;
		}
		SpriteRenderer component2 = this.theFirstArmor.GetComponent<SpriteRenderer>();
		int num6 = 0;
		component2.enabled = num6 != 0;
		Transform transform2 = this.theFirstArmor.transform;
		int num7 = 0;
		ulong num8;
		transform2.GetChild(num7).gameObject.SetActive(num8 != 0UL);
		uint num9;
		GameObject gameObject2 = this.theFirstArmor.transform.GetChild((int)num9).gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x000A8F2C File Offset: 0x000A712C
	[Token(Token = "0x6001FCE")]
	[Address(RVA = "0x588740", Offset = "0x586D40", VA = "0x180588740", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x000A8F68 File Offset: 0x000A7168
	[Token(Token = "0x6001FCF")]
	[Address(RVA = "0x5A2590", Offset = "0x5A0B90", VA = "0x1805A2590", Slot = "75")]
	public override void KillByCaltrop()
	{
		this.anim.SetTrigger("shake");
		this.anim.SetTrigger("GoDie");
		BoxCollider2D component = base.GetComponent<BoxCollider2D>();
		int num = 0;
		int num2 = 0;
		component.enabled = num2 != 0;
		this.beforeDying = true;
		base.Invoke("DieAndExplde", (float)num);
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x000A8FC0 File Offset: 0x000A71C0
	[Token(Token = "0x6001FD0")]
	[Address(RVA = "0x5A2660", Offset = "0x5A0C60", VA = "0x1805A2660", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)16)))
		{
			int num = 0;
			base.SetCold(time, num, true);
		}
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x000A8FE4 File Offset: 0x000A71E4
	[Token(Token = "0x6001FD1")]
	[Address(RVA = "0x5A26B0", Offset = "0x5A0CB0", VA = "0x1805A26B0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)16)))
		{
			int num = 0;
			base.SetFreeze(time, num);
		}
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x000A9008 File Offset: 0x000A7208
	[Token(Token = "0x6001FD2")]
	[Address(RVA = "0x5A2040", Offset = "0x5A0640", VA = "0x1805A2040", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)16)))
		{
			base.Buttered(time, sprite);
		}
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x000A9028 File Offset: 0x000A7228
	[Token(Token = "0x6001FD3")]
	[Address(RVA = "0x5A2880", Offset = "0x5A0E80", VA = "0x1805A2880")]
	public DrownCatapultZombie()
	{
		List<GameObject> list = new List();
		this.weapons = list;
		List<GameObject> list2 = new List();
		this.weapons2 = list2;
		List<GameObject> list3 = new List();
		this.damaged = list3;
		base..ctor();
	}

	// Token: 0x0400112E RID: 4398
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x400112E")]
	public List<GameObject> weapons;

	// Token: 0x0400112F RID: 4399
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x400112F")]
	public List<GameObject> weapons2;

	// Token: 0x04001130 RID: 4400
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4001130")]
	public List<GameObject> damaged;
}
