using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000232 RID: 562
[Token(Token = "0x2000232")]
public class Grave : GridItem
{
	// Token: 0x060009E6 RID: 2534 RVA: 0x000352E4 File Offset: 0x000334E4
	[Token(Token = "0x60009E6")]
	[Address(RVA = "0x90C110", Offset = "0x90A710", VA = "0x18090C110")]
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

	// Token: 0x060009E7 RID: 2535 RVA: 0x000353E0 File Offset: 0x000335E0
	[Token(Token = "0x60009E7")]
	[Address(RVA = "0x90BD00", Offset = "0x90A300", VA = "0x18090BD00")]
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

	// Token: 0x060009E8 RID: 2536 RVA: 0x00035430 File Offset: 0x00033630
	[Token(Token = "0x60009E8")]
	[Address(RVA = "0x90C700", Offset = "0x90AD00", VA = "0x18090C700")]
	public void TakeDamage(int value)
	{
		if (this.ability != 0)
		{
		}
		float num = this.health;
		this.health = num;
		this.Die();
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x0003545C File Offset: 0x0003365C
	[Token(Token = "0x60009E9")]
	[Address(RVA = "0x90B900", Offset = "0x909F00", VA = "0x18090B900", Slot = "4")]
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

	// Token: 0x060009EA RID: 2538 RVA: 0x00035540 File Offset: 0x00033740
	[Token(Token = "0x60009EA")]
	[Address(RVA = "0x90BC40", Offset = "0x90A240", VA = "0x18090BC40")]
	private void FixedUpdate()
	{
		if (this.ability != 0)
		{
		}
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x00035558 File Offset: 0x00033758
	[Token(Token = "0x60009EB")]
	[Address(RVA = "0x90BE70", Offset = "0x90A470", VA = "0x18090BE70")]
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

	// Token: 0x060009EC RID: 2540 RVA: 0x000355D8 File Offset: 0x000337D8
	[Token(Token = "0x60009EC")]
	[Address(RVA = "0x90BC90", Offset = "0x90A290", VA = "0x18090BC90")]
	private IEnumerator MoveAndSummonZombie()
	{
		Grave.<MoveAndSummonZombie>d__9 <MoveAndSummonZombie>d__;
		<MoveAndSummonZombie>d__.System.IDisposable.Dispose();
		<MoveAndSummonZombie>d__.<>1__state = (int)((ulong)0L);
		<MoveAndSummonZombie>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x000355FC File Offset: 0x000337FC
	[Token(Token = "0x60009ED")]
	[Address(RVA = "0x90B8B0", Offset = "0x909EB0", VA = "0x18090B8B0", Slot = "5")]
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

	// Token: 0x060009EE RID: 2542 RVA: 0x00035640 File Offset: 0x00033840
	[Token(Token = "0x60009EE")]
	[Address(RVA = "0x90C790", Offset = "0x90AD90", VA = "0x18090C790")]
	public Grave()
	{
	}

	// Token: 0x04000526 RID: 1318
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000526")]
	public GraveType graveType;

	// Token: 0x04000527 RID: 1319
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000527")]
	public float health = 800f;

	// Token: 0x04000528 RID: 1320
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000528")]
	[SerializeReference]
	private IEffect ability;
}
