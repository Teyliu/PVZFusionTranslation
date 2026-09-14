using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000767 RID: 1895
[Token(Token = "0x2000767")]
public class ZombieJackson : Zombie
{
	// Token: 0x06002683 RID: 9859 RVA: 0x000C9D78 File Offset: 0x000C7F78
	[Token(Token = "0x6002683")]
	[Address(RVA = "0x635220", Offset = "0x633820", VA = "0x180635220", Slot = "10")]
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

	// Token: 0x06002684 RID: 9860 RVA: 0x000C9DE0 File Offset: 0x000C7FE0
	[Token(Token = "0x6002684")]
	[Address(RVA = "0x635C20", Offset = "0x634220", VA = "0x180635C20", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		float deltaTime = Time.deltaTime;
		this.moonWalkTime = deltaTime;
		if (this.moonWalkTime <= 3f || !this.isMoonWalkFinish)
		{
		}
	}

	// Token: 0x06002685 RID: 9861 RVA: 0x000C9E18 File Offset: 0x000C8018
	[Token(Token = "0x6002685")]
	[Address(RVA = "0x635420", Offset = "0x633A20", VA = "0x180635420", Slot = "18")]
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

	// Token: 0x06002686 RID: 9862 RVA: 0x000C9EEC File Offset: 0x000C80EC
	[Token(Token = "0x6002686")]
	[Address(RVA = "0x6351C0", Offset = "0x6337C0", VA = "0x1806351C0", Slot = "40")]
	protected override void AttackUpdate()
	{
		if (this.isMoonWalkFinish || !Lawnf.TravelDebuff((TravelDebuff)((uint)13)))
		{
			base.AttackUpdate();
		}
	}

	// Token: 0x06002687 RID: 9863 RVA: 0x000C9F14 File Offset: 0x000C8114
	[Token(Token = "0x6002687")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
	private void PointOver()
	{
	}

	// Token: 0x06002688 RID: 9864 RVA: 0x000C9F24 File Offset: 0x000C8124
	[Token(Token = "0x6002688")]
	[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "76")]
	protected virtual ZombieType GetZombieType()
	{
		return ZombieType.DancePolZombie;
	}

	// Token: 0x06002689 RID: 9865 RVA: 0x000C9F34 File Offset: 0x000C8134
	[Token(Token = "0x6002689")]
	[Address(RVA = "0x634CD0", Offset = "0x6332D0", VA = "0x180634CD0")]
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

	// Token: 0x0600268A RID: 9866 RVA: 0x000CA10C File Offset: 0x000C830C
	[Token(Token = "0x600268A")]
	[Address(RVA = "0x6359C0", Offset = "0x633FC0", VA = "0x1806359C0", Slot = "77")]
	protected virtual GameObject SetZombie(float x, int row)
	{
		Board board = this.board;
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		ZombieType zombieType = this.GetZombieType();
		Zombie zombie;
		if (zombie.takeDmgMultiplier == 0f)
		{
		}
		CreateZombie instance2 = CreateZombie.Instance;
		ZombieType zombieType2 = this.GetZombieType();
		Corner targetCorner = this.targetCorner;
		Zombie zombie2;
		zombie2.targetCorner = targetCorner;
		Transform axis2 = zombie2.axis;
		ParticleManager instance3 = ParticleManager.Instance;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance3.SetParticle(ParticleType.RandomCloud, num, 11, num3 != 0UL, (float)num2);
		return zombie2.gameObject;
	}

	// Token: 0x0600268B RID: 9867 RVA: 0x000CA19C File Offset: 0x000C839C
	[Token(Token = "0x600268B")]
	[Address(RVA = "0x635910", Offset = "0x633F10", VA = "0x180635910", Slot = "27")]
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

	// Token: 0x0600268C RID: 9868 RVA: 0x000CA1E4 File Offset: 0x000C83E4
	[Token(Token = "0x600268C")]
	[Address(RVA = "0x6357C0", Offset = "0x633DC0", VA = "0x1806357C0")]
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

	// Token: 0x0600268D RID: 9869 RVA: 0x000CA244 File Offset: 0x000C8444
	[Token(Token = "0x600268D")]
	[Address(RVA = "0x635670", Offset = "0x633C70", VA = "0x180635670")]
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

	// Token: 0x0600268E RID: 9870 RVA: 0x000CA2A4 File Offset: 0x000C84A4
	[Token(Token = "0x600268E")]
	[Address(RVA = "0x635370", Offset = "0x633970", VA = "0x180635370", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[26];
		component.sprite = sprite;
	}

	// Token: 0x0600268F RID: 9871 RVA: 0x000CA2D4 File Offset: 0x000C84D4
	[Token(Token = "0x600268F")]
	[Address(RVA = "0x634B80", Offset = "0x633180", VA = "0x180634B80")]
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

	// Token: 0x06002690 RID: 9872 RVA: 0x000CA334 File Offset: 0x000C8534
	[Token(Token = "0x6002690")]
	[Address(RVA = "0x635BD0", Offset = "0x6341D0", VA = "0x180635BD0", Slot = "78")]
	protected virtual void StopMoonWalk()
	{
		this.anim.SetTrigger("summon");
		this.isMoonWalkFinish = true;
	}

	// Token: 0x06002691 RID: 9873 RVA: 0x000CA360 File Offset: 0x000C8560
	[Token(Token = "0x6002691")]
	[Address(RVA = "0x635CE0", Offset = "0x6342E0", VA = "0x180635CE0")]
	public ZombieJackson()
	{
		GameObject[] array = new GameObject[4];
		this.dancer = array;
		base..ctor();
	}

	// Token: 0x0400139E RID: 5022
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400139E")]
	public float moonWalkTime;

	// Token: 0x0400139F RID: 5023
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400139F")]
	private readonly GameObject[] dancer;

	// Token: 0x040013A0 RID: 5024
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40013A0")]
	protected bool isMoonWalkFinish;
}
