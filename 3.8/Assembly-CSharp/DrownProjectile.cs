using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000085 RID: 133
[Token(Token = "0x2000085")]
public class DrownProjectile : AirProjectile
{
	// Token: 0x0600021B RID: 539 RVA: 0x000072B8 File Offset: 0x000054B8
	[Token(Token = "0x600021B")]
	[Address(RVA = "0x3A7900", Offset = "0x3A5F00", VA = "0x1803A7900", Slot = "8")]
	protected override void OnFixedUpdate()
	{
		if (!this.land)
		{
			Rigidbody2D rb = this.rb;
			int num = 0;
			Vector2 velocity = rb.velocity;
			float fixedDeltaTime = Time.fixedDeltaTime;
			rb.velocity = num;
			Rigidbody2D rb2 = this.rb;
			Vector2 velocity2 = rb2.velocity;
			Vector3 vector;
			float z = vector.z;
			Vector3 vector2;
			float z2 = vector2.z;
			rb2.rotation = z2;
		}
	}

	// Token: 0x0600021C RID: 540 RVA: 0x00007324 File Offset: 0x00005524
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x3A7ED0", Offset = "0x3A64D0", VA = "0x1803A7ED0")]
	public void SetTarget(Vector2 startPosition, Plant targetPlant)
	{
		Transform axis = targetPlant.axis;
		Rigidbody2D rb = this.rb;
		float[] array;
		float num = array[1];
		this.dy = num;
		this.targetPlant = targetPlant;
		throw new NullReferenceException();
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00007360 File Offset: 0x00005560
	[Token(Token = "0x600021D")]
	[Address(RVA = "0x3A8080", Offset = "0x3A6680", VA = "0x1803A8080")]
	private void Start()
	{
		if (!this.free)
		{
			if (this.horizontal)
			{
				goto IL_003D;
			}
			Plant plant = this.targetPlant;
			int num = 0;
			if (plant == num)
			{
				this.rb.velocity = num;
			}
		}
		bool flag;
		if (flag)
		{
			goto IL_006C;
		}
		SortingGroup sortingGroup = this.AddComponent<SortingGroup>();
		IL_003D:
		Rigidbody2D rb = this.rb;
		float num2 = global::UnityEngine.Random.Range(12f, 14f);
		while (!this.big)
		{
		}
		Vector2 velocity = this.rb.velocity;
		IL_006C:
		int theRow = this.theRow;
		string text = string.Format("bullet{0}", theRow);
	}

	// Token: 0x0600021E RID: 542 RVA: 0x000073F8 File Offset: 0x000055F8
	[Token(Token = "0x600021E")]
	[Address(RVA = "0x3A8270", Offset = "0x3A6870", VA = "0x1803A8270")]
	private void Update()
	{
		float deltaTime = Time.deltaTime;
		this.existTime = deltaTime;
		if (!this.big)
		{
			if (deltaTime <= 3f)
			{
				goto IL_0050;
			}
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
		if (deltaTime > 30f)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
		}
		IL_0050:
		Transform transform2 = base.transform;
		Vector3 vector2;
		float y = vector2.y;
		Mouse instance = Mouse.Instance;
		Transform transform3 = base.transform;
		float num;
		if (num > y)
		{
			Rigidbody2D rb = this.rb;
			this.land = true;
			if (this.big)
			{
				GameObject gameObject = base.transform.Find("dirt").gameObject;
				int num2 = 0;
				if (gameObject != num2)
				{
					gameObject.SetActive(true);
					Transform transform4 = gameObject.transform;
					Quaternion identityQuaternion = Quaternion.identityQuaternion;
					transform4.rotation = identityQuaternion;
				}
			}
			BoxType[] roadType = Board.Instance.roadType;
			int theRow = this.theRow;
			if ("{il2cpp array field local52->}" == (ulong)1L)
			{
				global::UnityEngine.Object.Destroy(base.gameObject);
			}
		}
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00007510 File Offset: 0x00005710
	[Token(Token = "0x600021F")]
	[Address(RVA = "0x3A7D70", Offset = "0x3A6370", VA = "0x1803A7D70")]
	private void PositionUpdate()
	{
		Rigidbody2D rb = this.rb;
		int num = 0;
		Vector2 velocity = rb.velocity;
		float fixedDeltaTime = Time.fixedDeltaTime;
		rb.velocity = num;
		Rigidbody2D rb2 = this.rb;
		Vector2 velocity2 = rb2.velocity;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		rb2.rotation = z2;
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00007570 File Offset: 0x00005770
	[Token(Token = "0x6000220")]
	[Address(RVA = "0x3A7A70", Offset = "0x3A6070", VA = "0x1803A7A70")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		if ((this.land ? 1 : 0) == num && (this.hit ? 1 : 0) == num && collision.TryGetComponent<Plant>(num))
		{
			int theRow = this.theRow;
			Plant plant = this.targetPlant;
			bool flag = num == plant;
			if (!flag && this.horizontal == flag)
			{
				Plant plant2 = this.targetPlant;
				int num2 = 0;
				if (!(plant2 == num2))
				{
					return;
				}
			}
			if (this.big)
			{
				return;
			}
			if (!Lawnf.EveBalaced())
			{
				int damage = this.damage;
				num += damage;
				Dictionary<ZombieType, int> enermyCountDic = Board.Instance.enermyCountDic;
				bool flag2;
				if (flag2)
				{
				}
				if (flag2 || !flag2)
				{
				}
			}
			this.hit = true;
			base.Die();
			if (this.cold)
			{
			}
		}
	}

	// Token: 0x06000221 RID: 545 RVA: 0x00007638 File Offset: 0x00005838
	[Token(Token = "0x6000221")]
	[Address(RVA = "0x3A8660", Offset = "0x3A6C60", VA = "0x1803A8660")]
	public DrownProjectile()
	{
	}

	// Token: 0x0400007D RID: 125
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400007D")]
	public bool land;

	// Token: 0x0400007E RID: 126
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400007E")]
	private float existTime;

	// Token: 0x0400007F RID: 127
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400007F")]
	private bool hit;

	// Token: 0x04000080 RID: 128
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000080")]
	public Plant targetPlant;

	// Token: 0x04000081 RID: 129
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000081")]
	public bool horizontal;

	// Token: 0x04000082 RID: 130
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000082")]
	public bool free;

	// Token: 0x04000083 RID: 131
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x4000083")]
	public bool big;

	// Token: 0x04000084 RID: 132
	[FieldOffset(Offset = "0x6B")]
	[Token(Token = "0x4000084")]
	public bool cold;
}
