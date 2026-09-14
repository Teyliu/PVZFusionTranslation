using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020003BF RID: 959
[Token(Token = "0x20003BF")]
public class IceBlover : DoomBlover
{
	// Token: 0x06001196 RID: 4502 RVA: 0x0006375C File Offset: 0x0006195C
	[Token(Token = "0x6001196")]
	[Address(RVA = "0x492200", Offset = "0x490800", VA = "0x180492200", Slot = "70")]
	protected override void KeepEffect()
	{
		base.KeepEffect();
		int size = this.board.boardEntity.bulletArray._size;
		int num = size - 1;
		if (size > 0)
		{
			Bullet bullet = this.board.boardEntity.bulletArray[num];
			int num2 = 0;
			if (bullet != num2 && bullet.theBulletType == BulletType.Bullet_snowPea)
			{
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				if (bullet.<Team>k__BackingField == <Team>k__BackingField)
				{
					BoardAction boardAction = this.board.boardAction;
				}
			}
		}
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x000637E4 File Offset: 0x000619E4
	[Token(Token = "0x6001197")]
	[Address(RVA = "0x492060", Offset = "0x490660", VA = "0x180492060", Slot = "71")]
	protected override void BlowEffect()
	{
		ulong num;
		do
		{
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			bool flag;
			if (flag)
			{
				while (flag <= true)
				{
				}
				PlantType thePlantType = this.thePlantType;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x00063820 File Offset: 0x00061A20
	[Token(Token = "0x6001198")]
	[Address(RVA = "0x492360", Offset = "0x490960", VA = "0x180492360")]
	public IceBlover()
	{
	}
}
