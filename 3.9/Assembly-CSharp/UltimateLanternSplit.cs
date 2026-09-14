using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020005E6 RID: 1510
[Token(Token = "0x20005E6")]
public class UltimateLanternSplit : LanternPea
{
	// Token: 0x06001C15 RID: 7189 RVA: 0x00095F40 File Offset: 0x00094140
	[Token(Token = "0x6001C15")]
	[Address(RVA = "0x566AC0", Offset = "0x5650C0", VA = "0x180566AC0", Slot = "73")]
	protected override void ActionOnZombie(Zombie zombie, int damage)
	{
		ulong num6;
		do
		{
			float num = this.attributeFloat * 1.5f;
			zombie.SetPortaled(num);
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				uint num2;
				if (num2 == (uint)949)
				{
					int num3 = 0;
					int num4 = 0;
					zombie.SetCold(1f, num4, num3 != 0);
					Transform axis = zombie.axis;
					ParticleManager instance = ParticleManager.Instance;
					Transform axis2 = zombie.axis;
					Vector3 vector;
					float z = vector.z;
					PlantType thePlantType = this.thePlantType;
					uint num5;
					GameAPP.PlaySound((int)num5, 0.5f, 1f);
				}
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num6 != (ulong)0L);
	}

	// Token: 0x06001C16 RID: 7190 RVA: 0x00096010 File Offset: 0x00094210
	[Token(Token = "0x6001C16")]
	[Address(RVA = "0x5672E0", Offset = "0x5658E0", VA = "0x1805672E0", Slot = "61")]
	public override bool OnClicked(Mouse mouse)
	{
		mouse.cannonPlant = this;
		GameObject gameObject = GameAPP.itemPrefab[16];
		Vector2 mousePosition = mouse.MousePosition;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		mouse.theItemOnMouse = gameObject2;
		mouse.theItemOnMouse.name = "cannon";
		return true;
	}

