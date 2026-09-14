using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A5 RID: 1701
[Token(Token = "0x20006A5")]
public class NormalZombie : Zombie
{
	// Token: 0x06002119 RID: 8473 RVA: 0x000AEFB4 File Offset: 0x000AD1B4
	[Token(Token = "0x6002119")]
	[Address(RVA = "0x561970", Offset = "0x55FF70", VA = "0x180561970", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		int num = Animator.StringToHash("inWater");
		GameObject gameObject = this.duck;
		this.hash_inWater = num;
		int num2 = 0;
		if (gameObject != num2)
		{
			GameObject gameObject2 = this.duck;
			int num3 = 0;
			gameObject2.SetActive(num3 != 0);
		}
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x000AF004 File Offset: 0x000AD204
	[Token(Token = "0x600211A")]
	[Address(RVA = "0x561F90", Offset = "0x560590", VA = "0x180561F90", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameObject gameObject = this.duck;
		int num = 0;
		if (gameObject != num)
		{
			BoxType[] roadType = this.board.roadType;
			int theZombieRow = this.theZombieRow;
			BoxType boxType = roadType[theZombieRow];
			if (boxType != BoxType.Water && boxType != BoxType.River)
			{
				GameObject gameObject2 = this.duck;
			}
			this.duck.SetActive(true);
		}
		Board board = this.board;
		int column = base.Column;
		int theZombieRow2 = this.theZombieRow;
		if (board.GetBoxType(column, theZombieRow2) == BoxType.Water)
		{
			this.EnterWater();
		}
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x000AF098 File Offset: 0x000AD298
	[Token(Token = "0x600211B")]
	[Address(RVA = "0x561EC0", Offset = "0x5604C0", VA = "0x180561EC0", Slot = "21")]
	protected override void PositionUpdate()
	{
		base.PositionUpdate();
		Animator anim = this.anim;
		int num = this.hash_inWater;
		bool @bool = anim.GetBool(num);
		Board board = this.board;
		int column = base.Column;
		int theZombieRow = this.theZombieRow;
		bool flag = board.GetBoxType(column, theZombieRow) == BoxType.Water;
		if (@bool != flag)
		{
			if (@bool)
			{
				return;
			}
			this.EnterWater();
		}
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x000AF100 File Offset: 0x000AD300
	[Token(Token = "0x600211C")]
	[Address(RVA = "0x561E20", Offset = "0x560420", VA = "0x180561E20")]
	private void MoveWaterUpdate()
	{
		Animator anim = this.anim;
		int num = this.hash_inWater;
		bool @bool = anim.GetBool(num);
		Board board = this.board;
		int column = base.Column;
		int theZombieRow = this.theZombieRow;
		bool flag = board.GetBoxType(column, theZombieRow) == BoxType.Water;
		if (@bool != flag)
		{
			if (@bool)
			{
				return;
			}
			this.EnterWater();
		}
	}

	// Token: 0x0600211D RID: 8477 RVA: 0x000AF160 File Offset: 0x000AD360
	[Token(Token = "0x600211D")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x000AF170 File Offset: 0x000AD370
	[Token(Token = "0x600211E")]
	[Address(RVA = "0x561F60", Offset = "0x560560", VA = "0x180561F60", Slot = "64")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x000AF180 File Offset: 0x000AD380
	[Token(Token = "0x600211F")]
	[Address(RVA = "0x561A20", Offset = "0x560020", VA = "0x180561A20")]
	private void EnterWater()
	{
		Animator anim = this.anim;
		int num = this.hash_inWater;
		anim.SetBool(num, true);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num3 = 0;
		Vector3 vector2;
		float z2 = vector2.z;
		int theZombieRow = this.theZombieRow;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)32), num3, theZombieRow, num4 != 0UL, (float)num2);
		Transform axis3 = this.axis;
		GameAPP.PlaySound((SoundType)((uint)24), 0.5f, 1f);
		SpriteRenderer component = this.axis.GetComponent<SpriteRenderer>();
		int num5 = 0;
		component.enabled = num5 != 0;
		this.inWater = true;
	}

	// Token: 0x06002120 RID: 8480 RVA: 0x000AF230 File Offset: 0x000AD430
	[Token(Token = "0x6002120")]
	[Address(RVA = "0x561C20", Offset = "0x560220", VA = "0x180561C20")]
	private void ExitWater()
	{
		Animator anim = this.anim;
		int num = this.hash_inWater;
		int num2 = 0;
		anim.SetBool(num, num2 != 0);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num3 = 0;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num4 = 0;
		Vector3 vector2;
		float z2 = vector2.z;
		int theZombieRow = this.theZombieRow;
		ulong num5;
		Particle particle = instance.SetParticle((ParticleType)((uint)32), num4, theZombieRow, num5 != 0UL, (float)num3);
		Transform axis3 = this.axis;
		GameAPP.PlaySound((SoundType)((uint)24), 0.5f, 1f);
		this.axis.GetComponent<SpriteRenderer>().enabled = true;
		this.inWater = false;
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x000AF2D8 File Offset: 0x000AD4D8
	[Token(Token = "0x6002121")]
	[Address(RVA = "0x5620A0", Offset = "0x5606A0", VA = "0x1805620A0")]
	public NormalZombie()
	{
	}

	// Token: 0x040010EF RID: 4335
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010EF")]
	public GameObject duck;

	// Token: 0x040010F0 RID: 4336
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40010F0")]
	private int hash_inWater;
}
