using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000746 RID: 1862
[Token(Token = "0x2000746")]
public class GameAPP : MonoBehaviour
{
	// Token: 0x060025DA RID: 9690 RVA: 0x000C76FC File Offset: 0x000C58FC
	[Token(Token = "0x60025DA")]
	[Address(RVA = "0x5C2050", Offset = "0x5C0650", VA = "0x1805C2050")]
	private void Awake()
	{
		EventSystem.current.m_DragThreshold = (int)((ulong)1L);
		GameAPP.Instance = this;
		Thread currentThread = Thread.CurrentThread;
		CultureInfo cultureInfo = new CultureInfo("en");
		currentThread.CurrentCulture = cultureInfo;
		Thread currentThread2 = Thread.CurrentThread;
		CultureInfo cultureInfo2 = new CultureInfo("en");
		currentThread2.CurrentUICulture = cultureInfo2;
		GameAPP.resourcesManager = new ResourcesManager();
		GameAPP.config = new GameConfig();
		SaveInfo saveInfo = this.AddComponent<SaveInfo>();
		ErrorHandler errorHandler = this.AddComponent<ErrorHandler>();
		GameAPP.delayAction = this.AddComponent<DelayAction>();
		GameAPP.music = base.GetComponent<AudioSource>();
		GameAPP.musicDrum = Camera.main.GetComponent<AudioSource>();
		GameAPP.prelude = GameObject.Find("Prelude").GetComponent<PreludeMusic>();
		this.LoadResources();
		GameAPP.canvas = GameObject.Find("Canvas").transform;
		GameAPP.canvasUp = GameObject.Find("CanvasUp").transform;
		GameAPP.UIManager = new UIResourcesLoader();
		uint num;
		Application.targetFrameRate = (int)num;
		Time.timeScale = GameAPP.config.gameSpeed;
		CursorChange.curDefault = Resources.Load<Texture2D>("Image/CursorDefault");
		Texture2D curDefault = CursorChange.curDefault;
		Time.maximumDeltaTime = 0.1f;
		long time = GameAPP.GetTime();
		GameAPP.RealTime = time;
		MainMenu.GetLatestVersion();
		string text;
		Debug.Log("启动时间：" + text);
	}

	// Token: 0x060025DB RID: 9691 RVA: 0x000C785C File Offset: 0x000C5A5C
	[Token(Token = "0x60025DB")]
	[Address(RVA = "0x5C2820", Offset = "0x5C0E20", VA = "0x1805C2820")]
	public static long GetTime()
	{
		DateTime utcNow = DateTime.UtcNow;
		return 0L;
	}

	// Token: 0x060025DC RID: 9692 RVA: 0x000C7878 File Offset: 0x000C5A78
	[Token(Token = "0x60025DC")]
	[Address(RVA = "0x5C2760", Offset = "0x5C0D60", VA = "0x1805C2760")]
	private static string FormatTimestamp(long timestamp)
	{
		string text;
		return text;
	}

