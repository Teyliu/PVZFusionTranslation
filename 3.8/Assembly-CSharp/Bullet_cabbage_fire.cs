using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200011C RID: 284
[Token(Token = "0x200011C")]
public class Bullet_cabbage_fire : Bullet_cabbage
{
	// Token: 0x0600057A RID: 1402 RVA: 0x0001DAF8 File Offset: 0x0001BCF8
	[Token(Token = "0x600057A")]
	[Address(RVA = "0x6BB0F0", Offset = "0x6B96F0", VA = "0x1806BB0F0", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x0001DB24 File Offset: 0x0001BD24
	[Token(Token = "0x600057B")]
	[Address(RVA = "0x6BAB80", Offset = "0x6B9180", VA = "0x1806BAB80", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		zombie.SetJalaed();
		PlantType fromType = this.fromType;
		int column = zombie.Column;
		int theBulletRow = this.theBulletRow;
		int i = column - 1;
		Board board = this.board;
		if (i < board.columnNum)
		{
			float boxXFromColumn = Lawnf.GetBoxXFromColumn(i);
			int rowNum = this.board.rowNum;
			float boxYFromRow = Lawnf.GetBoxYFromRow(i, rowNum);
			CreateBullet instance = CreateBullet.Instance;
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			BulletType theBulletType = this.theBulletType;
			Bullet bullet;
			Transform transform3 = bullet.transform;
			float[] array;
			float num = array[0];
			bullet.Vx = num;
			float num2 = array[1];
			bullet.Vy = num2;
			float num3 = array[1];
			bullet.theStatus = (BulletStatus)((ulong)9L);
			bullet.detaVy = num3;
			Transform transform4 = bullet.transform;
			int num4 = 0;
			Transform child = transform4.GetChild(num4);
			PlantType fromType2 = this.fromType;
			bullet.fromType = fromType2;
		}
		i++;
		i -= column;
		while (i <= 1)
		{
		}
		uint num5;
		num5 += (uint)1;
		ParticleManager instance2 = ParticleManager.Instance;
		Transform transform5 = base.transform;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x0001DC64 File Offset: 0x0001BE64
	[Token(Token = "0x600057C")]
	[Address(RVA = "0x6BAA70", Offset = "0x6B9070", VA = "0x1806BAA70", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)116), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x0001DCB0 File Offset: 0x0001BEB0
	[Token(Token = "0x600057D")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_cabbage_fire()
	{
	}
}
