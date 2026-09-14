using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Core;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020005C8 RID: 1480
[Token(Token = "0x20005C8")]
public class UltimateBigGatling : BigGatling
{
	// Token: 0x06001B57 RID: 6999 RVA: 0x00092740 File Offset: 0x00090940
	[Token(Token = "0x6001B57")]
	[Address(RVA = "0x5531D0", Offset = "0x5517D0", VA = "0x1805531D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		SortingGroup sortingGroup = this.shootFire.AddComponent<SortingGroup>();
		sortingGroup.sortingLayerName = "particle11";
		sortingGroup.sortAtRoot = true;
		Action action = delegate
		{
			this.theStatus = (PlantStatus)((ulong)8L);
		};
		this.defaultAction = action;
		throw new NullReferenceException();
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x0009278C File Offset: 0x0009098C
	[Token(Token = "0x6001B58")]
	[Address(RVA = "0x5549F0", Offset = "0x552FF0", VA = "0x1805549F0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)15), action, num != 0);
		int num2 = 0;
		Action<object> action2;
		EventManager.AddListener_obj((GameEvent)((uint)16), action2, num2 != 0);
	}

	// Token: 0x06001B59 RID: 7001 RVA: 0x000927B8 File Offset: 0x000909B8
	[Token(Token = "0x6001B59")]
	[Address(RVA = "0x553800", Offset = "0x551E00", VA = "0x180553800", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)15), action);
		Action<object> action2;
		EventManager.RemoveListener((GameEvent)((uint)16), action2);
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x000927D8 File Offset: 0x000909D8
	[Token(Token = "0x6001B5A")]
	[Address(RVA = "0x554050", Offset = "0x552650", VA = "0x180554050")]
	private void OnPlantInjued(object obj)
	{
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x000927EC File Offset: 0x000909EC
	[Token(Token = "0x6001B5B")]
	[Address(RVA = "0x554800", Offset = "0x552E00", VA = "0x180554800")]
	private void StartBigShoot()
	{
		ParticleSystem.MainModule main = this.shootFire.main;
		ParticleSystem.MainModule main2 = this.shootFire2.main;
		CancellationToken[] array = new CancellationToken[1];
		CancellationToken cancellationTokenOnDestroy = this.GetCancellationTokenOnDestroy();
		array[0] = cancellationTokenOnDestroy;
		CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(array);
		this.CancellationTokenSource = cancellationTokenSource;
		CancellationTokenSource cancellationTokenSource2 = this.CancellationTokenSource;
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x00092860 File Offset: 0x00090A60
	[Token(Token = "0x6001B5C")]
	[Address(RVA = "0x553E10", Offset = "0x552410", VA = "0x180553E10")]
	private void MoreShoot(CancellationTokenSource token)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x00092884 File Offset: 0x00090A84
	[Token(Token = "0x6001B5D")]
	[Address(RVA = "0x553FB0", Offset = "0x5525B0", VA = "0x180553FB0")]
	public void OnBigShoot()
	{
		GameAPP.PlaySound((SoundType)((uint)61), 0.5f, 1f);
		GameAPP.PlaySound((SoundType)((uint)59), 0.5f, 1f);
		GameAPP.PlaySound((SoundType)((uint)60), 0.5f, 1f);
		this.CheckCollidersInSector();
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x000928D0 File Offset: 0x00090AD0
	[Token(Token = "0x6001B5E")]
	[Address(RVA = "0x5532B0", Offset = "0x5518B0", VA = "0x1805532B0")]
	private void CheckCollidersInSector()
	{
		Transform shoot = this.shoot;
		int num = 0;
		if (!(shoot == num))
		{
			Transform shoot2 = this.shoot;
			HashSet<Zombie> hashSet = new HashSet();
			int num2 = 0;
			LayerMask zombieLayer = this.zombieLayer;
			int num3 = 0;
			RaycastHit2D[] array;
			if (num3 < array.Length)
			{
				int num4 = 0;
				Collider2D collider2D;
				if (collider2D.TryGetComponent<Zombie>(num4) && !hashSet.Contains(num4))
				{
					bool flag = hashSet.Add(num4);
					PlantType thePlantType = this.thePlantType;
					PlantType thePlantType2 = this.thePlantType;
				}
				num3++;
			}
			num2++;
			if (num2 < 15)
			{
			}
		}
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x0009296C File Offset: 0x00090B6C
	[Token(Token = "0x6001B5F")]
	[Address(RVA = "0x5538D0", Offset = "0x551ED0", VA = "0x1805538D0")]
	public void EndBigShoot()
	{
		int num = 0;
		ParticleSystem.MainModule main = this.shootFire.main;
		ParticleSystem.MainModule main2 = this.shootFire2.main;
		CancellationTokenSource cancellationTokenSource = this.CancellationTokenSource;
		this.attackSpeed = 1f;
		cancellationTokenSource.Cancel();
		this.CancellationTokenSource.Dispose();
		bool flag;
		if (flag)
		{
			Board board = this.board;
			if (num < board.rowNum)
			{
				int num2 = 0;
				List<Zombie> zombiesByRow = global::Lawnf.GetZombiesByRow(num, num2 != 0);
				this.board.boardAction.CreateFireLineVision(num);
				Board board2 = this.board;
				num++;
			}
			List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
			Func<Zombie, bool> func;
			if (UltimateBigGatling.<>c.<>9__15_0 == 0)
			{
				func = (Zombie z) => global::Lawnf.InNotWudiStatus(z.theStatus);
				UltimateBigGatling.<>c.<>9__15_0 = func;
			}
			List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, func));
			long num3;
			int clipDamage = (int)num3;
			Func<Zombie, bool> func2;
			if (UltimateBigGatling.<>c.<>9__15_2 == 0)
			{
				func2 = (Zombie z) => !z.Alive;
				UltimateBigGatling.<>c.<>9__15_2 = func2;
			}
			uint num4;
			Action<Zombie> action;
			global::Core.Lawnf.Bounce<Zombie>(list, (int)num4, action, func2);
		}
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x00092A80 File Offset: 0x00090C80
	[Token(Token = "0x6001B60")]
	[Address(RVA = "0x553CD0", Offset = "0x5522D0", VA = "0x180553CD0")]
	public void GetEnergy(int value)
	{
		base.UpdateText();
		this.attackSpeed = 1f;
	}

	// Token: 0x06001B61 RID: 7009 RVA: 0x00092AAC File Offset: 0x00090CAC
	[Token(Token = "0x6001B61")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "72")]
	protected override void ModifyAttackSpeed()
	{
	}

	// Token: 0x06001B62 RID: 7010 RVA: 0x00092ABC File Offset: 0x00090CBC
	[Token(Token = "0x6001B62")]
	[Address(RVA = "0x5545B0", Offset = "0x552BB0", VA = "0x1805545B0")]
	public void ShootInterval()
	{
		int num;
		do
		{
			BoardAction boardAction = this.board.boardAction;
			PlantType thePlantType = this.thePlantType;
			num = 0;
			int thePlantRow = this.thePlantRow;
			BoardAction boardAction2 = this.board.boardAction;
			Transform shoot = this.shoot;
			Vector3 vector;
			float z = vector.z;
			int thePlantRow2 = this.thePlantRow;
			List<Plant> plantsByRow = global::Lawnf.GetPlantsByRow(this.board, thePlantRow2);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06001B63 RID: 7011 RVA: 0x00092B34 File Offset: 0x00090D34
	[Token(Token = "0x6001B63")]
	[Address(RVA = "0x5540D0", Offset = "0x5526D0", VA = "0x1805540D0", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Animator anim = this.anim;
		this.thePlantAttackCountDown = num;
		bool flag = base.Shootable();
		anim.SetBool("shooting", flag);
	}

	// Token: 0x06001B64 RID: 7012 RVA: 0x00092B94 File Offset: 0x00090D94
	[Token(Token = "0x6001B64")]
	[Address(RVA = "0x5541E0", Offset = "0x5527E0", VA = "0x1805541E0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		bool flag = global::Lawnf.TravelUltimate((UltiBuff)((uint)20));
		if (flag)
		{
		}
		if (!flag)
		{
			if (this.attackSpeed <= 1.5f)
			{
			}
			float num = Mathf.Epsilon * 8f;
			float num2;
			if (num2 <= num)
			{
				num2 = num;
			}
			if (num2 > 1.5f)
			{
			}
		}
		float num3;
		if (0 > (int)num3 || num3 > 1f)
		{
		}
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int shootingLevel = this.shootingLevel;
		bullet.shootingLevel = shootingLevel;
		while ((ulong)((uint)(-1)) <= (ulong)1L)
		{
		}
		Animator anim = this.anim;
		float num4 = this.multiplier * this.attackSpeed;
		anim.SetFloat("attackSpeed", num4);
		int num5 = this.thePlantMaxHealth;
		num5 = num5.MultiplyPercent(6.25f);
		this.thePlantHealth = num5;
		base.UpdateText();
		return bullet;
	}

	// Token: 0x06001B65 RID: 7013 RVA: 0x00092C78 File Offset: 0x00090E78
	[Token(Token = "0x6001B65")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
	private void Shoot()
	{
	}

	// Token: 0x06001B66 RID: 7014 RVA: 0x00092C88 File Offset: 0x00090E88
	[Token(Token = "0x6001B66")]
	[Address(RVA = "0x553EE0", Offset = "0x5524E0", VA = "0x180553EE0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001B67 RID: 7015 RVA: 0x00092CA8 File Offset: 0x00090EA8
	[Token(Token = "0x6001B67")]
	[Address(RVA = "0x554B40", Offset = "0x553140", VA = "0x180554B40")]
	public UltimateBigGatling()
	{
	}

	// Token: 0x04000F28 RID: 3880
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000F28")]
	public ParticleSystem shootFire;

	// Token: 0x04000F29 RID: 3881
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000F29")]
	public ParticleSystem shootFire2;

	// Token: 0x04000F2A RID: 3882
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000F2A")]
	public Color startColor1;

	// Token: 0x04000F2B RID: 3883
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000F2B")]
	public Color startColor2;

	// Token: 0x04000F2C RID: 3884
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000F2C")]
	public Color endColor1;

	// Token: 0x04000F2D RID: 3885
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000F2D")]
	public Color endColor2;

	// Token: 0x04000F2E RID: 3886
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000F2E")]
	private CancellationTokenSource CancellationTokenSource;
}
