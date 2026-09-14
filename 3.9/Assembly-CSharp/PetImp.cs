using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000286 RID: 646
[Token(Token = "0x2000286")]
public class PetImp : MiniPet
{
	// Token: 0x06000BA0 RID: 2976 RVA: 0x00042744 File Offset: 0x00040944
	[Token(Token = "0x6000BA0")]
	[Address(RVA = "0x427F40", Offset = "0x426540", VA = "0x180427F40")]
	private void Start()
	{
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x00042754 File Offset: 0x00040954
	[Token(Token = "0x6000BA1")]
	[Address(RVA = "0x427E00", Offset = "0x426400", VA = "0x180427E00", Slot = "11")]
	protected override void AttackReady(bool moveOver)
	{
		base.AttackReady(moveOver);
		this.anim.SetTrigger("shoot");
		int num = global::UnityEngine.Random.Range(0, 2);
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x00042788 File Offset: 0x00040988
	[Token(Token = "0x6000BA2")]
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

	// Token: 0x06000BA3 RID: 2979 RVA: 0x000427EC File Offset: 0x000409EC
	[Token(Token = "0x6000BA3")]
	[Address(RVA = "0x4276F0", Offset = "0x425CF0", VA = "0x1804276F0", Slot = "9")]
	protected override void AnimAttack()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			Func<Zombie, bool> <>9__3_ = PetImp.<>c.<>9__3_0;
			if (<>9__3_ == 0)
			{
				PetImp.<>c.<>9__3_0 = delegate(Zombie a)
				{
					int theZombieType = (int)a.theZombieType;
					bool flag;
					if (!flag && a.theZombieType != ZombieType.BoatImp && a.theZombieType != ZombieType.ChickenImp && a.theZombieType != ZombieType.ImpZombie && a.theZombieType != ZombieType.ObsidianImpZombie)
					{
						return a.theZombieType != ZombieType.ArmoredImpZombie;
					}
					throw new NullReferenceException();
				};
			}
			List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__3_));
			ListExtensions.Shuffle<Zombie>(list);
			int level = this.level;
			Board board = this.board;
			uint num2;
			IEnumerable<Zombie> enumerable = Enumerable.Take<Zombie>(list, (int)num2);
			if (num >= (int)num2)
			{
				goto IL_0067;
			}
			num += num;
			if (num != (int)num2)
			{
				num++;
				goto IL_0067;
			}
			goto IL_009B;
			IL_00B0:
			CreateZombie instance = CreateZombie.Instance;
			int num3 = 0;
			Zombie zombie;
			if (zombie != num3)
			{
				float theOriginSpeed = zombie.theOriginSpeed;
				zombie.theOriginSpeed = theOriginSpeed;
			}
			ParticleManager instance2 = ParticleManager.Instance;
			Vector3 vector;
			float z = vector.z;
			if (num == 0)
			{
				break;
			}
			continue;
			IL_0067:
			if (num < typeof(IEnumerable<Zombie>).TypeHandle)
			{
				num += num;
				num++;
			}
			if (num < num)
			{
				num += num;
				if (num == 0)
				{
					goto IL_00A9;
				}
				num++;
			}
			BoxType boxType;
			CreateZombie createZombie;
			if (boxType != BoxType.Water)
			{
				createZombie = CreateZombie.Instance;
				goto IL_009B;
			}
			goto IL_00B0;
			IL_00A9:
			createZombie += createZombie;
			goto IL_00B0;
			IL_009B:
			createZombie += createZombie;
			createZombie += createZombie;
			goto IL_00A9;
		}
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x0004292C File Offset: 0x00040B2C
	[Token(Token = "0x6000BA4")]
	[Address(RVA = "0x427F60", Offset = "0x426560", VA = "0x180427F60")]
	public PetImp()
	{
	}
}
