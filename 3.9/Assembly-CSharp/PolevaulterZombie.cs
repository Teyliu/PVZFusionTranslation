using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006ED RID: 1773
[Token(Token = "0x20006ED")]
public class PolevaulterZombie : Zombie
{
	// Token: 0x060022AF RID: 8879 RVA: 0x000B5C38 File Offset: 0x000B3E38
	[Token(Token = "0x60022AF")]
	[Address(RVA = "0x5CAF20", Offset = "0x5C9520", VA = "0x1805CAF20", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)2L);
	}

	// Token: 0x060022B0 RID: 8880 RVA: 0x000B5C54 File Offset: 0x000B3E54
	[Token(Token = "0x60022B0")]
	[Address(RVA = "0x5CAFD0", Offset = "0x5C95D0", VA = "0x1805CAFD0", Slot = "18")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (!base.HasBuff((EffectType)((uint)2)))
		{
		}
	}

	// Token: 0x060022B1 RID: 8881 RVA: 0x000B5C74 File Offset: 0x000B3E74
	[Token(Token = "0x60022B1")]
	[Address(RVA = "0x5CB650", Offset = "0x5C9C50", VA = "0x1805CB650", Slot = "76")]
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

	// Token: 0x060022B2 RID: 8882 RVA: 0x000B5D6C File Offset: 0x000B3F6C
	[Token(Token = "0x60022B2")]
	[Address(RVA = "0x5CBB10", Offset = "0x5CA110", VA = "0x1805CBB10")]
	public void StartJump()
	{
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)3L);
		anim.SetTrigger("jump");
		GameObject gameObject = this.axis.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x060022B3 RID: 8883 RVA: 0x000B5DB0 File Offset: 0x000B3FB0
	[Token(Token = "0x60022B3")]
	[Address(RVA = "0x5CB4F0", Offset = "0x5C9AF0", VA = "0x1805CB4F0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int theZombieRow = this.theZombieRow;
		}
	}

	// Token: 0x060022B4 RID: 8884 RVA: 0x000B5DD0 File Offset: 0x000B3FD0
	[Token(Token = "0x60022B4")]
	[Address(RVA = "0x5CB4A0", Offset = "0x5C9AA0", VA = "0x1805CB4A0", Slot = "77")]
	public virtual void JumpOver()
	{
		this.axis.gameObject.SetActive(true);
		this.theStatus = (ZombieStatus)((ulong)0L);
	}

	// Token: 0x060022B5 RID: 8885 RVA: 0x000B5E00 File Offset: 0x000B4000
	[Token(Token = "0x60022B5")]
	[Address(RVA = "0x5CB590", Offset = "0x5C9B90", VA = "0x1805CB590")]
	public void PlayJumpSound1()
	{
		GameAPP.PlaySound(50, 0.5f, 1f);
	}

	// Token: 0x060022B6 RID: 8886 RVA: 0x000B5E20 File Offset: 0x000B4020
	[Token(Token = "0x60022B6")]
	[Address(RVA = "0x5CB5F0", Offset = "0x5C9BF0", VA = "0x1805CB5F0", Slot = "78")]
	public virtual void PlayJumpSound2()
	{
		GameAPP.PlaySound(51, 0.5f, 1f);
	}

	// Token: 0x060022B7 RID: 8887 RVA: 0x000B5E40 File Offset: 0x000B4040
	[Token(Token = "0x60022B7")]
	[Address(RVA = "0x5CAF40", Offset = "0x5C9540", VA = "0x1805CAF40", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = Resources.Load<Sprite>("Zombies/Zombie_polevaulter/Zombie_polevaulter_outerarm_upper2");
		component.sprite = sprite;
	}

	// Token: 0x060022B8 RID: 8888 RVA: 0x000B5E6C File Offset: 0x000B406C
	[Token(Token = "0x60022B8")]
	[Address(RVA = "0x5CB030", Offset = "0x5C9630", VA = "0x1805CB030", Slot = "79")]
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

	// Token: 0x060022B9 RID: 8889 RVA: 0x000B5F5C File Offset: 0x000B415C
	[Token(Token = "0x60022B9")]
	[Address(RVA = "0x5CAEC0", Offset = "0x5C94C0", VA = "0x1805CAEC0")]
	public PolevaulterZombie()
	{
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x040011E6 RID: 4582
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011E6")]
	protected Vector2 jumpPos2;

	// Token: 0x040011E7 RID: 4583
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011E7")]
	protected Vector2 range = (ulong)1060320051L;
}
