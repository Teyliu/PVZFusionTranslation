using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000103 RID: 259
[Token(Token = "0x2000103")]
public class Brain : MonoBehaviour, IDamageable
{
	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060004DF RID: 1247 RVA: 0x00019D1C File Offset: 0x00017F1C
	// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00019D34 File Offset: 0x00017F34
	[Token(Token = "0x17000061")]
	public Team Team
	{
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "5")]
		set
		{
		}
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x00019D44 File Offset: 0x00017F44
	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x5A5380", Offset = "0x5A3980", VA = "0x1805A5380")]
	private void Awake()
	{
		EveManager instance = EveManager.Instance;
		this.eveManager = instance;
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x00019D60 File Offset: 0x00017F60
	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x5A5EB0", Offset = "0x5A44B0", VA = "0x1805A5EB0")]
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

	// Token: 0x060004E3 RID: 1251 RVA: 0x00019E50 File Offset: 0x00018050
	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x5A5CC0", Offset = "0x5A42C0", VA = "0x1805A5CC0")]
	public void Die()
	{
		bool flag = this.brainManager.brains.Remove(this);
		this.DieEvent();
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00019E88 File Offset: 0x00018088
	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x5A5A70", Offset = "0x5A4070", VA = "0x1805A5A70")]
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

	// Token: 0x060004E5 RID: 1253 RVA: 0x00019F98 File Offset: 0x00018198
	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x5A60D0", Offset = "0x5A46D0", VA = "0x1805A60D0")]
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

	// Token: 0x060004E6 RID: 1254 RVA: 0x00019FF0 File Offset: 0x000181F0
	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x5A56A0", Offset = "0x5A3CA0", VA = "0x1805A56A0")]
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

	// Token: 0x060004E7 RID: 1255 RVA: 0x0001A0D8 File Offset: 0x000182D8
	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x5A53D0", Offset = "0x5A39D0", VA = "0x1805A53D0")]
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

	// Token: 0x060004E8 RID: 1256 RVA: 0x0001A158 File Offset: 0x00018358
	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x5A5DD0", Offset = "0x5A43D0", VA = "0x1805A5DD0")]
	public void FlashOnce()
	{
		Material material = base.GetComponent<SpriteRenderer>().GetMaterial();
		Brain.<FlashObject>d__17 <FlashObject>d__;
		<FlashObject>d__.System.IDisposable.Dispose();
		<FlashObject>d__.<>1__state = (int)((ulong)0L);
		<FlashObject>d__.mt = material;
		Coroutine coroutine = base.StartCoroutine(<FlashObject>d__);
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x0001A198 File Offset: 0x00018398
	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x5A5D60", Offset = "0x5A4360", VA = "0x1805A5D60")]
	private IEnumerator FlashObject(Material mt)
	{
		Brain.<FlashObject>d__17 <FlashObject>d__;
		<FlashObject>d__.System.IDisposable.Dispose();
		<FlashObject>d__.<>1__state = (int)((ulong)0L);
		<FlashObject>d__.mt = mt;
		return null;
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x0001A1BC File Offset: 0x000183BC
	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x5A5EA0", Offset = "0x5A44A0", VA = "0x1805A5EA0", Slot = "6")]
	public void TakeDamage(int value, IDamageMaker damageFrom, DamageType DamageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x0001A1CC File Offset: 0x000183CC
	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Brain()
	{
	}

	// Token: 0x040002F7 RID: 759
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002F7")]
	public int theRow;

	// Token: 0x040002F8 RID: 760
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002F8")]
	public int theHealth;

	// Token: 0x040002F9 RID: 761
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002F9")]
	public Board board;

	// Token: 0x040002FA RID: 762
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002FA")]
	public BrainManager brainManager;

	// Token: 0x040002FB RID: 763
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002FB")]
	public EveManager eveManager;

	// Token: 0x040002FC RID: 764
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002FC")]
	public TextMeshPro points;
}
