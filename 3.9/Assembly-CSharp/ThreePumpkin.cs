using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200047A RID: 1146
[Token(Token = "0x200047A")]
public class ThreePumpkin : Pumpkin
{
	// Token: 0x0600151C RID: 5404 RVA: 0x00074A2C File Offset: 0x00072C2C
	[Token(Token = "0x600151C")]
	[Address(RVA = "0x4D0EF0", Offset = "0x4CF4F0", VA = "0x1804D0EF0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)5), action, num != 0);
	}

	// Token: 0x0600151D RID: 5405 RVA: 0x00074A4C File Offset: 0x00072C4C
	[Token(Token = "0x600151D")]
	[Address(RVA = "0x4D0BF0", Offset = "0x4CF1F0", VA = "0x1804D0BF0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)5), action);
	}

	// Token: 0x0600151E RID: 5406 RVA: 0x00074A64 File Offset: 0x00072C64
	[Token(Token = "0x600151E")]
	[Address(RVA = "0x4D0C90", Offset = "0x4CF290", VA = "0x1804D0C90")]
	private void OnZombieTakeDamage(object obj)
	{
		if (obj != 0 && obj != 0)
		{
			int num = 0;
			List<PlantType> list;
			if (list.Contains(num))
			{
			}
			int num2 = 0;
			CreateBullet instance = CreateBullet.Instance;
			PlantType thePlantType = this.thePlantType;
			Bullet bullet;
			bullet.fromType = thePlantType;
			bullet.Damage = num2;
			this.attributeCountdown = 0.02f;
		}
	}

	// Token: 0x0600151F RID: 5407 RVA: 0x00074AC4 File Offset: 0x00072CC4
	[Token(Token = "0x600151F")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public ThreePumpkin()
	{
	}
}
