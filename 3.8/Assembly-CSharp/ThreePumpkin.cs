using System;
using Cpp2IlInjected;

// Token: 0x0200045A RID: 1114
[Token(Token = "0x200045A")]
public class ThreePumpkin : Pumpkin
{
	// Token: 0x0600148C RID: 5260 RVA: 0x000726D4 File Offset: 0x000708D4
	[Token(Token = "0x600148C")]
	[Address(RVA = "0x479630", Offset = "0x477C30", VA = "0x180479630", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)5), action, num != 0);
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x000726F4 File Offset: 0x000708F4
	[Token(Token = "0x600148D")]
	[Address(RVA = "0x479330", Offset = "0x477930", VA = "0x180479330", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)5), action);
	}

	// Token: 0x0600148E RID: 5262 RVA: 0x0007270C File Offset: 0x0007090C
	[Token(Token = "0x600148E")]
	[Address(RVA = "0x4793D0", Offset = "0x4779D0", VA = "0x1804793D0")]
	private void OnZombieTakeDamage(object obj)
	{
		if (obj != 0 && obj != 0)
		{
			float attributeCountdown = this.attributeCountdown;
			bool flag;
			if (flag)
			{
			}
			int num = 0;
			CreateBullet instance = CreateBullet.Instance;
			PlantType thePlantType = this.thePlantType;
			Bullet bullet;
			bullet.fromType = thePlantType;
			bullet.Damage = num;
			this.attributeCountdown = 0.02f;
		}
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x00072768 File Offset: 0x00070968
	[Token(Token = "0x600148F")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public ThreePumpkin()
	{
	}
}
