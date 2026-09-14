using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000428 RID: 1064
[Token(Token = "0x2000428")]
public class PuffSquash : Plant
{
	// Token: 0x060013A0 RID: 5024 RVA: 0x0006DE70 File Offset: 0x0006C070
	[Token(Token = "0x60013A0")]
	[Address(RVA = "0x4B8F20", Offset = "0x4B7520", VA = "0x1804B8F20", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.back = true;
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x0006DE8C File Offset: 0x0006C08C
	[Token(Token = "0x60013A1")]
	[Address(RVA = "0x4B99A0", Offset = "0x4B7FA0", VA = "0x1804B99A0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float num = this.timer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.timer = num;
			this.NextStatus();
		}
		this.PositionUpdate();
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x0006DEC8 File Offset: 0x0006C0C8
	[Token(Token = "0x60013A2")]
	[Address(RVA = "0x4B9260", Offset = "0x4B7860", VA = "0x1804B9260")]
	private void PositionUpdate()
	{
		PuffSquash.Status status = this.status;
		if (status == PuffSquash.Status.Moving)
		{
			Transform axis = this.axis;
			Transform axis2 = this.axis;
			float deltaTime = Time.deltaTime;
			Transform axis3 = this.axis;
			float deltaTime2 = Time.deltaTime;
			int num = 0;
			float z = this.jumpTargetPosition.z;
			this.timer = 0.2f;
			this.status = (PuffSquash.Status)((ulong)2L);
			base.SetPosition(num);
			return;
		}
		while (status != PuffSquash.Status.Crashing)
		{
		}
		Transform axis4 = this.axis;
		Mouse instance = Mouse.Instance;
		int puffPlace = this.puffPlace;
		if (puffPlace == 0 || puffPlace == 0 || puffPlace == 1)
		{
		}
		GridSystem gridSystem = this.board.gridSystem;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		if (gridSystem.HasPot(thePlantColumn, thePlantRow))
		{
		}
		Transform axis5 = this.axis;
		Vector3 vector;
		float num2;
		Transform transform;
		if (vector.y > num2)
		{
			transform = base.transform;
			float deltaTime3 = Time.deltaTime;
		}
		Transform axis6 = this.axis;
		Vector3 position = transform.position;
		Transform axis7 = this.axis;
		Vector3 position2 = transform.position;
		throw new NullReferenceException();
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x0006DFDC File Offset: 0x0006C1DC
	[Token(Token = "0x60013A3")]
	[Address(RVA = "0x4B8FE0", Offset = "0x4B75E0", VA = "0x1804B8FE0")]
	private void NextStatus()
	{
		PuffSquash.Status status = this.status;
		if (status != PuffSquash.Status.Default)
		{
			while (status != PuffSquash.Status.Waiting)
			{
			}
			Animator anim = this.anim;
			this.status = (PuffSquash.Status)((ulong)3L);
			anim.SetTrigger("pop");
			return;
		}
		Zombie zombie = this.SearchZombie();
		int num = 0;
		bool flag = zombie != num;
		if (!flag)
		{
			if (this.back == flag)
			{
				Transform axis = this.axis;
				Vector3 vector;
				float z = vector.z;
				this.jumpTargetPosition.z = z;
				Mouse instance = Mouse.Instance;
				int thePlantColumn = this.thePlantColumn;
				float boxXFromColumn = instance.GetBoxXFromColumn(thePlantColumn);
				this.jumpTargetPosition = boxXFromColumn;
				int puffPlace = this.puffPlace;
				if (puffPlace == 1)
				{
					this.jumpTargetPosition = boxXFromColumn;
				}
				if (puffPlace == 2)
				{
					this.jumpTargetPosition = boxXFromColumn;
				}
			}
			this.timer = 0.5f;
			return;
		}
		Transform axis2 = zombie.axis;
		Vector2 velocity = zombie.Velocity;
		int num2 = 0;
		this.back = num2 != 0;
		this.anim.SetTrigger("jump");
	}

	// Token: 0x060013A4 RID: 5028 RVA: 0x0006E0DC File Offset: 0x0006C2DC
	[Token(Token = "0x60013A4")]
	[Address(RVA = "0x4B8E50", Offset = "0x4B7450", VA = "0x1804B8E50")]
	private void AnimJump()
	{
		Transform transform = this.shadow;
		this.status = (PuffSquash.Status)((ulong)1L);
		GameObject gameObject = transform.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		int thePlantRow = this.thePlantRow;
		SortingGroup sortingGroup = this.sortingGroup;
		string text = string.Format("bullet{0}", thePlantRow);
		sortingGroup.sortingLayerName = text;
		Collider2D collider2D = this.col;
		int num2 = 0;
		collider2D.enabled = num2 != 0;
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x0006E148 File Offset: 0x0006C348
	[Token(Token = "0x60013A5")]
	[Address(RVA = "0x4B9750", Offset = "0x4B7D50", VA = "0x1804B9750")]
	private new Zombie SearchZombie()
	{
		int thePlantColumn = this.thePlantColumn;
		int num = 0;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(thePlantColumn);
		Transform axis = this.axis;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (!Lawnf.InDodgeStatus((ZombieStatus)num))
				{
					Transform axis2 = this.axis;
				}
			}
			num++;
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x0006E1B0 File Offset: 0x0006C3B0
	[Token(Token = "0x60013A6")]
	[Address(RVA = "0x4B8B60", Offset = "0x4B7160", VA = "0x1804B8B60")]
	private void AnimCrash()
	{
		Transform axis = this.axis;
		int num = this.zombieLayer;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				bool flag2;
				if (!flag2)
				{
					PlantType thePlantType = this.thePlantType;
				}
			}
			num3++;
		}
		uint num4;
		GameAPP.PlaySound((int)num4, 0.3f, 1f);
		Transform transform = this.shadow;
		this.status = (PuffSquash.Status)((ulong)0L);
		this.timer = 0.3f;
		ulong num5;
		transform.gameObject.SetActive(num5 != 0UL);
		if (this.back)
		{
			SortingGroup sortingGroup = this.sortingGroup;
			int thePlantRow2 = this.thePlantRow;
			string text = string.Format("plantlow{0}", thePlantRow2);
			sortingGroup.sortingLayerName = text;
		}
		ulong num6;
		this.col.enabled = num6 != 0UL;
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x0006E284 File Offset: 0x0006C484
	[Token(Token = "0x60013A7")]
	[Address(RVA = "0x4B8F40", Offset = "0x4B7540", VA = "0x1804B8F40", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		int num = 0;
		if (zombie != num)
		{
		}
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x0006E2A4 File Offset: 0x0006C4A4
	[Token(Token = "0x60013A8")]
	[Address(RVA = "0x4B9A10", Offset = "0x4B8010", VA = "0x1804B9A10")]
	public PuffSquash()
	{
	}

	// Token: 0x04000CCA RID: 3274
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CCA")]
	public Transform shadow;

	// Token: 0x04000CCB RID: 3275
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CCB")]
	private PuffSquash.Status status;

	// Token: 0x04000CCC RID: 3276
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000CCC")]
	private float timer = 0.3f;

	// Token: 0x04000CCD RID: 3277
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CCD")]
	private bool back;

	// Token: 0x04000CCE RID: 3278
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000CCE")]
	private readonly float speed = 13f;

	// Token: 0x04000CCF RID: 3279
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CCF")]
	private Vector3 jumpTargetPosition;

	// Token: 0x04000CD0 RID: 3280
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000CD0")]
	public Collider2D col;

	// Token: 0x02000429 RID: 1065
	[Token(Token = "0x2000429")]
	private enum Status
	{
		// Token: 0x04000CD2 RID: 3282
		[Token(Token = "0x4000CD2")]
		Default,
		// Token: 0x04000CD3 RID: 3283
		[Token(Token = "0x4000CD3")]
		Moving,
		// Token: 0x04000CD4 RID: 3284
		[Token(Token = "0x4000CD4")]
		Waiting,
		// Token: 0x04000CD5 RID: 3285
		[Token(Token = "0x4000CD5")]
		Crashing,
		// Token: 0x04000CD6 RID: 3286
		[Token(Token = "0x4000CD6")]
		Crashed
	}
}
