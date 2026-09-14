using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace GameLevel.Abyss
{
	// Token: 0x02000CED RID: 3309
	[Token(Token = "0x2000CED")]
	public class AbyssLotteryAnim : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x0600453A RID: 17722 RVA: 0x0015E9C4 File Offset: 0x0015CBC4
		[Token(Token = "0x600453A")]
		[Address(RVA = "0x826DD0", Offset = "0x8253D0", VA = "0x180826DD0", Slot = "4")]
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

		// Token: 0x0600453B RID: 17723 RVA: 0x0015EA14 File Offset: 0x0015CC14
		[Token(Token = "0x600453B")]
		[Address(RVA = "0x826770", Offset = "0x824D70", VA = "0x180826770")]
		private void Awake()
		{
			Animator component = base.GetComponent<Animator>();
			this.anim = component;
			Animator animator = this.anim;
			float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
			animator.speed = num;
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x0015EA54 File Offset: 0x0015CC54
		[Token(Token = "0x600453C")]
		[Address(RVA = "0x8267F0", Offset = "0x824DF0", VA = "0x1808267F0")]
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

		// Token: 0x0600453D RID: 17725 RVA: 0x0015EAB4 File Offset: 0x0015CCB4
		[Token(Token = "0x600453D")]
		[Address(RVA = "0x820670", Offset = "0x81EC70", VA = "0x180820670")]
		public void Land()
		{
			this.land = true;
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x0015EAC8 File Offset: 0x0015CCC8
		[Token(Token = "0x600453E")]
		[Address(RVA = "0x826E80", Offset = "0x825480", VA = "0x180826E80")]
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

		// Token: 0x0600453F RID: 17727 RVA: 0x0015EB18 File Offset: 0x0015CD18
		[Token(Token = "0x600453F")]
		[Address(RVA = "0x8269A0", Offset = "0x824FA0", VA = "0x1808269A0")]
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

		// Token: 0x06004540 RID: 17728 RVA: 0x0015EBFC File Offset: 0x0015CDFC
		[Token(Token = "0x6004540")]
		[Address(RVA = "0x826E70", Offset = "0x825470", VA = "0x180826E70", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
			if (!this.opening)
			{
				CursorChange.SetClickCursor();
				return;
			}
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x0015EC1C File Offset: 0x0015CE1C
		[Token(Token = "0x6004541")]
		[Address(RVA = "0x51B300", Offset = "0x519900", VA = "0x18051B300", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
			CursorChange.SetDefaultCursor();
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x0015EC30 File Offset: 0x0015CE30
		[Token(Token = "0x6004542")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public AbyssLotteryAnim()
		{
		}

		// Token: 0x04003187 RID: 12679
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003187")]
		public Animator anim;

		// Token: 0x04003188 RID: 12680
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003188")]
		public PlantType thePlantType;

		// Token: 0x04003189 RID: 12681
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003189")]
		public TheCard cardPrefab;

		// Token: 0x0400318A RID: 12682
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400318A")]
		public Image glow;

		// Token: 0x0400318B RID: 12683
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400318B")]
		public GameObject landParticlePrefab;

		// Token: 0x0400318C RID: 12684
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400318C")]
		public GameObject dieParticlePrefab;

		// Token: 0x0400318D RID: 12685
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400318D")]
		public bool opened;

		// Token: 0x0400318E RID: 12686
		[FieldOffset(Offset = "0x51")]
		[Token(Token = "0x400318E")]
		private bool land;

		// Token: 0x0400318F RID: 12687
		[FieldOffset(Offset = "0x52")]
		[Token(Token = "0x400318F")]
		private bool opening;
	}
}
