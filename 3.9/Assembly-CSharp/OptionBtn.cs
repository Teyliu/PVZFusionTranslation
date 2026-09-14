using System;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200089E RID: 2206
[Token(Token = "0x200089E")]
public class OptionBtn : UIBtn
{
	// Token: 0x06002D0F RID: 11535 RVA: 0x000F55FC File Offset: 0x000F37FC
	[Token(Token = "0x6002D0F")]
	[Address(RVA = "0x6D29B0", Offset = "0x6D0FB0", VA = "0x1806D29B0", Slot = "4")]
	protected override void Awake()
	{
		base.Awake();
		int num = this.optionType;
		if (num == 4)
		{
			Transform transform = base.transform;
			int num2 = 0;
			TextMeshProUGUI component = transform.GetChild(num2).GetComponent<TextMeshProUGUI>();
			Camera main = Camera.main;
			float orthographicSize = main.orthographicSize;
			string text = string.Format("当前大小：{0}", main);
			component.text = text;
			return;
		}
		if (num == 5)
		{
			float canvasMatch = GameAPP.config.canvasMatch;
			Transform transform2 = base.transform;
			int num3 = 0;
			TextMeshProUGUI component2 = transform2.GetChild(num3).GetComponent<TextMeshProUGUI>();
			string text2 = string.Format("UI高度匹配：{0}", component2);
			component2.text = text2;
		}
	}

