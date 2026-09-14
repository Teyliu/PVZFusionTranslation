using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A71 RID: 2673
	[Token(Token = "0x2000A71")]
	public class GardenPrize : MonoBehaviour, IClickable
	{
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06003719 RID: 14105 RVA: 0x001278FC File Offset: 0x00125AFC
		[Token(Token = "0x17000289")]
		public int Priority
		{
			[Token(Token = "0x6003719")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "4")]
			get
			{
				return 5;
			}
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x0012790C File Offset: 0x00125B0C
		[Token(Token = "0x600371A")]
		[Address(RVA = "0x7B9F60", Offset = "0x7B8560", VA = "0x1807B9F60")]
		private void Awake()
		{
			GameAPP.PlaySound(117, 0.5f, 1f);
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x0012792C File Offset: 0x00125B2C
		[Token(Token = "0x600371B")]
		[Address(RVA = "0x7B9FE0", Offset = "0x7B85E0", VA = "0x1807B9FE0")]
		private void Update()
		{
			float deltaTime = Time.deltaTime;
			this.existTime = deltaTime;
			if (deltaTime > 15f)
			{
				global::UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x0012795C File Offset: 0x00125B5C
		[Token(Token = "0x600371C")]
		[Address(RVA = "0x7B9CA0", Offset = "0x7B82A0", VA = "0x1807B9CA0", Slot = "6")]
		public virtual void Active()
		{
			int num = 0;
			Transform transform = base.transform;
			int num2 = 0;
			GameObject gameObject = transform.GetChild(num2).gameObject;
			int num3 = 0;
			gameObject.SetActive(num3 != 0);
			base.transform.GetChild(1).gameObject.SetActive(true);
			GameAPP.PlaySound(66, 0.5f, 1f);
			global::UnityEngine.Object.Destroy(base.GetComponent<Collider2D>());
			bool flag = GardenUI.Data.TryAddPlantData(num, num, num);
			if (!flag)
			{
				InGameText instance = InGameText.Instance;
				global::UnityEngine.Object.Destroy(base.gameObject);
			}
			InGameText instance2 = InGameText.Instance;
			global::UnityEngine.Object.Destroy(base.gameObject, 3f);
			Transform transform2 = base.transform;
			Vector3 vector;
			float z = vector.z;
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x00127A1C File Offset: 0x00125C1C
		[Token(Token = "0x600371D")]
		[Address(RVA = "0x7B9FC0", Offset = "0x7B85C0", VA = "0x1807B9FC0", Slot = "5")]
		public bool OnClick(Mouse mouse)
		{
			this.Active();
			return true;
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00127A30 File Offset: 0x00125C30
		[Token(Token = "0x600371E")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public GardenPrize()
		{
		}

		// Token: 0x04002AA0 RID: 10912
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002AA0")]
		private float existTime;
	}
}
