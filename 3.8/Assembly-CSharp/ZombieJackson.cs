using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200072E RID: 1838
[Token(Token = "0x200072E")]
public class ZombieJackson : Zombie
{
	// Token: 0x0600255E RID: 9566 RVA: 0x000C4E54 File Offset: 0x000C3054
	[Token(Token = "0x600255E")]
	[Address(RVA = "0x5D3DA0", Offset = "0x5D23A0", VA = "0x1805D3DA0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform axis = this.axis;
		int num = 0;
		if (axis != num)
		{
			Transform axis2 = this.axis;
			Vector3 position = axis.position;
			Transform transform = base.transform;
			Vector3 position2 = axis.position;
			int num2 = 0;
			base.transform.localRotation = num2;
			base.AdjustPosition(num2);
		}
	}

	// Token: 0x0600255F RID: 9567 RVA: 0x000C4EBC File Offset: 0x000C30BC
	[Token(Token = "0x600255F")]
	[Address(RVA = "0x5D47C0", Offset = "0x5D2DC0", VA = "0x1805D47C0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float deltaTime = Time.deltaTime;
		this.moonWalkTime = deltaTime;
		if (this.moonWalkTime <= 3f || !this.isMoonWalkFinish)
		{
		}
	}

	// Token: 0x06002560 RID: 9568 RVA: 0x000C4EF4 File Offset: 0x000C30F4
	[Token(Token = "0x6002560")]
	[Address(RVA = "0x5D3FA0", Offset = "0x5D25A0", VA = "0x1805D3FA0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		int rowNum = this.board.rowNum;
		GameObject gameObject = this.dancer[0];
		int num = 0;
		if (!(gameObject == num))
		{
			GameObject gameObject2 = this.dancer[1];
			int num2 = 0;
			if (!(gameObject2 == num2))
			{
				GameObject gameObject3 = this.dancer[2];
				int num3 = 0;
				if (!(gameObject3 == num3))
				{
					GameObject gameObject4 = this.dancer[3];
					int num4 = 0;
					if (!(gameObject4 == num4))
					{
						return;
					}
				}
			}
		}
		this.anim.SetBool("loseDancer", true);
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x000C4FC8 File Offset: 0x000C31C8
	[Token(Token = "0x6002561")]
	[Address(RVA = "0x5D3D40", Offset = "0x5D2340", VA = "0x1805D3D40", Slot = "38")]
	protected override void AttackUpdate()
	{
		if (this.isMoonWalkFinish || !Lawnf.TravelDebuff((TravelDebuff)((uint)13)))
		{
			base.AttackUpdate();
		}
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x000C4FF0 File Offset: 0x000C31F0
	[Token(Token = "0x6002562")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10")]
	private void PointOver()
	{
	}

	// Token: 0x06002563 RID: 9571 RVA: 0x000C5000 File Offset: 0x000C3200
	[Token(Token = "0x6002563")]
	[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "74")]
	protected virtual ZombieType GetZombieType()
	{
		return ZombieType.DancePolZombie;
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x000C5010 File Offset: 0x000C3210
	[Token(Token = "0x6002564")]
	[Address(RVA = "0x5D3880", Offset = "0x5D1E80", VA = "0x1805D3880")]
	private void AnimSummon()
	{
		if (Lawnf.EveBalaced())
		{
			Transform axis = this.axis;
		}
		GameAPP.PlaySound(69, 0.5f, 1f);
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("loseDancer", num != 0);
		GameObject gameObject = this.dancer[0];
		int num2 = 0;
		if (gameObject == num2)
		{
			Board board = this.board;
			int column = base.Column;
			int theZombieRow = this.theZombieRow;
			if (board.GetBoxType(column, theZombieRow) != BoxType.Water)
			{
				Transform axis2 = this.axis;
				GameObject gameObject2;
				this.dancer[0] = gameObject2;
			}
		}
		GameObject gameObject3 = this.dancer[1];
		int num3 = 0;
		if (gameObject3 == num3)
		{
			Transform axis3 = this.axis;
			Board board2 = this.board;
			int theZombieRow2 = this.theZombieRow;
			int num4;
			if (board2.GetBoxType(num4, theZombieRow2) != BoxType.Water)
			{
				Transform axis4 = this.axis;
				GameObject gameObject4;
				this.dancer[1] = gameObject4;
			}
		}
		GameObject gameObject5 = this.dancer[2];
		int num5 = 0;
		if (gameObject5 == num5)
		{
			Transform axis5 = this.axis;
			Board board3 = this.board;
			int theZombieRow3 = this.theZombieRow;
			int num6;
			if (board3.GetBoxType(num6, theZombieRow3) != BoxType.Water)
			{
				Transform axis6 = this.axis;
				GameObject gameObject6;
				this.dancer[2] = gameObject6;
			}
		}
		GameObject gameObject7 = this.dancer[3];
		int num7 = 0;
		if (gameObject7 == num7)
		{
			int rowNum = this.board.rowNum;
			Board board4 = this.board;
			int column2 = base.Column;
			int num8 = this.theZombieRow;
			num8++;
			if (board4.GetBoxType(column2, num8) != BoxType.Water)
			{
				Transform axis7 = this.axis;
				GameObject[] array = this.dancer;
				int num9 = this.theZombieRow;
				num9++;
				GameObject gameObject8;
				array[3] = gameObject8;
			}
		}
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x000C51E8 File Offset: 0x000C33E8
	[Token(Token = "0x6002565")]
	[Address(RVA = "0x5D4540", Offset = "0x5D2B40", VA = "0x1805D4540")]
	private GameObject SetZombie(float x, int row)
	{
		Board board = this.board;
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		ZombieType zombieType = this.GetZombieType();
		Zombie zombie;
		if (zombie.read == 0)
		{
		}
		CreateZombie instance2 = CreateZombie.Instance;
		ZombieType zombieType2 = this.GetZombieType();
		Zombie zombie2;
		Zombie component = zombie2.GetComponent<Zombie>();
		Corner targetCorner = this.targetCorner;
		component.targetCorner = targetCorner;
		ParticleManager instance3 = ParticleManager.Instance;
		Transform axis2 = component.axis;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance3.SetParticle(ParticleType.RandomCloud, num, 11, num3 != 0UL, (float)num2);
		return component.gameObject;
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x000C527C File Offset: 0x000C347C
	[Token(Token = "0x6002566")]
	[Address(RVA = "0x5D4490", Offset = "0x5D2A90", VA = "0x1805D4490", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
		int num = 0;
		base.SetMindControl(num);
		GameObject[] array = this.dancer;
		int num2 = 0;
		if (num2 < array.Length)
		{
			uint num3;
			num3.m_value = (uint)num2;
			GameObject[] array2 = this.dancer;
			num2++;
			num3 += (uint)8;
		}
	}

	// Token: 0x06002567 RID: 9575 RVA: 0x000C52C4 File Offset: 0x000C34C4
	[Token(Token = "0x6002567")]
	[Address(RVA = "0x5D4340", Offset = "0x5D2940", VA = "0x1805D4340")]
	private void LookForward()
	{
		Transform axis = this.axis;
		int num = 0;
		if (axis != num)
		{
			Transform axis2 = this.axis;
			Vector3 position = axis.position;
			Transform transform = base.transform;
			Vector3 position2 = axis.position;
			int num2 = 0;
			base.transform.localRotation = num2;
			base.AdjustPosition(num2);
		}
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x000C5324 File Offset: 0x000C3524
	[Token(Token = "0x6002568")]
	[Address(RVA = "0x5D41F0", Offset = "0x5D27F0", VA = "0x1805D41F0")]
	private void LookBack()
	{
		Transform axis = this.axis;
		int num = 0;
		if (axis != num)
		{
			Transform axis2 = this.axis;
			Vector3 position = axis.position;
			Transform transform = base.transform;
			Vector3 position2 = axis.position;
			int num2 = 0;
			base.transform.localRotation = num2;
			base.AdjustPosition(num2);
		}
	}

	// Token: 0x06002569 RID: 9577 RVA: 0x000C5384 File Offset: 0x000C3584
	[Token(Token = "0x6002569")]
	[Address(RVA = "0x5D3EF0", Offset = "0x5D24F0", VA = "0x1805D3EF0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[26];
		component.sprite = sprite;
	}

	// Token: 0x0600256A RID: 9578 RVA: 0x000C53B4 File Offset: 0x000C35B4
	[Token(Token = "0x600256A")]
	[Address(RVA = "0x5D3730", Offset = "0x5D1D30", VA = "0x1805D3730")]
	private void AdjustAttackPosition()
	{
		Transform axis = this.axis;
		int num = 0;
		if (axis != num)
		{
			Transform axis2 = this.axis;
			Vector3 position = axis.position;
			Transform transform = base.transform;
			Vector3 position2 = axis.position;
			int num2 = 0;
			base.transform.localRotation = num2;
			base.AdjustPosition(num2);
		}
	}

	// Token: 0x0600256B RID: 9579 RVA: 0x000C5414 File Offset: 0x000C3614
	[Token(Token = "0x600256B")]
	[Address(RVA = "0x5D4770", Offset = "0x5D2D70", VA = "0x1805D4770", Slot = "75")]
	protected virtual void StopMoonWalk()
	{
		this.anim.SetTrigger("summon");
		this.isMoonWalkFinish = true;
	}

	// Token: 0x0600256C RID: 9580 RVA: 0x000C5440 File Offset: 0x000C3640
	[Token(Token = "0x600256C")]
	[Address(RVA = "0x5D4880", Offset = "0x5D2E80", VA = "0x1805D4880")]
	public ZombieJackson()
	{
		GameObject[] array = new GameObject[4];
		this.dancer = array;
		base..ctor();
	}

	// Token: 0x040012C9 RID: 4809
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40012C9")]
	private float moonWalkTime;

	// Token: 0x040012CA RID: 4810
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40012CA")]
	private readonly GameObject[] dancer;

	// Token: 0x040012CB RID: 4811
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40012CB")]
	protected bool isMoonWalkFinish;
}
