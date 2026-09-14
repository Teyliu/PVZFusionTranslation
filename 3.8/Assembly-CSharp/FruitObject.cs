using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000B3 RID: 179
[Token(Token = "0x20000B3")]
public class FruitObject : MonoBehaviour, IDamageMaker
{
	// Token: 0x17000042 RID: 66
	// (get) Token: 0x0600032A RID: 810 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
	// (set) Token: 0x0600032B RID: 811 RVA: 0x0000E508 File Offset: 0x0000C708
	[Token(Token = "0x17000042")]
	public Team Team
	{
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x3C76B0", Offset = "0x3C5CB0", VA = "0x1803C76B0", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0000E51C File Offset: 0x0000C71C
	[Token(Token = "0x600032C")]
	[Address(RVA = "0x3C5D50", Offset = "0x3C4350", VA = "0x1803C5D50")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
	}

	// Token: 0x0600032D RID: 813 RVA: 0x0000E538 File Offset: 0x0000C738
	[Token(Token = "0x600032D")]
	[Address(RVA = "0x3C6040", Offset = "0x3C4640", VA = "0x1803C6040")]
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<FruitBlade>() && !this.isSliced)
		{
			if (this.manager.combo)
			{
			}
			this.Slice();
		}
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0000E578 File Offset: 0x0000C778
	[Token(Token = "0x600032E")]
	[Address(RVA = "0x3C5DE0", Offset = "0x3C43E0", VA = "0x1803C5DE0")]
	private void FixedUpdate()
	{
		if (!this.isSliced)
		{
			Transform transform = base.transform;
			Vector3 vector;
			float y = vector.y;
			Board instance = Board.Instance;
			Mouse instance2 = Mouse.Instance;
			int rowNum = instance.rowNum;
			if (instance2.GetBoxYFromRow(rowNum) > y)
			{
				Vector2 velocity = this.rb.velocity;
				ulong num;
				bool flag = this.manager.buffCount.TryGetValue((uint)8, num);
				long num2;
				if (!flag || (flag ? 1L : 0L) >= num2)
				{
					if (!this.split)
					{
						FruitNinjaManager.Instance.LoseScore(10f);
					}
					global::UnityEngine.Object.Destroy(base.gameObject);
					return;
				}
				Rigidbody2D rigidbody2D = this.rb;
				Vector2 velocity2 = rigidbody2D.velocity;
				Rigidbody2D rigidbody2D2 = this.rb;
				int num3 = 0;
				Vector2 velocity3 = rigidbody2D2.velocity;
				rigidbody2D.velocity = num3;
			}
		}
	}

