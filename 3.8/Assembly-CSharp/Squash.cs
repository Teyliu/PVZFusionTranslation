using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000429 RID: 1065
[Token(Token = "0x2000429")]
public class Squash : Plant
{
	// Token: 0x170000FA RID: 250
	// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0006E074 File Offset: 0x0006C274
	[Token(Token = "0x170000FA")]
	protected virtual Vector2 Range
	{
		[Token(Token = "0x60013A0")]
		[Address(RVA = "0x46B980", Offset = "0x469F80", VA = "0x18046B980", Slot = "69")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x0006E08C File Offset: 0x0006C28C
	[Token(Token = "0x60013A1")]
	[Address(RVA = "0x46B6F0", Offset = "0x469CF0", VA = "0x18046B6F0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		BoxCollider2D[] components = base.GetComponents<BoxCollider2D>();
		this.boxCols = components;
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x0006E0B0 File Offset: 0x0006C2B0
	[Token(Token = "0x60013A2")]
	[Address(RVA = "0x46AE10", Offset = "0x469410", VA = "0x18046AE10", Slot = "17")]
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

	// Token: 0x060013A3 RID: 5027 RVA: 0x0006E124 File Offset: 0x0006C324
	[Token(Token = "0x60013A3")]
	[Address(RVA = "0x46B750", Offset = "0x469D50", VA = "0x18046B750", Slot = "70")]
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

	// Token: 0x060013A4 RID: 5028 RVA: 0x0006E18C File Offset: 0x0006C38C
	[Token(Token = "0x60013A4")]
	[Address(RVA = "0x46B370", Offset = "0x469970", VA = "0x18046B370")]
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

	// Token: 0x060013A5 RID: 5029 RVA: 0x0006E2E8 File Offset: 0x0006C4E8
	[Token(Token = "0x60013A5")]
	[Address(RVA = "0x46B300", Offset = "0x469900", VA = "0x18046B300", Slot = "71")]
	protected virtual void Sound()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(72, 74), 0.5f, 1f);
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x0006E310 File Offset: 0x0006C510
	[Token(Token = "0x60013A6")]
	[Address(RVA = "0x46AEB0", Offset = "0x4694B0", VA = "0x18046AEB0")]
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

	// Token: 0x060013A7 RID: 5031 RVA: 0x0006E368 File Offset: 0x0006C568
	[Token(Token = "0x60013A7")]
	[Address(RVA = "0x46A3F0", Offset = "0x4689F0", VA = "0x18046A3F0", Slot = "72")]
	protected virtual void ActionOnZombie(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)11), thePlantType, num != 0UL);
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x0006E398 File Offset: 0x0006C598
	[Token(Token = "0x60013A8")]
	[Address(RVA = "0x46A760", Offset = "0x468D60", VA = "0x18046A760", Slot = "73")]
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
		int num6 = 0;
		instance.ShowText("你成功套路了一个窝瓜！", 3f, num6 != 0);
		Vector3 vector2;
		float z2 = vector2.z;
		BoxType boxType;
		if (boxType != BoxType.Water)
		{
			uint num7;
			GameAPP.PlaySound((int)num7, 0.5f, 1f);
			ScreenShake.TriggerShake(0.05f);
			return;
		}
		Vector2 oneVector = Vector2.oneVector;
		uint num8;
		GameAPP.PlaySound((int)num8, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x0006E48C File Offset: 0x0006C68C
	[Token(Token = "0x60013A9")]
	[Address(RVA = "0x46B0E0", Offset = "0x4696E0", VA = "0x18046B0E0")]
	private bool InWater()
	{
		Transform axis = this.axis;
		Board board = this.board;
		int thePlantRow = this.thePlantRow;
		int num;
		return board.GetBoxType(num, thePlantRow) == BoxType.Water;
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x0006E4C4 File Offset: 0x0006C6C4
	[Token(Token = "0x60013AA")]
	[Address(RVA = "0x46B150", Offset = "0x469750", VA = "0x18046B150")]
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

	// Token: 0x060013AB RID: 5035 RVA: 0x0006E504 File Offset: 0x0006C704
	[Token(Token = "0x60013AB")]
	[Address(RVA = "0x46B1F0", Offset = "0x4697F0", VA = "0x18046B1F0")]
	private void SetTransform(GameObject plant, Vector3 position)
	{
		Transform axis = this.axis;
		Transform transform = plant.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x0006E530 File Offset: 0x0006C730
	[Token(Token = "0x60013AC")]
	[Address(RVA = "0x46ADD0", Offset = "0x4693D0", VA = "0x18046ADD0")]
	private float EaseInOut(float t)
	{
		return t;
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x0006E544 File Offset: 0x0006C744
	[Token(Token = "0x60013AD")]
	[Address(RVA = "0x46A450", Offset = "0x468A50", VA = "0x18046A450", Slot = "74")]
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

	// Token: 0x060013AE RID: 5038 RVA: 0x0006E64C File Offset: 0x0006C84C
	[Token(Token = "0x60013AE")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Squash()
	{
	}

	// Token: 0x04000C7B RID: 3195
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C7B")]
	protected bool isJump;

	// Token: 0x04000C7C RID: 3196
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C7C")]
	protected BoxCollider2D[] boxCols;

	// Token: 0x04000C7D RID: 3197
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C7D")]
	protected float startTime;

	// Token: 0x04000C7E RID: 3198
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000C7E")]
	protected float endTime;

	// Token: 0x04000C7F RID: 3199
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C7F")]
	protected Vector2 startJumpPos;

	// Token: 0x04000C80 RID: 3200
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000C80")]
	protected Vector2 endPos;
}
