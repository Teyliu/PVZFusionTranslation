using System;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000862 RID: 2146
[Token(Token = "0x2000862")]
public class OptionBtn : UIBtn
{
	// Token: 0x06002BDD RID: 11229 RVA: 0x000F096C File Offset: 0x000EEB6C
	[Token(Token = "0x6002BDD")]
	[Address(RVA = "0x66DE70", Offset = "0x66C470", VA = "0x18066DE70", Slot = "4")]
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

	// Token: 0x06002BDE RID: 11230 RVA: 0x000F0A14 File Offset: 0x000EEC14
	[Token(Token = "0x6002BDE")]
	[Address(RVA = "0x66E060", Offset = "0x66C660", VA = "0x18066E060", Slot = "7")]
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

	// Token: 0x06002BDF RID: 11231 RVA: 0x000F0B08 File Offset: 0x000EED08
	[Token(Token = "0x6002BDF")]
	[Address(RVA = "0x66E300", Offset = "0x66C900", VA = "0x18066E300")]
	private void PassAdvantureLevel()
	{
		bool[] advLevelCompleted = GameAPP.advLevelCompleted;
		while ((ulong)((uint)1) <= (ulong)45L)
		{
		}
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x06002BE0 RID: 11232 RVA: 0x000F0B34 File Offset: 0x000EED34
	[Token(Token = "0x6002BE0")]
	[Address(RVA = "0x66E420", Offset = "0x66CA20", VA = "0x18066E420")]
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

	// Token: 0x06002BE1 RID: 11233 RVA: 0x000F0BD8 File Offset: 0x000EEDD8
	[Token(Token = "0x6002BE1")]
	[Address(RVA = "0x66E770", Offset = "0x66CD70", VA = "0x18066E770")]
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

	// Token: 0x06002BE2 RID: 11234 RVA: 0x000F0C78 File Offset: 0x000EEE78
	[Token(Token = "0x6002BE2")]
	[Address(RVA = "0x66DCA0", Offset = "0x66C2A0", VA = "0x18066DCA0")]
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

	// Token: 0x06002BE3 RID: 11235 RVA: 0x000F0D18 File Offset: 0x000EEF18
	[Token(Token = "0x6002BE3")]
	[Address(RVA = "0x66EB00", Offset = "0x66D100", VA = "0x18066EB00")]
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

	// Token: 0x06002BE4 RID: 11236 RVA: 0x000F0D94 File Offset: 0x000EEF94
	[Token(Token = "0x6002BE4")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public OptionBtn()
	{
	}

	// Token: 0x04001A08 RID: 6664
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A08")]
	public int optionType;

	// Token: 0x04001A09 RID: 6665
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4001A09")]
	private bool realReset;

	// Token: 0x04001A0A RID: 6666
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A0A")]
	private float resetTime;
}
