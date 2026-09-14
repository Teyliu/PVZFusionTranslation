using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace GameLevel.Abyss
{
	// Token: 0x02000C52 RID: 3154
	[Token(Token = "0x2000C52")]
	public class AbyssLotteryAnim : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x060041A4 RID: 16804 RVA: 0x0015896C File Offset: 0x00156B6C
		[Token(Token = "0x60041A4")]
		[Address(RVA = "0x874420", Offset = "0x872A20", VA = "0x180874420", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
			if (this.land)
			{
				Animator animator = this.anim;
				this.opening = true;
				animator.SetTrigger("open");
				CursorChange.SetDefaultCursor();
				GameAPP.PlaySound((SoundType)((uint)23), 0.5f, 1f);
				return;
			}
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x001589BC File Offset: 0x00156BBC
		[Token(Token = "0x60041A5")]
		[Address(RVA = "0x873DB0", Offset = "0x8723B0", VA = "0x180873DB0")]
		private void Awake()
		{
			Animator component = base.GetComponent<Animator>();
			this.anim = component;
			Animator animator = this.anim;
			float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
			animator.speed = num;
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x001589FC File Offset: 0x00156BFC
		[Token(Token = "0x60041A6")]
		[Address(RVA = "0x873E30", Offset = "0x872430", VA = "0x180873E30")]
		public void FirstLand()
		{
			GameAPP.PlaySound((SoundType)((uint)22), 0.5f, 1f);
			GameObject gameObject = this.landParticlePrefab;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform parent = base.transform.parent;
			GameObject gameObject2;
			gameObject2.AddComponent<SortingGroup>().sortingLayerName = "UI";
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x00158A5C File Offset: 0x00156C5C
		[Token(Token = "0x60041A7")]
		[Address(RVA = "0x873FE0", Offset = "0x8725E0", VA = "0x180873FE0")]
		public void Land()
		{
			this.land = true;
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x00158A70 File Offset: 0x00156C70
		[Token(Token = "0x60041A8")]
		[Address(RVA = "0x8744D0", Offset = "0x872AD0", VA = "0x1808744D0")]
		public void Opening()
		{
			int num = (int)this.thePlantType;
			CardLevel cardLevel;
			if (cardLevel <= CardLevel.Red)
			{
				Image image = this.glow;
				Image image2 = this.glow;
				Image image3 = this.glow;
				Image image4 = this.glow;
				Image image5 = this.glow;
				Image image6 = this.glow;
			}
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x00158AC0 File Offset: 0x00156CC0
		[Token(Token = "0x60041A9")]
		[Address(RVA = "0x873FF0", Offset = "0x8725F0", VA = "0x180873FF0")]
		public void OnOpen()
		{
			TheCard theCard = this.cardPrefab;
			this.opened = true;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			Vector3 vector2;
			float z2 = vector2.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform parent = base.transform.parent;
			PlantType plantType = this.thePlantType;
			TheCard theCard2;
			theCard2.thePlantType = plantType;
			theCard2.SetBg();
			DroppedItem droppedItem = theCard2.AddComponent<DroppedItem>();
			Transform transform2 = base.transform;
			Vector3 vector3;
			float y = vector3.y;
			droppedItem.landY = y;
			global::UnityEngine.Object.Destroy(base.gameObject);
			GameObject gameObject = this.dieParticlePrefab;
			Transform transform3 = base.transform;
			Vector3 vector4;
			float z3 = vector4.z;
			Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
			Transform parent2 = base.transform.parent;
			GameObject gameObject2;
			gameObject2.AddComponent<SortingGroup>().sortingLayerName = "UI";
			int num = (int)this.thePlantType;
			CardLevel cardLevel;
			if (cardLevel <= CardLevel.Red)
			{
			}
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x00158BA4 File Offset: 0x00156DA4
		[Token(Token = "0x60041AA")]
		[Address(RVA = "0x8744C0", Offset = "0x872AC0", VA = "0x1808744C0", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
			if (!this.opening)
			{
				CursorChange.SetClickCursor();
				return;
			}
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x00158BC4 File Offset: 0x00156DC4
		[Token(Token = "0x60041AB")]
		[Address(RVA = "0x575490", Offset = "0x573A90", VA = "0x180575490", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
			CursorChange.SetDefaultCursor();
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x00158BD8 File Offset: 0x00156DD8
		[Token(Token = "0x60041AC")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public AbyssLotteryAnim()
		{
		}

		// Token: 0x0400322C RID: 12844
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400322C")]
		public Animator anim;

		// Token: 0x0400322D RID: 12845
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400322D")]
		public PlantType thePlantType;

		// Token: 0x0400322E RID: 12846
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400322E")]
		public TheCard cardPrefab;

		// Token: 0x0400322F RID: 12847
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400322F")]
		public Image glow;

		// Token: 0x04003230 RID: 12848
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003230")]
		public GameObject landParticlePrefab;

		// Token: 0x04003231 RID: 12849
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003231")]
		public GameObject dieParticlePrefab;

		// Token: 0x04003232 RID: 12850
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003232")]
		public bool opened;

		// Token: 0x04003233 RID: 12851
		[FieldOffset(Offset = "0x51")]
		[Token(Token = "0x4003233")]
		private bool land;

		// Token: 0x04003234 RID: 12852
		[FieldOffset(Offset = "0x52")]
		[Token(Token = "0x4003234")]
		private bool opening;
	}
}
