using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000B8 RID: 184
[Token(Token = "0x20000B8")]
public class FruitObject : MonoBehaviour, IDamageMaker
{
	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000345 RID: 837 RVA: 0x0000E868 File Offset: 0x0000CA68
	// (set) Token: 0x06000346 RID: 838 RVA: 0x0000E880 File Offset: 0x0000CA80
	[Token(Token = "0x1700007F")]
	public Team Team
	{
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x414480", Offset = "0x412A80", VA = "0x180414480", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x06000347 RID: 839 RVA: 0x0000E894 File Offset: 0x0000CA94
	[Token(Token = "0x6000347")]
	[Address(RVA = "0x412B20", Offset = "0x411120", VA = "0x180412B20")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
	}

	// Token: 0x06000348 RID: 840 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
	[Token(Token = "0x6000348")]
	[Address(RVA = "0x412E10", Offset = "0x411410", VA = "0x180412E10")]
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

	// Token: 0x06000349 RID: 841 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
	[Token(Token = "0x6000349")]
	[Address(RVA = "0x412BB0", Offset = "0x4111B0", VA = "0x180412BB0")]
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

	// Token: 0x0600034A RID: 842 RVA: 0x0000E9C8 File Offset: 0x0000CBC8
	[Token(Token = "0x600034A")]
	[Address(RVA = "0x413B30", Offset = "0x412130", VA = "0x180413B30")]
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

	// Token: 0x0600034B RID: 843 RVA: 0x0000EB4C File Offset: 0x0000CD4C
	[Token(Token = "0x600034B")]
	[Address(RVA = "0x412EC0", Offset = "0x4114C0", VA = "0x180412EC0")]
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
				goto IL_0169;
			}
			if (flag2)
			{
				if (flag2)
				{
					if (fruitType != FruitType.WinterMelon)
					{
						goto IL_0169;
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
					component.theDamage = gameObject;
				}
				Dictionary<FruitBuffType, int> buffCount4 = this.manager.buffCount;
				bool flag4;
				if (!flag4)
				{
					goto IL_0169;
				}
			}
			Dictionary<FruitBuffType, int> buffCount5 = this.manager.buffCount;
			bool flag5;
			if (!flag5 || (this.split ? 1 : 0) != num || flag5)
			{
				goto IL_0169;
			}
			BoardAction boardAction = Board.Instance.boardAction;
		}
		Dictionary<FruitBuffType, int> buffCount6 = this.manager.buffCount;
		bool flag6;
		if (flag6)
		{
			num4 += (flag6 ? 1 : 0);
		}
		IL_0169:
		Transform transform6 = base.transform;
		string[] array = new string[] { "Zombie" };
		int num7 = 0;
		int mask = LayerMask.GetMask(array);
		Collider2D[] array2;
		if (num < array2.Length)
		{
			if (array2[num].TryGetComponent<Zombie>(num7) && this.fruitType <= FruitType.UltimateFireMelon)
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
					int num8 = num4 * (flag8 ? 1 : 0);
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
				float num9;
				Lawnf.SetZombieHealth(component2, num9);
				num++;
				FruitNinjaManager fruitNinjaManager6 = this.manager;
				bool flag11;
				if (flag11)
				{
					int num10 = 0;
					if (component2 != num10)
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

	// Token: 0x0600034C RID: 844 RVA: 0x0000EDB8 File Offset: 0x0000CFB8
	[Token(Token = "0x600034C")]
	[Address(RVA = "0x412B70", Offset = "0x411170", VA = "0x180412B70", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x0600034D RID: 845 RVA: 0x0000EDCC File Offset: 0x0000CFCC
	[Token(Token = "0x600034D")]
	[Address(RVA = "0x414460", Offset = "0x412A60", VA = "0x180414460")]
	public FruitObject()
	{
	}

	// Token: 0x040001A8 RID: 424
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A8")]
	public int scoreValue = (int)((ulong)1L);

	// Token: 0x040001A9 RID: 425
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001A9")]
	public GameObject slicedPrefab;

	// Token: 0x040001AA RID: 426
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001AA")]
	public FruitType fruitType;

	// Token: 0x040001AB RID: 427
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001AB")]
	public FruitNinjaManager manager;

	// Token: 0x040001AC RID: 428
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001AC")]
	public Rigidbody2D rb;

	// Token: 0x040001AD RID: 429
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001AD")]
	public bool split;

	// Token: 0x040001AE RID: 430
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40001AE")]
	private int baseDamage = (int)((ulong)120L);

	// Token: 0x040001AF RID: 431
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001AF")]
	private bool isSliced;
}
