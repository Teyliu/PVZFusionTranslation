using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200040D RID: 1037
[Token(Token = "0x200040D")]
public class PuffSquash : Plant
{
	// Token: 0x0600132A RID: 4906 RVA: 0x0006BFD8 File Offset: 0x0006A1D8
	[Token(Token = "0x600132A")]
	[Address(RVA = "0x462830", Offset = "0x460E30", VA = "0x180462830", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.back = true;
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x0006BFF4 File Offset: 0x0006A1F4
	[Token(Token = "0x600132B")]
	[Address(RVA = "0x4632B0", Offset = "0x4618B0", VA = "0x1804632B0", Slot = "16")]
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

	// Token: 0x0600132C RID: 4908 RVA: 0x0006C030 File Offset: 0x0006A230
	[Token(Token = "0x600132C")]
	[Address(RVA = "0x462B70", Offset = "0x461170", VA = "0x180462B70")]
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

	// Token: 0x0600132D RID: 4909 RVA: 0x0006C144 File Offset: 0x0006A344
	[Token(Token = "0x600132D")]
	[Address(RVA = "0x4628F0", Offset = "0x460EF0", VA = "0x1804628F0")]
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

	// Token: 0x0600132E RID: 4910 RVA: 0x0006C244 File Offset: 0x0006A444
	[Token(Token = "0x600132E")]
	[Address(RVA = "0x462760", Offset = "0x460D60", VA = "0x180462760")]
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

	// Token: 0x0600132F RID: 4911 RVA: 0x0006C2B0 File Offset: 0x0006A4B0
	[Token(Token = "0x600132F")]
	[Address(RVA = "0x463060", Offset = "0x461660", VA = "0x180463060")]
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

	// Token: 0x06001330 RID: 4912 RVA: 0x0006C318 File Offset: 0x0006A518
	[Token(Token = "0x6001330")]
	[Address(RVA = "0x462470", Offset = "0x460A70", VA = "0x180462470")]
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

	// Token: 0x06001331 RID: 4913 RVA: 0x0006C3EC File Offset: 0x0006A5EC
	[Token(Token = "0x6001331")]
	[Address(RVA = "0x462850", Offset = "0x460E50", VA = "0x180462850", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		int num = 0;
		if (zombie != num)
		{
		}
	}

	// Token: 0x06001332 RID: 4914 RVA: 0x0006C40C File Offset: 0x0006A60C
	[Token(Token = "0x6001332")]
	[Address(RVA = "0x463320", Offset = "0x461920", VA = "0x180463320")]
	public PuffSquash()
	{
	}

	// Token: 0x04000C4F RID: 3151
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C4F")]
	public Transform shadow;

	// Token: 0x04000C50 RID: 3152
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C50")]
	private PuffSquash.Status status;

	// Token: 0x04000C51 RID: 3153
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000C51")]
	private float timer = 0.3f;

	// Token: 0x04000C52 RID: 3154
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C52")]
	private bool back;

	// Token: 0x04000C53 RID: 3155
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000C53")]
	private readonly float speed = 13f;

	// Token: 0x04000C54 RID: 3156
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C54")]
	private Vector3 jumpTargetPosition;

	// Token: 0x04000C55 RID: 3157
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000C55")]
	public Collider2D col;

	// Token: 0x0200040E RID: 1038
	[Token(Token = "0x200040E")]
	private enum Status
	{
		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		Default,
		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		Moving,
		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		Waiting,
		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		Crashing,
		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		Crashed
	}
}
