using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000395 RID: 917
[Token(Token = "0x2000395")]
public class GoldMagnet : Plant
{
	// Token: 0x060010CF RID: 4303 RVA: 0x000600EC File Offset: 0x0005E2EC
	[Token(Token = "0x60010CF")]
	[Address(RVA = "0x4383F0", Offset = "0x4369F0", VA = "0x1804383F0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 2.5f;
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x0006010C File Offset: 0x0005E30C
	[Token(Token = "0x60010D0")]
	[Address(RVA = "0x438380", Offset = "0x436980", VA = "0x180438380", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 5f;
		this.anim.SetTrigger("attrack");
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x00060140 File Offset: 0x0005E340
	[Token(Token = "0x60010D1")]
	[Address(RVA = "0x438180", Offset = "0x436780", VA = "0x180438180")]
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

	// Token: 0x060010D2 RID: 4306 RVA: 0x000601A4 File Offset: 0x0005E3A4
	[Token(Token = "0x60010D2")]
	[Address(RVA = "0x438100", Offset = "0x436700", VA = "0x180438100")]
	private void AnimAttrack()
	{
		this.attrackCount = (int)((ulong)0L);
		GameAPP.PlaySound(83, 0.5f, 1f);
		this.theStatus = (PlantStatus)((ulong)1L);
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x000601D4 File Offset: 0x0005E3D4
	[Token(Token = "0x60010D3")]
	[Address(RVA = "0x438420", Offset = "0x436A20", VA = "0x180438420", Slot = "17")]
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
					if (moveWay != BulletMoveWay.MoveRight)
					{
						if (moveWay > BulletMoveWay.Roll)
						{
							goto IL_00EA;
						}
						Rigidbody2D rb = bullet.rb;
						Vector2 velocity = rb.velocity;
						if (rb != 0)
						{
							goto IL_00EA;
						}
					}
					int thePlantRow2 = this.thePlantRow;
					if (bullet.theBulletRow != thePlantRow2)
					{
						int num3 = this.thePlantRow;
						num3++;
						if (bullet.theBulletRow != num3)
						{
							goto IL_00EA;
						}
					}
					int thePlantRow3 = this.thePlantRow;
					bullet.theBulletRow = thePlantRow3;
					bullet.goldMagneted = true;
				}
			}
			IL_00EA:
			Board board2 = this.board;
			num++;
		}
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x000602E0 File Offset: 0x0005E4E0
	[Token(Token = "0x60010D4")]
	[Address(RVA = "0x438310", Offset = "0x436910", VA = "0x180438310")]
	private bool Attrackable(Bullet bullet)
	{
		if (!bullet.goldMagneted)
		{
			int thePlantRow = this.thePlantRow;
			if (bullet.theBulletRow != thePlantRow)
			{
				BulletMoveWay moveWay = bullet._moveWay;
				if (moveWay != BulletMoveWay.MoveRight && moveWay <= BulletMoveWay.Roll)
				{
					Rigidbody2D rb = bullet.rb;
					Vector2 velocity = rb.velocity;
					if (rb == 0)
					{
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00060334 File Offset: 0x0005E534
	[Token(Token = "0x60010D5")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public GoldMagnet()
	{
	}

	// Token: 0x04000B97 RID: 2967
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B97")]
	private int attrackCount;
}
