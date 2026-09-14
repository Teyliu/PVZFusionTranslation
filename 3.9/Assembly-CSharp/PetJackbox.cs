using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000288 RID: 648
[Token(Token = "0x2000288")]
public class PetJackbox : MiniPet
{
	// Token: 0x06000BA8 RID: 2984 RVA: 0x000429CC File Offset: 0x00040BCC
	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0x427F40", Offset = "0x426540", VA = "0x180427F40")]
	private void Start()
	{
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x000429DC File Offset: 0x00040BDC
	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0x428710", Offset = "0x426D10", VA = "0x180428710", Slot = "11")]
	protected override void AttackReady(bool moveOver)
	{
		base.AttackReady(moveOver);
		Animator anim = this.anim;
		int num = global::UnityEngine.Random.Range(1, 4);
		string text = string.Format("attack{0}", num);
		anim.SetTrigger(text);
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x00042A18 File Offset: 0x00040C18
	[Token(Token = "0x6000BAA")]
	[Address(RVA = "0x427EC0", Offset = "0x4264C0", VA = "0x180427EC0", Slot = "18")]
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

	// Token: 0x06000BAB RID: 2987 RVA: 0x00042A7C File Offset: 0x00040C7C
	[Token(Token = "0x6000BAB")]
	[Address(RVA = "0x427FB0", Offset = "0x4265B0", VA = "0x180427FB0")]
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

	// Token: 0x06000BAC RID: 2988 RVA: 0x00042B44 File Offset: 0x00040D44
	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0x4281D0", Offset = "0x4267D0", VA = "0x1804281D0")]
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

	// Token: 0x06000BAD RID: 2989 RVA: 0x00042C24 File Offset: 0x00040E24
	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0x4284E0", Offset = "0x426AE0", VA = "0x1804284E0")]
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

	// Token: 0x06000BAE RID: 2990 RVA: 0x00042C68 File Offset: 0x00040E68
	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x4287C0", Offset = "0x426DC0", VA = "0x1804287C0")]
	public PetJackbox()
	{
	}
}
