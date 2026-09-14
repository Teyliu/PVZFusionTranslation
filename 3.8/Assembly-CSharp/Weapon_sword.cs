using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007A6 RID: 1958
[Token(Token = "0x20007A6")]
public class Weapon_sword : PlayerWeapon
{
	// Token: 0x060027C2 RID: 10178 RVA: 0x000D7CA0 File Offset: 0x000D5EA0
	[Token(Token = "0x60027C2")]
	[Address(RVA = "0x618960", Offset = "0x616F60", VA = "0x180618960")]
	public void AttackZombie(Zombie zombie)
	{
		int attackDamage = base.AttackDamage;
		float num = global::UnityEngine.Random.Range(1.3f, 1.8f);
		GameAPP.PlaySound(133, 0.5f, num);
	}

	// Token: 0x060027C3 RID: 10179 RVA: 0x000D7CDC File Offset: 0x000D5EDC
	[Token(Token = "0x60027C3")]
	[Address(RVA = "0x6190F0", Offset = "0x6176F0", VA = "0x1806190F0", Slot = "10")]
	protected override void Shoot()
	{
		if (Board.Instance.enermyCount > 0)
		{
			int num = 0;
			GameObject gameObject = this.bigSwordPrefab;
			Transform transform = base.transform;
			uint num3;
			uint num4;
			int num2 = global::UnityEngine.Random.Range((int)num3, (int)num4);
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform2 = Board.Instance.transform;
			GameObject gameObject2;
			BigSword component = gameObject2.GetComponent<BigSword>();
			int size = this.bigSwords._size;
			component.targetPosition = component;
			Action<Vector2> action;
			component.action = action;
			num++;
		}
	}

	// Token: 0x060027C4 RID: 10180 RVA: 0x000D7D5C File Offset: 0x000D5F5C
	[Token(Token = "0x60027C4")]
	[Address(RVA = "0x618710", Offset = "0x616D10", VA = "0x180618710")]
	private void AttackZombie(Vector2 position)
	{
		LayerMask zombieLayer = this.zombieLayer;
		int attackDamage = base.AttackDamage;
		int num = 0;
		int num2 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
			}
			num2++;
		}
		float num3 = global::UnityEngine.Random.Range(1.2f, 1.4f);
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, num3);
		ParticleManager instance = ParticleManager.Instance;
		Mouse instance2 = Mouse.Instance;
	}

	// Token: 0x060027C5 RID: 10181 RVA: 0x000D7DD0 File Offset: 0x000D5FD0
	[Token(Token = "0x60027C5")]
	[Address(RVA = "0x618B20", Offset = "0x617120", VA = "0x180618B20", Slot = "9")]
	public override void OnUpdate()
	{
		do
		{
			base.OnUpdate();
			List<Weapon_sword_item> list = this.swords;
			int shootCount = this.shootCount;
			Weapon_sword_item component = global::UnityEngine.Object.Instantiate<GameObject>(this.swordPrefab).GetComponent<Weapon_sword_item>();
			Transform transform = component.transform;
			Transform transform2 = base.transform;
			transform.parentInternal = transform2;
			component.weapon_Sword = this;
			int num = 0;
			if (component != num)
			{
				List<Weapon_sword_item> list2 = this.swords;
				if (this.swords != 0)
				{
					continue;
				}
			}
			List<Weapon_sword_item> list3 = this.swords;
			int shootCount2 = this.shootCount;
			List<Weapon_sword_item> list4 = this.swords;
			int size = list4._size;
			Weapon_sword_item weapon_sword_item = list4[size];
			int size2 = this.swords._size;
			this.swords.RemoveAt(size2);
			global::UnityEngine.Object.Destroy(weapon_sword_item.gameObject);
		}
		while (this.swords != 0);
		int num2 = 0;
		Weapon_sword_item weapon_sword_item2 = this.swords[num2];
		int num3 = 0;
		if (!(weapon_sword_item2 == num3))
		{
			float num4 = this.rotationSpeed;
			float time = Time.time;
			Transform center = this.player.center;
			Player player = this.player;
			Transform center2 = player.center;
			Transform transform3 = this.swords[num2].transform;
			Transform transform4 = this.swords[num2].transform;
			Transform transform5 = this.swords[num2].transform;
			Transform transform6 = this.swordPrefab.transform;
			Vector3 vector;
			float num5 = this.loadingSpeed * vector.z;
		}
		List<Weapon_sword_item> list5 = this.swords;
		num2++;
	}

	// Token: 0x060027C6 RID: 10182 RVA: 0x000D7F68 File Offset: 0x000D6168
	[Token(Token = "0x60027C6")]
	[Address(RVA = "0x618A40", Offset = "0x617040", VA = "0x180618A40")]
	private Weapon_sword_item GetSword()
	{
		Weapon_sword_item component = global::UnityEngine.Object.Instantiate<GameObject>(this.swordPrefab).GetComponent<Weapon_sword_item>();
		Transform transform = component.transform;
		Transform transform2 = base.transform;
		transform.parentInternal = transform2;
		component.weapon_Sword = this;
		return component;
	}

	// Token: 0x060027C7 RID: 10183 RVA: 0x000D7FAC File Offset: 0x000D61AC
	[Token(Token = "0x60027C7")]
	[Address(RVA = "0x6193F0", Offset = "0x6179F0", VA = "0x1806193F0")]
	public Weapon_sword()
	{
		List<Weapon_sword_item> list = new List();
		this.swords = list;
		this.rotationRadius = 1.5f;
		this.rotationSpeed = 120f;
		List<BigSword> list2 = new List();
		this.bigSwords = list2;
		base..ctor();
	}

	// Token: 0x04001605 RID: 5637
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001605")]
	public List<Weapon_sword_item> swords;

	// Token: 0x04001606 RID: 5638
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001606")]
	private readonly float rotationRadius;

	// Token: 0x04001607 RID: 5639
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4001607")]
	private readonly float rotationSpeed;

	// Token: 0x04001608 RID: 5640
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001608")]
	public GameObject swordPrefab;

	// Token: 0x04001609 RID: 5641
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001609")]
	private readonly List<BigSword> bigSwords;

	// Token: 0x0400160A RID: 5642
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400160A")]
	public GameObject bigSwordPrefab;
}
