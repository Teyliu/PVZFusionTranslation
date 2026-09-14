using System;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C0D RID: 3085
	[Token(Token = "0x2000C0D")]
	public class DamageBuff : GeneralBuff
	{
		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x00155284 File Offset: 0x00153484
		[Token(Token = "0x170004D7")]
		private float FinalAmount
		{
			[Token(Token = "0x6004066")]
			[Address(RVA = "0x80BBF0", Offset = "0x80A1F0", VA = "0x18080BBF0")]
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

		// Token: 0x06004067 RID: 16487 RVA: 0x001552C8 File Offset: 0x001534C8
		[Token(Token = "0x6004067")]
		[Address(RVA = "0x80BA60", Offset = "0x80A060", VA = "0x18080BA60")]
		public DamageBuff(PlantType type)
		{
			this.plantType = type;
			Quality randomQuality = ShootingManager.Instance.GetRandomQuality();
			this.randomQuality = randomQuality;
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x001552FC File Offset: 0x001534FC
		[Token(Token = "0x170004D8")]
		public override string Title
		{
			[Token(Token = "0x6004068")]
			[Address(RVA = "0x80BCB0", Offset = "0x80A2B0", VA = "0x18080BCB0", Slot = "5")]
			get
			{
				return "强化：力量";
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06004069 RID: 16489 RVA: 0x00155310 File Offset: 0x00153510
		[Token(Token = "0x170004D9")]
		public override string Description
		{
			[Token(Token = "0x6004069")]
			[Address(RVA = "0x80BAD0", Offset = "0x80A0D0", VA = "0x18080BAD0", Slot = "6")]
			get
			{
				int showType = (int)base.ShowType;
				float num = this.FinalAmount * 100f;
				TravelMgr instance = TravelMgr.Instance;
				TravelData data = instance.data;
				PlantType plantType = this.plantType;
				float num2 = data.GetDamageMultiplier(plantType) * 100f;
				string text;
				return string.Format("{0}获得{1:F0}%独立伤害增幅\n当前增幅：{2:F0}%", text, text, instance);
			}
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x00155374 File Offset: 0x00153574
		[Token(Token = "0x600406A")]
		[Address(RVA = "0x80B9D0", Offset = "0x809FD0", VA = "0x18080B9D0", Slot = "7")]
		public override void OnGet()
		{
			TravelData data = TravelMgr.Instance.data;
			PlantType plantType = this.plantType;
			float finalAmount = this.FinalAmount;
		}

		// Token: 0x040030EA RID: 12522
		[Token(Token = "0x40030EA")]
		private const float BaseDamage = 0.3f;
	}
}
