using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000783 RID: 1923
[Token(Token = "0x2000783")]
public class GameSpeedMgr : MonoBehaviour
{
	// Token: 0x06002710 RID: 10000 RVA: 0x000CE110 File Offset: 0x000CC310
	[Token(Token = "0x6002710")]
	[Address(RVA = "0x62A560", Offset = "0x628B60", VA = "0x18062A560")]
	private void Start()
	{
		Slider component = base.GetComponent<Slider>();
		this.slider = component;
		Slider slider = this.slider;
		int num = 0;
		slider.minValue = (float)num;
		Slider slider2 = this.slider;
		List<float> gears = GameSpeedMgr.Gears;
		slider2.maxValue = (float)num;
		this.slider.wholeNumbers = true;
		Slider slider3 = this.slider;
		float gameSpeed = GameAPP.config.gameSpeed;
		List<float> gears2 = GameSpeedMgr.Gears;
		int num2 = 0;
		float num3 = gears2[num2];
		List<float> gears3 = GameSpeedMgr.Gears;
		float num4 = GameSpeedMgr.Gears[1];
		if (gameSpeed > gameSpeed)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002711 RID: 10001 RVA: 0x000CE1A8 File Offset: 0x000CC3A8
	[Token(Token = "0x6002711")]
	[Address(RVA = "0x62A820", Offset = "0x628E20", VA = "0x18062A820")]
	private void Update()
	{
		GameConfig config = GameAPP.config;
		Slider slider = this.slider;
		List<float> gears = GameSpeedMgr.Gears;
		float value = slider.value;
		float num = gears[0];
		config.gameSpeed = num;
		TextMeshProUGUI textMeshProUGUI = this.tmp;
		int num2 = 0;
		if (textMeshProUGUI != num2)
		{
			TextMeshProUGUI textMeshProUGUI2 = this.tmp;
			float gameSpeed = GameAPP.config.gameSpeed;
			string text;
			textMeshProUGUI2.text = text;
		}
	}

	// Token: 0x06002712 RID: 10002 RVA: 0x000CE21C File Offset: 0x000CC41C
	[Token(Token = "0x6002712")]
	[Address(RVA = "0x62A3F0", Offset = "0x6289F0", VA = "0x18062A3F0")]
	private int GetGearIndex(float speed)
	{
		int num = 0;
		List<float> gears = GameSpeedMgr.Gears;
		int num2 = 0;
		float num3 = gears[num2];
		List<float> gears2 = GameSpeedMgr.Gears;
		float num4 = GameSpeedMgr.Gears[1];
		if (speed > speed)
		{
		}
		return num;
	}

	// Token: 0x06002713 RID: 10003 RVA: 0x000CE25C File Offset: 0x000CC45C
	[Token(Token = "0x6002713")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public GameSpeedMgr()
	{
	}

	// Token: 0x06002714 RID: 10004 RVA: 0x000CE270 File Offset: 0x000CC470
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6002714")]
	[Address(RVA = "0x62AA00", Offset = "0x629000", VA = "0x18062AA00")]
	static GameSpeedMgr()
	{
		List<float> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		GameSpeedMgr.Gears = list;
		throw new NullReferenceException();
	}

	// Token: 0x0400145E RID: 5214
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400145E")]
	private Slider slider;

	// Token: 0x0400145F RID: 5215
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400145F")]
	public TextMeshProUGUI tmp;

	// Token: 0x04001460 RID: 5216
	[Token(Token = "0x4001460")]
	public static List<float> Gears;
}
