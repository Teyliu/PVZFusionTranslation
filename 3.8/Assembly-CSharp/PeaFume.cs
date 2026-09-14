using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000541 RID: 1345
[Token(Token = "0x2000541")]
public class PeaFume : Shooter
{
	// Token: 0x06001903 RID: 6403 RVA: 0x00087628 File Offset: 0x00085828
	[Token(Token = "0x6001903")]
	[Address(RVA = "0x4DACD0", Offset = "0x4D92D0", VA = "0x1804DACD0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		int size = this.board.zombieArray._size;
		int num = 0;
		int num2 = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num2];
			int num3 = 0;
			if (zombie != num3 && !zombie.isMindControlled)
			{
				int thePlantRow = this.thePlantRow;
				if (zombie.theZombieRow == thePlantRow)
				{
					Transform axis = zombie.axis;
					Transform axis2 = this.axis;
					if (Lawnf.InLandStatus(zombie.theStatus))
					{
						PlantType thePlantType = this.thePlantType;
					}
				}
			}
			if (num != 0)
			{
				GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
			}
		}
		GameAPP.PlaySound(58, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06001904 RID: 6404 RVA: 0x000876EC File Offset: 0x000858EC
	[Token(Token = "0x6001904")]
	[Address(RVA = "0x4DAF10", Offset = "0x4D9510", VA = "0x1804DAF10")]
	private void StartShooting()
	{
		int thePlantRow = this.thePlantRow;
		SortingGroup sortingGroup = this.fume;
		string text = string.Format("particle{0}", thePlantRow);
		sortingGroup.sortingLayerName = text;
		Bullet bullet = base.AnimShoot();
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x06001905 RID: 6405 RVA: 0x00087734 File Offset: 0x00085934
	[Token(Token = "0x6001905")]
	[Address(RVA = "0x439AA0", Offset = "0x4380A0", VA = "0x180439AA0")]
	private void EndShooting()
	{
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x0008774C File Offset: 0x0008594C
	[Token(Token = "0x6001906")]
	[Address(RVA = "0x4DAA80", Offset = "0x4D9080", VA = "0x1804DAA80", Slot = "17")]
	protected override void FixedUpdate()
	{
		ulong num3;
		do
		{
			int num = 0;
			base.FixedUpdate();
			if (!base.Active)
			{
				break;
			}
			List<Bullet> bulletArray = this.board.boardEntity.bulletArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				Transform axis = this.axis;
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001907 RID: 6407 RVA: 0x000877BC File Offset: 0x000859BC
	[Token(Token = "0x6001907")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public PeaFume()
	{
	}

	// Token: 0x04000E38 RID: 3640
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E38")]
	public SortingGroup fume;
}
