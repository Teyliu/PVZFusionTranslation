using System;
using Core;
using Cpp2IlInjected;
using UI;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CC9 RID: 3273
	[Token(Token = "0x2000CC9")]
	public class DamageBuff : GeneralBuff
	{
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060043DE RID: 17374 RVA: 0x00161C7C File Offset: 0x0015FE7C
		[Token(Token = "0x170005FE")]
		private float FinalAmount
		{
			[Token(Token = "0x60043DE")]
			[Address(RVA = "0x88FCF0", Offset = "0x88E2F0", VA = "0x18088FCF0")]
			get
			{
				ShootingManager instance = ShootingManager.Instance;
				Quality randomQuality = this.randomQuality;
				return instance.GetQualityValue(0.3f, randomQuality);
			}
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00161CA8 File Offset: 0x0015FEA8
		[Token(Token = "0x60043DF")]
		[Address(RVA = "0x88FA40", Offset = "0x88E040", VA = "0x18088FA40")]
		public DamageBuff(PlantType type)
		{
			this.plantType = type;
			float value = global::UnityEngine.Random.value;
			this.randomQuality = (Quality)((uint)6);
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060043E0 RID: 17376 RVA: 0x00161CE8 File Offset: 0x0015FEE8
		[Token(Token = "0x170005FF")]
		public override string Title
		{
			[Token(Token = "0x60043E0")]
			[Address(RVA = "0x88FD50", Offset = "0x88E350", VA = "0x18088FD50", Slot = "5")]
			get
			{
				return "强化：力量";
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060043E1 RID: 17377 RVA: 0x00161CFC File Offset: 0x0015FEFC
		[Token(Token = "0x17000600")]
		public override string Description
		{
			[Token(Token = "0x60043E1")]
			[Address(RVA = "0x88FAE0", Offset = "0x88E0E0", VA = "0x18088FAE0", Slot = "6")]
			get
			{
				int showType = (int)base.ShowType;
				ShootingManager instance = ShootingManager.Instance;
				Quality randomQuality = this.randomQuality;
				float num = instance.GetQualityValue(0.3f, randomQuality) * 100f;
				TravelData data = TravelMgr.Instance.data;
				PlantType plantType = this.plantType;
				float num2 = data.GetDamageMultiplier(plantType) * 100f;
				string text;
				return text;
			}
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x00161DA8 File Offset: 0x0015FFA8
		[Token(Token = "0x60043E2")]
		[Address(RVA = "0x88F800", Offset = "0x88DE00", VA = "0x18088F800", Slot = "7")]
		public override void OnGet()
		{
			ShootingManager instance = ShootingManager.Instance;
			Quality randomQuality = this.randomQuality;
			float qualityValue = instance.GetQualityValue(0.3f, randomQuality);
			if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)10037)))
			{
			}
			if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)10036)))
			{
			}
			if (!ShootingManager.Instance.superUpgrade)
			{
				if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)10037)))
				{
				}
				if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)10036)))
				{
				}
			}
			float num = global::UnityEngine.Random.Range(qualityValue, 7.5000005f);
			InGameText instance2 = InGameText.Instance;
			float num2 = num * 100f;
			string text = string.Format("获得了{0:F0}%力量增幅", instance2);
			TravelData data = TravelMgr.Instance.data;
			PlantType plantType = this.plantType;
			data.AddDamage(plantType, qualityValue);
		}

		// Token: 0x04003357 RID: 13143
		[Token(Token = "0x4003357")]
		private const float BaseDamage = 0.3f;
	}
}
