using System;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A58 RID: 2648
	[Token(Token = "0x2000A58")]
	public class AnimTool : MonoBehaviour
	{
		// Token: 0x0600368A RID: 13962 RVA: 0x00123738 File Offset: 0x00121938
		[Token(Token = "0x600368A")]
		[Address(RVA = "0x7B3400", Offset = "0x7B1A00", VA = "0x1807B3400")]
		private void Fertilze()
		{
			if (this.action != 0)
			{
			}
			GardenPlant gardenPlant = this.plant;
			int num = 0;
			if (gardenPlant != num)
			{
				this.plant.Fertized((GardenToolType)((uint)2));
			}
			global::UnityEngine.Object.Destroy(base.gameObject);
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x00123780 File Offset: 0x00121980
		[Token(Token = "0x600368B")]
		[Address(RVA = "0x7B35E0", Offset = "0x7B1BE0", VA = "0x1807B35E0")]
		private void Water()
		{
			if (this.action != 0)
			{
			}
			GardenPlant gardenPlant = this.plant;
			int num = 0;
			if (gardenPlant != num)
			{
				this.plant.Watered((GardenToolType)((uint)1));
			}
			global::UnityEngine.Object.Destroy(base.gameObject);
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x001237C8 File Offset: 0x001219C8
		[Token(Token = "0x600368C")]
		[Address(RVA = "0x7B3580", Offset = "0x7B1B80", VA = "0x1807B3580")]
		private void PlayWaterSound()
		{
			GameAPP.PlaySound(113, 0.5f, 1f);
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x001237E8 File Offset: 0x001219E8
		[Token(Token = "0x600368D")]
		[Address(RVA = "0x7B3340", Offset = "0x7B1940", VA = "0x1807B3340")]
		private void BugSpray()
		{
			if (this.action != 0)
			{
			}
			GardenPlant gardenPlant = this.plant;
			int num = 0;
			if (gardenPlant != num)
			{
				this.plant.Develop((GardenToolType)((uint)3));
			}
			global::UnityEngine.Object.Destroy(base.gameObject);
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00123830 File Offset: 0x00121A30
		[Token(Token = "0x600368E")]
		[Address(RVA = "0x7B34C0", Offset = "0x7B1AC0", VA = "0x1807B34C0")]
		private void Phonograph()
		{
			if (this.action != 0)
			{
			}
			GardenPlant gardenPlant = this.plant;
			int num = 0;
			if (gardenPlant != num)
			{
				this.plant.Develop((GardenToolType)((uint)4));
			}
			global::UnityEngine.Object.Destroy(base.gameObject);
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00123878 File Offset: 0x00121A78
		[Token(Token = "0x600368F")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public AnimTool()
		{
		}

		// Token: 0x040029F3 RID: 10739
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40029F3")]
		public GardenPlant plant;

		// Token: 0x040029F4 RID: 10740
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40029F4")]
		public Action action;
	}
}
