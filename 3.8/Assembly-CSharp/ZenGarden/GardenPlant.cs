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
	// Token: 0x02000A25 RID: 2597
	[Token(Token = "0x2000A25")]
	public class GardenPlant : MonoBehaviour
	{
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x0011F6A4 File Offset: 0x0011D8A4
		[Token(Token = "0x1700023C")]
		public long CurrentTime
		{
			[Token(Token = "0x600357D")]
			[Address(RVA = "0x753050", Offset = "0x751650", VA = "0x180753050")]
			get
			{
				DateTime utcNow = DateTime.UtcNow;
				return 0L;
			}
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x0011F6C0 File Offset: 0x0011D8C0
		[Token(Token = "0x600357E")]
		[Address(RVA = "0x7511C0", Offset = "0x74F7C0", VA = "0x1807511C0")]
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

		// Token: 0x0600357F RID: 13695 RVA: 0x0011F790 File Offset: 0x0011D990
		[Token(Token = "0x600357F")]
		[Address(RVA = "0x7523C0", Offset = "0x7509C0", VA = "0x1807523C0")]
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

		// Token: 0x06003580 RID: 13696 RVA: 0x0011F898 File Offset: 0x0011DA98
		[Token(Token = "0x6003580")]
		[Address(RVA = "0x751AB0", Offset = "0x7500B0", VA = "0x180751AB0")]
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

		// Token: 0x06003581 RID: 13697 RVA: 0x0011F8F4 File Offset: 0x0011DAF4
		[Token(Token = "0x6003581")]
		[Address(RVA = "0x7513D0", Offset = "0x74F9D0", VA = "0x1807513D0")]
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

		// Token: 0x06003582 RID: 13698 RVA: 0x0011F928 File Offset: 0x0011DB28
		[Token(Token = "0x6003582")]
		[Address(RVA = "0x751C10", Offset = "0x750210", VA = "0x180751C10")]
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

		// Token: 0x06003583 RID: 13699 RVA: 0x0011FA10 File Offset: 0x0011DC10
		[Token(Token = "0x6003583")]
		[Address(RVA = "0x752B20", Offset = "0x751120", VA = "0x180752B20")]
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

		// Token: 0x06003584 RID: 13700 RVA: 0x0011FB68 File Offset: 0x0011DD68
		[Token(Token = "0x6003584")]
		[Address(RVA = "0x751860", Offset = "0x74FE60", VA = "0x180751860")]
		public void EnableInfo()
		{
			this.info.SetActive(true);
			this.UpdateInfo();
			this.infoShowTime = 5f;
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x0011FB98 File Offset: 0x0011DD98
		[Token(Token = "0x6003585")]
		[Address(RVA = "0x7527F0", Offset = "0x750DF0", VA = "0x1807527F0")]
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

		// Token: 0x06003586 RID: 13702 RVA: 0x0011FC5C File Offset: 0x0011DE5C
		[Token(Token = "0x6003586")]
		[Address(RVA = "0x751830", Offset = "0x74FE30", VA = "0x180751830")]
		private void DisableInfo()
		{
			GameObject gameObject = this.info;
			int num = 0;
			gameObject.SetActive(num != 0);
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x0011FC80 File Offset: 0x0011DE80
		[Token(Token = "0x6003587")]
		[Address(RVA = "0x7516C0", Offset = "0x74FCC0", VA = "0x1807516C0")]
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

		// Token: 0x06003588 RID: 13704 RVA: 0x0011FCEC File Offset: 0x0011DEEC
		[Token(Token = "0x6003588")]
		[Address(RVA = "0x752170", Offset = "0x750770", VA = "0x180752170")]
		public void SetBrightness(float b)
		{
			this.brightness = b;
			GameMaterial.SetBrightness(this.spriteRenderers, b);
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x0011FD0C File Offset: 0x0011DF0C
		[Token(Token = "0x6003589")]
		[Address(RVA = "0x7521F0", Offset = "0x7507F0", VA = "0x1807521F0")]
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

		// Token: 0x0600358A RID: 13706 RVA: 0x0011FD48 File Offset: 0x0011DF48
		[Token(Token = "0x600358A")]
		[Address(RVA = "0x752700", Offset = "0x750D00", VA = "0x180752700")]
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

		// Token: 0x0600358B RID: 13707 RVA: 0x0011FDA4 File Offset: 0x0011DFA4
		[Token(Token = "0x600358B")]
		[Address(RVA = "0x751F30", Offset = "0x750530", VA = "0x180751F30")]
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

		// Token: 0x0600358C RID: 13708 RVA: 0x0011FE20 File Offset: 0x0011E020
		[Token(Token = "0x600358C")]
		[Address(RVA = "0x752DB0", Offset = "0x7513B0", VA = "0x180752DB0")]
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

		// Token: 0x0600358D RID: 13709 RVA: 0x0011FF2C File Offset: 0x0011E12C
		[Token(Token = "0x600358D")]
		[Address(RVA = "0x7518A0", Offset = "0x74FEA0", VA = "0x1807518A0")]
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
				GardenPlant.<Grow>d__39 <Grow>d__;
				<Grow>d__.System.IDisposable.Dispose();
				int num4 = 0;
				<Grow>d__.<>4__this = this;
				<Grow>d__.<>1__state = num4;
				Coroutine coroutine = base.StartCoroutine(<Grow>d__);
				this.data.needTool = (GardenToolType)((ulong)1L);
				this.data.waterLevel = num4;
				global::UnityEngine.Object.Destroy(this.Bubble);
				Transform transform = this.axis;
				this.ready = num4 != 0;
				Transform transform2 = GardenUI.Instance.background.transform;
				GardenUI.Data.Save("施肥");
			}
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x00120008 File Offset: 0x0011E208
		[Token(Token = "0x600358E")]
		[Address(RVA = "0x751420", Offset = "0x74FA20", VA = "0x180751420")]
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
				uint num4;
				GameAPP.PlaySound((int)num4, 0.5f, 1f);
				GardenPlantData gardenPlantData2 = this.data;
				uint num6;
				uint num7;
				int num5 = global::UnityEngine.Random.Range((int)num6, (int)num7);
				gardenPlantData2.love = (int)num6;
				GardenPlantData gardenPlantData3 = this.data;
				if (gardenPlantData3.love > 100)
				{
					gardenPlantData3.love = (int)((ulong)100L);
					ulong num8;
					base.transform.Find("Glow").gameObject.SetActive(num8 != 0UL);
				}
				this.data.needTool = (GardenToolType)((ulong)1L);
				GardenPlantData gardenPlantData4 = this.data;
				int num9 = 0;
				gardenPlantData4.waterLevel = num9;
				global::UnityEngine.Object.Destroy(this.Bubble);
				this.ready = num9 != 0;
				GardenUI.Data.Save("杀虫、音乐");
				Transform transform = this.axis;
				Transform transform2 = GardenUI.Instance.background.transform;
			}
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x00120124 File Offset: 0x0011E324
		[Token(Token = "0x600358F")]
		[Address(RVA = "0x751E20", Offset = "0x750420", VA = "0x180751E20")]
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

		// Token: 0x06003590 RID: 13712 RVA: 0x00120198 File Offset: 0x0011E398
		[Token(Token = "0x6003590")]
		[Address(RVA = "0x751DB0", Offset = "0x7503B0", VA = "0x180751DB0")]
		private IEnumerator Grow()
		{
			GardenPlant.<Grow>d__39 <Grow>d__;
			<Grow>d__.System.IDisposable.Dispose();
			<Grow>d__.<>1__state = (int)((ulong)0L);
			<Grow>d__.<>4__this = this;
			return null;
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x001201BC File Offset: 0x0011E3BC
		[Token(Token = "0x6003591")]
		[Address(RVA = "0x752FD0", Offset = "0x7515D0", VA = "0x180752FD0")]
		public GardenPlant()
		{
			List<SpriteRenderer> list = new List();
			this.spriteRenderers = list;
			base..ctor();
		}

		// Token: 0x040028D1 RID: 10449
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40028D1")]
		public GardenPlantData data;

		// Token: 0x040028D2 RID: 10450
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40028D2")]
		public bool ready;

		// Token: 0x040028D3 RID: 10451
		[FieldOffset(Offset = "0x29")]
		[Token(Token = "0x40028D3")]
		public bool preview;

		// Token: 0x040028D4 RID: 10452
		[FieldOffset(Offset = "0x2A")]
		[Token(Token = "0x40028D4")]
		public bool onWheelBarrow;

		// Token: 0x040028D5 RID: 10453
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40028D5")]
		public float battleTimer;

		// Token: 0x040028D6 RID: 10454
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40028D6")]
		public Vector2 plantScale;

		// Token: 0x040028D7 RID: 10455
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40028D7")]
		public GameObject plantObject;

		// Token: 0x040028D8 RID: 10456
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40028D8")]
		public Transform plantTargetAxis;

		// Token: 0x040028D9 RID: 10457
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40028D9")]
		public Transform plantAxis;

		// Token: 0x040028DA RID: 10458
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40028DA")]
		public Transform axis;

		// Token: 0x040028DB RID: 10459
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40028DB")]
		public Animator anim;

		// Token: 0x040028DC RID: 10460
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40028DC")]
		public SortingGroup sortingGroup;

		// Token: 0x040028DD RID: 10461
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40028DD")]
		private GameObject info;

		// Token: 0x040028DE RID: 10462
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40028DE")]
		private TextMeshPro infoText;

		// Token: 0x040028DF RID: 10463
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40028DF")]
		private float timeUpdater;

		// Token: 0x040028E0 RID: 10464
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x40028E0")]
		private float brightness;

		// Token: 0x040028E1 RID: 10465
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40028E1")]
		private float infoShowTime;

		// Token: 0x040028E2 RID: 10466
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40028E2")]
		private GameObject Bubble;

		// Token: 0x040028E3 RID: 10467
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40028E3")]
		[SerializeField]
		private List<SpriteRenderer> spriteRenderers;
	}
}
