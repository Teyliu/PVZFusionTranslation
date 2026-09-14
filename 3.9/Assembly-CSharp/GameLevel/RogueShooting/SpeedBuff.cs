using System;
using Core;
using Cpp2IlInjected;
using UI;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CCA RID: 3274
	[Token(Token = "0x2000CCA")]
	public class SpeedBuff : GeneralBuff
	{
		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060043E3 RID: 17379 RVA: 0x00161E6C File Offset: 0x0016006C
		[Token(Token = "0x17000601")]
		private float FinalAmount
		{
			[Token(Token = "0x60043E3")]
			[Address(RVA = "0x8A11E0", Offset = "0x89F7E0", VA = "0x1808A11E0")]
			get
			{
				ShootingManager instance = ShootingManager.Instance;
				Quality randomQuality = this.randomQuality;
				return instance.GetQualityValue(0.2f, randomQuality);
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060043E4 RID: 17380 RVA: 0x00161E98 File Offset: 0x00160098
		[Token(Token = "0x17000602")]
		public override int MaxCount
		{
			[Token(Token = "0x60043E4")]
			[Address(RVA = "0x720BB0", Offset = "0x71F1B0", VA = "0x180720BB0", Slot = "8")]
			get
			{
				return 50;
			}
		}

		// Token: 0x060043E5 RID: 17381 RVA: 0x00161EA8 File Offset: 0x001600A8
		[Token(Token = "0x60043E5")]
		[Address(RVA = "0x8A0F30", Offset = "0x89F530", VA = "0x1808A0F30")]
		public SpeedBuff(PlantType type)
		{
			this.plantType = type;
			float value = global::UnityEngine.Random.value;
			this.randomQuality = (Quality)((uint)6);
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060043E6 RID: 17382 RVA: 0x00161EE8 File Offset: 0x001600E8
		[Token(Token = "0x17000603")]
		public override string Title
		{
			[Token(Token = "0x60043E6")]
			[Address(RVA = "0x8A1240", Offset = "0x89F840", VA = "0x1808A1240", Slot = "5")]
			get
			{
				return "强化：速度";
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x00161EFC File Offset: 0x001600FC
		[Token(Token = "0x17000604")]
		public override string Description
		{
			[Token(Token = "0x60043E7")]
			[Address(RVA = "0x8A0FD0", Offset = "0x89F5D0", VA = "0x1808A0FD0", Slot = "6")]
			get
			{
				int showType = (int)base.ShowType;
				ShootingManager instance = ShootingManager.Instance;
				Quality randomQuality = this.randomQuality;
				float num = instance.GetQualityValue(0.2f, randomQuality) * 100f;
				TravelData data = TravelMgr.Instance.data;
				PlantType plantType = this.plantType;
				float num2 = data.GetSpeed(plantType) * 100f;
				string text;
				return text;
			}
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x00161FA8 File Offset: 0x001601A8
		[Token(Token = "0x60043E8")]
		[Address(RVA = "0x8A0CA0", Offset = "0x89F2A0", VA = "0x1808A0CA0", Slot = "7")]
		public override void OnGet()
		{
			ShootingManager instance = ShootingManager.Instance;
			Quality randomQuality = this.randomQuality;
			float qualityValue = instance.GetQualityValue(0.2f, randomQuality);
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
			float num = global::UnityEngine.Random.Range(qualityValue, 5f);
			InGameText instance2 = InGameText.Instance;
			float num2 = num * 100f;
			string text = string.Format("获得了{0:F0}%速度增幅", instance2);
			TravelData data = TravelMgr.Instance.data;
			PlantType plantType = this.plantType;
			data.AddSpeed(plantType, qualityValue);
			ShootingManager instance3 = ShootingManager.Instance;
			bool flag;
			if (flag)
			{
			}
		}

		// Token: 0x04003358 RID: 13144
		[Token(Token = "0x4003358")]
		private const float BaseSpeed = 0.2f;
	}
}
