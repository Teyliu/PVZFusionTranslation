using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

// Token: 0x02000328 RID: 808
[Token(Token = "0x2000328")]
public class MixData
{
	// Token: 0x06000EBA RID: 3770 RVA: 0x00054220 File Offset: 0x00052420
	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0x40C260", Offset = "0x40A860", VA = "0x18040C260")]
	public static void InitMixData()
	{
		MixData.InitTravel();
		MixData.AddOrderedRecipe((PlantType)((uint)3), (PlantType)((uint)1027), (PlantType)((uint)1027));
		MixData.AddOrderedRecipe((PlantType)((uint)17), (PlantType)((uint)1060), (PlantType)((uint)1060));
		MixData.AddOrderedRecipe((PlantType)((uint)7), (PlantType)((uint)1070), (PlantType)((uint)1070));
		MixData.AddOrderedRecipe((PlantType)((uint)12), (PlantType)((uint)1067), (PlantType)((uint)1067));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)1120), (PlantType)((uint)1120));
		MixData.AddOrderedRecipe((PlantType)((uint)36), (PlantType)((uint)1247), (PlantType)((uint)1247));
		MixData.FogPlant();
		MixData.RoofPlant();
		MixData.PuffMix();
		MixData.FirstMix();
		MixData.SubInit();
		MixData.HandleSubUlti();
		PlantMixTreeManager.Init();
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x000542E0 File Offset: 0x000524E0
	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0x4057D0", Offset = "0x403DD0", VA = "0x1804057D0")]
	public static void FirstMix()
	{
		MixData.AddRecipe((PlantType)((uint)23), (PlantType)((uint)13), (PlantType)((uint)1441));
		MixData.AddRecipe((PlantType)((uint)14), (PlantType)((uint)11), (PlantType)((uint)1440));
		MixData.AddOrderedRecipe((PlantType)((uint)14), (PlantType)((uint)26), (PlantType)((uint)1439));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)14), (PlantType)((uint)1439));
		MixData.AddOrderedRecipe((PlantType)((uint)17), (PlantType)((uint)7), (PlantType)((uint)1438));
		MixData.AddOrderedRecipe((PlantType)((uint)7), (PlantType)((uint)17), (PlantType)((uint)1438));
		MixData.AddOrderedRecipe((PlantType)((uint)14), (PlantType)((uint)28), (PlantType)((uint)1434));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)14), (PlantType)((uint)1434));
		MixData.AddOrderedRecipe((PlantType)((uint)14), (PlantType)((uint)32), (PlantType)((uint)1433));
		MixData.AddOrderedRecipe((PlantType)((uint)32), (PlantType)((uint)14), (PlantType)((uint)1433));
		MixData.AddOrderedRecipe((PlantType)((uint)7), (PlantType)((uint)2), (PlantType)((uint)1428));
		MixData.AddOrderedRecipe((PlantType)((uint)2), (PlantType)((uint)7), (PlantType)((uint)1428));
		MixData.AddOrderedRecipe((PlantType)((uint)21), (PlantType)((uint)10), (PlantType)((uint)1427));
		MixData.AddOrderedRecipe((PlantType)((uint)10), (PlantType)((uint)21), (PlantType)((uint)1427));
		MixData.AddOrderedRecipe((PlantType)((uint)4), (PlantType)((uint)22), (PlantType)((uint)1426));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)4), (PlantType)((uint)1426));
		MixData.AddOrderedRecipe(PlantType.Peashooter, (PlantType)((uint)9), (PlantType)((uint)1425));
		int num = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)9), (PlantType)num, (PlantType)((uint)1425));
		MixData.AddOrderedRecipe((PlantType)((uint)4), (PlantType)((uint)18), (PlantType)((uint)1421));
		MixData.AddOrderedRecipe((PlantType)((uint)18), (PlantType)((uint)4), (PlantType)((uint)1421));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)22), (PlantType)((uint)1420));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)22), (PlantType)((uint)1420));
		MixData.AddOrderedRecipe((PlantType)((uint)17), (PlantType)((uint)1), (PlantType)((uint)1419));
		MixData.AddOrderedRecipe((PlantType)((uint)1), (PlantType)((uint)17), (PlantType)((uint)1419));
		MixData.AddOrderedRecipe((PlantType)((uint)17), (PlantType)((uint)26), (PlantType)((uint)1417));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)17), (PlantType)((uint)1417));
		MixData.AddOrderedRecipe((PlantType)((uint)17), (PlantType)((uint)32), (PlantType)((uint)1418));
		MixData.AddOrderedRecipe((PlantType)((uint)32), (PlantType)((uint)17), (PlantType)((uint)1418));
		MixData.AddOrderedRecipe((PlantType)((uint)40), (PlantType)((uint)33), (PlantType)((uint)1416));
		MixData.AddOrderedRecipe((PlantType)((uint)33), (PlantType)((uint)40), (PlantType)((uint)1416));
		MixData.AddOrderedRecipe((PlantType)((uint)21), (PlantType)((uint)17), (PlantType)((uint)1415));
		MixData.AddOrderedRecipe((PlantType)((uint)17), (PlantType)((uint)21), (PlantType)((uint)1415));
		int num2 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)23), (PlantType)num2, (PlantType)((uint)1412));
		MixData.AddOrderedRecipe(PlantType.Peashooter, (PlantType)((uint)23), (PlantType)((uint)1412));
		MixData.AddOrderedRecipe((PlantType)((uint)11), (PlantType)((uint)28), (PlantType)((uint)1411));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)11), (PlantType)((uint)1411));
		MixData.AddOrderedRecipe((PlantType)((uint)40), (PlantType)((uint)38), (PlantType)((uint)1409));
		MixData.AddOrderedRecipe((PlantType)((uint)38), (PlantType)((uint)40), (PlantType)((uint)1409));
		MixData.AddOrderedRecipe((PlantType)((uint)32), (PlantType)((uint)11), (PlantType)((uint)1408));
		MixData.AddOrderedRecipe((PlantType)((uint)11), (PlantType)((uint)32), (PlantType)((uint)1408));
		MixData.AddOrderedRecipe((PlantType)((uint)36), (PlantType)((uint)40), (PlantType)((uint)1406));
		MixData.AddOrderedRecipe((PlantType)((uint)40), (PlantType)((uint)36), (PlantType)((uint)1406));
		MixData.AddOrderedRecipe((PlantType)((uint)37), (PlantType)((uint)40), (PlantType)((uint)1403));
		MixData.AddOrderedRecipe((PlantType)((uint)40), (PlantType)((uint)37), (PlantType)((uint)1403));
		MixData.AddOrderedRecipe((PlantType)((uint)39), (PlantType)((uint)40), (PlantType)((uint)1402));
		MixData.AddOrderedRecipe((PlantType)((uint)40), (PlantType)((uint)39), (PlantType)((uint)1402));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)16), (PlantType)((uint)1400));
		MixData.AddOrderedRecipe((PlantType)((uint)16), (PlantType)((uint)28), (PlantType)((uint)1400));
		MixData.AddOrderedRecipe((PlantType)((uint)11), (PlantType)((uint)26), (PlantType)((uint)1399));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)11), (PlantType)((uint)1399));
		MixData.AddOrderedRecipe((PlantType)((uint)16), (PlantType)((uint)26), (PlantType)((uint)1398));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)16), (PlantType)((uint)1398));
		MixData.AddOrderedRecipe((PlantType)((uint)18), (PlantType)((uint)8), (PlantType)((uint)1394));
		MixData.AddOrderedRecipe((PlantType)((uint)8), (PlantType)((uint)18), (PlantType)((uint)1394));
		MixData.AddOrderedRecipe((PlantType)((uint)7), (PlantType)((uint)21), (PlantType)((uint)1393));
		MixData.AddOrderedRecipe((PlantType)((uint)21), (PlantType)((uint)7), (PlantType)((uint)1393));
		MixData.AddOrderedRecipe((PlantType)((uint)29), (PlantType)((uint)18), (PlantType)((uint)1391));
		MixData.AddOrderedRecipe((PlantType)((uint)18), (PlantType)((uint)29), (PlantType)((uint)1391));
		MixData.AddOrderedRecipe((PlantType)((uint)13), (PlantType)((uint)5), (PlantType)((uint)1390));
		MixData.AddOrderedRecipe((PlantType)((uint)5), (PlantType)((uint)13), (PlantType)((uint)1390));
		MixData.AddOrderedRecipe((PlantType)((uint)7), (PlantType)((uint)18), (PlantType)((uint)1389));
		MixData.AddOrderedRecipe((PlantType)((uint)18), (PlantType)((uint)7), (PlantType)((uint)1389));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)13), (PlantType)((uint)1378));
		MixData.AddOrderedRecipe((PlantType)((uint)13), (PlantType)((uint)26), (PlantType)((uint)1378));
		MixData.AddOrderedRecipe((PlantType)((uint)15), (PlantType)((uint)6), (PlantType)((uint)1377));
		MixData.AddOrderedRecipe((PlantType)((uint)10), (PlantType)((uint)28), (PlantType)((uint)1376));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)10), (PlantType)((uint)1376));
		MixData.AddOrderedRecipe((PlantType)((uint)10), (PlantType)((uint)26), (PlantType)((uint)1375));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)10), (PlantType)((uint)1375));
		MixData.AddOrderedRecipe((PlantType)((uint)10), (PlantType)((uint)4), (PlantType)((uint)1401));
		MixData.AddOrderedRecipe((PlantType)((uint)4), (PlantType)((uint)10), (PlantType)((uint)1401));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)13), (PlantType)((uint)1374));
		MixData.AddOrderedRecipe((PlantType)((uint)13), (PlantType)((uint)22), (PlantType)((uint)1374));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)17), (PlantType)((uint)1372));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)8), (PlantType)((uint)1380));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)22), (PlantType)((uint)1437));
		int num3 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)num3, (PlantType)((uint)1404));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)1109), (PlantType)((uint)1405));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)14), (PlantType)((uint)1442));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)10), (PlantType)((uint)1436));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)14), (PlantType)((uint)1435));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)16), (PlantType)((uint)1413));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)1168), (PlantType)((uint)1407));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)11), (PlantType)((uint)1371));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)13), (PlantType)((uint)1370));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)16), (PlantType)((uint)1384));
		MixData.AddOrderedRecipe((PlantType)((uint)7), (PlantType)((uint)26), (PlantType)((uint)1369));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)7), (PlantType)((uint)1369));
		MixData.AddOrderedRecipe((PlantType)((uint)10), (PlantType)((uint)31), (PlantType)((uint)1367));
		MixData.AddOrderedRecipe((PlantType)((uint)31), (PlantType)((uint)10), (PlantType)((uint)1367));
		MixData.AddOrderedRecipe((PlantType)((uint)8), (PlantType)((uint)23), (PlantType)((uint)1365));
		MixData.AddOrderedRecipe((PlantType)((uint)23), (PlantType)((uint)8), (PlantType)((uint)1365));
		MixData.AddOrderedRecipe(PlantType.Peashooter, (PlantType)((uint)13), (PlantType)((uint)1366));
		int num4 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)13), (PlantType)num4, (PlantType)((uint)1366));
		MixData.AddOrderedRecipe((PlantType)((uint)4), (PlantType)((uint)11), (PlantType)((uint)1364));
		MixData.AddOrderedRecipe((PlantType)((uint)11), (PlantType)((uint)4), (PlantType)((uint)1364));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)13), (PlantType)((uint)1363));
		MixData.AddOrderedRecipe((PlantType)((uint)13), (PlantType)((uint)28), (PlantType)((uint)1363));
		MixData.AddOrderedRecipe((PlantType)((uint)7), (PlantType)((uint)4), (PlantType)((uint)1362));
		MixData.AddOrderedRecipe((PlantType)((uint)4), (PlantType)((uint)7), (PlantType)((uint)1362));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)22), (PlantType)((uint)1359));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)26), (PlantType)((uint)1359));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)22), (PlantType)((uint)1360));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)28), (PlantType)((uint)1360));
		MixData.AddOrderedRecipe((PlantType)((uint)32), (PlantType)((uint)22), (PlantType)((uint)1361));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)32), (PlantType)((uint)1361));
		MixData.AddOrderedRecipe((PlantType)((uint)7), (PlantType)((uint)20), (PlantType)((uint)1358));
		MixData.AddOrderedRecipe((PlantType)((uint)20), (PlantType)((uint)7), (PlantType)((uint)1358));
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x000549F8 File Offset: 0x00052BF8
	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0x40D700", Offset = "0x40BD00", VA = "0x18040D700")]
	public static void PuffMix()
	{
		int num = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)num, (PlantType)((uint)1018));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)1030), (PlantType)((uint)1019));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)1090), (PlantType)((uint)1153));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)1032), (PlantType)((uint)1065));
		int num2 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)1018), (PlantType)num2, (PlantType)((uint)1019));
		MixData.AddOrderedRecipe((PlantType)((uint)1018), (PlantType)((uint)1030), (PlantType)((uint)1153));
		MixData.AddOrderedRecipe((PlantType)((uint)1018), (PlantType)((uint)1090), (PlantType)((uint)1065));
		int num3 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)1019), (PlantType)num3, (PlantType)((uint)1153));
		MixData.AddOrderedRecipe((PlantType)((uint)1019), (PlantType)((uint)1030), (PlantType)((uint)1065));
		int num4 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)1153), (PlantType)num4, (PlantType)((uint)1065));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)1034), (PlantType)((uint)1035));
		MixData.AddOrderedRecipe((PlantType)((uint)1018), (PlantType)((uint)10), (PlantType)((uint)1035));
		int num5 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)1036), (PlantType)num5, (PlantType)((uint)1035));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)1), (PlantType)((uint)1031));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)1020), (PlantType)((uint)1152));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)3), (PlantType)((uint)1021));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)8), (PlantType)((uint)1022));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)10), (PlantType)((uint)1036));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)11), (PlantType)((uint)1044));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)4), (PlantType)((uint)1170));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)26), (PlantType)((uint)1281));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)28), (PlantType)((uint)1203));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)32), (PlantType)((uint)1280));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)30), (PlantType)((uint)1301));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)23), (PlantType)((uint)1183));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)7), (PlantType)((uint)1396));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)9), (PlantType)((uint)1397));
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x00054BEC File Offset: 0x00052DEC
	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0x40AF40", Offset = "0x409540", VA = "0x18040AF40")]
	private static void FogPlant()
	{
		MixData.AddOrderedRecipe((PlantType)((uint)25), (PlantType)((uint)7), (PlantType)((uint)1158));
		MixData.AddOrderedRecipe((PlantType)((uint)7), (PlantType)((uint)25), (PlantType)((uint)1158));
		MixData.AddOrderedRecipe((PlantType)((uint)19), (PlantType)((uint)3), (PlantType)((uint)1293));
		MixData.AddOrderedRecipe((PlantType)((uint)19), (PlantType)((uint)21), (PlantType)((uint)1076));
		MixData.AddOrderedRecipe((PlantType)((uint)19), (PlantType)((uint)1), (PlantType)((uint)1077));
		MixData.AddOrderedRecipe((PlantType)((uint)19), (PlantType)((uint)20), (PlantType)((uint)1078));
		MixData.AddOrderedRecipe((PlantType)((uint)19), (PlantType)((uint)23), (PlantType)((uint)1083));
		MixData.AddOrderedRecipe((PlantType)((uint)19), (PlantType)((uint)22), (PlantType)((uint)1086));
		MixData.AddOrderedRecipe((PlantType)((uint)19), (PlantType)((uint)25), (PlantType)((uint)1101));
		MixData.AddOrderedRecipe((PlantType)((uint)20), (PlantType)((uint)21), (PlantType)((uint)1079));
		MixData.AddOrderedRecipe((PlantType)((uint)21), (PlantType)((uint)20), (PlantType)((uint)1079));
		MixData.AddOrderedRecipe((PlantType)((uint)20), (PlantType)((uint)22), (PlantType)((uint)1080));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)20), (PlantType)((uint)1080));
		MixData.AddOrderedRecipe((PlantType)((uint)20), (PlantType)((uint)23), (PlantType)((uint)1081));
		MixData.AddOrderedRecipe((PlantType)((uint)23), (PlantType)((uint)20), (PlantType)((uint)1081));
		MixData.AddOrderedRecipe((PlantType)((uint)21), (PlantType)((uint)22), (PlantType)((uint)1082));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)21), (PlantType)((uint)1082));
		MixData.AddOrderedRecipe((PlantType)((uint)23), (PlantType)((uint)22), (PlantType)((uint)1084));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)23), (PlantType)((uint)1084));
		MixData.AddOrderedRecipe((PlantType)((uint)23), (PlantType)((uint)21), (PlantType)((uint)1085));
		MixData.AddOrderedRecipe((PlantType)((uint)21), (PlantType)((uint)23), (PlantType)((uint)1085));
		MixData.AddOrderedRecipe((PlantType)((uint)23), (PlantType)((uint)25), (PlantType)((uint)1093));
		MixData.AddOrderedRecipe((PlantType)((uint)25), (PlantType)((uint)23), (PlantType)((uint)1093));
		MixData.AddOrderedRecipe((PlantType)((uint)1), (PlantType)((uint)25), (PlantType)((uint)1154));
		MixData.AddOrderedRecipe((PlantType)((uint)25), (PlantType)((uint)1), (PlantType)((uint)1154));
		MixData.AddOrderedRecipe((PlantType)((uint)20), (PlantType)((uint)25), (PlantType)((uint)1100));
		MixData.AddOrderedRecipe((PlantType)((uint)25), (PlantType)((uint)20), (PlantType)((uint)1100));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)25), (PlantType)((uint)1102));
		MixData.AddOrderedRecipe((PlantType)((uint)25), (PlantType)((uint)22), (PlantType)((uint)1102));
		MixData.AddOrderedRecipe((PlantType)((uint)21), (PlantType)((uint)25), (PlantType)((uint)1103));
		MixData.AddOrderedRecipe((PlantType)((uint)25), (PlantType)((uint)21), (PlantType)((uint)1103));
		MixData.AddOrderedRecipe((PlantType)((uint)8), (PlantType)((uint)25), (PlantType)((uint)1157));
		MixData.AddOrderedRecipe((PlantType)((uint)25), (PlantType)((uint)8), (PlantType)((uint)1157));
		MixData.AddOrderedRecipe((PlantType)((uint)1081), (PlantType)((uint)25), (PlantType)((uint)1104));
		MixData.AddOrderedRecipe((PlantType)((uint)25), (PlantType)((uint)1081), (PlantType)((uint)1104));
		MixData.AddOrderedRecipe((PlantType)((uint)1093), (PlantType)((uint)20), (PlantType)((uint)1104));
		MixData.AddOrderedRecipe((PlantType)((uint)20), (PlantType)((uint)1093), (PlantType)((uint)1104));
		MixData.AddOrderedRecipe((PlantType)((uint)1100), (PlantType)((uint)23), (PlantType)((uint)1104));
		MixData.AddOrderedRecipe((PlantType)((uint)23), (PlantType)((uint)1100), (PlantType)((uint)1104));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)18), (PlantType)((uint)1288));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)2), (PlantType)((uint)1164));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)20), (PlantType)((uint)1087));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)21), (PlantType)((uint)1088));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)23), (PlantType)((uint)1089));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)22), (PlantType)((uint)1091));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)25), (PlantType)((uint)1092));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)25), (PlantType)((uint)1092));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)13), (PlantType)((uint)1202));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)8), (PlantType)((uint)1205));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)3), (PlantType)((uint)1299));
		int num = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)num, (PlantType)((uint)1318));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)9), (PlantType)((uint)1200));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)4), (PlantType)((uint)1190));
		MixData.AddOrderedRecipe((PlantType)((uint)1088), (PlantType)((uint)22), (PlantType)((uint)1110));
		MixData.AddOrderedRecipe((PlantType)((uint)1091), (PlantType)((uint)21), (PlantType)((uint)1110));
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x00054FAC File Offset: 0x000531AC
	[Token(Token = "0x6000EBE")]
	[Address(RVA = "0x40D9C0", Offset = "0x40BFC0", VA = "0x18040D9C0")]
	private static void RoofPlant()
	{
		MixData.AddOrderedRecipe((PlantType)((uint)1), (PlantType)((uint)26), (PlantType)((uint)1111));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)1), (PlantType)((uint)1111));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)28), (PlantType)((uint)1113));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)26), (PlantType)((uint)1113));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)9), (PlantType)((uint)1357));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)3), (PlantType)((uint)1311));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)26), (PlantType)((uint)1112));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)28), (PlantType)((uint)1114));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)30), (PlantType)((uint)1133));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)29), (PlantType)((uint)1130));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)31), (PlantType)((uint)1136));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)32), (PlantType)((uint)1125));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)1), (PlantType)((uint)1184));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)20), (PlantType)((uint)1195));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)10), (PlantType)((uint)1287));
		MixData.AddOrderedRecipe((PlantType)((uint)30), (PlantType)((uint)26), (PlantType)((uint)1128));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)30), (PlantType)((uint)1128));
		MixData.AddOrderedRecipe((PlantType)((uint)30), (PlantType)((uint)28), (PlantType)((uint)1115));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)30), (PlantType)((uint)1115));
		MixData.AddOrderedRecipe((PlantType)((uint)30), (PlantType)((uint)29), (PlantType)((uint)1127));
		MixData.AddOrderedRecipe((PlantType)((uint)29), (PlantType)((uint)30), (PlantType)((uint)1127));
		MixData.AddOrderedRecipe((PlantType)((uint)30), (PlantType)((uint)32), (PlantType)((uint)1131));
		MixData.AddOrderedRecipe((PlantType)((uint)32), (PlantType)((uint)30), (PlantType)((uint)1131));
		MixData.AddOrderedRecipe((PlantType)((uint)32), (PlantType)((uint)10), (PlantType)((uint)1116));
		MixData.AddOrderedRecipe((PlantType)((uint)10), (PlantType)((uint)32), (PlantType)((uint)1116));
		MixData.AddOrderedRecipe((PlantType)((uint)32), (PlantType)((uint)16), (PlantType)((uint)1149));
		MixData.AddOrderedRecipe((PlantType)((uint)16), (PlantType)((uint)32), (PlantType)((uint)1149));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)29), (PlantType)((uint)1117));
		MixData.AddOrderedRecipe((PlantType)((uint)29), (PlantType)((uint)28), (PlantType)((uint)1117));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)29), (PlantType)((uint)1118));
		MixData.AddOrderedRecipe((PlantType)((uint)29), (PlantType)((uint)26), (PlantType)((uint)1118));
		MixData.AddOrderedRecipe((PlantType)((uint)32), (PlantType)((uint)29), (PlantType)((uint)1119));
		MixData.AddOrderedRecipe((PlantType)((uint)29), (PlantType)((uint)32), (PlantType)((uint)1119));
		MixData.AddOrderedRecipe((PlantType)((uint)32), (PlantType)((uint)28), (PlantType)((uint)1121));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)32), (PlantType)((uint)1121));
		MixData.AddOrderedRecipe((PlantType)((uint)1120), (PlantType)((uint)10), (PlantType)((uint)1123));
		MixData.AddOrderedRecipe((PlantType)((uint)1120), (PlantType)((uint)16), (PlantType)((uint)1122));
		MixData.AddOrderedRecipe((PlantType)((uint)32), (PlantType)((uint)26), (PlantType)((uint)1124));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)32), (PlantType)((uint)1124));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)1121), (PlantType)((uint)1126));
		MixData.AddOrderedRecipe((PlantType)((uint)1121), (PlantType)((uint)26), (PlantType)((uint)1126));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)1124), (PlantType)((uint)1126));
		MixData.AddOrderedRecipe((PlantType)((uint)1124), (PlantType)((uint)28), (PlantType)((uint)1126));
		MixData.AddOrderedRecipe((PlantType)((uint)32), (PlantType)((uint)1113), (PlantType)((uint)1126));
		MixData.AddOrderedRecipe((PlantType)((uint)1113), (PlantType)((uint)32), (PlantType)((uint)1126));
		MixData.AddOrderedRecipe((PlantType)((uint)26), (PlantType)((uint)31), (PlantType)((uint)1134));
		MixData.AddOrderedRecipe((PlantType)((uint)31), (PlantType)((uint)26), (PlantType)((uint)1134));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)31), (PlantType)((uint)1138));
		MixData.AddOrderedRecipe((PlantType)((uint)31), (PlantType)((uint)28), (PlantType)((uint)1138));
		MixData.AddOrderedRecipe((PlantType)((uint)30), (PlantType)((uint)31), (PlantType)((uint)1143));
		MixData.AddOrderedRecipe((PlantType)((uint)31), (PlantType)((uint)30), (PlantType)((uint)1143));
		MixData.AddOrderedRecipe((PlantType)((uint)29), (PlantType)((uint)31), (PlantType)((uint)1145));
		MixData.AddOrderedRecipe((PlantType)((uint)31), (PlantType)((uint)29), (PlantType)((uint)1145));
		MixData.AddOrderedRecipe((PlantType)((uint)32), (PlantType)((uint)31), (PlantType)((uint)1141));
		MixData.AddOrderedRecipe((PlantType)((uint)31), (PlantType)((uint)32), (PlantType)((uint)1141));
		MixData.AddOrderedRecipe((PlantType)((uint)31), (PlantType)((uint)31), (PlantType)((uint)1140));
		MixData.AddOrderedRecipe((PlantType)((uint)31), (PlantType)((uint)31), (PlantType)((uint)1140));
		MixData.AddOrderedRecipe((PlantType)((uint)1144), (PlantType)((uint)29), (PlantType)((uint)1148));
		MixData.AddOrderedRecipe((PlantType)((uint)29), (PlantType)((uint)1144), (PlantType)((uint)1148));
		MixData.AddOrderedRecipe((PlantType)((uint)1146), (PlantType)((uint)30), (PlantType)((uint)1148));
		MixData.AddOrderedRecipe((PlantType)((uint)30), (PlantType)((uint)1146), (PlantType)((uint)1148));
		MixData.AddOrderedRecipe((PlantType)((uint)31), (PlantType)((uint)25), (PlantType)((uint)1150));
		MixData.AddOrderedRecipe((PlantType)((uint)25), (PlantType)((uint)31), (PlantType)((uint)1150));
		MixData.AddOrderedRecipe((PlantType)((uint)2), (PlantType)((uint)25), (PlantType)((uint)1166));
		MixData.AddOrderedRecipe((PlantType)((uint)25), (PlantType)((uint)2), (PlantType)((uint)1166));
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x00055428 File Offset: 0x00053628
	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0x40C380", Offset = "0x40A980", VA = "0x18040C380")]
	private static void InitTravel()
	{
		MixData.AddOrderedRecipe((PlantType)((uint)1410), (PlantType)((uint)1215), (PlantType)((uint)5002));
		MixData.AddOrderedRecipe((PlantType)((uint)1215), (PlantType)((uint)1410), (PlantType)((uint)5002));
		MixData.AddOrderedRecipe((PlantType)((uint)1420), (PlantType)((uint)22), (PlantType)((uint)998));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)1420), (PlantType)((uint)998));
		MixData.AddOrderedRecipe((PlantType)((uint)1266), (PlantType)((uint)1173), (PlantType)((uint)997));
		MixData.AddOrderedRecipe((PlantType)((uint)8), (PlantType)((uint)252), (PlantType)((uint)994));
		MixData.AddOrderedRecipe((PlantType)((uint)252), (PlantType)((uint)8), (PlantType)((uint)993));
		MixData.AddOrderedRecipe((PlantType)((uint)1040), (PlantType)((uint)10), (PlantType)((uint)992));
		MixData.AddOrderedRecipe((PlantType)((uint)1020), (PlantType)((uint)1306), (PlantType)((uint)985));
		MixData.AddOrderedRecipe((PlantType)((uint)1306), (PlantType)((uint)1020), (PlantType)((uint)985));
		MixData.AddOrderedRecipe((PlantType)((uint)1208), (PlantType)((uint)1382), (PlantType)((uint)984));
		MixData.AddOrderedRecipe((PlantType)((uint)1382), (PlantType)((uint)1208), (PlantType)((uint)984));
		MixData.AddOrderedRecipe((PlantType)((uint)1067), (PlantType)((uint)248), (PlantType)((uint)926));
		MixData.AddOrderedRecipe((PlantType)((uint)248), (PlantType)((uint)1067), (PlantType)((uint)926));
		MixData.AddOrderedRecipe((PlantType)((uint)1179), (PlantType)((uint)222), (PlantType)((uint)979));
		MixData.AddOrderedRecipe((PlantType)((uint)222), (PlantType)((uint)1179), (PlantType)((uint)979));
		MixData.AddOrderedRecipe((PlantType)((uint)1173), (PlantType)((uint)1173), (PlantType)((uint)977));
		MixData.AddOrderedRecipe((PlantType)((uint)1173), (PlantType)((uint)1173), (PlantType)((uint)977));
		MixData.AddOrderedRecipe((PlantType)((uint)1337), (PlantType)((uint)1063), (PlantType)((uint)970));
		MixData.AddOrderedRecipe((PlantType)((uint)1063), (PlantType)((uint)1337), (PlantType)((uint)970));
		MixData.AddOrderedRecipe((PlantType)((uint)1175), (PlantType)((uint)1302), (PlantType)((uint)960));
		MixData.AddOrderedRecipe((PlantType)((uint)1332), (PlantType)((uint)2), (PlantType)((uint)959));
		MixData.AddOrderedRecipe((PlantType)((uint)2), (PlantType)((uint)1332), (PlantType)((uint)959));
		MixData.AddOrderedRecipe((PlantType)((uint)1069), (PlantType)((uint)1179), (PlantType)((uint)958));
		MixData.AddOrderedRecipe((PlantType)((uint)1116), (PlantType)((uint)1316), (PlantType)((uint)957));
		MixData.AddOrderedRecipe((PlantType)((uint)1316), (PlantType)((uint)1116), (PlantType)((uint)957));
		MixData.AddOrderedRecipe((PlantType)((uint)1192), (PlantType)((uint)1317), (PlantType)((uint)956));
		MixData.AddOrderedRecipe((PlantType)((uint)1317), (PlantType)((uint)1192), (PlantType)((uint)956));
		MixData.AddOrderedRecipe((PlantType)((uint)1188), (PlantType)((uint)1304), (PlantType)((uint)954));
		MixData.AddOrderedRecipe((PlantType)((uint)1304), (PlantType)((uint)1188), (PlantType)((uint)954));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)1109), (PlantType)((uint)1290));
		MixData.AddOrderedRecipe((PlantType)((uint)1109), (PlantType)((uint)11), (PlantType)((uint)1272));
		MixData.AddOrderedRecipe((PlantType)((uint)11), (PlantType)((uint)1109), (PlantType)((uint)1272));
		MixData.AddOrderedRecipe((PlantType)((uint)1109), (PlantType)((uint)29), (PlantType)((uint)1329));
		MixData.AddOrderedRecipe((PlantType)((uint)29), (PlantType)((uint)1109), (PlantType)((uint)1329));
		MixData.AddOrderedRecipe((PlantType)((uint)1109), (PlantType)((uint)16), (PlantType)((uint)1167));
		MixData.AddOrderedRecipe((PlantType)((uint)16), (PlantType)((uint)1109), (PlantType)((uint)1167));
		MixData.AddOrderedRecipe((PlantType)((uint)1109), (PlantType)((uint)5), (PlantType)((uint)1424));
		MixData.AddOrderedRecipe((PlantType)((uint)5), (PlantType)((uint)1109), (PlantType)((uint)1424));
		MixData.AddOrderedRecipe((PlantType)((uint)1109), (PlantType)((uint)23), (PlantType)((uint)1429));
		MixData.AddOrderedRecipe((PlantType)((uint)23), (PlantType)((uint)1109), (PlantType)((uint)1429));
		MixData.AddOrderedRecipe((PlantType)((uint)1168), (PlantType)((uint)14), (PlantType)((uint)1271));
		MixData.AddOrderedRecipe((PlantType)((uint)14), (PlantType)((uint)1168), (PlantType)((uint)1271));
		MixData.AddOrderedRecipe((PlantType)((uint)1168), (PlantType)((uint)8), (PlantType)((uint)1292));
		MixData.AddOrderedRecipe((PlantType)((uint)8), (PlantType)((uint)1168), (PlantType)((uint)1292));
		MixData.AddOrderedRecipe((PlantType)((uint)1168), (PlantType)((uint)10), (PlantType)((uint)1165));
		MixData.AddOrderedRecipe((PlantType)((uint)10), (PlantType)((uint)1168), (PlantType)((uint)1165));
		MixData.AddOrderedRecipe((PlantType)((uint)1168), (PlantType)((uint)3), (PlantType)((uint)1423));
		MixData.AddOrderedRecipe((PlantType)((uint)3), (PlantType)((uint)1168), (PlantType)((uint)1423));
		MixData.AddOrderedRecipe((PlantType)((uint)1174), (PlantType)((uint)1241), (PlantType)((uint)951));
		MixData.AddOrderedRecipe((PlantType)((uint)1220), (PlantType)((uint)1221), (PlantType)((uint)947));
		MixData.AddOrderedRecipe((PlantType)((uint)1221), (PlantType)((uint)1220), (PlantType)((uint)947));
		MixData.AddOrderedRecipe((PlantType)((uint)1166), (PlantType)((uint)1100), (PlantType)((uint)944));
		MixData.AddOrderedRecipe((PlantType)((uint)1100), (PlantType)((uint)1166), (PlantType)((uint)944));
		MixData.AddOrderedRecipe((PlantType)((uint)1203), (PlantType)((uint)1210), (PlantType)((uint)943));
		MixData.AddOrderedRecipe((PlantType)((uint)1152), (PlantType)((uint)25), (PlantType)((uint)942));
		MixData.AddOrderedRecipe((PlantType)((uint)1066), (PlantType)((uint)1140), (PlantType)((uint)941));
		MixData.AddOrderedRecipe((PlantType)((uint)1149), (PlantType)((uint)1160), (PlantType)((uint)940));
		MixData.AddOrderedRecipe((PlantType)((uint)1160), (PlantType)((uint)1149), (PlantType)((uint)940));
		MixData.AddOrderedRecipe((PlantType)((uint)1079), (PlantType)((uint)1185), (PlantType)((uint)937));
		MixData.AddOrderedRecipe((PlantType)((uint)1185), (PlantType)((uint)1079), (PlantType)((uint)937));
		MixData.AddOrderedRecipe((PlantType)((uint)1137), (PlantType)((uint)1), (PlantType)((uint)936));
		MixData.AddOrderedRecipe((PlantType)((uint)1092), (PlantType)((uint)25), (PlantType)((uint)935));
		MixData.AddOrderedRecipe((PlantType)((uint)1135), (PlantType)((uint)1111), (PlantType)((uint)934));
		MixData.AddOrderedRecipe((PlantType)((uint)1111), (PlantType)((uint)1135), (PlantType)((uint)934));
		MixData.AddOrderedRecipe((PlantType)((uint)1055), (PlantType)((uint)1150), (PlantType)((uint)932));
		MixData.AddOrderedRecipe((PlantType)((uint)1150), (PlantType)((uint)1055), (PlantType)((uint)932));
		MixData.AddOrderedRecipe((PlantType)((uint)1045), (PlantType)((uint)11), (PlantType)((uint)928));
		MixData.AddOrderedRecipe((PlantType)((uint)11), (PlantType)((uint)1045), (PlantType)((uint)928));
		MixData.AddOrderedRecipe((PlantType)((uint)1161), (PlantType)((uint)1173), (PlantType)((uint)927));
		MixData.AddOrderedRecipe((PlantType)((uint)1058), (PlantType)((uint)16), (PlantType)((uint)918));
		MixData.AddOrderedRecipe((PlantType)((uint)16), (PlantType)((uint)1058), (PlantType)((uint)918));
		MixData.AddOrderedRecipe((PlantType)((uint)918), (PlantType)((uint)16), (PlantType)((uint)919));
		MixData.AddOrderedRecipe((PlantType)((uint)16), (PlantType)((uint)918), (PlantType)((uint)919));
		MixData.AddOrderedRecipe((PlantType)((uint)8), (PlantType)((uint)8), (PlantType)((uint)900));
		MixData.AddOrderedRecipe((PlantType)((uint)8), (PlantType)((uint)8), (PlantType)((uint)900));
		MixData.AddOrderedRecipe((PlantType)((uint)1006), (PlantType)((uint)3), (PlantType)((uint)905));
		MixData.AddOrderedRecipe((PlantType)((uint)3), (PlantType)((uint)1006), (PlantType)((uint)905));
		MixData.AddOrderedRecipe((PlantType)((uint)1074), (PlantType)((uint)1075), (PlantType)((uint)906));
		MixData.AddOrderedRecipe((PlantType)((uint)1075), (PlantType)((uint)1074), (PlantType)((uint)906));
		MixData.AddOrderedRecipe((PlantType)((uint)1073), (PlantType)((uint)1039), (PlantType)((uint)913));
		MixData.AddOrderedRecipe((PlantType)((uint)1039), (PlantType)((uint)1073), (PlantType)((uint)913));
		MixData.AddOrderedRecipe((PlantType)((uint)1017), (PlantType)((uint)1005), (PlantType)((uint)901));
		MixData.AddOrderedRecipe((PlantType)((uint)1005), (PlantType)((uint)1017), (PlantType)((uint)901));
		MixData.AddOrderedRecipe((PlantType)((uint)1052), (PlantType)((uint)1054), (PlantType)((uint)902));
		MixData.AddOrderedRecipe((PlantType)((uint)1054), (PlantType)((uint)1052), (PlantType)((uint)902));
		MixData.AddOrderedRecipe((PlantType)((uint)1013), (PlantType)((uint)1016), (PlantType)((uint)903));
		MixData.AddOrderedRecipe((PlantType)((uint)1016), (PlantType)((uint)1013), (PlantType)((uint)903));
		MixData.AddOrderedRecipe((PlantType)((uint)1046), (PlantType)((uint)1041), (PlantType)((uint)904));
		MixData.AddOrderedRecipe((PlantType)((uint)1041), (PlantType)((uint)1046), (PlantType)((uint)904));
		MixData.AddOrderedRecipe((PlantType)((uint)1032), (PlantType)((uint)11), (PlantType)((uint)907));
		MixData.AddOrderedRecipe((PlantType)((uint)11), (PlantType)((uint)1032), (PlantType)((uint)907));
		MixData.AddOrderedRecipe((PlantType)((uint)1194), (PlantType)((uint)1090), (PlantType)((uint)907));
		MixData.AddOrderedRecipe((PlantType)((uint)1090), (PlantType)((uint)1194), (PlantType)((uint)907));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)1106), (PlantType)((uint)908));
		MixData.AddOrderedRecipe((PlantType)((uint)1065), (PlantType)((uint)10), (PlantType)((uint)908));
		MixData.AddOrderedRecipe((PlantType)((uint)1035), (PlantType)((uint)1090), (PlantType)((uint)908));
		MixData.AddOrderedRecipe((PlantType)((uint)1019), (PlantType)((uint)1105), (PlantType)((uint)908));
		MixData.AddOrderedRecipe((PlantType)((uint)1036), (PlantType)((uint)1032), (PlantType)((uint)908));
		MixData.AddOrderedRecipe((PlantType)((uint)1153), (PlantType)((uint)1034), (PlantType)((uint)908));
		MixData.AddOrderedRecipe((PlantType)((uint)1018), (PlantType)((uint)1107), (PlantType)((uint)908));
		MixData.AddOrderedRecipe((PlantType)((uint)1104), (PlantType)((uint)1103), (PlantType)((uint)909));
		MixData.AddOrderedRecipe((PlantType)((uint)1103), (PlantType)((uint)1104), (PlantType)((uint)909));
		MixData.AddOrderedRecipe((PlantType)((uint)1072), (PlantType)((uint)1046), (PlantType)((uint)910));
		MixData.AddOrderedRecipe((PlantType)((uint)1046), (PlantType)((uint)1072), (PlantType)((uint)910));
		MixData.AddOrderedRecipe((PlantType)((uint)1110), (PlantType)((uint)1102), (PlantType)((uint)911));
		MixData.AddOrderedRecipe((PlantType)((uint)1126), (PlantType)((uint)1119), (PlantType)((uint)914));
		MixData.AddOrderedRecipe((PlantType)((uint)1119), (PlantType)((uint)1126), (PlantType)((uint)914));
		MixData.AddOrderedRecipe((PlantType)((uint)1123), (PlantType)((uint)1040), (PlantType)((uint)915));
		MixData.AddOrderedRecipe((PlantType)((uint)1122), (PlantType)((uint)1179), (PlantType)((uint)953));
		MixData.AddOrderedRecipe((PlantType)((uint)1148), (PlantType)((uint)1128), (PlantType)((uint)916));
		MixData.AddOrderedRecipe((PlantType)((uint)1128), (PlantType)((uint)1148), (PlantType)((uint)916));
		MixData.AddOrderedRecipe((PlantType)((uint)1026), (PlantType)((uint)1157), (PlantType)((uint)924));
		MixData.AddOrderedRecipe((PlantType)((uint)1157), (PlantType)((uint)1026), (PlantType)((uint)924));
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x00055DDC File Offset: 0x00053FDC
	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0x40E5D0", Offset = "0x40CBD0", VA = "0x18040E5D0")]
	private static void SubInit()
	{
		MixData.AddOrderedRecipe((PlantType)((uint)958), (PlantType)((uint)19), (PlantType)((uint)996));
		MixData.AddOrderedRecipe((PlantType)((uint)996), (PlantType)((uint)1067), (PlantType)((uint)958));
		MixData.AddOrderedRecipe((PlantType)((uint)992), (PlantType)((uint)11), (PlantType)((uint)995));
		MixData.AddOrderedRecipe((PlantType)((uint)995), (PlantType)((uint)10), (PlantType)((uint)992));
		MixData.AddOrderedRecipe((PlantType)((uint)940), (PlantType)((uint)28), (PlantType)((uint)991));
		MixData.AddOrderedRecipe((PlantType)((uint)991), (PlantType)((uint)32), (PlantType)((uint)940));
		MixData.AddOrderedRecipe((PlantType)((uint)984), (PlantType)((uint)29), (PlantType)((uint)989));
		MixData.AddOrderedRecipe((PlantType)((uint)989), (PlantType)((uint)20), (PlantType)((uint)984));
		MixData.AddOrderedRecipe((PlantType)((uint)956), (PlantType)((uint)4), (PlantType)((uint)983));
		MixData.AddOrderedRecipe((PlantType)((uint)983), (PlantType)((uint)5), (PlantType)((uint)956));
		MixData.AddOrderedRecipe((PlantType)((uint)982), (PlantType)((uint)18), (PlantType)((uint)932));
		MixData.AddOrderedRecipe((PlantType)((uint)932), (PlantType)((uint)20), (PlantType)((uint)982));
		MixData.AddOrderedRecipe((PlantType)((uint)957), (PlantType)((uint)11), (PlantType)((uint)981));
		MixData.AddOrderedRecipe((PlantType)((uint)981), (PlantType)((uint)32), (PlantType)((uint)957));
		MixData.AddOrderedRecipe((PlantType)((uint)947), (PlantType)((uint)39), (PlantType)((uint)980));
		MixData.AddOrderedRecipe((PlantType)((uint)980), (PlantType)((uint)36), (PlantType)((uint)947));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)977), (PlantType)((uint)990));
		MixData.AddOrderedRecipe((PlantType)((uint)6), (PlantType)((uint)914), (PlantType)((uint)952));
		MixData.AddOrderedRecipe((PlantType)((uint)952), (PlantType)((uint)32), (PlantType)((uint)914));
		MixData.AddOrderedRecipe((PlantType)((uint)27), (PlantType)((uint)970), (PlantType)((uint)978));
		MixData.AddOrderedRecipe((PlantType)((uint)935), (PlantType)((uint)23), (PlantType)((uint)935));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)976), (PlantType)((uint)935));
		MixData.AddOrderedRecipe((PlantType)((uint)937), (PlantType)((uint)10), (PlantType)((uint)975));
		MixData.AddOrderedRecipe((PlantType)((uint)975), (PlantType)((uint)20), (PlantType)((uint)937));
		MixData.AddOrderedRecipe((PlantType)((uint)944), (PlantType)((uint)1), (PlantType)((uint)974));
		MixData.AddOrderedRecipe((PlantType)((uint)974), (PlantType)((uint)2), (PlantType)((uint)944));
		MixData.AddOrderedRecipe((PlantType)((uint)926), (PlantType)((uint)34), (PlantType)((uint)973));
		MixData.AddOrderedRecipe((PlantType)((uint)973), (PlantType)((uint)1067), (PlantType)((uint)926));
		int num = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)972), (PlantType)num, (PlantType)((uint)971));
		MixData.AddOrderedRecipe((PlantType)((uint)971), (PlantType)((uint)9), (PlantType)((uint)972));
		MixData.AddOrderedRecipe((PlantType)((uint)930), (PlantType)((uint)11), (PlantType)((uint)972));
		MixData.AddOrderedRecipe((PlantType)((uint)907), (PlantType)((uint)11), (PlantType)((uint)971));
		MixData.AddOrderedRecipe((PlantType)((uint)905), (PlantType)((uint)16), (PlantType)((uint)968));
		MixData.AddOrderedRecipe((PlantType)((uint)968), (PlantType)((uint)1), (PlantType)((uint)905));
		int num2 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)908), (PlantType)num2, (PlantType)((uint)987));
		int num3 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)929), (PlantType)num3, (PlantType)((uint)988));
		MixData.AddOrderedRecipe((PlantType)((uint)987), (PlantType)((uint)1), (PlantType)((uint)988));
		MixData.AddOrderedRecipe((PlantType)((uint)988), (PlantType)((uint)10), (PlantType)((uint)987));
		MixData.AddOrderedRecipe((PlantType)((uint)919), (PlantType)((uint)16), (PlantType)((uint)999));
		MixData.AddOrderedRecipe((PlantType)((uint)999), (PlantType)((uint)22), (PlantType)((uint)5000));
		MixData.AddOrderedRecipe((PlantType)((uint)22), (PlantType)((uint)999), (PlantType)((uint)5000));
		MixData.AddOrderedRecipe((PlantType)((uint)905), (PlantType)((uint)3), (PlantType)((uint)963));
		MixData.AddOrderedRecipe((PlantType)((uint)968), (PlantType)((uint)3), (PlantType)((uint)969));
		MixData.AddOrderedRecipe((PlantType)((uint)963), (PlantType)((uint)16), (PlantType)((uint)969));
		MixData.AddOrderedRecipe((PlantType)((uint)969), (PlantType)((uint)1), (PlantType)((uint)963));
		MixData.AddOrderedRecipe((PlantType)((uint)24), (PlantType)((uint)924), (PlantType)((uint)967));
		MixData.AddOrderedRecipe((PlantType)((uint)953), (PlantType)((uint)26), (PlantType)((uint)966));
		MixData.AddOrderedRecipe((PlantType)((uint)966), (PlantType)((uint)28), (PlantType)((uint)953));
		MixData.AddOrderedRecipe((PlantType)((uint)965), (PlantType)((uint)2), (PlantType)((uint)959));
		MixData.AddOrderedRecipe((PlantType)((uint)959), (PlantType)((uint)13), (PlantType)((uint)965));
		MixData.AddOrderedRecipe((PlantType)((uint)915), (PlantType)((uint)32), (PlantType)((uint)964));
		MixData.AddOrderedRecipe((PlantType)((uint)964), (PlantType)((uint)28), (PlantType)((uint)915));
		MixData.AddOrderedRecipe((PlantType)((uint)919), (PlantType)((uint)22), (PlantType)((uint)962));
		MixData.AddOrderedRecipe((PlantType)((uint)942), (PlantType)((uint)22), (PlantType)((uint)961));
		MixData.AddOrderedRecipe((PlantType)((uint)961), (PlantType)((uint)25), (PlantType)((uint)942));
		MixData.AddOrderedRecipe((PlantType)((uint)934), (PlantType)((uint)20), (PlantType)((uint)955));
		MixData.AddOrderedRecipe((PlantType)((uint)955), (PlantType)((uint)1), (PlantType)((uint)934));
		MixData.AddOrderedRecipe((PlantType)((uint)302), (PlantType)((uint)20), (PlantType)((uint)955));
		MixData.AddOrderedRecipe((PlantType)((uint)910), (PlantType)((uint)20), (PlantType)((uint)949));
		MixData.AddOrderedRecipe((PlantType)((uint)949), (PlantType)((uint)1070), (PlantType)((uint)910));
		MixData.AddOrderedRecipe((PlantType)((uint)902), (PlantType)((uint)23), (PlantType)((uint)948));
		MixData.AddOrderedRecipe((PlantType)((uint)948), (PlantType)((uint)13), (PlantType)((uint)902));
		MixData.AddOrderedRecipe((PlantType)((uint)927), (PlantType)((uint)1109), (PlantType)((uint)946));
		int num4 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)946), (PlantType)num4, (PlantType)((uint)927));
		MixData.AddOrderedRecipe((PlantType)((uint)943), (PlantType)((uint)3), (PlantType)((uint)945));
		MixData.AddOrderedRecipe((PlantType)((uint)945), (PlantType)((uint)28), (PlantType)((uint)943));
		MixData.AddOrderedRecipe((PlantType)((uint)901), (PlantType)((uint)22), (PlantType)((uint)939));
		MixData.AddOrderedRecipe((PlantType)((uint)928), (PlantType)((uint)31), (PlantType)((uint)938));
		MixData.AddOrderedRecipe((PlantType)((uint)938), (PlantType)((uint)11), (PlantType)((uint)928));
		MixData.AddOrderedRecipe((PlantType)((uint)933), (PlantType)((uint)7), (PlantType)((uint)904));
		MixData.AddOrderedRecipe((PlantType)((uint)904), (PlantType)((uint)21), (PlantType)((uint)933));
		MixData.AddOrderedRecipe((PlantType)((uint)906), (PlantType)((uint)3), (PlantType)((uint)931));
		MixData.AddOrderedRecipe((PlantType)((uint)931), (PlantType)((uint)1060), (PlantType)((uint)906));
		int num5 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)930), (PlantType)num5, (PlantType)((uint)907));
		MixData.AddOrderedRecipe((PlantType)((uint)907), (PlantType)((uint)9), (PlantType)((uint)930));
		MixData.AddOrderedRecipe((PlantType)((uint)908), (PlantType)((uint)1), (PlantType)((uint)929));
		MixData.AddOrderedRecipe((PlantType)((uint)929), (PlantType)((uint)10), (PlantType)((uint)908));
		MixData.AddOrderedRecipe((PlantType)((uint)916), (PlantType)((uint)32), (PlantType)((uint)923));
		MixData.AddOrderedRecipe((PlantType)((uint)923), (PlantType)((uint)26), (PlantType)((uint)916));
		MixData.AddOrderedRecipe((PlantType)((uint)909), (PlantType)((uint)22), (PlantType)((uint)920));
		MixData.AddOrderedRecipe((PlantType)((uint)920), (PlantType)((uint)23), (PlantType)((uint)909));
		MixData.AddOrderedRecipe((PlantType)((uint)911), (PlantType)((uint)2), (PlantType)((uint)922));
		MixData.AddOrderedRecipe((PlantType)((uint)922), (PlantType)((uint)21), (PlantType)((uint)911));
		MixData.AddOrderedRecipe((PlantType)((uint)903), (PlantType)((uint)29), (PlantType)((uint)921));
		MixData.AddOrderedRecipe((PlantType)((uint)921), (PlantType)((uint)2), (PlantType)((uint)903));
		MixData.AddOrderedRecipe((PlantType)((uint)900), (PlantType)((uint)2), (PlantType)((uint)917));
		MixData.AddOrderedRecipe((PlantType)((uint)917), (PlantType)((uint)8), (PlantType)((uint)900));
		MixData.AddOrderedRecipe((PlantType)((uint)913), (PlantType)((uint)4), (PlantType)((uint)925));
		MixData.AddOrderedRecipe((PlantType)((uint)925), (PlantType)((uint)1027), (PlantType)((uint)913));
		int num6 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)1109), (PlantType)num6, (PlantType)((uint)1168));
		int num7 = 0;
		MixData.AddOrderedRecipe((PlantType)((uint)1168), (PlantType)num7, (PlantType)((uint)1109));
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00056508 File Offset: 0x00054708
	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0x40E510", Offset = "0x40CB10", VA = "0x18040E510")]
	private static void SpecialPlant()
	{
		MixData.AddOrderedRecipe((PlantType)((uint)3), (PlantType)((uint)1027), (PlantType)((uint)1027));
		MixData.AddOrderedRecipe((PlantType)((uint)17), (PlantType)((uint)1060), (PlantType)((uint)1060));
		MixData.AddOrderedRecipe((PlantType)((uint)7), (PlantType)((uint)1070), (PlantType)((uint)1070));
		MixData.AddOrderedRecipe((PlantType)((uint)12), (PlantType)((uint)1067), (PlantType)((uint)1067));
		MixData.AddOrderedRecipe((PlantType)((uint)28), (PlantType)((uint)1120), (PlantType)((uint)1120));
		MixData.AddOrderedRecipe((PlantType)((uint)36), (PlantType)((uint)1247), (PlantType)((uint)1247));
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x0005658C File Offset: 0x0005478C
	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0x405750", Offset = "0x403D50", VA = "0x180405750")]
	private static void AddRecipe(PlantType a, PlantType b, PlantType c)
	{
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x0005659C File Offset: 0x0005479C
	[Token(Token = "0x6000EC3")]
	[Address(RVA = "0x405540", Offset = "0x403B40", VA = "0x180405540")]
	private static void AddOrderedRecipe(PlantType a, PlantType b, PlantType c)
	{
		Dictionary<ValueTuple<PlantType, PlantType>, PlantType> recipes = MixData._recipes;
		Dictionary<ValueTuple<PlantType, PlantType>, PlantType> recipes_random = MixData._recipes_random;
		bool flag;
		if (!flag)
		{
			Dictionary<PlantType, ValueTuple<PlantType, PlantType>> parentNodes = MixData._parentNodes;
			bool flag2;
			if (!flag2)
			{
				Dictionary<PlantType, ValueTuple<PlantType, PlantType>> parentNodes2 = MixData._parentNodes;
			}
		}
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x000565E4 File Offset: 0x000547E4
	[Token(Token = "0x6000EC4")]
	[Address(RVA = "0x40EF40", Offset = "0x40D540", VA = "0x18040EF40")]
	public static bool TryGetMix(PlantType a, PlantType b, [Out] PlantType c, bool order = true)
	{
		Dictionary<ValueTuple<PlantType, PlantType>, PlantType> recipes = MixData._recipes;
		bool flag;
		if (!flag)
		{
			if (!order)
			{
				Dictionary<ValueTuple<PlantType, PlantType>, PlantType> recipes2 = MixData._recipes;
				bool flag2;
				if (!flag2)
				{
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x0005661C File Offset: 0x0005481C
	[Token(Token = "0x6000EC5")]
	[Address(RVA = "0x40F0A0", Offset = "0x40D6A0", VA = "0x18040F0A0")]
	public static bool TryGetRandomMix(PlantType a, PlantType b, [Out] PlantType c)
	{
		Dictionary<ValueTuple<PlantType, PlantType>, PlantType> recipes_random = MixData._recipes_random;
		bool flag;
		if (!flag)
		{
			Dictionary<ValueTuple<PlantType, PlantType>, PlantType> recipes_random2 = MixData._recipes_random;
			bool flag2;
			if (!flag2)
			{
				return flag2;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00056650 File Offset: 0x00054850
	[Token(Token = "0x6000EC6")]
	[Address(RVA = "0x40F200", Offset = "0x40D800", VA = "0x18040F200")]
	public static void UpdateRandomMix()
	{
		ulong num2;
		do
		{
			List<ValueTuple<PlantType, PlantType>> list = Enumerable.ToList<ValueTuple<PlantType, PlantType>>(MixData._recipes_random.Keys);
			List<PlantType> list2 = new List(GameAPP.resourcesManager.allPlants);
			Predicate<PlantType> <>9__15_ = MixData.<>c.<>9__15_0;
			if (<>9__15_ == 0)
			{
				MixData.<>c.<>9__15_0 = delegate(PlantType p)
				{
					bool flag2;
					return flag2;
				};
			}
			int num = list2.RemoveAll(<>9__15_);
			bool flag;
			if (flag)
			{
				Dictionary<ValueTuple<PlantType, PlantType>, PlantType> recipes_random = MixData._recipes_random;
				PlantType random = ListExtensions.GetRandom<PlantType>(list2);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x000566D0 File Offset: 0x000548D0
	[Token(Token = "0x6000EC7")]
	[Address(RVA = "0x40EEB0", Offset = "0x40D4B0", VA = "0x18040EEB0")]
	public static bool TryGetDisMix(PlantType thePlantType, [TupleElementNames(new string[] { "left", "right" })] [Out] ValueTuple<PlantType, PlantType> data)
	{
		Dictionary<PlantType, ValueTuple<PlantType, PlantType>> parentNodes = MixData._parentNodes;
		bool flag;
		return flag;
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x000566EC File Offset: 0x000548EC
	[Token(Token = "0x6000EC8")]
	[Address(RVA = "0x40B7B0", Offset = "0x409DB0", VA = "0x18040B7B0")]
	private static void HandleSubUlti()
	{
		int num;
		do
		{
			num = 0;
			Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
			bool flag;
			if (flag)
			{
				Dictionary<PlantType, List<PlantType>> baseOfUltimatePlants = MixData.BaseOfUltimatePlants;
				bool flag2;
				while (!flag2)
				{
				}
				while (!flag2)
				{
				}
				Dictionary<PlantType, List<PlantType>> baseOfUltimatePlants2 = MixData.BaseOfUltimatePlants;
				List<PlantType> list = new List(num);
				bool flag3;
				while (!flag3)
				{
				}
				Dictionary<PlantType, List<PlantType>> baseOfUltimatePlants3 = MixData.BaseOfUltimatePlants;
				Dictionary<PlantType, List<PlantType>> baseOfUltimatePlants4 = MixData.BaseOfUltimatePlants;
			}
		}
		while (num != 0);
		int size = MixData.BaseOfUltimatePlants[(uint)976]._size;
		int size2 = MixData.BaseOfUltimatePlants[(uint)969]._size;
		int size3 = MixData.BaseOfUltimatePlants[(uint)901]._size;
		int size4 = MixData.BaseOfUltimatePlants[(uint)939]._size;
		int size5 = MixData.BaseOfUltimatePlants[(uint)940]._size;
		int size6 = MixData.BaseOfUltimatePlants[(uint)988]._size;
		int size7 = MixData.BaseOfUltimatePlants[(uint)988]._size;
		int size8 = MixData.BaseOfUltimatePlants[(uint)987]._size;
		int size9 = MixData.BaseOfUltimatePlants[(uint)916]._size;
		int size10 = MixData.BaseOfUltimatePlants[(uint)923]._size;
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x00056854 File Offset: 0x00054A54
	[Token(Token = "0x6000EC9")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MixData()
	{
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00056868 File Offset: 0x00054A68
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6000ECA")]
	[Address(RVA = "0x40F590", Offset = "0x40DB90", VA = "0x18040F590")]
	static MixData()
	{
		Dictionary<PlantType, List<PlantType>> dictionary = new Dictionary();
		List<PlantType> list = new List();
		int size = list._size;
		int size2 = list._size;
		List<PlantType> list2 = new List();
		int size3 = list2._size;
		int num = 0;
		list2._size = 1;
		list2._syncRoot = num;
		int size4 = list2._size;
		list2._size = 1;
		int size5 = list2._size;
		list2._size = 1;
		int size6 = list2._size;
		list2._size = 1;
		int size7 = list2._size;
		list2._size = 1;
		List<PlantType> list3 = new List();
		int size8 = list3._size;
		int size9 = list3._size;
		int size10 = list3._size;
		List<PlantType> list4 = new List();
		int size11 = list4._size;
		int size12 = list4._size;
		int size13 = list4._size;
		int size14 = list4._size;
		List<PlantType> list5 = new List();
		int size15 = list5._size;
		int size16 = list5._size;
		int size17 = list5._size;
		int size18 = list5._size;
		List<PlantType> list6 = new List();
		int size19 = list6._size;
		int size20 = list6._size;
		int size21 = list6._size;
		int size22 = list6._size;
		int size23 = list6._size;
		int size24 = list6._size;
		List<PlantType> list7 = new List();
		int size25 = list7._size;
		int size26 = list7._size;
		int size27 = list7._size;
		List<PlantType> list8 = new List();
		int size28 = list8._size;
		int size29 = list8._size;
		List<PlantType> list9 = new List();
		List<PlantType> list10 = new List();
		List<PlantType> list11 = new List();
		List<PlantType> list12 = new List();
		List<PlantType> list13 = new List();
		List<PlantType> list14 = new List();
		List<PlantType> list15 = new List();
		List<PlantType> list16 = new List();
		List<PlantType> list17 = new List();
		List<PlantType> list18 = new List();
		List<PlantType> list19 = new List();
		List<PlantType> list20 = new List();
		List<PlantType> list21 = new List();
	}

	// Token: 0x04000B0C RID: 2828
	[Token(Token = "0x4000B0C")]
	public static readonly Dictionary<ValueTuple<PlantType, PlantType>, PlantType> _recipes = new Dictionary();

	// Token: 0x04000B0D RID: 2829
	[Token(Token = "0x4000B0D")]
	public static readonly Dictionary<ValueTuple<PlantType, PlantType>, PlantType> _recipes_random = new Dictionary();

	// Token: 0x04000B0E RID: 2830
	[Token(Token = "0x4000B0E")]
	[TupleElementNames(new string[] { "left", "right" })]
	public static readonly Dictionary<PlantType, ValueTuple<PlantType, PlantType>> _parentNodes = new Dictionary();

	// Token: 0x04000B0F RID: 2831
	[Token(Token = "0x4000B0F")]
	public static Dictionary<PlantType, List<PlantType>> BaseOfUltimatePlants;
}
