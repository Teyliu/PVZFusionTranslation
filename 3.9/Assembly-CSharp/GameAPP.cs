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

// Token: 0x0200077F RID: 1919
[Token(Token = "0x200077F")]
public class GameAPP : MonoBehaviour
{
	// Token: 0x060026FF RID: 9983 RVA: 0x000CC5D8 File Offset: 0x000CA7D8
	[Token(Token = "0x60026FF")]
	[Address(RVA = "0x622C00", Offset = "0x621200", VA = "0x180622C00")]
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

	// Token: 0x06002700 RID: 9984 RVA: 0x000CC738 File Offset: 0x000CA938
	[Token(Token = "0x6002700")]
	[Address(RVA = "0x6233D0", Offset = "0x6219D0", VA = "0x1806233D0")]
	public static long GetTime()
	{
		DateTime utcNow = DateTime.UtcNow;
		return 0L;
	}

	// Token: 0x06002701 RID: 9985 RVA: 0x000CC754 File Offset: 0x000CA954
	[Token(Token = "0x6002701")]
	[Address(RVA = "0x623310", Offset = "0x621910", VA = "0x180623310")]
	private static string FormatTimestamp(long timestamp)
	{
		string text;
		return text;
	}

	// Token: 0x06002702 RID: 9986 RVA: 0x000CC768 File Offset: 0x000CA968
	[Token(Token = "0x6002702")]
	[Address(RVA = "0x6298E0", Offset = "0x627EE0", VA = "0x1806298E0")]
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

	// Token: 0x06002703 RID: 9987 RVA: 0x000CC7CC File Offset: 0x000CA9CC
	[Token(Token = "0x6002703")]
	[Address(RVA = "0x629420", Offset = "0x627A20", VA = "0x180629420")]
	public static void PlaySound(SoundType soundType, float theVolume = 0.5f, float pitch = 1f)
	{
		GameAPP.PlaySound((int)soundType, theVolume, pitch);
	}

	// Token: 0x06002704 RID: 9988 RVA: 0x000CC7E4 File Offset: 0x000CA9E4
	[Token(Token = "0x6002704")]
	[Address(RVA = "0x629360", Offset = "0x627960", VA = "0x180629360")]
	public static void PlaySound(int theSoundID, float theVolume = 0.5f, float pitch = 1f)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002705 RID: 9989 RVA: 0x000CC804 File Offset: 0x000CAA04
	[Token(Token = "0x6002705")]
	[Address(RVA = "0x628E60", Offset = "0x627460", VA = "0x180628E60")]
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

	// Token: 0x06002706 RID: 9990 RVA: 0x000CC95C File Offset: 0x000CAB5C
	[Token(Token = "0x6002706")]
	[Address(RVA = "0x627420", Offset = "0x625A20", VA = "0x180627420")]
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

	// Token: 0x06002707 RID: 9991 RVA: 0x000CC9E0 File Offset: 0x000CABE0
	[Token(Token = "0x6002707")]
	[Address(RVA = "0x624940", Offset = "0x622F40", VA = "0x180624940")]
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

	// Token: 0x06002708 RID: 9992 RVA: 0x000CD030 File Offset: 0x000CB230
	[Token(Token = "0x6002708")]
	[Address(RVA = "0x6276D0", Offset = "0x625CD0", VA = "0x1806276D0")]
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

	// Token: 0x06002709 RID: 9993 RVA: 0x000CD680 File Offset: 0x000CB880
	[Token(Token = "0x6002709")]
	[Address(RVA = "0x623490", Offset = "0x621A90", VA = "0x180623490")]
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

	// Token: 0x0600270A RID: 9994 RVA: 0x000CDCF0 File Offset: 0x000CBEF0
	[Token(Token = "0x600270A")]
	[Address(RVA = "0x629A10", Offset = "0x628010", VA = "0x180629A10")]
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

	// Token: 0x0600270B RID: 9995 RVA: 0x000CDDC4 File Offset: 0x000CBFC4
	[Token(Token = "0x600270B")]
	[Address(RVA = "0x629490", Offset = "0x627A90", VA = "0x180629490")]
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

