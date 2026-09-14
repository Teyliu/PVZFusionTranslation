using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005B4 RID: 1460
[Token(Token = "0x20005B4")]
public class SuperStarfruit : LanternStarFruit
{
	// Token: 0x06001AF8 RID: 6904 RVA: 0x00090784 File Offset: 0x0008E984
	[Token(Token = "0x6001AF8")]
	[Address(RVA = "0x54B110", Offset = "0x549710", VA = "0x18054B110", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Board board = this.board;
		board.ActiveCreateMeteorite();
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x000907B0 File Offset: 0x0008E9B0
	[Token(Token = "0x6001AF9")]
	[Address(RVA = "0x54AF80", Offset = "0x549580", VA = "0x18054AF80", Slot = "72")]
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

	// Token: 0x06001AFA RID: 6906 RVA: 0x00090818 File Offset: 0x0008EA18
	[Token(Token = "0x6001AFA")]
	[Address(RVA = "0x54AEB0", Offset = "0x5494B0", VA = "0x18054AEB0", Slot = "54")]
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

	// Token: 0x06001AFB RID: 6907 RVA: 0x00090858 File Offset: 0x0008EA58
	[Token(Token = "0x6001AFB")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public SuperStarfruit()
	{
	}
}
