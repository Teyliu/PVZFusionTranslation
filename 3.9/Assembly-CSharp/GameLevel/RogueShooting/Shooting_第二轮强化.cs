using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C5F RID: 3167
	[Token(Token = "0x2000C5F")]
	public class Shooting_第二轮强化 : BaseDebuff
	{
		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06004205 RID: 16901 RVA: 0x0015B1C4 File Offset: 0x001593C4
		[Token(Token = "0x1700055C")]
		public override int Point
		{
			[Token(Token = "0x6004205")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "21")]
			get
			{
				return 100;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06004206 RID: 16902 RVA: 0x0015B1D4 File Offset: 0x001593D4
		[Token(Token = "0x1700055D")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004206")]
			[Address(RVA = "0x88CF40", Offset = "0x88B540", VA = "0x18088CF40", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_第二轮强化;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06004207 RID: 16903 RVA: 0x0015B1E8 File Offset: 0x001593E8
		[Token(Token = "0x1700055E")]
		public override string Description
		{
			[Token(Token = "0x6004207")]
			[Address(RVA = "0x88CF50", Offset = "0x88B550", VA = "0x18088CF50", Slot = "13")]
			get
			{
				return "第二轮回强化：第二轮回的僵尸血量提高40%，速度提高25%";
			}
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x0015B1FC File Offset: 0x001593FC
		[Token(Token = "0x6004208")]
		[Address(RVA = "0x88CEB0", Offset = "0x88B4B0", VA = "0x18088CEB0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			ShootingManager instance = ShootingManager.Instance;
			float num = instance.healthMultiplier2 * 1.4f;
			instance.healthMultiplier2 = num;
			ShootingManager instance2 = ShootingManager.Instance;
			float num2 = instance2.speedMultiplier2 * 1.25f;
			instance2.speedMultiplier2 = num2;
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x0015B244 File Offset: 0x00159444
		[Token(Token = "0x6004209")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_第二轮强化()
		{
		}
	}
}
