using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D1 RID: 465
[Token(Token = "0x20001D1")]
public class Bullet_winterMelon_ultimate : Bullet_cabbage
{
	// Token: 0x060007F7 RID: 2039 RVA: 0x000290B8 File Offset: 0x000272B8
	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x853740", Offset = "0x851D40", VA = "0x180853740", Slot = "9")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		int num2 = 0;
		GameObject gameObject = child.GetChild(num2).gameObject;
		this.theBlackHole = gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x000290FC File Offset: 0x000272FC
	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x854320", Offset = "0x852920", VA = "0x180854320", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		this.existBlackHole = false;
		Transform transform = base.transform;
		GameObject gameObject = this.theBlackHole;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x00029134 File Offset: 0x00027334
	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x8537B0", Offset = "0x851DB0", VA = "0x1808537B0", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = this._damage;
		num += num;
		if (this.existBlackHole)
		{
			GameObject gameObject = this.holePrefab;
			Transform transform2 = base.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform3 = Board.Instance.transform;
			GameObject gameObject2;
			BlackHole component = gameObject2.GetComponent<BlackHole>();
			component.theDamage = num;
			int theBulletRow = this.theBulletRow;
			component.Row = theBulletRow;
		}
		base.Die();
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x000291CC File Offset: 0x000273CC
	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x853A70", Offset = "0x852070", VA = "0x180853A70", Slot = "25")]
	protected override void HitZombie(Zombie z)
	{
		ulong num4;
		do
		{
			int damage = this._damage;
			if (this.existBlackHole)
			{
				Transform axis = z.axis;
				Mouse instance = Mouse.Instance;
				GameObject gameObject = this.holePrefab;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = Board.Instance.transform;
				GameObject gameObject2;
				BlackHole component = gameObject2.GetComponent<BlackHole>();
				component.theDamage = damage;
				int theZombieRow = z.theZombieRow;
				component.Row = theZombieRow;
				PlantType fromType = this.fromType;
				component.fromType = fromType;
			}
			int theZombieRow2 = z.theZombieRow;
			Transform transform2 = base.transform;
			Vector3 vector;
			float z2 = vector.z;
			LayerMask zombieLayer = this.zombieLayer;
			List<Zombie> list = new List();
			int num = 0;
			int num2 = 0;
			Collider2D[] array;
			if (num2 < array.Length)
			{
				bool flag;
				bool flag2;
				if (flag && flag2)
				{
					ulong num3;
					if (num3 != (ulong)0L)
					{
					}
					PlantType fromType2 = this.fromType;
				}
				num++;
			}
			Predicate<Zombie> predicate;
			if (Bullet_winterMelon_ultimate.<>c.<>9__6_0 == 0)
			{
				Bullet_winterMelon_ultimate.<>c.<>9__6_0 = predicate;
			}
			if (!list.Find(predicate))
			{
				break;
			}
			bool flag3;
			if (flag3)
			{
				bool flag4;
				while (flag4)
				{
				}
				bool flag5;
				flag4 = flag5;
			}
		}
		while (num4 != (ulong)0L);
		bool flag6;
		if (flag6)
		{
		}
		ParticleManager instance2 = ParticleManager.Instance;
		uint num5;
		uint num6;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num5, (int)num6), 0.5f, 1f);
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x0002931C File Offset: 0x0002751C
	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_winterMelon_ultimate()
	{
	}

	// Token: 0x040003B6 RID: 950
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40003B6")]
	public bool existBlackHole;

	// Token: 0x040003B7 RID: 951
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40003B7")]
	private GameObject theBlackHole;

	// Token: 0x040003B8 RID: 952
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40003B8")]
	public GameObject holePrefab;
}