	// Token: 0x06002D10 RID: 11536 RVA: 0x000F56A4 File Offset: 0x000F38A4
	[Token(Token = "0x6002D10")]
	[Address(RVA = "0x6D2BA0", Offset = "0x6D11A0", VA = "0x1806D2BA0", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		int num = this.optionType;
		if (num != 0)
		{
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_00D4;
						}
						this.AdjustCameraSize();
					}
					int num2 = 0;
					if ((this.realReset ? 1 : 0) == num2)
					{
						goto IL_0058;
					}
					this.ResetAllLevel();
				}
				int num3 = 0;
				if ((this.realReset ? 1 : 0) == num3)
				{
					goto IL_0058;
				}
				this.PassAllLevel();
			}
			if (this.realReset)
			{
				goto IL_0088;
			}
			IL_0058:
			this.realReset = true;
			this.resetTime = 2f;
			Transform transform = base.transform;
			int num4 = 0;
			ulong num5;
			transform.GetChild(num4).gameObject.SetActive(num5 != 0UL);
			IL_0088:
			bool[] advLevelCompleted = GameAPP.advLevelCompleted;
			uint num6;
			num6 += (uint)1;
			num6 += (uint)1;
			while (num6 <= (uint)45)
			{
			}
			SaveInfo.Instance.SavePlayerData();
		}
		bool flag = "{il2cpp field on {'constant40' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xB9}" == (ulong)0L;
		uint num7;
		uint num8;
		Screen.SetResolution((int)num7, (int)num8, flag);
		GameAPP.isFullScreen = "{il2cpp field on {'constant47' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xB9}" == (ulong)0L;
		IL_00D4:
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002D11 RID: 11537 RVA: 0x000F5798 File Offset: 0x000F3998
	[Token(Token = "0x6002D11")]
	[Address(RVA = "0x6D2E40", Offset = "0x6D1440", VA = "0x1806D2E40")]
	private void PassAdvantureLevel()
	{
		bool[] advLevelCompleted = GameAPP.advLevelCompleted;
		while ((ulong)((uint)1) <= (ulong)45L)
		{
		}
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002D12 RID: 11538 RVA: 0x000F57C4 File Offset: 0x000F39C4
	[Token(Token = "0x6002D12")]
	[Address(RVA = "0x6D2F60", Offset = "0x6D1560", VA = "0x1806D2F60")]
	private void PassAllLevel()
	{
		bool[] advLevelCompleted = GameAPP.advLevelCompleted;
		uint num;
		num += (uint)1;
		num += (uint)1;
		while (num <= (uint)45)
		{
		}
		ChallengeLevel[] enumValues = global::Core.Lawnf.GetEnumValues<ChallengeLevel>();
		int num2 = 0;
		if (num2 < enumValues.Length)
		{
			bool[] clgLevelCompleted = GameAPP.clgLevelCompleted;
			num2++;
		}
		bool[] gameLevelCompleted = GameAPP.gameLevelCompleted;
		uint num3;
		num3 += (uint)1;
		num3 += (uint)1;
		while (num3 <= (uint)26)
		{
		}
		bool[] survivalLevelCompleted = GameAPP.survivalLevelCompleted;
		uint num4;
		num4 += (uint)1;
		num4 += (uint)1;
		while (num4 <= (uint)38)
		{
		}
		uint num5;
		bool flag = GameAPP.exploreLevelCompleted.Add(num5);
		num5 += (uint)1;
		while (num5 <= (uint)12)
		{
		}
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002D13 RID: 11539 RVA: 0x000F5868 File Offset: 0x000F3A68
	[Token(Token = "0x6002D13")]
	[Address(RVA = "0x6D32B0", Offset = "0x6D18B0", VA = "0x1806D32B0")]
	private void ResetAllLevel()
	{
		bool[] advLevelCompleted = GameAPP.advLevelCompleted;
		if ((uint)1 < (uint)advLevelCompleted.Length)
		{
			bool[] advLevelCompleted2 = GameAPP.advLevelCompleted;
		}
		bool[] clgLevelCompleted = GameAPP.clgLevelCompleted;
		if ((uint)1 < (uint)clgLevelCompleted.Length)
		{
			bool[] clgLevelCompleted2 = GameAPP.clgLevelCompleted;
		}
		bool[] gameLevelCompleted = GameAPP.gameLevelCompleted;
		if ((uint)1 < (uint)gameLevelCompleted.Length)
		{
			bool[] gameLevelCompleted2 = GameAPP.gameLevelCompleted;
		}
		bool[] survivalLevelCompleted = GameAPP.survivalLevelCompleted;
		if ((uint)1 < (uint)survivalLevelCompleted.Length)
		{
			bool[] survivalLevelCompleted2 = GameAPP.survivalLevelCompleted;
		}
		GameAPP.exploreLevelCompleted.Clear();
		GameAPP.config.travelLevelCompleted_runTime.Clear();
		GameAPP.skinLevelCompleted.Clear();
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002D14 RID: 11540 RVA: 0x000F5908 File Offset: 0x000F3B08
	[Token(Token = "0x6002D14")]
	[Address(RVA = "0x6D27E0", Offset = "0x6D0DE0", VA = "0x1806D27E0")]
	private void AdjustCameraSize()
	{
		Camera main = Camera.main;
		float orthographicSize = main.orthographicSize;
		Camera main2;
		if (main == 0)
		{
			main2 = Camera.main;
			main2.orthographicSize = 6f;
		}
		if (main2 == 0)
		{
			Camera.main.orthographicSize = 7f;
		}
		Camera.main.orthographicSize = 5f;
		GameConfig config = GameAPP.config;
		float orthographicSize2 = Camera.main.orthographicSize;
		config.cameraSize = orthographicSize2;
		Transform transform = base.transform;
		int num = 0;
		TextMeshProUGUI component = transform.GetChild(num).GetComponent<TextMeshProUGUI>();
		throw new NullReferenceException();
	}

	// Token: 0x06002D15 RID: 11541 RVA: 0x000F59A8 File Offset: 0x000F3BA8
	[Token(Token = "0x6002D15")]
	[Address(RVA = "0x6D3640", Offset = "0x6D1C40", VA = "0x1806D3640")]
	private void Update()
	{
		if (this.optionType <= 2)
		{
			if (this.realReset)
			{
				float num = this.resetTime;
				float deltaTime = Time.deltaTime;
				this.resetTime = num;
			}
			if (0 > (int)this.resetTime)
			{
				this.realReset = false;
				this.resetTime = 2f;
				Transform transform = base.transform;
				int num2 = 0;
				GameObject gameObject = transform.GetChild(num2).gameObject;
				int num3 = 0;
				gameObject.SetActive(num3 != 0);
				return;
			}
		}
	}

	// Token: 0x06002D16 RID: 11542 RVA: 0x000F5A24 File Offset: 0x000F3C24
	[Token(Token = "0x6002D16")]
	[Address(RVA = "0x5EDFC0", Offset = "0x5EC5C0", VA = "0x1805EDFC0")]
	public OptionBtn()
	{
	}

	// Token: 0x04001AF6 RID: 6902
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001AF6")]
	public int optionType;

	// Token: 0x04001AF7 RID: 6903
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4001AF7")]
	private bool realReset;

	// Token: 0x04001AF8 RID: 6904
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001AF8")]
	private float resetTime;
}
