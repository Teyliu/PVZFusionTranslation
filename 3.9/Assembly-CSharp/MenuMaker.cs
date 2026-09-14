using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020008E7 RID: 2279
[Token(Token = "0x20008E7")]
public class MenuMaker : MonoBehaviour
{
	// Token: 0x06002E53 RID: 11859 RVA: 0x000FD15C File Offset: 0x000FB35C
	[Token(Token = "0x6002E53")]
	[Address(RVA = "0x6FD280", Offset = "0x6FB880", VA = "0x1806FD280")]
	public void SetMenu(int x, int y)
	{
		ulong num;
		do
		{
			this.CreateObjects(x, y);
			List<Image> list = this.clips;
			bool flag;
			if (flag)
			{
				Transform transform = base.transform;
				Transform transform2;
				transform2.parentInternal = transform;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002E54 RID: 11860 RVA: 0x000FD1AC File Offset: 0x000FB3AC
	[Token(Token = "0x6002E54")]
	[Address(RVA = "0x6FD440", Offset = "0x6FBA40", VA = "0x1806FD440")]
	public void SetPosition(int x, int y)
	{
		Sprite sprite = this.topLeft;
		Sprite sprite2 = this.topLeft;
		Sprite sprite3 = this.top;
		Sprite sprite4 = this.top;
		Sprite sprite5 = this.topRight;
		Sprite sprite6 = this.topRight;
		Sprite sprite7 = this.leftMid;
		Sprite sprite8 = this.leftMid;
		Sprite sprite9 = this.mid;
		Sprite sprite10 = this.mid;
		Sprite sprite11 = this.rightMid;
		Sprite sprite12 = this.rightMid;
		Sprite sprite13 = this.bottomLeft;
		Sprite sprite14 = this.bottomLeft;
		Sprite sprite15 = this.bottom;
		Sprite sprite16 = this.bottom;
		Sprite sprite17 = this.bottomRight;
		Sprite sprite18 = this.bottomRight;
		List<Image> list = this.clips;
		int num = 0;
		Image image = list[num];
		int num2 = 0;
		image.rectTransform.anchoredPosition = num2;
		int num3 = 0;
		if (x > 0)
		{
			Image image2 = this.clips[1];
			int num4 = 0;
			image2.rectTransform.anchoredPosition = num4;
			num3++;
		}
		List<Image> list2 = this.clips;
		int num5 = x + 1;
		Image image3 = list2[num5];
		int num6 = 0;
		image3.rectTransform.anchoredPosition = num6;
		int num10;
		if (y > 0)
		{
			List<Image> list3 = this.clips;
			int num7 = num6 * num3;
			num7 += 2;
			num7 += x;
			Image image4 = list3[num7];
			int num8 = 0;
			image4.rectTransform.anchoredPosition = num8;
			int num9;
			RectTransform rectTransform;
			if (x > 0)
			{
				Image image5 = this.clips[num8];
				num9 = 0;
				rectTransform = image5.rectTransform;
				rectTransform.anchoredPosition = num9;
				num3++;
			}
			List<Image> list4 = this.clips;
			RectTransform rectTransform2 = rectTransform * num3;
			num9 += rectTransform2;
			Image image6 = list4[num9];
			num10 = 0;
			image6.rectTransform.anchoredPosition = num10;
			num3++;
		}
		List<Image> list5 = this.clips;
		int num11 = num10 * y;
		num11 += 2;
		num11 += x;
		Image image7 = list5[num11];
		int num12 = 0;
		image7.rectTransform.anchoredPosition = num12;
		int num14;
		RectTransform rectTransform3;
		if (x > 0)
		{
			int num13 = num3 * y;
			num13 += 3;
			num13 += x;
			Image image8 = this.clips[num12];
			num14 = 0;
			rectTransform3 = image8.rectTransform;
			rectTransform3.anchoredPosition = num14;
			num3++;
		}
		List<Image> list6 = this.clips;
		RectTransform rectTransform4 = rectTransform3 * y;
		num14 += rectTransform4;
		Image image9 = list6[num14];
		int num15 = 0;
		image9.rectTransform.anchoredPosition = num15;
	}

	// Token: 0x06002E55 RID: 11861 RVA: 0x000FD418 File Offset: 0x000FB618
	[Token(Token = "0x6002E55")]
	[Address(RVA = "0x6FCA10", Offset = "0x6FB010", VA = "0x1806FCA10")]
	public void CreateObjects(int x, int y)
	{
		int num = 0;
		Image image = new GameObject("TopLeft").AddComponent<Image>();
		Sprite sprite = this.topLeft;
		image.sprite = sprite;
		int size = this.clips._size;
		image.m_Material = image;
		if (x > 0)
		{
			string text;
			Image image2 = new GameObject("TopMid_" + text).AddComponent<Image>();
			Sprite sprite2 = this.top;
			image2.sprite = sprite2;
			int size2 = this.clips._size;
			image2.m_Material = image2;
			num++;
		}
		Image image3 = new GameObject("TopRight").AddComponent<Image>();
		Sprite sprite3 = this.topRight;
		image3.sprite = sprite3;
		int size3 = this.clips._size;
		image3.m_Material = image3;
		if (y > 0)
		{
			string text2;
			Image image4 = new GameObject("LeftMid_" + text2).AddComponent<Image>();
			Sprite sprite4 = this.leftMid;
			image4.sprite = sprite4;
			int size4 = this.clips._size;
			image4.m_Material = image4;
			if (x > 0)
			{
				string text3;
				string text4;
				Image image5 = new GameObject("Mid_" + text3 + "_" + text4).AddComponent<Image>();
				Sprite sprite5 = this.mid;
				image5.sprite = sprite5;
				List<Image> list = this.clips;
				num++;
			}
			string text5;
			Image image6 = new GameObject("RightMid_" + text5).AddComponent<Image>();
			Sprite sprite6 = this.rightMid;
			image6.sprite = sprite6;
			List<Image> list2 = this.clips;
			num++;
		}
		Image image7 = new GameObject("BottomLeft").AddComponent<Image>();
		Sprite sprite7 = this.bottomLeft;
		image7.sprite = sprite7;
		int size5 = this.clips._size;
		image7.m_Material = image7;
		if (x > 0)
		{
			string text6;
			Image image8 = new GameObject("BottomMid_" + text6).AddComponent<Image>();
			Sprite sprite8 = this.bottom;
			image8.sprite = sprite8;
			int size6 = this.clips._size;
			image8.m_Material = image8;
			num++;
		}
		Image image9 = new GameObject("BottomRight").AddComponent<Image>();
		Sprite sprite9 = this.bottomRight;
		image9.sprite = sprite9;
		int size7 = this.clips._size;
	}

	// Token: 0x06002E56 RID: 11862 RVA: 0x000FD664 File Offset: 0x000FB864
	[Token(Token = "0x6002E56")]
	[Address(RVA = "0x6FDAA0", Offset = "0x6FC0A0", VA = "0x1806FDAA0")]
	public MenuMaker()
	{
		List<Image> list = new List();
		this.clips = list;
		base..ctor();
	}

	// Token: 0x04001C31 RID: 7217
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001C31")]
	public Sprite topLeft;

	// Token: 0x04001C32 RID: 7218
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001C32")]
	public Sprite topRight;

	// Token: 0x04001C33 RID: 7219
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001C33")]
	public Sprite top;

	// Token: 0x04001C34 RID: 7220
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001C34")]
	public Sprite leftMid;

	// Token: 0x04001C35 RID: 7221
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001C35")]
	public Sprite mid;

	// Token: 0x04001C36 RID: 7222
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001C36")]
	public Sprite rightMid;

	// Token: 0x04001C37 RID: 7223
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001C37")]
	public Sprite bottomLeft;

	// Token: 0x04001C38 RID: 7224
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001C38")]
	public Sprite bottomRight;

	// Token: 0x04001C39 RID: 7225
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001C39")]
	public Sprite bottom;

	// Token: 0x04001C3A RID: 7226
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001C3A")]
	public List<Image> clips;

	// Token: 0x04001C3B RID: 7227
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001C3B")]
	public bool set;
}
