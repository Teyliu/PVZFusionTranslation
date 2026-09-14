using System;
using Cpp2IlInjected;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x02000806 RID: 2054
[Token(Token = "0x2000806")]
public class BaseWindow : UIButton
{
	// Token: 0x060029E2 RID: 10722 RVA: 0x000E5270 File Offset: 0x000E3470
	[Token(Token = "0x60029E2")]
	[Address(RVA = "0x6344E0", Offset = "0x632AE0", VA = "0x1806344E0", Slot = "10")]
	protected virtual void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
	}

	// Token: 0x060029E3 RID: 10723 RVA: 0x000E528C File Offset: 0x000E348C
	[Token(Token = "0x60029E3")]
	[Address(RVA = "0x634530", Offset = "0x632B30", VA = "0x180634530", Slot = "11")]
	public virtual void OnAnimOver()
	{
		if (this.onAnimOver != 0)
		{
		}
	}

	// Token: 0x060029E4 RID: 10724 RVA: 0x000E52A4 File Offset: 0x000E34A4
	[Token(Token = "0x60029E4")]
	[Address(RVA = "0x6345F0", Offset = "0x632BF0", VA = "0x1806345F0")]
	public void SetDescription(string text)
	{
		TextMeshProUGUI textMeshProUGUI = this.introduce;
		throw new NullReferenceException();
	}

	// Token: 0x060029E5 RID: 10725 RVA: 0x000E52C0 File Offset: 0x000E34C0
	[Token(Token = "0x60029E5")]
	[Address(RVA = "0x634550", Offset = "0x632B50", VA = "0x180634550")]
	public GameObject ResetPlant(PlantType thePlantType)
	{
		GameObject gameObject = this.show;
		int num = 0;
		if (gameObject != num)
		{
			global::UnityEngine.Object.Destroy(this.show);
		}
		GameObject gameObject2;
		return gameObject2;
	}

	// Token: 0x060029E6 RID: 10726 RVA: 0x000E52F0 File Offset: 0x000E34F0
	[Token(Token = "0x60029E6")]
	[Address(RVA = "0x634730", Offset = "0x632D30", VA = "0x180634730")]
	public GameObject SetPlant(PlantType thePlantType)
	{
		GameObject gameObject;
		bool flag;
		do
		{
			Transform transform = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num = 0;
			if (gameObject == num)
			{
				Transform transform2 = this.axis;
				Vector3 vector2;
				float z2 = vector2.z;
			}
			Transform transform3 = gameObject.transform;
			Transform transform4 = base.transform;
			transform3.parentInternal = transform4;
			this.show = gameObject;
		}
		while (flag);
		gameObject.AddComponent<SortingGroup>().sortingLayerName = "UI";
		bool flag2;
		if (flag2)
		{
			Transform transform5 = gameObject.transform;
			Vector3 vector3;
			float z3 = vector3.z;
		}
		return gameObject;
	}

	// Token: 0x060029E7 RID: 10727 RVA: 0x000E5388 File Offset: 0x000E3588
	[Token(Token = "0x60029E7")]
	[Address(RVA = "0x6349D0", Offset = "0x632FD0", VA = "0x1806349D0")]
	public void SetZombie(ZombieType theZombieType, float scale = 1f)
	{
		GameObject gameObject2;
		bool flag;
		do
		{
			GameObject gameObject = this.show;
			int num = 0;
			if (gameObject != num)
			{
				global::UnityEngine.Object.Destroy(this.show);
			}
			Transform transform = this.axis;
			Vector3 vector;
			float z = vector.z;
			Transform transform2 = gameObject2.transform;
			Transform transform3 = base.transform;
			transform2.parentInternal = transform3;
			Transform transform4 = gameObject2.transform;
			Vector3 vector2;
			float z2 = vector2.z;
		}
		while (flag);
		gameObject2.AddComponent<SortingGroup>().sortingLayerName = "UI";
		this.show = gameObject2;
	}

	// Token: 0x060029E8 RID: 10728 RVA: 0x000E5414 File Offset: 0x000E3614
	[Token(Token = "0x60029E8")]
	[Address(RVA = "0x634620", Offset = "0x632C20", VA = "0x180634620")]
	public void SetImage(Quality frameType)
	{
		Image image = this.frameImage;
		int num = 0;
		if (!(image == num))
		{
			if (frameType == Quality.Default)
			{
			}
			string text2;
			string text = "UI/Img_Almanac/Frame_" + text2;
			Image image2 = this.frameImage;
			Sprite sprite = Resources.Load<Sprite>(text);
			image2.sprite = sprite;
		}
	}

	// Token: 0x060029E9 RID: 10729 RVA: 0x000E546C File Offset: 0x000E366C
	[Token(Token = "0x60029E9")]
	[Address(RVA = "0x51C260", Offset = "0x51A860", VA = "0x18051C260")]
	public BaseWindow()
	{
	}

	// Token: 0x04001825 RID: 6181
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001825")]
	public Transform axis;

	// Token: 0x04001826 RID: 6182
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001826")]
	public TextMeshProUGUI title;

	// Token: 0x04001827 RID: 6183
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001827")]
	public TextMeshProUGUI introduce;

	// Token: 0x04001828 RID: 6184
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001828")]
	public GameObject show;

	// Token: 0x04001829 RID: 6185
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001829")]
	public Action onAnimOver;

	// Token: 0x0400182A RID: 6186
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400182A")]
	protected Animator anim;

	// Token: 0x0400182B RID: 6187
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400182B")]
	public Image frameImage;
}
