using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x0200022C RID: 556
[Token(Token = "0x200022C")]
public class Grave : GridItem
{
	// Token: 0x060009CB RID: 2507 RVA: 0x000353DC File Offset: 0x000335DC
	[Token(Token = "0x60009CB")]
	[Address(RVA = "0x87C600", Offset = "0x87AC00", VA = "0x18087C600")]
	private void Start()
	{
		int num;
		do
		{
			num = 0;
			int theItemRow = this.theItemRow;
			List<Plant> list = global::Lawnf.Get1x1Plants(this.theItemColumn, theItemRow);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
		Vector3 vector;
		float z = vector.z;
		bool flag2;
		if (flag2)
		{
		}
		Rigidbody2D rigidbody2D;
		ulong num2;
		rigidbody2D.isKinematic = num2 != 0UL;
		int num3 = 0;
		Transform transform;
		ulong num4;
		transform.GetChild(num3).AddComponent<BoxCollider2D>().isTrigger = num4 != 0UL;
		GameObject gameObject;
		List<SpriteRenderer> sprites = global::Core.Lawnf.GetSprites(gameObject);
		FlashEffect flashEffect = new FlashEffect(sprites);
		Predicate<SpriteRenderer> predicate;
		if (Grave.<>c.<>9__3_0 == 0)
		{
			Grave.<>c.<>9__3_0 = predicate;
		}
		int num5 = sprites.RemoveAll(predicate);
		Rigidbody2D rigidbody2D2;
		ulong num6;
		rigidbody2D2.isKinematic = num6 != 0UL;
		PhysicsMaterial2D physicsMaterial2D = Resources.Load<PhysicsMaterial2D>("Board/Game/BrickGame/paddle");
		rigidbody2D2.sharedMaterial = physicsMaterial2D;
		int num7 = 0;
		Transform transform2;
		BoxCollider2D boxCollider2D = transform2.GetChild(num7).AddComponent<BoxCollider2D>();
		GameObject gameObject2;
		List<SpriteRenderer> sprites2 = global::Core.Lawnf.GetSprites(gameObject2);
		FlashEffect flashEffect2 = new FlashEffect(sprites2);
		Predicate<SpriteRenderer> predicate2;
		if (Grave.<>c.<>9__3_1 == 0)
		{
			Grave.<>c.<>9__3_1 = predicate2;
		}
		int num8 = sprites2.RemoveAll(predicate2);
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x000354D8 File Offset: 0x000336D8
	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x87C200", Offset = "0x87A800", VA = "0x18087C200")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			if (!flag)
			{
				if (flag)
				{
					return;
				}
				if (!flag)
				{
					int theItemRow = this.theItemRow;
				}
			}
			if (this.ability != 0)
			{
			}
			float num = this.health;
			this.health = num;
			this.Die();
		}
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x00035528 File Offset: 0x00033728
	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x87CBF0", Offset = "0x87B1F0", VA = "0x18087CBF0")]
	public void TakeDamage(int value)
	{
		if (this.ability != 0)
		{
		}
		float num = this.health;
		this.health = num;
		this.Die();
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x00035554 File Offset: 0x00033754
	[Token(Token = "0x60009CE")]
	[Address(RVA = "0x87BE00", Offset = "0x87A400", VA = "0x18087BE00", Slot = "4")]
	public override void Die()
	{
		Board board = this.board;
		int num = 0;
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		CreateItem instance3 = CreateItem.Instance;
		GameAPP.PlaySound(16, 0.5f, 1f);
		GameAPP.PlaySound(125, 0.5f, 1f);
		Board board2 = this.board;
		BrickManager instance4 = BrickManager.Instance;
		int num2 = 0;
		CreateItem instance5 = CreateItem.Instance;
		int num3 = 0;
		int theItemRow = this.theItemRow;
		int theItemColumn = this.theItemColumn;
		GameObject gameObject = instance5.SetCoin(theItemColumn, theItemRow, num3, num, num2, num2 != 0);
		Board board3 = this.board;
		int num4 = 0;
		board3.GetPoint(1f, num4 != 0);
		ParticleManager instance6 = ParticleManager.Instance;
		Transform transform = base.transform;
		int num5 = 0;
		int num6 = 0;
		int theItemRow2 = this.theItemRow;
		ulong num7;
		Particle particle = instance6.SetParticle((ParticleType)((uint)119), num5, theItemRow2, num7 != 0UL, (float)num6);
		base.Die();
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x00035638 File Offset: 0x00033838
	[Token(Token = "0x60009CF")]
	[Address(RVA = "0x87C140", Offset = "0x87A740", VA = "0x18087C140")]
	private void FixedUpdate()
	{
		if (this.ability != 0)
		{
		}
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x00035650 File Offset: 0x00033850
	[Token(Token = "0x60009D0")]
	[Address(RVA = "0x87C360", Offset = "0x87A960", VA = "0x18087C360")]
	public void SetZombie()
	{
		ulong num3;
		do
		{
			int num = 0;
			GridSystem gridSystem = this.board.gridSystem;
			int theItemRow = this.theItemRow;
			int theItemColumn = this.theItemColumn;
			List<Plant> plants = gridSystem.GetGrid(theItemColumn, theItemRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		Vector3 vector;
		float z = vector.z;
		Grave.<MoveAndSummonZombie>d__9 <MoveAndSummonZombie>d__;
		<MoveAndSummonZombie>d__.<>1__state = (int)((ulong)0L);
		<MoveAndSummonZombie>d__.<>4__this = 0;
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x000356D0 File Offset: 0x000338D0
	[Token(Token = "0x60009D1")]
	[Address(RVA = "0x87C190", Offset = "0x87A790", VA = "0x18087C190")]
	private IEnumerator MoveAndSummonZombie()
	{
		Grave.<MoveAndSummonZombie>d__9 <MoveAndSummonZombie>d__;
		<MoveAndSummonZombie>d__.System.IDisposable.Dispose();
		<MoveAndSummonZombie>d__.<>1__state = (int)((ulong)0L);
		<MoveAndSummonZombie>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x000356F4 File Offset: 0x000338F4
	[Token(Token = "0x60009D2")]
	[Address(RVA = "0x87BDB0", Offset = "0x87A3B0", VA = "0x18087BDB0", Slot = "5")]
	protected override void DieEvent()
	{
		GridSystem gridSystem = this.board.gridSystem;
		int theItemRow = this.theItemRow;
		int theItemColumn = this.theItemColumn;
		BoardGrid grid = gridSystem.GetGrid(theItemColumn, theItemRow);
		if (grid == 0 || grid.graveNum > 0)
		{
		}
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00035738 File Offset: 0x00033938
	[Token(Token = "0x60009D3")]
	[Address(RVA = "0x87CC80", Offset = "0x87B280", VA = "0x18087CC80")]
	public Grave()
	{
	}

	// Token: 0x0400051B RID: 1307
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400051B")]
	public GraveType graveType;

	// Token: 0x0400051C RID: 1308
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400051C")]
	public float health = 800f;

	// Token: 0x0400051D RID: 1309
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400051D")]
	[SerializeReference]
	private IEffect ability;
}
