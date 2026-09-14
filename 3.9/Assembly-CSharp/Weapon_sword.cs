using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007DF RID: 2015
[Token(Token = "0x20007DF")]
public class Weapon_sword : PlayerWeapon
{
	// Token: 0x060028F1 RID: 10481 RVA: 0x000DCC5C File Offset: 0x000DAE5C
	[Token(Token = "0x60028F1")]
	[Address(RVA = "0x67C200", Offset = "0x67A800", VA = "0x18067C200")]
	public void AttackZombie(Zombie zombie)
	{
		int attackDamage = base.AttackDamage;
		float num = global::UnityEngine.Random.Range(1.3f, 1.8f);
		GameAPP.PlaySound(133, 0.5f, num);
	}

	// Token: 0x060028F2 RID: 10482 RVA: 0x000DCC98 File Offset: 0x000DAE98
	[Token(Token = "0x60028F2")]
	[Address(RVA = "0x67C990", Offset = "0x67AF90", VA = "0x18067C990", Slot = "10")]
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

	// Token: 0x060028F3 RID: 10483 RVA: 0x000DCD18 File Offset: 0x000DAF18
	[Token(Token = "0x60028F3")]
	[Address(RVA = "0x67BFB0", Offset = "0x67A5B0", VA = "0x18067BFB0")]
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

	// Token: 0x060028F4 RID: 10484 RVA: 0x000DCD8C File Offset: 0x000DAF8C
	[Token(Token = "0x60028F4")]
	[Address(RVA = "0x67C3C0", Offset = "0x67A9C0", VA = "0x18067C3C0", Slot = "9")]
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

	// Token: 0x060028F5 RID: 10485 RVA: 0x000DCF24 File Offset: 0x000DB124
	[Token(Token = "0x60028F5")]
	[Address(RVA = "0x67C2E0", Offset = "0x67A8E0", VA = "0x18067C2E0")]
	private Weapon_sword_item GetSword()
	{
		Weapon_sword_item component = global::UnityEngine.Object.Instantiate<GameObject>(this.swordPrefab).GetComponent<Weapon_sword_item>();
		Transform transform = component.transform;
		Transform transform2 = base.transform;
		transform.parentInternal = transform2;
		component.weapon_Sword = this;
		return component;
	}

	// Token: 0x060028F6 RID: 10486 RVA: 0x000DCF68 File Offset: 0x000DB168
	[Token(Token = "0x60028F6")]
	[Address(RVA = "0x67CC90", Offset = "0x67B290", VA = "0x18067CC90")]
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

	// Token: 0x040016E1 RID: 5857
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40016E1")]
	public List<Weapon_sword_item> swords;

	// Token: 0x040016E2 RID: 5858
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40016E2")]
	private readonly float rotationRadius;

	// Token: 0x040016E3 RID: 5859
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40016E3")]
	private readonly float rotationSpeed;

	// Token: 0x040016E4 RID: 5860
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40016E4")]
	public GameObject swordPrefab;

	// Token: 0x040016E5 RID: 5861
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40016E5")]
	private readonly List<BigSword> bigSwords;

	// Token: 0x040016E6 RID: 5862
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40016E6")]
	public GameObject bigSwordPrefab;
}
