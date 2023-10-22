﻿using System;
using System.Collections.Generic;
using System.Text;

public enum ProcessGroup
{
    PneumaticControllers,
    WellPadEquipmentLeaks,
    ChemicalInjectionPumps,
    Tanks,
    LiquidsUnloading
}

public enum Group
{
    PneumaticControllers,
    WellPadEquipmentLeaks,
    ChemicalInjectionPumps,
    Tanks,
    LiquidsUnloading
}

public enum Process
{ 
    Separators,
	Heaters,
	Dehydrators,
	MetersPiping,
	Compressors,
    HighBleed,
    LowBleed,
    IntermittentBleed,
    LargeTankswVRU,
    LargeTankswoControl,
    SmallTankswoFlares,
    MalfunctioningSeparatorDumpValves,
    LargeTankswFlares,
    SmallTankswFlares,
    LiquidsUnloadingwPlungerLifts,
    LiquidsUnloadingwoPlungerLifts
}

public enum Batches //Each value represent the origin of the stream
{
    NewEnglandProvince = 0, 
    AdirondackUplift = 1,
    AtlanticCoast = 2,
    SGASedimentaryProv = 3,
    FloridaPlatform = 4,
    PiedmontBlueRidgeProv = 5,
    Appalachian = 6,
    AppalachianEastb = 7,
    BlackWarrior = 8,
    MidGulfCoast = 9,
    GulfCoast = 10,
    Arkla = 11, 
    UpperMississippiEmbaymnt = 12,
    EastTexas = 13,
    CincinnatiArch = 14,
    Michigan = 15,
    Illinois = 16,
    SiouxUplift = 17,
    ForestCity = 18,
    Arkoma = 19,
    SouthOklahomaFoldedBelt = 20,
    ChautauquaPlatform = 21,
    Anadarko = 22,
    Cherokee = 23,
    NemahaAnticline = 24,
    Sedgwick = 25,
    Salina = 26,
    CentralKansasUplift = 27,
    ChadronArch = 28,
    Williston = 29,
    OuachitaFoldedBelt = 30,
    Kerr = 31,
    LlanoUplift = 32,
    Strawn = 33,
    FortWorthSyncline = 34,
    BendArch = 35,
    Permian = 36,
    PaloDuro = 37,
    SierraGrandeUplift = 38,
    LasAnimasArch = 39,
    LasVegasRaton = 40,
    Estancia = 41,
    Orogrande = 42,
    Pedregosa = 43,
    BasinAndRangeProvince = 44,
    SweetgrassArch = 45,
    NorthWesternOverthrust = 46,
    MontanaFoldedBelt = 47,
    CentralWesternOverthrust = 48,
    SouthWesternOverthrust = 49,
    CentralMontanaUplift = 50,
    PowderRiver = 51,
    BigHorn = 52,
    YellowstoneProvince = 53,
    WindRiver = 54,
    GreenRiver = 55,
    Denver = 56,
    NorthPark = 57,
    SanLuis = 58,
    Uinta = 59,
    SanJuan = 60,
    Paradox = 61,
    BlackMesa = 62,
    Piceance = 63,
    SnakeRiver = 64,
    SouthernOregon = 65,
    GreatBasinProvince = 66,
    OverthrustWasatchUplift = 67,
    PlateauSedimentaryProv = 68,
    Mojave = 69,
    Salton = 70,
    SierraNevadaProvince = 71,
    WesternColumbia = 72,
    EelRiver = 73,
    NorthernCoastRangeProv = 74,
    Sacramento = 75,
    SantaCruz = 76,
    Coastal = 77,
    SanJoaquin = 78,
    SantaMaria = 79,
    Ventura = 80,
    LosAngeles = 81,
    Capistrano = 82,
    SoutheasternAlaskaProvinces = 83,
    GulfofAlaska = 84,
    CopperRiver = 85,
    AKCookInlet = 86,
    AlaskaPeninsulaProvince = 87,
    YukonPorcupineProvince = 88,
    YukonKoyukukProvince = 89,
    BristolBay = 90,
    SelawikLowland = 91,
    InteriorLowlands = 92, 
    SouthernFoothillsProvince = 93,
    NorthernFoothillsProvince = 94,
    ArcticCoastalPlainsProvince = 95
}