	// Token: 0x0600032F RID: 815 RVA: 0x0000E650 File Offset: 0x0000C850
	[Token(Token = "0x600032F")]
	[Address(RVA = "0x3C6D60", Offset = "0x3C5360", VA = "0x1803C6D60")]
	private void Slice()
	{
		int num;
		GameObject gameObject2;
		do
		{
			num = 0;
			this.isSliced = true;
			GameObject gameObject = this.slicedPrefab;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			Transform transform2 = base.transform;
			Transform transform3 = Board.Instance.transform;
			IEnumerator enumerator = gameObject2.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				Vector3 vector2;
				float z2 = vector2.z;
				while (!this.split)
				{
				}
				Vector3 vector3;
				float z3 = vector3.z;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		int num2 = 0;
		Rigidbody2D[] componentsInChildren = gameObject2.GetComponentsInChildren<Rigidbody2D>();
		float num3;
		float num5;
		if (num2 < componentsInChildren.Length)
		{
			num3 = global::UnityEngine.Random.Range(-5f, 5f);
			float num4 = global::UnityEngine.Random.Range(num3, 5f);
			num5 = global::UnityEngine.Random.Range(-10f, 10f);
			num2++;
		}
		FruitNinjaManager.Instance.AddScore(num5);
		num3 = global::UnityEngine.Random.Range(1.3f, 1.8f);
		uint num6;
		GameAPP.PlaySound((int)num6, 0.5f, num3);
		uint num7;
		uint num8;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num7, (int)num8), 0.5f, 1f);
		GameObject gameObject3;
		global::UnityEngine.Object.Destroy(gameObject3);
		global::UnityEngine.Object.Destroy(gameObject2, 0.5f);
		bool flag;
		if (flag && num2 > 0)
		{
			float num9 = global::UnityEngine.Random.Range(1f, 3f);
			FruitObject fruitObject;
			fruitObject.split = true;
			Transform transform4 = fruitObject.transform;
			Vector3 vector4;
			float z4 = vector4.z;
			num2++;
		}
	}

	// Token: 0x06000330 RID: 816 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
	[Token(Token = "0x6000330")]
	[Address(RVA = "0x3C60F0", Offset = "0x3C46F0", VA = "0x1803C60F0")]
	private void SliceEvent()
	{
		int num = 0;
		Mouse instance = Mouse.Instance;
		Transform transform = base.transform;
		Mouse instance2 = Mouse.Instance;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		int num2 = 0;
		int num3 = this.baseDamage;
		FruitNinjaManager fruitNinjaManager = this.manager;
		num3 -= transform3;
		int num4;
		if ((this.split ? 1 : 0) == num)
		{
			num4 = this.baseDamage;
		}
		Dictionary<FruitBuffType, int> buffCount = fruitNinjaManager.buffCount;
		int num5 = 0;
		bool flag = buffCount.TryGetValue(num5, num2);
		if (flag)
		{
			num4 += (flag ? 1 : 0);
		}
		FruitNinjaManager fruitNinjaManager2 = this.manager;
		bool flag2;
		if (fruitNinjaManager2.comboCount > 1)
		{
			Dictionary<FruitBuffType, int> buffCount2 = fruitNinjaManager2.buffCount;
			if (flag2)
			{
			}
		}
		FruitType fruitType = this.fruitType;
		if (flag2)
		{
			if (!flag2)
			{
				goto IL_0173;
			}
			if (flag2)
			{
				if (flag2)
				{
					if (fruitType != FruitType.WinterMelon)
					{
						goto IL_0173;
					}
					Dictionary<FruitBuffType, int> buffCount3 = this.manager.buffCount;
					bool flag3;
					if (flag3)
					{
						num4 += (flag3 ? 1 : 0);
					}
					Transform transform4 = base.transform;
					Mouse instance3 = Mouse.Instance;
					Transform transform5 = base.transform;
					GameObject gameObject;
					FireOcean component = gameObject.GetComponent<FireOcean>();
					int num6;
					component.theRow = num6;
					float num8;
					float num7 = num8 * 0.08f;
					component.theDamage = gameObject;
				}
				Dictionary<FruitBuffType, int> buffCount4 = this.manager.buffCount;
				bool flag4;
				if (!flag4)
				{
					goto IL_0173;
				}
			}
			Dictionary<FruitBuffType, int> buffCount5 = this.manager.buffCount;
			bool flag5;
			if (!flag5 || (this.split ? 1 : 0) != num || flag5)
			{
				goto IL_0173;
			}
			BoardAction boardAction = Board.Instance.boardAction;
		}
		Dictionary<FruitBuffType, int> buffCount6 = this.manager.buffCount;
		bool flag6;
		if (flag6)
		{
			num4 += (flag6 ? 1 : 0);
		}
		IL_0173:
		Transform transform6 = base.transform;
		string[] array = new string[] { "Zombie" };
		int num9 = 0;
		int mask = LayerMask.GetMask(array);
		Collider2D[] array2;
		if (num < array2.Length)
		{
			if (array2[num].TryGetComponent<Zombie>(num9) && this.fruitType <= FruitType.UltimateFireMelon)
			{
				FruitNinjaManager fruitNinjaManager3 = this.manager;
				bool flag7;
				if (flag7)
				{
				}
				bool flag8;
				if (!flag8)
				{
					FruitNinjaManager fruitNinjaManager4 = this.manager;
					int num10 = num4 * (flag8 ? 1 : 0);
					bool flag9;
					if (flag9)
					{
					}
				}
				num++;
				CreateZombie instance4 = CreateZombie.Instance;
				Zombie zombie;
				Zombie component2 = zombie.GetComponent<Zombie>();
				FruitNinjaManager fruitNinjaManager5 = this.manager;
				bool flag10;
				if (flag10)
				{
					component2.theAttackDamage = (flag10 ? 1 : 0);
				}
				float num11;
				Lawnf.SetZombieHealth(component2, num11);
				num++;
				FruitNinjaManager fruitNinjaManager6 = this.manager;
				bool flag11;
				if (flag11)
				{
					int num12 = 0;
					if (component2 != num12)
					{
					}
				}
				FruitNinjaManager fruitNinjaManager7 = this.manager;
				bool flag12;
				if (flag12)
				{
				}
				num++;
			}
			num++;
		}
	}

	// Token: 0x06000331 RID: 817 RVA: 0x0000EA48 File Offset: 0x0000CC48
	[Token(Token = "0x6000331")]
	[Address(RVA = "0x3C5DA0", Offset = "0x3C43A0", VA = "0x1803C5DA0", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x06000332 RID: 818 RVA: 0x0000EA5C File Offset: 0x0000CC5C
	[Token(Token = "0x6000332")]
	[Address(RVA = "0x3C7690", Offset = "0x3C5C90", VA = "0x1803C7690")]
	public FruitObject()
	{
	}

	// Token: 0x0400019B RID: 411
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400019B")]
	public int scoreValue = (int)((ulong)1L);

	// Token: 0x0400019C RID: 412
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400019C")]
	public GameObject slicedPrefab;

	// Token: 0x0400019D RID: 413
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400019D")]
	public FruitType fruitType;

	// Token: 0x0400019E RID: 414
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400019E")]
	public FruitNinjaManager manager;

	// Token: 0x0400019F RID: 415
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400019F")]
	public Rigidbody2D rb;

	// Token: 0x040001A0 RID: 416
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001A0")]
	public bool split;

	// Token: 0x040001A1 RID: 417
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40001A1")]
	private int baseDamage = (int)((ulong)120L);

	// Token: 0x040001A2 RID: 418
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001A2")]
	private bool isSliced;
}
