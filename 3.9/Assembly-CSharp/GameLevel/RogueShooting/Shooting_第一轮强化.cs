using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C5E RID: 3166
	[Token(Token = "0x2000C5E")]
	public class Shooting_第一轮强化 : BaseDebuff
	{
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06004200 RID: 16896 RVA: 0x0015B138 File Offset: 0x00159338
		[Token(Token = "0x17000559")]
		public override int Point
		{
			[Token(Token = "0x6004200")]
			[Address(RVA = "0x88CDD0", Offset = "0x88B3D0", VA = "0x18088CDD0", Slot = "21")]
			get
			{
				return 250;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06004201 RID: 16897 RVA: 0x0015B14C File Offset: 0x0015934C
		[Token(Token = "0x1700055A")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004201")]
			[Address(RVA = "0x88CD90", Offset = "0x88B390", VA = "0x18088CD90", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_第一轮强化;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06004202 RID: 16898 RVA: 0x0015B160 File Offset: 0x00159360
		[Token(Token = "0x1700055B")]
		public override string Description
		{
			[Token(Token = "0x6004202")]
			[Address(RVA = "0x88CDA0", Offset = "0x88B3A0", VA = "0x18088CDA0", Slot = "13")]
			get
			{
				return "第一轮回强化：第一轮回的僵尸血量提高20%，速度提高20%";
			}
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x0015B174 File Offset: 0x00159374
		[Token(Token = "0x6004203")]
		[Address(RVA = "0x88CD00", Offset = "0x88B300", VA = "0x18088CD00", Slot = "17")]
		public override void OnSelect(Board board)
		{
			ShootingManager instance = ShootingManager.Instance;
			float healthMultiplier = instance.healthMultiplier1;
			instance.healthMultiplier1 = healthMultiplier;
			ShootingManager instance2 = ShootingManager.Instance;
			float speedMultiplier = instance2.speedMultiplier1;
			instance2.speedMultiplier1 = speedMultiplier;
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x0015B1B0 File Offset: 0x001593B0
		[Token(Token = "0x6004204")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_第一轮强化()
		{
		}
	}
}
