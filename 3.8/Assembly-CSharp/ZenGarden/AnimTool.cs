using System;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A19 RID: 2585
	[Token(Token = "0x2000A19")]
	public class AnimTool : MonoBehaviour
	{
		// Token: 0x06003549 RID: 13641 RVA: 0x0011E61C File Offset: 0x0011C81C
		[Token(Token = "0x6003549")]
		[Address(RVA = "0x74CA40", Offset = "0x74B040", VA = "0x18074CA40")]
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

		// Token: 0x0600354A RID: 13642 RVA: 0x0011E664 File Offset: 0x0011C864
		[Token(Token = "0x600354A")]
		[Address(RVA = "0x74CC20", Offset = "0x74B220", VA = "0x18074CC20")]
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

		// Token: 0x0600354B RID: 13643 RVA: 0x0011E6AC File Offset: 0x0011C8AC
		[Token(Token = "0x600354B")]
		[Address(RVA = "0x74CBC0", Offset = "0x74B1C0", VA = "0x18074CBC0")]
		private void PlayWaterSound()
		{
			GameAPP.PlaySound(113, 0.5f, 1f);
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x0011E6CC File Offset: 0x0011C8CC
		[Token(Token = "0x600354C")]
		[Address(RVA = "0x74C980", Offset = "0x74AF80", VA = "0x18074C980")]
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

		// Token: 0x0600354D RID: 13645 RVA: 0x0011E714 File Offset: 0x0011C914
		[Token(Token = "0x600354D")]
		[Address(RVA = "0x74CB00", Offset = "0x74B100", VA = "0x18074CB00")]
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

		// Token: 0x0600354E RID: 13646 RVA: 0x0011E75C File Offset: 0x0011C95C
		[Token(Token = "0x600354E")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public AnimTool()
		{
		}

		// Token: 0x04002882 RID: 10370
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002882")]
		public GardenPlant plant;

		// Token: 0x04002883 RID: 10371
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002883")]
		public Action action;
	}
}
