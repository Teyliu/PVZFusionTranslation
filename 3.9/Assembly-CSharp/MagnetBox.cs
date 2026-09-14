using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020003F1 RID: 1009
[Token(Token = "0x20003F1")]
public class MagnetBox : Plant
{
	// Token: 0x0600128A RID: 4746 RVA: 0x00067BA8 File Offset: 0x00065DA8
	[Token(Token = "0x600128A")]
	[Address(RVA = "0x4454A0", Offset = "0x443AA0", VA = "0x1804454A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x00067BC8 File Offset: 0x00065DC8
	[Token(Token = "0x600128B")]
	[Address(RVA = "0x4A3AB0", Offset = "0x4A20B0", VA = "0x1804A3AB0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		int num = this.value;
		TextMeshPro textMeshPro = this.valueText;
		string text = string.Format("磁力：{0}", num);
		textMeshPro.text = text;
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x00067C04 File Offset: 0x00065E04
	[Token(Token = "0x600128C")]
	[Address(RVA = "0x4A38A0", Offset = "0x4A1EA0", VA = "0x1804A38A0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.InitValueText();
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x00067C20 File Offset: 0x00065E20
	[Token(Token = "0x600128D")]
	[Address(RVA = "0x4A3270", Offset = "0x4A1870", VA = "0x1804A3270")]
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

	// Token: 0x0600128E RID: 4750 RVA: 0x00067D20 File Offset: 0x00065F20
	[Token(Token = "0x600128E")]
	[Address(RVA = "0x4A3230", Offset = "0x4A1830", VA = "0x1804A3230", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 1f;
		this.InterfaceUpdate();
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x00067D44 File Offset: 0x00065F44
	[Token(Token = "0x600128F")]
	[Address(RVA = "0x4A3B60", Offset = "0x4A2160", VA = "0x1804A3B60", Slot = "60")]
	public override bool UseItem(BucketType type, Bucket bucket)
	{
		this.AddMagnet(type, bucket);
		return true;
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x00067D5C File Offset: 0x00065F5C
	[Token(Token = "0x6001290")]
	[Address(RVA = "0x4A3170", Offset = "0x4A1770", VA = "0x1804A3170")]
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

	// Token: 0x06001291 RID: 4753 RVA: 0x00067D9C File Offset: 0x00065F9C
	[Token(Token = "0x6001291")]
	[Address(RVA = "0x4A38C0", Offset = "0x4A1EC0", VA = "0x1804A38C0", Slot = "50")]
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

	// Token: 0x06001292 RID: 4754 RVA: 0x00067E00 File Offset: 0x00066000
	[Token(Token = "0x6001292")]
	[Address(RVA = "0x4A35A0", Offset = "0x4A1BA0", VA = "0x1804A35A0")]
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

	// Token: 0x06001293 RID: 4755 RVA: 0x00067EC4 File Offset: 0x000660C4
	[Token(Token = "0x6001293")]
	[Address(RVA = "0x4A3B80", Offset = "0x4A2180", VA = "0x1804A3B80")]
	public MagnetBox()
	{
		List<MagnetInterface> list = new List();
		this.interfaces = list;
		base..ctor();
	}

	// Token: 0x04000C62 RID: 3170
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C62")]
	public int value;

	// Token: 0x04000C63 RID: 3171
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000C63")]
	private readonly int outPutCount = (int)((ulong)10000L);

	// Token: 0x04000C64 RID: 3172
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C64")]
	private TextMeshPro valueText;

	// Token: 0x04000C65 RID: 3173
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C65")]
	[SerializeField]
	private List<MagnetInterface> interfaces;
}
