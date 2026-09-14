using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006B6 RID: 1718
[Token(Token = "0x20006B6")]
public class PolevaulterZombie : Zombie
{
	// Token: 0x06002198 RID: 8600 RVA: 0x000B0F88 File Offset: 0x000AF188
	[Token(Token = "0x6002198")]
	[Address(RVA = "0x567600", Offset = "0x565C00", VA = "0x180567600", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)2L);
	}

	// Token: 0x06002199 RID: 8601 RVA: 0x000B0FA4 File Offset: 0x000AF1A4
	[Token(Token = "0x6002199")]
	[Address(RVA = "0x5676B0", Offset = "0x565CB0", VA = "0x1805676B0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (!base.HasBuff((EffectType)((uint)2)))
		{
		}
	}

	// Token: 0x0600219A RID: 8602 RVA: 0x000B0FC4 File Offset: 0x000AF1C4
	[Token(Token = "0x600219A")]
	[Address(RVA = "0x567D30", Offset = "0x566330", VA = "0x180567D30", Slot = "74")]
	protected virtual void PolUpdate()
	{
		Transform axis = this.axis;
		int num = 0;
		Transform axis2 = this.axis;
		LayerMask plantLayer = this.plantLayer;
		Vector3 vector;
		float y = vector.y;
		this.jumpPos2.y = y;
		int num2 = plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int num3 = 0;
				GridItem gridItem;
				if (!(gridItem != num3))
				{
					Board board = this.board;
					BoxType boxType;
					if (boxType == BoxType.Dirt)
					{
						int theZombieRow = this.theZombieRow;
						Transform axis3 = this.axis;
					}
				}
			}
			num++;
			Transform axis4 = this.axis;
			LayerMask plantLayer2 = this.plantLayer;
			Vector3 vector2;
			float y2 = vector2.y;
			this.jumpPos2.y = y2;
			Collider2D[] array2;
			if (num < array2.Length)
			{
				bool flag2;
				if (flag2)
				{
					int num4 = 0;
					GridItem gridItem2;
					if (!(gridItem2 != num4))
					{
						Board board2 = this.board;
						BoxType boxType2;
						if (boxType2 == BoxType.Dirt)
						{
							int theZombieRow2 = this.theZombieRow;
							Transform axis5 = this.axis;
						}
					}
				}
				num++;
				this.StartJump();
			}
		}
	}

	// Token: 0x0600219B RID: 8603 RVA: 0x000B10BC File Offset: 0x000AF2BC
	[Token(Token = "0x600219B")]
	[Address(RVA = "0x5681F0", Offset = "0x5667F0", VA = "0x1805681F0")]
	public void StartJump()
	{
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)3L);
		anim.SetTrigger("jump");
		GameObject gameObject = this.axis.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x0600219C RID: 8604 RVA: 0x000B1100 File Offset: 0x000AF300
	[Token(Token = "0x600219C")]
	[Address(RVA = "0x567BD0", Offset = "0x5661D0", VA = "0x180567BD0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int theZombieRow = this.theZombieRow;
		}
	}

	// Token: 0x0600219D RID: 8605 RVA: 0x000B1120 File Offset: 0x000AF320
	[Token(Token = "0x600219D")]
	[Address(RVA = "0x567B80", Offset = "0x566180", VA = "0x180567B80", Slot = "75")]
	public virtual void JumpOver()
	{
		this.axis.gameObject.SetActive(true);
		this.theStatus = (ZombieStatus)((ulong)0L);
	}

	// Token: 0x0600219E RID: 8606 RVA: 0x000B1150 File Offset: 0x000AF350
	[Token(Token = "0x600219E")]
	[Address(RVA = "0x567C70", Offset = "0x566270", VA = "0x180567C70")]
	public void PlayJumpSound1()
	{
		GameAPP.PlaySound(50, 0.5f, 1f);
	}

	// Token: 0x0600219F RID: 8607 RVA: 0x000B1170 File Offset: 0x000AF370
	[Token(Token = "0x600219F")]
	[Address(RVA = "0x567CD0", Offset = "0x5662D0", VA = "0x180567CD0", Slot = "76")]
	public virtual void PlayJumpSound2()
	{
		GameAPP.PlaySound(51, 0.5f, 1f);
	}

	// Token: 0x060021A0 RID: 8608 RVA: 0x000B1190 File Offset: 0x000AF390
	[Token(Token = "0x60021A0")]
	[Address(RVA = "0x567620", Offset = "0x565C20", VA = "0x180567620", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = Resources.Load<Sprite>("Zombies/Zombie_polevaulter/Zombie_polevaulter_outerarm_upper2");
		component.sprite = sprite;
	}

	// Token: 0x060021A1 RID: 8609 RVA: 0x000B11BC File Offset: 0x000AF3BC
	[Token(Token = "0x60021A1")]
	[Address(RVA = "0x567710", Offset = "0x565D10", VA = "0x180567710", Slot = "77")]
	protected virtual void JumpFail()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = this.plantLayer;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				int num4 = 0;
				GridItem gridItem;
				if (gridItem == num4)
				{
					goto IL_0058;
				}
			}
			num3++;
			IL_0058:
			Vector3 vector2;
			float z2 = vector2.z;
			Transform axis2 = this.axis;
			this.anim.Play("walk2");
			ulong num5;
			this.axis.gameObject.SetActive(num5 != 0UL);
			this.theStatus = (ZombieStatus)((ulong)0L);
			GameObject[] particlePrefab = GameAPP.particlePrefab;
			Transform axis3 = this.axis;
			GameObject gameObject = particlePrefab[23];
			Transform axis4 = this.axis;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			uint num6;
			GameAPP.PlaySound((int)num6, 0.5f, 1f);
		}
	}

	// Token: 0x060021A2 RID: 8610 RVA: 0x000B12AC File Offset: 0x000AF4AC
	[Token(Token = "0x60021A2")]
	[Address(RVA = "0x568270", Offset = "0x566870", VA = "0x180568270")]
	public PolevaulterZombie()
	{
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x04001119 RID: 4377
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001119")]
	protected Vector2 jumpPos2;

	// Token: 0x0400111A RID: 4378
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400111A")]
	protected Vector2 range = (ulong)1060320051L;
}
