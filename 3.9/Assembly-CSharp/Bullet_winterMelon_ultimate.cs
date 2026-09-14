using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001DB RID: 475
[Token(Token = "0x20001DB")]
public class Bullet_winterMelon_ultimate : Bullet_cabbage
{
	// Token: 0x0600080D RID: 2061 RVA: 0x00028C78 File Offset: 0x00026E78
	[Token(Token = "0x600080D")]
	[Address(RVA = "0x8E2420", Offset = "0x8E0A20", VA = "0x1808E2420", Slot = "10")]
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

	// Token: 0x0600080E RID: 2062 RVA: 0x00028CBC File Offset: 0x00026EBC
	[Token(Token = "0x600080E")]
	[Address(RVA = "0x8E3000", Offset = "0x8E1600", VA = "0x1808E3000", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		this.existBlackHole = false;
		Transform transform = base.transform;
		GameObject gameObject = this.theBlackHole;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x00028CF4 File Offset: 0x00026EF4
	[Token(Token = "0x600080F")]
	[Address(RVA = "0x8E2490", Offset = "0x8E0A90", VA = "0x1808E2490", Slot = "17")]
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

	// Token: 0x06000810 RID: 2064 RVA: 0x00028D8C File Offset: 0x00026F8C
	[Token(Token = "0x6000810")]
	[Address(RVA = "0x8E2750", Offset = "0x8E0D50", VA = "0x1808E2750", Slot = "22")]
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

	// Token: 0x06000811 RID: 2065 RVA: 0x00028EDC File Offset: 0x000270DC
	[Token(Token = "0x6000811")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_winterMelon_ultimate()
	{
	}

	// Token: 0x040003C0 RID: 960
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40003C0")]
	public bool existBlackHole;

	// Token: 0x040003C1 RID: 961
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40003C1")]
	private GameObject theBlackHole;

	// Token: 0x040003C2 RID: 962
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40003C2")]
	public GameObject holePrefab;
}
