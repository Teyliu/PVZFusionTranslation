using System;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace OpenBLive.Runtime
{
	// Token: 0x02000E31 RID: 3633
	[Token(Token = "0x2000E31")]
	public class OpenBLiveMenu : BaseMenu
	{
		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06004AF5 RID: 19189 RVA: 0x00171240 File Offset: 0x0016F440
		[Token(Token = "0x1700096C")]
		private static BLiveConfig LiveConfig
		{
			[Token(Token = "0x6004AF5")]
			[Address(RVA = "0x8CE5B0", Offset = "0x8CCBB0", VA = "0x1808CE5B0")]
			get
			{
				return GameAPP.config.liveConfig;
			}
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x00171260 File Offset: 0x0016F460
		[Token(Token = "0x6004AF6")]
		[Address(RVA = "0x8CDC00", Offset = "0x8CC200", VA = "0x1808CDC00", Slot = "6")]
		protected override void Awake()
		{
			base.Awake();
			this.ReadData();
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x0017127C File Offset: 0x0016F47C
		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0x8CDCE0", Offset = "0x8CC2E0", VA = "0x1808CDCE0")]
		public void Connect()
		{
			ConnectViaCode.Instance.Connect();
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x0017129C File Offset: 0x0016F49C
		[Token(Token = "0x6004AF8")]
		[Address(RVA = "0x8CDD40", Offset = "0x8CC340", VA = "0x1808CDD40")]
		public void EndGame()
		{
			ConnectViaCode instance = ConnectViaCode.Instance;
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x001712B8 File Offset: 0x0016F4B8
		[Token(Token = "0x6004AF9")]
		[Address(RVA = "0x8CDDD0", Offset = "0x8CC3D0", VA = "0x1808CDDD0")]
		public void OpenDam()
		{
			DamMenu instance = DamMenu.Instance;
			int num = 0;
			if (instance == num)
			{
				GameObject gameObject = Resources.Load<GameObject>("UI/Prefabs/DamMenu");
				Transform canvasUp = GameAPP.canvasUp;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, canvasUp);
			}
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x001712F4 File Offset: 0x0016F4F4
		[Token(Token = "0x6004AFA")]
		[Address(RVA = "0x8CDC20", Offset = "0x8CC220", VA = "0x1808CDC20")]
		public void CloseDam()
		{
			DamMenu instance = DamMenu.Instance;
			int num = 0;
			if (instance != num)
			{
				global::UnityEngine.Object.Destroy(DamMenu.Instance.gameObject);
				return;
			}
		}

		// Token: 0x06004AFB RID: 19195 RVA: 0x0017132C File Offset: 0x0016F52C
		[Token(Token = "0x6004AFB")]
		[Address(RVA = "0x8CDEE0", Offset = "0x8CC4E0", VA = "0x1808CDEE0")]
		private void ReadData()
		{
			ulong num;
			Toggle[] componentsInChildren = this.ToggleGroup.GetComponentsInChildren<Toggle>(num != 0UL);
			int num2 = 0;
			if (num2 < componentsInChildren.Length)
			{
				SpawnMode spawnMode = GameAPP.config.liveConfig.spawnMode;
				string text;
				string text2;
				if (!string.Equals(text, text2))
				{
					num2++;
				}
			}
			TMP_InputField tmp_InputField = this.maxZombieCountText;
			BLiveConfig liveConfig = OpenBLiveMenu.LiveConfig;
			string text3;
			tmp_InputField.text = text3;
			TMP_InputField tmp_InputField2 = this.likeNeedPerSpawnText;
			BLiveConfig liveConfig2 = OpenBLiveMenu.LiveConfig;
			string text4;
			tmp_InputField2.text = text4;
			TMP_InputField tmp_InputField3 = this.damMaxPerSpawnText;
			BLiveConfig liveConfig3 = OpenBLiveMenu.LiveConfig;
			string text5;
			tmp_InputField3.text = text5;
			TMP_InputField tmp_InputField4 = this.baseBulletDamageText;
			BLiveConfig liveConfig4 = OpenBLiveMenu.LiveConfig;
			string text6;
			tmp_InputField4.text = text6;
			Toggle toggle = this.scMode;
			bool flag = OpenBLiveMenu.LiveConfig.scMode;
			toggle.isOn = flag;
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x00171404 File Offset: 0x0016F604
		[Token(Token = "0x6004AFC")]
		[Address(RVA = "0x8CDDB0", Offset = "0x8CC3B0", VA = "0x1808CDDB0", Slot = "8")]
		public override void OnExit()
		{
			base.OnExit();
			this.SaveConfig();
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x00171420 File Offset: 0x0016F620
		[Token(Token = "0x6004AFD")]
		[Address(RVA = "0x8CE160", Offset = "0x8CC760", VA = "0x1808CE160")]
		private void SaveConfig()
		{
			ToggleGroup toggleGroup = this.ToggleGroup;
			int num = 0;
			Toggle toggle = Enumerable.FirstOrDefault<Toggle>(toggleGroup.ActiveToggles());
			Type typeFromHandle = typeof(SpawnMode);
			string name = toggle.name;
			if (Enum.TryParse(typeFromHandle, name, num))
			{
				BLiveConfig liveConfig = OpenBLiveMenu.LiveConfig;
				int num2 = num;
				liveConfig.spawnMode = (SpawnMode)num2;
			}
			if (!int.TryParse(this.maxZombieCountText.m_Text, num))
			{
			}
			ulong num3;
			GameAPP.config.liveConfig.maxZombieCount = (int)num3;
			if (!int.TryParse(this.likeNeedPerSpawnText.m_Text, num))
			{
			}
			ulong num4;
			GameAPP.config.liveConfig.likePerSpawn = (int)num4;
			if (!int.TryParse(this.damMaxPerSpawnText.m_Text, num))
			{
			}
			ulong num5;
			GameAPP.config.liveConfig.damMaxPerSpawn = (int)num5;
			if (!int.TryParse(this.baseBulletDamageText.m_Text, num))
			{
			}
			ulong num6;
			GameAPP.config.liveConfig.baseBulletDamage = (int)num6;
			GameConfig config = GameAPP.config;
			Toggle toggle2 = this.scMode;
			BLiveConfig liveConfig2 = config.liveConfig;
			bool isOn = toggle2.m_IsOn;
			liveConfig2.scMode = isOn;
			SaveInfo.Instance.SavePlayerData();
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x00171548 File Offset: 0x0016F748
		[Token(Token = "0x6004AFE")]
		[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
		public OpenBLiveMenu()
		{
		}

		// Token: 0x0400351D RID: 13597
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400351D")]
		public ToggleGroup ToggleGroup;

		// Token: 0x0400351E RID: 13598
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400351E")]
		public Toggle scMode;

		// Token: 0x0400351F RID: 13599
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400351F")]
		public TMP_InputField maxZombieCountText;

		// Token: 0x04003520 RID: 13600
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003520")]
		public TMP_InputField likeNeedPerSpawnText;

		// Token: 0x04003521 RID: 13601
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003521")]
		public TMP_InputField damMaxPerSpawnText;

		// Token: 0x04003522 RID: 13602
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003522")]
		public TMP_InputField baseBulletDamageText;
	}
}
