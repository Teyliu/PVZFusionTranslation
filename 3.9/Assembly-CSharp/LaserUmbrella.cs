using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020003E3 RID: 995
[Token(Token = "0x20003E3")]
public class LaserUmbrella : LanternUmbrella
{
	// Token: 0x1700012E RID: 302
	// (get) Token: 0x0600122F RID: 4655 RVA: 0x00065C78 File Offset: 0x00063E78
	[Token(Token = "0x1700012E")]
	private IEnumerable<LaserUmbrella.Channel> AllChannel
	{
		[Token(Token = "0x600122F")]
		[Address(RVA = "0x4A00E0", Offset = "0x49E6E0", VA = "0x1804A00E0")]
		get
		{
			List<LaserUmbrella.Channel> list = this.zombieChannels;
			return Enumerable.Concat<LaserUmbrella.Channel>(this.plantChannels, list);
		}
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x00065C98 File Offset: 0x00063E98
	[Token(Token = "0x6001230")]
	[Address(RVA = "0x49D950", Offset = "0x49BF50", VA = "0x18049D950")]
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

	// Token: 0x06001231 RID: 4657 RVA: 0x00065D6C File Offset: 0x00063F6C
	[Token(Token = "0x6001231")]
	[Address(RVA = "0x49EEA0", Offset = "0x49D4A0", VA = "0x18049EEA0", Slot = "15")]
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

	// Token: 0x06001232 RID: 4658 RVA: 0x00065DA4 File Offset: 0x00063FA4
	[Token(Token = "0x6001232")]
	[Address(RVA = "0x49F9A0", Offset = "0x49DFA0", VA = "0x18049F9A0", Slot = "16")]
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

	// Token: 0x06001233 RID: 4659 RVA: 0x00065F10 File Offset: 0x00064110
	[Token(Token = "0x6001233")]
	[Address(RVA = "0x49E530", Offset = "0x49CB30", VA = "0x18049E530", Slot = "18")]
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
				ulong num3;
				if (flag2 && Lawnf.InUpStatus((ZombieStatus)num) && num3 != (ulong)0L)
				{
					uint num4;
					base.UseEnergy((int)num4);
				}
				num++;
			}
		}
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x00065F78 File Offset: 0x00064178
	[Token(Token = "0x6001234")]
	[Address(RVA = "0x49DBB0", Offset = "0x49C1B0", VA = "0x18049DBB0", Slot = "52")]
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

	// Token: 0x06001235 RID: 4661 RVA: 0x00066014 File Offset: 0x00064214
	[Token(Token = "0x6001235")]
	[Address(RVA = "0x49DF50", Offset = "0x49C550", VA = "0x18049DF50")]
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
			uint num2;
			if (num2.TryGetComponent<Zombie>(num))
			{
				num -= row;
				PlantType thePlantType = this.thePlantType;
			}
			num++;
		}
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x00066070 File Offset: 0x00064270
	[Token(Token = "0x6001236")]
	[Address(RVA = "0x49E7B0", Offset = "0x49CDB0", VA = "0x18049E7B0", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		this.AttackZombie();
		this.SearchZombieUpdate();
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x000660AC File Offset: 0x000642AC
	[Token(Token = "0x6001237")]
	[Address(RVA = "0x49EB20", Offset = "0x49D120", VA = "0x18049EB20")]
	private void SearchZombieUpdate()
	{
		int num;
		do
		{
			num = 0;
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			Func<Zombie, bool> func = (Zombie z) => this.CheckZombie(z);
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(allZombies, func);
			Func<Zombie, bool> <>9__20_ = LaserUmbrella.<>c.<>9__20_1;
			if (<>9__20_ == 0)
			{
				LaserUmbrella.<>c.<>9__20_1 = (Zombie z) => z.theStatus != ZombieStatus.Flying;
			}
			Func<Zombie, float> func2;
			if (Enumerable.ThenBy<Zombie, float>(Enumerable.OrderBy<Zombie, bool>(enumerable, <>9__20_), func2) != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num == typeof(IEnumerator).TypeHandle)
					{
						goto IL_006E;
					}
					num++;
				}
				bool flag;
				while (flag)
				{
				}
				IL_006E:
				flag += flag;
			}
			if ("{il2cpp array field local17->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06001238 RID: 4664 RVA: 0x0006614C File Offset: 0x0006434C
	[Token(Token = "0x6001238")]
	[Address(RVA = "0x49D000", Offset = "0x49B600", VA = "0x18049D000")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled)
		{
			Collider2D col = zombie.col;
			int num = 0;
			if (!(col == num))
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

	// Token: 0x06001239 RID: 4665 RVA: 0x00066198 File Offset: 0x00064398
	[Token(Token = "0x6001239")]
	[Address(RVA = "0x49CC60", Offset = "0x49B260", VA = "0x18049CC60")]
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

	// Token: 0x0600123A RID: 4666 RVA: 0x00066218 File Offset: 0x00064418
	[Token(Token = "0x600123A")]
	[Address(RVA = "0x49F040", Offset = "0x49D640", VA = "0x18049F040")]
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

	// Token: 0x0600123B RID: 4667 RVA: 0x000663A8 File Offset: 0x000645A8
	[Token(Token = "0x600123B")]
	[Address(RVA = "0x49C990", Offset = "0x49AF90", VA = "0x18049C990")]
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

	// Token: 0x0600123C RID: 4668 RVA: 0x00066434 File Offset: 0x00064634
	[Token(Token = "0x600123C")]
	[Address(RVA = "0x49E160", Offset = "0x49C760", VA = "0x18049E160")]
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

	// Token: 0x0600123D RID: 4669 RVA: 0x00066500 File Offset: 0x00064700
	[Token(Token = "0x600123D")]
	[Address(RVA = "0x49E830", Offset = "0x49CE30", VA = "0x18049E830")]
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

	// Token: 0x0600123E RID: 4670 RVA: 0x00066584 File Offset: 0x00064784
	[Token(Token = "0x600123E")]
	[Address(RVA = "0x49CF10", Offset = "0x49B510", VA = "0x18049CF10")]
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

	// Token: 0x0600123F RID: 4671 RVA: 0x000665C0 File Offset: 0x000647C0
	[Token(Token = "0x600123F")]
	[Address(RVA = "0x49C710", Offset = "0x49AD10", VA = "0x18049C710")]
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

	// Token: 0x06001240 RID: 4672 RVA: 0x00066624 File Offset: 0x00064824
	[Token(Token = "0x6001240")]
	[Address(RVA = "0x49D110", Offset = "0x49B710", VA = "0x18049D110", Slot = "48")]
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

	// Token: 0x06001241 RID: 4673 RVA: 0x00066864 File Offset: 0x00064A64
	[Token(Token = "0x6001241")]
	[Address(RVA = "0x49DE70", Offset = "0x49C470", VA = "0x18049DE70", Slot = "49")]
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

	// Token: 0x06001242 RID: 4674 RVA: 0x000668BC File Offset: 0x00064ABC
	[Token(Token = "0x6001242")]
	[Address(RVA = "0x4A0010", Offset = "0x49E610", VA = "0x1804A0010")]
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

	// Token: 0x04000C39 RID: 3129
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000C39")]
	[SerializeField]
	private List<LaserUmbrella.Channel> zombieChannels;

	// Token: 0x04000C3A RID: 3130
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000C3A")]
	[SerializeField]
	private List<LaserUmbrella.Channel> plantChannels;

	// Token: 0x04000C3B RID: 3131
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4000C3B")]
	public GameObject theLightPrefab;

	// Token: 0x04000C3C RID: 3132
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000C3C")]
	public GameObject ballPrefab;

	// Token: 0x04000C3D RID: 3133
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000C3D")]
	public GameObject lightBall;

	// Token: 0x04000C3E RID: 3134
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000C3E")]
	public bool main;

	// Token: 0x04000C3F RID: 3135
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4000C3F")]
	public int maxTarget;

	// Token: 0x04000C40 RID: 3136
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000C40")]
	private float explodeTimer;

	// Token: 0x04000C41 RID: 3137
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4000C41")]
	private float healTimer;

	// Token: 0x020003E4 RID: 996
	[Token(Token = "0x20003E4")]
	public enum ChannelType
	{
		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		Plant,
		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		Zombie
	}

	// Token: 0x020003E5 RID: 997
	[Token(Token = "0x20003E5")]
	[Serializable]
	public class Channel
	{
		// Token: 0x06001245 RID: 4677 RVA: 0x0006694C File Offset: 0x00064B4C
		[Token(Token = "0x6001245")]
		[Address(RVA = "0x49A120", Offset = "0x498720", VA = "0x18049A120")]
		public Channel(LaserUmbrella plant, GameObject gameObject, LaserUmbrella.ChannelType channelType)
		{
			this.plant = plant;
			this.gameObject = gameObject;
			this.channelType = channelType;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00066978 File Offset: 0x00064B78
		[Token(Token = "0x6001246")]
		[Address(RVA = "0x49A040", Offset = "0x498640", VA = "0x18049A040")]
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

		// Token: 0x06001247 RID: 4679 RVA: 0x000669D4 File Offset: 0x00064BD4
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x499FF0", Offset = "0x4985F0", VA = "0x180499FF0")]
		public void Die()
		{
			global::UnityEngine.Object.Destroy(this.gameObject);
		}

		// Token: 0x04000C45 RID: 3141
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C45")]
		public LaserUmbrella plant;

		// Token: 0x04000C46 RID: 3142
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C46")]
		public GameObject gameObject;

		// Token: 0x04000C47 RID: 3143
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C47")]
		public Zombie targetZombie;

		// Token: 0x04000C48 RID: 3144
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C48")]
		public Plant targetPlant;

		// Token: 0x04000C49 RID: 3145
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C49")]
		public LineRenderer line;

		// Token: 0x04000C4A RID: 3146
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C4A")]
		public ParticleSystem particle;

		// Token: 0x04000C4B RID: 3147
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C4B")]
		public SortingGroup sortingGroup;

		// Token: 0x04000C4C RID: 3148
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C4C")]
		public LaserUmbrella.ChannelType channelType;
	}
}