	// Token: 0x060025DD RID: 9693 RVA: 0x000C788C File Offset: 0x000C5A8C
	[Token(Token = "0x60025DD")]
	[Address(RVA = "0x5C8D30", Offset = "0x5C7330", VA = "0x1805C8D30")]
	private void Start()
	{
		UIMgr.EnterMainMenu();
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform transform = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)5), transform, num != 0);
		MixData.InitMixData();
		PlantDataManager.Init();
		ExploreDataManager.LoadData();
		ZombieDataManager.LoadData();
		LayerMaskMgr.InitLayer();
		ElementUpgrade.OnElementUpgrade();
	}

	// Token: 0x060025DE RID: 9694 RVA: 0x000C78F0 File Offset: 0x000C5AF0
	[Token(Token = "0x60025DE")]
	[Address(RVA = "0x5C8870", Offset = "0x5C6E70", VA = "0x1805C8870")]
	public static void PlaySound(SoundType soundType, float theVolume = 0.5f, float pitch = 1f)
	{
		GameAPP.PlaySound((int)soundType, theVolume, pitch);
	}

	// Token: 0x060025DF RID: 9695 RVA: 0x000C7908 File Offset: 0x000C5B08
	[Token(Token = "0x60025DF")]
	[Address(RVA = "0x5C87B0", Offset = "0x5C6DB0", VA = "0x1805C87B0")]
	public static void PlaySound(int theSoundID, float theVolume = 0.5f, float pitch = 1f)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060025E0 RID: 9696 RVA: 0x000C7928 File Offset: 0x000C5B28
	[Token(Token = "0x60025E0")]
	[Address(RVA = "0x5C82B0", Offset = "0x5C68B0", VA = "0x1805C82B0")]
	public void PlayMusic(MusicType id)
	{
		GameAPP.music.Stop();
		GameAPP.musicDrum.Stop();
		GameAPP.prelude.audioSource.Stop();
		if (id != MusicType.Roof_pre)
		{
			Dictionary<MusicType, AudioClip> musics = GameAPP.soundManager.musics;
			AudioSource audioSource = GameAPP.music;
			GameAPP.soundManager.musicUpdater.musicVolume = 1f;
			AudioSource audioSource2 = GameAPP.music;
			int num = 0;
			audioSource2.time = (float)num;
			GameAPP.music.Play();
			SoundManager soundManager = GameAPP.soundManager;
			bool flag;
			if (flag)
			{
				AudioSource audioSource3 = GameAPP.musicDrum;
				GameAPP.soundManager.musicUpdater.drumVolume = 0f;
			}
			if (id > MusicType.Snow)
			{
				if (!flag)
				{
					Board instance = Board.Instance;
					int num2 = 0;
					if (instance != num2)
					{
						Board.Instance.musicType = (int)((ulong)0L);
					}
					return;
				}
			}
			else
			{
				Board instance;
				if (instance <= (ulong)10L)
				{
					GameAPP.music.time = 1f;
					GameAPP.music.Play();
					return;
				}
				while (instance != (ulong)19L)
				{
				}
			}
			AudioSource audioSource4 = GameAPP.musicDrum;
			int num3 = 0;
			audioSource4.time = (float)num3;
			GameAPP.musicDrum.Play();
			Board.Instance.musicType = (int)((ulong)1L);
			return;
		}
		PreludeMusic preludeMusic = GameAPP.prelude;
	}

	// Token: 0x060025E1 RID: 9697 RVA: 0x000C7A80 File Offset: 0x000C5C80
	[Token(Token = "0x60025E1")]
	[Address(RVA = "0x5C6870", Offset = "0x5C4E70", VA = "0x1805C6870")]
	private void LoadResources()
	{
		Dictionary<string, IZData> dictionary = new Dictionary();
		CustomIZManager customIZManager;
		customIZManager.customIZDatas = dictionary;
		List<string> list = new List();
		customIZManager.levelNames = list;
		customIZManager.LoadLevelData("IZLevelData");
		GameAPP.customIZManager = customIZManager;
		AudioSource audioSource = GameAPP.music;
		AudioSource audioSource2 = GameAPP.musicDrum;
		GameAPP.soundManager = new SoundManager(audioSource, audioSource2);
		GameAPP.itemManager = new ItemManager();
		GameAPP.LoadParticle();
		GameAPP.LoadItem();
		GameAPP.LoadSprite();
		GameAPP.font = Resources.Load<TMP_FontAsset>("fonts/fzjz Dynamic");
	}

	// Token: 0x060025E2 RID: 9698 RVA: 0x000C7B04 File Offset: 0x000C5D04
	[Token(Token = "0x60025E2")]
	[Address(RVA = "0x5C3D90", Offset = "0x5C2390", VA = "0x1805C3D90")]
	private static void LoadParticle()
	{
		GameObject[] array = GameAPP.particlePrefab;
		GameObject gameObject = Resources.Load<GameObject>("Particle/Prefabs/" + "PeaSplat");
		array[0] = gameObject;
		GameObject[] array2 = GameAPP.particlePrefab;
		GameObject gameObject2 = Resources.Load<GameObject>("Particle/Prefabs/" + "Dirt");
		array2[1] = gameObject2;
		GameObject[] array3 = GameAPP.particlePrefab;
		GameObject gameObject3 = Resources.Load<GameObject>("Particle/Prefabs/" + "BombCloud");
		array3[2] = gameObject3;
		GameObject[] array4 = GameAPP.particlePrefab;
		GameObject gameObject4 = Resources.Load<GameObject>("Particle/Prefabs/" + "SunBombCloud");
		array4[3] = gameObject4;
		GameObject[] array5 = GameAPP.particlePrefab;
		GameObject gameObject5 = Resources.Load<GameObject>("Particle/Prefabs/" + "CherrySplat");
		array5[4] = gameObject5;
		GameObject[] array6 = GameAPP.particlePrefab;
		GameObject gameObject6 = Resources.Load<GameObject>("Particle/Prefabs/" + "NutPartical");
		array6[5] = gameObject6;
		GameObject[] array7 = GameAPP.particlePrefab;
		GameObject gameObject7 = Resources.Load<GameObject>("Particle/Prefabs/" + "CherryNutPartical");
		array7[6] = gameObject7;
		GameObject[] array8 = GameAPP.particlePrefab;
		GameObject gameObject8 = Resources.Load<GameObject>("Particle/Prefabs/" + "NutSplat");
		array8[7] = gameObject8;
		GameObject[] array9 = GameAPP.particlePrefab;
		GameObject gameObject9 = Resources.Load<GameObject>("Particle/Prefabs/" + "PotaoParticle");
		array9[8] = gameObject9;
		GameObject[] array10 = GameAPP.particlePrefab;
		GameObject gameObject10 = Resources.Load<GameObject>("Particle/Prefabs/" + "PotatoRise");
		array10[9] = gameObject10;
		GameObject[] array11 = GameAPP.particlePrefab;
		GameObject gameObject11 = Resources.Load<GameObject>("Particle/Prefabs/" + "GreenCherrySplat");
		array11[10] = gameObject11;
		GameObject[] array12 = GameAPP.particlePrefab;
		GameObject gameObject12 = Resources.Load<GameObject>("Particle/Prefabs/" + "RandomCloud");
		array12[11] = gameObject12;
		GameObject[] array13 = GameAPP.particlePrefab;
		GameObject gameObject13 = Resources.Load<GameObject>("Particle/Prefabs/" + "ZombieBlockSplat");
		array13[12] = gameObject13;
		GameObject[] array14 = GameAPP.particlePrefab;
		GameObject gameObject14 = Resources.Load<GameObject>("Particle/Prefabs/" + "PurpleNutDust");
		array14[13] = gameObject14;
		GameObject[] array15 = GameAPP.particlePrefab;
		GameObject gameObject15 = Resources.Load<GameObject>("Particle/Prefabs/" + "BombCloudSmall");
		array15[14] = gameObject15;
		GameObject[] array16 = GameAPP.particlePrefab;
		GameObject gameObject16 = Resources.Load<GameObject>("Particle/Prefabs/" + "PotatoSplat");
		array16[15] = gameObject16;
		GameObject[] array17 = GameAPP.particlePrefab;
		GameObject gameObject17 = Resources.Load<GameObject>("Particle/Prefabs/" + "Health");
		array17[16] = gameObject17;
		GameObject[] array18 = GameAPP.particlePrefab;
		GameObject gameObject18 = Resources.Load<GameObject>("Particle/Prefabs/" + "PuffSplat");
		array18[17] = gameObject18;
		GameObject[] array19 = GameAPP.particlePrefab;
		GameObject gameObject19 = Resources.Load<GameObject>("Particle/Prefabs/" + "IronPeaSplat");
		array19[18] = gameObject19;
		GameObject[] array20 = GameAPP.particlePrefab;
		GameObject gameObject20 = Resources.Load<GameObject>("Particle/Prefabs/" + "Fume");
		array20[19] = gameObject20;
		GameObject[] array21 = GameAPP.particlePrefab;
		GameObject gameObject21 = Resources.Load<GameObject>("Particle/Prefabs/" + "MindControl");
		array21[20] = gameObject21;
		GameObject[] array22 = GameAPP.particlePrefab;
		GameObject gameObject22 = Resources.Load<GameObject>("Particle/Prefabs/" + "FumeColorful");
		array22[21] = gameObject22;
		GameObject[] array23 = GameAPP.particlePrefab;
		GameObject gameObject23 = Resources.Load<GameObject>("Particle/Prefabs/" + "FumeColorful2");
		array23[22] = gameObject23;
		GameObject[] array24 = GameAPP.particlePrefab;
		GameObject gameObject24 = Resources.Load<GameObject>("Particle/Prefabs/" + "Star");
		array24[23] = gameObject24;
		GameObject[] array25 = GameAPP.particlePrefab;
		GameObject gameObject25 = Resources.Load<GameObject>("Particle/Prefabs/" + "SnowPeaSplat");
		array25[24] = gameObject25;
		GameObject[] array26 = GameAPP.particlePrefab;
		GameObject gameObject26 = Resources.Load<GameObject>("Particle/Prefabs/" + "Doom");
		array26[25] = gameObject26;
		GameObject[] array27 = GameAPP.particlePrefab;
		GameObject gameObject27 = Resources.Load<GameObject>("Particle/Prefabs/" + "PuffBlackSplat");
		array27[26] = gameObject27;
		GameObject[] array28 = GameAPP.particlePrefab;
		GameObject gameObject28 = Resources.Load<GameObject>("Particle/Prefabs/" + "DoomSplat");
		array28[27] = gameObject28;
		GameObject[] array29 = GameAPP.particlePrefab;
		GameObject gameObject29 = Resources.Load<GameObject>("Particle/Prefabs/" + "IceDoomSplat");
		array29[28] = gameObject29;
		GameObject[] array30 = GameAPP.particlePrefab;
		GameObject gameObject30 = Resources.Load<GameObject>("Particle/Prefabs/" + "IceDoom");
		array30[29] = gameObject30;
		GameObject[] array31 = GameAPP.particlePrefab;
		GameObject gameObject31 = Resources.Load<GameObject>("Particle/Prefabs/" + "FumeIce");
		array31[30] = gameObject31;
		GameObject[] array32 = GameAPP.particlePrefab;
		GameObject gameObject32 = Resources.Load<GameObject>("Particle/Prefabs/" + "FumeDoom");
		array32[31] = gameObject32;
		GameObject[] array33 = GameAPP.particlePrefab;
		GameObject gameObject33 = Resources.Load<GameObject>("Particle/Prefabs/" + "WaterSplats");
		array33[32] = gameObject33;
		GameObject[] array34 = GameAPP.particlePrefab;
		GameObject gameObject34 = Resources.Load<GameObject>("Particle/Prefabs/" + "Fire");
		array34[33] = gameObject34;
		GameObject[] array35 = GameAPP.particlePrefab;
		GameObject gameObject35 = Resources.Load<GameObject>("Particle/Prefabs/" + "MachineExplode");
		array35[34] = gameObject35;
		GameObject[] array36 = GameAPP.particlePrefab;
		GameObject gameObject36 = Resources.Load<GameObject>("Particle/Prefabs/" + "FireFree");
		array36[35] = gameObject36;
		GameObject[] array37 = GameAPP.particlePrefab;
		GameObject gameObject37 = Resources.Load<GameObject>("Particle/Prefabs/" + "MachineExplodeRed");
		array37[36] = gameObject37;
		GameObject[] array38 = GameAPP.particlePrefab;
		GameObject gameObject38 = Resources.Load<GameObject>("Particle/Prefabs/" + "Gloom");
		array38[37] = gameObject38;
		GameObject[] array39 = GameAPP.particlePrefab;
		GameObject gameObject39 = Resources.Load<GameObject>("Particle/Prefabs/" + "GloomFire");
		array39[38] = gameObject39;
		GameObject[] array40 = GameAPP.particlePrefab;
		GameObject gameObject40 = Resources.Load<GameObject>("Particle/Prefabs/" + "GloomIce");
		array40[39] = gameObject40;
		string text = "Particle/Prefabs/" + "LanternShine";
	}

	// Token: 0x060025E3 RID: 9699 RVA: 0x000C8154 File Offset: 0x000C6354
	[Token(Token = "0x60025E3")]
	[Address(RVA = "0x5C6B20", Offset = "0x5C5120", VA = "0x1805C6B20")]
	private static void LoadSprite()
	{
		Sprite[] array = GameAPP.spritePrefab;
		Sprite sprite = Resources.Load<Sprite>("Zombies/Image/reanim/Zombie_outerarm_upper2");
		array[0] = sprite;
		Sprite[] array2 = GameAPP.spritePrefab;
		Sprite sprite2 = Resources.Load<Sprite>("Zombies/Image/reanim/Zombie_cone2");
		array2[1] = sprite2;
		Sprite[] array3 = GameAPP.spritePrefab;
		Sprite sprite3 = Resources.Load<Sprite>("Zombies/Image/reanim/Zombie_cone3");
		array3[2] = sprite3;
		Sprite[] array4 = GameAPP.spritePrefab;
		Sprite sprite4 = Resources.Load<Sprite>("Zombies/Image/reanim/Zombie_bucket2");
		array4[3] = sprite4;
		Sprite[] array5 = GameAPP.spritePrefab;
		Sprite sprite5 = Resources.Load<Sprite>("Zombies/Image/reanim/Zombie_bucket3");
		array5[4] = sprite5;
		Sprite[] array6 = GameAPP.spritePrefab;
		Sprite sprite6 = Resources.Load<Sprite>("Zombies/PaperZombie/paper_bone");
		array6[5] = sprite6;
		Sprite[] array7 = GameAPP.spritePrefab;
		Sprite sprite7 = Resources.Load<Sprite>("Zombies/PaperZombie/paper2");
		array7[6] = sprite7;
		Sprite[] array8 = GameAPP.spritePrefab;
		Sprite sprite8 = Resources.Load<Sprite>("Zombies/PaperZombie/paper3");
		array8[7] = sprite8;
		Sprite[] array9 = GameAPP.spritePrefab;
		Sprite sprite9 = Resources.Load<Sprite>("Plants/WallNut/crackedA");
		array9[8] = sprite9;
		Sprite[] array10 = GameAPP.spritePrefab;
		Sprite sprite10 = Resources.Load<Sprite>("Plants/WallNut/crackedB");
		array10[9] = sprite10;
		Sprite[] array11 = GameAPP.spritePrefab;
		Sprite sprite11 = Resources.Load<Sprite>("Zombies/PlantZombie/Paper/CherryPaper1");
		array11[10] = sprite11;
		Sprite[] array12 = GameAPP.spritePrefab;
		Sprite sprite12 = Resources.Load<Sprite>("Zombies/PlantZombie/Paper/CherryPaper2");
		array12[11] = sprite12;
		Sprite[] array13 = GameAPP.spritePrefab;
		Sprite sprite13 = Resources.Load<Sprite>("Zombies/Zombie/Zombie_cone2");
		array13[12] = sprite13;
		Sprite[] array14 = GameAPP.spritePrefab;
		Sprite sprite14 = Resources.Load<Sprite>("Zombies/Zombie/Zombie_cone3");
		array14[13] = sprite14;
		Sprite[] array15 = GameAPP.spritePrefab;
		Sprite sprite15 = Resources.Load<Sprite>("Zombies/PlantZombie/ironNut2");
		array15[14] = sprite15;
		Sprite[] array16 = GameAPP.spritePrefab;
		Sprite sprite16 = Resources.Load<Sprite>("Zombies/PlantZombie/ironNut3");
		array16[15] = sprite16;
		Sprite[] array17 = GameAPP.spritePrefab;
		Sprite sprite17 = Resources.Load<Sprite>("Plants/_Mixer/CherryNut/crack1");
		array17[16] = sprite17;
		Sprite[] array18 = GameAPP.spritePrefab;
		Sprite sprite18 = Resources.Load<Sprite>("Plants/_Mixer/CherryNut/crack2");
		array18[17] = sprite18;
		Sprite[] array19 = GameAPP.spritePrefab;
		Sprite sprite19 = Resources.Load<Sprite>("Zombies/Door/Zombie_screendoor2");
		array19[18] = sprite19;
		Sprite[] array20 = GameAPP.spritePrefab;
		Sprite sprite20 = Resources.Load<Sprite>("Zombies/Door/Zombie_screendoor3");
		array20[19] = sprite20;
		Sprite[] array21 = GameAPP.spritePrefab;
		Sprite sprite21 = Resources.Load<Sprite>("Zombies/Zombie_football/Football/Zombie_football_helmet2");
		array21[20] = sprite21;
		Sprite[] array22 = GameAPP.spritePrefab;
		Sprite sprite22 = Resources.Load<Sprite>("Zombies/Zombie_football/Football/Zombie_football_helmet3");
		array22[21] = sprite22;
		Sprite[] array23 = GameAPP.spritePrefab;
		Sprite sprite23 = Resources.Load<Sprite>("Zombies/Zombie_football/TallNutFootballZ/tnf2");
		array23[22] = sprite23;
		Sprite[] array24 = GameAPP.spritePrefab;
		Sprite sprite24 = Resources.Load<Sprite>("Zombies/Zombie_football/TallNutFootballZ/tnf3");
		array24[23] = sprite24;
		Sprite[] array25 = GameAPP.spritePrefab;
		Sprite sprite25 = Resources.Load<Sprite>("Zombies/Zombie/Gold2");
		array25[24] = sprite25;
		Sprite[] array26 = GameAPP.spritePrefab;
		Sprite sprite26 = Resources.Load<Sprite>("Zombies/Zombie/Gold3");
		array26[25] = sprite26;
		Sprite[] array27 = GameAPP.spritePrefab;
		Sprite sprite27 = Resources.Load<Sprite>("Zombies/Zombie_Jackson/Zombie_Jackson_outerarm_upper2");
		array27[26] = sprite27;
		Sprite[] array28 = GameAPP.spritePrefab;
		Sprite sprite28 = Resources.Load<Sprite>("Zombies/PlantZombie/TallIceNutZ/TallIceCracked1");
		array28[27] = sprite28;
		Sprite[] array29 = GameAPP.spritePrefab;
		Sprite sprite29 = Resources.Load<Sprite>("Zombies/PlantZombie/TallIceNutZ/TallIceCracked2");
		array29[28] = sprite29;
		Sprite[] array30 = GameAPP.spritePrefab;
		Sprite sprite30 = Resources.Load<Sprite>("Zombies/Zombie_Driver/Zombie_zamboni_1_damage1");
		array30[29] = sprite30;
		Sprite[] array31 = GameAPP.spritePrefab;
		Sprite sprite31 = Resources.Load<Sprite>("Zombies/Zombie_Driver/Zombie_zamboni_1_damage2");
		array31[30] = sprite31;
		Sprite[] array32 = GameAPP.spritePrefab;
		Sprite sprite32 = Resources.Load<Sprite>("Zombies/Zombie_Driver/Zombie_zamboni_2_damage2");
		array32[31] = sprite32;
		Sprite[] array33 = GameAPP.spritePrefab;
		Sprite sprite33 = Resources.Load<Sprite>("Zombies/Zombie_Driver/Zombie_zamboni_2_damage2");
		array33[32] = sprite33;
		Sprite[] array34 = GameAPP.spritePrefab;
		Sprite sprite34 = Resources.Load<Sprite>("Zombies/Zombie_Driver/SuperDriver/body_dmg1");
		array34[33] = sprite34;
		Sprite[] array35 = GameAPP.spritePrefab;
		Sprite sprite35 = Resources.Load<Sprite>("Zombies/Zombie_Driver/SuperDriver/lower_dmg1");
		array35[34] = sprite35;
		Sprite[] array36 = GameAPP.spritePrefab;
		Sprite sprite36 = Resources.Load<Sprite>("Zombies/Zombie_Driver/SuperDriver/body_dmg2");
		array36[35] = sprite36;
		Sprite[] array37 = GameAPP.spritePrefab;
		Sprite sprite37 = Resources.Load<Sprite>("Zombies/Zombie_Driver/SuperDriver/lower_dmg2");
		array37[36] = sprite37;
		Sprite[] array38 = GameAPP.spritePrefab;
		Sprite sprite38 = Resources.Load<Sprite>("Zombies/Zombie_Driver/SuperDriver/below_dmg");
		array38[37] = sprite38;
		Sprite[] array39 = GameAPP.spritePrefab;
		Sprite sprite39 = Resources.Load<Sprite>("Zombies/PaperZombie/paper_bone1");
		array39[38] = sprite39;
		Sprite[] array40 = GameAPP.spritePrefab;
		Sprite sprite40 = Resources.Load<Sprite>("Bullet/BulletSpirtes/fireironpea");
		array40[39] = sprite40;
		Sprite[] array41 = GameAPP.spritePrefab;
		Sprite sprite41 = Resources.Load<Sprite>("Zombies/InTravel/FootballDrown/dmg1");
		array41[40] = sprite41;
		Sprite[] array42 = GameAPP.spritePrefab;
		Sprite sprite42 = Resources.Load<Sprite>("Zombies/InTravel/FootballDrown/dmg2");
		array42[41] = sprite42;
		Sprite[] array43 = GameAPP.spritePrefab;
		Sprite sprite43 = Resources.Load<Sprite>("Zombies/PaperZombie/book2");
		array43[42] = sprite43;
		Sprite[] array44 = GameAPP.spritePrefab;
		Sprite sprite44 = Resources.Load<Sprite>("Zombies/PaperZombie/book3");
		array44[43] = sprite44;
		Sprite[] array45 = GameAPP.spritePrefab;
		Sprite sprite45 = Resources.Load<Sprite>("Zombies/Zombie/DiamondDoll2");
		array45[44] = sprite45;
		Sprite[] array46 = GameAPP.spritePrefab;
		Sprite sprite46 = Resources.Load<Sprite>("Zombies/Zombie/DiamondDoll3");
		array46[45] = sprite46;
		Sprite[] array47 = GameAPP.spritePrefab;
		Sprite sprite47 = Resources.Load<Sprite>("Zombies/Zombie/GoldDoll2");
		array47[46] = sprite47;
		Sprite[] array48 = GameAPP.spritePrefab;
		Sprite sprite48 = Resources.Load<Sprite>("Zombies/Zombie/GoldDoll3");
		array48[47] = sprite48;
		Sprite[] array49 = GameAPP.spritePrefab;
		Sprite sprite49 = Resources.Load<Sprite>("Zombies/Zombie/SilverDoll2");
		array49[48] = sprite49;
		Sprite[] array50 = GameAPP.spritePrefab;
		Sprite sprite50 = Resources.Load<Sprite>("Zombies/Zombie/SilverDoll3");
		array50[49] = sprite50;
		Sprite[] array51 = GameAPP.spritePrefab;
		Sprite sprite51 = Resources.Load<Sprite>("Bullet/BulletSpirtes/ColorfulPuff1");
		array51[50] = sprite51;
		Sprite[] array52 = GameAPP.spritePrefab;
		Sprite sprite52 = Resources.Load<Sprite>("Bullet/BulletSpirtes/ColorfulPuff2");
		array52[51] = sprite52;
		Sprite[] array53 = GameAPP.spritePrefab;
		Sprite sprite53 = Resources.Load<Sprite>("Bullet/BulletSpirtes/ColorfulPuff3");
		array53[52] = sprite53;
		Sprite[] array54 = GameAPP.spritePrefab;
		Sprite sprite54 = Resources.Load<Sprite>("Bullet/BulletSpirtes/ColorfulPuff4");
		array54[53] = sprite54;
	}

	// Token: 0x060025E4 RID: 9700 RVA: 0x000C87A4 File Offset: 0x000C69A4
	[Token(Token = "0x60025E4")]
	[Address(RVA = "0x5C28E0", Offset = "0x5C0EE0", VA = "0x1805C28E0")]
	private static void LoadItem()
	{
		GameObject[] array = GameAPP.itemPrefab;
		GameObject gameObject = Resources.Load<GameObject>("Items/Sun/Sun");
		array[0] = gameObject;
		GameObject[] array2 = GameAPP.itemPrefab;
		GameObject gameObject2 = Resources.Load<GameObject>("Items/Sun/BigSun");
		array2[1] = gameObject2;
		GameObject[] array3 = GameAPP.itemPrefab;
		GameObject gameObject3 = Resources.Load<GameObject>("Items/Sun/SmallSun");
		array3[2] = gameObject3;
		GameObject[] array4 = GameAPP.itemPrefab;
		GameObject gameObject4 = Resources.Load<GameObject>("Items/KirovBomb");
		array4[3] = gameObject4;
		GameObject[] array5 = GameAPP.itemPrefab;
		GameObject gameObject5 = Resources.Load<GameObject>("Items/Bucket");
		array5[4] = gameObject5;
		GameObject[] array6 = GameAPP.itemPrefab;
		GameObject gameObject6 = Resources.Load<GameObject>("Items/Door");
		array6[5] = gameObject6;
		GameObject[] array7 = GameAPP.itemPrefab;
		GameObject gameObject7 = Resources.Load<GameObject>("Items/Helmet");
		array7[6] = gameObject7;
		GameObject[] array8 = GameAPP.itemPrefab;
		GameObject gameObject8 = Resources.Load<GameObject>("Items/Jackbox");
		array8[7] = gameObject8;
		GameObject[] array9 = GameAPP.itemPrefab;
		GameObject gameObject9 = Resources.Load<GameObject>("Items/Pickaxe");
		array9[8] = gameObject9;
		GameObject[] array10 = GameAPP.itemPrefab;
		GameObject gameObject10 = Resources.Load<GameObject>("Items/DroppedCard");
		array10[9] = gameObject10;
		GameObject[] array11 = GameAPP.itemPrefab;
		GameObject gameObject11 = Resources.Load<GameObject>("Items/BigStar");
		array11[10] = gameObject11;
		GameObject[] array12 = GameAPP.itemPrefab;
		GameObject gameObject12 = Resources.Load<GameObject>("Items/BigSuperStar");
		array12[11] = gameObject12;
		GameObject[] array13 = GameAPP.itemPrefab;
		GameObject gameObject13 = Resources.Load<GameObject>("Items/BigUltimateStar");
		array13[12] = gameObject13;
		GameObject[] array14 = GameAPP.itemPrefab;
		GameObject gameObject14 = Resources.Load<GameObject>("Items/Sun/BulletSun");
		array14[13] = gameObject14;
		GameObject[] array15 = GameAPP.itemPrefab;
		GameObject gameObject15 = Resources.Load<GameObject>("Zombies/InTravel/SuperKirov/Superbomb/SuperBomb");
		array15[14] = gameObject15;
		GameObject[] array16 = GameAPP.itemPrefab;
		GameObject gameObject16 = Resources.Load<GameObject>("Zombies/Cornpult_butter_splat");
		array16[15] = gameObject16;
		GameObject[] array17 = GameAPP.itemPrefab;
		GameObject gameObject17 = Resources.Load<GameObject>("Items/CobCannon_target");
		array17[16] = gameObject17;
		GameObject[] array18 = GameAPP.itemPrefab;
		GameObject gameObject18 = Resources.Load<GameObject>("Items/Jumper");
		array18[17] = gameObject18;
		GameObject[] array19 = GameAPP.itemPrefab;
		GameObject gameObject19 = Resources.Load<GameObject>("Garden/BubbleWater");
		array19[18] = gameObject19;
		GameObject[] array20 = GameAPP.itemPrefab;
		GameObject gameObject20 = Resources.Load<GameObject>("Garden/BubbleFertize");
		array20[19] = gameObject20;
		GameObject[] array21 = GameAPP.itemPrefab;
		GameObject gameObject21 = Resources.Load<GameObject>("Garden/BubbleBugSpray");
		array21[20] = gameObject21;
		GameObject[] array22 = GameAPP.itemPrefab;
		GameObject gameObject22 = Resources.Load<GameObject>("Garden/BubblePhonograph");
		array22[21] = gameObject22;
		GameObject[] array23 = GameAPP.itemPrefab;
		GameObject gameObject23 = Resources.Load<GameObject>("Garden/GardenPot");
		array23[22] = gameObject23;
		GameObject[] array24 = GameAPP.itemPrefab;
		GameObject gameObject24 = Resources.Load<GameObject>("Garden/Fertize/Ferilize");
		array24[23] = gameObject24;
		GameObject[] array25 = GameAPP.itemPrefab;
		GameObject gameObject25 = Resources.Load<GameObject>("Garden/WaterCan/WateringCanGold");
		array25[24] = gameObject25;
		GameObject[] array26 = GameAPP.itemPrefab;
		GameObject gameObject26 = Resources.Load<GameObject>("Garden/BugSpray/BugSpray");
		array26[25] = gameObject26;
		GameObject[] array27 = GameAPP.itemPrefab;
		GameObject gameObject27 = Resources.Load<GameObject>("Garden/Phonograph/Phonograph");
		array27[26] = gameObject27;
		GameObject[] array28 = GameAPP.itemPrefab;
		GameObject gameObject28 = Resources.Load<GameObject>("Garden/GardenPotPreview");
		array28[27] = gameObject28;
		GameObject[] array29 = GameAPP.itemPrefab;
		GameObject gameObject29 = Resources.Load<GameObject>("Items/SproutPotPrize/SproutPotPrize");
		array29[28] = gameObject29;
		GameObject[] array30 = GameAPP.itemPrefab;
		GameObject gameObject30 = Resources.Load<GameObject>("Items/NormalCard");
		array30[29] = gameObject30;
		GameObject[] array31 = GameAPP.itemPrefab;
		GameObject gameObject31 = Resources.Load<GameObject>("Items/IronHead");
		array31[30] = gameObject31;
		GameObject[] array32 = GameAPP.itemPrefab;
		GameObject gameObject32 = Resources.Load<GameObject>("Items/RedIronHead");
		array32[31] = gameObject32;
		GameObject[] array33 = GameAPP.itemPrefab;
		GameObject gameObject33 = Resources.Load<GameObject>("Zombies/_Image/FireBall");
		array33[32] = gameObject33;
		GameObject[] array34 = GameAPP.itemPrefab;
		GameObject gameObject34 = Resources.Load<GameObject>("Zombies/_Image/IceBall");
		array34[33] = gameObject34;
		GameObject[] array35 = GameAPP.itemPrefab;
		GameObject gameObject35 = Resources.Load<GameObject>("Items/Money/Silver");
		array35[34] = gameObject35;
		GameObject[] array36 = GameAPP.itemPrefab;
		GameObject gameObject36 = Resources.Load<GameObject>("Items/Money/Gold");
		array36[35] = gameObject36;
		GameObject[] array37 = GameAPP.itemPrefab;
		GameObject gameObject37 = Resources.Load<GameObject>("Items/Money/Diamond");
		array37[36] = gameObject37;
		GameObject[] array38 = GameAPP.itemPrefab;
		GameObject gameObject38 = Resources.Load<GameObject>("Items/Bean");
		array38[37] = gameObject38;
		GameObject[] array39 = GameAPP.itemPrefab;
		GameObject gameObject39 = Resources.Load<GameObject>("Items/Money/Silver");
		array39[38] = gameObject39;
		GameObject[] array40 = GameAPP.itemPrefab;
		GameObject gameObject40 = Resources.Load<GameObject>("Items/Money/Gold");
		array40[39] = gameObject40;
		GameObject[] array41 = GameAPP.itemPrefab;
		GameObject gameObject41 = Resources.Load<GameObject>("Items/BeltCard");
		array41[40] = gameObject41;
		GameObject[] array42 = GameAPP.itemPrefab;
		GameObject gameObject42 = Resources.Load<GameObject>("Items/Machine");
		array42[41] = gameObject42;
		GameObject[] array43 = GameAPP.itemPrefab;
		GameObject gameObject43 = Resources.Load<GameObject>("Items/Ladder");
		array43[42] = gameObject43;
		GameObject[] array44 = GameAPP.itemPrefab;
		GameObject gameObject44 = Resources.Load<GameObject>("Items/LevelUp/EliteIcon");
		array44[43] = gameObject44;
		GameObject[] array45 = GameAPP.itemPrefab;
		GameObject gameObject45 = Resources.Load<GameObject>("Items/LevelUp/EpicIcon");
		array45[44] = gameObject45;
		GameObject[] array46 = GameAPP.itemPrefab;
		GameObject gameObject46 = Resources.Load<GameObject>("Items/LevelUp/UltimateIcon");
		array46[45] = gameObject46;
		GameObject[] array47 = GameAPP.itemPrefab;
		GameObject gameObject47 = Resources.Load<GameObject>("Items/Solar");
		array47[46] = gameObject47;
		GameObject[] array48 = GameAPP.itemPrefab;
		GameObject gameObject48 = Resources.Load<GameObject>("Items/SolarStar");
		array48[47] = gameObject48;
		GameObject[] array49 = GameAPP.itemPrefab;
		GameObject gameObject49 = Resources.Load<GameObject>("Items/CobCannon_target_fire");
		array49[48] = gameObject49;
		GameObject[] array50 = GameAPP.itemPrefab;
		GameObject gameObject50 = Resources.Load<GameObject>("Items/ZombieCard");
		array50[49] = gameObject50;
		GameObject[] array51 = GameAPP.itemPrefab;
		GameObject gameObject51 = Resources.Load<GameObject>("Garden/GardenWaterPot");
		array51[50] = gameObject51;
		GameObject[] array52 = GameAPP.itemPrefab;
		GameObject gameObject52 = Resources.Load<GameObject>("Garden/GardenBigPot");
		array52[51] = gameObject52;
		GameObject[] array53 = GameAPP.itemPrefab;
		GameObject gameObject53 = Resources.Load<GameObject>("Items/Lunar");
		array53[52] = gameObject53;
		GameObject[] array54 = GameAPP.itemPrefab;
		GameObject gameObject54 = Resources.Load<GameObject>("Items/Sun/BlueSun");
		array54[53] = gameObject54;
		GameObject[] array55 = GameAPP.itemPrefab;
		GameObject gameObject55 = Resources.Load<GameObject>("Items/Sun/SmallBlueSun");
		array55[54] = gameObject55;
	}

	// Token: 0x060025E5 RID: 9701 RVA: 0x000C8E14 File Offset: 0x000C7014
	[Token(Token = "0x60025E5")]
	[Address(RVA = "0x5C8E60", Offset = "0x5C7460", VA = "0x1805C8E60")]
	private void Update()
	{
		if (Input.GetKeyDownInt(KeyCodeManager.FullScreen))
		{
			bool flag = "{il2cpp field on {'constant15' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xB9}" == (ulong)0L;
			Screen.SetResolution(1920, 1080, flag);
			GameAPP.isFullScreen = "{il2cpp field on {'constant24' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xB9}" == (ulong)0L;
		}
		if (Input.GetKeyDownInt(KeyCodeManager.NormalScreen))
		{
			int num = 0;
			Screen.SetResolution(1280, 720, num != 0);
		}
		GameAPP.soundManager.musicUpdater.MusicUpdate();
		if (Input.GetKeyDownInt(KeyCodeManager.Ra2Sound))
		{
			GameConfig gameConfig = GameAPP.config;
			bool flag2 = !gameConfig.ra2Sound;
			gameConfig.ra2Sound = flag2;
		}
		float num2 = this.realTimeUpdater;
		float deltaTime = Time.deltaTime;
		this.realTimeUpdater = num2;
		this.realTimeUpdater = 1f;
		GameAPP.RealTime = GameAPP.GetTime();
	}

	// Token: 0x060025E6 RID: 9702 RVA: 0x000C8EE8 File Offset: 0x000C70E8
	[Token(Token = "0x60025E6")]
	[Address(RVA = "0x5C88E0", Offset = "0x5C6EE0", VA = "0x1805C88E0")]
	private void SearchEnumBug()
	{
		int num = 0;
		string[] names = Enum.GetNames(typeof(TravelAdvanture));
		if (num < names.Length)
		{
			int num2 = 0;
			if (!Enum.TryParse(typeof(PlantType), num2, num))
			{
				return;
			}
			num++;
		}
		string[] names2 = Enum.GetNames(typeof(SkinLevel));
		if (num < names2.Length)
		{
			int num3 = 0;
			if (!Enum.TryParse(typeof(PlantType), num3, num))
			{
				return;
			}
			num++;
		}
		string[] names3 = Enum.GetNames(typeof(LeaderType));
		if (num < names3.Length)
		{
			Type typeFromHandle = typeof(PlantType);
			bool flag;
			if (!flag)
			{
				return;
			}
			num++;
		}
	}

	// Token: 0x060025E7 RID: 9703 RVA: 0x000C8F90 File Offset: 0x000C7190
	[Token(Token = "0x60025E7")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public GameAPP()
	{
	}

	// Token: 0x0400133B RID: 4923
	[Token(Token = "0x400133B")]
	public static GameAPP Instance;

	// Token: 0x0400133C RID: 4924
	[Token(Token = "0x400133C")]
	public static Transform canvas;

	// Token: 0x0400133D RID: 4925
	[Token(Token = "0x400133D")]
	public static Transform canvasUp;

	// Token: 0x0400133E RID: 4926
	[Token(Token = "0x400133E")]
	public static GameObject board;

	// Token: 0x0400133F RID: 4927
	[Token(Token = "0x400133F")]
	public static GameObject[] particlePrefab = new GameObject[1024];

	// Token: 0x04001340 RID: 4928
	[Token(Token = "0x4001340")]
	public static GameObject[] itemPrefab = new GameObject[1024];

	// Token: 0x04001341 RID: 4929
	[Token(Token = "0x4001341")]
	public static Sprite[] spritePrefab = new Sprite[1024];

	// Token: 0x04001342 RID: 4930
	[Token(Token = "0x4001342")]
	public static List<GameAPP.LastCards> lastCards = new List();

	// Token: 0x04001343 RID: 4931
	[Token(Token = "0x4001343")]
	public static float currentMusicVolume;

	// Token: 0x04001344 RID: 4932
	[Token(Token = "0x4001344")]
	public static float currentDrumVolume;

	// Token: 0x04001345 RID: 4933
	[Token(Token = "0x4001345")]
	public static long theMoneyCount;

	// Token: 0x04001346 RID: 4934
	[Token(Token = "0x4001346")]
	public static bool[] advLevelCompleted = new bool[128];

	// Token: 0x04001347 RID: 4935
	[Token(Token = "0x4001347")]
	public static bool[] clgLevelCompleted = new bool[256];

	// Token: 0x04001348 RID: 4936
	[Token(Token = "0x4001348")]
	public static bool[] gameLevelCompleted = new bool[128];

	// Token: 0x04001349 RID: 4937
	[Token(Token = "0x4001349")]
	public static bool[] survivalLevelCompleted = new bool[128];

	// Token: 0x0400134A RID: 4938
	[Token(Token = "0x400134A")]
	public static HashSet<int> exploreLevelCompleted = new HashSet();

	// Token: 0x0400134B RID: 4939
	[Token(Token = "0x400134B")]
	public static HashSet<int> skinLevelCompleted = new HashSet();

	// Token: 0x0400134C RID: 4940
	[Token(Token = "0x400134C")]
	public static HashSet<int> customCompleted = new HashSet();

	// Token: 0x0400134D RID: 4941
	[Token(Token = "0x400134D")]
	public static int newAdvArrivedLevel;

	// Token: 0x0400134E RID: 4942
	[Token(Token = "0x400134E")]
	public static HashSet<string> nameLevelCompleted = new HashSet();

	// Token: 0x0400134F RID: 4943
	[Token(Token = "0x400134F")]
	public static int theBoardLevel;

	// Token: 0x04001350 RID: 4944
	[Token(Token = "0x4001350")]
	public static LevelType theBoardType;

	// Token: 0x04001351 RID: 4945
	[Token(Token = "0x4001351")]
	public static string theIZLevelName;

	// Token: 0x04001352 RID: 4946
	[Token(Token = "0x4001352")]
	public static GameStatus theGameStatus;

	// Token: 0x04001353 RID: 4947
	[Token(Token = "0x4001353")]
	public static bool developerMode;

	// Token: 0x04001354 RID: 4948
	[Token(Token = "0x4001354")]
	public static List<GameAPP.EVEPlant> plantEVE = new List();

	// Token: 0x04001355 RID: 4949
	[Token(Token = "0x4001355")]
	public static bool mouseFlip;

	// Token: 0x04001356 RID: 4950
	[Token(Token = "0x4001356")]
	public static bool isFullScreen;

	// Token: 0x04001357 RID: 4951
	[Token(Token = "0x4001357")]
	public static string playerName = "Player";

	// Token: 0x04001358 RID: 4952
	[Token(Token = "0x4001358")]
	public static string version = "3.8.1";

	// Token: 0x04001359 RID: 4953
	[Token(Token = "0x4001359")]
	public static int advantureLevel;

	// Token: 0x0400135A RID: 4954
	[Token(Token = "0x400135A")]
	public static int advantureZhouMu;

	// Token: 0x0400135B RID: 4955
	[Token(Token = "0x400135B")]
	public static int towerLevel;

	// Token: 0x0400135C RID: 4956
	[Token(Token = "0x400135C")]
	public static List<PlantType> randomPlantInZhouMu = new List();

	// Token: 0x0400135D RID: 4957
	[Token(Token = "0x400135D")]
	public static List<PlantType> bannedInPVPScaryPot = new List();

	// Token: 0x0400135E RID: 4958
	[Token(Token = "0x400135E")]
	public static List<ZombieType> bannedInPVPScaryPot_zombie = new List();

	// Token: 0x0400135F RID: 4959
	[Token(Token = "0x400135F")]
	public static bool almanalTextSafe;

	// Token: 0x04001360 RID: 4960
	[Token(Token = "0x4001360")]
	public static bool TravelMenu;

	// Token: 0x04001361 RID: 4961
	[Token(Token = "0x4001361")]
	public static ResourcesManager resourcesManager;

	// Token: 0x04001362 RID: 4962
	[Token(Token = "0x4001362")]
	public static CustomIZManager customIZManager;

	// Token: 0x04001363 RID: 4963
	[Token(Token = "0x4001363")]
	public static SoundManager soundManager;

	// Token: 0x04001364 RID: 4964
	[Token(Token = "0x4001364")]
	public static ItemManager itemManager;

	// Token: 0x04001365 RID: 4965
	[Token(Token = "0x4001365")]
	public static UIResourcesLoader UIManager;

	// Token: 0x04001366 RID: 4966
	[Token(Token = "0x4001366")]
	public static GameConfig config;

	// Token: 0x04001367 RID: 4967
	[Token(Token = "0x4001367")]
	public static KeyCode keyCode;

	// Token: 0x04001368 RID: 4968
	[Token(Token = "0x4001368")]
	public static List<KeyCode> keyCode2 = new List();

	// Token: 0x04001369 RID: 4969
	[Token(Token = "0x4001369")]
	public const float const_x = 1.35f;

	// Token: 0x0400136A RID: 4970
	[Token(Token = "0x400136A")]
	public const float const_y = 1.67f;

	// Token: 0x0400136B RID: 4971
	[Token(Token = "0x400136B")]
	public const float const_y2 = 1.45f;

	// Token: 0x0400136C RID: 4972
	[Token(Token = "0x400136C")]
	public const float mower_x = -6f;

	// Token: 0x0400136D RID: 4973
	[Token(Token = "0x400136D")]
	public const int MaxDamage = 1000000;

	// Token: 0x0400136E RID: 4974
	[Token(Token = "0x400136E")]
	public const float 屋顶X坐标 = 1.5f;

	// Token: 0x0400136F RID: 4975
	[Token(Token = "0x400136F")]
	public const float 屋顶斜率 = 0.22f;

	// Token: 0x04001370 RID: 4976
	[Token(Token = "0x4001370")]
	public const float PotOffset = 0.1f;

	// Token: 0x04001371 RID: 4977
	[Token(Token = "0x4001371")]
	public const int 万 = 10000;

	// Token: 0x04001372 RID: 4978
	[Token(Token = "0x4001372")]
	public const int 千万 = 10000000;

	// Token: 0x04001373 RID: 4979
	[Token(Token = "0x4001373")]
	public const int 亿 = 100000000;

	// Token: 0x04001374 RID: 4980
	[Token(Token = "0x4001374")]
	public const int 十亿 = 1000000000;

	// Token: 0x04001375 RID: 4981
	[Token(Token = "0x4001375")]
	public static AudioSource music;

	// Token: 0x04001376 RID: 4982
	[Token(Token = "0x4001376")]
	public static AudioSource musicDrum;

	// Token: 0x04001377 RID: 4983
	[Token(Token = "0x4001377")]
	public static PreludeMusic prelude;

	// Token: 0x04001378 RID: 4984
	[Token(Token = "0x4001378")]
	public static DelayAction delayAction;

	// Token: 0x04001379 RID: 4985
	[Token(Token = "0x4001379")]
	public static TMP_FontAsset font;

	// Token: 0x0400137A RID: 4986
	[Token(Token = "0x400137A")]
	public static long RealTime;

	// Token: 0x0400137B RID: 4987
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400137B")]
	private float realTimeUpdater;

	// Token: 0x02000747 RID: 1863
	[Token(Token = "0x2000747")]
	public struct EVEPlant
	{
		// Token: 0x0400137C RID: 4988
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400137C")]
		public int row;

		// Token: 0x0400137D RID: 4989
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400137D")]
		public int column;

		// Token: 0x0400137E RID: 4990
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400137E")]
		public PlantType type;
	}

	// Token: 0x02000748 RID: 1864
	[Token(Token = "0x2000748")]
	public struct LastCards
	{
		// Token: 0x0400137F RID: 4991
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400137F")]
		public PlantType theSeedType;

		// Token: 0x04001380 RID: 4992
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4001380")]
		public bool isExtra;
	}
}