	// Token: 0x06001C17 RID: 7191 RVA: 0x00096070 File Offset: 0x00094270
	[Token(Token = "0x6001C17")]
	[Address(RVA = "0x5676E0", Offset = "0x565CE0", VA = "0x1805676E0", Slot = "62")]
	public override void SetTargetByMouse(Mouse mouse)
	{
		ulong num2;
		do
		{
			int num = 0;
			int theMouseRow = mouse.theMouseRow;
			List<Plant> list = Lawnf.Get1x1Plants(mouse.theMouseColumn, theMouseRow);
			bool flag;
			if (flag)
			{
				bool flag2 = base.CheckPlant(num);
				while (!flag2)
				{
				}
				if (!flag2 && !flag2)
				{
					while (!flag2)
					{
					}
				}
				this.targetPlant = num;
				bool flag3 = base.OnClicked(mouse);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001C18 RID: 7192 RVA: 0x000960D8 File Offset: 0x000942D8
	[Token(Token = "0x6001C18")]
	[Address(RVA = "0x567120", Offset = "0x565720", VA = "0x180567120", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		ulong num2;
		do
		{
			int num = 0;
			base.OnCreate((int)reason, num);
			Stack<UltimateLanternSplit.DamageLine> stack = this.lines;
			bool flag;
			if (flag)
			{
				UltimateLanternSplit.DamageLine damageLine;
				global::UnityEngine.Object.Destroy(damageLine.gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001C19 RID: 7193 RVA: 0x00096124 File Offset: 0x00094324
	[Token(Token = "0x6001C19")]
	[Address(RVA = "0x566F70", Offset = "0x565570", VA = "0x180566F70")]
	[ProButton]
	public void CreateLineAndUpdateIt()
	{
		UltimateLanternSplit.DamageLine damageLine = this.lines.Peek();
		if (damageLine.column != 0)
		{
			LineRenderer laserPrefab = this.laserPrefab;
			int column = damageLine.column;
			int num;
			UltimateLanternSplit.DamageLine damageLine2 = new UltimateLanternSplit.DamageLine(laserPrefab, num, this);
			num = column - 1;
			this.lines.Push(damageLine2);
			damageLine2.rightLine = damageLine;
			damageLine.leftLine = damageLine2;
			float explodeTimer = damageLine.explodeTimer;
			damageLine2.explodeTimer = explodeTimer;
		}
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x000961CC File Offset: 0x000943CC
	[Token(Token = "0x6001C1A")]
	[Address(RVA = "0x5674D0", Offset = "0x565AD0", VA = "0x1805674D0", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		ulong num;
		do
		{
			base.OnFixedUpdate();
			Stack<UltimateLanternSplit.DamageLine> stack = this.lines;
			bool flag;
			if (flag)
			{
				float fixedDeltaTime = Time.fixedDeltaTime;
				UltimateLanternSplit.DamageLine damageLine;
				float damageTimer = damageLine.damageTimer;
				Plant plant = damageLine.plant;
				damageLine.damageTimer = damageTimer;
				damageLine.damageTimer = 0.2f;
				damageLine.SimpleDamage();
				float explodeTimer = damageLine.explodeTimer;
				Plant plant2 = damageLine.plant;
				damageLine.explodeTimer = explodeTimer;
				damageLine.explodeTimer = 20f;
				if (!Lawnf.TravelAdvanced((AdvBuff)((uint)12010)))
				{
					continue;
				}
				while (damageLine.rightLine == (ulong)0L)
				{
				}
				damageLine.Explode();
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001C1B RID: 7195 RVA: 0x00096298 File Offset: 0x00094498
	[Token(Token = "0x6001C1B")]
	[Address(RVA = "0x567880", Offset = "0x565E80", VA = "0x180567880")]
	public UltimateLanternSplit()
	{
		Stack<UltimateLanternSplit.DamageLine> stack = new Stack();
		this.lines = stack;
		base..ctor();
	}

	// Token: 0x04000F86 RID: 3974
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000F86")]
	private readonly Stack<UltimateLanternSplit.DamageLine> lines;

	// Token: 0x020005E7 RID: 1511
	[Token(Token = "0x20005E7")]
	private class DamageLine
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x000962BC File Offset: 0x000944BC
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x000962D0 File Offset: 0x000944D0
		[Token(Token = "0x17000184")]
		public float StartTimer
		{
			[Token(Token = "0x6001C1C")]
			[Address(RVA = "0x55BD50", Offset = "0x55A350", VA = "0x18055BD50")]
			get
			{
				return this.explodeTimer;
			}
			[Token(Token = "0x6001C1D")]
			[Address(RVA = "0x55BD60", Offset = "0x55A360", VA = "0x18055BD60")]
			set
			{
				this.explodeTimer = value;
			}
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x000962E4 File Offset: 0x000944E4
		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x55BC80", Offset = "0x55A280", VA = "0x18055BC80")]
		public DamageLine(LineRenderer prefab, int column, Plant plant)
		{
			this.column = column;
			this.plant = plant;
			this.CreateLineObject(prefab);
			GameObject gameObject = Resources.Load<GameObject>("Plants/PeaShooter/LanternPea/UltimateLanternSplit/BlackHole");
			this.holePrefab = gameObject;
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00096320 File Offset: 0x00094520
		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x55B1E0", Offset = "0x5597E0", VA = "0x18055B1E0")]
		private void CreateLineObject(LineRenderer prefab)
		{
			Transform transform = this.plant.board.transform;
			LineRenderer lineRenderer = global::UnityEngine.Object.Instantiate<LineRenderer>(prefab, transform);
			this.r = lineRenderer;
			GameObject gameObject = this.r.gameObject;
			this.gameObject = gameObject;
			this.gameObject.SetActive(true);
			GridSystem gridSystem = this.plant.board.gridSystem;
			int num = this.column;
			int num2 = 0;
			BoardGrid grid = gridSystem.GetGrid(num, num2);
			Vector2 position = grid.Position;
			Board board = this.plant.board;
			Plant plant = this.plant;
			GridSystem gridSystem2 = board.gridSystem;
			int rowNum = plant.board.rowNum;
			int num3 = this.column;
			BoardGrid grid2 = gridSystem2.GetGrid(num3, rowNum);
			Vector2 position2 = grid2.Position;
			LineRenderer lineRenderer2 = this.r;
			LineRenderer lineRenderer3 = this.r;
			SortingGroup component = this.r.GetComponent<SortingGroup>();
			int rowNum2 = this.plant.board.rowNum;
			string text = string.Format("particle{0}", component);
			component.sortingLayerName = text;
			Transform transform2 = this.r.transform;
			int num4 = 0;
			global::UnityEngine.Object.Destroy(transform2.GetChild(num4).gameObject);
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x00096464 File Offset: 0x00094664
		[Token(Token = "0x17000185")]
		private float Speed
		{
			[Token(Token = "0x6001C20")]
			[Address(RVA = "0x55BD30", Offset = "0x55A330", VA = "0x18055BD30")]
			get
			{
				return this.plant.attributeSpeed;
			}
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00096484 File Offset: 0x00094684
		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x55B890", Offset = "0x559E90", VA = "0x18055B890")]
		public void OnFixedUpdate(float deltaTime)
		{
			Plant plant = this.plant;
			float num = this.damageTimer;
			this.damageTimer = num;
			this.damageTimer = 0.2f;
			this.SimpleDamage();
			Plant plant2 = this.plant;
			float num2 = this.explodeTimer;
			this.explodeTimer = num2;
			this.explodeTimer = 20f;
			if (Lawnf.TravelAdvanced((AdvBuff)((uint)12010)) && this.rightLine != (ulong)0L)
			{
				this.Explode();
			}
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00096504 File Offset: 0x00094704
		[Token(Token = "0x6001C22")]
		[Address(RVA = "0x55B950", Offset = "0x559F50", VA = "0x18055B950")]
		private void SimpleDamage()
		{
			LineRenderer lineRenderer = this.r;
			int num = 0;
			int num2 = 0;
			Vector3 vector;
			float z = vector.z;
			LineRenderer lineRenderer2 = this.r;
			LineRenderer lineRenderer3 = this.r;
			LayerMask zombieLayer = this.plant.zombieLayer;
			Vector3 vector2;
			float x = vector2.x;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				int num3;
				if (flag && num3 == this.column && Lawnf.InLandStatus((ZombieStatus)num))
				{
					PlantType thePlantType = this.plant.thePlantType;
				}
				num++;
			}
			if (num2 != 0)
			{
				uint num4;
				GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
			}
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000965A0 File Offset: 0x000947A0
		[Token(Token = "0x6001C23")]
		[Address(RVA = "0x55B5A0", Offset = "0x559BA0", VA = "0x18055B5A0")]
		private void Explode()
		{
			LineRenderer lineRenderer = this.r;
			LineRenderer lineRenderer2 = this.rightLine.r;
			GameObject gameObject = this.holePrefab;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = Board.Instance.transform;
			GameObject gameObject2;
			BlackHole_split component = gameObject2.GetComponent<BlackHole_split>();
			Plant plant = this.plant;
			long num;
			component.theDamage = (int)num;
			PlantType thePlantType = this.plant.thePlantType;
			component.fromType = thePlantType;
			ParticleManager instance = ParticleManager.Instance;
			GameAPP.PlaySound((SoundType)((uint)95), 0.5f, 1f);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00096630 File Offset: 0x00094830
		[Token(Token = "0x6001C24")]
		[Address(RVA = "0x55B550", Offset = "0x559B50", VA = "0x18055B550")]
		public void Die()
		{
			global::UnityEngine.Object.Destroy(this.gameObject);
		}

		// Token: 0x04000F87 RID: 3975
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000F87")]
		public int column;

		// Token: 0x04000F88 RID: 3976
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000F88")]
		public UltimateLanternSplit.DamageLine leftLine;

		// Token: 0x04000F89 RID: 3977
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000F89")]
		public UltimateLanternSplit.DamageLine rightLine;

		// Token: 0x04000F8A RID: 3978
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000F8A")]
		private readonly Plant plant;

		// Token: 0x04000F8B RID: 3979
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000F8B")]
		private readonly GameObject holePrefab;

		// Token: 0x04000F8C RID: 3980
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000F8C")]
		private GameObject gameObject;

		// Token: 0x04000F8D RID: 3981
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000F8D")]
		private LineRenderer r;

		// Token: 0x04000F8E RID: 3982
		[Token(Token = "0x4000F8E")]
		private const float damageInterval = 0.2f;

		// Token: 0x04000F8F RID: 3983
		[Token(Token = "0x4000F8F")]
		private const float explodeInterval = 20f;

		// Token: 0x04000F90 RID: 3984
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000F90")]
		private float damageTimer;

		// Token: 0x04000F91 RID: 3985
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000F91")]
		private float explodeTimer;
	}
}
