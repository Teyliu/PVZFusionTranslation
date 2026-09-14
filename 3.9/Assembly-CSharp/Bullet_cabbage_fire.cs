using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000122 RID: 290
[Token(Token = "0x2000122")]
public class Bullet_cabbage_fire : Bullet_cabbage
{
	// Token: 0x0600058B RID: 1419 RVA: 0x0001D484 File Offset: 0x0001B684
	[Token(Token = "0x600058B")]
	[Address(RVA = "0x6E5F40", Offset = "0x6E4540", VA = "0x1806E5F40", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x0001D4B0 File Offset: 0x0001B6B0
	[Token(Token = "0x600058C")]
	[Address(RVA = "0x6E5A70", Offset = "0x6E4070", VA = "0x1806E5A70", Slot = "22")]
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
			bullet.theStatus = (BulletStatus)((ulong)9L);
			Transform transform4 = bullet.transform;
			int num = 0;
			Transform child = transform4.GetChild(num);
			PlantType fromType2 = this.fromType;
			bullet.fromType = fromType2;
		}
		i++;
		i -= column;
		while (i <= 1)
		{
		}
		uint num2;
		num2 += (uint)1;
		while (num2 <= (uint)1)
		{
		}
		ParticleManager instance2 = ParticleManager.Instance;
		Transform transform5 = base.transform;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x0001D5C0 File Offset: 0x0001B7C0
	[Token(Token = "0x600058D")]
	[Address(RVA = "0x6E5960", Offset = "0x6E3F60", VA = "0x1806E5960", Slot = "17")]
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

	// Token: 0x0600058E RID: 1422 RVA: 0x0001D60C File Offset: 0x0001B80C
	[Token(Token = "0x600058E")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_cabbage_fire()
	{
	}
}
