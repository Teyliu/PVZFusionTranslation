using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000448 RID: 1096
[Token(Token = "0x2000448")]
public class Squash : Plant
{
	// Token: 0x1700013F RID: 319
	// (get) Token: 0x0600142A RID: 5162 RVA: 0x0007031C File Offset: 0x0006E51C
	[Token(Token = "0x1700013F")]
	protected virtual Vector2 Range
	{
		[Token(Token = "0x600142A")]
		[Address(RVA = "0x4C1E50", Offset = "0x4C0450", VA = "0x1804C1E50", Slot = "68")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x0600142B RID: 5163 RVA: 0x00070334 File Offset: 0x0006E534
	[Token(Token = "0x600142B")]
	[Address(RVA = "0x4C1BC0", Offset = "0x4C01C0", VA = "0x1804C1BC0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		BoxCollider2D[] components = base.GetComponents<BoxCollider2D>();
		this.boxCols = components;
	}

	// Token: 0x0600142C RID: 5164 RVA: 0x00070358 File Offset: 0x0006E558
	[Token(Token = "0x600142C")]
	[Address(RVA = "0x4C12E0", Offset = "0x4BF8E0", VA = "0x1804C12E0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.PumpkinType == PlantType.SquashPumpkin)
		{
			GridSystem gridSystem = this.board.gridSystem;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			if (gridSystem.GetGrid(thePlantColumn, thePlantRow).boxType != BoxType.Water)
			{
				return;
			}
		}
		if (!this.isJump)
		{
			Animator anim = this.anim;
			float speed = anim.speed;
			if (anim != 0)
			{
				this.SquashUpdate();
				return;
			}
		}
	}

	// Token: 0x0600142D RID: 5165 RVA: 0x000703CC File Offset: 0x0006E5CC
	[Token(Token = "0x600142D")]
	[Address(RVA = "0x4C1C20", Offset = "0x4C0220", VA = "0x1804C1C20", Slot = "69")]
	protected virtual void UpdateZombieList()
	{
		Transform axis = this.axis;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		Vector2 range = this.Range;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && global::Lawnf.ThrowLandStatus((ZombieStatus)num))
			{
				int thePlantRow = this.thePlantRow;
				List<Zombie> zombieList = this.zombieList;
			}
			num++;
		}
	}

	// Token: 0x0600142E RID: 5166 RVA: 0x00070434 File Offset: 0x0006E634
	[Token(Token = "0x600142E")]
	[Address(RVA = "0x4C1840", Offset = "0x4BFE40", VA = "0x1804C1840")]
	private void SquashUpdate()
	{
		this.UpdateZombieList();
		Zombie nearestZombie = this.GetNearestZombie();
		this.targetZombie = nearestZombie;
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie != num)
		{
			Zombie targetZombie2 = this.targetZombie;
			this.isJump = true;
			Transform axis = targetZombie2.axis;
			Transform axis2 = this.axis;
			this.anim.SetTrigger("lookleft");
			Transform transform = base.transform;
			Transform transform2 = this.board.transform;
			transform.parentInternal = transform2;
			float time = Time.time;
			Zombie targetZombie3 = this.targetZombie;
			this.startTime = time;
			Transform axis3 = targetZombie3.axis;
			this.startJumpPos.y = time;
			this.Sound();
			this.invincible = true;
			Transform transform3 = base.transform;
			Transform transform4 = this.board.transform;
			transform3.parentInternal = transform4;
			BoxCollider2D[] array = this.boxCols;
			int num2 = 0;
			int num3 = 0;
			if (num2 < array.Length)
			{
				num3++;
			}
			if (Mouse.Instance.thePlantOnGlove == this)
			{
				global::UnityEngine.Object.Destroy(Mouse.Instance.theItemOnMouse);
				Mouse.Instance.theItemOnMouse = (ulong)0L;
				Mouse.Instance.thePlantTypeOnMouse = (PlantType)((ulong)4294967295L);
				Mouse.Instance.thePlantOnGlove = (ulong)0L;
			}
		}
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x00070590 File Offset: 0x0006E790
	[Token(Token = "0x600142F")]
	[Address(RVA = "0x4C17D0", Offset = "0x4BFDD0", VA = "0x1804C17D0", Slot = "70")]
	protected virtual void Sound()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(72, 74), 0.5f, 1f);
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x000705B8 File Offset: 0x0006E7B8
	[Token(Token = "0x6001430")]
	[Address(RVA = "0x4C1380", Offset = "0x4BF980", VA = "0x1804C1380")]
	private Zombie GetNearestZombie()
	{
		int num;
		do
		{
			num = 0;
			List<Zombie> zombieList = this.zombieList;
			bool flag;
			if (flag)
			{
				Transform axis = this.axis;
				Transform axis2 = this.axis;
			}
		}
		while (num != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06001431 RID: 5169 RVA: 0x00070610 File Offset: 0x0006E810
	[Token(Token = "0x6001431")]
	[Address(RVA = "0x4C08B0", Offset = "0x4BEEB0", VA = "0x1804C08B0", Slot = "71")]
	protected virtual void ActionOnZombie(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)11), thePlantType, num != 0UL);
	}

