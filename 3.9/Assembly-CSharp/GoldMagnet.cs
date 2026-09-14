using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A8 RID: 936
[Token(Token = "0x20003A8")]
public class GoldMagnet : Plant
{
	// Token: 0x06001129 RID: 4393 RVA: 0x0006160C File Offset: 0x0005F80C
	[Token(Token = "0x6001129")]
	[Address(RVA = "0x48BCE0", Offset = "0x48A2E0", VA = "0x18048BCE0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 2.5f;
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x0006162C File Offset: 0x0005F82C
	[Token(Token = "0x600112A")]
	[Address(RVA = "0x48BC70", Offset = "0x48A270", VA = "0x18048BC70", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 5f;
		this.anim.SetTrigger("attrack");
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x00061660 File Offset: 0x0005F860
	[Token(Token = "0x600112B")]
	[Address(RVA = "0x48BA90", Offset = "0x48A090", VA = "0x18048BA90")]
	private void AttrackOver()
	{
		int num = 0;
		this.theStatus = (PlantStatus)num;
		if (this.attrackCount > num)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			GameAPP.PlaySound(97, 0.5f, 1f);
		}
		if (this.attrackCount > num && num < 20)
		{
			CreateItem instance = CreateItem.Instance;
			num++;
		}
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x000616C4 File Offset: 0x0005F8C4
	[Token(Token = "0x600112C")]
	[Address(RVA = "0x48BA10", Offset = "0x48A010", VA = "0x18048BA10")]
	private void AnimAttrack()
	{
		this.attrackCount = (int)((ulong)0L);
		GameAPP.PlaySound(83, 0.5f, 1f);
		this.theStatus = (PlantStatus)((ulong)1L);
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x000616F4 File Offset: 0x0005F8F4
	[Token(Token = "0x600112D")]
	[Address(RVA = "0x48BD10", Offset = "0x48A310", VA = "0x18048BD10", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
			Board board = this.board;
			int num = 0;
			List<Bullet> bulletArray = board.boardEntity.bulletArray;
			Bullet bullet = this.board.boardEntity.bulletArray[num];
			int num2 = 0;
			if (bullet != num2 && !bullet.goldMagneted)
			{
				int thePlantRow = this.thePlantRow;
				if (bullet.theBulletRow != thePlantRow)
				{
					BulletMoveWay moveWay = bullet._moveWay;
					if (moveWay == BulletMoveWay.MoveRight || moveWay == BulletMoveWay.MoveRight_threePeater)
					{
						int thePlantRow2 = this.thePlantRow;
						if (bullet.theBulletRow != thePlantRow2)
						{
							int num3 = this.thePlantRow;
							num3++;
							if (bullet.theBulletRow != num3)
							{
								goto IL_00DC;
							}
						}
						bullet.MoveWay = (BulletMoveWay)((uint)2);
						int thePlantRow3 = this.thePlantRow;
						bullet.theBulletRow = thePlantRow3;
						bullet.goldMagneted = true;
					}
				}
			}
			IL_00DC:
			Board board2 = this.board;
			num++;
		}
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x000617F0 File Offset: 0x0005F9F0
	[Token(Token = "0x600112E")]
	[Address(RVA = "0x48BC20", Offset = "0x48A220", VA = "0x18048BC20")]
	private bool Attrackable(Bullet bullet)
	{
		if (!bullet.goldMagneted)
		{
			int thePlantRow = this.thePlantRow;
			if (bullet.theBulletRow != thePlantRow)
			{
				BulletMoveWay moveWay = bullet._moveWay;
				return moveWay == BulletMoveWay.MoveRight || moveWay == BulletMoveWay.MoveRight_threePeater;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00061834 File Offset: 0x0005FA34
	[Token(Token = "0x600112F")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public GoldMagnet()
	{
	}

	// Token: 0x04000BF2 RID: 3058
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BF2")]
	private int attrackCount;
}