	// Token: 0x0600270C RID: 9996 RVA: 0x000CDE6C File Offset: 0x000CC06C
	[Token(Token = "0x600270C")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public GameAPP()
	{
	}

	// Token: 0x04001411 RID: 5137
	[Token(Token = "0x4001411")]
	public static GameAPP Instance;

	// Token: 0x04001412 RID: 5138
	[Token(Token = "0x4001412")]
	public static Transform canvas;

	// Token: 0x04001413 RID: 5139
	[Token(Token = "0x4001413")]
	public static Transform canvasUp;

	// Token: 0x04001414 RID: 5140
	[Token(Token = "0x4001414")]
	public static GameObject board;

	// Token: 0x04001415 RID: 5141
	[Token(Token = "0x4001415")]
	public static GameObject[] particlePrefab = new GameObject[1024];

	// Token: 0x04001416 RID: 5142
	[Token(Token = "0x4001416")]
	public static GameObject[] itemPrefab = new GameObject[1024];

	// Token: 0x04001417 RID: 5143
	[Token(Token = "0x4001417")]
	public static Sprite[] spritePrefab = new Sprite[1024];

	// Token: 0x04001418 RID: 5144
	[Token(Token = "0x4001418")]
	public static List<GameAPP.LastCards> lastCards = new List();

	// Token: 0x04001419 RID: 5145
	[Token(Token = "0x4001419")]
	public static float currentMusicVolume;

	// Token: 0x0400141A RID: 5146
	[Token(Token = "0x400141A")]
	public static float currentDrumVolume;

	// Token: 0x0400141B RID: 5147
	[Token(Token = "0x400141B")]
	public static long theMoneyCount;

	// Token: 0x0400141C RID: 5148
	[Token(Token = "0x400141C")]
	public static bool[] advLevelCompleted = new bool[128];

	// Token: 0x0400141D RID: 5149
	[Token(Token = "0x400141D")]
	public static bool[] clgLevelCompleted = new bool[256];

	// Token: 0x0400141E RID: 5150
	[Token(Token = "0x400141E")]
	public static bool[] gameLevelCompleted = new bool[128];

	// Token: 0x0400141F RID: 5151
	[Token(Token = "0x400141F")]
	public static bool[] survivalLevelCompleted = new bool[128];

	// Token: 0x04001420 RID: 5152
	[Token(Token = "0x4001420")]
	public static HashSet<int> exploreLevelCompleted = new HashSet();

	// Token: 0x04001421 RID: 5153
	[Token(Token = "0x4001421")]
	public static HashSet<int> skinLevelCompleted = new HashSet();

	// Token: 0x04001422 RID: 5154
	[Token(Token = "0x4001422")]
	public static HashSet<int> customCompleted = new HashSet();

	// Token: 0x04001423 RID: 5155
	[Token(Token = "0x4001423")]
	public static int newAdvArrivedLevel;

	// Token: 0x04001424 RID: 5156
	[Token(Token = "0x4001424")]
	public static HashSet<string> nameLevelCompleted = new HashSet();

	// Token: 0x04001425 RID: 5157
	[Token(Token = "0x4001425")]
	public static int theBoardLevel;

	// Token: 0x04001426 RID: 5158
	[Token(Token = "0x4001426")]
	public static LevelType theBoardType;

	// Token: 0x04001427 RID: 5159
	[Token(Token = "0x4001427")]
	public static string theIZLevelName;

	// Token: 0x04001428 RID: 5160
	[Token(Token = "0x4001428")]
	public static GameStatus theGameStatus;

	// Token: 0x04001429 RID: 5161
	[Token(Token = "0x4001429")]
	public static bool developerMode;

	// Token: 0x0400142A RID: 5162
	[Token(Token = "0x400142A")]
	public static List<GameAPP.EVEPlant> plantEVE = new List();

	// Token: 0x0400142B RID: 5163
	[Token(Token = "0x400142B")]
	public static bool mouseFlip;

	// Token: 0x0400142C RID: 5164
	[Token(Token = "0x400142C")]
	public static bool isFullScreen;

	// Token: 0x0400142D RID: 5165
	[Token(Token = "0x400142D")]
	public static string playerName = "Player";

	// Token: 0x0400142E RID: 5166
	[Token(Token = "0x400142E")]
	public static string version = "3.9";

	// Token: 0x0400142F RID: 5167
	[Token(Token = "0x400142F")]
	public static int advantureLevel;

	// Token: 0x04001430 RID: 5168
	[Token(Token = "0x4001430")]
	public static int advantureZhouMu;

	// Token: 0x04001431 RID: 5169
	[Token(Token = "0x4001431")]
	public static int towerLevel;

	// Token: 0x04001432 RID: 5170
	[Token(Token = "0x4001432")]
	public static List<PlantType> randomPlantInZhouMu = new List();

	// Token: 0x04001433 RID: 5171
	[Token(Token = "0x4001433")]
	public static List<PlantType> bannedInPVPScaryPot = new List();

	// Token: 0x04001434 RID: 5172
	[Token(Token = "0x4001434")]
	public static List<ZombieType> bannedInPVPScaryPot_zombie = new List();

	// Token: 0x04001435 RID: 5173
	[Token(Token = "0x4001435")]
	public static bool almanalTextSafe;

	// Token: 0x04001436 RID: 5174
	[Token(Token = "0x4001436")]
	public static bool TravelMenu;

	// Token: 0x04001437 RID: 5175
	[Token(Token = "0x4001437")]
	public static ResourcesManager resourcesManager;

	// Token: 0x04001438 RID: 5176
	[Token(Token = "0x4001438")]
	public static CustomIZManager customIZManager;

	// Token: 0x04001439 RID: 5177
	[Token(Token = "0x4001439")]
	public static SoundManager soundManager;

	// Token: 0x0400143A RID: 5178
	[Token(Token = "0x400143A")]
	public static ItemManager itemManager;

	// Token: 0x0400143B RID: 5179
	[Token(Token = "0x400143B")]
	public static UIResourcesLoader UIManager;

	// Token: 0x0400143C RID: 5180
	[Token(Token = "0x400143C")]
	public static GameConfig config;

	// Token: 0x0400143D RID: 5181
	[Token(Token = "0x400143D")]
	public static KeyCode keyCode;

	// Token: 0x0400143E RID: 5182
	[Token(Token = "0x400143E")]
	public static List<KeyCode> keyCode2 = new List();

	// Token: 0x0400143F RID: 5183
	[Token(Token = "0x400143F")]
	public const float const_x = 1.35f;

	// Token: 0x04001440 RID: 5184
	[Token(Token = "0x4001440")]
	public const float const_y = 1.67f;

	// Token: 0x04001441 RID: 5185
	[Token(Token = "0x4001441")]
	public const float const_y2 = 1.45f;

	// Token: 0x04001442 RID: 5186
	[Token(Token = "0x4001442")]
	public const float mower_x = -6f;

	// Token: 0x04001443 RID: 5187
	[Token(Token = "0x4001443")]
	public const int MaxDamage = 1000000;

	// Token: 0x04001444 RID: 5188
	[Token(Token = "0x4001444")]
	public const float 屋顶X坐标 = 1.5f;

	// Token: 0x04001445 RID: 5189
	[Token(Token = "0x4001445")]
	public const float 屋顶斜率 = 0.22f;

	// Token: 0x04001446 RID: 5190
	[Token(Token = "0x4001446")]
	public const float PotOffset = 0.1f;

	// Token: 0x04001447 RID: 5191
	[Token(Token = "0x4001447")]
	public const int 万 = 10000;

	// Token: 0x04001448 RID: 5192
	[Token(Token = "0x4001448")]
	public const int 千万 = 10000000;

	// Token: 0x04001449 RID: 5193
	[Token(Token = "0x4001449")]
	public const int 亿 = 100000000;

	// Token: 0x0400144A RID: 5194
	[Token(Token = "0x400144A")]
	public const int 十亿 = 1000000000;

	// Token: 0x0400144B RID: 5195
	[Token(Token = "0x400144B")]
	public static AudioSource music;

	// Token: 0x0400144C RID: 5196
	[Token(Token = "0x400144C")]
	public static AudioSource musicDrum;

	// Token: 0x0400144D RID: 5197
	[Token(Token = "0x400144D")]
	public static PreludeMusic prelude;

	// Token: 0x0400144E RID: 5198
	[Token(Token = "0x400144E")]
	public static DelayAction delayAction;

	// Token: 0x0400144F RID: 5199
	[Token(Token = "0x400144F")]
	public static TMP_FontAsset font;

	// Token: 0x04001450 RID: 5200
	[Token(Token = "0x4001450")]
	public static long RealTime;

	// Token: 0x04001451 RID: 5201
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001451")]
	private float realTimeUpdater;

	// Token: 0x02000780 RID: 1920
	[Token(Token = "0x2000780")]
	public struct EVEPlant
	{
		// Token: 0x04001452 RID: 5202
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001452")]
		public int row;

		// Token: 0x04001453 RID: 5203
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4001453")]
		public int column;

		// Token: 0x04001454 RID: 5204
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001454")]
		public PlantType type;
	}

	// Token: 0x02000781 RID: 1921
	[Token(Token = "0x2000781")]
	public struct LastCards
	{
		// Token: 0x04001455 RID: 5205
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001455")]
		public PlantType theSeedType;

		// Token: 0x04001456 RID: 5206
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4001456")]
		public bool isExtra;
	}
}
