using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001E5 RID: 485
[Token(Token = "0x20001E5")]
public class MoveWay_throw : BulletMovement
{
	// Token: 0x06000834 RID: 2100 RVA: 0x00029A58 File Offset: 0x00027C58
	[Token(Token = "0x6000834")]
	[Address(RVA = "0x8FC370", Offset = "0x8FA970", VA = "0x1808FC370", Slot = "6")]
	public override void UpdateHitFilter()
	{
		List<BulletHitFilter> hitFilters = this.bullet.hitFilters;
		int num = 0;
		hitFilters._size = num;
		List<BulletHitFilter> hitFilters2 = this.bullet.hitFilters;
		int size = hitFilters2._size;
		hitFilters2._size = 1;
		List<BulletHitFilter> hitFilters3 = this.bullet.hitFilters;
		int size2 = hitFilters3._size;
		hitFilters3._size = 1;
		List<BulletHitFilter> hitFilters4 = this.bullet.hitFilters;
		int size3 = hitFilters4._size;
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00029ADC File Offset: 0x00027CDC
	[Token(Token = "0x6000835")]
	[Address(RVA = "0x8FC220", Offset = "0x8FA820", VA = "0x1808FC220", Slot = "4")]
	public override void PositionUpdate()
	{
		Bullet bullet = this.bullet;
		Mouse instance = Mouse.Instance;
		Transform transform = bullet.transform;
		Bullet bullet2 = this.bullet;
		Transform transform2 = this.bullet.transform;
		float num;
		Vector3 vector;
		if (num > vector.y)
		{
			Bullet bullet3 = this.bullet;
			bullet3.HitLand();
			EventManager.TriggerEvent((GameEvent)((uint)18), this);
		}
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x00029B40 File Offset: 0x00027D40
	[Token(Token = "0x6000836")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_throw()
	{
		base.PositionUpdate();
	}
}
