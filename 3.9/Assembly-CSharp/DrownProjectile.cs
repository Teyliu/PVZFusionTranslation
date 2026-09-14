using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200008A RID: 138
[Token(Token = "0x200008A")]
public class DrownProjectile : AirProjectile
{
	// Token: 0x06000236 RID: 566 RVA: 0x0000768C File Offset: 0x0000588C
	[Token(Token = "0x6000236")]
	[Address(RVA = "0x3F3720", Offset = "0x3F1D20", VA = "0x1803F3720", Slot = "8")]
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

	// Token: 0x06000237 RID: 567 RVA: 0x000076F8 File Offset: 0x000058F8
	[Token(Token = "0x6000237")]
	[Address(RVA = "0x3F3CD0", Offset = "0x3F22D0", VA = "0x1803F3CD0")]
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

	// Token: 0x06000238 RID: 568 RVA: 0x00007734 File Offset: 0x00005934
	[Token(Token = "0x6000238")]
	[Address(RVA = "0x3F3E80", Offset = "0x3F2480", VA = "0x1803F3E80")]
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

	// Token: 0x06000239 RID: 569 RVA: 0x000077CC File Offset: 0x000059CC
	[Token(Token = "0x6000239")]
	[Address(RVA = "0x3F4070", Offset = "0x3F2670", VA = "0x1803F4070")]
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

	// Token: 0x0600023A RID: 570 RVA: 0x000078E4 File Offset: 0x00005AE4
	[Token(Token = "0x600023A")]
	[Address(RVA = "0x3F3B70", Offset = "0x3F2170", VA = "0x1803F3B70")]
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

	// Token: 0x0600023B RID: 571 RVA: 0x00007944 File Offset: 0x00005B44
	[Token(Token = "0x600023B")]
	[Address(RVA = "0x3F3890", Offset = "0x3F1E90", VA = "0x1803F3890")]
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
				int num3 = 0;
				FreezedPlant freezedPlant = FreezedPlant.FreezePlant(num, num3 != 0);
			}
		}
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00007A1C File Offset: 0x00005C1C
	[Token(Token = "0x600023C")]
	[Address(RVA = "0x3F4460", Offset = "0x3F2A60", VA = "0x1803F4460")]
	public DrownProjectile()
	{
	}

	// Token: 0x0400008A RID: 138
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400008A")]
	public bool land;

	// Token: 0x0400008B RID: 139
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400008B")]
	private float existTime;

	// Token: 0x0400008C RID: 140
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400008C")]
	private bool hit;

	// Token: 0x0400008D RID: 141
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400008D")]
	public Plant targetPlant;

	// Token: 0x0400008E RID: 142
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400008E")]
	public bool horizontal;

	// Token: 0x0400008F RID: 143
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x400008F")]
	public bool free;

	// Token: 0x04000090 RID: 144
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x4000090")]
	public bool big;

	// Token: 0x04000091 RID: 145
	[FieldOffset(Offset = "0x6B")]
	[Token(Token = "0x4000091")]
	public bool cold;
}
