using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000280 RID: 640
[Token(Token = "0x2000280")]
public class PetImp : MiniPet
{
	// Token: 0x06000B84 RID: 2948 RVA: 0x00042914 File Offset: 0x00040B14
	[Token(Token = "0x6000B84")]
	[Address(RVA = "0x3D9DA0", Offset = "0x3D83A0", VA = "0x1803D9DA0")]
	private void Start()
	{
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x00042924 File Offset: 0x00040B24
	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x3D9C60", Offset = "0x3D8260", VA = "0x1803D9C60", Slot = "11")]
	protected override void AttackReady(bool moveOver)
	{
		base.AttackReady(moveOver);
		this.anim.SetTrigger("shoot");
		int num = global::UnityEngine.Random.Range(0, 2);
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x00042958 File Offset: 0x00040B58
	[Token(Token = "0x6000B86")]
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

	// Token: 0x06000B87 RID: 2951 RVA: 0x000429BC File Offset: 0x00040BBC
	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x3D9550", Offset = "0x3D7B50", VA = "0x1803D9550", Slot = "9")]
	protected override void AnimAttack()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			Func<Zombie, bool> <>9__3_ = PetImp.<>c.<>9__3_0;
			if (<>9__3_ == 0)
			{
				Func<Zombie, bool> func;
				PetImp.<>c.<>9__3_0 = func;
			}
			List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__3_));
			ListExtensions.Shuffle<Zombie>(list);
			int level = this.level;
			Board board = this.board;
			uint num2;
			IEnumerable<Zombie> enumerable = Enumerable.Take<Zombie>(list, (int)num2);
			if (num >= (int)num2)
			{
				goto IL_005B;
			}
			num += num;
			if (num != (int)num2)
			{
				num++;
				goto IL_005B;
			}
			goto IL_008F;
			IL_00A4:
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
			IL_005B:
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
					goto IL_009D;
				}
				num++;
			}
			BoxType boxType;
			CreateZombie createZombie;
			if (boxType != BoxType.Water)
			{
				createZombie = CreateZombie.Instance;
				goto IL_008F;
			}
			goto IL_00A4;
			IL_009D:
			createZombie += createZombie;
			goto IL_00A4;
			IL_008F:
			createZombie += createZombie;
			createZombie += createZombie;
			goto IL_009D;
		}
	}

	// Token: 0x06000B88 RID: 2952 RVA: 0x00042AF0 File Offset: 0x00040CF0
	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x3D9DC0", Offset = "0x3D83C0", VA = "0x1803D9DC0")]
	public PetImp()
	{
	}
}
