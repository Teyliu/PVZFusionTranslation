using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020003F2 RID: 1010
[Token(Token = "0x20003F2")]
public class MagnetInterface : Plant
{
	// Token: 0x06001294 RID: 4756 RVA: 0x00067EF4 File Offset: 0x000660F4
	[Token(Token = "0x6001294")]
	[Address(RVA = "0x4A44B0", Offset = "0x4A2AB0", VA = "0x1804A44B0", Slot = "60")]
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

	// Token: 0x06001295 RID: 4757 RVA: 0x00068028 File Offset: 0x00066228
	[Token(Token = "0x6001295")]
	[Address(RVA = "0x4A43D0", Offset = "0x4A29D0", VA = "0x1804A43D0")]
	public int Supply(int value)
	{
		int num = this.energy;
		num += value;
		this.energy = num;
		return 0;
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x00068060 File Offset: 0x00066260
	[Token(Token = "0x6001296")]
	[Address(RVA = "0x4812D0", Offset = "0x47F8D0", VA = "0x1804812D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x00068080 File Offset: 0x00066280
	[Token(Token = "0x6001297")]
	[Address(RVA = "0x4A3C10", Offset = "0x4A2210", VA = "0x1804A3C10", Slot = "39")]
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

	// Token: 0x06001298 RID: 4760 RVA: 0x0006817C File Offset: 0x0006637C
	[Token(Token = "0x6001298")]
	[Address(RVA = "0x4A4400", Offset = "0x4A2A00", VA = "0x1804A4400", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		int num = this.energy;
		TextMeshPro textMeshPro = this.valueText;
		string text = string.Format("磁力：{0}", num);
		textMeshPro.text = text;
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x000681B8 File Offset: 0x000663B8
	[Token(Token = "0x6001299")]
	[Address(RVA = "0x4A43B0", Offset = "0x4A29B0", VA = "0x1804A43B0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.InitValueText();
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x000681D4 File Offset: 0x000663D4
	[Token(Token = "0x600129A")]
	[Address(RVA = "0x4A4080", Offset = "0x4A2680", VA = "0x1804A4080")]
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

	// Token: 0x0600129B RID: 4763 RVA: 0x000682D4 File Offset: 0x000664D4
	[Token(Token = "0x600129B")]
	[Address(RVA = "0x4A4880", Offset = "0x4A2E80", VA = "0x1804A4880")]
	public MagnetInterface()
	{
	}

	// Token: 0x04000C66 RID: 3174
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C66")]
	public int energy;

	// Token: 0x04000C67 RID: 3175
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000C67")]
	public readonly int fullEnergy = (int)((ulong)3000L);

	// Token: 0x04000C68 RID: 3176
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C68")]
	private BucketType setType;

	// Token: 0x04000C69 RID: 3177
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C69")]
	private TextMeshPro valueText;

	// Token: 0x04000C6A RID: 3178
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C6A")]
	private GameObject theBucket;
}
