using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020003DC RID: 988
[Token(Token = "0x20003DC")]
public class MagnetInterface : Plant
{
	// Token: 0x06001231 RID: 4657 RVA: 0x00066634 File Offset: 0x00064834
	[Token(Token = "0x6001231")]
	[Address(RVA = "0x44FCE0", Offset = "0x44E2E0", VA = "0x18044FCE0", Slot = "61")]
	public override bool UseItem(BucketType type, Bucket bucket)
	{
		GameObject gameObject = this.theBucket;
		int num = 0;
		if (gameObject != num)
		{
			global::UnityEngine.Object.Destroy(this.theBucket);
		}
		int num2 = 0;
		if (bucket != num2)
		{
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(bucket.gameObject);
			this.theBucket = gameObject2;
			SpriteRenderer component = this.theBucket.GetComponent<SpriteRenderer>();
			int thePlantRow = this.thePlantRow;
			string text = string.Format("plant{0}", component);
			component.sortingLayerName = text;
			SpriteRenderer component2 = this.theBucket.GetComponent<SpriteRenderer>();
			int num3 = this.baseLayer;
			num3 += 2;
			component2.sortingOrder = num3;
			Transform transform = this.theBucket.transform;
			Transform transform2 = this.theBucket.transform;
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			Transform transform3 = this.theBucket.transform;
			Transform transform4 = base.transform;
			int num4 = 0;
			Transform child = transform4.GetChild(num4);
			transform3.parentInternal = child;
			global::UnityEngine.Object.Destroy(this.theBucket.GetComponent<Bucket>());
			global::UnityEngine.Object.Destroy(this.theBucket.GetComponent<Collider2D>());
			global::UnityEngine.Object.Destroy(bucket.gameObject);
		}
		this.setType = type;
		throw new NullReferenceException();
	}

	// Token: 0x06001232 RID: 4658 RVA: 0x00066768 File Offset: 0x00064968
	[Token(Token = "0x6001232")]
	[Address(RVA = "0x44FC00", Offset = "0x44E200", VA = "0x18044FC00")]
	public int Supply(int value)
	{
		int num = this.energy;
		num += value;
		this.energy = num;
		return 0;
	}

	// Token: 0x06001233 RID: 4659 RVA: 0x000667A0 File Offset: 0x000649A0
	[Token(Token = "0x6001233")]
	[Address(RVA = "0x4309E0", Offset = "0x42EFE0", VA = "0x1804309E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x000667C0 File Offset: 0x000649C0
	[Token(Token = "0x6001234")]
	[Address(RVA = "0x44F440", Offset = "0x44DA40", VA = "0x18044F440", Slot = "40")]
	protected override void AttributeEvent()
	{
		BucketType bucketType = this.setType;
		int num = 0;
		int magnetValue = Lawnf.GetMagnetValue(bucketType);
		if (this.energy > magnetValue)
		{
			int num2 = this.thePlantColumn;
			int thePlantRow = this.thePlantRow;
			num2++;
			List<Plant> list = Lawnf.Get1x1Plants(num2, thePlantRow);
			Func<Plant, int> <>9__8_ = MagnetInterface.<>c.<>9__8_0;
			if (<>9__8_ == 0)
			{
				Func<Plant, int> func;
				MagnetInterface.<>c.<>9__8_0 = func;
			}
			List<Plant> list2 = Enumerable.ToList<Plant>(Enumerable.OrderBy<Plant, int>(list, <>9__8_));
			Func<Plant, int> func2;
			if (MagnetInterface.<>c.<>9__8_1 == 0)
			{
				MagnetInterface.<>c.<>9__8_1 = func2;
			}
			List<Plant> list3 = Enumerable.ToList<Plant>(Enumerable.OrderBy<Plant, int>(list2, func2));
			Func<Plant, int> func3;
			if (MagnetInterface.<>c.<>9__8_2 == 0)
			{
				MagnetInterface.<>c.<>9__8_2 = func3;
			}
			List<Plant> list4 = Enumerable.ToList<Plant>(Enumerable.OrderBy<Plant, int>(list3, func3));
			Func<Plant, int> func4;
			if (MagnetInterface.<>c.<>9__8_3 == 0)
			{
				MagnetInterface.<>c.<>9__8_3 = func4;
			}
			List<Plant> list5 = Enumerable.ToList<Plant>(Enumerable.OrderBy<Plant, int>(list4, func4));
			int num3 = 0;
			Plant plant = list5[num3];
			int num4 = 0;
			BucketType bucketType2 = this.setType;
			if (plant.UseItem(bucketType2, num4))
			{
			}
		}
		base.AttributeCountdown = (float)num;
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x000668BC File Offset: 0x00064ABC
	[Token(Token = "0x6001235")]
	[Address(RVA = "0x44FC30", Offset = "0x44E230", VA = "0x18044FC30", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		int num = this.energy;
		TextMeshPro textMeshPro = this.valueText;
		string text = string.Format("磁力：{0}", num);
		textMeshPro.text = text;
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x000668F8 File Offset: 0x00064AF8
	[Token(Token = "0x6001236")]
	[Address(RVA = "0x44FBE0", Offset = "0x44E1E0", VA = "0x18044FBE0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.InitValueText();
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x00066914 File Offset: 0x00064B14
	[Token(Token = "0x6001237")]
	[Address(RVA = "0x44F8B0", Offset = "0x44DEB0", VA = "0x18044F8B0")]
	private void InitValueText()
	{
		GameObject gameObject = new GameObject(base.name);
		Transform transform = gameObject.transform;
		Transform transform2 = base.transform;
		transform.parent = transform2;
		TextMeshPro textMeshPro = gameObject.AddComponent<TextMeshPro>();
		this.valueText = textMeshPro;
		TextMeshPro textMeshPro2 = this.valueText;
		TMP_FontAsset font = GameAPP.font;
		textMeshPro2.font = font;
		int num = this.energy;
		TextMeshPro textMeshPro3 = this.valueText;
		string text = string.Format("磁力：{0}", num);
		textMeshPro3.text = text;
		TextMeshPro textMeshPro4 = this.valueText;
		this.valueText.alignment = (TextAlignmentOptions)((uint)514);
		this.valueText.fontSize = 2.5f;
		this.valueText.sortingOrder = 103;
		TextMeshPro textMeshPro5 = this.valueText;
		int num2 = SortingLayer.NameToID("up1");
		textMeshPro5.sortingLayerID = num2;
		RectTransform component = this.valueText.GetComponent<RectTransform>();
		Transform transform3 = this.valueText.transform;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001238 RID: 4664 RVA: 0x00066A14 File Offset: 0x00064C14
	[Token(Token = "0x6001238")]
	[Address(RVA = "0x4500B0", Offset = "0x44E6B0", VA = "0x1804500B0")]
	public MagnetInterface()
	{
	}

	// Token: 0x04000BFA RID: 3066
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BFA")]
	public int energy;

	// Token: 0x04000BFB RID: 3067
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000BFB")]
	public readonly int fullEnergy = (int)((ulong)3000L);

	// Token: 0x04000BFC RID: 3068
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BFC")]
	private BucketType setType;

	// Token: 0x04000BFD RID: 3069
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BFD")]
	private TextMeshPro valueText;

	// Token: 0x04000BFE RID: 3070
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000BFE")]
	private GameObject theBucket;
}
