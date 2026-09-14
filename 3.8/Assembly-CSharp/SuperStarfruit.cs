using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000583 RID: 1411
[Token(Token = "0x2000583")]
public class SuperStarfruit : LanternStarFruit
{
	// Token: 0x06001A12 RID: 6674 RVA: 0x0008C3FC File Offset: 0x0008A5FC
	[Token(Token = "0x6001A12")]
	[Address(RVA = "0x4EB2B0", Offset = "0x4E98B0", VA = "0x1804EB2B0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Board board = this.board;
		board.ActiveCreateMeteorite();
	}

	// Token: 0x06001A13 RID: 6675 RVA: 0x0008C428 File Offset: 0x0008A628
	[Token(Token = "0x6001A13")]
	[Address(RVA = "0x4EB120", Offset = "0x4E9720", VA = "0x1804EB120", Slot = "73")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.theStatus = (BulletStatus)((ulong)4L);
		Transform transform = bullet.transform;
		int num = this.attackDamage;
		num += num;
		Quaternion quaternion;
		float x;
		if (num >= quaternion)
		{
			x = quaternion.x;
		}
		bullet.Damage = (int)x;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001A14 RID: 6676 RVA: 0x0008C490 File Offset: 0x0008A690
	[Token(Token = "0x6001A14")]
	[Address(RVA = "0x4EB050", Offset = "0x4E9650", VA = "0x1804EB050", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		base.OnCreate(theColumn, theRow);
		InGameUI instance = InGameUI.Instance;
		int num = 0;
		if (instance != num)
		{
			InGameUI.Instance.Stars.SetActive(true);
		}
	}

	// Token: 0x06001A15 RID: 6677 RVA: 0x0008C4D0 File Offset: 0x0008A6D0
	[Token(Token = "0x6001A15")]
	[Address(RVA = "0x4C8690", Offset = "0x4C6C90", VA = "0x1804C8690")]
	public SuperStarfruit()
	{
	}
}
