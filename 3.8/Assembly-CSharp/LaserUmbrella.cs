using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020003CF RID: 975
[Token(Token = "0x20003CF")]
public class LaserUmbrella : LanternUmbrella
{
	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060011D3 RID: 4563 RVA: 0x00064660 File Offset: 0x00062860
	[Token(Token = "0x170000EB")]
	private IEnumerable<LaserUmbrella.Channel> AllChannel
	{
		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x44BBE0", Offset = "0x44A1E0", VA = "0x18044BBE0")]
		get
		{
			List<LaserUmbrella.Channel> list = this.zombieChannels;
			return Enumerable.Concat<LaserUmbrella.Channel>(this.plantChannels, list);
		}
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x00064680 File Offset: 0x00062880
	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x4494C0", Offset = "0x447AC0", VA = "0x1804494C0")]
	private LaserUmbrella.Channel CreateChannel(LaserUmbrella.ChannelType channelType)
	{
		GameObject gameObject = this.theLightPrefab;
		Transform transform = Board.Instance.transform;
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<LineRenderer>().gameObject;
		LaserUmbrella.Channel channel;
		channel.plant = this;
		channel.gameObject = gameObject2;
		channel.channelType = channelType;
		LineRenderer component = channel.gameObject.GetComponent<LineRenderer>();
		channel.line = component;
		Transform transform2 = channel.line.transform;
		int num = 0;
		ParticleSystem component2 = transform2.GetChild(num).GetComponent<ParticleSystem>();
		channel.particle = component2;
		SortingGroup sortingGroup = channel.gameObject.AddComponent<SortingGroup>();
		channel.sortingGroup = sortingGroup;
		GameObject gameObject3 = channel.gameObject;
		int num2 = 0;
		gameObject3.SetActive(num2 != 0);
		if (channelType == LaserUmbrella.ChannelType.Plant)
		{
		}
		if (channelType == LaserUmbrella.ChannelType.Zombie)
		{
			List<LaserUmbrella.Channel> list = this.zombieChannels;
		}
		return channel;
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x00064754 File Offset: 0x00062954
	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x44AA00", Offset = "0x449000", VA = "0x18044AA00", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		bool flag;
		if (flag)
		{
			num += num;
			this.maxEnergy = num;
		}
		int num2 = 0;
		LaserUmbrella.Channel channel = this.CreateChannel((LaserUmbrella.ChannelType)num2);
		while (flag)
		{
		}
		while (flag)
		{
		}
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x0006478C File Offset: 0x0006298C
	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x44B4A0", Offset = "0x449AA0", VA = "0x18044B4A0", Slot = "16")]
	protected override void Update()
	{
		int num;
		List<Zombie> list;
		bool flag3;
		for (;;)
		{
			num = 0;
			base.Update();
			Transform transform = this.lanternLight.transform;
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			float recoverEnergyTimer = this.recoverEnergyTimer;
			float deltaTime = Time.deltaTime;
			this.recoverEnergyTimer = recoverEnergyTimer;
			this.recoverEnergyTimer = 1f;
			bool flag;
			if (flag)
			{
			}
			int num2 = this.shootingLevel;
			num2++;
			int num3 = this.theLevel;
			num3++;
			long num5;
			int num4 = (int)((long)(num2 * num3) * num5);
			base.UseEnergy(num4);
			Animator anim = this.anim;
			float speed = anim.speed;
			if (anim == 0)
			{
				break;
			}
			float deltaTime2 = Time.deltaTime;
			list = new List();
			bool flag2;
			if (flag2)
			{
				int num6 = 0;
				flag3 = num != num6;
				while (!flag3)
				{
				}
			}
			if (num == 0)
			{
				goto Block_6;
			}
		}
		List<LaserUmbrella.Channel> list2 = this.zombieChannels;
		IEnumerable<LaserUmbrella.Channel> enumerable = Enumerable.Concat<LaserUmbrella.Channel>(this.plantChannels, list2);
		if (enumerable != 0)
		{
			if (num < typeof(IEnumerator).TypeHandle)
			{
				num += num;
				if (num == typeof(IEnumerator).TypeHandle)
				{
					goto IL_00D1;
				}
				num++;
			}
			int num7 = 0;
			IL_00D1:
			enumerable += enumerable;
			num7 += 312;
		}
		if ("{il2cpp array field local34->}" != (ulong)0L)
		{
		}
		if (num == 0)
		{
			return;
		}
		throw new NullReferenceException();
		Block_6:
		Transform axis2 = list[flag3 ? 1 : 0].axis;
		throw new NullReferenceException();
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x000648F8 File Offset: 0x00062AF8
	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x44A0A0", Offset = "0x4486A0", VA = "0x18044A0A0", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		int num = 0;
		base.OnFixedUpdate();
		bool flag;
		if (flag)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num2 = this.zombieLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag2;
				bool flag3;
				if (flag2 && Lawnf.InUpStatus((ZombieStatus)num) && flag3)
				{
					uint num3;
					base.UseEnergy((int)num3);
				}
				num++;
			}
		}
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x00064960 File Offset: 0x00062B60
	[Token(Token = "0x60011D8")]
	[Address(RVA = "0x449720", Offset = "0x447D20", VA = "0x180449720", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num;
		do
		{
			num = 0;
			CreatePlant instance = CreatePlant.Instance;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			uint num2;
			ulong num3;
			instance.AdjustLightLevel(thePlantColumn, thePlantRow, (int)num2, (int)num3);
			global::UnityEngine.Object.Destroy(this.lanternLight);
			List<LaserUmbrella.Channel> list = this.zombieChannels;
			if (Enumerable.Concat<LaserUmbrella.Channel>(this.plantChannels, list) != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_005F;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_005F;
				}
				IL_0062:
				int num4;
				num4 += 312;
				goto IL_006C;
				IL_005F:
				num4 = 0;
				goto IL_0062;
			}
			IL_006C:
			if ("{il2cpp array field local14->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x000649FC File Offset: 0x00062BFC
	[Token(Token = "0x60011D9")]
	[Address(RVA = "0x449AC0", Offset = "0x4480C0", VA = "0x180449AC0")]
	private void Explode(Vector2 position, int row)
	{
		int num = 0;
		LayerMask zombieLayer = this.zombieLayer;
		bool flag;
		if (flag)
		{
		}
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag2;
			if (flag2)
			{
				num -= row;
				PlantType thePlantType = this.thePlantType;
			}
			num++;
		}
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x00064A54 File Offset: 0x00062C54
	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x44A310", Offset = "0x448910", VA = "0x18044A310", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		this.AttackZombie();
		this.SearchZombieUpdate();
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x00064A90 File Offset: 0x00062C90
	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x44A680", Offset = "0x448C80", VA = "0x18044A680")]
	private void SearchZombieUpdate()
	{
		int num;
		do
		{
			num = 0;
			Func<Zombie, bool> func;
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(Lawnf.GetAllZombies(false), func);
			Func<Zombie, bool> <>9__20_ = LaserUmbrella.<>c.<>9__20_1;
			if (<>9__20_ == 0)
			{
				Func<Zombie, bool> func2;
				LaserUmbrella.<>c.<>9__20_1 = func2;
			}
			Func<Zombie, float> func3;
			if (Enumerable.ThenBy<Zombie, float>(Enumerable.OrderBy<Zombie, bool>(enumerable, <>9__20_), func3) != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num == typeof(IEnumerator).TypeHandle)
					{
						goto IL_004E;
					}
					num++;
				}
				bool flag;
				while (flag)
				{
				}
				IL_004E:
				flag += flag;
			}
			if ("{il2cpp array field local17->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x00064B10 File Offset: 0x00062D10
	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x448B70", Offset = "0x447170", VA = "0x180448B70")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled)
		{
			Collider2D col = zombie.col;
			int num = 0;
			if (!(col == num) && zombie.theHealth > 0)
			{
				int theZombieRow = zombie.theZombieRow;
				ZombieStatus theStatus = zombie.theStatus;
				if (theStatus == ZombieStatus.Miner_digging || theStatus != ZombieStatus.Boss)
				{
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00064B64 File Offset: 0x00062D64
	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x4487D0", Offset = "0x446DD0", VA = "0x1804487D0")]
	private void AttackZombie()
	{
		int num2;
		PlantType thePlantType;
		do
		{
			int num = this.attackDamage;
			bool flag;
			if (flag)
			{
			}
			Board board = this.board;
			num += board;
			List<LaserUmbrella.Channel> list = this.zombieChannels;
			num2 = 0;
			bool flag2;
			if (flag2)
			{
				bool flag3;
				while (!flag3)
				{
				}
				thePlantType = this.thePlantType;
			}
		}
		while (num2 != 0);
		ulong num3;
		if (num3 != (ulong)0L)
		{
			GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		}
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x00064BE4 File Offset: 0x00062DE4
	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x44AB40", Offset = "0x449140", VA = "0x18044AB40")]
	private void UpdateLight()
	{
		int num5;
		do
		{
			Transform shoot = this.shoot;
			Vector3 vector;
			float z = vector.z;
			GameObject gameObject = this.lightBall;
			int num = 0;
			if (gameObject != num)
			{
				Transform transform = this.lightBall.transform;
				Vector3 vector2;
				float z2 = vector2.z;
			}
			List<LaserUmbrella.Channel> list = this.zombieChannels;
			int num2 = 0;
			int num3 = 0;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				bool flag2;
				if (flag2 && this.CheckZombie(num4))
				{
					float deltaTime = Time.deltaTime;
					if (num3 > (int)deltaTime || deltaTime > 1f)
					{
					}
					int thePlantRow = this.thePlantRow;
					string text = string.Format("particle{0}", thePlantRow);
				}
			}
			if (num2 != 0)
			{
				goto IL_0139;
			}
			num5 = 0;
			int num6 = 0;
			bool flag3;
			if (flag3)
			{
				bool flag4;
				bool flag5;
				if (flag4 && flag5)
				{
					float deltaTime2 = Time.deltaTime;
					if (num6 > (int)deltaTime2 || deltaTime2 > 1f)
					{
					}
					Transform transform2;
					string text2 = string.Format("particle{0}", transform2);
				}
			}
		}
		while (num5 != 0);
		return;
		IL_0139:
		throw new NullReferenceException();
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x00064D74 File Offset: 0x00062F74
	[Token(Token = "0x60011DF")]
	[Address(RVA = "0x448500", Offset = "0x446B00", VA = "0x180448500")]
	private bool AddZombie(Zombie zombie)
	{
		int num;
		bool flag;
		do
		{
			List<LaserUmbrella.Channel> list = this.zombieChannels;
			num = 0;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num != 0);
		int num2 = 0;
		bool flag3;
		if (flag3)
		{
		}
		uint num3;
		if (num3 < (flag ? 1U : 0U))
		{
			flag3 = flag;
			flag3 = (flag3 ? 1U : 0U) - num3 != 0U;
			if (flag3 > false)
			{
				while (flag3)
				{
				}
			}
		}
		LaserUmbrella.Channel channel;
		if (num2 < channel.gameObject)
		{
			if (num2 < (flag ? 1 : 0))
			{
				LaserUmbrella.Channel channel2;
				Zombie targetZombie = channel2.targetZombie;
				int num4 = 0;
				if (targetZombie == num4)
				{
					goto IL_006F;
				}
			}
			num2++;
			IL_006F:
			LaserUmbrella.Channel channel3;
			channel3.targetZombie = 0;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x00064E00 File Offset: 0x00063000
	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x449CD0", Offset = "0x4482D0", VA = "0x180449CD0")]
	private void HealUpdate()
	{
		int num6;
		do
		{
			int num = 0;
			float num2 = this.healTimer;
			float deltaTime = Time.deltaTime;
			this.healTimer = num2;
			int num3 = 0;
			bool flag;
			if (flag)
			{
				float num4 = this.healTimer;
				float deltaTime2 = Time.deltaTime;
				this.healTimer = num4;
			}
			if (0 <= (int)this.healTimer)
			{
				break;
			}
			this.healTimer = 2f;
			num3 += num3;
			List<LaserUmbrella.Channel> list = this.plantChannels;
			int num5 = 0;
			bool flag2;
			if (flag2)
			{
				num += 40;
			}
			if (num5 != 0)
			{
				goto IL_00B1;
			}
			num6 = 0;
			bool flag3;
			if (flag3)
			{
				bool flag4;
				while (!flag4)
				{
				}
				int currentLightLevel = this.currentLightLevel;
				int num7 = 0;
				num7 += num7;
				base.UseEnergy(num7);
			}
		}
		while (num6 != 0);
		return;
		IL_00B1:
		throw new NullReferenceException();
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x00064ECC File Offset: 0x000630CC
	[Token(Token = "0x60011E1")]
	[Address(RVA = "0x44A390", Offset = "0x448990", VA = "0x18044A390")]
	private void SearchPlant()
	{
		int num;
		do
		{
			num = 0;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			Func<Plant, float> <>9__26_ = LaserUmbrella.<>c.<>9__26_0;
			if (<>9__26_ == 0)
			{
				Func<Plant, float> func;
				LaserUmbrella.<>c.<>9__26_0 = func;
			}
			if (Enumerable.OrderBy<Plant, float>(list, <>9__26_) != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num == typeof(IEnumerator).TypeHandle)
					{
						goto IL_0053;
					}
					num++;
				}
				bool flag;
				while (!flag)
				{
				}
				bool flag2;
				while (flag2)
				{
				}
				IL_0053:
				flag2 += flag2;
			}
			if ("{il2cpp array field local12->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x00064F50 File Offset: 0x00063150
	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x448A80", Offset = "0x447080", VA = "0x180448A80")]
	private bool CheckPlant(Plant plant)
	{
		int thePlantMaxHealth = plant.thePlantMaxHealth;
		if (plant.thePlantHealth < thePlantMaxHealth)
		{
			int thePlantColumn = plant.thePlantColumn;
			return plant.thePlantRow <= 1;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00064F8C File Offset: 0x0006318C
	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x448280", Offset = "0x446880", VA = "0x180448280")]
	private bool AddPlant(Plant plant)
	{
		int num;
		do
		{
			List<LaserUmbrella.Channel> list = this.plantChannels;
			num = 0;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num != 0);
		int num2 = 0;
		if (num2 < 2)
		{
			LaserUmbrella.Channel channel;
			Plant targetPlant = channel.targetPlant;
			int num3 = 0;
			if (targetPlant == num3)
			{
				goto IL_0043;
			}
		}
		num2++;
		IL_0043:
		LaserUmbrella.Channel channel2;
		channel2.targetPlant = 0;
		return true;
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00064FF0 File Offset: 0x000631F0
	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x448C80", Offset = "0x447280", VA = "0x180448C80", Slot = "49")]
	public override void Connected(Plant plant)
	{
		int num;
		do
		{
			num = 0;
			base.Connected(plant);
			if (this.connectPlant.TryGetComponent<LaserUmbrella>(num))
			{
				int num2 = 0;
				if (plant == num2)
				{
					GameObject gameObject = this.ballPrefab;
					Transform transform = this.board.transform;
					GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
					this.lightBall = gameObject2;
					GameObject gameObject3 = this.lightBall;
					num += 624;
					Transform transform2 = this.lightBall.transform;
					Transform axis = this.axis;
					SortingGroup sortingGroup = this.lightBall.AddComponent<SortingGroup>();
					int thePlantRow = this.thePlantRow;
					int num3;
					string text = string.Format("particle{0}", num3);
					sortingGroup.sortingLayerName = text;
					GameObject gameObject4 = this.theLightPrefab;
					Transform transform3 = this.board.transform;
					LineRenderer component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject4, transform3).GetComponent<LineRenderer>();
					GameObject gameObject5 = this.theLightPrefab;
					Transform transform4 = this.board.transform;
					LineRenderer component2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject5, transform4).GetComponent<LineRenderer>();
					Transform transform5 = component.transform;
					int num4 = 0;
					GameObject gameObject6 = transform5.GetChild(num4).gameObject;
					int num5 = 0;
					gameObject6.SetActive(num5 != 0);
					Transform transform6 = component2.transform;
					int num6 = 0;
					GameObject gameObject7 = transform6.GetChild(num6).gameObject;
					int num7 = 0;
					gameObject7.SetActive(num7 != 0);
					Transform transform7 = this.lightBall.transform;
					Vector3 vector;
					float z = vector.z;
					Transform shoot = this.shoot;
					Vector3 vector2;
					float z2 = vector2.z;
					Transform transform8 = this.lightBall.transform;
					Vector3 vector3;
					float z3 = vector3.z;
					Vector3 vector4;
					float z4 = vector4.z;
					Transform transform9 = component.transform;
					Transform transform10 = this.lightBall.transform;
					transform9.parentInternal = transform10;
					Transform transform11 = component2.transform;
					Transform transform12 = this.lightBall.transform;
					transform11.parentInternal = transform12;
					this.main = true;
				}
			}
			List<LaserUmbrella.Channel> list = this.zombieChannels;
			IEnumerable<LaserUmbrella.Channel> enumerable = Enumerable.Concat<LaserUmbrella.Channel>(this.plantChannels, list);
			if (enumerable != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_01F8;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_01F8;
				}
				IL_0208:
				enumerable += enumerable;
				uint num8;
				num8 += (uint)312;
				goto IL_021A;
				IL_01F8:
				float z5 = this.startPos.z;
				goto IL_0208;
			}
			IL_021A:
			if ("{il2cpp array field local106->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00065230 File Offset: 0x00063430
	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x4499E0", Offset = "0x447FE0", VA = "0x1804499E0", Slot = "50")]
	public override void DisConnected()
	{
		GameObject gameObject = this.lightBall;
		int num = 0;
		if (gameObject != num)
		{
			global::UnityEngine.Object.Destroy(this.lightBall);
			this.lightBall = (ulong)0L;
		}
		base.DisConnected();
		Animator anim = this.anim;
		int num2 = 0;
		anim.SetBool("connect", num2 != 0);
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00065288 File Offset: 0x00063488
	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x44BB10", Offset = "0x44A110", VA = "0x18044BB10")]
	public LaserUmbrella()
	{
		List<LaserUmbrella.Channel> list = new List();
		this.zombieChannels = list;
		List<LaserUmbrella.Channel> list2 = new List();
		this.plantChannels = list2;
		this.maxTarget = (int)((ulong)4L);
		this.recoverEnergyTimer = 1f;
		this.maxEnergy = (int)((ulong)2000L);
		base..ctor();
	}

	// Token: 0x04000BD3 RID: 3027
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000BD3")]
	[SerializeField]
	private List<LaserUmbrella.Channel> zombieChannels;

	// Token: 0x04000BD4 RID: 3028
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000BD4")]
	[SerializeField]
	private List<LaserUmbrella.Channel> plantChannels;

	// Token: 0x04000BD5 RID: 3029
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4000BD5")]
	public GameObject theLightPrefab;

	// Token: 0x04000BD6 RID: 3030
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000BD6")]
	public GameObject ballPrefab;

	// Token: 0x04000BD7 RID: 3031
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000BD7")]
	public GameObject lightBall;

	// Token: 0x04000BD8 RID: 3032
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000BD8")]
	public bool main;

	// Token: 0x04000BD9 RID: 3033
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4000BD9")]
	public int maxTarget;

	// Token: 0x04000BDA RID: 3034
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000BDA")]
	private float explodeTimer;

	// Token: 0x04000BDB RID: 3035
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4000BDB")]
	private float healTimer;

	// Token: 0x020003D0 RID: 976
	[Token(Token = "0x20003D0")]
	public enum ChannelType
	{
		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4000BDD")]
		Plant,
		// Token: 0x04000BDE RID: 3038
		[Token(Token = "0x4000BDE")]
		Zombie
	}

	// Token: 0x020003D1 RID: 977
	[Token(Token = "0x20003D1")]
	[Serializable]
	public class Channel
	{
		// Token: 0x060011E9 RID: 4585 RVA: 0x0006531C File Offset: 0x0006351C
		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x442D00", Offset = "0x441300", VA = "0x180442D00")]
		public Channel(LaserUmbrella plant, GameObject gameObject, LaserUmbrella.ChannelType channelType)
		{
			this.plant = plant;
			this.gameObject = gameObject;
			this.channelType = channelType;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00065348 File Offset: 0x00063548
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x442C20", Offset = "0x441220", VA = "0x180442C20")]
		public void InitChannel()
		{
			LineRenderer component = this.gameObject.GetComponent<LineRenderer>();
			this.line = component;
			Transform transform = this.line.transform;
			int num = 0;
			ParticleSystem component2 = transform.GetChild(num).GetComponent<ParticleSystem>();
			this.particle = component2;
			SortingGroup sortingGroup = this.gameObject.AddComponent<SortingGroup>();
			this.sortingGroup = sortingGroup;
			throw new NullReferenceException();
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000653A4 File Offset: 0x000635A4
		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x442BD0", Offset = "0x4411D0", VA = "0x180442BD0")]
		public void Die()
		{
			global::UnityEngine.Object.Destroy(this.gameObject);
		}

		// Token: 0x04000BDF RID: 3039
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BDF")]
		public LaserUmbrella plant;

		// Token: 0x04000BE0 RID: 3040
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BE0")]
		public GameObject gameObject;

		// Token: 0x04000BE1 RID: 3041
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BE1")]
		public Zombie targetZombie;

		// Token: 0x04000BE2 RID: 3042
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BE2")]
		public Plant targetPlant;

		// Token: 0x04000BE3 RID: 3043
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BE3")]
		public LineRenderer line;

		// Token: 0x04000BE4 RID: 3044
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BE4")]
		public ParticleSystem particle;

		// Token: 0x04000BE5 RID: 3045
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BE5")]
		public SortingGroup sortingGroup;

		// Token: 0x04000BE6 RID: 3046
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000BE6")]
		public LaserUmbrella.ChannelType channelType;
	}
}
