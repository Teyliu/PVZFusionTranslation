using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004CF RID: 1231
[Token(Token = "0x20004CF")]
public class CherryFume : FumeShroom
{
	// Token: 0x06001739 RID: 5945 RVA: 0x0007FB48 File Offset: 0x0007DD48
	[Token(Token = "0x6001739")]
	[Address(RVA = "0x49EA40", Offset = "0x49D040", VA = "0x18049EA40", Slot = "69")]
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

	// Token: 0x0600173A RID: 5946 RVA: 0x0007FBAC File Offset: 0x0007DDAC
	[Token(Token = "0x600173A")]
	[Address(RVA = "0x49EB60", Offset = "0x49D160", VA = "0x18049EB60", Slot = "47")]
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

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x0600173B RID: 5947 RVA: 0x0007FBF0 File Offset: 0x0007DDF0
	[Token(Token = "0x1700012A")]
	private IReadOnlyList<Bullet> Targets
	{
		[Token(Token = "0x600173B")]
		[Address(RVA = "0x49EF50", Offset = "0x49D550", VA = "0x18049EF50")]
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

	// Token: 0x0600173C RID: 5948 RVA: 0x0007FC80 File Offset: 0x0007DE80
	[Token(Token = "0x600173C")]
	[Address(RVA = "0x49EC30", Offset = "0x49D230", VA = "0x18049EC30")]
	protected void TurnBullet()
	{
		int num;
		do
		{
			num = 0;
			uint num2;
			IEnumerable<Bullet> enumerable = Enumerable.Take<Bullet>(this.Targets, (int)num2);
			if (enumerable != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_002B;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_002B;
				}
				goto IL_003D;
				IL_0041:
				BoardAction boardAction;
				while (boardAction != (ulong)105L)
				{
				}
				BoardAction boardAction2 = this.board.boardAction;
				goto IL_0055;
				IL_003D:
				boardAction += boardAction;
				goto IL_0041;
				IL_002B:
				if (enumerable == (ulong)1L)
				{
					boardAction = this.board.boardAction;
					goto IL_003D;
				}
				goto IL_0041;
			}
			IL_0055:
			if ("{il2cpp array field local7->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x0600173D RID: 5949 RVA: 0x0007FD1C File Offset: 0x0007DF1C
	[Token(Token = "0x600173D")]
	[Address(RVA = "0x49EED0", Offset = "0x49D4D0", VA = "0x18049EED0")]
	public CherryFume()
	{
		List<Bullet> list = new List();
		this._bullets = list;
		base..ctor();
	}

	// Token: 0x04000DBB RID: 3515
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DBB")]
	private readonly List<Bullet> _bullets;
}
