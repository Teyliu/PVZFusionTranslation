using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020003DB RID: 987
[Token(Token = "0x20003DB")]
public class MagnetBox : Plant
{
	// Token: 0x06001227 RID: 4647 RVA: 0x000662E8 File Offset: 0x000644E8
	[Token(Token = "0x6001227")]
	[Address(RVA = "0x4013E0", Offset = "0x3FF9E0", VA = "0x1804013E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06001228 RID: 4648 RVA: 0x00066308 File Offset: 0x00064508
	[Token(Token = "0x6001228")]
	[Address(RVA = "0x44F2E0", Offset = "0x44D8E0", VA = "0x18044F2E0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		int num = this.value;
		TextMeshPro textMeshPro = this.valueText;
		string text = string.Format("磁力：{0}", num);
		textMeshPro.text = text;
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x00066344 File Offset: 0x00064544
	[Token(Token = "0x6001229")]
	[Address(RVA = "0x44F0D0", Offset = "0x44D6D0", VA = "0x18044F0D0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.InitValueText();
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x00066360 File Offset: 0x00064560
	[Token(Token = "0x600122A")]
	[Address(RVA = "0x44EAA0", Offset = "0x44D0A0", VA = "0x18044EAA0")]
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
		int num = this.value;
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

	// Token: 0x0600122B RID: 4651 RVA: 0x00066460 File Offset: 0x00064660
	[Token(Token = "0x600122B")]
	[Address(RVA = "0x44EA60", Offset = "0x44D060", VA = "0x18044EA60", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 1f;
		this.InterfaceUpdate();
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x00066484 File Offset: 0x00064684
	[Token(Token = "0x600122C")]
	[Address(RVA = "0x44F390", Offset = "0x44D990", VA = "0x18044F390", Slot = "61")]
	public override bool UseItem(BucketType type, Bucket bucket)
	{
		this.AddMagnet(type, bucket);
		return true;
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x0006649C File Offset: 0x0006469C
	[Token(Token = "0x600122D")]
	[Address(RVA = "0x44E9A0", Offset = "0x44CFA0", VA = "0x18044E9A0")]
	public void AddMagnet(BucketType bucketType, Bucket item)
	{
		int num = 0;
		if (!(item == num))
		{
			global::UnityEngine.Object.Destroy(item.gameObject);
		}
		int num2 = this.value;
		int num3;
		num3 += num2;
		this.value = num3;
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x000664DC File Offset: 0x000646DC
	[Token(Token = "0x600122E")]
	[Address(RVA = "0x44F0F0", Offset = "0x44D6F0", VA = "0x18044F0F0", Slot = "51")]
	public override void UpdateMagnetCount(int count)
	{
		ulong num;
		do
		{
			base.UpdateMagnetCount(count);
			List<MagnetInterface> list = this.interfaces;
			int size = list._size;
			list._size = (int)((ulong)0L);
			if (size > 0)
			{
			}
			List<Plant> plants = MagnetSystem.GetPlants(this);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				List<MagnetInterface> list2 = this.interfaces;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x0600122F RID: 4655 RVA: 0x00066540 File Offset: 0x00064740
	[Token(Token = "0x600122F")]
	[Address(RVA = "0x44EDD0", Offset = "0x44D3D0", VA = "0x18044EDD0")]
	private void InterfaceUpdate()
	{
		List<MagnetInterface> list;
		bool flag;
		ulong num3;
		do
		{
			int num = 0;
			list = new List();
			List<MagnetInterface> list2 = this.interfaces;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		int num4 = 0;
		int i = list._size;
		uint num5;
		if (num4 > (flag ? 1 : 0) && num5 > (uint)0)
		{
			while (i <= 0)
			{
			}
			MagnetInterface magnetInterface = list[i];
			int num6 = magnetInterface.energy;
			num6 += (flag ? 1 : 0);
			magnetInterface.energy = num6;
			int num7 = 0;
			int fullEnergy = magnetInterface.fullEnergy;
			magnetInterface.energy = fullEnergy;
			num7 -= fullEnergy;
			if (num7 == (flag ? 1 : 0))
			{
				list.RemoveAt(i);
			}
			flag = (flag ? 1 : 0) - num7 != 0;
			num4 += (flag ? 1 : 0);
		}
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x00066604 File Offset: 0x00064804
	[Token(Token = "0x6001230")]
	[Address(RVA = "0x44F3B0", Offset = "0x44D9B0", VA = "0x18044F3B0")]
	public MagnetBox()
	{
		List<MagnetInterface> list = new List();
		this.interfaces = list;
		base..ctor();
	}

	// Token: 0x04000BF6 RID: 3062
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BF6")]
	public int value;

	// Token: 0x04000BF7 RID: 3063
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000BF7")]
	private readonly int outPutCount = (int)((ulong)10000L);

	// Token: 0x04000BF8 RID: 3064
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BF8")]
	private TextMeshPro valueText;

	// Token: 0x04000BF9 RID: 3065
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BF9")]
	[SerializeField]
	private List<MagnetInterface> interfaces;
}
