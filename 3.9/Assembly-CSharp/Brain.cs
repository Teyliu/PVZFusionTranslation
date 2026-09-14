using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000108 RID: 264
[Token(Token = "0x2000108")]
public class Brain : MonoBehaviour, IDamageable
{
	// Token: 0x1700009E RID: 158
	// (get) Token: 0x060004FA RID: 1274 RVA: 0x0001A120 File Offset: 0x00018320
	// (set) Token: 0x060004FB RID: 1275 RVA: 0x0001A138 File Offset: 0x00018338
	[Token(Token = "0x1700009E")]
	public Team Team
	{
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "5")]
		set
		{
		}
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x0001A148 File Offset: 0x00018348
	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x5DCD70", Offset = "0x5DB370", VA = "0x1805DCD70")]
	private void Awake()
	{
		EveManager instance = EveManager.Instance;
		this.eveManager = instance;
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x0001A164 File Offset: 0x00018364
	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x5DD8A0", Offset = "0x5DBEA0", VA = "0x1805DD8A0")]
	private void Update()
	{
		bool flag = this.brainManager.brains.Remove(this);
		this.DieEvent();
		global::UnityEngine.Object.Destroy(base.gameObject);
		EveManager eveManager = this.eveManager;
		int num = 0;
		if (eveManager != num && this.eveManager.newEve)
		{
			Transform transform = base.transform;
			int num2 = 0;
			GameObject gameObject = transform.GetChild(num2).gameObject;
			NewEveData newEveData = this.eveManager.newEveData;
			int num3 = this.theRow;
			bool flag2 = newEveData.selectedRow == num3;
			gameObject.SetActive(flag2);
			this.points.gameObject.SetActive(true);
			EveManager eveManager2 = this.eveManager;
			TextMeshPro textMeshPro = this.points;
			List<int> list = eveManager2.newEveData.points;
			int num4 = this.theRow;
			int num5 = list[num4];
			string text;
			textMeshPro.text = text;
		}
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x0001A254 File Offset: 0x00018454
	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x5DD6B0", Offset = "0x5DBCB0", VA = "0x1805DD6B0")]
	public void Die()
	{
		bool flag = this.brainManager.brains.Remove(this);
		this.DieEvent();
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x0001A28C File Offset: 0x0001848C
	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x5DD460", Offset = "0x5DBA60", VA = "0x1805DD460")]
	private void DieEvent()
	{
		if (this.board.isEveStarted)
		{
			EveManager instance = EveManager.Instance;
			if (instance.newEve)
			{
				List<Brain> brains = this.brainManager.brains;
				NewEveData newEveData = instance.newEveData;
				int num = this.theRow;
				uint num2;
				newEveData.GetPoint(num, (int)num2);
			}
			BrainManager brainManager = this.brainManager;
			List<Brain> brains2 = brainManager.brains;
			int num3 = 0;
			int num4 = brains2[num3].theRow;
			brainManager.winRoad = num4;
			this.ClearAll();
			if (this.board.isAutoEve)
			{
				DelayAction delayAction = GameAPP.delayAction;
				Action action = new Action(this.WinAction);
				delayAction.SetAction(action, 3f);
			}
			EveManager instance2 = EveManager.Instance;
			if (instance2.newEve)
			{
				BrainManager brainManager2 = this.brainManager;
				NewEveData newEveData2 = instance2.newEveData;
				int winRoad = brainManager2.winRoad;
				uint num5;
				newEveData2.GetPoint(winRoad, (int)num5);
				EveManager.Instance.RoundOver();
			}
		}
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x0001A39C File Offset: 0x0001859C
	[Token(Token = "0x6000500")]
	[Address(RVA = "0x5DDAC0", Offset = "0x5DC0C0", VA = "0x1805DDAC0")]
	private void WinAction()
	{
		Board board = this.board;
		int num = 0;
		if (board != num)
		{
			BrainManager brainManager = this.board.brainManager;
			GameAPP.UIManager.PopAll();
			global::UnityEngine.Object.Destroy(brainManager.board.gameObject);
			UIMgr.EVEAuto(brainManager.winRoad);
		}
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x0001A3F4 File Offset: 0x000185F4
	[Token(Token = "0x6000501")]
	[Address(RVA = "0x5DD090", Offset = "0x5DB690", VA = "0x1805DD090")]
	private void ClearRow(int theRow)
	{
		int size = this.board.zombieArray._size;
		int num = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[theRow];
			int num2 = 0;
			if (zombie != num2 && zombie.theZombieRow == theRow)
			{
				zombie.Die(1);
			}
		}
		int size2 = this.board.boardEntity.plantArray._size;
		int num3 = size2 - 1;
		if (size2 > 0)
		{
			Plant plant = this.board.boardEntity.plantArray[theRow];
			int num4 = 0;
			if (plant != num4 && plant.thePlantRow == theRow)
			{
				Transform axis = plant.axis;
				GameObject gameObject = GameAPP.particlePrefab[11];
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = Board.Instance.transform;
				int num5 = 0;
				plant.Die((Plant.DieReason)num5);
			}
		}
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x0001A4DC File Offset: 0x000186DC
	[Token(Token = "0x6000502")]
	[Address(RVA = "0x5DCDC0", Offset = "0x5DB3C0", VA = "0x1805DCDC0")]
	private void ClearAll()
	{
		int size = this.board.zombieArray._size;
		int num = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num];
			int num2 = 0;
			if (zombie != num2)
			{
				Transform axis = zombie.axis;
				GameObject gameObject = GameAPP.particlePrefab[11];
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = Board.Instance.transform;
				zombie.Die(2);
			}
		}
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x0001A55C File Offset: 0x0001875C
	[Token(Token = "0x6000503")]
	[Address(RVA = "0x5DD7C0", Offset = "0x5DBDC0", VA = "0x1805DD7C0")]
	public void FlashOnce()
	{
		Material material = base.GetComponent<SpriteRenderer>().GetMaterial();
		Brain.<FlashObject>d__17 <FlashObject>d__;
		<FlashObject>d__.System.IDisposable.Dispose();
		<FlashObject>d__.<>1__state = (int)((ulong)0L);
		<FlashObject>d__.mt = material;
		Coroutine coroutine = base.StartCoroutine(<FlashObject>d__);
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x0001A59C File Offset: 0x0001879C
	[Token(Token = "0x6000504")]
	[Address(RVA = "0x5DD750", Offset = "0x5DBD50", VA = "0x1805DD750")]
	private IEnumerator FlashObject(Material mt)
	{
		Brain.<FlashObject>d__17 <FlashObject>d__;
		<FlashObject>d__.System.IDisposable.Dispose();
		<FlashObject>d__.<>1__state = (int)((ulong)0L);
		<FlashObject>d__.mt = mt;
		return null;
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x0001A5C0 File Offset: 0x000187C0
	[Token(Token = "0x6000505")]
	[Address(RVA = "0x5DD890", Offset = "0x5DBE90", VA = "0x1805DD890", Slot = "6")]
	public void TakeDamage(int value, IDamageMaker damageFrom, DamageType DamageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x0001A5D0 File Offset: 0x000187D0
	[Token(Token = "0x6000506")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Brain()
	{
	}

	// Token: 0x04000305 RID: 773
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000305")]
	public int theRow;

	// Token: 0x04000306 RID: 774
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000306")]
	public int theHealth;

	// Token: 0x04000307 RID: 775
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000307")]
	public Board board;

	// Token: 0x04000308 RID: 776
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000308")]
	public BrainManager brainManager;

	// Token: 0x04000309 RID: 777
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000309")]
	public EveManager eveManager;

	// Token: 0x0400030A RID: 778
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400030A")]
	public TextMeshPro points;
}
