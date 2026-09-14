using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000282 RID: 642
[Token(Token = "0x2000282")]
public class PetJackbox : MiniPet
{
	// Token: 0x06000B8C RID: 2956 RVA: 0x00042B90 File Offset: 0x00040D90
	[Token(Token = "0x6000B8C")]
	[Address(RVA = "0x3D9DA0", Offset = "0x3D83A0", VA = "0x1803D9DA0")]
	private void Start()
	{
	}

	// Token: 0x06000B8D RID: 2957 RVA: 0x00042BA0 File Offset: 0x00040DA0
	[Token(Token = "0x6000B8D")]
	[Address(RVA = "0x3DA570", Offset = "0x3D8B70", VA = "0x1803DA570", Slot = "11")]
	protected override void AttackReady(bool moveOver)
	{
		base.AttackReady(moveOver);
		Animator anim = this.anim;
		int num = global::UnityEngine.Random.Range(1, 4);
		string text = string.Format("attack{0}", num);
		anim.SetTrigger(text);
	}

	// Token: 0x06000B8E RID: 2958 RVA: 0x00042BDC File Offset: 0x00040DDC
	[Token(Token = "0x6000B8E")]
	[Address(RVA = "0x3D9D20", Offset = "0x3D8320", VA = "0x1803D9D20", Slot = "18")]
	protected override void SetTarget()
	{
		int num = 0;
		int num2 = 0;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(num);
		Board board = this.board;
		Mouse mouse = this.mouse;
		int num3 = board.rowNum;
		num3 -= num2;
		float landY = mouse.GetLandY(boxXFromColumn, num3);
		this.targetPosition = boxXFromColumn;
		this.targetPosition.y = landY;
		this.moving = true;
	}

	// Token: 0x06000B8F RID: 2959 RVA: 0x00042C40 File Offset: 0x00040E40
	[Token(Token = "0x6000B8F")]
	[Address(RVA = "0x3D9E10", Offset = "0x3D8410", VA = "0x1803D9E10")]
	private void AnimAttack1()
	{
		base.GetExperience(10);
		int num = 0;
		int num2 = 0;
		Board board = this.board;
		if (num < board.rowNum)
		{
			CreateZombie instance = CreateZombie.Instance;
			float boxXFromColumn = Lawnf.GetBoxXFromColumn(num);
			Zombie zombie = instance.SetZombieWithMindControl(num, (ZombieType)((uint)30), boxXFromColumn, num != 0);
			int num3 = 0;
			if (zombie != num3)
			{
				int level = this.level;
				int num4 = level * level;
				zombie.level = num4;
				int theAttackDamage = zombie.theAttackDamage;
				zombie.theAttackDamage = theAttackDamage;
				int level2 = this.level;
				Lawnf.SetZombieHealth(zombie, (float)num3);
				Transform axis = zombie.axis;
				ParticleManager instance2 = ParticleManager.Instance;
				int num5 = 0;
				ulong num6;
				Particle particle = instance2.SetParticle(ParticleType.RandomCloud, num5, 11, num6 != 0UL, (float)num2);
			}
			num++;
		}
		num++;
	}

	// Token: 0x06000B90 RID: 2960 RVA: 0x00042D08 File Offset: 0x00040F08
	[Token(Token = "0x6000B90")]
	[Address(RVA = "0x3DA030", Offset = "0x3D8630", VA = "0x1803DA030")]
	private void AnimAttack2()
	{
		base.GetExperience(30);
		if (this.level == 2)
		{
		}
		Board board = this.board;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if (num2 < board.columnNum)
		{
			int num4 = 0;
			Board board2 = this.board;
			if (num4 < board2.rowNum)
			{
				GameObject gameObject = Resources.Load<GameObject>("Zombies/Zombie_pogo/JackboxJump/WaterJackboxJump/JackboxBomb");
				Transform shoot = this.shoot;
				Vector3 vector;
				float z = vector.z;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = this.board.transform;
				GameObject gameObject2;
				JackboxBomb component = gameObject2.GetComponent<JackboxBomb>();
				component.theRow = num4;
				component.isMindConrolled = true;
				Board board3 = this.board;
				component.board = board3;
				if (component <= 0)
				{
				}
				num4++;
				component.damage = (int)((uint)10000);
				component.v.z = (float)num3;
			}
			num++;
		}
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x00042DE8 File Offset: 0x00040FE8
	[Token(Token = "0x6000B91")]
	[Address(RVA = "0x3DA340", Offset = "0x3D8940", VA = "0x1803DA340")]
	private void AnimAttack3()
	{
		int num;
		do
		{
			base.GetExperience(50);
			if (this.level == 2)
			{
			}
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			num = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x00042E2C File Offset: 0x0004102C
	[Token(Token = "0x6000B92")]
	[Address(RVA = "0x3DA620", Offset = "0x3D8C20", VA = "0x1803DA620")]
	public PetJackbox()
	{
	}
}
