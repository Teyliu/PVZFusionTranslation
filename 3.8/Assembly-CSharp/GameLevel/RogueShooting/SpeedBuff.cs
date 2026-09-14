using System;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C0E RID: 3086
	[Token(Token = "0x2000C0E")]
	public class SpeedBuff : GeneralBuff
	{
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600406B RID: 16491 RVA: 0x001553A4 File Offset: 0x001535A4
		[Token(Token = "0x170004DA")]
		private float FinalAmount
		{
			[Token(Token = "0x600406B")]
			[Address(RVA = "0x823460", Offset = "0x821A60", VA = "0x180823460")]
			get
			{
				Quality randomQuality = this.randomQuality;
				if (!ShootingManager.Instance.superUpgrade || randomQuality == Quality.diamond)
				{
				}
				if (randomQuality == Quality.Default || randomQuality == Quality.Default || randomQuality == Quality.Default || randomQuality != Quality.silver)
				{
				}
				throw new NullReferenceException();
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x001553E8 File Offset: 0x001535E8
		[Token(Token = "0x170004DB")]
		public override int MaxCount
		{
			[Token(Token = "0x600406C")]
			[Address(RVA = "0x6A6A50", Offset = "0x6A5050", VA = "0x1806A6A50", Slot = "8")]
			get
			{
				return 50;
			}
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x001553F8 File Offset: 0x001535F8
		[Token(Token = "0x600406D")]
		[Address(RVA = "0x8232D0", Offset = "0x8218D0", VA = "0x1808232D0")]
		public SpeedBuff(PlantType type)
		{
			this.plantType = type;
			Quality randomQuality = ShootingManager.Instance.GetRandomQuality();
			this.randomQuality = randomQuality;
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x0015542C File Offset: 0x0015362C
		[Token(Token = "0x170004DC")]
		public override string Title
		{
			[Token(Token = "0x600406E")]
			[Address(RVA = "0x823520", Offset = "0x821B20", VA = "0x180823520", Slot = "5")]
			get
			{
				return "强化：速度";
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x00155440 File Offset: 0x00153640
		[Token(Token = "0x170004DD")]
		public override string Description
		{
			[Token(Token = "0x600406F")]
			[Address(RVA = "0x823340", Offset = "0x821940", VA = "0x180823340", Slot = "6")]
			get
			{
				int showType = (int)base.ShowType;
				float num = this.FinalAmount * 100f;
				TravelMgr instance = TravelMgr.Instance;
				TravelData data = instance.data;
				PlantType plantType = this.plantType;
				float num2 = data.GetSpeed(plantType) * 100f;
				string text;
				return string.Format("{0}获得{1:F0}%速度增幅\n当前增幅：{2:F0}%", text, text, instance);
			}
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x001554A4 File Offset: 0x001536A4
		[Token(Token = "0x6004070")]
		[Address(RVA = "0x8231D0", Offset = "0x8217D0", VA = "0x1808231D0", Slot = "7")]
		public override void OnGet()
		{
			TravelData data = TravelMgr.Instance.data;
			PlantType plantType = this.plantType;
			float finalAmount = this.FinalAmount;
			ShootingManager instance = ShootingManager.Instance;
			bool flag;
			if (flag)
			{
				float finalAmount2 = this.FinalAmount;
			}
		}

		// Token: 0x040030EB RID: 12523
		[Token(Token = "0x40030EB")]
		private const float BaseSpeed = 0.2f;
	}
}
