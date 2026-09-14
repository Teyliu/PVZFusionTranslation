using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A31 RID: 2609
	[Token(Token = "0x2000A31")]
	public class GardenPrize : MonoBehaviour, IClickable
	{
		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x00122684 File Offset: 0x00120884
		[Token(Token = "0x17000241")]
		public int Priority
		{
			[Token(Token = "0x60035D5")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "4")]
			get
			{
				return 5;
			}
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x00122694 File Offset: 0x00120894
		[Token(Token = "0x60035D6")]
		[Address(RVA = "0x7533C0", Offset = "0x7519C0", VA = "0x1807533C0")]
		private void Awake()
		{
			GameAPP.PlaySound(117, 0.5f, 1f);
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x001226B4 File Offset: 0x001208B4
		[Token(Token = "0x60035D7")]
		[Address(RVA = "0x753440", Offset = "0x751A40", VA = "0x180753440")]
		private void Update()
		{
			float deltaTime = Time.deltaTime;
			this.existTime = deltaTime;
			if (deltaTime > 15f)
			{
				global::UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x001226E4 File Offset: 0x001208E4
		[Token(Token = "0x60035D8")]
		[Address(RVA = "0x753110", Offset = "0x751710", VA = "0x180753110", Slot = "6")]
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
				int num4 = 0;
				instance.ShowText("花园放不下更多的植物了", 7f, num4 != 0);
				global::UnityEngine.Object.Destroy(base.gameObject);
			}
			InGameText instance2 = InGameText.Instance;
			int num5 = 0;
			instance2.ShowText("你为你的花园找到了一株植物", 7f, num5 != 0);
			global::UnityEngine.Object.Destroy(base.gameObject, 3f);
			Transform transform2 = base.transform;
			Vector3 vector;
			float z = vector.z;
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x001227D0 File Offset: 0x001209D0
		[Token(Token = "0x60035D9")]
		[Address(RVA = "0x753420", Offset = "0x751A20", VA = "0x180753420", Slot = "5")]
		public bool OnClick(Mouse mouse)
		{
			this.Active();
			return true;
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x001227E4 File Offset: 0x001209E4
		[Token(Token = "0x60035DA")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public GardenPrize()
		{
		}

		// Token: 0x0400292D RID: 10541
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400292D")]
		private float existTime;
	}
}
