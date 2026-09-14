using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000652 RID: 1618
[Token(Token = "0x2000652")]
public class DrownCatapultZombie : CatapultZombie
{
	// Token: 0x06001EC4 RID: 7876 RVA: 0x000A44C4 File Offset: 0x000A26C4
	[Token(Token = "0x6001EC4")]
	[Address(RVA = "0x53F790", Offset = "0x53DD90", VA = "0x18053F790", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.basketballNum = (int)((ulong)2L);
	}

	// Token: 0x06001EC5 RID: 7877 RVA: 0x000A44E0 File Offset: 0x000A26E0
	[Token(Token = "0x6001EC5")]
	[Address(RVA = "0x53FA30", Offset = "0x53E030", VA = "0x18053FA30", Slot = "75")]
	protected override void CataUpdate()
	{
		float boardMaxX = this.board.boardMaxX;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)17)))
		{
		}
		Transform axis = this.axis;
		base.SearchPlantUpdate();
	}

	// Token: 0x06001EC6 RID: 7878 RVA: 0x000A4540 File Offset: 0x000A2740
	[Token(Token = "0x6001EC6")]
	[Address(RVA = "0x53F5A0", Offset = "0x53DBA0", VA = "0x18053F5A0", Slot = "74")]
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

	// Token: 0x06001EC7 RID: 7879 RVA: 0x000A45AC File Offset: 0x000A27AC
	[Token(Token = "0x6001EC7")]
	[Address(RVA = "0x540090", Offset = "0x53E690", VA = "0x180540090")]
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

	// Token: 0x06001EC8 RID: 7880 RVA: 0x000A4604 File Offset: 0x000A2804
	[Token(Token = "0x6001EC8")]
	[Address(RVA = "0x53FB30", Offset = "0x53E130", VA = "0x18053FB30")]
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

	// Token: 0x06001EC9 RID: 7881 RVA: 0x000A4638 File Offset: 0x000A2838
	[Token(Token = "0x6001EC9")]
	[Address(RVA = "0x53F410", Offset = "0x53DA10", VA = "0x18053F410")]
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

	// Token: 0x06001ECA RID: 7882 RVA: 0x000A466C File Offset: 0x000A286C
	[Token(Token = "0x6001ECA")]
	[Address(RVA = "0x53F7B0", Offset = "0x53DDB0", VA = "0x18053F7B0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num6;
		do
		{
			int num = this.theHealth;
			num -= theDamage;
			this.theHealth = num;
			num -= theDamage;
			int num2 = this.theMaxHealth;
			num2 -= theDamage;
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

	// Token: 0x06001ECB RID: 7883 RVA: 0x000A4708 File Offset: 0x000A2908
	[Token(Token = "0x6001ECB")]
	[Address(RVA = "0x53FCC0", Offset = "0x53E2C0", VA = "0x18053FCC0", Slot = "61")]
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

	// Token: 0x06001ECC RID: 7884 RVA: 0x000A47D4 File Offset: 0x000A29D4
	[Token(Token = "0x6001ECC")]
	[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x000A4810 File Offset: 0x000A2A10
	[Token(Token = "0x6001ECD")]
	[Address(RVA = "0x53FF30", Offset = "0x53E530", VA = "0x18053FF30", Slot = "73")]
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

	// Token: 0x06001ECE RID: 7886 RVA: 0x000A4868 File Offset: 0x000A2A68
	[Token(Token = "0x6001ECE")]
	[Address(RVA = "0x540000", Offset = "0x53E600", VA = "0x180540000", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)16)))
		{
			int num = 0;
			base.SetCold(time, num, true);
		}
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x000A488C File Offset: 0x000A2A8C
	[Token(Token = "0x6001ECF")]
	[Address(RVA = "0x540050", Offset = "0x53E650", VA = "0x180540050", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)16)))
		{
			int num = 0;
			base.SetFreeze(time, num);
		}
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x000A48B0 File Offset: 0x000A2AB0
	[Token(Token = "0x6001ED0")]
	[Address(RVA = "0x53F9E0", Offset = "0x53DFE0", VA = "0x18053F9E0", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)16)))
		{
			base.Buttered(time, sprite);
		}
	}

	// Token: 0x06001ED1 RID: 7889 RVA: 0x000A48D0 File Offset: 0x000A2AD0
	[Token(Token = "0x6001ED1")]
	[Address(RVA = "0x540220", Offset = "0x53E820", VA = "0x180540220")]
	public DrownCatapultZombie()
	{
		List<GameObject> list = new List();
		this.weapons = list;
		List<GameObject> list2 = new List();
		this.weapons2 = list2;
		List<GameObject> list3 = new List();
		this.damaged = list3;
		this.basketballNum = (int)((ulong)25L);
		base..ctor();
	}

	// Token: 0x04001062 RID: 4194
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4001062")]
	public List<GameObject> weapons;

	// Token: 0x04001063 RID: 4195
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001063")]
	public List<GameObject> weapons2;

	// Token: 0x04001064 RID: 4196
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001064")]
	public List<GameObject> damaged;
}
