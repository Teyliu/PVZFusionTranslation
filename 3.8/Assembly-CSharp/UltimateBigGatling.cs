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

// Token: 0x02000597 RID: 1431
[Token(Token = "0x2000597")]
public class UltimateBigGatling : BigGatling
{
	// Token: 0x06001A71 RID: 6769 RVA: 0x0008E384 File Offset: 0x0008C584
	[Token(Token = "0x6001A71")]
	[Address(RVA = "0x4F5C20", Offset = "0x4F4220", VA = "0x1804F5C20", Slot = "10")]
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

	// Token: 0x06001A72 RID: 6770 RVA: 0x0008E3D0 File Offset: 0x0008C5D0
	[Token(Token = "0x6001A72")]
	[Address(RVA = "0x4F7440", Offset = "0x4F5A40", VA = "0x1804F7440", Slot = "15")]
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

	// Token: 0x06001A73 RID: 6771 RVA: 0x0008E3FC File Offset: 0x0008C5FC
	[Token(Token = "0x6001A73")]
	[Address(RVA = "0x4F6250", Offset = "0x4F4850", VA = "0x1804F6250", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)15), action);
		Action<object> action2;
		EventManager.RemoveListener((GameEvent)((uint)16), action2);
	}

	// Token: 0x06001A74 RID: 6772 RVA: 0x0008E41C File Offset: 0x0008C61C
	[Token(Token = "0x6001A74")]
	[Address(RVA = "0x4F6AA0", Offset = "0x4F50A0", VA = "0x1804F6AA0")]
	private void OnPlantInjued(object obj)
	{
	}

	// Token: 0x06001A75 RID: 6773 RVA: 0x0008E430 File Offset: 0x0008C630
	[Token(Token = "0x6001A75")]
	[Address(RVA = "0x4F7250", Offset = "0x4F5850", VA = "0x1804F7250")]
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

	// Token: 0x06001A76 RID: 6774 RVA: 0x0008E4A4 File Offset: 0x0008C6A4
	[Token(Token = "0x6001A76")]
	[Address(RVA = "0x4F6860", Offset = "0x4F4E60", VA = "0x1804F6860")]
	private void MoreShoot(CancellationTokenSource token)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001A77 RID: 6775 RVA: 0x0008E4C8 File Offset: 0x0008C6C8
	[Token(Token = "0x6001A77")]
	[Address(RVA = "0x4F6A00", Offset = "0x4F5000", VA = "0x1804F6A00")]
	public void OnBigShoot()
	{
		GameAPP.PlaySound((SoundType)((uint)61), 0.5f, 1f);
		GameAPP.PlaySound((SoundType)((uint)59), 0.5f, 1f);
		GameAPP.PlaySound((SoundType)((uint)60), 0.5f, 1f);
		this.CheckCollidersInSector();
	}

	// Token: 0x06001A78 RID: 6776 RVA: 0x0008E514 File Offset: 0x0008C714
	[Token(Token = "0x6001A78")]
	[Address(RVA = "0x4F5D00", Offset = "0x4F4300", VA = "0x1804F5D00")]
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

	// Token: 0x06001A79 RID: 6777 RVA: 0x0008E5B0 File Offset: 0x0008C7B0
	[Token(Token = "0x6001A79")]
	[Address(RVA = "0x4F6320", Offset = "0x4F4920", VA = "0x1804F6320")]
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
				UltimateBigGatling.<>c.<>9__15_0 = func;
			}
			List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, func));
			long num3;
			int clipDamage = (int)num3;
			Func<Zombie, bool> func2;
			if (UltimateBigGatling.<>c.<>9__15_2 == 0)
			{
				UltimateBigGatling.<>c.<>9__15_2 = func2;
			}
			uint num4;
			Action<Zombie> action;
			global::Core.Lawnf.Bounce<Zombie>(list, (int)num4, action, func2);
		}
	}

	// Token: 0x06001A7A RID: 6778 RVA: 0x0008E6A0 File Offset: 0x0008C8A0
	[Token(Token = "0x6001A7A")]
	[Address(RVA = "0x4F6720", Offset = "0x4F4D20", VA = "0x1804F6720")]
	public void GetEnergy(int value)
	{
		base.UpdateText();
		this.attackSpeed = 1f;
	}

	// Token: 0x06001A7B RID: 6779 RVA: 0x0008E6CC File Offset: 0x0008C8CC
	[Token(Token = "0x6001A7B")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "73")]
	protected override void ModifyAttackSpeed()
	{
	}

	// Token: 0x06001A7C RID: 6780 RVA: 0x0008E6DC File Offset: 0x0008C8DC
	[Token(Token = "0x6001A7C")]
	[Address(RVA = "0x4F7000", Offset = "0x4F5600", VA = "0x1804F7000")]
	public void ShootInterval()
	{
		ulong num;
		do
		{
			BoardAction boardAction = this.board.boardAction;
			PlantType thePlantType = this.thePlantType;
			BoardAction boardAction2 = this.board.boardAction;
			Transform shoot = this.shoot;
			Vector3 vector;
			float z = vector.z;
			int thePlantRow = this.thePlantRow;
			List<Plant> plantsByRow = global::Lawnf.GetPlantsByRow(this.board, thePlantRow);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001A7D RID: 6781 RVA: 0x0008E748 File Offset: 0x0008C948
	[Token(Token = "0x6001A7D")]
	[Address(RVA = "0x4F6B20", Offset = "0x4F5120", VA = "0x1804F6B20", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Animator anim = this.anim;
		this.thePlantAttackCountDown = num;
		bool flag = base.Shootable();
		anim.SetBool("shooting", flag);
	}

	// Token: 0x06001A7E RID: 6782 RVA: 0x0008E7A8 File Offset: 0x0008C9A8
	[Token(Token = "0x6001A7E")]
	[Address(RVA = "0x4F6C30", Offset = "0x4F5230", VA = "0x1804F6C30", Slot = "69")]
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

	// Token: 0x06001A7F RID: 6783 RVA: 0x0008E88C File Offset: 0x0008CA8C
	[Token(Token = "0x6001A7F")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10")]
	private void Shoot()
	{
	}

	// Token: 0x06001A80 RID: 6784 RVA: 0x0008E89C File Offset: 0x0008CA9C
	[Token(Token = "0x6001A80")]
	[Address(RVA = "0x4F6930", Offset = "0x4F4F30", VA = "0x1804F6930", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001A81 RID: 6785 RVA: 0x0008E8BC File Offset: 0x0008CABC
	[Token(Token = "0x6001A81")]
	[Address(RVA = "0x4F7590", Offset = "0x4F5B90", VA = "0x1804F7590")]
	public UltimateBigGatling()
	{
	}

	// Token: 0x04000E69 RID: 3689
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000E69")]
	public ParticleSystem shootFire;

	// Token: 0x04000E6A RID: 3690
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000E6A")]
	public ParticleSystem shootFire2;

	// Token: 0x04000E6B RID: 3691
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000E6B")]
	public Color startColor1;

	// Token: 0x04000E6C RID: 3692
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000E6C")]
	public Color startColor2;

	// Token: 0x04000E6D RID: 3693
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000E6D")]
	public Color endColor1;

	// Token: 0x04000E6E RID: 3694
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000E6E")]
	public Color endColor2;

	// Token: 0x04000E6F RID: 3695
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000E6F")]
	private CancellationTokenSource CancellationTokenSource;
}
