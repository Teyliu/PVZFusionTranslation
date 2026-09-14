using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C60 RID: 3168
	[Token(Token = "0x2000C60")]
	public class Shooting_第三轮强化 : BaseDebuff
	{
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600420A RID: 16906 RVA: 0x0015B258 File Offset: 0x00159458
		[Token(Token = "0x1700055F")]
		public override int Point
		{
			[Token(Token = "0x600420A")]
			[Address(RVA = "0x88CDD0", Offset = "0x88B3D0", VA = "0x18088CDD0", Slot = "21")]
			get
			{
				return 250;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x0015B26C File Offset: 0x0015946C
		[Token(Token = "0x17000560")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x600420B")]
			[Address(RVA = "0x88CE70", Offset = "0x88B470", VA = "0x18088CE70", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_第三轮强化;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600420C RID: 16908 RVA: 0x0015B280 File Offset: 0x00159480
		[Token(Token = "0x17000561")]
		public override string Description
		{
			[Token(Token = "0x600420C")]
			[Address(RVA = "0x88CE80", Offset = "0x88B480", VA = "0x18088CE80", Slot = "13")]
			get
			{
				return "第三轮回强化：第三轮回的僵尸血量提高60%，速度提高30%";
			}
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x0015B294 File Offset: 0x00159494
		[Token(Token = "0x600420D")]
		[Address(RVA = "0x88CDE0", Offset = "0x88B3E0", VA = "0x18088CDE0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			ShootingManager instance = ShootingManager.Instance;
			float num = instance.healthMultiplier3 * 1.6f;
			instance.healthMultiplier3 = num;
			ShootingManager instance2 = ShootingManager.Instance;
			float num2 = instance2.speedMultiplier3 * 1.3f;
			instance2.speedMultiplier3 = num2;
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x0015B2DC File Offset: 0x001594DC
		[Token(Token = "0x600420E")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_第三轮强化()
		{
		}
	}
}
