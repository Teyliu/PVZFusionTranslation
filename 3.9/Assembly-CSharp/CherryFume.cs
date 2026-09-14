using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004F4 RID: 1268
[Token(Token = "0x20004F4")]
public class CherryFume : FumeShroom
{
	// Token: 0x060017E7 RID: 6119 RVA: 0x00082AD4 File Offset: 0x00080CD4
	[Token(Token = "0x60017E7")]
	[Address(RVA = "0x51DD00", Offset = "0x51C300", VA = "0x18051DD00", Slot = "68")]
	protected override Bullet Shoot1()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform shoot = this.shoot;
		int num = 0;
		int thePlantRow = this.thePlantRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)153), num, thePlantRow, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(58, 0.5f, 1f);
		base.AttackZombie();
		this.TurnBullet();
		throw new NullReferenceException();
	}

	// Token: 0x060017E8 RID: 6120 RVA: 0x00082B38 File Offset: 0x00080D38
	[Token(Token = "0x60017E8")]
	[Address(RVA = "0x51DE20", Offset = "0x51C420", VA = "0x18051DE20", Slot = "46")]
	protected override bool Shootable()
	{
		if (base.Shootable())
		{
		}
		int num = 0;
		IReadOnlyList<Bullet> readOnlyList = this.Targets;
		int num2 = 0;
		if (num2 < num)
		{
			num2 += num2;
			if (num2 == num)
			{
				readOnlyList += readOnlyList;
				throw new NullReferenceException();
			}
			num2++;
		}
		return num2 > 0;
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x060017E9 RID: 6121 RVA: 0x00082B7C File Offset: 0x00080D7C
	[Token(Token = "0x17000170")]
	private IReadOnlyList<Bullet> Targets
	{
		[Token(Token = "0x60017E9")]
		[Address(RVA = "0x51E310", Offset = "0x51C910", VA = "0x18051E310")]
		get
		{
			List<Bullet> bullets = this._bullets;
			int num = 0;
			int size = bullets._size;
			bullets._size = num;
			if (size > 0)
			{
			}
			Transform shoot = this.shoot;
			int num2 = this.bulletLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					Team <Team>k__BackingField = this.<Team>k__BackingField;
					int thePlantRow = this.thePlantRow;
					if (thePlantRow == 1 || thePlantRow == 105)
					{
						List<Bullet> bullets2 = this._bullets;
					}
				}
				num++;
			}
			List<Bullet> bullets3 = this._bullets;
			throw new NullReferenceException();
		}
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x00082C0C File Offset: 0x00080E0C
	[Token(Token = "0x60017EA")]
	[Address(RVA = "0x51DEF0", Offset = "0x51C4F0", VA = "0x18051DEF0")]
	protected void TurnBullet()
	{
		for (;;)
		{
			int num = 0;
			uint num2;
			IEnumerable<Bullet> enumerable = Enumerable.Take<Bullet>(this.Targets, (int)num2);
			if (num >= (int)num2)
			{
				goto IL_001F;
			}
			num += num;
			if (num != (int)num2)
			{
				num++;
				goto IL_001F;
			}
			goto IL_0050;
			IL_005C:
			BoardAction boardAction;
			while (boardAction != (ulong)105L)
			{
			}
			BoardAction boardAction2 = this.board.boardAction;
			if ("{il2cpp array field local7->}" != (ulong)0L)
			{
			}
			if (num == 0)
			{
				break;
			}
			continue;
			IL_001F:
			if (num < typeof(IEnumerable<Bullet>).TypeHandle)
			{
				num += num;
				num++;
			}
			if (num < num)
			{
				num += num;
				if (num == 0)
				{
					goto IL_0058;
				}
				num++;
			}
			if (enumerable == (ulong)1L)
			{
				boardAction = this.board.boardAction;
				goto IL_0050;
			}
			goto IL_005C;
			IL_0058:
			boardAction += boardAction;
			goto IL_005C;
			IL_0050:
			boardAction += boardAction;
			boardAction += boardAction;
			goto IL_0058;
		}
	}

	// Token: 0x060017EB RID: 6123 RVA: 0x00082CC8 File Offset: 0x00080EC8
	[Token(Token = "0x60017EB")]
	[Address(RVA = "0x51E280", Offset = "0x51C880", VA = "0x18051E280")]
	public CherryFume()
	{
		List<Bullet> list = new List();
		this._bullets = list;
		this.range = 7f;
		base..ctor();
	}

	// Token: 0x04000E5E RID: 3678
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E5E")]
	private readonly List<Bullet> _bullets;
}