	// Token: 0x06001432 RID: 5170 RVA: 0x00070640 File Offset: 0x0006E840
	[Token(Token = "0x6001432")]
	[Address(RVA = "0x4C0C20", Offset = "0x4BF220", VA = "0x1804C0C20", Slot = "72")]
	protected virtual void AttackZombie()
	{
		ulong num5;
		do
		{
			int num = 0;
			List<Zombie> list = new List();
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num2 = this.zombieLayer;
			int num3 = 0;
			int num4 = 0;
			Collider2D[] array;
			if (num4 < array.Length)
			{
				bool flag;
				if (flag)
				{
					bool flag2;
					if (!flag2)
					{
					}
					int thePlantRow = this.thePlantRow;
				}
				num3++;
			}
			AdvantureData data = AdvantureConfig.data;
			bool flag3;
			if (flag3)
			{
			}
			bool flag4;
			if (flag4)
			{
				this.ActionOnZombie(num);
			}
		}
		while (num5 != (ulong)0L);
		InGameText instance = InGameText.Instance;
		Vector3 vector2;
		float z2 = vector2.z;
		BoxType boxType;
		if (boxType != BoxType.Water)
		{
			uint num6;
			GameAPP.PlaySound((int)num6, 0.5f, 1f);
			ScreenShake.TriggerShake(0.05f);
			return;
		}
		Vector2 oneVector = Vector2.oneVector;
		uint num7;
		GameAPP.PlaySound((int)num7, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06001433 RID: 5171 RVA: 0x0007071C File Offset: 0x0006E91C
	[Token(Token = "0x6001433")]
	[Address(RVA = "0x4C15B0", Offset = "0x4BFBB0", VA = "0x1804C15B0")]
	private bool InWater()
	{
		Transform axis = this.axis;
		Board board = this.board;
		int thePlantRow = this.thePlantRow;
		int num;
		return board.GetBoxType(num, thePlantRow) == BoxType.Water;
	}

	// Token: 0x06001434 RID: 5172 RVA: 0x00070754 File Offset: 0x0006E954
	[Token(Token = "0x6001434")]
	[Address(RVA = "0x4C1620", Offset = "0x4BFC20", VA = "0x1804C1620")]
	protected IEnumerator MoveToZombie(Vector3 endPos, float speed)
	{
		Squash.<MoveToZombie>d__17 <MoveToZombie>d__;
		<MoveToZombie>d__.System.IDisposable.Dispose();
		<MoveToZombie>d__.<>1__state = (int)((ulong)0L);
		<MoveToZombie>d__.<>4__this = this;
		float z = endPos.z;
		<MoveToZombie>d__.speed = speed;
		<MoveToZombie>d__.endPos.z = z;
		return null;
	}

	// Token: 0x06001435 RID: 5173 RVA: 0x00070794 File Offset: 0x0006E994
	[Token(Token = "0x6001435")]
	[Address(RVA = "0x4C16C0", Offset = "0x4BFCC0", VA = "0x1804C16C0")]
	private void SetTransform(GameObject plant, Vector3 position)
	{
		Transform axis = this.axis;
		Transform transform = plant.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001436 RID: 5174 RVA: 0x000707C0 File Offset: 0x0006E9C0
	[Token(Token = "0x6001436")]
	[Address(RVA = "0x4C12A0", Offset = "0x4BF8A0", VA = "0x1804C12A0")]
	private float EaseInOut(float t)
	{
		return t;
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x000707D4 File Offset: 0x0006E9D4
	[Token(Token = "0x6001437")]
	[Address(RVA = "0x4C0910", Offset = "0x4BEF10", VA = "0x1804C0910", Slot = "73")]
	protected virtual void AnimMove()
	{
		global::UnityEngine.Object.Destroy(this.axis.GetComponent<SpriteRenderer>());
		this.freeMoving = false;
		base.RemoveFromList();
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			string text = string.Format("bullet{0}", thePlantRow);
		}
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (!(targetZombie != num))
		{
			Transform axis = this.axis;
		}
		Zombie component = this.targetZombie.GetComponent<Zombie>();
		int theZombieRow = component.theZombieRow;
		this.thePlantRow = theZombieRow;
		float time = Time.time;
		this.endTime = time;
		Transform axis2 = component.axis;
		Vector3 vector;
		float z = vector.z;
		this.endPos.y = time;
		Vector2 vector2 = this.startJumpPos;
		Transform axis3 = component.axis;
		int num2 = 0;
		Squash.<MoveToZombie>d__17 <MoveToZombie>d__;
		<MoveToZombie>d__.System.IDisposable.Dispose();
		<MoveToZombie>d__.<>1__state = (int)((ulong)0L);
		<MoveToZombie>d__.<>4__this = this;
		<MoveToZombie>d__.endPos.z = (float)num2;
		<MoveToZombie>d__.speed = 8f;
		Coroutine coroutine = base.StartCoroutine(<MoveToZombie>d__);
	}

	// Token: 0x06001438 RID: 5176 RVA: 0x000708DC File Offset: 0x0006EADC
	[Token(Token = "0x6001438")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Squash()
	{
	}

	// Token: 0x04000D05 RID: 3333
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D05")]
	protected bool isJump;

	// Token: 0x04000D06 RID: 3334
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D06")]
	protected BoxCollider2D[] boxCols;

	// Token: 0x04000D07 RID: 3335
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D07")]
	protected float startTime;

	// Token: 0x04000D08 RID: 3336
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000D08")]
	protected float endTime;

	// Token: 0x04000D09 RID: 3337
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D09")]
	protected Vector2 startJumpPos;

	// Token: 0x04000D0A RID: 3338
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000D0A")]
	protected Vector2 endPos;
}
