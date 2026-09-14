using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

namespace ZenGarden
{
	// Token: 0x02000A65 RID: 2661
	[Token(Token = "0x2000A65")]
	public class GardenPlant : MonoBehaviour
	{
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060036C0 RID: 14016 RVA: 0x00124940 File Offset: 0x00122B40
		[Token(Token = "0x17000284")]
		public long CurrentTime
		{
			[Token(Token = "0x60036C0")]
			[Address(RVA = "0x7B9BE0", Offset = "0x7B81E0", VA = "0x1807B9BE0")]
			get
			{
				DateTime utcNow = DateTime.UtcNow;
				return 0L;
			}
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x0012495C File Offset: 0x00122B5C
		[Token(Token = "0x60036C1")]
		[Address(RVA = "0x7B7CF0", Offset = "0x7B62F0", VA = "0x1807B7CF0")]
		private void Awake()
		{
			Transform transform = base.transform.Find("PlantAxis");
			this.plantTargetAxis = transform;
			Transform transform2 = base.transform.Find("Shadow");
			this.axis = transform2;
			Transform transform3 = base.transform;
			int num = 0;
			GameObject gameObject = transform3.GetChild(num).gameObject;
			this.info = gameObject;
			Transform transform4 = this.info.transform;
			int num2 = 0;
			TextMeshPro component = transform4.GetChild(num2).GetComponent<TextMeshPro>();
			this.infoText = component;
			GameObject gameObject2 = this.info;
			int num3 = 0;
			if (!(gameObject2 == num3))
			{
				TextMeshPro textMeshPro = this.infoText;
				int num4 = 0;
				if (!(textMeshPro == num4) && GameAPP.config == 0)
				{
					return;
				}
			}
			this.data.needTool = (GardenToolType)((ulong)0L);
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x00124A2C File Offset: 0x00122C2C
		[Token(Token = "0x60036C2")]
		[Address(RVA = "0x7B8F50", Offset = "0x7B7550", VA = "0x1807B8F50")]
		private void Start()
		{
			List<SpriteRenderer> childs = global::Core.Lawnf.GetChilds<SpriteRenderer>(base.transform);
			this.spriteRenderers = childs;
			int growStage = this.data.growStage;
			if (growStage == 0)
			{
				Transform transform = this.plantObject.transform;
				Vector2 vector = this.plantScale;
				float y = this.plantScale.y;
			}
			if (growStage == 1)
			{
				Transform transform2 = this.plantObject.transform;
				Vector2 vector2 = this.plantScale;
				float y2 = this.plantScale.y;
			}
			Transform transform3 = this.plantAxis;
			Transform transform4 = this.plantTargetAxis;
			Vector3 vector3;
			float z = vector3.z;
			Transform transform5 = this.plantObject.transform;
			Transform transform6 = base.transform.Find("plantHead");
			int num = 0;
			Animator component = transform6.GetChild(num).GetComponent<Animator>();
			this.anim = component;
			SortingGroup component2 = base.GetComponent<SortingGroup>();
			this.sortingGroup = component2;
			GardenPlantData gardenPlantData = this.data;
			base.transform.Find("Glow").gameObject.SetActive(true);
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x00124B34 File Offset: 0x00122D34
		[Token(Token = "0x60036C3")]
		[Address(RVA = "0x7B84C0", Offset = "0x7B6AC0", VA = "0x1807B84C0")]
		private void FixedUpdate()
		{
			Board instance = Board.Instance;
			int num = 0;
			if (instance != num)
			{
				Mouse instance2 = Mouse.Instance;
				int num2 = 0;
				if (!(instance2 != num2) || !(Mouse.Instance.theGardenPlantOnGlove == this))
				{
					float num3 = this.battleTimer;
					int num4 = 0;
					if (num3 <= (float)num4)
					{
					}
				}
			}
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x00124B90 File Offset: 0x00122D90
		[Token(Token = "0x60036C4")]
		[Address(RVA = "0x7B7F00", Offset = "0x7B6500", VA = "0x1807B7F00")]
		private void BattleUpdate()
		{
			float num = this.battleTimer;
			int num2 = 0;
			if (num > (float)num2)
			{
				float deltaTime = Time.deltaTime;
				this.battleTimer = num;
				this.battleTimer = 0f;
			}
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x00124BC4 File Offset: 0x00122DC4
		[Token(Token = "0x60036C5")]
		[Address(RVA = "0x7B8620", Offset = "0x7B6C20", VA = "0x1807B8620")]
		private void GardenUpdate()
		{
			int num = 0;
			if (!this.preview)
			{
				float num2 = this.timeUpdater;
				float deltaTime = Time.deltaTime;
				this.timeUpdater = num2;
				if (num > (int)num2)
				{
					this.timeUpdater = 1f;
					if (!this.ready)
					{
						long currentTime = this.CurrentTime;
						GardenPlantData gardenPlantData = this.data;
						if (currentTime > gardenPlantData.nextTime)
						{
							GardenUI instance = GardenUI.Instance;
							int num3 = 0;
							if (instance != num3 && GardenUI.Instance.plantOnWheel != this)
							{
								this.ready = true;
								this.Ready();
							}
						}
						if (this.infoShowTime > (float)num)
						{
							this.UpdateInfo();
						}
					}
				}
			}
			float num4 = this.infoShowTime;
			if (num4 > (float)num)
			{
				float deltaTime2 = Time.deltaTime;
				this.infoShowTime = num4;
				GameObject gameObject = this.info;
				int num5 = 0;
				gameObject.SetActive(num5 != 0);
			}
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x00124CAC File Offset: 0x00122EAC
		[Token(Token = "0x60036C6")]
		[Address(RVA = "0x7B96B0", Offset = "0x7B7CB0", VA = "0x1807B96B0")]
		private void Update()
		{
			float num = this.battleTimer;
			int num2 = 0;
			if (num > (float)num2)
			{
				float deltaTime = Time.deltaTime;
				this.battleTimer = num;
				this.battleTimer = 0f;
			}
			GardenUI instance = GardenUI.Instance;
			int num3 = 0;
			if (!(instance != num3) || !GardenUI.Instance.inStore)
			{
				Board instance2 = Board.Instance;
				int num4 = 0;
				bool flag = instance2 != num4;
				if (!flag)
				{
					if (this.preview == flag)
					{
						float num5 = this.timeUpdater;
						float deltaTime2 = Time.deltaTime;
						this.timeUpdater = num5;
						if (num2 > (int)num5)
						{
							this.timeUpdater = 1f;
							if (!this.ready)
							{
								long currentTime = this.CurrentTime;
								GardenPlantData gardenPlantData = this.data;
								if (currentTime > gardenPlantData.nextTime)
								{
									GardenUI instance3 = GardenUI.Instance;
									int num6 = 0;
									if (instance3 != num6 && GardenUI.Instance.plantOnWheel != this)
									{
										this.ready = true;
										this.Ready();
									}
								}
								if (this.infoShowTime > (float)num2)
								{
									this.UpdateInfo();
								}
							}
						}
					}
					float num7 = this.infoShowTime;
					if (num7 > (float)num2)
					{
						float num5 = num7;
						float deltaTime3 = Time.deltaTime;
						this.infoShowTime = num5;
						GameObject gameObject = this.info;
						int num8 = 0;
						gameObject.SetActive(num8 != 0);
					}
				}
			}
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x00124E04 File Offset: 0x00123004
		[Token(Token = "0x60036C7")]
		[Address(RVA = "0x7B82B0", Offset = "0x7B68B0", VA = "0x1807B82B0")]
		public void EnableInfo()
		{
			this.info.SetActive(true);
			this.UpdateInfo();
			this.infoShowTime = 5f;
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x00124E34 File Offset: 0x00123034
		[Token(Token = "0x60036C8")]
		[Address(RVA = "0x7B9380", Offset = "0x7B7980", VA = "0x1807B9380")]
		private void UpdateInfo()
		{
			long num = this.data.nextTime;
			long currentTime = this.CurrentTime;
			num -= currentTime;
			TextMeshPro textMeshPro = this.infoText;
			ulong num2;
			num2 += num2;
			long num3 = (long)(num2 * (ulong)((uint)60));
			num -= num3;
			object[] array = new object[5];
			ulong num4;
			num4 += num4;
			int num5 = this.data.waterLevel;
			if (num5 != 0)
			{
			}
			array[2] = num5;
			int growStage = this.data.growStage;
			num5 = growStage;
			if (growStage != 0)
			{
			}
			array[3] = num5;
			int love = this.data.love;
			num5 = love;
			if (love != 0)
			{
			}
			array[4] = num5;
			string text = string.Format("下一阶段：{0}分{1}秒\r\n当前水分：{2}/100\r\n当前成长阶段：{3}/2\r\n成长值：{4}/100", array);
			textMeshPro.text = text;
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x00124EF8 File Offset: 0x001230F8
		[Token(Token = "0x60036C9")]
		[Address(RVA = "0x7B8280", Offset = "0x7B6880", VA = "0x1807B8280")]
		private void DisableInfo()
		{
			GameObject gameObject = this.info;
			int num = 0;
			gameObject.SetActive(num != 0);
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x00124F1C File Offset: 0x0012311C
		[Token(Token = "0x60036CA")]
		[Address(RVA = "0x7B8110", Offset = "0x7B6710", VA = "0x1807B8110")]
		public void Die()
		{
			GardenUI instance = GardenUI.Instance;
			int num = 0;
			if (instance != num)
			{
				bool flag = GardenUI.Instance.gardenPlants.Remove(this);
			}
			Board instance2 = Board.Instance;
			int num2 = 0;
			if (instance2 != num2)
			{
				bool flag2 = Board.Instance.boardEntity.gardenPlants.Remove(this);
			}
			global::UnityEngine.Object.Destroy(base.gameObject);
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00124F88 File Offset: 0x00123188
		[Token(Token = "0x60036CB")]
		[Address(RVA = "0x7B8D00", Offset = "0x7B7300", VA = "0x1807B8D00")]
		public void SetBrightness(float b)
		{
			this.brightness = b;
			GameMaterial.SetBrightness(this.spriteRenderers, b);
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00124FA8 File Offset: 0x001231A8
		[Token(Token = "0x60036CC")]
		[Address(RVA = "0x7B8D80", Offset = "0x7B7380", VA = "0x1807B8D80")]
		public void SetColor(float r, float g, float b, float a)
		{
			ulong num3;
			do
			{
				int num = 0;
				List<SpriteRenderer> list = this.spriteRenderers;
				bool flag;
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
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00124FE4 File Offset: 0x001231E4
		[Token(Token = "0x60036CD")]
		[Address(RVA = "0x7B9290", Offset = "0x7B7890", VA = "0x1807B9290")]
		private void TimeUpdate()
		{
			long currentTime = this.CurrentTime;
			GardenPlantData gardenPlantData = this.data;
			if (currentTime > gardenPlantData.nextTime)
			{
				GardenUI instance = GardenUI.Instance;
				int num = 0;
				if (instance != num && GardenUI.Instance.plantOnWheel != this)
				{
					this.ready = true;
					this.Ready();
				}
			}
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00125040 File Offset: 0x00123240
		[Token(Token = "0x60036CE")]
		[Address(RVA = "0x7B8AC0", Offset = "0x7B70C0", VA = "0x1807B8AC0")]
		private void Ready()
		{
			GardenPlantData gardenPlantData = this.data;
			GardenToolType needTool = gardenPlantData.needTool;
			if (gardenPlantData == 0 || gardenPlantData == 0 || gardenPlantData == 0 || needTool == GardenToolType.WateringCan)
			{
			}
			Transform transform = this.axis;
			Vector3 vector;
			float z = vector.z;
			GameObject[] itemPrefab = GameAPP.itemPrefab;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject;
			this.Bubble = gameObject;
			Transform transform2 = this.Bubble.transform;
			Transform transform3 = base.transform;
			transform2.parentInternal = transform3;
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x001250BC File Offset: 0x001232BC
		[Token(Token = "0x60036CF")]
		[Address(RVA = "0x7B9940", Offset = "0x7B7F40", VA = "0x1807B9940")]
		public void Watered(GardenToolType tool)
		{
			GardenPlantData gardenPlantData = this.data;
			if (tool == gardenPlantData.needTool && this.ready)
			{
				uint num2;
				uint num3;
				int num = global::UnityEngine.Random.Range((int)num2, (int)num3);
				gardenPlantData.waterLevel = (int)num2;
				GardenPlantData gardenPlantData2 = this.data;
				long currentTime = this.CurrentTime;
				uint num5;
				uint num6;
				int num4 = global::UnityEngine.Random.Range((int)num5, (int)num6);
				num4 = (int)((long)num4 + currentTime);
				gardenPlantData2.nextTime = (long)num4;
				GardenPlantData gardenPlantData3 = this.data;
				gardenPlantData3.needTool = (GardenToolType)((ulong)1L);
				gardenPlantData3.waterLevel = (int)((ulong)100L);
				GardenPlantData gardenPlantData4 = this.data;
				if (gardenPlantData4.growStage < 2)
				{
					gardenPlantData4.needTool = (GardenToolType)((ulong)2L);
				}
				uint num8;
				int num7 = global::UnityEngine.Random.Range(0, (int)num8);
				GardenPlantData gardenPlantData5 = this.data;
				bool flag = num7 != 0;
				gardenPlantData5.needTool = (flag ? GardenToolType.WateringCan : GardenToolType.Default);
				Transform transform = this.axis;
				Transform transform2 = GardenUI.Instance.background.transform;
				global::UnityEngine.Object.Destroy(this.Bubble);
				this.ready = false;
				GardenUI.Data.Save("浇水");
			}
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x001251C8 File Offset: 0x001233C8
		[Token(Token = "0x60036D0")]
		[Address(RVA = "0x7B82F0", Offset = "0x7B68F0", VA = "0x1807B82F0")]
		public void Fertized(GardenToolType tool)
		{
			GardenPlantData gardenPlantData = this.data;
			if (tool == gardenPlantData.needTool && this.ready)
			{
				long currentTime = this.CurrentTime;
				uint num2;
				uint num3;
				int num = global::UnityEngine.Random.Range((int)num2, (int)num3);
				num = (int)((long)num + currentTime);
				gardenPlantData.nextTime = (long)num;
				GardenPlantData gardenPlantData2 = this.data;
				IEnumerator enumerator = this.Grow();
				Coroutine coroutine = base.StartCoroutine(enumerator);
				this.data.needTool = (GardenToolType)((ulong)1L);
				GardenPlantData gardenPlantData3 = this.data;
				int num4 = 0;
				gardenPlantData3.waterLevel = num4;
				global::UnityEngine.Object.Destroy(this.Bubble);
				Transform transform = this.axis;
				this.ready = num4 != 0;
				Transform transform2 = GardenUI.Instance.background.transform;
				GardenUI.Data.Save("施肥");
			}
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00125298 File Offset: 0x00123498
		[Token(Token = "0x60036D1")]
		[Address(RVA = "0x7B7F50", Offset = "0x7B6550", VA = "0x1807B7F50")]
		public void Develop(GardenToolType tool)
		{
			GardenPlantData gardenPlantData = this.data;
			if (tool == gardenPlantData.needTool && this.ready)
			{
				long currentTime = this.CurrentTime;
				uint num2;
				uint num3;
				int num = global::UnityEngine.Random.Range((int)num2, (int)num3);
				num = (int)((long)num + currentTime);
				gardenPlantData.nextTime = (long)num;
				this.Prize();
				this.data.needTool = (GardenToolType)((ulong)1L);
				GardenPlantData gardenPlantData2 = this.data;
				int num4 = 0;
				gardenPlantData2.waterLevel = num4;
				global::UnityEngine.Object.Destroy(this.Bubble);
				this.ready = num4 != 0;
				GardenUI.Data.Save("杀虫、音乐");
				Transform transform = this.axis;
				Transform transform2 = GardenUI.Instance.background.transform;
			}
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00125354 File Offset: 0x00123554
		[Token(Token = "0x60036D2")]
		[Address(RVA = "0x7B87C0", Offset = "0x7B6DC0", VA = "0x1807B87C0")]
		public void GrowUp()
		{
			GardenPlantData gardenPlantData = this.data;
			int num = 0;
			if (gardenPlantData.growStage < 2)
			{
				gardenPlantData.growStage = (int)((ulong)2L);
				GardenPlant.<Grow>d__40 <Grow>d__;
				<Grow>d__.System.IDisposable.Dispose();
				<Grow>d__.<>1__state = num;
				<Grow>d__.<>4__this = this;
				Coroutine coroutine = base.StartCoroutine(<Grow>d__);
			}
			GameObject bubble = this.Bubble;
			this.ready = num != 0;
			global::UnityEngine.Object.Destroy(bubble);
			this.data.needTool = (GardenToolType)((ulong)1L);
			this.data.waterLevel = num;
			GardenPlantData gardenPlantData2 = this.data;
			long currentTime = this.CurrentTime;
			uint num3;
			uint num4;
			int num2 = global::UnityEngine.Random.Range((int)num3, (int)num4);
			num2 = (int)((long)num2 + currentTime);
			gardenPlantData2.nextTime = (long)num2;
			this.data.love = (int)((ulong)100L);
			this.Prize();
			GardenUI.Data.Save("使用了超级肥料");
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x00125424 File Offset: 0x00123624
		[Token(Token = "0x60036D3")]
		[Address(RVA = "0x7B89B0", Offset = "0x7B6FB0", VA = "0x1807B89B0")]
		private void Prize()
		{
			GameAPP.PlaySound(66, 0.5f, 1f);
			GardenPlantData gardenPlantData = this.data;
			int num = global::UnityEngine.Random.Range(25, 36);
			gardenPlantData.love = 25;
			GardenPlantData gardenPlantData2 = this.data;
			if (gardenPlantData2.love > 100)
			{
				gardenPlantData2.love = (int)((ulong)100L);
				base.transform.Find("Glow").gameObject.SetActive(true);
			}
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x00125498 File Offset: 0x00123698
		[Token(Token = "0x60036D4")]
		[Address(RVA = "0x7B8940", Offset = "0x7B6F40", VA = "0x1807B8940")]
		private IEnumerator Grow()
		{
			GardenPlant.<Grow>d__40 <Grow>d__;
			<Grow>d__.System.IDisposable.Dispose();
			<Grow>d__.<>1__state = (int)((ulong)0L);
			<Grow>d__.<>4__this = this;
			return null;
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x001254BC File Offset: 0x001236BC
		[Token(Token = "0x60036D5")]
		[Address(RVA = "0x7B9B60", Offset = "0x7B8160", VA = "0x1807B9B60")]
		public GardenPlant()
		{
			List<SpriteRenderer> list = new List();
			this.spriteRenderers = list;
			base..ctor();
		}

		// Token: 0x04002A44 RID: 10820
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002A44")]
		public GardenPlantData data;

		// Token: 0x04002A45 RID: 10821
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002A45")]
		public bool ready;

		// Token: 0x04002A46 RID: 10822
		[FieldOffset(Offset = "0x29")]
		[Token(Token = "0x4002A46")]
		public bool preview;

		// Token: 0x04002A47 RID: 10823
		[FieldOffset(Offset = "0x2A")]
		[Token(Token = "0x4002A47")]
		public bool onWheelBarrow;

		// Token: 0x04002A48 RID: 10824
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002A48")]
		public float battleTimer;

		// Token: 0x04002A49 RID: 10825
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002A49")]
		public Vector2 plantScale;

		// Token: 0x04002A4A RID: 10826
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002A4A")]
		public GameObject plantObject;

		// Token: 0x04002A4B RID: 10827
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002A4B")]
		public Transform plantTargetAxis;

		// Token: 0x04002A4C RID: 10828
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002A4C")]
		public Transform plantAxis;

		// Token: 0x04002A4D RID: 10829
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002A4D")]
		public Transform axis;

		// Token: 0x04002A4E RID: 10830
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002A4E")]
		public Animator anim;

		// Token: 0x04002A4F RID: 10831
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002A4F")]
		public SortingGroup sortingGroup;

		// Token: 0x04002A50 RID: 10832
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002A50")]
		private GameObject info;

		// Token: 0x04002A51 RID: 10833
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002A51")]
		private TextMeshPro infoText;

		// Token: 0x04002A52 RID: 10834
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002A52")]
		private float timeUpdater;

		// Token: 0x04002A53 RID: 10835
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4002A53")]
		private float brightness;

		// Token: 0x04002A54 RID: 10836
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002A54")]
		private float infoShowTime;

		// Token: 0x04002A55 RID: 10837
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002A55")]
		private GameObject Bubble;

		// Token: 0x04002A56 RID: 10838
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002A56")]
		[SerializeField]
		private List<SpriteRenderer> spriteRenderers;
	}
}
