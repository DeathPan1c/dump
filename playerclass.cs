internal class Player : AttackableEntity, EAHHEDNCJAL, MPICKNDAPEB, AEPAPLNNAHF, IReusableObjectOwner, IJOMOIINJGM, EHCKCDIGOGA
{
	// Fields
	private Dictionary`2 OPBLJKHBGEJ; // 0x54
	private Dictionary`2 NMOMIKCJDOL; // 0x58
	private readonly Dictionary`2 AAADOILNGEG; // 0x5c
	private readonly Dictionary`2 OPDKANIJGIF; // 0x60
	public Boolean IsFrozenKnockDown; // 0x64
	private Boolean PNNPNDDJCPN; // 0x65
	private List`1 GHJDIFDEAAL; // 0x68
	private Comparison`1 FNKBPNLMFJB; // 0x6c
	private List`1 IACDLHNBMHB; // 0x70
	private List`1 MANELMHNBAD; // 0x74
	private List`1 BCDNABEJFGC; // 0x78
	private Comparison`1 KLMOPHNJPHG; // 0x7c
	private List`1 IIOOJJEAFHC; // 0x80
	private UInt32 BFAAGOEPLBF; // 0x84
	private Vector3 FODACOFDEIG; // 0x88
	public Boolean UsePhysicalCharacterController; // 0x94
	public Boolean UGCRequestJump; // 0x95
	public Boolean UGCStartFiring; // 0x96
	public Int32 JumpCount; // 0x98
	private PhysicalCCT <EABEPPMPHKC>k__BackingField; // 0x9c
	private Vector3 CGJANGNOOLC; // 0xa0
	public static FCMBLDHNOHF m_PlayerFiringEvt; // 0x0
	public static DDMILIACFIC m_PlayerHPChangeEvt; // 0x4
	public static DLFEOLBDFKA m_PlayerEPChangeEvt; // 0x8
	public static OKGHHBPDGHC m_PlayerIncreaseShootAndMoveSpeedSyncEvt; // 0xc
	public static IKDEJMGMILF m_PlayerTeamShieldEvt; // 0x10
	public static AFADPNBAGLP m_PlayerSerachEvt; // 0x14
	public static EOFBFKLCDDJ m_PlayerAimEvt; // 0x18
	public static OJDFBPCOMDI PlayerSkillBrightEvt; // 0x1c
	public static MJKEKGLHAMP PetSkillBrightEvt; // 0x20
	public static GELBANBIAFF PlayerSkillPassiveCDEvt; // 0x24
	public static MMPIEJKOJIC PetSkillCDEvt; // 0x28
	public static LLCEIGHFLNB HudPlayerSkillBrightAnimEvt; // 0x2c
	public static CCNMCCCJONJ HudPetSkillBrightAnimEvt; // 0x30
	public static HCEJOAHLIKL HudPlayerSkillFlashAnimEvt; // 0x34
	public static JBNAMFMEBLO HudPetSkillFlashAnimEvt; // 0x38
	public static LMNICFDFNHN HudPetSkillChangeIconEvt; // 0x3c
	public static JEPGMPGLDGE HudPlayerSkillPassiveCDAnimEvt; // 0x40
	public static PELPOCIMEGP HudPetSkillCDAnimEvt; // 0x44
	public static FEAEHNIGMNJ m_LocalPlayerHitEvt; // 0x48
	public static OJODLBKFIJE m_LPickupAreaEvt; // 0x4c
	public static MIPLPFJMEEB m_PickupAreaEvt; // 0x50
	public static HIODOKPEHOP m_PreparationCancelEvt; // 0x54
	public static IMEKLOAHDEO m_PlayerSPChangeEvt; // 0x58
	public static CADCMIJEDME hitArmorEvent; // 0x5c
	public static FAHCMOCMCCL PlayerIDEvt; // 0x60
	public static ABMEBJBPEKH PlayerBoolStateEvt; // 0x64
	public static MEHFBLNMCOC PlayerKillEvt; // 0x68
	public static FJANPKJAMOP PersonaHitEvt; // 0x6c
	public static BCHJMJGAMBM PersonaBreakEvt; // 0x70
	public static HKHIFHDMIIL PlayerChangeTeamEvt; // 0x74
	public Dictionary`2 InventoryMap3P; // 0xac
	public LevelBombModeBomb TriggerBombModeBomb; // 0xb0
	protected EEKDOKOEAEO PIGAJKODKBC; // 0xb4
	protected Dictionary`2 FBPNBBGKMLG; // 0xb8
	protected ResourceID IMLEGFGAJOO; // 0xbc
	protected UInt32 DMLMMBJBPOE; // 0xc0
	protected GameObject JILKEHHLFBK; // 0xc4
	protected ResourceID EPBLCLECCNB; // 0xc8
	private Dictionary`2 ECEIBFFDDHB; // 0xcc
	private Dictionary`2 PHBFMAGNIFD; // 0xd0
	private Dictionary`2 KGMAEMIGPKB; // 0xd4
	private Dictionary`2 DLKOOFLDPKJ; // 0xd8
	protected GameObject DIANKKBHJHC; // 0xdc
	protected UInt32 FINENGEJCNH; // 0xe0
	public Boolean isInZeppelin; // 0xe4
	protected UInt32 HLGGDPMJEHM; // 0xe8
	private Boolean HCKCBDKPJCP; // 0xec
	private Boolean FMJKOEAAPPA; // 0xed
	private Single MLLGIEIPEHA; // 0xf0
	private Single CDKELFDHGOO; // 0xf4
	protected Boolean NBGAEDGPOKI; // 0xf8
	protected GameObject LGIIDLGLPLD; // 0xfc
	private Dictionary`2 JPOMMBKDIMP; // 0x100
	public List`1 m_PendingMovePlatformList; // 0x104
	protected Vector3 PCFINADABHD; // 0x108
	public Boolean UseAimForwardAsForward; // 0x114
	public Boolean NeedShowVehicleScanTips; // 0x115
	public Boolean NeedShowVehicleFortressTips; // 0x116
	private Boolean GMJEGIKDPDH; // 0x117
	public Boolean IsPersonaEPDown; // 0x118
	public Boolean IsPersonaEPUp; // 0x119
	public Action LateUpdateFunc; // 0x11c
	protected Boolean JEPFNELBGID; // 0x120
	protected Vector3 LCCDDPEKKDE; // 0x124
	private Single CHLOKGFHEOC; // 0x130
	private Action BDEOJGEKKHM; // 0x134
	private Single GBOGIKIHPBJ; // 0x138
	private Single KBNILIJPKAD; // 0x13c
	public static Single REQUEST_STROP_ACTION_CD; // 0x78
	public static CJKJKAEMMAO s_bbUpdateRes; // 0x7c
	private static List`1 IHJGOBGIIAO; // 0x80
	private static Dictionary`2 BNEHNKGFPFH; // 0x84
	protected readonly Dictionary`2 LFOKBMLEIML; // 0x140
	private Boolean <LLAOOKFCGMA>k__BackingField; // 0x144
	private Single <HDMNMKLLGCJ>k__BackingField; // 0x148
	private List`1 LHHKCOLGEEI; // 0x14c
	private EmoteLeaderCollider OJJCNCMFPKE; // 0x150
	protected GameObject FHNKEFAOCLO; // 0x154
	protected Boolean DPJJPHKPJMG; // 0x158
	public UInt32 m_KnockDownDamagePerSec; // 0x15c
	private Boolean DBPAMBCJLMH; // 0x160
	protected UInt32 EPCJCNCOIPM; // 0x164
	private MJFNDLDGOCL OJJBENJMFBL; // 0x168
	private FJPAMHIOBOG HHDCFDLCCKM; // 0x16c
	private OGLOLLNEBAC <FBGDEHKPDOC>k__BackingField; // 0x170
	private ResourceID PHPEJILBMLM; // 0x174
	private Boolean IDHAHLLBEAO; // 0x178
	public Transform MainCameraTransform; // 0x17c
	private NILHJAFNEJL HMMIKFIACJD; // 0x180
	private UInt32 CJBNJOLJKAB; // 0x184
	protected UInt64 KMIBPHEHDNG; // 0x188
	public Boolean IsCadet; // 0x190
	protected IHAAMHPPLMG KFMGKCJMCAM; // 0x198
	protected Boolean KCADLABCONA; // 0x1b0
	protected UInt64 PLELBLDOAPF; // 0x1b8
	private Int32 <NICENMJCIPK>k__BackingField; // 0x1c0
	public UInt32 TeamModeID; // 0x1c4
	public Boolean IsShowEquip; // 0x1c8
	private IHAAMHPPLMG <HMJPPFALOLK>k__BackingField; // 0x1d0
	private UInt32 <HMENLODKOJA>k__BackingField; // 0x1e8
	private String <GDJEPAJNGKN>k__BackingField; // 0x1ec
	private String <OLHGDLCEKFG>k__BackingField; // 0x1f0
	private UInt32 <PBPCPGHHADI>k__BackingField; // 0x1f4
	private UInt32 <KIMHOMFJEAN>k__BackingField; // 0x1f8
	public Boolean PartyGameComboChanged; // 0x1fc
	public UInt32 PartyGameMusicShootingIndex; // 0x200
	public UInt32 ServerGameMusicShootingIndex; // 0x204
	protected Object NCNCLJHGEOF; // 0x208
	protected String OIAJCBLDHKP; // 0x20c
	public Boolean IsClientBot; // 0x210
	private Boolean FHGIKLGCPJE; // 0x211
	private UInt64 MGCDPGDFKBD; // 0x218
	private List`1 IFBNGCILJML; // 0x220
	protected Boolean IABKCAGKPAK; // 0x224
	private Boolean <LGLDBAFAKAO>k__BackingField; // 0x225
	private EPreparationTimerType FOJINOHOGAF; // 0x228
	protected TBlackBoard CJMCGPFMHAB; // 0x22c
	protected UserControlHandler LAHBMONIOOI; // 0x230
	protected CharacterController HLMCNIKBHOB; // 0x234
	private Boolean DMMCDMPIDLD; // 0x238
	private Boolean GLMGFCFOCJE; // 0x239
	private UInt32 JMOOAILMPEE; // 0x23c
	private Boolean LMFGJEMJCJM; // 0x240
	private Boolean EFICBKLKKKL; // 0x241
	protected UInt32 HPDKELNKDGG; // 0x244
	protected Boolean MIBGJAJIHFE; // 0x248
	protected UInt32 AEIJOOHLMME; // 0x24c
	public Boolean m_GetInVehicle; // 0x250
	private Boolean <CCNDLIBNOFC>k__BackingField; // 0x251
	private Boolean <APPMNFIOHBG>k__BackingField; // 0x252
	private Boolean <IIFBIIKDKCP>k__BackingField; // 0x253
	private Boolean <ACCOOGCNEKI>k__BackingField; // 0x254
	private Boolean <IONDGFBFFJB>k__BackingField; // 0x255
	private EPlayerLastKillState <NGGDOPGPDLP>k__BackingField; // 0x258
	private Boolean <NAECCHFPMDI>k__BackingField; // 0x25c
	private Boolean JKNFBBGBNJK; // 0x25d
	protected LevelAmmoBox CKJEHEKAJOO; // 0x260
	private UInt32 <GBJDMPNADHL>k__BackingField; // 0x264
	private String <OKFFHNAPPHD>k__BackingField; // 0x268
	private Boolean <NMHBCLGBEIF>k__BackingField; // 0x26c
	public Vector3 TeamMapMark; // 0x270
	public Boolean ShowMapMark; // 0x27c
	public Boolean ShowMarkBtn; // 0x27d
	public UInt32 CachedLastDriveVehicleObjID; // 0x280
	public Single InCount; // 0x284
	public Single UnCount; // 0x288
	public UInt32 GetCount; // 0x28c
	public UInt32 AimCount; // 0x290
	private Quaternion JNODEFADBAF; // 0x294
	public Single Speed; // 0x2a4
	private Single PDNLLLONJBN; // 0x2a8
	private Queue`1 PFJKJCJBDGO; // 0x2ac
	public Single ACount; // 0x2b0
	private Boolean PGCJIBDBOJP; // 0x2b4
	private Boolean KPGGOFKKNIA; // 0x2b5
	private Boolean OMFDILIAFGM; // 0x2b6
	private Boolean KFGOHPPJAJH; // 0x2b7
	private Boolean MBFFLKDNEDG; // 0x2b8
	private Boolean HHCAANFPELO; // 0x2b9
	private Single IGDKGBDOHOH; // 0x2bc
	protected AvatarEffect AOOAPNCMNCH; // 0x2c0
	protected GameObject OMJJGPDDDGG; // 0x2c4
	protected PropAnimComponent OBCLHOEJBBP; // 0x2c8
	protected GameObject MMOGANEKGEK; // 0x2cc
	protected ResourceID HFOLDNAACED; // 0x2d0
	protected BattleFlagConfigData FCDOOAJKAML; // 0x2d4
	public Boolean IsUsingRescureZone; // 0x2d8
	protected IEnumerator DNKNEGKDJDO; // 0x2dc
	protected IEnumerator BKFPKJLJAAA; // 0x2e0
	protected IEnumerator EIGLFLJMLHO; // 0x2e4
	private UInt32 GBEMKMLPOEA; // 0x2e8
	private Boolean BGAMNOEPHNO; // 0x2ec
	private UInt32 BEPELMPKJDC; // 0x2f0
	private UInt32 FHPIKFBDLCP; // 0x2f4
	private Int32 JEIOBBMLPJM; // 0x2f8
	private Int32 CFAENHCOBFE; // 0x2fc
	private Int32 NDHGEHGINNC; // 0x300
	public Boolean lockTransformMusicWhenUpdate; // 0x304
	private UInt32 BPLDFKIIOGE; // 0x308
	private UInt32 ACBJKAIDELD; // 0x30c
	public GPBDEDFKJNA ActiveUISightingWeapon; // 0x310
	protected KCMNBMDPNAK EABOMEAANJM; // 0x314
	public Boolean NextFireActionFromAuxButton; // 0x318
	private Quaternion <KCFEHMAIINO>k__BackingField; // 0x31c
	private Quaternion <DJEKDGNFJJG>k__BackingField; // 0x32c
	public GINHBFJPFBP m_AimAssist; // 0x33c
	public DEBPBFOAHKI m_AimAssistForIceWall; // 0x340
	private Boolean <MJKMHJJJJGL>k__BackingField; // 0x344
	private Single AEDMMIKNECI; // 0x348
	private Boolean PCLBMKFOOEB; // 0x34c
	private Boolean GOGABLALMMG; // 0x34d
	private Boolean PBBJJHIOFBF; // 0x34e
	private HashSet`1 KGPKDHENIEF; // 0x350
	private EAimAssist GNBLLOPNPNG; // 0x354
	private FFNBBHKEDAE CPOKMKOBMGM; // 0x358
	private NLIOCEKCAOF FCOGKEMNFIH; // 0x35c
	protected CEPIKIJENLK FBNJKPALJEE; // 0x360
	protected FollowCamera CHDOHNOEBML; // 0x364
	protected ITransformNode GCMICMFEAKI; // 0x368
	protected ITransformNode OLCJOGDHJJJ; // 0x36c
	protected ITransformNode OLJBCONDGLO; // 0x370
	protected ITransformNode HCLMADAFLPD; // 0x374
	protected ITransformNode PFHDPLOAENC; // 0x378
	protected ITransformNode CENAIGAFGAG; // 0x37c
	protected ITransformNode MPJBGDJJJMJ; // 0x380
	protected ITransformNode JPBJIMCDBHN; // 0x384
	protected ITransformNode BMGCHFGEDDA; // 0x388
	protected ITransformNode AGHJLIMNPJA; // 0x38c
	protected ITransformNode FDMBKCKMODA; // 0x390
	protected ITransformNode CKABHDJDMAP; // 0x394
	protected ITransformNode KOCDBPLKMBI; // 0x398
	protected Transform EKEIMDDMFDG; // 0x39c
	protected ITransformNode LIBEIIIAGIK; // 0x3a0
	protected ITransformNode HDEPJIBNIIK; // 0x3a4
	protected ITransformNode NJDDAPKPILB; // 0x3a8
	protected ITransformNode JHIBMHEMJOL; // 0x3ac
	protected ITransformNode JBACCHNMGNJ; // 0x3b0
	protected ITransformNode FGECMMJKFNC; // 0x3b4
	protected Collider HECFNHJKOMN; // 0x3b8
	protected NPCNMJAGIKI COLEAPKGFLK; // 0x3bc
	protected NJKAFIOELHI ANMJONGHENN; // 0x3c0
	private Boolean GPCPBJJOHFD; // 0x3c4
	protected NewPlayerAnimationSystemComponent HFKJCLHCBGB; // 0x3c8
	public FPAMKKJBMPD m_UGCPlayerAnimPort; // 0x3cc
	protected PlayerAttributes JKPFFNEMJIF; // 0x3d0
	protected AvatarManager FOGJNGDMJKJ; // 0x3d4
	protected AvatarDynamicEffectManager ICCHKILHLFH; // 0x3d8
	protected AvatarPropManager IOFIHCKMFJG; // 0x3dc
	protected PropertyData OOABFDMBHHM; // 0x3e0
	protected BigHeadComponent LBDJPFMEJIK; // 0x3e4
	protected BigHeadDataConfig DNHHAHENHLA; // 0x3e8
	protected Single NIDPPKIOHNC; // 0x3ec
	protected Boolean BEMKJMCNFHL; // 0x3f0
	protected GameObject IBPFHDNFENM; // 0x3f4
	private IceWallMakerData NPEKPHFPJAG; // 0x3f8
	private Boolean <KDIONBJOKOM>k__BackingField; // 0x3fc
	private Boolean <DLAPBLCDAHL>k__BackingField; // 0x3fd
	protected NavMeshAgent KLDDNDJLFJB; // 0x400
	private NetworkPet <KKIEBALJHEO>k__BackingField; // 0x404
	private Boolean OEOILKGEMEP; // 0x408
	public Boolean PetForceHide; // 0x409
	private Boolean PAGELNJPFBJ; // 0x40a
	private Boolean <CDOCOAAGAMM>k__BackingField; // 0x40b
	private Boolean BFCJOEFIADO; // 0x40c
	private Boolean <OPDNPGDMNKL>k__BackingField; // 0x40d
	private UInt32 <IJHGFDOKMCC>k__BackingField; // 0x410
	private Single OPLPDHICHEI; // 0x414
	private Vector3 GIAOCFNMKLP; // 0x418
	private Single FLJONGPCEHE; // 0x424
	public const Single RECOVER_FROM_HIT_FLY_INTERVAL; // 0x0
	public DAPMAMPECCF HitFlyInfo; // 0x428
	private Boolean KCOKFMECBHB; // 0x42c
	private Single MNDBDFDOLNL; // 0x430
	protected Boolean LJHKFOOOPBF; // 0x434
	protected const Int32 IFCJNDPCMAL; // 0x0
	public UInt32 CallSetAimRotationCount; // 0x438
	public String TeamColorStr; // 0x43c
	protected EMEHJLLMKNM JNGKBJICFLK; // 0x440
	protected TBTAction FODOLHEPEFD; // 0x444
	protected ILJPBIDGCDL KCOLAEGJAEP; // 0x448
	protected TBTAction OIBPDDEFIAG; // 0x44c
	protected TBTAction JOCAKHKNJMH; // 0x450
	private Boolean <LPEIEILIKGC>k__BackingField; // 0x454
	private LMAFDMFMENA KJCBIJIFNFL; // 0x458
	private Boolean NFCDJDLOMEA; // 0x45c
	private EntityInfo ECOLJBKKDPP; // 0x460
	private EntityInfo GAGAEIMAFJC; // 0x474
	protected List`1 DKNKEDPODIN; // 0x488
	protected List`1 CENJPNDNFIB; // 0x48c
	protected Int32 OEIIPIHDPKP; // 0x490
	protected Vector3 NLPNKFGICKN; // 0x494
	protected Vector3 ENJJHJECMFE; // 0x4a0
	protected Boolean OAHCAPCEACE; // 0x4ac
	protected Boolean CPOAHAKEDPO; // 0x4ad
	private List`1 EFKFHDFLCOG; // 0x4b0
	private List`1 DFKLDJGEJDE; // 0x4b4
	private List`1 NNPAMCIOGNJ; // 0x4b8
	private Dictionary`2 MGHBEOAIGPJ; // 0x4bc
	private List`1 OPOHCIOFMOC; // 0x4c0
	private ClimbingTrigger FNJKEGLPPFP; // 0x4c4
	private Collider CGHACLMNLGN; // 0x4c8
	public LevelDoor CurProcessLevelDoor; // 0x4cc
	protected Vector3 HJHFAJACFLD; // 0x4d0
	protected Vehicle JGDCKBFOKNO; // 0x4dc
	public LevelTechBuildSafeZoneController m_SafeZoneCtrlIAmIn; // 0x4e0
	protected LevelStrop KGJEAPMNDDB; // 0x4e4
	protected Int32 MJLLKKDEHML; // 0x4e8
	protected Boolean IKPPEFBMNCO; // 0x4ec
	protected Single BIKAGOIAIEB; // 0x4f0
	public Boolean IsStropDash; // 0x4f4
	protected FerrisWheelSeatGroup EOBIOOMCFHE; // 0x4f8
	protected Single JOHPBBFACND; // 0x4fc
	protected Single BAGNGLOAHNA; // 0x500
	protected Boolean EJHKFCHEDEM; // 0x504
	protected Vector3 CNNOGCAKGMB; // 0x508
	protected Vector3 BNADCHBCHDI; // 0x514
	protected Vector3 HLBKGMGKJDK; // 0x520
	protected Vector3 KMACLGBOIMA; // 0x52c
	protected LevelChair MMAENOBNBFH; // 0x538
	protected LevelCatapult DBEFOKEBPHG; // 0x53c
	protected LevelCannon HAFOKBEGIGK; // 0x540
	protected Quaternion CFKFFLJPAPL; // 0x544
	protected Quaternion JBNNBONFKKM; // 0x554
	protected LevelFerrisWheel OPFJPFCGKDC; // 0x564
	protected ITransformNode DHKPNBNNDBN; // 0x568
	protected ITransformNode HBFFGGLPDPL; // 0x56c
	protected ITransformNode DJFFMJAKGGA; // 0x570
	protected ITransformNode CIDGDIKNJNM; // 0x574
	protected ITransformNode EBOBKMBNJJK; // 0x578
	private Single OCCKMDJJIGC; // 0x57c
	private Single PCJAEDCHCPK; // 0x580
	private AudioResource LCKMHBAGOCH; // 0x584
	protected Vector3 IEDMBMHFEBN; // 0x588
	protected LevelGrapplingHook IAFEPPDJILB; // 0x594
	private PlayerLagHint LDKNCJNCPOC; // 0x598
	protected LevelSwingSpider CJGLIGGAILO; // 0x59c
	protected Boolean DFJLHMCEGOE; // 0x5a0
	protected UInt32 KFHIIKIDKLC; // 0x5a4
	protected Single EHAEIDEHDMB; // 0x5a8
	private Boolean <LNMELDPHJND>k__BackingField; // 0x5ac
	private Boolean <FEKDPENFNFC>k__BackingField; // 0x5ad
	private UInt32 LNKHKNJHKCM; // 0x5b0
	private Boolean <NEHPFAFDLMG>k__BackingField; // 0x5b4
	private Boolean <BEKHBKEPPGP>k__BackingField; // 0x5b5
	protected Boolean ODFGIJCAPAO; // 0x5b6
	protected Vector3 AAANOLNNEDP; // 0x5b8
	protected Vector3 BOPHBENCCDF; // 0x5c4
	protected Boolean PEHEHEMMFPI; // 0x5d0
	protected Boolean GCNDHHGDCEA; // 0x5d1
	protected Vector3 FAJDAHLIECL; // 0x5d4
	public Int32 BlockUserControlExceptCancel; // 0x5e0
	private Boolean <GDFPFHMONMF>k__BackingField; // 0x5e4
	private Boolean <GNINDNFAMJF>k__BackingField; // 0x5e5
	private Boolean <CCFMDCOMFAK>k__BackingField; // 0x5e6
	private Boolean <LIANBOIJIDO>k__BackingField; // 0x5e7
	private Boolean <NBNMJPGCKMM>k__BackingField; // 0x5e8
	private Boolean PFBKKKHFOPK; // 0x5e9
	private Boolean OMKCMEOOPKA; // 0x5ea
	private Boolean APEAIMDNPPM; // 0x5eb
	private Boolean EDPCMDPGDOH; // 0x5ec
	private Boolean <PONPMCPHJCG>k__BackingField; // 0x5ed
	private Boolean CHCBNPEHMHH; // 0x5ee
	protected const UInt32 KLEIOAKEPBK; // 0x0
	protected const UInt32 ELIMKHFAEEJ; // 0x0
	protected const UInt32 HDCGPMEBADA; // 0x0
	protected const UInt32 IACELDMIMMP; // 0x0
	protected const UInt32 LCOOIAMLDPH; // 0x0
	protected const UInt32 DECLAGAPDFG; // 0x0
	protected const UInt32 JKPIDABDNPA; // 0x0
	protected const UInt32 PABPLOKMJJJ; // 0x0
	protected const UInt32 MBBCLLGLKAN; // 0x0
	protected const UInt32 MDFEFNKBAMF; // 0x0
	protected const UInt32 AOPDCLHKLEA; // 0x0
	protected const UInt32 BBABEKBLAII; // 0x0
	protected const UInt32 DAACOBELADE; // 0x0
	protected const UInt32 PCJGCIMIJLP; // 0x0
	protected const UInt32 GGBBNBMCDIK; // 0x0
	protected const UInt32 BGCAPAJFHCE; // 0x0
	protected BitArrayBoolean NAPHEFGOPOK; // 0x5f0
	public const UInt32 ISVISIBLE_CAMERA; // 0x0
	public const UInt32 ISVISIBLE_VEHICLE; // 0x0
	public const UInt32 ISVISIBLE_STREAMER; // 0x0
	public const UInt32 ISVISIBLE_ONBOARD; // 0x0
	public const UInt32 ISVISIBLE_SKILL; // 0x0
	public const UInt32 ISVISIBLE_ALIVE; // 0x0
	public const UInt32 ISVISIBLE_INCUTSCENE; // 0x0
	public const UInt32 ISVISIBLE_PRI; // 0x0
	public const UInt32 ISVISIBLE_Transform; // 0x0
	public const UInt32 ISVISIBLE_ZoneChange; // 0x0
	public const UInt32 ISVISIBLE_Animation; // 0x0
	public const UInt32 ISVISIBLE_WereWolfDead; // 0x0
	public const UInt32 ISVISIBLE_SceneEdit; // 0x0
	public const UInt32 ISVISIBLE_PHOTOGRAPH; // 0x0
	public const UInt32 ISVISIBLE_UGCVISIBILITY; // 0x0
	public const UInt32 ISVISIBLE_WAITING_CABIN; // 0x0
	public const UInt32 ISVISIBLE_LASTKILL; // 0x0
	public const UInt32 ISVISIBLE_LEAVING; // 0x0
	public const UInt32 ISVISIBLE_FPP_Mode; // 0x0
	public const UInt32 ISVISIBLE_Fligh_Async_Load; // 0x0
	public const UInt32 ISVISIBLE_DynamicPVS; // 0x0
	private UInt32 KAJNNEADLLJ; // 0x5f4
	protected BitArrayBoolean FAGCPHGJGPI; // 0x5f8
	protected Boolean GOOIOCALNNN; // 0x5fc
	protected Transform DEDJAOIJKFM; // 0x600
	protected List`1 DPNPDAMCHDD; // 0x604
	public Boolean IsSkillActive; // 0x608
	private Boolean BGJPEMHLKEF; // 0x609
	private Boolean JEBPFCDCOEA; // 0x60a
	private Texture2D PMAICELBPPI; // 0x60c
	private Single NHCOJPPFDPB; // 0x610
	private Single FPCAFLLFFDF; // 0x614
	private Single LGNMDAJBNCP; // 0x618
	private const Single PMCMIKOFPCI; // 0x0
	private const Single NDOEAKINCFF; // 0x0
	private MADMMIICBNN BOALKMLCEKO; // 0x61c
	private GAGILKKDDMJ JJCIEFCHDII; // 0x620
	private MADMMIICBNN HMDJANMFEAF; // 0x624
	private CapsuleHuman KHEEBPOHHMD; // 0x628
	private CapsuleCollider PLFOAPLCNJJ; // 0x62c
	private readonly Single DAJBPLPGKEO; // 0x630
	private readonly Vector3 HFJEKJLAAGG; // 0x634
	private Boolean AKHCEAJPHBC; // 0x640
	private GameObject JMIBMIHFPLI; // 0x644
	private List`1 AIDDOCAPFKA; // 0x648
	private AudioResource LCBECEOKKON; // 0x64c
	private AudioResource FEEPOCJJIFE; // 0x650
	private AudioResource EBAEDIHDKBA; // 0x654
	private AudioResource GCMBPHHLCEA; // 0x658
	private AudioSource BOFJNDEHEDF; // 0x65c
	private AudioResource FJIAAIFGCGG; // 0x660
	protected Boolean HGMCDMLCDNM; // 0x664
	protected Boolean DNPBOLIHBOH; // 0x665
	protected Boolean GGECEALLDLB; // 0x666
	protected Boolean KAJMBOKIEGC; // 0x667
	protected Int32 FOMENKLPKOK; // 0x668
	private CBOODHNHCFN JBEEHMKNFLK; // 0x66c
	private List`1 DFHGFIABMPA; // 0x670
	private AEBBGMIGCDL BBLIPLPFGPD; // 0x674
	private LevelLockBountyVehicle IIEIHDNIAKA; // 0x678
	private LevelBountyBox DJBFOEPJPIO; // 0x67c
	private LevelWeRunBox HOPHBADLACN; // 0x680
	private PKLAGHHKOPO BMNPJLPCAHG; // 0x684
	private GBJAEPHNFMD FOFFJBPHJEN; // 0x688
	private UInt32 <AKJAMLCCNCP>k__BackingField; // 0x68c
	private Single CFBBENDFAJB; // 0x690
	private Single EJJCNCMMPJG; // 0x694
	public Single LevelInstrumentUseCDEndTime; // 0x698
	public Single LevelWishingTreeUseCDEndTime; // 0x69c
	public Single WaitingCupUseCDEndTime; // 0x6a0
	private Boolean OMIOGAMPNCO; // 0x6a4
	private Single BGIHFDHDBBL; // 0x6a8
	private Boolean LIGAAGBGKMA; // 0x6ac
	private Boolean <CDOBMFNCJHD>k__BackingField; // 0x6ad
	private Byte <KGEEJEELIKB>k__BackingField; // 0x6ae
	private Boolean FDBCFNNEIFJ; // 0x6af
	protected Boolean DLKHKAEKCJF; // 0x6b0
	protected Single KFMADIEPNPD; // 0x6b4
	protected MANEMECPKIO CEIEIBMLCGB; // 0x6b8
	private UInt32 DLHGENMCDKC; // 0x6bc
	protected ResourceID PGKGMOIFFFI; // 0x6c0
	protected ResourceID BHLLEKOLGGE; // 0x6c4
	protected SkyboardData HLBFHIPPHMG; // 0x6c8
	protected FlightData FHOPNAMDKCG; // 0x6cc
	protected FlightData PIOEKHNAKBI; // 0x6d0
	protected PlayerAudioComponent CAIANDEEDFA; // 0x6d4
	protected PreviewTeamFlightView DFPCKGNAKFE; // 0x6d8
	protected GameObject MIGFGFBEIAI; // 0x6dc
	protected Flight IBHNPLCMKMJ; // 0x6e0
	protected GameObject OGHCAIDNDIC; // 0x6e4
	protected Parachute MMCDCKLFJMC; // 0x6e8
	private UInt32 KNDABGAGCJB; // 0x6ec
	private UInt32 BCBFPFMNBPF; // 0x6f0
	private UInt32 FJIPAEPAMPM; // 0x6f4
	protected GameObject KIKLGCHBKNF; // 0x6f8
	protected GameObject LHEABNEBLKJ; // 0x6fc
	protected GameObject OOCMAEECDLO; // 0x700
	protected ResourceID GJEKBKPPINL; // 0x704
	protected UInt32 LINMFLMMGON; // 0x708
	protected GameObject AJOCBJKJFBG; // 0x70c
	protected ResourceID MACPCCEFEAC; // 0x710
	protected UInt32 CGPDDFHDLLH; // 0x714
	protected GameObject JCBDAMEOFJD; // 0x718
	protected GameObject PGLNGCLGFFM; // 0x71c
	protected UInt32 EMALIJFFKJM; // 0x720
	protected StropRing KBPIGIGLOEI; // 0x724
	protected UInt32 IAJPGNJBAIB; // 0x728
	protected UInt32 HNNOKKLKKME; // 0x72c
	protected UInt32 OAEOJGIBHJF; // 0x730
	protected UInt32 GBMOKPDDIJA; // 0x734
	public GameObject m_CamouflageUniformGO; // 0x738
	protected GameObject MBOGLBPFBMO; // 0x73c
	protected GameObject HPFEBMEAFLH; // 0x740
	protected GameObject EPECOOLMCCE; // 0x744
	protected LevelHayrickOrigin PEHLMCLMJNB; // 0x748
	protected LevelHayrickEnd LJMCJBLMBNI; // 0x74c
	private GameObject FBPEKCNNNBH; // 0x750
	protected GameObject GECMAEDCDNF; // 0x754
	protected ResourceID AAMHKAKPBDG; // 0x758
	protected GameObject LGOMNIOFGNN; // 0x75c
	protected ResourceID IPGGFDIKDPD; // 0x760
	protected ResourceID BNMNECHHHEB; // 0x764
	private Dictionary`2 HBKNPLBMPOP; // 0x768
	private GameObject NCCOBMFEMHN; // 0x76c
	private Boolean FBEHNEEFMPO; // 0x770
	private Boolean IHGCGIEGBBE; // 0x771
	private ResourceID BFGHDMECCKF; // 0x774
	private UInt32 NHEGOGIPCIG; // 0x778
	private Single BPNGKBJNPBM; // 0x77c
	public Boolean isInTrainingShootAreaTrigger; // 0x780
	private JNGKMJDINHC MCBOALKDHLJ; // 0x784
	private MALGAHKKNNN HFKCFHINHNF; // 0x788
	private EntityInfo JNDGKAICLGP; // 0x78c
	private Boolean JGFACILIHLJ; // 0x7a0
	private UInt32 KNHIDBIJFAF; // 0x7a4
	private Boolean JHOEDAABEKH; // 0x7a8
	private Quaternion NGDLLEBMAAJ; // 0x7ac
	private Single PFNIFBENNDM; // 0x7bc
	private const Single OOLEHDECAKK; // 0x0
	private const Single HLGMDFABCAJ; // 0x0
	private Single KJOFGFIOJAC; // 0x7c0
	public Single m_ControlDirectionResetTime; // 0x7c4
	public Single m_AuxAimResetTime; // 0x7c8
	public Single m_MinAngleX; // 0x7cc
	public Single m_MaxAngleX; // 0x7d0
	private Single CDIHKEBMCCE; // 0x7d4
	private Single BNIBBPOJLHE; // 0x7d8
	private MADMMIICBNN GEGFCFDGGGP; // 0x7dc
	private MADMMIICBNN IHGEFBPODCC; // 0x7e0
	public Boolean LastAimingInfoFromWeaponAdjusted; // 0x7e4
	private Boolean CCAIBFNCKCG; // 0x7e5
	private Boolean FGFMOPILOIM; // 0x7e6
	private OPILIBBOEAC <IMIKNCAFOCH>k__BackingField; // 0x7e8
	private GNBLNCJCKIN EMPLGOPMOKA; // 0x7ec
	private Func`2 KKGELKJDAAH; // 0x7f0
	private UInt32 HMNPPKCOJJB; // 0x7f4
	public Single LastPlayBulletTrackEffectTime; // 0x7f8
	private ResourceID GLJPHGNPLPG; // 0x7fc
	private UInt32 PDLCNAMKEHO; // 0x800
	private GameObject OKIGDDNAKLO; // 0x804
	private UInt32 GMBJMMEHNOK; // 0x808
	private GameObject ENIEJNDCAGN; // 0x80c
	private GameObject CGDGELBHIGL; // 0x810
	private GameObject AGDKBLNIILL; // 0x814
	private GameObject PCAOEKALLDM; // 0x818
	private GameObject JDHIDBEKPFN; // 0x81c
	private GameObject LIBHOJCBFJH; // 0x820
	private GameObject BPJPIEFPMDE; // 0x824
	private Boolean BDOLEIDDIDI; // 0x828
	private ResourceID GAABJILEOLP; // 0x82c
	private UInt32 BIDJMFDOKAE; // 0x830
	private ResourceID KJHHECHKBJB; // 0x834
	private UInt32 NALIOLHHLJE; // 0x838
	private UInt32 NCKABPEJDAP; // 0x83c
	private Boolean DPCEOPBAPMB; // 0x840
	private const Single FKBCKHGJJHF; // 0x0
	private UInt32 IKDCPJCBPLG; // 0x844
	private Int32 NOOBOEKMNGI; // 0x848
	private ResourceID NHDACCFLNFA; // 0x84c
	private UInt32 BDFJEILALAG; // 0x850
	private UInt32 HCDJGKMLDIF; // 0x854
	public Boolean Is3PStopFire_WaitingChangeClipAnim; // 0x858
	private List`1 KJNMPDNJCOB; // 0x85c
	protected AudioResource IHDNEGGNKPP; // 0x860
	protected AudioResource KHFEIEDHFLM; // 0x864
	private RuntimeAnimatorController DLHPJNALDBE; // 0x868
	private Single BAFFFHFPNOC; // 0x86c
	private Boolean CKCMCCFJHJL; // 0x870
	private UInt32 CLDCOKNKFPO; // 0x874
	private Single NNMHGOKCNJD; // 0x878
	private Single HCLPKLFPMPP; // 0x87c
	private Single PDBGMCCBINL; // 0x880
	private Int32 OONNCMGHNNF; // 0x884
	private Single GHJIFCGFKIK; // 0x888
	private Single AAJPJLFGBGG; // 0x88c
	private Single AAKJAGGDPCK; // 0x890
	private Single EIOCLNPDFJH; // 0x894
	private Single FDPNGICACDF; // 0x898
	private Boolean NFLALJEGNNK; // 0x89c
	private Boolean NGGCPHGJBLD; // 0x89d
	private Boolean GNMHFAFOLAI; // 0x89e
	private Boolean AHOFPEOFELN; // 0x89f
	private Single LADNPEHHKEB; // 0x8a0
	private Single OOLIBAOKGFF; // 0x8a4
	private Boolean CNHJMPJNGKE; // 0x8a8
	public const Single IPHONE_DPI; // 0x0
	public const Single MAX_ROTATION_DELTA; // 0x0
	public const Single ROTATION_EXPONENT; // 0x0
	public Boolean EnableUserControl; // 0x8a9
	public Single m_LastPlayFallingLandTime; // 0x8ac
	private Single EMCLDFFMEEL; // 0x8b0
	protected LevelItemPlant GLMFPMNIFCN; // 0x8b4
	public Single NBEatNoodleStartTime; // 0x8b8
	private LinkedList`1 FMPPBIOCMEL; // 0x8bc
	private Boolean <EJBPAOEEGJB>k__BackingField; // 0x8c0
	private Quaternion GAFKFFOIEEA; // 0x8c4
	private Boolean HMFIOAAJICH; // 0x8d4
	protected GameObject LLIKLJNGCDD; // 0x8d8
	protected ResourceID BDHGEBNCOHG; // 0x8dc
	private List`1 KMPFOMBMCKD; // 0x8e0
	private Boolean <ADBBBGFEGIA>k__BackingField; // 0x8e4
	private Boolean <MPDKGKPBCFI>k__BackingField; // 0x8e5
	private UInt32 CCOGPHMOCCJ; // 0x8e8
	private Dictionary`2 OOKHKKMMGCO; // 0x8ec
	private Boolean NMGMDCEDNBB; // 0x8f0
	private Single LDHKJJAENEN; // 0x8f4
	private Boolean HJCOEOCAJGP; // 0x8f8
	private ResourceID DPGJOJGKNCB; // 0x8fc
	private UInt32 LDKJOMHGKKD; // 0x900
	private UInt32 FDCJPFGPEMD; // 0x904
	private ResourceID JHFAJJALKEI; // 0x908
	private UInt32 GGGDMAOCHIL; // 0x90c
	private Boolean AMHMPIHPJMJ; // 0x910
	private Boolean EIMKLIKDICP; // 0x911
	private GameObject HALJPCILNOA; // 0x914
	private UInt32 HPBAPHIEODG; // 0x918
	private ResourceID LCGMGMAFIGI; // 0x91c
	private CheckBoxCrossHairTrigger ECCFHNCAMAB; // 0x920
	protected List`1 GBDKCGEPGKD; // 0x924
	private Int32 BCHLPJMEMAN; // 0x928
	private Boolean <MLGOJIOINIM>k__BackingField; // 0x92c
	private Int32 CJJGBBBJMJA; // 0x930
	protected Boolean KNIAPOABMOP; // 0x934
	private ResourceID NABLMGKLAEB; // 0x938
	private Boolean PDDLACPFBGP; // 0x93c
	private Single CGGDNMFAOMB; // 0x940
	private UInt32 KLGLCBBOJPK; // 0x944
	private UInt32 OPAJLIABGEL; // 0x948
	private UInt32 GNCDLANIDOH; // 0x94c
	private Quaternion IMFIKFHEMOJ; // 0x950
	protected GPGBALKIDJK HJEPPEFPGIB; // 0x960
	private Boolean CAMHBNPLLKL; // 0x964
	private Single DAHOOELNILG; // 0x968
	private Vector2 LILENNDENJG; // 0x96c
	private Boolean PBKIEIPDKIJ; // 0x974
	private Single ILLKHKFHDMI; // 0x978
	private Vector2 KFDHBDHNIPD; // 0x97c
	private AudioResource FCDMMFCJCIF; // 0x984
	private Boolean IPALGNHIGGP; // 0x988
	private ResourceID LIJKENDLCLF; // 0x98c
	private Boolean NIOKPGHHFLE; // 0x990
	private PCAirTrailView CCGGMOEJAMH; // 0x994
	private LevelEmote NAJACJCDPPH; // 0x998
	private ResourceID IKKMCEGOFHN; // 0x99c
	private GameObject JHHABGNEDGC; // 0x9a0
	private Vector3 FFCCEMBLAGK; // 0x9a4
	private Dictionary`2 GFIMHENBJHJ; // 0x9b0
	private const UInt32 GEGPKGONNFK; // 0x0
	private UInt32 PAPKNNEGHMD; // 0x9b4
	protected BitArrayBoolean ABMHBLGAHGF; // 0x9b8
	protected AvatarTrace LIEOMBNJELG; // 0x9bc
	private Boolean <CGBEONIENCF>k__BackingField; // 0x9c0
	public const UInt32 ISOUTLINEVISIBLE_LOCALPLAYER_ALIVE; // 0x0
	public const UInt32 ISOUTLINEVISIBLE_SKILL_TRANSFORM; // 0x0
	public const UInt32 ISOUTLINEVISIBLE_SKILL_AuroraBoy3P; // 0x0
	public const UInt32 ISOUTLINEVISIBLE_3P_ALIVE; // 0x0
	private String FPEFFHNNOPL; // 0x9c4
	private IPJMHLGGAIK LJNBECJBGCC; // 0x9c8
	private Nullable`1 IIHCCOJCKED; // 0x9cc
	private Single OFBPIDMAGJF; // 0x9d4
	private Single DCBOLAEAPCP; // 0x9d8
	private Boolean ANKOBFEMGCG; // 0x9dc
	private List`1 MKDBJOJNPFN; // 0x9e0
	private GameObject MNIIFADNNEI; // 0x9e4
	private GameObject IGEHMJFLFLK; // 0x9e8
	public Single LastRunSpeedUpOverTime; // 0x9ec
	public const Single RunSpeedUpContinueShootInterval; // 0x0
	public Single LastInvincibleOverTime; // 0x9f0
	private Single BELBBPLMOLM; // 0x9f4
	private Single NHDKAFCHKPN; // 0x9f8
	private Single HOGELEIOFBN; // 0x9fc
	private Single JKGANBCKJJF; // 0xa00
	private Single EIDHPEPGOFJ; // 0xa04
	private Boolean AHCHKHNPNPN; // 0xa08
	private List`1 OHFDNGOPJNM; // 0xa0c
	private UInt32 KJNHPFHDNKI; // 0xa10
	private UInt32 MAKHOIJINKC; // 0xa14
	public Boolean IsAtPartyGameSoloDanceBattleField; // 0xa18
	public Boolean IsPartyGameSoloDancePreparing; // 0xa19
	public Boolean IsPartyGameSoloDanceBattling; // 0xa1a
	public const Int32 UGCAnimationClipType_Fist; // 0x0
	public const Int32 UGCAnimationClipType_Pistol; // 0x0
	public const Int32 UGCAnimationClipType_Gun; // 0x0
	private Dictionary`2 ABPOFEBPOJA; // 0xa1c
	private Dictionary`2 MHOBOEIOJOO; // 0xa20
	private Dictionary`2 OHOLLMKPLDP; // 0xa24
	private Int32 EKJBJIKKMMO; // 0xa28
	private Dictionary`2 BEPCCIMEKLN; // 0xa2c
	public static Dictionary`2 FallingActionCollectionType2Suffix; // 0x88
	private GameObject BBCNMGKEMIP; // 0xa30
	private ResourceID OCFEGGIJDBN; // 0xa34
	private AudioResource CAAMEEJKNDF; // 0xa38
	private Int32 PNFIANAMDGF; // 0xa3c
	private Int32 FKFJPIHAOAB; // 0xa40
	private Dictionary`2 OMMIPFDHOHG; // 0xa44
	private EntityVisualEffectManager GHJGPAKJLNA; // 0xa48
	public VisualEffectLoadMethod m_LoadMode; // 0xa4c
	private String PBMMAPNNHFL; // 0xa50
	private String IPJOCPKJGAA; // 0xa54
	protected UGCPlayerRepItem FILPJPDELCM; // 0xa58
	protected UGCPlayerBehaviorRepItem OKANHEKMDDC; // 0xa5c
	protected UGCEntityRepItem CPOGLBOCEJO; // 0xa60
	protected MGJLFMAMIHJ CNOIHBPEGMK; // 0xa64
	protected UInt32 AMMMGMOLOPD; // 0xa68
	public HNJPDMBFFJH ActSkillUpdateKinmaticsCall; // 0xa6c
	protected FDMPBIEMHAF NCLJLFMCMCO; // 0xa70
	private Boolean <BPCEGCDMFMM>k__BackingField; // 0xa74
	private Boolean <NCOILFBAHHH>k__BackingField; // 0xa75
	private Boolean <MFEHPDLGNAL>k__BackingField; // 0xa76
	private Boolean <PHFKOPMMCAE>k__BackingField; // 0xa77
	private Boolean <OMDHJPALMCN>k__BackingField; // 0xa78
	private VisualInstanceHolder KLAFIJKABDC; // 0xa7c
	public Boolean IsKnockedDownBleed; // 0xa80
	private UInt32 IIDLPNMBCJK; // 0xa84
	private GameObject INHEGLODFKB; // 0xa88
	private ResourceID GPOJEGOOLMF; // 0xa8c
	private GameObject GGKPCEKJPKH; // 0xa90
	private ResourceID NOMPKHMJFDN; // 0xa94
	private EPDJJKGINPC EFCMKJAKCLM; // 0xa98
	private Boolean DKKNPEPNOEH; // 0xa9c
	public GameObject m_TransformObject; // 0xaa0
	private MeshRenderer[] LAIINONMDCB; // 0xaa4
	private String NHMLCJFBCKP; // 0xaa8
	private Dictionary`2 KJFMDAGLHGG; // 0xaac
	private Nullable`1 NNFDOKFHEPA; // 0xab0
	private Dictionary`2 OHDIIBBJLDO; // 0xab8
	public NBSkillTransformAnimCtrl m_NBTransformAnimator; // 0xabc
	protected List`1 PFMCMLCMHGF; // 0xac0
	protected Boolean ODMOIMMJICK; // 0xac4
	protected GameObject NPHCEHACHBC; // 0xac8
	private Boolean HHKNFBFMMKF; // 0xacc
	private ResourceID BOPKDMFAHLJ; // 0xad0
	private UInt32 GLKACJCIJBK; // 0xad4
	public ResourceID PlayerSkillBlowUpIceWallExplorEffect; // 0xad8
	private Dictionary`2 HMIHJJEGKMJ; // 0xadc
	private Int32 GMLBEMAEMMN; // 0xae0
	private Boolean LPGAELOHOOD; // 0xae4
	private Boolean GFNBDIAGPMF; // 0xae5
	private Boolean DBAKJCJCBKD; // 0xae6
	private Boolean MPPFBGJNLKI; // 0xae7
	private Boolean DDFGKFOLOEP; // 0xae8
	private Boolean EGOKFNJKBKF; // 0xae9
	private Boolean KOKCOJMOPEO; // 0xaea
	private Int32 LNNGGJFHMJM; // 0xaec
	private SkinnedMeshRenderer[] GMFKCDEHJBG; // 0xaf0
	private Boolean <LEHMADBPEBD>k__BackingField; // 0xaf4
	private GFPFNMDNEFJ CDCMONCOEDK; // 0xaf8
	private MEALBEDNBED CHBGIAEPJIH; // 0xafc
	public static Single SkateBoardHalfLen; // 0x8c
	private HashSet`1 FLBLFABBFBP; // 0xb00
	private Dictionary`2 GFBOGEMKKDM; // 0xb04
	private ArcGenerator NAMMNPNKKNL; // 0xb08
	private BezierSlide DGCMOJKBNCB; // 0xb0c
	private Single KMLEJGAFIDF; // 0xb10
	private ArcGenerator OAGABJEKJGA; // 0xb14
	private BezierSlide JLEAPFIBGMA; // 0xb18
	private Single EGIIHAJKACC; // 0xb1c
	private KCMGGEJLNNO GIIGPFDMOFB; // 0xb20
	private Vector3 AIELBIBJDCI; // 0xb24
	private Vector3 <PLECABLAKNH>k__BackingField; // 0xb30
	private Vector3 <GBFODHHNJOM>k__BackingField; // 0xb3c
	private Vector3 APMHJLDPFHG; // 0xb48
	private Boolean <IKOGNIJJIHK>k__BackingField; // 0xb54
	private Vector3 AMALNNJKNDN; // 0xb58
	private Single DHMBOOJFJMI; // 0xb64
	private Single BJHOLAFGGBM; // 0xb68
	private Single BGMHBFFNJFM; // 0xb6c
	private Vector3 HCNHIHKPOIG; // 0xb70
	private Single OJKNAPGEKKC; // 0xb7c
	private UInt32 PNJHPMHDEAN; // 0xb80
	private FAINJNFLPEE LOPCJPEIIFA; // 0xb84
	private Dictionary`2 BGCIGCPAHHO; // 0xb88
	private UInt32 PPIHFJFLHJM; // 0xb8c
	private GameObject BNILKBFOFKE; // 0xb90
	protected CIIDIPDOOLC LKBDNHEBLML; // 0xb94
	private UInt32 HEMBGDIIKBA; // 0xb98
	private UInt32 PIHKNDHJFBA; // 0xb9c
	private UInt32 GEHGHGDELBN; // 0xba0
	private BDJFKJJNNFC BCDDNPLPFCP; // 0xba4
	private Vector3 JGDEMICGAIB; // 0xba8
	private List`1 EDBKHEJIPDH; // 0xbb4
	private Boolean KMKMGOFBAIA; // 0xbb8
	private AvatarTransformer LGKMIPFPCMM; // 0xbbc
	private Boolean OJHKLPIADDA; // 0xbc0
	private UInt32 DHBBIFDKJNI; // 0xbc4
	private EAvatarModelIngameType ALBDPBBOOFG; // 0xbc8
	protected CKGPOJHAKOI EEGNIJLGCBI; // 0xbcc
	private PVEEnergyBallManager <NNJAOKKKHLJ>k__BackingField; // 0xbd0
	private Dictionary`2 KLBFPHILHJD; // 0xbd4
	private ObjectPool`1 ENHNIMLFPAB; // 0xbd8
	private UInt32 AINBLPAPNGL; // 0xbdc
	private UInt32 POHMJFNEOMH; // 0xbe0
	private Dictionary`2 EEFPGBMCELJ; // 0xbe4
	private Single AILOFDKBIEI; // 0xbe8
	private Single KPKJIPJJOEL; // 0xbec
	private Single GGEPKEONELC; // 0xbf0
	private Single OOAKFNMLCDA; // 0xbf4
	private Quaternion LDFINGBJFFO; // 0xbf8
	private Quaternion FHEBFMCEPKH; // 0xc08
	private Quaternion KBJPPFLOHFG; // 0xc18
	private Quaternion MLAJHCFEKLN; // 0xc28
	private ClimbingTrigger FLJAGFADKJJ; // 0xc38
	private Dictionary`2 MOLOMMJNIKP; // 0xc3c
	private List`1 IMMKFOLLBCJ; // 0xc40
	private static Dictionary`2 GPKPLMFDJLM; // 0x90
	public Single minAngleInCreep; // 0xc44
	public Single maxAngleInCreep; // 0xc48
	private MADMMIICBNN NFAHKACNAPB; // 0xc4c
	private Nullable`1 DADKBHNGOPJ; // 0xc50
	private Single CPBNDNOGCFM; // 0xc54
	private Single PGIFAOABEOM; // 0xc58
	public Boolean IsDoubleJumpTriggered; // 0xc5c
	public Single ResetSecondJumpRushTime; // 0xc60
	protected GameObject KLFBNALOAIC; // 0xc64
	protected GameObject IIGHDHHBBCL; // 0xc68
	protected AMPGCIMNMBI FOEFIDJIHLP; // 0xc6c
	private DuoEmoteInviteCollider GGBOIJMGMPM; // 0xc70
	private EmoteSoundCollider LKAMKFPLGHC; // 0xc74
	public IHAAMHPPLMG DuoPlayerId; // 0xc78
	public Boolean ResetCabinWaitingFlagForPlayDuoEmote; // 0xc90
	protected UInt32 IKCHNIDCIPM; // 0xc94
	protected UInt32 GNKPCLMIJBA; // 0xc98
	protected AAKFAPMGNEJ HCKIBKEBJAC; // 0xc9c
	protected HBKDJCNCLCE EIMCGINDBPD; // 0xca0
	protected Boolean JIFCJHBEPAK; // 0xca4
	protected GPBDEDFKJNA ABFHKKMBEAA; // 0xca8
	protected ResourceID OMIENAIEBND; // 0xcac
	protected UInt32 AKAOEBMCGIJ; // 0xcb0
	protected ResourceID DAHNHALPADD; // 0xcb4
	protected Boolean HJMHBKOHFDI; // 0xcb8
	protected Boolean HEPMPNLNOBO; // 0xcb9
	protected GameObject PDHFDMAJKFB; // 0xcbc
	protected GameObject JFMBAHFBFIH; // 0xcc0
	protected HBKDJCNCLCE MNGCIHBDDNJ; // 0xcc4
	protected Boolean BDEKNOCBHHP; // 0xcc8
	private UInt32 LGFKMOGEGMN; // 0xccc
	private Single KOHMJMMJJED; // 0xcd0
	public Boolean IsPlayExecutorCamera; // 0xcd4
	public const UInt32 FISTWEAPONID; // 0x0
	private MADMMIICBNN CFHENECECNB; // 0xcd8
	protected Player OBEMHFDFCBB; // 0xcdc
	private Transform PFGPODLGGDA; // 0xce0
	private CameraAnimationManager GGEILMMGCGP; // 0xce4
	private Boolean <DILHLGFALGA>k__BackingField; // 0xce8
	private Boolean <IFAPMMCMAGF>k__BackingField; // 0xce9
	private Single NPELJHNMCLM; // 0xcec
	protected Vector3 AGLPCFJDOEK; // 0xcf0
	protected MILCMIMPDMG ODGHKHFAPON; // 0xcfc
	private Boolean NBALNFIPBGC; // 0xd24
	private GameObject PJLGGOCFHMG; // 0xd28
	private Boolean CNCAHHEBKOA; // 0xd2c
	private Byte LGJKNEPDIHH; // 0xd2d
	private Boolean IMNOADNIKHH; // 0xd2e
	private Int32 DDEMPHJBBIC; // 0xd30
	private ResourceID NPGBCPDJMHN; // 0xd34
	protected CCGBDNBALMI JNBLBAACNIF; // 0xd38
	public Single StartGlideTime; // 0xd3c
	private FoldWingConfigData COMEEIBGFFH; // 0xd40
	public GameObject m_FoldWingIAmIn; // 0xd44
	private Boolean PBPODOFEMGA; // 0xd48
	protected Single ONKBEPDPMIN; // 0xd4c
	protected GameObject IMGBBFACIBP; // 0xd50
	protected SphereCollider IMJJHDCEAPK; // 0xd54
	protected Football DIMIKOEBCAM; // 0xd58
	protected FootballHitTrigger JBHIAACEOOO; // 0xd5c
	public Vector3 m_FootballHitVelocity; // 0xd60
	protected Single DKECBLGHKPH; // 0xd6c
	protected Boolean FABPGCNFANC; // 0xd70
	public static readonly Single FOOTBALL_MOVE_EPSILON; // 0x94
	protected Vector3 PJDLFBIJJCJ; // 0xd74
	protected GameObject NCJOKPHEEGM; // 0xd80
	protected AudioSource CGOLMJKNPLI; // 0xd84
	private UIHudChatBoxController PKCBBDANHOE; // 0xd88
	private GameObject LIBIGJDMHLD; // 0xd8c
	private GameObject EPKFIBGDMKJ; // 0xd90
	private VisualInstanceHolder OCPBIKBFPGC; // 0xd94
	private VisualInstanceHolder MDGLBFCGBFL; // 0xd98
	public static readonly Dictionary`2 TagToBeneathFeet; // 0x98
	protected List`1 PJJGMNDOHOJ; // 0xd9c
	public static ResourceID[] FPP_Male_Low_HP_Sound_Array; // 0x9c
	public static ResourceID[] FPP_Female_Low_HP_Sound_Array; // 0xa0
	public static ResourceID[] FPP_Male_Recover_Hp_Sound_Array; // 0xa4
	public static ResourceID[] FPP_Female_Recover_Hp_Sound_Array; // 0xa8
	public Single m_FPPLastPlayRecoverSoundTime; // 0xda0
	public Single m_FPPLastPlayLowHpSoundTime; // 0xda4
	public GameObject m_FPPLastRecoverSound; // 0xda8
	public GameObject m_FPPLastLowHpSound; // 0xdac
	private TransformNode ODNPGIBCPPK; // 0xdb0
	private Single EFAFMFJKKJJ; // 0xdb4
	private Single JGCDBNLCJHG; // 0xdb8
	private Player_FPPModel GFDCBAMOJPP; // 0xdbc
	private GameObject ELHOAGFGFGK; // 0xdc0
	private Boolean HLFNNGPNCIE; // 0xdc4
	private TransformNode JDHOJPCOCOM; // 0xdc8
	private Vector3 GANKEMDEJPI; // 0xdcc
	private Vector3 MAEJOCKEHMJ; // 0xdd8
	private Vector3 GOJJAMLIFOD; // 0xde4
	private ResourceID OIIMCNGMJDO; // 0xdf0
	private UInt32 DJOMJHMNHCK; // 0xdf4
	private UInt32 FELOCMIPJMC; // 0xdf8
	private Vector3 DMBCBBJGJHA; // 0xdfc
	private UInt32 HJGICDJEBJF; // 0xe08
	private UInt32 MCIBLPDLFLC; // 0xe0c
	private Single OEOCKOBIINA; // 0xe10
	private Int32 PJEIIEHLDEH; // 0xe14
	private Single PPODDABLHMD; // 0xe18
	private Boolean CHLBMPMNCDF; // 0xe1c
	private UInt32 OEBDCCLCFDE; // 0xe20
	private UInt32 FIMLBIKBJOL; // 0xe24
	private UInt32 OHJJOPDBMCL; // 0xe28
	private Single GLMNNKHIFPF; // 0xe2c
	private Int32 GMAEBFLLEMF; // 0xe30
	private Int32 NLJGPCCIDPL; // 0xe34
	private UInt32 NIIEONHEOFG; // 0xe38
	private Single ODANJKLLOHB; // 0xe3c
	private Single LFNHKGOLDKA; // 0xe40
	protected Vector3 ECPJLGNDCEH; // 0xe44
	private ResourceID AHLFDJKCMKL; // 0xe50
	protected CKMBFCELDAO NPMKIFFMMHH; // 0xe54
	protected GameObject JKKJGLIGPON; // 0xe58
	private MADMMIICBNN OCPLOAGPGNK; // 0xe5c
	private Player GBBOIAIGLHK; // 0xe60
	private Single FHCNIJEPPFA; // 0xe64
	private Single KNCMHFAKHNF; // 0xe68
	private Single NHHIKOKGAPC; // 0xe6c
	private Single LKFCGAFJKAK; // 0xe70
	private Boolean PBNFIIMHGJL; // 0xe74
	private Boolean DDKKHJGKMDG; // 0xe75
	private HOHOHJMCDGA CFBKACJOJNA; // 0xe78
	private GameObject KIJEBCMPPEC; // 0xe7c
	private GameObject MKEBJHELBPM; // 0xe80
	protected LevelMovePlatform MLKBNNJMCAF; // 0xe84
	protected Vector3 PPIGOHLCMKI; // 0xe88
	protected Vector3 PLMCBCCFAHL; // 0xe94
	private IBCLOJLONNM PJMOFHMHDEG; // 0xea0
	private UInt32 FJBLPEPKPNK; // 0xea4
	protected KHDMPGBLNCM IBHJOIGFAEH; // 0xea8
	private UInt32 JNCKPLHIMAM; // 0xeac
	private Single FAEBGIMCJAI; // 0xeb0
	private Single CJPAJHCILKJ; // 0xeb4
	private ControllerColliderHit EHGBEFPMPDB; // 0xeb8
	private RaycastHit[] OLOKPCCEHEO; // 0xebc
	public const Single GroundDetectionBackDistance; // 0x0
	public Single MinGroundDetectionDistance; // 0xec0
	public Vector3 m_GroundHitNormal; // 0xec4
	public Vector3 m_GroundHitPos; // 0xed0
	public Boolean m_GroundHitResult; // 0xedc
	private Boolean <MFEFNPCBNJI>k__BackingField; // 0xedd
	private Boolean <PEBDHJOGKAO>k__BackingField; // 0xede
	private Boolean OHLEEFLGMDK; // 0xedf
	private Single OIEABJBKFNH; // 0xee0
	private const Int32 IBNIIGAHDGD; // 0x0
	private const Int32 FCONPGDHNCC; // 0x0
	private IEnumerator GLFAIOCPHMD; // 0xee4
	private Byte JCJJHPLJIBA; // 0xee8
	protected ALAHNGGPDIE FNAFKJFAEPA; // 0xeec
	private Boolean HCLEADIJLEH; // 0xef0
	private Boolean IFEJGHFEEPL; // 0xef1
	private Boolean <BGEPKHIKMKN>k__BackingField; // 0xef2
	private UInt32 CFOANMPFNPP; // 0xef4
	private UInt32 LLCCILPBIPK; // 0xef8
	private UInt32 CHODADBHCMB; // 0xefc
	public Single LastHitEffectTime; // 0xf00
	public Single LastHealHitEffectTiem; // 0xf04
	protected Int32 OHCDDMOIBDH; // 0xf08
	private Boolean AHLDOCCIMLB; // 0xf0c
	private List`1 FEEMLCHLFJO; // 0xf10
	private ResourceID PIPGKFPFPHK; // 0xf14
	private UInt32 EKNJEBBMJLD; // 0xf18
	private Byte <HCFMGMCOAMD>k__BackingField; // 0xf1c
	private Boolean <OOIGBDIGADD>k__BackingField; // 0xf1d
	public Single FlyUPDistance; // 0xf20
	public const FBCAHNCLMDC SkateboardJumpPose; // 0x0
	public const FBCAHNCLMDC SkateboardSecondJumpPose; // 0x0
	private GPGBALKIDJK JOKBBDGDCGH; // 0xf24
	private GPGBALKIDJK MDCCIFENIFF; // 0xf28
	private GPGBALKIDJK FGMECLFDOMN; // 0xf2c
	private GPGBALKIDJK LOPINBEJDJI; // 0xf30
	private ResourceID FAFEJKKGLPF; // 0xf34
	private ResourceID KKLENDNJFKA; // 0xf38
	private GameObject CIAELMOEDKJ; // 0xf3c
	private GameObject BFNJEMODDMA; // 0xf40
	private GameObject JELEGBPLPHH; // 0xf44
	private VisualInstanceHolder PDLCPAIPBOA; // 0xf48
	private Boolean JFKFKBEHACK; // 0xf4c
	private Int32 MPNMENPICOK; // 0xf50
	protected Single HEDHLKDDOAH; // 0xf54
	protected Single IMNLLKCFMOE; // 0xf58
	protected UInt16 POJFCEJPHIE; // 0xf5c
	private Single CJAEOJIGMJL; // 0xf60
	protected Single NKJFJMGKCPJ; // 0xf64
	protected GameObject LGDNHNHCLMI; // 0xf68
	protected LNPFNEMBDOB BPPLGKHPHAP; // 0xf6c
	private Single EEECGDMIEHM; // 0xf70
	private VehicleDriverCameraTarget FGDPLLHHIGH; // 0xf74
	private BCIGOPJHDPB <HECLGLBAEGC>k__BackingField; // 0xf78
	private static readonly Single LOPANOEFNIH; // 0xac
	private static readonly Single HEMFKLCOBPC; // 0xb0
	public Single SkySurfingTotalDurationForLog; // 0xf7c
	public Single SkyDivingTotalDurationForLog; // 0xf80
	public UInt32 SkySlidingPressBtnCountForLog; // 0xf84
	public Int32 SkyDivingSwitchPosTimes; // 0xf88
	public FBCAHNCLMDC FlightMonoPose; // 0xf8c
	private Single OHBFIAAOMJM; // 0xf90
	private Single GBAFAOKFEBO; // 0xf94
	protected GNOEFCLIGBL NPGMDECEADM; // 0xf98
	public Boolean IsDieingOnParachute; // 0xf9c
	private AEMINKPBIIJ GKMOEIDAONO; // 0xfa0
	protected ArrayMap`1 HDOADBCLAKH; // 0xfa4
	private Boolean MLPIFDOGEFA; // 0xfa8
	private Single APIPJEMABHG; // 0xfac
	private SuperEmoteCameraAnimationManager NKDIIODPFFA; // 0xfb0
	private GameObject MOLIJOGOFJC; // 0xfb4
	private SuperEmoteCollider CPKICHHHNJF; // 0xfb8
	private UInt32 MCILBFGLPCL; // 0xfbc
	private UInt32 NNOHMHJNNFM; // 0xfc0
	private UInt32 DHKCPOJGKBH; // 0xfc4
	private EHEGBOKBKJG EAOLAOCAPDN; // 0xfc8
	private GameObject PIGJPNIHBII; // 0xfcc
	private ResourceID CFOMCFLGDDA; // 0xfd0
	private GameObject KEAAHBKPHBJ; // 0xfd4
	private UInt32 DBDKAJHPEGC; // 0xfd8
	private const Single NIBNJEFIAFA; // 0x0
	private ResourceID JAINBAFJNDM; // 0xfdc
	public Boolean ResetCabinWaitingFlagForPlaySuperEmote; // 0xfe0
	public Boolean LocalPlayerWaitingAsyncSuperEmote; // 0xfe1
	private Int32 JFBJHDLGLIH; // 0xfe4
	private UInt32 <MMLPOOBKGOK>k__BackingField; // 0xfe8
	private IHAAMHPPLMG HCOFNOCGHCH; // 0xff0
	protected UInt32 DBMOAHNFFKO; // 0x1008
	protected UInt32 HPPFBNDMDCL; // 0x100c
	protected Int32 GELFKFFGMDD; // 0x1010
	protected Byte FBCOPLIHFEL; // 0x1014
	private Byte LIMGFHMEGLD; // 0x1015
	private IKBGGPAEFDO BMMIMFAGFFG; // 0x1018
	private Vector3 NCJJNJINDEG; // 0x101c
	private Boolean NDODIPNEHOI; // 0x1028
	public Boolean IsResetTeamFlightAnim; // 0x1029
	public GGHHAHINCOB m_TeamParachuteCallBack; // 0x102c
	public MHBKOOONOGC m_OnPlayerPhysxStateSwtich; // 0x1030
	public AFICEILBKKH m_OnLeaderWantChangeTransfom; // 0x1034
	private Single MNJCKIGFANJ; // 0x1038
	private Boolean MCCBJIPJBCJ; // 0x103c
	private Boolean OBFOMJPJMFD; // 0x103d
	private Boolean HOLEEOILHJD; // 0x103e
	private ResourceID IFALCKJJBAO; // 0x1040
	protected JAEAODJEENM JGIOLIADMMM; // 0x1044
	protected Collider OJGBKKCKKHC; // 0x1048
	private Single EECCGJAJJFN; // 0x104c
	private Single LDGIAGGPCHE; // 0x1050
	private Int32 GGGFPPEFLJK; // 0x1054
	private MADMMIICBNN OAJEDLLNHBP; // 0x1058
	private HCKOJDGLJCI AGAIPPNCMDE; // 0x105c
	private GameObject EOAPFCPNAOG; // 0x1060
	private Boolean GBHGDOIHFCK; // 0x1064
	protected Boolean CCFIDBDDDIM; // 0x1065
	private Boolean <OONCPPKEEJI>k__BackingField; // 0x1066
	private Boolean <OFFCPMBKFCP>k__BackingField; // 0x1067
	private Boolean <DGDEOCAENIE>k__BackingField; // 0x1068
	private Boolean <GDMDDPBAEDM>k__BackingField; // 0x1069
	private Boolean <PPMOGOHHNCI>k__BackingField; // 0x106a
	private Boolean APBLMNIFDNF; // 0x106b
	protected Boolean NALOKAEEKLO; // 0x106c
	private NPPLLOJKPGL CEHEGECLLIE; // 0x1070
	private Dictionary`2 IKHCOAKAPAM; // 0x1074
	private Dictionary`2 PNKFNLLLNHF; // 0x1078
	private Dictionary`2 LOCOMGIOABK; // 0x107c
	private MADMMIICBNN LKDCNBEPEOF; // 0x1080
	private CPOJAJBFBMG GBHPAMEMLLE; // 0x1084
	private Dictionary`2 NHGMEKBFNMK; // 0x1088
	private Dictionary`2 EGFOFAMPAFL; // 0x108c
	private Int32 CPDBDAEIKLA; // 0x1090
	private Dictionary`2 NBDELKFPIFJ; // 0x1094
	private readonly List`1 FNDFPNBJOFL; // 0x1098
	private readonly List`1 OHCCDKMKCDA; // 0x109c
	private readonly Dictionary`2 EGIKHMIAHMN; // 0x10a0
	private Color DDOMLJDNBIG; // 0x10a4
	private readonly String HBHEBBFMNJA; // 0x10b4
	private IPJMHLGGAIK HLNPCBEPEPH; // 0x10b8
	private readonly String AFPHAEEOPND; // 0x10bc
	private IPJMHLGGAIK NDAPGFHJMEL; // 0x10c0
	public readonly Int32 CfgDonotSortCnt; // 0x10c4
	private readonly UInt32 CNCCBOFEGNA; // 0x10c8
	private BitArrayBoolean NBDOKOADBDP; // 0x10cc
	protected Dictionary`2 ILPNHBIIODC; // 0x10d0
	protected List`1 CMAFGEBBBKF; // 0x10d4
	private const Int32 NCABFOIPELJ; // 0x0
	public Boolean IsClientSkillCharging; // 0x10d8
	public Boolean IsChargeSkillDisableJump; // 0x10d9
	public Boolean IsChargeSkillLockInput; // 0x10da
	private Boolean AHPOICNEKLE; // 0x10db
	public Boolean m_IsChargeSkillLockAnim; // 0x10dc
	public Boolean IsChargeSkillForceMove; // 0x10dd
	public Boolean ChargeSkillForceMoveToForward; // 0x10de
	public Boolean IsChargeSkillLockFreeMove; // 0x10df
	private Boolean PNNGDHFGHFK; // 0x10e0
	public Single ChargeSkillLockMoveSpeedDecayPerFrame; // 0x10e4
	private Int32 IKICDDEDCLP; // 0x10e8
	public Single ChargeSkillLockRunSpeed; // 0x10ec
	private static Comparison`1 HMDOHFBHDOB; // 0xb4
	private static Comparison`1 AOCDJNOINOH; // 0xb8
	private static Comparison`1 AAOFHFGKOBN; // 0xbc
	private static Comparison`1 KJNIBJNOINP; // 0xc0

	// Properties
	public Boolean NKLDJINEBHC { get; set; }
	public Comparison`1 PFMNDEKPBBP { get; }
	private List`1 JCLIOJALJPD { get; }
	private List`1 MJBFIAGLBAC { get; }
	private List`1 KEDKNECLANJ { get; }
	public Comparison`1 JOODDOGIBMG { get; }
	private List`1 BGCKDIGBFJB { get; }
	public PhysicalCCT OJMNMPIENAD { get; set; }
	public Boolean DFODGJLJPLM { get; set; }
	public Single MCOHMDCFCOC { get; set; }
	public Boolean GDABKBKEEPK { get; set; }
	public List`1 HJOHLKJCLGB { get; }
	public Boolean AEHHCLKFOIF { get; set; }
	public MJFNDLDGOCL BDHHMKIMFOF { get; }
	public OGLOLLNEBAC DCDJKJGFMND { get; set; }
	public UInt64 MIJOCMKONAD { get; set; }
	public IHAAMHPPLMG IHAAMHPPLMG { get; set; }
	public UInt64 DBBDCBDBDIG { get; set; }
	public UInt64 CDPMKEGBFNC { get; }
	public Int32 CPDNBJNLAIM { get; set; }
	public IHAAMHPPLMG INJHIIEDLOE { get; set; }
	public UInt32 MGFPABPGMCA { get; set; }
	public String MFLBOPEBOKE { get; set; }
	public String AIBGAEMOLAN { get; set; }
	public UInt32 LGFOLJMCMFH { get; set; }
	public UInt32 HACHAICBNDJ { get; set; }
	public Object AKMGPJFCGKD { get; set; }
	public String GCJBNAHBGMD { get; set; }
	public Boolean JHKDNBCFKMN { get; set; }
	public UInt64 PAJPAJAJKAF { get; set; }
	public List`1 IHJCPLDPBPO { get; }
	public Boolean NJOEDDBEOFF { get; set; }
	public EPreparationTimerType BMNGAEDACND { get; set; }
	public Boolean OCLKKGCBCFO { get; }
	public Boolean CGLPGGGGLEE { get; }
	public Boolean LFHHIGKHEBJ { get; }
	public Boolean HBKOOOGIPBC { get; set; }
	public CharacterController IJCLBOKGMCH { get; }
	public Boolean AMHNMEBKJKJ { get; set; }
	public Boolean EFEDDDPHDMG { get; set; }
	public UInt32 AHILKHDAHGK { get; set; }
	public Boolean JHCHNAGGJLO { get; set; }
	public Boolean NBAPKPFJGEF { get; set; }
	public Boolean IJLNDEBJIAP { get; set; }
	public Boolean ECGLMHGGJIA { get; set; }
	public Boolean FLEOHKNBGFK { get; set; }
	public Boolean HAFCKIHMJPA { get; set; }
	public Boolean JABEIFNBKAJ { get; set; }
	public Boolean GHHECPHJALL { get; set; }
	public Boolean HLLNDKGMJGE { get; }
	public Boolean BBOOLBGAJCN { get; }
	public EPlayerLastKillState BHHIJFGOPDO { get; set; }
	public Boolean NLDFHMAACHI { get; set; }
	public Boolean EOLCOFLAEDK { get; set; }
	public UInt32 MDDDNKCOMDF { get; set; }
	public String JDDFBJGDAAG { get; set; }
	public Boolean EBFBALADDBB { get; set; }
	private Queue`1 ILBHDFJFJKK { get; }
	public UInt32 ACAENGGIMAK { get; }
	public UInt32 PAHEGIIKLIH { get; }
	public Boolean CCHKPEGPMND { get; }
	public UInt32 CJCLANDKOJL { get; }
	protected Quaternion PNDINIPFHJL { get; set; }
	protected Quaternion FAJPNPDBODN { get; set; }
	public Boolean JFCNHDKPKLJ { get; set; }
	public Boolean PGMFLGILALM { get; set; }
	public Boolean NKKHPIOIOCP { get; set; }
	public Boolean HFEDEEMNIPJ { get; }
	public HashSet`1 MOMCEJNBBPA { get; }
	public Boolean DGECLMPJMFK { get; }
	public Single JONKEJFFOMF { get; }
	public EAimAssist KINGHFICKOE { get; }
	public Boolean JGJHDKKPNPA { get; }
	public Boolean OKLALGPPNDJ { get; }
	public Boolean AMDICHFGBFK { get; }
	public Boolean FCOMBCAICLO { get; }
	public FollowCamera IJMODEIJCOD { get; }
	public virtual Collider NDIJPOAKKGG { get; }
	public NJKAFIOELHI NJKAFIOELHI { get; }
	public NewPlayerAnimationSystemComponent ILFAKEOIACP { get; }
	public AvatarManager LOHKIAIEKBM { get; }
	public IceWallMakerData KPPEJFMOBOJ { get; }
	public PlayerAttributes KNHAHIOBOGM { get; }
	public Boolean FCDEPAABNFL { get; set; }
	public Boolean IAPCAGNFMPO { get; set; }
	public Transform PHFLOHBNECC { get; }
	public Transform ILGHEFOMOFC { get; }
	public Transform PBHBNMIFEKJ { get; }
	public Transform MHLFJLJMPMF { get; }
	public Transform FJGMHKIGNNH { get; }
	public Transform BPFMFOEBAEM { get; }
	public Transform BOCCFAPCJCI { get; }
	public NavMeshAgent EHLFKJGHJBJ { get; }
	public NetworkPet DHKMHJMDLAA { get; set; }
	public Boolean AIGHBCPEEBH { get; set; }
	public Boolean EBFPHODKLOP { get; set; }
	public Boolean HMFEILDEEPL { get; set; }
	public Boolean GMNLFKLOFCC { get; set; }
	public Boolean IDHBDFGLDEJ { get; set; }
	public UInt32 PDDPBJOMKFJ { get; set; }
	public Single LKGPEGADHNL { get; set; }
	public Vector3 BPCCLCIMGOA { get; set; }
	public virtual Boolean AFDMGPFCBIO { get; }
	public Boolean ALIGKMFIOBB { get; }
	public Boolean LGMPLILDPAJ { get; }
	public Boolean DMABBAJADHK { get; }
	public Boolean AFENBOJOONG { get; set; }
	public LMAFDMFMENA FBPOLCMOIOB { get; }
	public EntityInfo ACNHNCPFCFB { get; }
	public EntityInfo OLBGLPLMEIO { get; }
	public Boolean MDFFLKJAKHP { get; }
	public Boolean OPMGNCPJPFL { get; }
	public Boolean ABCDIOFOCFE { get; }
	public Boolean KILKIKOHANG { get; }
	public Boolean NFOHALLLPIC { get; }
	public Boolean PJKIDKGJGNA { get; }
	public Boolean DHCCDAPIPAO { get; }
	public Boolean LEANLMHPJKC { get; }
	public Boolean FLCGKIKFHNP { get; }
	public Boolean JNFIDMMDFMM { get; }
	public Boolean EJIMJBIBMED { get; }
	public Boolean JOKIHGBEEHI { get; }
	public Boolean JPEIKDHIKIA { get; }
	public Boolean DFCEANPIEIJ { get; }
	public Boolean KDONPBDKKIE { get; }
	public Boolean FOEBFCANIFA { get; }
	public LevelGrapplingHook JFLNOPHEHEF { get; set; }
	public Int32 NBAGGEEODCN { get; set; }
	public Single BLPGHLACJKD { get; set; }
	public Boolean LPGNHAPLGIL { get; set; }
	public LevelSwingSpider ODFEEOOGFEL { get; set; }
	public Boolean EEJHIPELLEE { get; }
	public Boolean LPIJDKICPHJ { get; set; }
	public Boolean IFACMDMJCHG { get; set; }
	public Boolean FECFKLIPDDG { get; set; }
	public Boolean IIJLJAEALEG { get; set; }
	public Boolean KOMALEEFGJG { get; set; }
	public Boolean HFJKBGABJKL { get; set; }
	public Boolean LDJKNCAALJE { get; set; }
	public Boolean KOPGHJJGEID { get; }
	public Boolean NNKENPMDLOL { get; }
	public Boolean CAGDDOFJJFG { get; set; }
	public Boolean IBJHOHCFBNG { get; }
	public Boolean NLFCPFENIHC { get; }
	public Boolean ADFOBAFBAAG { get; set; }
	public Boolean IKIAHICCKKP { get; set; }
	public Boolean CGOOCAELGID { get; set; }
	public Boolean PMGFBCBCOOH { get; set; }
	public LevelChair OEOKKLPIJKE { get; }
	public Int32 BFPJBCPMOBI { get; }
	public Boolean CMHIOJAIEPA { get; }
	public Transform HCJBHFBLHOB { get; }
	public Transform POKAGBKPOKL { get; }
	public Transform IFBEAIFGJBA { get; }
	public Transform OFEFMJNNKCF { get; }
	public Transform JJGNDPJJGCJ { get; }
	public Transform AMPHBHIEIKN { get; }
	public Transform LHAGAILJBPM { get; }
	public Transform PIOBJOPPEPL { get; }
	public Boolean CEBMLIKMBCE { get; }
	public Boolean KGLGDDGKENI { get; }
	public Boolean KMPHLIBPIDL { get; }
	public Boolean JPFPIPLEPNN { get; }
	public Boolean DGGCLEJJFOP { get; }
	public Boolean KPNHKCBLLJI { get; }
	public Boolean OABGNKEHOMI { get; }
	public Boolean GLFLEOOCGBN { get; }
	public Boolean KAMCALBHFBI { get; }
	public Boolean CJGENGNALFO { get; }
	public Boolean EFPKMNJJFHE { get; }
	public Boolean ENFDNEBDGFM { get; }
	public Boolean LEOANJFLKND { get; }
	public Boolean HFMNNKEBNIP { get; }
	public Boolean OAHOIENIABJ { get; }
	public Boolean MKMICDHFEAE { get; set; }
	public Boolean LFJKFLNNNBK { get; }
	public Boolean AJMHFMMNDEP { get; }
	public Boolean HHJABOAFPHM { get; set; }
	public Boolean CENMCEFKFBK { get; }
	public Boolean GDDHBLAGLFG { get; }
	public List`1 MCPGFPHMOGM { get; }
	public Boolean JKHBGMBINHI { get; set; }
	public Boolean OLJFKOBDAMN { get; set; }
	public LevelLockBountyVehicle NNFFGHJIIHN { get; }
	public LevelBountyBox POMBHMIFHMN { get; }
	public LevelWeRunBox PDPNMNLDHAL { get; }
	public LevelTriggerHumanTire PGPNJNNOIDC { get; }
	public PKLAGHHKOPO PKLAGHHKOPO { get; }
	public GBJAEPHNFMD ABCBDLOPKEN { get; set; }
	public UInt32 KFMJKFECHGI { get; set; }
	public Single DELDBLPCJNN { get; set; }
	public Single CDHLJIOPPID { get; set; }
	public Boolean NMJMPJNFGII { get; set; }
	public Boolean INEDAPDNGGE { get; }
	public Boolean JPFMADNPNEB { get; set; }
	public Byte IMEJKAHCAPH { get; set; }
	public MANEMECPKIO LOGFGAGLHAI { set; }
	public ResourceID PBOFPKGJIJA { get; }
	public ResourceID KFPJPLHFLOE { get; }
	public ResourceID ECBHFOMLHIC { get; set; }
	public ResourceID MDLPMNCNFNP { get; set; }
	public SkyboardData PLKBLACHKDO { get; set; }
	public FlightData CKBPNFBNFLO { get; set; }
	public FlightData HBGBEPKBOBM { get; set; }
	public PlayerAudioComponent MEEBGFCOPJO { get; }
	public Parachute COGOGHNCDHE { get; }
	public Flight JEIMEBEHMIH { get; }
	public Dictionary`2 AOAKNDGCJJJ { get; }
	public JNGKMJDINHC IMIAJFDPHIB { get; set; }
	public MALGAHKKNNN OLLCDNPLHBN { get; set; }
	public Boolean JKDKDMPBGCJ { get; set; }
	public MADMMIICBNN GCMAMNFNEBG { get; }
	private MADMMIICBNN CJCNKCALFIK { get; }
	public OPILIBBOEAC AEMHIOJGMBP { get; set; }
	public Vector3 GBHKDOGIBMM { get; }
	public Vector3 GJPONEDMMKP { get; }
	public Boolean PPAOKBGCIEH { get; }
	public BaseLevelObject MCNKFJAECNC { get; }
	public Boolean IPHMKAABNPJ { get; set; }
	public Boolean PCFMFMAMNME { get; set; }
	public Boolean DPDKHDBCBPH { get; set; }
	public Boolean DLIGANJECNO { get; }
	public Boolean PAPMKCKLHBF { get; }
	public Boolean CPLEOLCIFPK { get; }
	public Boolean OKGECDMNNKJ { get; }
	public Boolean EAAGPMFOFHM { get; }
	public Boolean GEKIOMAKPOL { get; }
	public Single LCLDOLFJAKG { get; }
	public Boolean LPLBPCNPAGH { get; set; }
	public Boolean FMDPNPIILAC { get; }
	public CheckBoxCrossHairTrigger HDLADJNFKJN { get; }
	public Boolean LKMJDBHPHLL { get; }
	public Int32 EJBKGJDBCPE { get; }
	public Player LNLKCHLDGPF { get; }
	public Boolean FOJHOMHLPDH { get; set; }
	public Int32 PCIBDOCDMIE { get; }
	public Boolean FJCJOOOHHBE { get; set; }
	public virtual BaseProfileInfo GFNIFLOJIAF { get; }
	private Dictionary`2 PKIICFFCBJE { get; }
	public Boolean NEKBPMGJFIJ { get; set; }
	public Single CFFHMNNJOBK { get; set; }
	public Single HCCFDNJGDLM { get; set; }
	public Boolean AHNHGCFOLIN { get; }
	public Single IGIDMIPOLNE { get; }
	public Single HLKMFCIIBPI { get; }
	public Single CFGLFCCMJKC { get; }
	public override Boolean GEOGJOICHKF { get; }
	public Boolean CMPIOCMJHAP { get; }
	public Boolean AKBGNBLOBMN { get; }
	public override Boolean COBEBJDAGGC { get; }
	public Int32 KGPDNLLBPDL { get; }
	public Boolean HPAPGJKFPFD { get; }
	public UGCPlayerRepItem LMONIKMGINA { get; }
	public Boolean KFFKLLDNCMH { get; set; }
	public Boolean FLLFLDIDMNE { get; set; }
	public Boolean GICJKCOKDCH { get; set; }
	public Boolean MBEDBIKJBOM { get; set; }
	public Boolean KNPACMOLBOE { get; set; }
	public Boolean GKDOBOEENDB { get; }
	public List`1 JHMMBNFJCKG { get; }
	public Boolean IJBJJGDMABM { get; }
	public Boolean GDKNPOIADPA { get; set; }
	public ArcGenerator HPIFCBMIBBD { get; }
	public BezierSlide MKKNFNMGLEG { get; }
	private Vector3 EDHIMLDDKAH { get; }
	private Vector3 BGJAOIBBIIE { get; set; }
	private Vector3 AMMHHOAADLN { get; set; }
	private Boolean FPKFIKBDBAL { get; set; }
	private FAINJNFLPEE CFJNPDAAHAE { get; }
	public Boolean EDNBAEMFPKC { get; }
	public EAvatarModelIngameType BOJLLAPPHBK { get; }
	public AvatarTransformData KJDCMLJDEMK { get; }
	public PVEEnergyBallManager JCDPGOIDNBO { get; set; }
	public Boolean FOCKKHFBHPD { get; }
	public Boolean IDDMOPOHKPJ { get; }
	public ClimbingTrigger NODLLGGEIBF { get; }
	private Dictionary`2 CNOLIADNIPK { get; }
	public Boolean OCGFJFKOPBD { get; }
	public Boolean KPKHALMFEKF { get; }
	public Boolean JFOHGJCANMP { get; }
	public Boolean JINIJFONCCB { get; }
	public Boolean CPGDBMHKHCF { get; }
	public GPBDEDFKJNA PHPOJNJJJJC { get; }
	public HBKDJCNCLCE AHHHDGIJMIJ { get; }
	public Boolean LCPOCMKNKAB { get; }
	public Boolean OEFMKHKHPNJ { get; }
	public Boolean FMENPGDGCML { get; }
	public Boolean BOBPHLENPOD { get; set; }
	public Boolean CIAKKHCFGFC { get; }
	public Boolean KFFEOMGCOBO { get; }
	public Boolean KMMKKLDMEGM { get; }
	public Boolean CNHIMPHCIAI { get; }
	public Boolean EDOKAHPMFIM { get; set; }
	public Boolean CJLIMMPHKGJ { get; }
	public Byte HNOENPIFBNL { get; }
	public Boolean OKBEPCFMCJC { get; }
	public Int32 FHFGCKGOMGO { get; }
	public CCGBDNBALMI IJBNNNALNIK { get; set; }
	public Boolean PFNBJLDAGGD { get; }
	public FoldWingConfigData JDODMKEPPNG { get; }
	public Boolean PJGBEEDGBON { get; set; }
	public Football CBFDFHABLIM { get; }
	public Single CKEKAPOLDAM { get; }
	public Boolean BILJIPOILDD { get; }
	protected List`1 FCAEJHHAFCA { get; }
	public GHCOKFDGCNF JBPOAMOMIFA { get; set; }
	public Player_FPPModel MEMFAAHDJDM { get; }
	public Boolean OFJLNEMDMAM { get; }
	public Int32 ILKLIHOCJEN { get; }
	public Int32 BMPKNEJBDHP { get; }
	public Int32 KDDNMKCKDIL { get; }
	public Single ANCJPEOIEHD { get; }
	public Boolean APLKOHCELBK { get; }
	public Boolean GIPJOLAFCNB { get; }
	public Boolean JMIJEBJMLHG { get; }
	public Boolean MDCJIOPJFJP { get; }
	public CKMBFCELDAO EBOPGNPLBOE { get; }
	public Boolean HGENIGEDNIO { get; }
	public MADMMIICBNN KJADDCANPJN { get; }
	public Boolean ONFIONIEFGN { get; }
	public Boolean ANBCJGBGFBA { get; }
	public Boolean MNCBODIBDAN { get; }
	public Boolean AMAPNBCFIJN { get; }
	public Player OIFHDFOAHAA { get; set; }
	public Single DNPGGMOJION { get; set; }
	public Single JIOMGAGKCJL { get; }
	public Single KLGNNDLNGHJ { get; set; }
	public Single JPPOINGLPBN { get; }
	public Single IMFADHNGBBN { get; set; }
	public Single BGJFIKAHMNJ { get; }
	public Single IPFAMKGLGIG { get; set; }
	public Single HJJOOKKOICO { get; }
	public Boolean MEKHBAAMNBP { get; }
	public Boolean CCHFFCHILCL { get; }
	public HOHOHJMCDGA ICBNFFMDFGP { get; }
	public UInt32 OIFPNDKHLPE { get; }
	public Vector3 IEBKAELKDFF { get; }
	public Boolean AHLEEFJOIKP { get; }
	public KHDMPGBLNCM DOPEOMJDEPC { get; }
	protected Single KOOGCLBBJHP { get; }
	protected Single CMOIDFCEHBN { get; }
	public Vector3 EEEIBKLMNDN { get; }
	public Boolean CDPIAJMOGMN { get; }
	public Boolean PGJCEANJPPI { get; set; }
	public Boolean EBLJBEEMBGE { get; set; }
	public Int32 LJBCNMIFEFJ { get; set; }
	public Int32 JMFDKFEGFLK { get; set; }
	public Int32 AHHNGMMAMMG { get; }
	public Int32 ALFKOKPECKN { get; set; }
	public Int32 EOEKAOHEMPP { get; set; }
	public Int32 OHOMAJNANED { get; }
	public Int32 JAMLPDKPOHC { get; set; }
	public Int32 KKCCJDIBIHD { get; set; }
	public Int32 ALPEBDEJHAP { get; set; }
	public Boolean GADGEAMIMED { get; }
	public UInt32 FNGDFCPPBPG { get; }
	public Int32 OCKCOOPFHBA { get; set; }
	public Int32 HGPIPGFJMEB { get; }
	public Boolean EHLGMMDMGDH { get; }
	public UInt32 PMNAJLOPJKG { get; }
	public Int32 FEPEFNDHJPG { get; }
	public Single PKCBJJLHMEO { get; }
	public Int32 NDOJPPCJKIC { get; }
	public Int32 KOKDOPJMGPD { get; set; }
	public Int32 PLHJHKPJHDN { get; }
	public Int32 HIFLJPPPJAN { get; }
	public Boolean IAAEKPFDJHK { get; }
	public Int32 LOOIDLJGDHP { get; }
	public Int32 GBLBEFNFKGD { get; }
	public Single BEJOJAEJKLO { get; }
	public Int32 CBNPIFJAKFJ { get; }
	public INNIMLNIOIA IIJLDPOMKNL { get; }
	public Int32 ELLCNHNCNCC { get; }
	public Boolean GBDOJEMKGPD { get; }
	public Int32 ADPCNGKFADL { get; }
	public Int32 NHPIDPBPPII { get; }
	public Int32 EAMPFEJIFLA { get; }
	public Byte IDEPJJALDIK { get; }
	public Int32 INFBGJBCLMC { get; }
	public Int32 ANNJOPOOOFO { get; }
	public UInt32 NFPPMIHIMJH { get; }
	public Boolean NAMKPAIJALK { get; set; }
	public Int32 ELEIEHDKHJM { get; }
	public Int32 HKAJPDLHJPA { get; }
	public Int32 NDACFLCILDK { get; }
	public Boolean DPEBBONMIHE { get; }
	public Int32 HJPDAOFPHJA { get; }
	public UInt32 KJPNIKHFKDJ { get; }
	public Int32 INLNGPCBGFI { get; }
	public UInt32 DBNIDAFPMHG { get; }
	public Int32 KEEADNIPIKE { get; }
	public UInt32 EGCHLGKIIFM { get; }
	public Boolean GNIOKEILMBJ { get; }
	public Int32 BPKBPDCHHCH { get; }
	public UInt32 OBIJLEIGAJC { get; }
	public UInt32 JGPMMHIGGCA { get; }
	public Byte DOAKODIPCCG { get; }
	public Int32 CMNOAMEDCIM { get; }
	public Int32 NEJBENPMECK { get; }
	public Single BKPLECJDNNN { get; }
	public UInt32 IENIPKGIIKK { get; }
	public UInt32 HFBJBHMDPII { get; }
	public MFMBECGKCNM EPJHBFJMJLJ { get; }
	public Int32 NLLEHOKPHHN { get; }
	public Boolean PJCBMEJPCPH { get; }
	public Boolean ACMMDNJFLGK { get; }
	public UInt32 BDNBGOHCKJF { get; }
	public Single BCDOOOCHNOF { get; }
	public Boolean MFHDIDBGKEP { set; }
	public Int32 GAPGDEHHDCN { get; }
	public UInt32 HAGPMPDJHNC { get; }
	public UInt32 JFLBPPBLEPB { get; }
	public Boolean LPMCCPCLGBN { get; }
	public Boolean HNFJGOBEMKM { get; set; }
	public Single DKEFDABEPLJ { get; }
	public Int32 MHJMENLPANO { get; }
	public Int32 KJKENCDMEDC { get; }
	public Boolean DMPPPDAFIIC { get; }
	public Boolean AENDMLNBMHH { get; }
	public Byte DDPABHOMLJP { get; set; }
	public Byte NDCOECLCDLA { get; }
	public Int32 IGFOFIPJIKF { get; }
	public Byte KHNAFDBPPON { get; }
	public UInt16 GOGNBHLGECA { get; }
	public Boolean MDMEANIOKJH { get; }
	public Boolean ONDFBKPADAE { get; }
	public Byte LMPMFBDBKIK { get; }
	public Byte MFAKFIALKIK { get; }
	public UInt16 IHLIJFECCEC { get; }
	public Byte GLOKOKNOEBF { get; }
	public Byte GNOFOFFKHBF { get; }
	public UInt32 PLHMEBHBNJJ { get; }
	public UInt32 AJPANOOFOCB { get; }
	public UInt64 ADEPGNOKFBP { get; }
	public Boolean HNMNEMFEKFA { get; }
	public Boolean HFFGDIIPDFP { get; }
	public Int32 BCNAGICEBAL { get; }
	public UInt32 DKNFIBPLJHG { get; }
	public UInt32 LGIHPKPLAMF { get; }
	public UInt32 CMFKNDHJLPJ { get; }
	public Int32 CHFMHPGADKM { get; }
	public UInt32 BEGDDBIMPCO { get; }
	public Boolean JKGEABFADCO { get; set; }
	public Boolean IMEDADNKAKL { get; }
	public Boolean PJHCDJKNLON { get; }
	public Boolean GPPOKKMKOEM { get; }
	public Boolean PGIDLPHPOLJ { get; }
	public VehicleDriverCameraTarget JEKIIDNDOPG { get; }
	protected BCIGOPJHDPB BCIGOPJHDPB { get; set; }
	public Boolean ONDKEAJMHPJ { get; }
	public Boolean OGNJMIBKLCD { get; }
	public Boolean JLCBAGLEDIH { get; }
	public AEMINKPBIIJ NKOFHJFNIJP { get; set; }
	public EHEGBOKBKJG KMJBCCOAJON { get; }
	public Boolean LPBBNOGKAGG { get; }
	public Boolean EHKKLLNOBGO { get; }
	private Boolean JGJDOGIGMHN { get; }
	public Boolean NCPJDOCMEEH { get; }
	private Boolean AGEKOLFACHF { get; }
	public Boolean DHJDBFFAHAM { get; }
	public UInt32 HJFFJILFFEK { get; set; }
	public IHAAMHPPLMG DLOMIEBOLKM { get; }
	public Byte GPOFBNCDLCD { get; }
	public IKBGGPAEFDO IAILGALCJJK { get; }
	public Transform CGGOHIKLEKD { get; }
	public Boolean PKDPHMNGLLG { get; }
	public JAEAODJEENM EKEPLMOHPKL { get; }
	public Boolean JFNGCEALNGP { get; set; }
	public Boolean NKFANDDPHCG { get; set; }
	public Boolean FDCONCGPLAK { get; set; }
	public Boolean OPAGCJCHNNC { get; set; }
	public Boolean JFGIOAOHDOG { get; set; }
	public virtual UGCCameraConfigRepItem AAMFEKEIKJF { get; set; }
	public virtual Int32 DCGOIGJNCEF { get; }
	public virtual UGCFactionRepItem EPLCBDBGOPA { get; set; }
	public Boolean HGJFMOEOIFA { get; }
	public Boolean HPEAGOLIGDK { get; }
	public FFPMOBMCAHM DOFJHIIHBGJ { get; }
	public FFPMOBMCAHM IPDMFNLKEBL { get; }
	public FFPMOBMCAHM GAJPNDPFDNN { get; }
	public FFPMOBMCAHM GHKBKJBHJHN { get; }
	public FFPMOBMCAHM KJOBLGLBPGF { get; }
	public FFPMOBMCAHM MOOMCBPOHFP { get; }
	public FFPMOBMCAHM OJJOBINHNBN { get; }
	public FFPMOBMCAHM FMOFGJDCEJN { get; }
	public FFPMOBMCAHM PMNBFFJGMEA { get; }
	public Boolean NODCBGBMDII { get; }
	public static Int32 LKKNFACINGL { get; }
	public Boolean MCKLKEIAJCF { get; }
	protected Dictionary`2 HIEMKCKHEHM { get; }
	protected List`1 AGHPOOOLFHJ { get; }
	public Boolean JIBAMIEFKKE { get; set; }
	public Boolean CFLILNFPLGB { get; set; }
	public Boolean MKAAAJPDALP { get; set; }
	public Single AKICOMKJFAG { get; }

	// Methods
	// RVA: 0x126cb50 VA: 0x98124b50
	public Void .ctor() { }
	// RVA: 0x126e0ec VA: 0x981260ec
	public Void ClearBuffAction() { }
	// RVA: 0x126e238 VA: 0x98126238
	public Boolean TryGetBuffCustomVisualEffectContext(UInt32 PPDKNGMFJBJ, out BOHHLHCINEH LEKAFNNMDDD) { }
	// RVA: 0x126e320 VA: 0x98126320
	public Void ProcessSyncedBuffActionClientShowEffect(FMBPBMIFDAF GMKGCONNAJG) { }
	// RVA: 0x126ec3c VA: 0x98126c3c
	private BOHHLHCINEH NIOLGBBPHHG(NAJEAIMLDLM ECHCIHMFLKM, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x126f220 VA: 0x98127220
	private static Boolean KIAEIGNDHNG(POOHHHEKCBI PHNCAMALICN, out BOHHLHCINEH LEKAFNNMDDD) { }
	// RVA: 0x126f004 VA: 0x98127004
	private Void DANGJJNEBGM(FMBPBMIFDAF JKBNDADENMG, POOHHHEKCBI PHNCAMALICN, BOHHLHCINEH EGGJLMMNPIO) { }
	// RVA: 0x1271784 VA: 0x98129784
	private Void HLANNAMCLJH(UInt32 BBAFHKCBFFN, ResourceID DAOHLFEOLEK, GameObject GAHBKGJAHPJ) { }
	// RVA: 0x1270d88 VA: 0x98128d88
	private Void OBFNEFMJNNG(FMBPBMIFDAF JKBNDADENMG, BOHHLHCINEH EGGJLMMNPIO, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x12702d8 VA: 0x981282d8
	private Void MMDOEHHFHDN(NAJEAIMLDLM ECHCIHMFLKM, BOHHLHCINEH EGGJLMMNPIO) { }
	// RVA: 0x126f880 VA: 0x98127880
	private Void CBHKBAEMEKI(NAJEAIMLDLM ECHCIHMFLKM, BOHHLHCINEH EGGJLMMNPIO) { }
	// RVA: 0x126f74c VA: 0x9812774c
	private Void NIDIDONGMAF(NAJEAIMLDLM ECHCIHMFLKM, BOHHLHCINEH EGGJLMMNPIO) { }
	// RVA: 0x1271b44 VA: 0x98129b44
	public Void ProcessSyncedBuffActionFunction(BBPEFCEFHBN EJGLEAICHBD) { }
	// RVA: 0x1272244 VA: 0x9812a244
	private Void PIMLLJDMMIK(BBPEFCEFHBN EJGLEAICHBD) { }
	// RVA: 0x127205c VA: 0x9812a05c
	public Void ProcessPlayerGiveDeltaSpeedScaleAction(UInt64 NIHPAPECJNP, BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI MPLAFKFAODI) { }
	// RVA: 0x1272508 VA: 0x9812a508
	private Void IOEOOEGJJEK(BBPEFCEFHBN EJGLEAICHBD) { }
	// RVA: 0x12727b0 VA: 0x9812a7b0
	private Void BNGHHDAACKN(BBPEFCEFHBN EJGLEAICHBD) { }
	// RVA: 0x127295c VA: 0x9812a95c
	private Void OFHHKNLJPHB(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI BACGLEFIAPG) { }
	// RVA: 0x1272d9c VA: 0x9812ad9c
	private Void NADKMOHBLMC() { }
	// RVA: 0x1272f00 VA: 0x9812af00
	private static Void GAADPPEHPII(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x127336c VA: 0x9812b36c
	private Void NMOGGPOAADM(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x1273540 VA: 0x9812b540
	private Void NINPGBCHAJC(BBPEFCEFHBN EJGLEAICHBD) { }
	// RVA: 0x12736a0 VA: 0x9812b6a0
	private Void NPCEFHOIBJO(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x127396c VA: 0x9812b96c
	private Void DBEKIOOADAC(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x1273a50 VA: 0x9812ba50
	private Void BDGDHNAEHBM(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x1273b9c VA: 0x9812bb9c
	private Void DOIAGFICBHI(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x1273e90 VA: 0x9812be90
	private Void HCBEEHJPNMN(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x1274128 VA: 0x9812c128
	private Void FNKKGIPFNNN(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x12743e8 VA: 0x9812c3e8
	private Void GGFPNGINELH(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x1274a14 VA: 0x9812ca14
	private Void HEBBJCPPGCC(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x1276548 VA: 0x9812e548
	public Boolean get_NeedBuffKingVisual() { }
	// RVA: 0x12765a0 VA: 0x9812e5a0
	public Void set_NeedBuffKingVisual(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1275008 VA: 0x9812d008
	private Void BGAKFGFJMIC(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x12750c4 VA: 0x9812d0c4
	private Void COCACNNAMIK(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x12755d4 VA: 0x9812d5d4
	private Void CJLDHJHGNBK(BBPEFCEFHBN EJGLEAICHBD) { }
	// RVA: 0x1275734 VA: 0x9812d734
	private Void KECELJFBKII(BBPEFCEFHBN EJGLEAICHBD, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x12758f8 VA: 0x9812d8f8
	private Void PPLAJGOLEOH(BBPEFCEFHBN EJGLEAICHBD) { }
	// RVA: 0x126fabc VA: 0x98127abc
	private Void HDPPIHJPNPN(FMBPBMIFDAF JKBNDADENMG, BOHHLHCINEH EGGJLMMNPIO, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x127040c VA: 0x9812840c
	private Void ALIGHBJMNAO(FMBPBMIFDAF JKBNDADENMG, BOHHLHCINEH EGGJLMMNPIO, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x12770ec VA: 0x9812f0ec
	public Comparison`1 get_BuffECAKillNotificationComparer() { }
	// RVA: 0x1277298 VA: 0x9812f298
	public HIPMADOOFCD GetBuffECAKillNotificationContext(Boolean BKDPOLJFEHP) { }
	// RVA: 0x12773b8 VA: 0x9812f3b8
	private List`1 PBIOFCNNCOL() { }
	// RVA: 0x1277490 VA: 0x9812f490
	private List`1 ANGFBLDNGGP() { }
	// RVA: 0x1277568 VA: 0x9812f568
	private List`1 FPFDJPDLHJK() { }
	// RVA: 0x1277640 VA: 0x9812f640
	public Void ClearBuffECABeKilledContext() { }
	// RVA: 0x1270a34 VA: 0x98128a34
	private Void LBLLIMAEACC(NAJEAIMLDLM ECHCIHMFLKM, BOHHLHCINEH EGGJLMMNPIO, POOHHHEKCBI PHNCAMALICN, Boolean BKDPOLJFEHP) { }
	// RVA: 0x1277824 VA: 0x9812f824
	public Comparison`1 get_BuffVFXOnTargetComparer() { }
	// RVA: 0x12779d0 VA: 0x9812f9d0
	private List`1 MEMCFNKOKDC() { }
	// RVA: 0x1277aa8 VA: 0x9812faa8
	public CLAEAIOIJAI GetBuffECAKillVFXOnTargetContext() { }
	// RVA: 0x1270c08 VA: 0x98128c08
	private Void CGNEGGMEEBD(NAJEAIMLDLM ECHCIHMFLKM, BOHHLHCINEH EGGJLMMNPIO, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x12712a0 VA: 0x981292a0
	private Void GOKHAHIEOJB(FMBPBMIFDAF JKBNDADENMG, BOHHLHCINEH EGGJLMMNPIO, POOHHHEKCBI PHNCAMALICN) { }
	// RVA: 0x1277d68 VA: 0x9812fd68
	private Void KMOIEAPAIFA() { }
	// RVA: 0x1277e9c VA: 0x9812fe9c
	public PhysicalCCT get_PhysicalCCT() { }
	// RVA: 0x1277ea4 VA: 0x9812fea4
	protected Void ONGOJCAJJPH(PhysicalCCT IMGNBGJDAHG) { }
	// RVA: 0x1277eac VA: 0x9812feac
	public Void UpdateKinematics_UsingPhysicalCCT(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x127b6a4 VA: 0x981336a4
	private Void COW.GamePlay.IPhysicalCharacter.BeforeCCTUpdate() { }
	// RVA: 0x127b724 VA: 0x98133724
	private Void COW.GamePlay.IPhysicalCharacter.AfterCCTUpdate() { }
	// RVA: 0x127df94 VA: 0x98135f94
	private Void COW.GamePlay.IPhysicalCharacter.AfterUpdateGroundState() { }
	// RVA: 0x127dfe8 VA: 0x98135fe8
	private Quaternion COW.GamePlay.IPhysicalCharacter.UpdateRotation(Quaternion JFGLGDFMNAG, Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x127e8f0 VA: 0x981368f0
	private Vector3 COW.GamePlay.IPhysicalCharacter.UpdateVelocity(Vector3 HGFIINKCCAN, Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x127f89c VA: 0x9813789c
	private Void COW.GamePlay.IPhysicalCharacter.OnCollideWith(Collider HFBDJJDICLN) { }
	// RVA: 0x127f8f8 VA: 0x981378f8
	private Void COW.GamePlay.IPhysicalCharacter.OnGroundHit(Collider HFBDJJDICLN, Vector3 MJGMFIOGGAF, Vector3 KFFDFBMFEBM) { }
	// RVA: 0x127f98c VA: 0x9813798c
	private Void COW.GamePlay.IPhysicalCharacter.OnMovementHit(Collider HFBDJJDICLN, Vector3 MJGMFIOGGAF, Vector3 KFFDFBMFEBM) { }
	// RVA: 0x127fa20 VA: 0x98137a20
	public virtual Void OnSyncUGCPhysicalCCTProperty(Int64 EPPGBCFFINM, JOAFEKCBPHD DNHNPDIJHCE) { }
	// RVA: 0x1280258 VA: 0x98138258
	public Void SetDelayDestroyGoInfo(Single NFPILHKMBHL, Action HLLGOKLLGEH) { }
	// RVA: 0x12803ac VA: 0x981383ac
	public static CJKJKAEMMAO GetBuffBehaviorUpdateRes(FPMJDPCJAPL AJKBOONEOAB) { }
	// RVA: 0x12805e4 VA: 0x981385e4
	public static CJKJKAEMMAO GetBuffBehaviorUpdateRes(IHAAMHPPLMG BIFFAIEPIND, UInt32 GFKLEBLGBCP, UInt32 NDDPCCFIBGP, PPLHPCEENEJ KIKIIKHCDCO, Single HDOLNEDLOBK) { }
	// RVA: 0x12809e8 VA: 0x981389e8
	public Boolean get_IsAwayFromPreaparePhaseEndPos() { }
	// RVA: 0x12809f0 VA: 0x981389f0
	protected Void BBFLEIIKNMC(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12809f8 VA: 0x981389f8
	public Void SetIgnoreUserInputState(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1280b30 VA: 0x98138b30
	public Single get_LastStartFireTime() { }
	// RVA: 0x1280b38 VA: 0x98138b38
	public Void set_LastStartFireTime(Single IMGNBGJDAHG) { }
	// RVA: 0x1280b40 VA: 0x98138b40
	public Void SetIgnoreMoveInput(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1280cfc VA: 0x98138cfc
	public Boolean get_IsAvatarHasEffect() { }
	// RVA: 0x1280d54 VA: 0x98138d54
	public Void set_IsAvatarHasEffect(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1280db4 VA: 0x98138db4
	public List`1 get_OwnedDebuffInfos() { }
	// RVA: 0x1280e8c VA: 0x98138e8c
	public Void set_HasTriggerGrenadeOnHand(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1281350 VA: 0x98139350
	public Boolean get_HasTriggerGrenadeOnHand() { }
	// RVA: 0x12813a8 VA: 0x981393a8
	public MJFNDLDGOCL get_BooyahBountyData() { }
	// RVA: 0x12814a4 VA: 0x981394a4
	public Void AddEPSurroundEffect(Int32 EIKCFIDCCMM, Boolean GJMAOIBIEBI) { }
	// RVA: 0x128186c VA: 0x9813986c
	public Void ForceMoveByClientHit(Vector3 LGCEBENCFFM) { }
	// RVA: 0x1281f00 VA: 0x98139f00
	public Void SetAirShopBoughtData(UInt32 KMGIELCFMND, UInt16 BJBICJALBNE) { }
	// RVA: 0x1282028 VA: 0x9813a028
	public UInt16 GetAirShopBoughtById(UInt32 IDNEFEOPGIF) { }
	// RVA: 0x1282110 VA: 0x9813a110
	public Void ClearAirShopBounght() { }
	// RVA: 0x12821c4 VA: 0x9813a1c4
	public OGLOLLNEBAC get_HippoCrisisGameFinishedType() { }
	// RVA: 0x12821cc VA: 0x9813a1cc
	public Void set_HippoCrisisGameFinishedType(OGLOLLNEBAC IMGNBGJDAHG) { }
	// RVA: 0x12821d4 VA: 0x9813a1d4
	public Void UpdateAutoFLihtDamageEffect(Boolean ODOEHEHNJOG, IHAAMHPPLMG LHBBHLJCNOM) { }
	// RVA: 0x1281ad8 VA: 0x98139ad8
	private Vector3 KEOMJALFPKD(Vector3 NLPMJMOOMIH, Single IHDMOOHOJKO) { }
	// RVA: 0x1282a1c VA: 0x9813aa1c
	public Boolean GetInPartyShoot() { }
	// RVA: 0x1282a74 VA: 0x9813aa74
	public Void SetInPartyShoot(Boolean EBOJJLIHHCM) { }
	// RVA: 0x1282ad4 VA: 0x9813aad4
	public Void SetPartyEffectShow(UInt32 EIKCFIDCCMM) { }
	// RVA: 0x1282bdc VA: 0x9813abdc
	public Void InitMusicPartyEffect() { }
	// RVA: 0x1282cd8 VA: 0x9813acd8
	protected Void AFAAALFAJJJ() { }
	// RVA: 0x1283044 VA: 0x9813b044
	public Void SyncRevengeInfo(MDGAOJIACDM LHCHNFGKLHD) { }
	// RVA: 0x12831c4 VA: 0x9813b1c4
	public Void SyncRevengersInfo(HNOGPPOKMHC LHCHNFGKLHD) { }
	// RVA: 0x12836ac VA: 0x9813b6ac
	public Void UpdateRevengeStatus(Boolean DPEBBLGPIMH) { }
	// RVA: 0x1283d94 VA: 0x9813bd94
	public Void EnableCrossWindowEffect(Boolean KENDCFNPDCE) { }
	// RVA: 0x1283df0 VA: 0x9813bdf0
	public Transform GetRuntimeMainCameraTransform() { }
	// RVA: 0x1283f90 VA: 0x9813bf90
	public override Vector3 GetAttackableCenterWS() { }
	// RVA: 0x1284950 VA: 0x9813c950
	public override Single GetAttackableRadius() { }
	// RVA: 0x12849c8 VA: 0x9813c9c8
	public UInt32 GenerateLocalDamgeProjectileID() { }
	// RVA: 0x1284a9c VA: 0x9813ca9c
	public UInt64 get_UserID() { }
	// RVA: 0x1284afc VA: 0x9813cafc
	protected Void AHGMDFNMNMO(UInt64 IMGNBGJDAHG) { }
	// RVA: 0x1284b7c VA: 0x9813cb7c
	public UInt64 GetShowUserID() { }
	// RVA: 0x126eb38 VA: 0x98126b38
	public IHAAMHPPLMG get_PlayerID() { }
	// RVA: 0x1284cb0 VA: 0x9813ccb0
	protected Void MHBBNJFBKIB(IHAAMHPPLMG IMGNBGJDAHG) { }
	// RVA: 0x1284d5c VA: 0x9813cd5c
	public UInt64 get_ServiceGroupID() { }
	// RVA: 0x1284dbc VA: 0x9813cdbc
	protected Void MPNFKACJCOH(UInt64 IMGNBGJDAHG) { }
	// RVA: 0x1284e3c VA: 0x9813ce3c
	public UInt64 get_TrackingPlayerServiceGroup() { }
	// RVA: 0x1284e9c VA: 0x9813ce9c
	public Int32 get_TeamIndex() { }
	// RVA: 0x1284ea4 VA: 0x9813cea4
	public Void set_TeamIndex(Int32 IMGNBGJDAHG) { }
	// RVA: 0x1284eac VA: 0x9813ceac
	protected Void COBFGPKKCCK(IHAAMHPPLMG IMGNBGJDAHG) { }
	// RVA: 0x1284ee0 VA: 0x9813cee0
	public IHAAMHPPLMG get_KillerPlayerID() { }
	// RVA: 0x1284ef8 VA: 0x9813cef8
	public UInt32 get_CustomRoomIndex() { }
	// RVA: 0x1284f00 VA: 0x9813cf00
	public Void set_CustomRoomIndex(UInt32 IMGNBGJDAHG) { }
	// RVA: 0x1284f08 VA: 0x9813cf08
	public String get_GroupName() { }
	// RVA: 0x1284f10 VA: 0x9813cf10
	public Void set_GroupName(String IMGNBGJDAHG) { }
	// RVA: 0x1284f18 VA: 0x9813cf18
	public String get_GroupNameAbbr() { }
	// RVA: 0x1284f20 VA: 0x9813cf20
	public Void set_GroupNameAbbr(String IMGNBGJDAHG) { }
	// RVA: 0x1284f28 VA: 0x9813cf28
	public UInt32 get_GroupIcon() { }
	// RVA: 0x1284f30 VA: 0x9813cf30
	public Void set_GroupIcon(UInt32 IMGNBGJDAHG) { }
	// RVA: 0x1284f38 VA: 0x9813cf38
	public UInt32 get_PartyGameCombo() { }
	// RVA: 0x1284f40 VA: 0x9813cf40
	public Void set_PartyGameCombo(UInt32 IMGNBGJDAHG) { }
	// RVA: 0x1284f48 VA: 0x9813cf48
	public Object get_SynInfo() { }
	// RVA: 0x1284fa0 VA: 0x9813cfa0
	protected Void LGLCLODPMIF(Object IMGNBGJDAHG) { }
	// RVA: 0x1285000 VA: 0x9813d000
	public String get_NickName() { }
	// RVA: 0x1285058 VA: 0x9813d058
	protected Void KGLHIDLDMKD(String IMGNBGJDAHG) { }
	// RVA: 0x1284bf8 VA: 0x9813cbf8
	public Boolean get_IsSamoAI() { }
	// RVA: 0x12850b8 VA: 0x9813d0b8
	public Void set_IsSamoAI(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1284c50 VA: 0x9813cc50
	public UInt64 get_SamoUserID() { }
	// RVA: 0x1285118 VA: 0x9813d118
	protected Void HEHPIDPDFJD(UInt64 IMGNBGJDAHG) { }
	// RVA: 0x1285198 VA: 0x9813d198
	public List`1 get_SamoSkillDatas() { }
	// RVA: 0x1285270 VA: 0x9813d270
	public Void ReplaceSamoInfo(UInt64 HHMJNLLBELP, String KCKPGNOGDDI) { }
	// RVA: 0x12853e4 VA: 0x9813d3e4
	public Boolean get_IsDoingAction() { }
	// RVA: 0x12853ec VA: 0x9813d3ec
	public Void set_IsDoingAction(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12853f4 VA: 0x9813d3f4
	public EPreparationTimerType get_DoingPrearationActionType() { }
	// RVA: 0x128544c VA: 0x9813d44c
	public Void set_DoingPrearationActionType(EPreparationTimerType IMGNBGJDAHG) { }
	// RVA: 0x1285580 VA: 0x9813d580
	public Boolean get_NeedRepairArmor() { }
	// RVA: 0x128578c VA: 0x9813d78c
	public Boolean get_HasVest() { }
	// RVA: 0x1285898 VA: 0x9813d898
	public Boolean get_HasHelmet() { }
	// RVA: 0x12859a4 VA: 0x9813d9a4
	public Boolean get_IsAvatarInitialized() { }
	// RVA: 0x12859fc VA: 0x9813d9fc
	protected Void ILNNDPAKEKB(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1285a5c VA: 0x9813da5c
	public CharacterController get_CharacterController() { }
	// RVA: 0x1285ab4 VA: 0x9813dab4
	public Void set_IsReady(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1285b14 VA: 0x9813db14
	public Boolean get_IsReady() { }
	// RVA: 0x1285b6c VA: 0x9813db6c
	public Void set_IsInShop(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1285bcc VA: 0x9813dbcc
	public Boolean get_IsInShop() { }
	// RVA: 0x1285c24 VA: 0x9813dc24
	public Void set_CurrentInGameShopID(UInt32 IMGNBGJDAHG) { }
	// RVA: 0x1285c84 VA: 0x9813dc84
	public UInt32 get_CurrentInGameShopID() { }
	// RVA: 0x1285cdc VA: 0x9813dcdc
	public Void set_IsInPartyMusicShoot(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1285d3c VA: 0x9813dd3c
	public Boolean get_IsInPartyMusicShoot() { }
	// RVA: 0x1285d94 VA: 0x9813dd94
	public Void set_IsInPartySoloDance(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1285df4 VA: 0x9813ddf4
	public Boolean get_IsInPartySoloDance() { }
	// RVA: 0x1285e4c VA: 0x9813de4c
	public UInt32 GenUniqueID() { }
	// RVA: 0x1285eb0 VA: 0x9813deb0
	public Boolean get_IsCuring() { }
	// RVA: 0x1285f08 VA: 0x9813df08
	public Void set_IsCuring(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1285f68 VA: 0x9813df68
	public Boolean get_IsPreparing() { }
	// RVA: 0x1285f70 VA: 0x9813df70
	protected Void GFFHEDBLHPM(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1285f78 VA: 0x9813df78
	public Boolean get_IsEating() { }
	// RVA: 0x1285f80 VA: 0x9813df80
	public Void set_IsEating(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1285f88 VA: 0x9813df88
	public Boolean get_IsRepairing() { }
	// RVA: 0x1285f90 VA: 0x9813df90
	public Void set_IsRepairing(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1285f98 VA: 0x9813df98
	public Boolean get_UseActiveSkillState() { }
	// RVA: 0x1285fa0 VA: 0x9813dfa0
	public Void set_UseActiveSkillState(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1285fa8 VA: 0x9813dfa8
	public Boolean get_UseEpState() { }
	// RVA: 0x1285fb0 VA: 0x9813dfb0
	public Void set_UseEpState(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1285fb8 VA: 0x9813dfb8
	public Boolean get_IsGrenadeStart() { }
	// RVA: 0x1286140 VA: 0x9813e140
	public Boolean get_IsThrowingKnifeStart() { }
	// RVA: 0x1286268 VA: 0x9813e268
	public EPlayerLastKillState get_LastKillEffectState() { }
	// RVA: 0x1286270 VA: 0x9813e270
	public Void set_LastKillEffectState(EPlayerLastKillState IMGNBGJDAHG) { }
	// RVA: 0x1286278 VA: 0x9813e278
	public Boolean get_IsInDashBefore() { }
	// RVA: 0x12770e4 VA: 0x9812f0e4
	public Void set_IsInDashBefore(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1286280 VA: 0x9813e280
	public Boolean get_KeepDashAfterFiring() { }
	// RVA: 0x12862d8 VA: 0x9813e2d8
	public Void set_KeepDashAfterFiring(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1286338 VA: 0x9813e338
	public UInt32 get_BattleFlagID() { }
	// RVA: 0x1286340 VA: 0x9813e340
	public Void set_BattleFlagID(UInt32 IMGNBGJDAHG) { }
	// RVA: 0x1286348 VA: 0x9813e348
	public String get_LockRegion() { }
	// RVA: 0x1286350 VA: 0x9813e350
	public Void set_LockRegion(String IMGNBGJDAHG) { }
	// RVA: 0x1286358 VA: 0x9813e358
	public Boolean get_DisableFriendSpectate() { }
	// RVA: 0x1286360 VA: 0x9813e360
	public Void set_DisableFriendSpectate(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1286368 VA: 0x9813e368
	private Queue`1 LBEHJPHCDCD() { }
	// RVA: 0x1286440 VA: 0x9813e440
	public UInt32 get_CurrentIdleEmotionID() { }
	// RVA: 0x1286498 VA: 0x9813e498
	public UInt32 get_CurrentEmotionID() { }
	// RVA: 0x12864f0 VA: 0x9813e4f0
	public Boolean get_IsFreezeEmote() { }
	// RVA: 0x1286548 VA: 0x9813e548
	public UInt32 get_CurrentEmotionEffIdx() { }
	// RVA: 0x12865a0 VA: 0x9813e5a0
	public Void SetBooyahEmotionID(UInt32 IDNEFEOPGIF) { }
	// RVA: 0x1286600 VA: 0x9813e600
	public Void RequireFollowCameraRotationUpdateTracing() { }
	// RVA: 0x128666c VA: 0x9813e66c
	public Boolean IsTracingFollowCameraRotationUpdate() { }
	// RVA: 0x12866c4 VA: 0x9813e6c4
	public Boolean IsFollowCameraRotationUpdateTracingFinished() { }
	// RVA: 0x128671c VA: 0x9813e71c
	public Void UpdateFollowCameraRotationUpdateTracing(Boolean OAHOFGAPLJK, Boolean FJNODLOFNAA) { }
	// RVA: 0x12867f4 VA: 0x9813e7f4
	protected Quaternion EIMDIDANNEG() { }
	// RVA: 0x1286804 VA: 0x9813e804
	protected Void JPNJCAONHME(Quaternion IMGNBGJDAHG) { }
	// RVA: 0x1286814 VA: 0x9813e814
	protected Quaternion EJLGMFOHCFF() { }
	// RVA: 0x1286824 VA: 0x9813e824
	protected Void NEEPCKOFDHE(Quaternion IMGNBGJDAHG) { }
	// RVA: 0x1286834 VA: 0x9813e834
	public Boolean get_FriendAuxEnabled() { }
	// RVA: 0x128683c VA: 0x9813e83c
	private Void FJLHAMPHDIJ(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1286844 VA: 0x9813e844
	public Void set_IsAuxAiming(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1286e8c VA: 0x9813ee8c
	public Boolean get_IsAuxAiming() { }
	// RVA: 0x1286ee4 VA: 0x9813eee4
	public Boolean get_NeedLerpAuxAiming() { }
	// RVA: 0x1286f3c VA: 0x9813ef3c
	public Void set_NeedLerpAuxAiming(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1286f9c VA: 0x9813ef9c
	public Boolean get_IsInBlockViewTrigger() { }
	// RVA: 0x1287074 VA: 0x9813f074
	public HashSet`1 get_InBlockViewTriggerSet() { }
	// RVA: 0x128714c VA: 0x9813f14c
	public Boolean get_IsBanAimAssistState() { }
	// RVA: 0x1287224 VA: 0x9813f224
	public Single get_CustomGravity() { }
	// RVA: 0x1287350 VA: 0x9813f350
	public EAimAssist get_EAimAssit() { }
	// RVA: 0x128745c VA: 0x9813f45c
	public Void SetEAimAssitMode(EAimAssist NFPHLGPHGIK) { }
	// RVA: 0x12875d8 VA: 0x9813f5d8
	public FFNBBHKEDAE GetAimAssistOnSighting() { }
	// RVA: 0x12876a4 VA: 0x9813f6a4
	public NLIOCEKCAOF GetSightCameraRot() { }
	// RVA: 0x127cdec VA: 0x98134dec
	public Boolean get_IsDieing() { }
	// RVA: 0x1287770 VA: 0x9813f770
	public Boolean get_IsKnockDownKeepForwardAsAiming() { }
	// RVA: 0x1287864 VA: 0x9813f864
	public CEPIKIJENLK GetResureStatus() { }
	// RVA: 0x12878bc VA: 0x9813f8bc
	public Boolean get_IsRescureing() { }
	// RVA: 0x128792c VA: 0x9813f92c
	public Boolean get_IsRescured() { }
	// RVA: 0x128799c VA: 0x9813f99c
	public FollowCamera get_MyFollowCamera() { }
	// RVA: 0x1287ae4 VA: 0x9813fae4
	public Vector3 GetChestPos(Boolean HCHMPFNDCND) { }
	// RVA: 0x1287efc VA: 0x9813fefc
	protected virtual Transform LPCNANNNHAH() { }
	// RVA: 0x1288050 VA: 0x98140050
	public virtual Collider get_HeadCollider() { }
	// RVA: 0x1288328 VA: 0x98140328
	public NJKAFIOELHI get_PersistCounterManager() { }
	// RVA: 0x1288380 VA: 0x98140380
	public NewPlayerAnimationSystemComponent get_NewAnimComponent() { }
	// RVA: 0x12883d8 VA: 0x981403d8
	public AvatarManager get_AvatarMag() { }
	// RVA: 0x1288430 VA: 0x98140430
	public IceWallMakerData get_CurIceWallMakerData() { }
	// RVA: 0x1288488 VA: 0x98140488
	public AvatarManager GetAvatarManager() { }
	// RVA: 0x1275c5c VA: 0x9812dc5c
	public PlayerAttributes get_Attributes() { }
	// RVA: 0x12887cc VA: 0x981407cc
	public Boolean get_LoopPlayEmotion() { }
	// RVA: 0x12887d4 VA: 0x981407d4
	public Void set_LoopPlayEmotion(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12887dc VA: 0x981407dc
	public Boolean get_IsLoopingPlayEmotion() { }
	// RVA: 0x12887e4 VA: 0x981407e4
	public Void set_IsLoopingPlayEmotion(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12887ec VA: 0x981407ec
	public Transform get_WeaponMountTF() { }
	// RVA: 0x1288940 VA: 0x98140940
	public Transform get_WeaponSecondaryMountTF() { }
	// RVA: 0x1288a94 VA: 0x98140a94
	public Transform get_LeftDummyWeaponMountTF() { }
	// RVA: 0x1288f3c VA: 0x98140f3c
	public Transform get_RightHandTF() { }
	// RVA: 0x1288de0 VA: 0x98140de0
	public Transform get_LeftHandTF() { }
	// RVA: 0x1289090 VA: 0x98141090
	public Transform get_LeftForeArmTF() { }
	// RVA: 0x12891e4 VA: 0x981411e4
	public Transform get_RightForeArmTF() { }
	// RVA: 0x1289338 VA: 0x98141338
	public NavMeshAgent get_NavMeshAgent() { }
	// RVA: 0x1289390 VA: 0x98141390
	public NetworkPet get_Pet() { }
	// RVA: 0x1289398 VA: 0x98141398
	public Void set_Pet(NetworkPet IMGNBGJDAHG) { }
	// RVA: 0x12893a0 VA: 0x981413a0
	public Boolean get_IsPetHiddenByLocalPlayer() { }
	// RVA: 0x12893f8 VA: 0x981413f8
	public Void set_IsPetHiddenByLocalPlayer(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1289458 VA: 0x98141458
	public Boolean get_HaveDamageAdditionBuffForOni() { }
	// RVA: 0x12894b0 VA: 0x981414b0
	private Void GICLKJKJBHL(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12895e4 VA: 0x981415e4
	public Boolean get_HaveOniQuest() { }
	// RVA: 0x12895ec VA: 0x981415ec
	public Void set_HaveOniQuest(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12895f4 VA: 0x981415f4
	public Void set_HasEagleSkill(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12896d8 VA: 0x981416d8
	public Boolean get_HasEagleSkill() { }
	// RVA: 0x1289730 VA: 0x98141730
	public Void set_HasShowBountyBoxUnlockEffect(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1289738 VA: 0x98141738
	public Boolean get_HasShowBountyBoxUnlockEffect() { }
	// RVA: 0x1289740 VA: 0x98141740
	public Void set_IgnoreAimAssistType(UInt32 IMGNBGJDAHG) { }
	// RVA: 0x1289748 VA: 0x98141748
	public UInt32 get_IgnoreAimAssistType() { }
	// RVA: 0x1289750 VA: 0x98141750
	public Void set_LastStartJumpTime(Single IMGNBGJDAHG) { }
	// RVA: 0x12897c0 VA: 0x981417c0
	public Single get_LastStartJumpTime() { }
	// RVA: 0x1289818 VA: 0x98141818
	public Void set_LastStartJumpPos(Vector3 IMGNBGJDAHG) { }
	// RVA: 0x12898a0 VA: 0x981418a0
	public Vector3 get_LastStartJumpPos() { }
	// RVA: 0x1289918 VA: 0x98141918
	public Void ResetHitFlyGetUpSpeed() { }
	// RVA: 0x128998c VA: 0x9814198c
	public Void ResetHitFlyInfo() { }
	// RVA: 0x1289a1c VA: 0x98141a1c
	public virtual Boolean get_IsRecoveringFromHitFly() { }
	// RVA: 0x1289afc VA: 0x98141afc
	public Boolean get_InFallingState() { }
	// RVA: 0x1289b7c VA: 0x98141b7c
	public Void ResetSwapWeaponTime() { }
	// RVA: 0x1289be0 VA: 0x98141be0
	public Boolean get_InSwapWeaponCD() { }
	// RVA: 0x1289cf4 VA: 0x98141cf4
	public Boolean get_WaitForForceSync() { }
	// RVA: 0x1289d4c VA: 0x98141d4c
	public Void SetAimRotation(Quaternion JGOGIAFGCFC) { }
	// RVA: 0x1286138 VA: 0x9813e138
	public Boolean get_IsPrepareAttack() { }
	// RVA: 0x1289e14 VA: 0x98141e14
	public Void set_IsPrepareAttack(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1289e1c VA: 0x98141e1c
	public LMAFDMFMENA get_CancelHudTarget() { }
	// RVA: 0x1289e74 VA: 0x98141e74
	public Void ReleaseCancelTargetExcept(LMAFDMFMENA GIHNLPHCJGM) { }
	// RVA: 0x1289f90 VA: 0x98141f90
	public LMAFDMFMENA GetCancelTarget() { }
	// RVA: 0x1289fe8 VA: 0x98141fe8
	public Void SetCancelTargetTriggered() { }
	// RVA: 0x128a1bc VA: 0x981421bc
	public Void SetCancelTargetPressed(Boolean JAIBGLCNMMO, LMAFDMFMENA FFDHFKIMFDG) { }
	// RVA: 0x1265b88 VA: 0x9811db88
	public EntityInfo get_CurTriggeredEntityInfo() { }
	// RVA: 0x128a49c VA: 0x9814249c
	public EntityInfo get_CurTriggeredPickUpEntityInfo() { }
	// RVA: 0x128a514 VA: 0x98142514
	public Boolean get_IsInRoom() { }
	// RVA: 0x128a6c0 VA: 0x981426c0
	public Boolean get_IsInShoal() { }
	// RVA: 0x128a790 VA: 0x98142790
	public Boolean get_IsInWater() { }
	// RVA: 0x128a860 VA: 0x98142860
	public Boolean get_IsInClimbTrigger() { }
	// RVA: 0x128a930 VA: 0x98142930
	public Boolean get_IsInBattleZone() { }
	// RVA: 0x128ab38 VA: 0x98142b38
	public Boolean get_IsInShootingRange() { }
	// RVA: 0x128aba8 VA: 0x98142ba8
	public Boolean get_IsInSocialZone() { }
	// RVA: 0x128ac10 VA: 0x98142c10
	public Boolean get_IsInVideioRoom() { }
	// RVA: 0x128ac80 VA: 0x98142c80
	public Boolean get_IsInIceWallPractice() { }
	// RVA: 0x128acf0 VA: 0x98142cf0
	public Boolean get_IsInBoxingZone() { }
	// RVA: 0x128ad60 VA: 0x98142d60
	public Boolean get_IsInZepplinZone() { }
	// RVA: 0x128add0 VA: 0x98142dd0
	public Boolean get_IsInSkyFallingZone() { }
	// RVA: 0x128ae40 VA: 0x98142e40
	public Boolean get_IsInGrenadePractice() { }
	// RVA: 0x128aeb0 VA: 0x98142eb0
	public Boolean get_IsInBoybandBRoom() { }
	// RVA: 0x128af20 VA: 0x98142f20
	public Boolean get_IsInFootballField() { }
	// RVA: 0x128af90 VA: 0x98142f90
	public Boolean get_IsInRacingZone() { }
	// RVA: 0x128b000 VA: 0x98143000
	public Void set_GrapplingHook(LevelGrapplingHook IMGNBGJDAHG) { }
	// RVA: 0x128b060 VA: 0x98143060
	public LevelGrapplingHook get_GrapplingHook() { }
	// RVA: 0x128b0b8 VA: 0x981430b8
	public Int32 get_CurrentRailStropIndex() { }
	// RVA: 0x128b110 VA: 0x98143110
	public Void set_CurrentRailStropIndex(Int32 IMGNBGJDAHG) { }
	// RVA: 0x128b170 VA: 0x98143170
	public Single get_CurrentRailStropProgRate() { }
	// RVA: 0x128b1c8 VA: 0x981431c8
	public Void set_CurrentRailStropProgRate(Single IMGNBGJDAHG) { }
	// RVA: 0x128b234 VA: 0x98143234
	public Boolean get_IsRailStropForwardDir() { }
	// RVA: 0x128b28c VA: 0x9814328c
	public Void set_IsRailStropForwardDir(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128b2ec VA: 0x981432ec
	public Void set_SwingSpider(LevelSwingSpider IMGNBGJDAHG) { }
	// RVA: 0x128b34c VA: 0x9814334c
	public LevelSwingSpider get_SwingSpider() { }
	// RVA: 0x128b3a4 VA: 0x981433a4
	public Boolean get_IsReallyDead() { }
	// RVA: 0x128b428 VA: 0x98143428
	public Boolean get_IsPendingRevive() { }
	// RVA: 0x128b430 VA: 0x98143430
	protected Void KAEBGJLNKPL(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128b438 VA: 0x98143438
	public Void SetIsPendingRevive(Boolean EPIDFMHNHFG) { }
	// RVA: 0x128b498 VA: 0x98143498
	public Boolean get_HaveRevived() { }
	// RVA: 0x128b4a0 VA: 0x981434a0
	public Void set_HaveRevived(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128b4a8 VA: 0x981434a8
	public Boolean get_IsInCutscene() { }
	// RVA: 0x128b4b0 VA: 0x981434b0
	public Void set_IsInCutscene(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128b4b8 VA: 0x981434b8
	public Boolean get_IsOnlyAllowLeftAndRightInput() { }
	// RVA: 0x128b4c0 VA: 0x981434c0
	public Void set_IsOnlyAllowLeftAndRightInput(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128b4c8 VA: 0x981434c8
	public Boolean get_InPhysicFreeze() { }
	// RVA: 0x126e0e4 VA: 0x981260e4
	public Void set_InPhysicFreeze(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128b4d0 VA: 0x981434d0
	public Boolean get_IsFixedUpdated() { }
	// RVA: 0x128b4d8 VA: 0x981434d8
	private Void BLAGGMBCIBE(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128b4e0 VA: 0x981434e0
	public Boolean get_IsLag() { }
	// RVA: 0x128b4e8 VA: 0x981434e8
	public Void set_IsLag(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128b4f0 VA: 0x981434f0
	public Boolean get_IsWeaponCombined() { }
	// RVA: 0x128b568 VA: 0x98143568
	public Boolean get_IsWeaponCombineLocked() { }
	// RVA: 0x127c078 VA: 0x98134078
	public Boolean get_IsPauseAnim() { }
	// RVA: 0x128b5e0 VA: 0x981435e0
	public Void set_IsPauseAnim(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128b5e8 VA: 0x981435e8
	public Boolean get_IsDriver() { }
	// RVA: 0x128b774 VA: 0x98143774
	public Boolean get_IsPassenger() { }
	// RVA: 0x128b900 VA: 0x98143900
	public Boolean get_IsExchangingSeat() { }
	// RVA: 0x128b908 VA: 0x98143908
	public Void set_IsExchangingSeat(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128b910 VA: 0x98143910
	public Vehicle VehicleIAmIn() { }
	// RVA: 0x128b968 VA: 0x98143968
	public Boolean UseBountyMotoVehicleFireController() { }
	// RVA: 0x128bb28 VA: 0x98143b28
	public Boolean IsPassengerInVehicleCanFire() { }
	// RVA: 0x128bd3c VA: 0x98143d3c
	public Boolean get_PlayerInBuildingArea() { }
	// RVA: 0x128bd94 VA: 0x98143d94
	public Void set_PlayerInBuildingArea(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128bdf4 VA: 0x98143df4
	public Boolean get_PlayerInMusicElement() { }
	// RVA: 0x128be4c VA: 0x98143e4c
	public Void set_PlayerInMusicElement(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128beac VA: 0x98143eac
	public Boolean get_VehicleChipEnable() { }
	// RVA: 0x128bf04 VA: 0x98143f04
	public Void set_VehicleChipEnable(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128bf64 VA: 0x98143f64
	public Boolean IsDriverInVehicleCanFire() { }
	// RVA: 0x128c178 VA: 0x98144178
	public LevelChair get_ChairIAmOn() { }
	// RVA: 0x127f5e8 VA: 0x981375e8
	public Boolean IsInCatapult() { }
	// RVA: 0x127f76c VA: 0x9813776c
	public Boolean IsInCannon() { }
	// RVA: 0x128c1d0 VA: 0x981441d0
	public Boolean CanUseCannon() { }
	// RVA: 0x128c230 VA: 0x98144230
	public Boolean IsUseSpaceShield() { }
	// RVA: 0x128c544 VA: 0x98144544
	public LevelCatapult GetCatapultIAmIn() { }
	// RVA: 0x128c59c VA: 0x9814459c
	public LevelCannon GetCannonIAmIn() { }
	// RVA: 0x128c5f4 VA: 0x981445f4
	public Int32 get_InVehiclePose() { }
	// RVA: 0x128c730 VA: 0x98144730
	public Boolean get_IsParachuting() { }
	// RVA: 0x1282868 VA: 0x9813a868
	public Transform get_SpineBoneTransform() { }
	// RVA: 0x1277bb4 VA: 0x9812fbb4
	public Transform get_RootTransform() { }
	// RVA: 0x128c7b8 VA: 0x981447b8
	public Transform get_BipTransform() { }
	// RVA: 0x128c96c VA: 0x9814496c
	public Transform get_BoneRootTransform() { }
	// RVA: 0x128cb20 VA: 0x98144b20
	public Transform get_ShoulderBoneTransform() { }
	// RVA: 0x128ccd4 VA: 0x98144cd4
	public Transform get_HipsBoneTransform() { }
	// RVA: 0x128ce88 VA: 0x98144e88
	public Transform get_HeadBoneTransform() { }
	// RVA: 0x128d03c VA: 0x9814503c
	public Transform get_BoneLeftWeapon() { }
	// RVA: 0x128d1f0 VA: 0x981451f0
	public Boolean get_IsSkyDiving() { }
	// RVA: 0x128d278 VA: 0x98145278
	public Boolean get_IsSlideOffFalling() { }
	// RVA: 0x128d3c4 VA: 0x981453c4
	public Boolean get_IsInSlideState() { }
	// RVA: 0x128d438 VA: 0x98145438
	public Boolean get_IsSlideRunning() { }
	// RVA: 0x128d4b8 VA: 0x981454b8
	public Boolean get_IsSlideFalling() { }
	// RVA: 0x128d538 VA: 0x98145538
	public Boolean get_IsOnFerrisWheel() { }
	// RVA: 0x128d5c0 VA: 0x981455c0
	public Boolean get_IsOnBoard() { }
	// RVA: 0x128d778 VA: 0x98145778
	public Boolean get_CanWholeBodyAttack() { }
	// RVA: 0x127d344 VA: 0x98135344
	public Boolean get_IsWalkingState() { }
	// RVA: 0x128d8d8 VA: 0x981458d8
	public Boolean get_IsWalking() { }
	// RVA: 0x128d968 VA: 0x98145968
	public Boolean get_IsPoseFallingHigh() { }
	// RVA: 0x12871ac VA: 0x9813f1ac
	public Boolean get_IsJumpPadFalling() { }
	// RVA: 0x128d9e0 VA: 0x981459e0
	public Boolean get_IsFallingHigh() { }
	// RVA: 0x128da58 VA: 0x98145a58
	public Boolean get_IsFallingLow() { }
	// RVA: 0x128dad0 VA: 0x98145ad0
	public Boolean get_IsFallingStanding() { }
	// RVA: 0x128db48 VA: 0x98145b48
	public Boolean get_IsSkyDashing() { }
	// RVA: 0x128dba0 VA: 0x98145ba0
	public Void set_IsSkyDashing(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128de6c VA: 0x98145e6c
	public Boolean get_IsDashing() { }
	// RVA: 0x128df60 VA: 0x98145f60
	public Boolean get_IsPartyDance() { }
	// RVA: 0x128dfd8 VA: 0x98145fd8
	public Boolean get_IsWearingCamouflage() { }
	// RVA: 0x128dfe0 VA: 0x98145fe0
	public Void set_IsWearingCamouflage(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128dfe8 VA: 0x98145fe8
	public Boolean get_IsInhalering() { }
	// RVA: 0x128e040 VA: 0x98146040
	public Boolean get_IsInCanUseInhalerState() { }
	// RVA: 0x128e150 VA: 0x98146150
	public override Boolean IsVisible() { }
	// RVA: 0x128e1b4 VA: 0x981461b4
	public Boolean IsVisibleByFlag(UInt32 EBOJJLIHHCM) { }
	// RVA: 0x128e238 VA: 0x98146238
	public Boolean IsFPPVisible() { }
	// RVA: 0x128e2c8 VA: 0x981462c8
	private UInt32 KMGNMBAPLGG() { }
	// RVA: 0x128e344 VA: 0x98146344
	public BitArrayBoolean CloneCurrentVisible() { }
	// RVA: 0x128e454 VA: 0x98146454
	public Boolean IsOnlyFlagHidePlayer(UInt32 EBOJJLIHHCM) { }
	// RVA: 0x128e51c VA: 0x9814651c
	public List`1 get_Skills() { }
	// RVA: 0x128e574 VA: 0x98146574
	public Boolean get_IsBotAgentDebug() { }
	// RVA: 0x128e5cc VA: 0x981465cc
	public Void set_IsBotAgentDebug(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128e62c VA: 0x9814662c
	public Boolean get_IsHangUpBotAgent() { }
	// RVA: 0x128e684 VA: 0x98146684
	public Void set_IsHangUpBotAgent(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128e6e4 VA: 0x981466e4
	public Boolean IsOnlineBotAgent() { }
	// RVA: 0x128e758 VA: 0x98146758
	public Void SetSniperFireCollider(CapsuleCollider NMKHBJBBDCK) { }
	// RVA: 0x128e7b8 VA: 0x981467b8
	public LevelLockBountyVehicle get_LockBountyVehicleIAmIn() { }
	// RVA: 0x128e810 VA: 0x98146810
	public LevelBountyBox get_BountyBoxIAmIn() { }
	// RVA: 0x128e868 VA: 0x98146868
	public LevelWeRunBox get_LevelWeRunBoxIAmIn() { }
	// RVA: 0x128e8c0 VA: 0x981468c0
	public LevelTriggerHumanTire get_CurrentHumanTireIAmIn() { }
	// RVA: 0x128e9b8 VA: 0x981469b8
	public PKLAGHHKOPO get_GameMissionManager() { }
	// RVA: 0x128ea10 VA: 0x98146a10
	public Boolean CanHumanTireJump() { }
	// RVA: 0x128f0bc VA: 0x981470bc
	public static GBJAEPHNFMD GetReasonFromRescueMethod(LFAAPFNDDAF PGLDJPCKBOG) { }
	// RVA: 0x128f13c VA: 0x9814713c
	public GBJAEPHNFMD get_PlayerRescureReason() { }
	// RVA: 0x128f194 VA: 0x98147194
	public Void set_PlayerRescureReason(GBJAEPHNFMD IMGNBGJDAHG) { }
	// RVA: 0x128f1f4 VA: 0x981471f4
	public override Boolean IsStreamerVisible() { }
	// RVA: 0x128f2ec VA: 0x981472ec
	public Boolean IsPartialVisible(UInt32 EBOJJLIHHCM) { }
	// RVA: 0x128f370 VA: 0x98147370
	public virtual BaseProfileInfo PlayerBaseProfile() { }
	// RVA: 0x128f3c8 VA: 0x981473c8
	public virtual Boolean IsWatching() { }
	// RVA: 0x128f420 VA: 0x98147420
	protected Void DAHCGFKLGLH(UInt32 IMGNBGJDAHG) { }
	// RVA: 0x128f428 VA: 0x98147428
	public UInt32 get_Role() { }
	// RVA: 0x128f430 VA: 0x98147430
	public Single get_TeleportDoorUseCDEndTime() { }
	// RVA: 0x128f488 VA: 0x98147488
	public Void set_TeleportDoorUseCDEndTime(Single IMGNBGJDAHG) { }
	// RVA: 0x128f4f4 VA: 0x981474f4
	public Single get_TeleportDoorUseCD() { }
	// RVA: 0x128f54c VA: 0x9814754c
	public Void set_TeleportDoorUseCD(Single IMGNBGJDAHG) { }
	// RVA: 0x128f5bc VA: 0x981475bc
	public Boolean get_CanUseDriftBottle() { }
	// RVA: 0x128f614 VA: 0x98147614
	public Void set_CanUseDriftBottle(Boolean IMGNBGJDAHG) { }
	// RVA: 0x128f674 VA: 0x98147674
	public Boolean get_SwitchToGrenadeBeforeFire() { }
	// RVA: 0x VA: 0x0
	public static Player CreatePlayer(Transform GOLANILPAJP, UInt64 HHMJNLLBELP, UInt64 OJHGCEHMNNI, IHAAMHPPLMG BIFFAIEPIND, Boolean JNLEJHIJFOP, Object JKBNDADENMG, Boolean DHENKAGPHFA) { }
	// RVA: 0x128f6cc VA: 0x981476cc
	public override Void InitEntityInfo() { }
	// RVA: 0x128fae4 VA: 0x98147ae4
	protected virtual Void HJEJIGIOOFD(String HJIHMAICLLD) { }
	// RVA: 0x128fe70 VA: 0x98147e70
	public virtual Void OnLogicEntityCreated(String HJIHMAICLLD) { }
	// RVA: 0x12900c0 VA: 0x981480c0
	public Void CreateCapsuleHuman() { }
	// RVA: 0x12902e0 VA: 0x981482e0
	public override Void ReUse() { }
	// RVA: 0x1296054 VA: 0x9814e054
	public override Boolean Recycle() { }
	// RVA: 0x1296284 VA: 0x9814e284
	public Void BeforeRecyle() { }
	// RVA: 0x1290440 VA: 0x98148440
	public Void ClearData() { }
	// RVA: 0x1298e30 VA: 0x98150e30
	public Void ClearDataExtra() { }
	// RVA: 0x1298e84 VA: 0x98150e84
	public override Void OnRecycle() { }
	// RVA: 0x129a87c VA: 0x9815287c
	protected override Void OnOnDestroy() { }
	// RVA: 0x129a910 VA: 0x98152910
	public override Void RecycleForInGameReload() { }
	// RVA: 0x129aff4 VA: 0x98152ff4
	protected IEnumerator MMFMMGEIKII() { }
	// RVA: 0x129b0c0 VA: 0x981530c0
	public virtual Void InitWhenAvatarReady() { }
	// RVA: 0x1288f34 VA: 0x98140f34
	public Boolean get_IsFemale() { }
	// RVA: 0x1298d14 VA: 0x98150d14
	public Void set_IsFemale(Boolean IMGNBGJDAHG) { }
	// RVA: 0x129b30c VA: 0x9815330c
	public Byte get_ChangedFourSymbolsClothType() { }
	// RVA: 0x1298d1c VA: 0x98150d1c
	public Void set_ChangedFourSymbolsClothType(Byte IMGNBGJDAHG) { }
	// RVA: 0x129b314 VA: 0x98153314
	public Void EnableCharactorController(UInt32 EBOJJLIHHCM, Boolean EDLIFKGBCMD) { }
	// RVA: 0x129b530 VA: 0x98153530
	public Void EnableSniperCollider(Boolean HPMMALDGFAB) { }
	// RVA: 0x129b680 VA: 0x98153680
	public Void EnableCharactorCollider(Boolean HPMMALDGFAB) { }
	// RVA: 0x129b8b0 VA: 0x981538b0
	private Void DFJCCHFPDAP(Int32 HHLONFLCJBL) { }
	// RVA: 0x1295f28 VA: 0x9814df28
	public Void EnableCharactorAnimator(Boolean HPMMALDGFAB) { }
	// RVA: 0x129b9ec VA: 0x981539ec
	public Void SetVisibleOnTrainingZoneChange(Boolean FICNJIMKAEF) { }
	// RVA: 0x129ba94 VA: 0x98153a94
	public Boolean CheckPendingTriggerEmpty() { }
	// RVA: 0x129bba0 VA: 0x98153ba0
	private Void AHCGNFAIFFL() { }
	// RVA: 0x129bc8c VA: 0x98153c8c
	private List`1 DBBFDAMBCFD(Boolean KDPOBDEMOIE) { }
	// RVA: 0x129b4b0 VA: 0x981534b0
	private Void HNEBFIMBKJL(Boolean ELOELMEPFCN) { }
	// RVA: 0x129c024 VA: 0x98154024
	public virtual Void SetVisible(UInt32 EBOJJLIHHCM, Boolean EDLIFKGBCMD) { }
	// RVA: 0x129f284 VA: 0x98157284
	public Boolean IsOnlyCabinWaitingHide() { }
	// RVA: 0x129f310 VA: 0x98157310
	public virtual Void ClientSetOnBoard() { }
	// RVA: 0x129f3a0 VA: 0x981573a0
	public Void SetVisibleOfCabinWaiting(Boolean FICNJIMKAEF) { }
	// RVA: 0x129f73c VA: 0x9815773c
	public Boolean GetVisibleOfCabinWaiting() { }
	// RVA: 0x129f7b8 VA: 0x981577b8
	public Void RefreshVehicleAnim() { }
	// RVA: 0x129f970 VA: 0x98157970
	protected virtual Void ENOKKOIOGGN() { }
	// RVA: 0x129f9c4 VA: 0x981579c4
	private Boolean POANGPHGLNN() { }
	// RVA: 0x1285734 VA: 0x9813d734
	public NPCNMJAGIKI GetInventoryManager() { }
	// RVA: 0x1284858 VA: 0x9813c858
	public GPBDEDFKJNA GetWeaponOnHand() { }
	// RVA: 0x129fb9c VA: 0x98157b9c
	public Void RefreshAllWeaponParams() { }
	// RVA: 0x129fc08 VA: 0x98157c08
	public Void RefreshContinueHitTime(Int32 CDAKGFIJNBE) { }
	// RVA: 0x129fdb4 VA: 0x98157db4
	public Void ClearWeaponContinueHitTime(Int32 CDAKGFIJNBE) { }
	// RVA: 0x1266c20 VA: 0x9811ec20
	public GPBDEDFKJNA GetActiveWeapon() { }
	// RVA: 0x12a00d4 VA: 0x981580d4
	protected override Void OnAwake() { }
	// RVA: 0x12a01d0 VA: 0x981581d0
	protected Void LLIPGNOGKPP() { }
	// RVA: 0x12a04dc VA: 0x981584dc
	private Void DLPABGGJLJC(Transform MCNPCMHJKGK, Transform FFDHFKIMFDG, Boolean MLHBOIEAGNK) { }
	// RVA: 0x12a0ca0 VA: 0x98158ca0
	public Void set_ParachuteResData(MANEMECPKIO IMGNBGJDAHG) { }
	// RVA: 0x12a0d00 VA: 0x98158d00
	public ResourceID get_ParachuteModleResId() { }
	// RVA: 0x12a0eb8 VA: 0x98158eb8
	public ResourceID get_ParachuteSkinResId() { }
	// RVA: 0x12a1014 VA: 0x98159014
	public ResourceID get_SkyboardModelResID() { }
	// RVA: 0x12a106c VA: 0x9815906c
	public Void set_SkyboardModelResID(ResourceID IMGNBGJDAHG) { }
	// RVA: 0x12a10cc VA: 0x981590cc
	public ResourceID get_FlightModelResID() { }
	// RVA: 0x12a1124 VA: 0x98159124
	public Void set_FlightModelResID(ResourceID IMGNBGJDAHG) { }
	// RVA: 0x129f634 VA: 0x98157634
	public Boolean HaveTeamFlight() { }
	// RVA: 0x12a1184 VA: 0x98159184
	public virtual Boolean HaveFlight() { }
	// RVA: 0x12a14d0 VA: 0x981594d0
	public SkyboardData get_CurSkyboardData() { }
	// RVA: 0x12a1528 VA: 0x98159528
	public Void set_CurSkyboardData(SkyboardData IMGNBGJDAHG) { }
	// RVA: 0x12a1588 VA: 0x98159588
	public FlightData get_CurFlightData() { }
	// RVA: 0x12a1470 VA: 0x98159470
	public Void set_CurFlightData(FlightData IMGNBGJDAHG) { }
	// RVA: 0x12a15e0 VA: 0x981595e0
	public FlightData get_CurTeamFlightData() { }
	// RVA: 0x12a1638 VA: 0x98159638
	public Void set_CurTeamFlightData(FlightData IMGNBGJDAHG) { }
	// RVA: 0x12a1698 VA: 0x98159698
	public PlayerAudioComponent get_PlayerAudio() { }
	// RVA: 0x12a17b4 VA: 0x981597b4
	public Parachute get_ParachuteMono() { }
	// RVA: 0x12a180c VA: 0x9815980c
	public Flight get_FlightMono() { }
	// RVA: 0x12a1864 VA: 0x98159864
	public Boolean IsTeamFlightParachutingNeedSound() { }
	// RVA: 0x129f16c VA: 0x9815716c
	public Boolean IsTeamFlightParachuting() { }
	// RVA: 0x12a19c8 VA: 0x981599c8
	protected Transform ADECBABGGBL() { }
	// RVA: 0x12a1c74 VA: 0x98159c74
	public Dictionary`2 get_HypeLevelToEffectRes() { }
	// RVA: 0x12a1f34 VA: 0x98159f34
	public virtual Void InitProperties(Object KGCOINAOBOH, Boolean HMLKNAHACCI) { }
	// RVA: 0x12a2bf8 VA: 0x9815abf8
	public Void SwitchReadyState(NILHJAFNEJL GLDLCOBLGNF) { }
	// RVA: 0x12a2c58 VA: 0x9815ac58
	public Boolean IsStateReady(NILHJAFNEJL GLDLCOBLGNF) { }
	// RVA: 0x12a29e4 VA: 0x9815a9e4
	protected Void HDMKLFBJANC() { }
	// RVA: 0x12a2ccc VA: 0x9815accc
	protected virtual Void DPLMGOJKKCM() { }
	// RVA: 0x12a6a3c VA: 0x9815ea3c
	public virtual Void UpdateShiledEffect() { }
	// RVA: 0x12a7150 VA: 0x9815f150
	public Void ChangeAnimationSystemFormWaitingToBattle() { }
	// RVA: 0x12a7398 VA: 0x9815f398
	public Void ShowShieldAttackedEffect(Player CNEIJLIGFEB) { }
	// RVA: 0x12a69d8 VA: 0x9815e9d8
	private Void CGIDCIBAEKE() { }
	// RVA: 0x12a6434 VA: 0x9815e434
	protected Void BGIELJBHEIB() { }
	// RVA: 0x12884e0 VA: 0x981404e0
	protected Void GAKOBGKCJKN() { }
	// RVA: 0x12a7524 VA: 0x9815f524
	public static Boolean IsLocalPlayer(UInt64 HHMJNLLBELP, IHAAMHPPLMG BIFFAIEPIND, Boolean JKEHHIKOPOI) { }
	// RVA: 0x1275c04 VA: 0x9812dc04
	public Boolean IsLocalPlayer() { }
	// RVA: 0x12a77c4 VA: 0x9815f7c4
	public virtual Boolean IsLocalTeammate() { }
	// RVA: 0x12a7a18 VA: 0x9815fa18
	public Boolean IsInLocalPlayerServiceGroup() { }
	// RVA: 0x12a7b8c VA: 0x9815fb8c
	public Boolean ShowWeaponSkin() { }
	// RVA: 0x12a7de8 VA: 0x9815fde8
	public Boolean ShowSkinInternal(SkinType PMGBACFJIHO) { }
	// RVA: 0x12a7cbc VA: 0x9815fcbc
	public Boolean ShowSkin(SkinType PMGBACFJIHO) { }
	// RVA: 0x12a8488 VA: 0x98160488
	public Boolean ShowSkinInUgc() { }
	// RVA: 0x12a84e0 VA: 0x981604e0
	public static Boolean ShowSkinForQualityAndMemory() { }
	// RVA: 0x12a8698 VA: 0x98160698
	public Boolean ShowFistWeapon() { }
	// RVA: 0x12a8814 VA: 0x98160814
	public Boolean ShowHandWeaponEffect() { }
	// RVA: 0x12a8a50 VA: 0x98160a50
	public Boolean ShowHandWeaponFireEffect() { }
	// RVA: 0x12a8c8c VA: 0x98160c8c
	public Boolean ShowHandWeaponGunTraceEffect() { }
	// RVA: 0x12a8ec8 VA: 0x98160ec8
	public Boolean ShowHandWeaponReloadEffect() { }
	// RVA: 0x12a9104 VA: 0x98161104
	public virtual UInt32 GetWeaponRelatedFinalShotID(UInt32 HEONOMOEOLN) { }
	// RVA: 0x12a9168 VA: 0x98161168
	public virtual UInt32 GetWeaponRelatedPropertySkinID(UInt32 HEONOMOEOLN) { }
	// RVA: 0x12a91cc VA: 0x981611cc
	public Boolean IsWeaponSkinABStatusA(UInt32 EKOKLNAIEME) { }
	// RVA: 0x12a92e8 VA: 0x981612e8
	public Boolean NeedWeaponSkinFireSound(UInt32 EKOKLNAIEME) { }
	// RVA: 0x12a9698 VA: 0x98161698
	public Boolean ShowBackWeaponEffectByQualityAndTeammate() { }
	// RVA: 0x12a98d4 VA: 0x981618d4
	public Boolean ShowClothEffect() { }
	// RVA: 0x12a9acc VA: 0x98161acc
	public static Boolean UseHighQualityAvatar(UInt64 HHMJNLLBELP, IHAAMHPPLMG BIFFAIEPIND, UInt64 OJHGCEHMNNI) { }
	// RVA: 0x12a9ff0 VA: 0x98161ff0
	public Boolean UseHighQualityAvatar() { }
	// RVA: 0x1276380 VA: 0x9812e380
	public Boolean IsLocalObservered() { }
	// RVA: 0x12aa0fc VA: 0x981620fc
	public Boolean IsLocalTryingObservered() { }
	// RVA: 0x12aa31c VA: 0x9816231c
	public virtual Void SetAI(Boolean KENDCFNPDCE) { }
	// RVA: 0x12aa570 VA: 0x98162570
	public Boolean IsUserControlChanged() { }
	// RVA: 0x12aa5f4 VA: 0x981625f4
	public GameObject GetGameObject() { }
	// RVA: 0x12aa658 VA: 0x98162658
	public Vector3 GetTargetDirection() { }
	// RVA: 0x12aa6dc VA: 0x981626dc
	public Vector3 GetFallingDirection() { }
	// RVA: 0x12aa790 VA: 0x98162790
	public Vector3 GetVelocity() { }
	// RVA: 0x12aa814 VA: 0x98162814
	public DFKKGHCFGNM GetPhysXState() { }
	// RVA: 0x12aa894 VA: 0x98162894
	public FBCAHNCLMDC GetPhysXPose() { }
	// RVA: 0x12aa90c VA: 0x9816290c
	public Boolean IsCrouching() { }
	// RVA: 0x12aa984 VA: 0x98162984
	private Void CPNJJHHPLKJ() { }
	// RVA: 0x12ab010 VA: 0x98163010
	private Void MIEABLNHMCO() { }
	// RVA: 0x12ab3b4 VA: 0x981633b4
	public virtual Void Dead(Int32 HEONOMOEOLN, UInt32 EKOKLNAIEME, IHAAMHPPLMG HLJDHPGGODB, Boolean KCHNLMEEHOP, Boolean EPIDFMHNHFG, Boolean HIGJDJBFGIG, Boolean AEIPFMCDCOG) { }
	// RVA: 0x12af460 VA: 0x98167460
	private Void BIDPFPFOGOF(IHAAMHPPLMG LJAINBNBANO, Boolean KCHNLMEEHOP, Boolean PJEMMDLKPBF, Boolean BKCIKLECCMI, UInt32 HEONOMOEOLN) { }
	// RVA: 0x12b13cc VA: 0x981693cc
	public Void HideLastKillModel(String AKAJHMHFKMG) { }
	// RVA: 0x12b15e8 VA: 0x981695e8
	private Void JJLLEAMKDPI() { }
	// RVA: 0x12b1730 VA: 0x98169730
	public virtual Void UpdateController(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12b17e4 VA: 0x981697e4
	public Void UpdateRightAxisAndDoRotation(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12b1894 VA: 0x98169894
	public Void UpdateBrightness() { }
	// RVA: 0x12b1d10 VA: 0x98169d10
	public override Void OnUpdate(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12b2d2c VA: 0x9816ad2c
	private Void OKDHDJNIJID(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12b2f10 VA: 0x9816af10
	private Void ACAGEGKDPDD() { }
	// RVA: 0x12b286c VA: 0x9816a86c
	private Void BGLBGABDMFI(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12b1224 VA: 0x98169224
	private Void ELJKMOEOJKN() { }
	// RVA: 0x12b35e4 VA: 0x9816b5e4
	protected Void BJNNIBHHCJB() { }
	// RVA: 0x12b3928 VA: 0x9816b928
	public virtual Void OnPlayerBeTouch() { }
	// RVA: 0x12b3cf0 VA: 0x9816bcf0
	public Void CapsuleHumanTriggerEnter(Collider KODGAANKJBG) { }
	// RVA: 0x12b40d8 VA: 0x9816c0d8
	private Void BJBMCOPPGKP() { }
	// RVA: 0x12b4318 VA: 0x9816c318
	public Void CapsuleHumanTriggerStay(Collider KODGAANKJBG) { }
	// RVA: 0x12b4768 VA: 0x9816c768
	public Void CapsuleHumanTriggerExit(Collider KODGAANKJBG) { }
	// RVA: 0x12b4b78 VA: 0x9816cb78
	private Boolean EEOLAPHGEMP(Collider KODGAANKJBG) { }
	// RVA: 0x12b4d4c VA: 0x9816cd4c
	private Boolean NFPAOOBBJNB(ref EntityInfo GJMOEPKGCKO) { }
	// RVA: 0x12b4ddc VA: 0x9816cddc
	private Boolean BJMENKFFBJB(ref EntityInfo GJMOEPKGCKO) { }
	// RVA: 0x12b4e78 VA: 0x9816ce78
	public virtual Void OnTriggerEnter(Collider KODGAANKJBG) { }
	// RVA: 0x12bd5b8 VA: 0x981755b8
	private Void ICLGAAFEGID(Boolean JDLGNOJHFEG) { }
	// RVA: 0x12bc778 VA: 0x98174778
	private Void ICLGAAFEGID(Boolean JDLGNOJHFEG, EntityInfo GJMOEPKGCKO, Vector3 LLOAGEMLBPF) { }
	// RVA: 0x12c2cf8 VA: 0x9817acf8
	private Boolean GMAIFHDIKPG(List`1 IOEOEDBDJPL, ref EntityInfo GJMOEPKGCKO) { }
	// RVA: 0x12c2f10 VA: 0x9817af10
	private Void OnTriggerStay(Collider KODGAANKJBG) { }
	// RVA: 0x12c33cc VA: 0x9817b3cc
	public Void ForceExitMusicShooingZone() { }
	// RVA: 0x12c3a28 VA: 0x9817ba28
	public virtual Void OnTriggerExit(Collider KODGAANKJBG) { }
	// RVA: 0x12cc928 VA: 0x98184928
	public Void UpdateTriggerBtns() { }
	// RVA: 0x12c304c VA: 0x9817b04c
	private Void KOMAGPGFMMM() { }
	// RVA: 0x12cd864 VA: 0x98185864
	public Boolean InSlider() { }
	// RVA: 0x12bb838 VA: 0x98173838
	protected Void EOLLAHNPEHI(Collider KODGAANKJBG) { }
	// RVA: 0x12caff4 VA: 0x98182ff4
	protected Void HDIBBCNFHPF(Collider KODGAANKJBG) { }
	// RVA: 0x12cda90 VA: 0x98185a90
	public JNGKMJDINHC get_CurrrentTrainingMiniGameTriggerType() { }
	// RVA: 0x12cdae8 VA: 0x98185ae8
	public Void set_CurrrentTrainingMiniGameTriggerType(JNGKMJDINHC IMGNBGJDAHG) { }
	// RVA: 0x12cdb48 VA: 0x98185b48
	public MALGAHKKNNN get_CurrentServerMiniGameType() { }
	// RVA: 0x12cdba0 VA: 0x98185ba0
	public Void set_CurrentServerMiniGameType(MALGAHKKNNN IMGNBGJDAHG) { }
	// RVA: 0x12cd970 VA: 0x98185970
	private Void ACODEINPIOJ() { }
	// RVA: 0x12cc76c VA: 0x9818476c
	private Void JMKFHLFIBOA(Boolean EDALGMHFMHP) { }
	// RVA: 0x12ccfdc VA: 0x98184fdc
	private Void NDDJABFPNKP(Boolean EDALGMHFMHP) { }
	// RVA: 0x12cdc00 VA: 0x98185c00
	protected Void FBDEGHILJMA(EntityInfo LKKPEFCCPPP, Vector3 LLOAGEMLBPF) { }
	// RVA: 0x12cdf98 VA: 0x98185f98
	protected Void BPFBHCIPOAE(EntityInfo LKKPEFCCPPP, Vector3 LLOAGEMLBPF) { }
	// RVA: 0x12bd7d0 VA: 0x981757d0
	protected Void JPKAJBBDHIN(EntityInfo LKKPEFCCPPP, Vector3 LLOAGEMLBPF) { }
	// RVA: 0x12be530 VA: 0x98176530
	protected Void JICIFKPNHFC(EntityInfo LKKPEFCCPPP, Vector3 LLOAGEMLBPF) { }
	// RVA: 0x12d0584 VA: 0x98188584
	public virtual Boolean CanUseAmmoBox() { }
	// RVA: 0x12d0744 VA: 0x98188744
	public Boolean CanJoinPartyGame() { }
	// RVA: 0x12ce728 VA: 0x98186728
	private Void HFMCDFEIEOF() { }
	// RVA: 0x12ce600 VA: 0x98186600
	private Void LIBMAPKFDLG() { }
	// RVA: 0x12ce850 VA: 0x98186850
	private Void KCBHFOJMFKH() { }
	// RVA: 0x12cead4 VA: 0x98186ad4
	private Void IJCGLIALPHN() { }
	// RVA: 0x12cebfc VA: 0x98186bfc
	private Void DFIICNPDJAJ() { }
	// RVA: 0x12ced24 VA: 0x98186d24
	private Void NKOFCOBAOHP() { }
	// RVA: 0x12cee4c VA: 0x98186e4c
	private Void IALMOEBOEDO() { }
	// RVA: 0x12d0a1c VA: 0x98188a1c
	public Boolean IsInHayric() { }
	// RVA: 0x12cef74 VA: 0x98186f74
	private Void EJMONKEHBFF() { }
	// RVA: 0x12cbe44 VA: 0x98183e44
	private Void DJKPCNMOHAM() { }
	// RVA: 0x12cf020 VA: 0x98187020
	private Void HOCHIBABHLB(OJCOOJEIJPD OPJKJHBKLGN) { }
	// RVA: 0x12d0254 VA: 0x98188254
	private Void GHOEMLLEFCB() { }
	// RVA: 0x12ce37c VA: 0x9818637c
	public Void EnterActionTrigger(EHudActionType PMGBACFJIHO) { }
	// RVA: 0x12cc174 VA: 0x98184174
	public Void ExitActionTrigger() { }
	// RVA: 0x12d0dc4 VA: 0x98188dc4
	private Void ACMIIEDBPGD() { }
	// RVA: 0x12d2528 VA: 0x9818a528
	private Void LAAMIIEHLBC() { }
	// RVA: 0x12d2688 VA: 0x9818a688
	private Void GBFHAIDNCNL(Boolean IOOECBJGKDC) { }
	// RVA: 0x12ce598 VA: 0x98186598
	public Void ExitVehicleTrigger() { }
	// RVA: 0x12cbab4 VA: 0x98183ab4
	private Void MAHFFCLOGDP(OFJHNKMJNGA CLJGFIOLMAK, UInt32 IEPFELEIMFE) { }
	// RVA: 0x12ce538 VA: 0x98186538
	private Void IGIOFJHFNGC() { }
	// RVA: 0x12d2e88 VA: 0x9818ae88
	public EntityInfo GetLastenteredVehicleInfo() { }
	// RVA: 0x12cd3f8 VA: 0x981853f8
	private Void PGLGELCMJCH() { }
	// RVA: 0x12d2f00 VA: 0x9818af00
	public Void ClearLastEnterVehicleInfoWhenVehicleExplode(EntityInfo AJHKHMKMAEB) { }
	// RVA: 0x12d2fdc VA: 0x9818afdc
	public virtual Boolean IsInTrigger() { }
	// RVA: 0x12bd54c VA: 0x9817554c
	public Boolean IsInPickUpTrigger() { }
	// RVA: 0x12d3114 VA: 0x9818b114
	public Boolean IsInEntityTriggerIncludingPending(UInt32 EAIEPINNMFK, UInt32 GNJLBPLDLHG, UInt32 BMNJANHBPIG) { }
	// RVA: 0x12d3320 VA: 0x9818b320
	public Boolean IsInTriggerIncludingPendingTrigger(EntityInfo GJMOEPKGCKO) { }
	// RVA: 0x12bd37c VA: 0x9817537c
	private Boolean LCPBPLGBJED(EntityInfo GJMOEPKGCKO) { }
	// RVA: 0x12d36cc VA: 0x9818b6cc
	public Void StopUsingItemOnHand() { }
	// RVA: 0x1275d40 VA: 0x9812dd40
	public AAHMJHHPECM GetItemOnHand() { }
	// RVA: 0x12d3770 VA: 0x9818b770
	public Boolean HasThrowingKnifeBROnHand() { }
	// RVA: 0x12d38d4 VA: 0x9818b8d4
	public Int32 GetThrowingKnifeLegMountCount() { }
	// RVA: 0x12d3a3c VA: 0x9818ba3c
	public AAHMJHHPECM GetRealItemOnHand() { }
	// RVA: 0x12d3ab0 VA: 0x9818bab0
	public UserControlHandler GetUserControlHandler() { }
	// RVA: 0x12d3b08 VA: 0x9818bb08
	public override Void OnFixedUpdate(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12d3bac VA: 0x9818bbac
	public Boolean IsGrounded() { }
	// RVA: 0x12d3c24 VA: 0x9818bc24
	public virtual Void UpdateAI(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12d3e4c VA: 0x9818be4c
	public virtual Void UpdateBehavior(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12d5208 VA: 0x9818d208
	public virtual Void UpdateBehaviorOutOfControl(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12d535c VA: 0x9818d35c
	protected virtual Void FNJFNAHEIOJ() { }
	// RVA: 0x12d5874 VA: 0x9818d874
	protected virtual Void LNMJFMKPKEO() { }
	// RVA: 0x12d61b0 VA: 0x9818e1b0
	protected Void JLOJPGBJBLF(Boolean FJMIBOFFNNG) { }
	// RVA: 0x12d6400 VA: 0x9818e400
	public Void ForceStopEmotionForCabinWaiting() { }
	// RVA: 0x12d62d4 VA: 0x9818e2d4
	private Void BOKHKNADKOL() { }
	// RVA: 0x12d6578 VA: 0x9818e578
	protected Void LMICHEEPCGD() { }
	// RVA: 0x12d6848 VA: 0x9818e848
	public virtual Void UpdateKinematics(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x127b248 VA: 0x98133248
	private Void NOMOLMDIOFA(Boolean AIIILDFFNHL, Single OMAFEKBHOAA) { }
	// RVA: 0x12780e8 VA: 0x981300e8
	protected Void NHHOFJDBEKD(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x127cfc8 VA: 0x98134fc8
	public Boolean IsMoving() { }
	// RVA: 0x127cf50 VA: 0x98134f50
	private Void KHHKLDLHHFG(Boolean DCCDHMCDHJH) { }
	// RVA: 0x12e3ff8 VA: 0x9819bff8
	protected Boolean GKAPGHDOMJJ(Vector3 FAPNMKAAPFI) { }
	// RVA: 0x12e45ec VA: 0x9819c5ec
	private Void LateUpdate() { }
	// RVA: 0x12e557c VA: 0x9819d57c
	private Void EGDEABJLICF() { }
	// RVA: 0x12e4908 VA: 0x9819c908
	private Void FJMLFDKINML() { }
	// RVA: 0x12e7bb0 VA: 0x9819fbb0
	public Boolean get_SyncSkillIncreaseShootAndMoveSpeed() { }
	// RVA: 0x12e7c08 VA: 0x9819fc08
	public Void set_SyncSkillIncreaseShootAndMoveSpeed(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12e7a14 VA: 0x9819fa14
	private Void BGDIEBAIHCL(Boolean OGAFCJBHMFK) { }
	// RVA: 0x12e6f5c VA: 0x9819ef5c
	protected Boolean KAFDBJLIHDF() { }
	// RVA: 0x12e7c68 VA: 0x9819fc68
	public Boolean LastInFrustum() { }
	// RVA: 0x12e706c VA: 0x9819f06c
	protected Void KNHEOJCMMOJ() { }
	// RVA: 0x12e6078 VA: 0x9819e078
	protected Void BBNBBPHAGCO() { }
	// RVA: 0x12e7cc0 VA: 0x9819fcc0
	protected Boolean KBBJOOFNDJI(Transform BMLDFEHGDCE, Boolean OECNEAAPILJ, Single EBJNFHAODMP, Single LFKIGLIEAOF) { }
	// RVA: 0x12e8310 VA: 0x981a0310
	protected Void EPHLKDIEHDB(Transform BMLDFEHGDCE, Single EBJNFHAODMP, Single LFKIGLIEAOF, Boolean LOONMIGPEIE) { }
	// RVA: 0x12e8878 VA: 0x981a0878
	protected virtual Boolean ANHDPJADLOH() { }
	// RVA: 0x12e88d0 VA: 0x981a08d0
	public virtual Boolean InKnockRevivedSafeTime() { }
	// RVA: 0x12e8928 VA: 0x981a0928
	protected virtual Void GBIJDLNLONP() { }
	// RVA: 0x12e8ae4 VA: 0x981a0ae4
	private Void LKNAJCCBIBK(Single OMAFEKBHOAA, out Boolean DCCFMIHLEKA, out Single CGPEFIBAFAB) { }
	// RVA: 0x12e8ec4 VA: 0x981a0ec4
	public virtual Void PostUpdate(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12ecd48 VA: 0x981a4d48
	protected virtual Void INDOOFOELNJ() { }
	// RVA: 0x12ecd9c VA: 0x981a4d9c
	public Void ForceUpdateRotation() { }
	// RVA: 0x1278444 VA: 0x98130444
	private Void OJOHLBJEIJO(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12ee7f8 VA: 0x981a67f8
	private Single FCMOKEPOAID(Vector3 KDLAFFALFIN, Single EHHDNGCIBNF) { }
	// RVA: 0x12eeca8 VA: 0x981a6ca8
	private Single POKKAHADOBD(Vector3 KDLAFFALFIN, Single EHHDNGCIBNF) { }
	// RVA: 0x12ef684 VA: 0x981a7684
	public virtual Void OnLandFinsish() { }
	// RVA: 0x12f0234 VA: 0x981a8234
	public Boolean IsMeleeFiring() { }
	// RVA: 0x12f0310 VA: 0x981a8310
	public virtual Void OnFaithFallingLandFinsish() { }
	// RVA: 0x12f03b4 VA: 0x981a83b4
	public Void SetHayrickOrigin(LevelHayrickOrigin DENIDDKOHJM) { }
	// RVA: 0x12f0414 VA: 0x981a8414
	public Boolean IsTargetFriend(OPILIBBOEAC FFDHFKIMFDG) { }
	// RVA: 0x12f04a8 VA: 0x981a84a8
	protected virtual Boolean PHPKGJIBCIK(OPILIBBOEAC FFDHFKIMFDG) { }
	// RVA: 0x12d23e8 VA: 0x9818a3e8
	public Quaternion GetAimRotation() { }
	// RVA: 0x12f0ef0 VA: 0x981a8ef0
	public Quaternion GetAuxAimRotation() { }
	// RVA: 0x12f0f6c VA: 0x981a8f6c
	public Void ResetAuxAimRotation() { }
	// RVA: 0x12f0fd4 VA: 0x981a8fd4
	public virtual Void PauseAnimator() { }
	// RVA: 0x12f10cc VA: 0x981a90cc
	public MADMMIICBNN get_LastAimingInfoFromWeapon() { }
	// RVA: 0x12f1124 VA: 0x981a9124
	private MADMMIICBNN FCDMDFGPNBM() { }
	// RVA: 0x12f117c VA: 0x981a917c
	public OPILIBBOEAC get_LastAimingTargetFromWeapon() { }
	// RVA: 0x1298d24 VA: 0x98150d24
	public Void set_LastAimingTargetFromWeapon(OPILIBBOEAC IMGNBGJDAHG) { }
	// RVA: 0x12f1184 VA: 0x981a9184
	public Boolean HasHeuristicTarget() { }
	// RVA: 0x12f1424 VA: 0x981a9424
	public Boolean HeuristicTargetIsFriend() { }
	// RVA: 0x12f16d4 VA: 0x981a96d4
	public OPILIBBOEAC GetHeuristicTarget() { }
	// RVA: 0x12f1884 VA: 0x981a9884
	public Single GetHeuristicTargetInfoScore() { }
	// RVA: 0x12f1a34 VA: 0x981a9a34
	public Vector3 GetWeaponTraceStartPos() { }
	// RVA: 0x12f1c88 VA: 0x981a9c88
	public Vector3 get_AimStartPostion() { }
	// RVA: 0x12f2110 VA: 0x981aa110
	public Vector3 get_VMEAimStartPostion() { }
	// RVA: 0x12f223c VA: 0x981aa23c
	private static Boolean IMINBKBIJHI(GNBLNCJCKIN DBEFECLOBEJ, GNBLNCJCKIN CCFNDMDKKMH) { }
	// RVA: 0x12f22b0 VA: 0x981aa2b0
	public virtual Void UpdateAiming(Single OPKNJGBDOBB, Single OMAFEKBHOAA, Boolean PKPEMNPJDHA) { }
	// RVA: 0x12f500c VA: 0x981ad00c
	private Boolean NNKNOHCEKMP() { }
	// RVA: 0x12f5154 VA: 0x981ad154
	public Boolean IsAmimingSelfGunShield(Collider HFBDJJDICLN) { }
	// RVA: 0x12f5474 VA: 0x981ad474
	public Boolean IsAimmingViewBlockTransparent(Collider HFBDJJDICLN) { }
	// RVA: 0x12f5610 VA: 0x981ad610
	public Boolean IsAmimingSelfVehicleShield(Collider HFBDJJDICLN) { }
	// RVA: 0x12f589c VA: 0x981ad89c
	public Boolean IsAmimingLevelSpaceShield(Collider HFBDJJDICLN) { }
	// RVA: 0x12f59a0 VA: 0x981ad9a0
	public override Void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, MKFEKBKJCKE OPINPCANMDE, List`1 NBKBEBFNDBE, UInt32 GGIDKOBOJBB) { }
	// RVA: 0x12f5bf0 VA: 0x981adbf0
	public virtual Int32 TakeDamage(Int32 KOCMLPLOILD, IHAAMHPPLMG HLJDHPGGODB, ELMGJKHIIAA JIIJIFKKCCB, Int32 BOEIBGAABDL, Vector3 NJMFBKNHMBP, Vector3 DOBOBMFMKBJ, List`1 NBKBEBFNDBE, MKFEKBKJCKE OPINPCANMDE, UInt32 GGIDKOBOJBB) { }
	// RVA: 0x12f5d70 VA: 0x981add70
	protected Int32 PJHONHFGDAD(Int32 KOCMLPLOILD, IHAAMHPPLMG HLJDHPGGODB, out Int32 BGCCDLIOJLL, ELMGJKHIIAA JIIJIFKKCCB, Int32 BOEIBGAABDL, Vector3 NJMFBKNHMBP, Vector3 DOBOBMFMKBJ, List`1 NBKBEBFNDBE, MKFEKBKJCKE OPINPCANMDE, UInt32 GGIDKOBOJBB) { }
	// RVA: 0x12f9190 VA: 0x981b1190
	private Void NHHPDLLGBPI(Player JGAKJHAPHOA, IHAAMHPPLMG HLJDHPGGODB) { }
	// RVA: 0x12f93e0 VA: 0x981b13e0
	private Void CBBIJLJKKKK(Boolean IIBLMCDPLDA) { }
	// RVA: 0x12f999c VA: 0x981b199c
	public override Void TakeHealing(FFLDLNDNFCO CMDMCECHKDK, List`1 NBKBEBFNDBE) { }
	// RVA: 0x12fa3d4 VA: 0x981b23d4
	private static Boolean DHPPANLEAHO(Byte GLDLCOBLGNF) { }
	// RVA: 0x129e8a4 VA: 0x981568a4
	public Void ShowFireInfoInMap(Byte GLDLCOBLGNF) { }
	// RVA: 0x12f8ce0 VA: 0x981b0ce0
	public Void PlaySpeedRoyalBGM(Int32 BOEIBGAABDL) { }
	// RVA: 0x12fa5b4 VA: 0x981b25b4
	public virtual Void PlayFireEffect(GPBDEDFKJNA LPGPKFMGCBG) { }
	// RVA: 0x12fa7e4 VA: 0x981b27e4
	public virtual Void PlayMeleeEnergyChargeAnimation(GPBDEDFKJNA LPGPKFMGCBG) { }
	// RVA: 0x12faa40 VA: 0x981b2a40
	public Void OnMeleeEnergyAttackRateChange(Single BOGINBBGDIB) { }
	// RVA: 0x12b052c VA: 0x9816852c
	public Void ClearMeleeEnergyEffect() { }
	// RVA: 0x12fab34 VA: 0x981b2b34
	public virtual Void PlayMeleeEnergyEndAnimation() { }
	// RVA: 0x12fabd4 VA: 0x981b2bd4
	public virtual Void PlayMeleeEnergyAttackAnimation(GPBDEDFKJNA LPGPKFMGCBG) { }
	// RVA: 0x12fac7c VA: 0x981b2c7c
	public virtual Void PlayCureAnimation(Boolean FJNDHBCJPEJ) { }
	// RVA: 0x12fad5c VA: 0x981b2d5c
	private Void CGNEPMPHNLN(Boolean FJNDHBCJPEJ) { }
	// RVA: 0x12fb014 VA: 0x981b3014
	public virtual Void PlayBombAnimation(Boolean FJNDHBCJPEJ, Boolean JDKCEEGNPLG, Single GPOHMJDBNID) { }
	// RVA: 0x12fbd88 VA: 0x981b3d88
	public Void PlayADSTeleportAnimation() { }
	// RVA: 0x12fc0c0 VA: 0x981b40c0
	public Void ShowADSPortalEffect(Boolean ODOEHEHNJOG, MOIJLENBKNL DEEGGKFDOKA) { }
	// RVA: 0x12fca2c VA: 0x981b4a2c
	public Void ShowADSBodyEffect(Boolean ODOEHEHNJOG) { }
	// RVA: 0x12fcc7c VA: 0x981b4c7c
	public Void ShowADSWinBuffEffect(Boolean ODOEHEHNJOG) { }
	// RVA: 0x12fc404 VA: 0x981b4404
	private GameObject PLIKAJPOCCN(MOIJLENBKNL DEEGGKFDOKA) { }
	// RVA: 0x12fcff8 VA: 0x981b4ff8
	public Void PlayUsePacemakerAnimation(Boolean FJNDHBCJPEJ, UInt32 CJDMCMOODAH) { }
	// RVA: 0x12fd560 VA: 0x981b5560
	public Void CreatePacemakerInAnim() { }
	// RVA: 0x12b0488 VA: 0x98168488
	public Void ClearPacemaker() { }
	// RVA: 0x12d56f4 VA: 0x9818d6f4
	private Void NBFFHHAOINL() { }
	// RVA: 0x12fd7b0 VA: 0x981b57b0
	public Void PlaySelfRescureGetUpEffect() { }
	// RVA: 0x12b0794 VA: 0x98168794
	protected Void CPLJNGNFOJK() { }
	// RVA: 0x12fd9e8 VA: 0x981b59e8
	protected Void JALPBAJJFKM(LFAAPFNDDAF PGLDJPCKBOG, Single NBFEKBJGBNL) { }
	// RVA: 0x12fdc20 VA: 0x981b5c20
	public Void SyncStopBeingRescued() { }
	// RVA: 0x12fdcdc VA: 0x981b5cdc
	private Void ONADONOJCLA() { }
	// RVA: 0x12fdee4 VA: 0x981b5ee4
	private Void OPJHMFBIGOE() { }
	// RVA: 0x12fdf74 VA: 0x981b5f74
	public Void PlayShootMusicTarget() { }
	// RVA: 0x12b0344 VA: 0x98168344
	public Void ResetPlayerRescureReason() { }
	// RVA: 0x12fdfc8 VA: 0x981b5fc8
	public virtual Void PlayPreparationAnimation(Boolean FJNDHBCJPEJ, EPreparationTimerType PMGBACFJIHO) { }
	// RVA: 0x12fe180 VA: 0x981b6180
	public Void PlayRMDEatFoodAnimation(Boolean FJNDHBCJPEJ, Int32 DIAHPMFBHKA) { }
	// RVA: 0x12d60dc VA: 0x9818e0dc
	public Boolean IsRMDEatingFood() { }
	// RVA: 0x12fe480 VA: 0x981b6480
	public Void ShowFoodAndSpoon(Boolean FJNDHBCJPEJ) { }
	// RVA: 0x12fe844 VA: 0x981b6844
	private Void EJKFDMKGGAE(UInt32 LLONJJJJLFL, ResourceID FCMOICILFBP, GameObject GAHBKGJAHPJ) { }
	// RVA: 0x12fec74 VA: 0x981b6c74
	public Void PlayPEDAnimation(Boolean FJNDHBCJPEJ) { }
	// RVA: 0x12ff0f8 VA: 0x981b70f8
	public virtual Void StartFiring(GPBDEDFKJNA LPGPKFMGCBG) { }
	// RVA: 0x12ff338 VA: 0x981b7338
	protected Void JJCEMPIMLDG() { }
	// RVA: 0x12ff38c VA: 0x981b738c
	public virtual Void StartWholeBodyFiring(GPBDEDFKJNA LPGPKFMGCBG) { }
	// RVA: 0x12ff5cc VA: 0x981b75cc
	public virtual Void StartWarmUp(GPBDEDFKJNA LPGPKFMGCBG) { }
	// RVA: 0x12ff628 VA: 0x981b7628
	public virtual Void StopFire(GPBDEDFKJNA LPGPKFMGCBG) { }
	// RVA: 0x12ffa68 VA: 0x981b7a68
	public Void OnReloadingNoBullet(GPBDEDFKJNA LPGPKFMGCBG) { }
	// RVA: 0x12ffac4 VA: 0x981b7ac4
	public virtual Void StopCharge(GPBDEDFKJNA LPGPKFMGCBG) { }
	// RVA: 0x12ffb20 VA: 0x981b7b20
	public List`1 GetOccupationContinueHitInfo() { }
	// RVA: 0x12ffe14 VA: 0x981b7e14
	public virtual Void OnExpansionAblityEnd() { }
	// RVA: 0x12ffeb0 VA: 0x981b7eb0
	public virtual Boolean GetSightingState() { }
	// RVA: 0x12fffc4 VA: 0x981b7fc4
	public PFMPPELJECF GetWeaponSightingAttachmentData() { }
	// RVA: 0x130003c VA: 0x981b803c
	public virtual Boolean IsSightingUIAvailable() { }
	// RVA: 0x1300170 VA: 0x981b8170
	public Void OnAnimationVisibilityChanged(Int32 POCENLDINHC) { }
	// RVA: 0x1300210 VA: 0x981b8210
	public Void OnAnimEvent(OHHHJLJHCKI HGMBMICDALC, Object[] POCENLDINHC) { }
	// RVA: 0x1300e8c VA: 0x981b8e8c
	public Void UpdateWeaponActiveOnProptertyVisiblityChange(Boolean CDPFEPBKMEI) { }
	// RVA: 0x1301418 VA: 0x981b9418
	private Void KFGHAJEDHLG(Boolean PLGKHKHBADL) { }
	// RVA: 0x1301044 VA: 0x981b9044
	private Void OPIIKCKHDNB(Boolean CCBOHNJELDL) { }
	// RVA: 0x1301a10 VA: 0x981b9a10
	public Void OnSightingUIStateChange(Boolean HNFJGOBEMKM, Single HCIFNBGLHIF) { }
	// RVA: 0x1301e24 VA: 0x981b9e24
	public virtual Void SwapWeapon(Int32 POFFNNMOOBM, Boolean GDKLMFLNNGM, List`1 HACDOKBPCHJ) { }
	// RVA: 0x130264c VA: 0x981ba64c
	private Boolean IGHCCPAFKBH(BMGBKEENCJH JPAGIDGHAAI, AAHMJHHPECM KJCJNKGIBOK) { }
	// RVA: 0x1275db4 VA: 0x9812ddb4
	public Void AutoSwitchWeapon() { }
	// RVA: 0x130250c VA: 0x981ba50c
	private Boolean FPLIAOCDEKO() { }
	// RVA: 0x1302808 VA: 0x981ba808
	public virtual Void SwapWeapon(BMGBKEENCJH JPAGIDGHAAI, Boolean GDKLMFLNNGM) { }
	// RVA: 0x1302f54 VA: 0x981baf54
	private Void BIOBIDINEOG(BMGBKEENCJH JPAGIDGHAAI) { }
	// RVA: 0x13030e0 VA: 0x981bb0e0
	public virtual Void ReloadWeapon() { }
	// RVA: 0x13032d8 VA: 0x981bb2d8
	public virtual Void FullWeaponAmmo() { }
	// RVA: 0x1303350 VA: 0x981bb350
	public virtual Void OnGrenadeStartFire() { }
	// RVA: 0x1303404 VA: 0x981bb404
	public virtual Void OnGrenadeEndFire() { }
	// RVA: 0x13034a4 VA: 0x981bb4a4
	public virtual Void OnIceWallStartFire() { }
	// RVA: 0x13035ac VA: 0x981bb5ac
	public virtual Void OnThrowKnifeStartFire() { }
	// RVA: 0x130364c VA: 0x981bb64c
	public virtual Void OnThrowKnifeEndFire() { }
	// RVA: 0x13036ec VA: 0x981bb6ec
	public virtual Void OnGrenadeQuitFire() { }
	// RVA: 0x1303780 VA: 0x981bb780
	public virtual Void OnBeginPutDown() { }
	// RVA: 0x13037d4 VA: 0x981bb7d4
	public virtual Void OnWeaponLift(Boolean FNHIJNENHHM) { }
	// RVA: 0x13038b4 VA: 0x981bb8b4
	public virtual Void OnWeaponPutDown() { }
	// RVA: 0x1303984 VA: 0x981bb984
	public virtual Void OnWeaponReloadImmediateStarted(Single LDBLIBDEDMH, Boolean GJFOOHPJCOG) { }
	// RVA: 0x1303a08 VA: 0x981bba08
	public virtual Void OnWeaponReloadImmediateFinished(Boolean KIHNJGKPMPP) { }
	// RVA: 0x1303a64 VA: 0x981bba64
	public virtual Void OnWeaponReloadStarted(Single LDBLIBDEDMH, Boolean GJFOOHPJCOG) { }
	// RVA: 0x1303db4 VA: 0x981bbdb4
	public virtual Void OnWeaponReloadFinished(Boolean KIHNJGKPMPP) { }
	// RVA: 0x1303ea0 VA: 0x981bbea0
	public Void OnWeaponReloadDone(Boolean PKPEMNPJDHA) { }
	// RVA: 0x1303f80 VA: 0x981bbf80
	public Boolean IsReloading() { }
	// RVA: 0x1304024 VA: 0x981bc024
	public virtual Void OnSniperPullBoltStarted(Single LDBLIBDEDMH) { }
	// RVA: 0x13040c4 VA: 0x981bc0c4
	public virtual Void OnSniperPullBoltFinished() { }
	// RVA: 0x1304118 VA: 0x981bc118
	public Void OnSniperPullBoltDone() { }
	// RVA: 0x13041a8 VA: 0x981bc1a8
	public Void PlayChangeWeaponSoundInternal() { }
	// RVA: 0x12e5a8c VA: 0x9819da8c
	protected Boolean AIOEHOACJFL() { }
	// RVA: 0x1304cb8 VA: 0x981bccb8
	public Void StartJumpOffAirTransporter() { }
	// RVA: 0x1305778 VA: 0x981bd778
	protected Void JMIMBCCIFOF() { }
	// RVA: 0x13062f0 VA: 0x981be2f0
	public Void PlayOnBoardSound() { }
	// RVA: 0x1306b04 VA: 0x981beb04
	protected Void KKANIBBAPAO() { }
	// RVA: 0x1306c98 VA: 0x981bec98
	protected Void AGMLANOELOO() { }
	// RVA: 0x1307448 VA: 0x981bf448
	public Void ProcessSkySpeedLeftEffect(UInt32 FAPKGPANEBH, ResourceID CLCOBMMDGIP, GameObject MCAMPDBANIL) { }
	// RVA: 0x1307584 VA: 0x981bf584
	public Void ProcessSkySpeedRightEffect(UInt32 IFGGLOCEABA, ResourceID PAJAGBODFIN, GameObject NNFFBDHMFCH) { }
	// RVA: 0x13076c0 VA: 0x981bf6c0
	public Void EquipFlight() { }
	// RVA: 0x12af0c0 VA: 0x981670c0
	public Void UnEquipFlight() { }
	// RVA: 0x1308294 VA: 0x981c0294
	private Void DNJEBLMCPOA() { }
	// RVA: 0x13087b0 VA: 0x981c07b0
	protected virtual Void NHBCHNEHPDJ() { }
	// RVA: 0x1308804 VA: 0x981c0804
	public Boolean IsDrivingFlight() { }
	// RVA: 0x13088d8 VA: 0x981c08d8
	private VisualEffectLoadMethod BJDIDNCPEAM() { }
	// RVA: 0x1307ff4 VA: 0x981bfff4
	private VisualEffectLoadMethod LICPKCPOGFB() { }
	// RVA: 0x13084a8 VA: 0x981c04a8
	private Boolean HJDHEGKMGMC() { }
	// RVA: 0x1308ae0 VA: 0x981c0ae0
	private Boolean JAHJOCJOIKM() { }
	// RVA: 0x1308b84 VA: 0x981c0b84
	protected Void AFJJLINKCLK() { }
	// RVA: 0x1308fc8 VA: 0x981c0fc8
	private Void CJEGGKCFKNK() { }
	// RVA: 0x1309114 VA: 0x981c1114
	private Void FPGDFIKKLMK(UInt32 BBAFHKCBFFN, ResourceID BNEEHJIDAFI, GameObject GAHBKGJAHPJ) { }
	// RVA: 0x1309640 VA: 0x981c1640
	private Void IIACGAIPNPG(UInt32 BBAFHKCBFFN, ResourceID BNEEHJIDAFI, GameObject GAHBKGJAHPJ) { }
	// RVA: 0x12af120 VA: 0x98167120
	protected Void AGDIMDNAEPM(Boolean LAAFFMHJPJF) { }
	// RVA: 0x130974c VA: 0x981c174c
	private Void PFIFPCBGFNA() { }
	// RVA: 0x129aea8 VA: 0x98152ea8
	protected Void NONLOIKKJFC() { }
	// RVA: 0x13098b4 VA: 0x981c18b4
	public Void StartSkyDiving() { }
	// RVA: 0x130afc4 VA: 0x981c2fc4
	private Void LLPLCHGKHLH() { }
	// RVA: 0x1289668 VA: 0x98141668
	private Void MBDOEGHJNIJ() { }
	// RVA: 0x130b4fc VA: 0x981c34fc
	public Void TryRefreshNBEventEffect() { }
	// RVA: 0x130a6b0 VA: 0x981c26b0
	private Void CLNPBADKONF() { }
	// RVA: 0x13073e8 VA: 0x981bf3e8
	public Boolean HasUseEagleSkill() { }
	// RVA: 0x130b49c VA: 0x981c349c
	public Boolean HasOwnEagleSkill() { }
	// RVA: 0x130b0cc VA: 0x981c30cc
	private Void HKAHMNACOOI() { }
	// RVA: 0x130baf0 VA: 0x981c3af0
	public virtual Single GetExtraSpeed() { }
	// RVA: 0x130bb48 VA: 0x981c3b48
	private Void BAJOHJCBLKF() { }
	// RVA: 0x130be80 VA: 0x981c3e80
	public Void StopParachuting(Boolean LOJHBGCFEFL) { }
	// RVA: 0x130cf04 VA: 0x981c4f04
	private Void MAJJPFNNGED() { }
	// RVA: 0x130d470 VA: 0x981c5470
	private Void POHMPLFGAKK() { }
	// RVA: 0x130d08c VA: 0x981c508c
	private Void KBALBMLNEJP(Boolean ADFGDEFPDHN) { }
	// RVA: 0x130d5dc VA: 0x981c55dc
	private Void KADIMEJEDND() { }
	// RVA: 0x130da0c VA: 0x981c5a0c
	protected Void MNNMJDIKEJN() { }
	// RVA: 0x130dcb0 VA: 0x981c5cb0
	private Boolean DPCODGNKNJC() { }
	// RVA: 0x13054fc VA: 0x981bd4fc
	private Boolean EFGMIIKLBEK(ResourceID PEAJPNPDBDJ) { }
	// RVA: 0x130dde0 VA: 0x981c5de0
	private Void DGNBBEMIOND() { }
	// RVA: 0x130df30 VA: 0x981c5f30
	private Void OGFLHCCHNKG(Boolean DAFHANIELFM) { }
	// RVA: 0x130e17c VA: 0x981c617c
	private Void DJHDDKEJPNE() { }
	// RVA: 0x130d800 VA: 0x981c5800
	private Void OCKJBOEKGLC(ResourceID PEAJPNPDBDJ) { }
	// RVA: 0x129a378 VA: 0x98152378
	private Void AJKJOEMOFOF() { }
	// RVA: 0x130d2a4 VA: 0x981c52a4
	private Void GMMNFHGNLOB(Boolean JMOAFMFOJKJ) { }
	// RVA: 0x130e308 VA: 0x981c6308
	private Void LBAFJMIDFIO(Boolean IOIGOCMBKIO, Boolean GCAKNCLNGIF) { }
	// RVA: 0x130e4e8 VA: 0x981c64e8
	private Void NIDPGIGGGIM() { }
	// RVA: 0x130ef18 VA: 0x981c6f18
	private Void ECDADPJAKPK() { }
	// RVA: 0x130f640 VA: 0x981c7640
	protected Void BFFMBDHBKEO(Single OJGNBJELDEM) { }
	// RVA: 0x128dc1c VA: 0x98145c1c
	public Void PlayAccEngineSound() { }
	// RVA: 0x130f748 VA: 0x981c7748
	public Void OnSkySurfingSpeedChanged(Boolean EHLGEAGLLFE) { }
	// RVA: 0x130f824 VA: 0x981c7824
	protected Void NBAPPPOGEMB(Single OJGNBJELDEM) { }
	// RVA: 0x130f94c VA: 0x981c794c
	public Void StartParachuting() { }
	// RVA: 0x1310510 VA: 0x981c8510
	public Void OnParachuteSkinResCallBack(UInt32 LPFMNBCHJPE, Boolean BBFAHFFADIC, Object ECINOMEHBKA) { }
	// RVA: 0x131078c VA: 0x981c878c
	public Void OnParachuteSkinResCallBackEmpty(UInt32 LPFMNBCHJPE, Boolean BBFAHFFADIC, Object DLACOMOFMGG) { }
	// RVA: 0x130eb8c VA: 0x981c6b8c
	private Void IALNNBOKJHM() { }
	// RVA: 0x1310800 VA: 0x981c8800
	public Void PlayHypeFireEffect(Int32 HPCPFHJBNIJ, Int32 DCCLEJKNHKN) { }
	// RVA: 0x1310eac VA: 0x981c8eac
	private Void CLHNGLMIONN() { }
	// RVA: 0x13112f0 VA: 0x981c92f0
	protected Void OKJEFDPMEJH(Int32 DCCLEJKNHKN, Int32 BACIIIEPDLO) { }
	// RVA: 0x1311848 VA: 0x981c9848
	public virtual Void BeforeSwitchAnimController(Boolean DLEBGIFAMJG) { }
	// RVA: 0x1311904 VA: 0x981c9904
	public virtual Void SwitchAnimController() { }
	// RVA: 0x1311fa0 VA: 0x981c9fa0
	public Void SetAsDriver() { }
	// RVA: 0x131202c VA: 0x981ca02c
	public virtual Void PlayChangeVehicleSeatAnimation(Boolean IPMICKKDKMJ) { }
	// RVA: 0x131211c VA: 0x981ca11c
	public Void ShowBagPack() { }
	// RVA: 0x13121d0 VA: 0x981ca1d0
	public Void HideBagPack() { }
	// RVA: 0x1312288 VA: 0x981ca288
	public virtual Void OnSwitchWeaponSkin(UInt32 EGKLLCFPBOG, UInt32 LAIIJPFGAPF) { }
	// RVA: 0x13122f8 VA: 0x981ca2f8
	public virtual Void OnWeaponAnimFireEffect() { }
	// RVA: 0x1312394 VA: 0x981ca394
	public Void OnStartChangeWeapon(GPBDEDFKJNA LPLPBJGAPHK, Single PFNGHMIADLB) { }
	// RVA: 0x1312d10 VA: 0x981cad10
	public virtual Void ResizeSniperFireCollider(Single LCMKCHOILIB, Single BAJIOEGPDAN, Single DCGFBHEMOGF, Boolean NCOONPPOKJO) { }
	// RVA: 0x1313164 VA: 0x981cb164
	public virtual Void ResizeCapsuleCollider(Single LCMKCHOILIB, Single BAJIOEGPDAN, Single LDAODGKLLGC, Single KDDFFJOMPDD) { }
	// RVA: 0x129de60 VA: 0x98155e60
	protected Void DGFEGFFJLKL(Boolean HGMBMICDALC) { }
	// RVA: 0x12a5c48 VA: 0x9815dc48
	public Void OnFireModeChanged(Boolean IKPLNEOMFCJ) { }
	// RVA: 0x13136b4 VA: 0x981cb6b4
	public Void SetAimAssistIceWallParams(Single AKKKDEFMCDP, Single IEFKLEFMOPM, Vector4 OOIFCIIDEME, Vector4 LCAOBHBOHGJ) { }
	// RVA: 0x12ae770 VA: 0x98166770
	public Void OnThrowSkillCrossHairFireBegin(Boolean GAKPDNJGOGL) { }
	// RVA: 0x1313860 VA: 0x981cb860
	public virtual Transform GetHeadTF() { }
	// RVA: 0x1313a7c VA: 0x981cba7c
	public virtual Transform GetHipTF() { }
	// RVA: 0x1313c98 VA: 0x981cbc98
	protected virtual Vector3 MPDOJMMECAF() { }
	// RVA: 0x1313ffc VA: 0x981cbffc
	public virtual Transform GetLeftAnkleTF() { }
	// RVA: 0x1314150 VA: 0x981cc150
	public virtual Transform GetRightAnkleTF() { }
	// RVA: 0x13142a4 VA: 0x981cc2a4
	public virtual Transform GetLeftToeTF() { }
	// RVA: 0x13143f8 VA: 0x981cc3f8
	public virtual Transform GetRightToeTF() { }
	// RVA: 0x131454c VA: 0x981cc54c
	public virtual Vector3 GetCharacterControllerTopPosition() { }
	// RVA: 0x12bc070 VA: 0x98174070
	public Single GetCharacterHeight() { }
	// RVA: 0x1314864 VA: 0x981cc864
	public Single GetCharacterCenterY() { }
	// RVA: 0x12f4d3c VA: 0x981acd3c
	private OPILIBBOEAC GKHECDLGAJA(MADMMIICBNN NLEGOPLNDBB) { }
	// RVA: 0x1314910 VA: 0x981cc910
	public Int32 GetWeaponZoomAmplifier() { }
	// RVA: 0x12ed174 VA: 0x981a5174
	protected Vector3 FGMAPCMEDOA() { }
	// RVA: 0x1314b08 VA: 0x981ccb08
	public Single GetAimAssisYSensitivity(GPBDEDFKJNA LPLPBJGAPHK) { }
	// RVA: 0x13149c8 VA: 0x981cc9c8
	public Single GetAimAssistDampCoefficient(GPBDEDFKJNA LPLPBJGAPHK) { }
	// RVA: 0x1314d3c VA: 0x981ccd3c
	public virtual Boolean RequestRescureTarget(IHAAMHPPLMG FFDHFKIMFDG) { }
	// RVA: 0x1315204 VA: 0x981cd204
	public virtual Boolean RequestStopResure() { }
	// RVA: 0x1315290 VA: 0x981cd290
	protected Void GFBKBGOPNDF() { }
	// RVA: 0x12cf150 VA: 0x98187150
	public Void RequestUseTeleportDoor(UInt32 IEPFELEIMFE, Boolean JJBNCDACMAD) { }
	// RVA: 0x131579c VA: 0x981cd79c
	private Void FACFMIBCGEL(LevelTeleportDoor EJKDLCBJMOG, UInt32 IEPFELEIMFE) { }
	// RVA: 0x1315b38 VA: 0x981cdb38
	public Boolean get_IsFallingLand() { }
	// RVA: 0x1315440 VA: 0x981cd440
	public Boolean CheckCanUseTeleportDoor() { }
	// RVA: 0x1315c5c VA: 0x981cdc5c
	public Boolean CheckCanUseFerrisWheel() { }
	// RVA: 0x1315fac VA: 0x981cdfac
	public Boolean CheckCanUnlockBountyVehicle() { }
	// RVA: 0x1316494 VA: 0x981ce494
	public BaseLevelObject get_PrayingPlant() { }
	// RVA: 0x13164ec VA: 0x981ce4ec
	public virtual Void RequestPlayEmote4Plant(OFJHNKMJNGA CLJGFIOLMAK, UInt32 IEPFELEIMFE) { }
	// RVA: 0x13168d0 VA: 0x981ce8d0
	public virtual Void RequestStoreInWareHouse(UInt32 IEPFELEIMFE) { }
	// RVA: 0x131692c VA: 0x981ce92c
	public virtual Void RequestStopStoringInWarehouse() { }
	// RVA: 0x1316980 VA: 0x981ce980
	public virtual Void RequestOpenTreasury() { }
	// RVA: 0x13169d4 VA: 0x981ce9d4
	public virtual Void RequestOpenTimingTreasureBox() { }
	// RVA: 0x1316a28 VA: 0x981cea28
	public virtual Void RequestHayrickJump() { }
	// RVA: 0x1316a7c VA: 0x981cea7c
	public virtual Void DoSquareDancingTriggerAction() { }
	// RVA: 0x1317034 VA: 0x981cf034
	public virtual Void LocalStopSquareDancing() { }
	// RVA: 0x131709c VA: 0x981cf09c
	public Void NBEatNoodle() { }
	// RVA: 0x1317290 VA: 0x981cf290
	private IEnumerator BBNPCPFPCJO() { }
	// RVA: 0x1316d88 VA: 0x981ced88
	public Void LocalStartSquareDancing(UInt32 MJKNGMDNEAJ) { }
	// RVA: 0x1317d28 VA: 0x981cfd28
	public virtual Void RequestStopEmote4Plant() { }
	// RVA: 0x1317db0 VA: 0x981cfdb0
	public virtual Void StopPlayEmotion() { }
	// RVA: 0x1317ec4 VA: 0x981cfec4
	public virtual Void RequestSyncStopEmotion(Boolean DOKIPIBOMOI) { }
	// RVA: 0x1317fe8 VA: 0x981cffe8
	public virtual Void StopEmote4Plant() { }
	// RVA: 0x1318104 VA: 0x981d0104
	public Void RequestEnterMusicShootZone(UInt32 IDNEFEOPGIF) { }
	// RVA: 0x1318228 VA: 0x981d0228
	public Void RequestEnterSoloDance() { }
	// RVA: 0x131869c VA: 0x981d069c
	public Void RequestSoloDanceReady() { }
	// RVA: 0x13187a4 VA: 0x981d07a4
	public Void RequestQuitSoloDance() { }
	// RVA: 0x13188ac VA: 0x981d08ac
	public Void RequestInviteSoloDanceOpponent(Boolean JPAMDNJCDHB) { }
	// RVA: 0x12c3858 VA: 0x9817b858
	public Void RequestExitMusicShootZone(UInt32 IDNEFEOPGIF, Boolean EBOJJLIHHCM) { }
	// RVA: 0x1318a50 VA: 0x981d0a50
	public virtual Void RequestOpenRangeShop(UInt32 IEPFELEIMFE) { }
	// RVA: 0x1319104 VA: 0x981d1104
	public virtual Void RequestPray4EscortBoss(UInt32 IEPFELEIMFE) { }
	// RVA: 0x1319558 VA: 0x981d1558
	public virtual Void RequestStopPraying4EscortBoss() { }
	// RVA: 0x13195ac VA: 0x981d15ac
	public virtual Void OnEscortBossStatusChanged() { }
	// RVA: 0x13197c4 VA: 0x981d17c4
	public virtual Void RequestGetOnFerrisWheel() { }
	// RVA: 0x1319d0c VA: 0x981d1d0c
	public virtual Void RequestUnlockBountyVehicle() { }
	// RVA: 0x1319e5c VA: 0x981d1e5c
	public virtual Boolean CheckCanOpenBountyBox() { }
	// RVA: 0x131a49c VA: 0x981d249c
	public virtual Boolean CheckCanOpenWeRunBox() { }
	// RVA: 0x131a5b4 VA: 0x981d25b4
	public virtual Void RequestGetOffFerrisWheel() { }
	// RVA: 0x131a908 VA: 0x981d2908
	public Void RequestEnterServerMiniGame(UInt32 MAPEMGAINLD) { }
	// RVA: 0x131ab2c VA: 0x981d2b2c
	public Void RequestGiveSnowball(UInt32 EEAIIFLPEMM) { }
	// RVA: 0x131ae60 VA: 0x981d2e60
	public Boolean CanWeaponCombine(GPBDEDFKJNA JDBHLIJFKOH) { }
	// RVA: 0x131afd8 VA: 0x981d2fd8
	public virtual Void DoUpdateActionState(EAcationState FNECNAAOMEG, EPreparationTimerType JCLPFENICLD, Single LEBOAIEJCPJ, Object[] GCHBPLKFBPK) { }
	// RVA: 0x131b074 VA: 0x981d3074
	public Void MountWeaponGameObject(GPBDEDFKJNA LPLPBJGAPHK, Boolean NJGHGBPCOCL) { }
	// RVA: 0x131b774 VA: 0x981d3774
	public Void MountWeaponGameObject(GPBDEDFKJNA LPLPBJGAPHK) { }
	// RVA: 0x12ef458 VA: 0x981a7458
	public Boolean IsFreeMove() { }
	// RVA: 0x127d43c VA: 0x9813543c
	public Boolean IsFiring() { }
	// RVA: 0x131bfd8 VA: 0x981d3fd8
	public Boolean IsInExpansionAbility() { }
	// RVA: 0x131c090 VA: 0x981d4090
	public Boolean IsWeaponInAutoCharge() { }
	// RVA: 0x131c148 VA: 0x981d4148
	public Boolean IsHoldingFireForSingleShot() { }
	// RVA: 0x131c200 VA: 0x981d4200
	public Boolean IsSniperPullingBolt() { }
	// RVA: 0x131c294 VA: 0x981d4294
	public ENBHOKKHLPG GetWeaponType() { }
	// RVA: 0x131c378 VA: 0x981d4378
	public Int32 GetWeaponSubType() { }
	// RVA: 0x131c45c VA: 0x981d445c
	public Void ExitTriggers(Boolean GHLKDNNNICJ, Boolean PMNCCODPOCE) { }
	// RVA: 0x131c8a0 VA: 0x981d48a0
	public virtual Void OnGetOnFerrisWheel(LevelFerrisWheel NLDLLCIMJGH, Byte NCLKIGNAEMK, Byte FNJFBBAGJGF) { }
	// RVA: 0x131cb30 VA: 0x981d4b30
	public virtual Void OnGetOffFerrisWheel(Byte NCLKIGNAEMK, Byte FNJFBBAGJGF) { }
	// RVA: 0x131cd50 VA: 0x981d4d50
	protected Void MLPIEADEOIF() { }
	// RVA: 0x131ced4 VA: 0x981d4ed4
	public virtual Void OnGetOnVehicle(Vehicle JOGHOHLEJFL) { }
	// RVA: 0x131e8f8 VA: 0x981d68f8
	public Vector3 GetOffVehiclePosition() { }
	// RVA: 0x1321280 VA: 0x981d9280
	public Vector3 GetOffChairPosition() { }
	// RVA: 0x1321b04 VA: 0x981d9b04
	public Void OnLeaderPosChange(Single OMAFEKBHOAA) { }
	// RVA: 0x1321c0c VA: 0x981d9c0c
	public virtual Void OnGetOffVehicle() { }
	// RVA: 0x1322cdc VA: 0x981dacdc
	public Boolean GetOnStropPrecheck() { }
	// RVA: 0x132313c VA: 0x981db13c
	public virtual Void OnGetOnStrop(LevelStrop GDMPEEPJPPG, Single NIBKFKFNPOF, Single KEFKOGBHIKE, Boolean DNDJMGNCJPC) { }
	// RVA: 0x1324b70 VA: 0x981dcb70
	private Void KBLCNDBFPJK() { }
	// RVA: 0x1324cfc VA: 0x981dccfc
	private Boolean KBCKAAFFOJO() { }
	// RVA: 0x1324e78 VA: 0x981dce78
	public Void OnStropRingGOCallBack(UInt32 LFKHBCOJFLP, ResourceID KNJPONEBDGA, GameObject OMDFNKNJDII) { }
	// RVA: 0x1325a94 VA: 0x981dda94
	private Void INLNODEFIJP(UInt32 LFKHBCOJFLP, ResourceID KNJPONEBDGA, GameObject OMDFNKNJDII) { }
	// RVA: 0x1325bf8 VA: 0x981ddbf8
	public virtual Void OnGetOffStrop(Single MHLMCIHJALP) { }
	// RVA: 0x132689c VA: 0x981de89c
	protected Void EMOFEHBJCOE() { }
	// RVA: 0x1326934 VA: 0x981de934
	public Void OnSceneEditLookMode() { }
	// RVA: 0x13269f0 VA: 0x981de9f0
	public Void OnSceneEditUpdateTransform(Boolean LIEKNHHHKDC) { }
	// RVA: 0x132735c VA: 0x981df35c
	public Void OnSceneEditFreeMode() { }
	// RVA: 0x1327520 VA: 0x981df520
	public Void OnSceneEditLockMode() { }
	// RVA: 0x13276e4 VA: 0x981df6e4
	public Void OnSceneEditPutDown() { }
	// RVA: 0x1324704 VA: 0x981dc704
	private Void AKCBKALIAIN() { }
	// RVA: 0x1327940 VA: 0x981df940
	public Boolean HasGrapplingHook() { }
	// RVA: 0x1327a78 VA: 0x981dfa78
	public Boolean HasVMEHook() { }
	// RVA: 0x12aef6c VA: 0x98166f6c
	public Boolean HasHook() { }
	// RVA: 0x1327bb0 VA: 0x981dfbb0
	public Boolean IsOnGrapplingHook() { }
	// RVA: 0x12cd198 VA: 0x98185198
	public Boolean IsOnHook() { }
	// RVA: 0x1327c4c VA: 0x981dfc4c
	public Boolean IsOnVMEHook() { }
	// RVA: 0x1327ce8 VA: 0x981dfce8
	public Void OnGrapplingHookSpawned(LevelGrapplingHook BJCKGAJPCIJ) { }
	// RVA: 0x1327d54 VA: 0x981dfd54
	public Void OnGrapplingHookHooked() { }
	// RVA: 0x1327de4 VA: 0x981dfde4
	public Boolean get_NeedGlideAfterHookLanding() { }
	// RVA: 0x1327dec VA: 0x981dfdec
	public Void set_NeedGlideAfterHookLanding(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12af048 VA: 0x98167048
	public Void OnGrapplingHookDestroyed() { }
	// RVA: 0x1327df4 VA: 0x981dfdf4
	public Void GetOffGrapplingHook() { }
	// RVA: 0x1327e94 VA: 0x981dfe94
	public Void OnGrapplingHookReEnter(Vector3 GFJJOEJMNON) { }
	// RVA: 0x1327f54 VA: 0x981dff54
	public Void StartOnGrapplingHook() { }
	// RVA: 0x1328a08 VA: 0x981e0a08
	public Void StopOnGrapplingHook() { }
	// RVA: 0x1328588 VA: 0x981e0588
	public Void AddGrapplingHookGunEfeect(Boolean ILDNPPIHOMD) { }
	// RVA: 0x1328f04 VA: 0x981e0f04
	public Boolean HasSwingSpider() { }
	// RVA: 0x1328fe0 VA: 0x981e0fe0
	public Boolean IsOnSwing() { }
	// RVA: 0x132907c VA: 0x981e107c
	public Void OnSwingSpiderSpawned(LevelSwingSpider IJDCOFLGPPA) { }
	// RVA: 0x13290e8 VA: 0x981e10e8
	public Void OnSwingSpiderAttached() { }
	// RVA: 0x1329178 VA: 0x981e1178
	public Void OnSwingSpiderDestroyed() { }
	// RVA: 0x1329288 VA: 0x981e1288
	public Void GetOffSwingSpider(Boolean HMFBNAHDPGN) { }
	// RVA: 0x1329788 VA: 0x981e1788
	public Void OnSwingSpiderReEnter(Vector3 GFJJOEJMNON) { }
	// RVA: 0x13299d4 VA: 0x981e19d4
	public Void StartOnSwingSpider() { }
	// RVA: 0x132a8b4 VA: 0x981e28b4
	public Void StopOnSwingSpider() { }
	// RVA: 0x132a424 VA: 0x981e2424
	public Void AddSwingGunEffect(Boolean ILDNPPIHOMD) { }
	// RVA: 0x132b098 VA: 0x981e3098
	public Void OnStartSprint() { }
	// RVA: 0x132b1dc VA: 0x981e31dc
	public Void OnFinishSprint() { }
	// RVA: 0x132b340 VA: 0x981e3340
	public Void OnStartFaithJuming() { }
	// RVA: 0x132b3d8 VA: 0x981e33d8
	public Void StartFaithJumping() { }
	// RVA: 0x132ba44 VA: 0x981e3a44
	public Void OnFaithJumpingLand() { }
	// RVA: 0x132beec VA: 0x981e3eec
	public Void StopFaithJumping() { }
	// RVA: 0x132c4ac VA: 0x981e44ac
	public Void OnReusableObjectRecycled(ResourceID ODNIHGABFJA, GameObject ECINOMEHBKA) { }
	// RVA: 0x129e108 VA: 0x98156108
	private Void PMOMJMGILGF() { }
	// RVA: 0x129e2d8 VA: 0x981562d8
	private Void KGLBHKBMKDO() { }
	// RVA: 0x132c678 VA: 0x981e4678
	public Void StartJumpOffStrop(Boolean JLHGJLGFPNM) { }
	// RVA: 0x132cc9c VA: 0x981e4c9c
	public Void SwitchStrop() { }
	// RVA: 0x132d228 VA: 0x981e5228
	public Void StropDash() { }
	// RVA: 0x1315ab8 VA: 0x981cdab8
	public Boolean IsFalling() { }
	// RVA: 0x12aeb90 VA: 0x98166b90
	public Boolean IsOnStrop() { }
	// RVA: 0x1324a44 VA: 0x981dca44
	public Boolean IsOnRailStrop() { }
	// RVA: 0x12e5990 VA: 0x9819d990
	public Boolean DisableFireOnStrop() { }
	// RVA: 0x132d4a8 VA: 0x981e54a8
	public Boolean IsAbleToSwitchStrop() { }
	// RVA: 0x128e0c8 VA: 0x981460c8
	public Boolean IsStropState() { }
	// RVA: 0x127f514 VA: 0x98137514
	public Boolean IsOnChair() { }
	// RVA: 0x132d5d0 VA: 0x981e55d0
	public FerrisWheelSeatGroup GetFerrisTriggerIAmIn() { }
	// RVA: 0x132d628 VA: 0x981e5628
	public LevelStrop GetStropIAmOn() { }
	// RVA: 0x1278014 VA: 0x98130014
	public Boolean IsInVehicle() { }
	// RVA: 0x128d720 VA: 0x98145720
	public Vehicle GetVehicleIAmIn() { }
	// RVA: 0x12b3090 VA: 0x9816b090
	public Boolean IsInVehicleOrHelicopter() { }
	// RVA: 0x12f7a8c VA: 0x981afa8c
	public Vehicle GetVehicleOrHelicopterIAmIn() { }
	// RVA: 0x132d680 VA: 0x981e5680
	public Boolean IsInHelicopter(Boolean NFIPLPDIKAJ) { }
	// RVA: 0x132d904 VA: 0x981e5904
	public Void ApplyVechileControl(COGIEJGPDDD AGGIFAEGEPA, Vector3 HAIAPHFNAIP) { }
	// RVA: 0x1304388 VA: 0x981bc388
	public GameObject PlayAshot(ResourceID IDNEFEOPGIF, Boolean ELOGCJLPBKI, Single AIFHEJMAIFP, ResourceID IBPEKMGNANK, Boolean JMFIHKELDED, EAudioEngineType DLBAILHGELB, Boolean PDPACCCGECN, Boolean DAKAECPEMAI, Int32 AEMNIFDEIHM, Boolean BFAFOIOCBME) { }
	// RVA: 0x132db7c VA: 0x981e5b7c
	public List`1 GetBoundingBoxList() { }
	// RVA: 0x132deb0 VA: 0x981e5eb0
	protected override Void OnUpdateVisibleStateByStreamer(Vector3 MKGCDPNKMOB, Vector3 OANAHFHPBNB) { }
	// RVA: 0x132e084 VA: 0x981e6084
	public Void RegisterDynamicPVS() { }
	// RVA: 0x132e38c VA: 0x981e638c
	public Void UnRegisterDynamicPVS() { }
	// RVA: 0x132e5b8 VA: 0x981e65b8
	private Void DMJENAOBEJM(Boolean FICNJIMKAEF) { }
	// RVA: 0x132e650 VA: 0x981e6650
	public Vector3 GetCameraTrackableEntityPosition() { }
	// RVA: 0x132e8b8 VA: 0x981e68b8
	public Quaternion GetCameraTrackableEntityAimRotation() { }
	// RVA: 0x132e938 VA: 0x981e6938
	public virtual Vector3 GetCameraTrackableEntityTopPosition() { }
	// RVA: 0x132eddc VA: 0x981e6ddc
	public Transform GetCameraTrackableEntityTransfrom() { }
	// RVA: 0x132ef44 VA: 0x981e6f44
	public Boolean IsCameraTrackableEntityAlive() { }
	// RVA: 0x132f110 VA: 0x981e7110
	public virtual Boolean IsOutOfControl() { }
	// RVA: 0x1289af4 VA: 0x98141af4
	public Void set_AllowRotateIfOutOfControl(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12d739c VA: 0x9818f39c
	public Boolean get_AllowRotateIfOutOfControl() { }
	// RVA: 0x1276290 VA: 0x9812e290
	public Void set_AllowBuildingGunIfOutOfControl(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1302800 VA: 0x981ba800
	public Boolean get_AllowBuildingGunIfOutOfControl() { }
	// RVA: 0x132f1f4 VA: 0x981e71f4
	public virtual Boolean IsLocalPlayerOutOfControlNeedUpdataAimRotaion() { }
	// RVA: 0x132f2a8 VA: 0x981e72a8
	public virtual Boolean NeedTickWhenDead() { }
	// RVA: 0x132f330 VA: 0x981e7330
	public Void SetDriverSteeringAngle(Single BLHEBBCODLC) { }
	// RVA: 0x132f3ec VA: 0x981e73ec
	public Void SetHasDriverForAim(Single BLHEBBCODLC) { }
	// RVA: 0x132f4a8 VA: 0x981e74a8
	private ResourceID KBGOGGEFADN() { }
	// RVA: 0x132f634 VA: 0x981e7634
	public Boolean HasCustomAnimation() { }
	// RVA: 0x12d5df0 VA: 0x9818ddf0
	public Boolean get_IsPlayingCustomAnimation() { }
	// RVA: 0x1300c34 VA: 0x981b8c34
	public Boolean get_IsPlayingFreezeCustomAnimation() { }
	// RVA: 0x132f724 VA: 0x981e7724
	public Boolean get_IsPlayingWalk() { }
	// RVA: 0x132f820 VA: 0x981e7820
	public Boolean get_IsPlayingMedKit() { }
	// RVA: 0x132fa04 VA: 0x981e7a04
	public Boolean get_IsSwimmingSurfChange() { }
	// RVA: 0x12ec33c VA: 0x981a433c
	public Boolean get_IsSwimmingDead() { }
	// RVA: 0x132fb78 VA: 0x981e7b78
	public virtual Boolean RequestPlayCustomAnimation() { }
	// RVA: 0x1330518 VA: 0x981e8518
	public Void SpawnBattleFlagOnHand() { }
	// RVA: 0x1330724 VA: 0x981e8724
	protected Void BJDEIKLANCD() { }
	// RVA: 0x1300aa8 VA: 0x981b8aa8
	protected Void DIKKBMEEEOL() { }
	// RVA: 0x1330d04 VA: 0x981e8d04
	protected Vector3 NCCKNPDMJHP() { }
	// RVA: 0x1330f78 VA: 0x981e8f78
	public GameObject GetBattleFlagOnGround() { }
	// RVA: 0x1330fe8 VA: 0x981e8fe8
	public Void ClearOnGroundBattleFlagRef() { }
	// RVA: 0x13310cc VA: 0x981e90cc
	public ResourceID GetBattleFlagResId() { }
	// RVA: 0x1331124 VA: 0x981e9124
	public Void ChangedBattleFlagToGround() { }
	// RVA: 0x1331a04 VA: 0x981e9a04
	public virtual Boolean RequestUseBattleFlag() { }
	// RVA: 0x1331adc VA: 0x981e9adc
	protected Void GAIMDDGHDKJ() { }
	// RVA: 0x130110c VA: 0x981b910c
	private Void GGCOCMBOHNA() { }
	// RVA: 0x1300d30 VA: 0x981b8d30
	public Void StopAnimEfects(Boolean CFDIGBCIEON) { }
	// RVA: 0x1331c70 VA: 0x981e9c70
	public Void ResetClothEffectEmoteShowMaskVisibility() { }
	// RVA: 0x1331d6c VA: 0x981e9d6c
	public UInt32 GetNowPlayeAvatarId() { }
	// RVA: 0x132ffbc VA: 0x981e7fbc
	public Void PlayCustomAnimation(SByte OECMLDILLJN) { }
	// RVA: 0x1331f64 VA: 0x981e9f64
	public virtual Boolean RequestPlayEmotionAnimation(UInt32 IMBFPICKFHM, Single KPCJADGMEJG) { }
	// RVA: 0x13334b0 VA: 0x981eb4b0
	public virtual Boolean CanPlayEmotion() { }
	// RVA: 0x13337ac VA: 0x981eb7ac
	public Void PlayTransformSound(ResourceID DJGKIAJEFCI) { }
	// RVA: 0x12fe34c VA: 0x981b634c
	public AnimationRuntimeHandle PlayAnimation(ResourceID MFNEABEJJCB, Boolean ILOIBNIHGPM, Boolean BFAFOIOCBME, Single HIPCLFGCBNI) { }
	// RVA: 0x1333944 VA: 0x981eb944
	public Void SetAnimationSpeed(Single OJGNBJELDEM) { }
	// RVA: 0x13339c8 VA: 0x981eb9c8
	public Void UpdateBuffBehaivor(CJKJKAEMMAO LHCHNFGKLHD, GPBDEDFKJNA CGGALFNOEIA) { }
	// RVA: 0x133f7a4 VA: 0x981f77a4
	private Void KNNHJDOCNJB(Single KNHIPEDCCMN) { }
	// RVA: 0x133e4c0 VA: 0x981f64c0
	public Void CreateOrHideA124SlienceEffect(Boolean MLCNEKFABOP) { }
	// RVA: 0x1340178 VA: 0x981f8178
	public Void CancelPreparation() { }
	// RVA: 0x133e664 VA: 0x981f6664
	private Void EMLPOJLFOBD(Single LEBOAIEJCPJ) { }
	// RVA: 0x133eb4c VA: 0x981f6b4c
	private Void MGOPCBNEDNO() { }
	// RVA: 0x1340c3c VA: 0x981f8c3c
	public Single get_BanActiveSkillEndTime() { }
	// RVA: 0x1340318 VA: 0x981f8318
	private Void HMJAPKENAGD(Boolean MCDIDHODHLN, Single NFPILHKMBHL, ABPCCGDJHIA OMNGGLFFMGM) { }
	// RVA: 0x1340d6c VA: 0x981f8d6c
	public Void BanActiveSkill(AKHIEKAIJJA LHCHNFGKLHD) { }
	// RVA: 0x1341198 VA: 0x981f9198
	public Void RecoverActiveSkill() { }
	// RVA: 0x134135c VA: 0x981f935c
	public Boolean get_IsCanInterruptSkillEffecting() { }
	// RVA: 0x13413b4 VA: 0x981f93b4
	public Void set_IsCanInterruptSkillEffecting(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12b0868 VA: 0x98168868
	private Void JJEDBOONCAG(Boolean ODOEHEHNJOG) { }
	// RVA: 0x12b0ab0 VA: 0x98168ab0
	public Void ShowBooyahGuyBuffEffect(Boolean ODOEHEHNJOG) { }
	// RVA: 0x1341414 VA: 0x981f9414
	private Void NHEIOFOLEOE(UMAData AJKBOONEOAB) { }
	// RVA: 0x12b0c20 VA: 0x98168c20
	private Void IEEMKHNHDKE(Boolean ODOEHEHNJOG, Boolean JDBPBKHLBFG, Boolean LBGNACHEJPP, Boolean IEOEBNPDNMG) { }
	// RVA: 0x133e214 VA: 0x981f6214
	private Void JOPOGPONKNB(Boolean OJFAADINKON, Boolean BICPNCHOCJI) { }
	// RVA: 0x13414a4 VA: 0x981f94a4
	public Void SwitchEffect(EffectType INJCOCBCFNM) { }
	// RVA: 0x133dd54 VA: 0x981f5d54
	public Void ShowSpeedUpEffect(Boolean ODOEHEHNJOG) { }
	// RVA: 0x12fee28 VA: 0x981b6e28
	private Boolean EOEPMCFDAEA(Boolean EDCBODJMHJI) { }
	// RVA: 0x12b0f84 VA: 0x98168f84
	public Void ShowEnergyStoneBuffEffect(Boolean ODOEHEHNJOG, ResourceID MHMPNKIIODD) { }
	// RVA: 0x133f010 VA: 0x981f7010
	private Void FBEKCOGLHGE(Boolean GIKMGIJCDOP, CBIKNJDAGLO JMEHJCCMLAL) { }
	// RVA: 0x133261c VA: 0x981ea61c
	public Void PlayEmotionAnimation(UInt32 IMBFPICKFHM, Single KPCJADGMEJG, UInt32 KLFDACDKGHH, EDuoEmoteStage DBGJKPJPGPE, Boolean CPLOPPNHOGA) { }
	// RVA: 0x1317790 VA: 0x981cf790
	public Void LeadEmote(UInt32 MJKNGMDNEAJ, Boolean KFDLBGBCCNB) { }
	// RVA: 0x131735c VA: 0x981cf35c
	public Void FollowEmote(IHAAMHPPLMG KCBGGCKHIGA, Boolean KFDLBGBCCNB) { }
	// RVA: 0x13418e8 VA: 0x981f98e8
	public UInt32 GetPlayLeadEmoteTickCnt() { }
	// RVA: 0x12bc0f8 VA: 0x981740f8
	private Void NOJOCINAIBM(LevelDoor JEGOMJCNILO) { }
	// RVA: 0x12cd234 VA: 0x98185234
	private Void PFCCNLMMAGC(LevelDoor JEGOMJCNILO) { }
	// RVA: 0x12cb1c8 VA: 0x981831c8
	private Void EOIHJPDAMHI(LevelDoor JEGOMJCNILO) { }
	// RVA: 0x1341940 VA: 0x981f9940
	public Void SetExternalWeapon(KCMNBMDPNAK JDBHLIJFKOH) { }
	// RVA: 0x12faf9c VA: 0x981b2f9c
	public HMNOKCEINKD GetCombinedWeapon() { }
	// RVA: 0x1341a28 VA: 0x981f9a28
	public Boolean CanCombineWeapon() { }
	// RVA: 0x1341aa0 VA: 0x981f9aa0
	public Boolean get_IsWearingTeleportDoor() { }
	// RVA: 0x1341bd0 VA: 0x981f9bd0
	public CheckBoxCrossHairTrigger get_TeleportDoorPlayerOverlapChecker() { }
	// RVA: 0x1341f68 VA: 0x981f9f68
	public Boolean get_HasAgainstEntities() { }
	// RVA: 0x1342364 VA: 0x981fa364
	public Void SetTeleportDoorPlayerOverlapCheckerActive(Boolean GIKMGIJCDOP) { }
	// RVA: 0x134249c VA: 0x981fa49c
	public virtual Boolean RequestUsingTeleportDoor() { }
	// RVA: 0x12a5d5c VA: 0x9815dd5c
	protected Void JOLIAOCIMHE(Int32 EIKCFIDCCMM) { }
	// RVA: 0x129e010 VA: 0x98156010
	protected GameObject CAPBJIHPPFH() { }
	// RVA: 0x13425f4 VA: 0x981fa5f4
	protected Void LNDMGAFECMD(Int32 BLEAICPKPGL) { }
	// RVA: 0x1342e84 VA: 0x981fae84
	protected Void HMKGIEKJCJH(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13433a8 VA: 0x981fb3a8
	protected Void PEEBIJOOMNJ(PNNDOLFEBEL KJINKEBEBNG, Int32 EIKCFIDCCMM) { }
	// RVA: 0x134376c VA: 0x981fb76c
	protected Void KIKMCKIBECF(Int32 EIKCFIDCCMM) { }
	// RVA: 0x1343b9c VA: 0x981fbb9c
	public virtual Void PlayBigHeadHypeEffect() { }
	// RVA: 0x1343c04 VA: 0x981fbc04
	private Void KFCMCNOJKLC() { }
	// RVA: 0x1343f58 VA: 0x981fbf58
	public virtual Void PlayBigHeadLevelUpEffect() { }
	// RVA: 0x13443ac VA: 0x981fc3ac
	public Void PlaySwimmingSurfSound(Boolean CHADOJMOHFJ) { }
	// RVA: 0x13446dc VA: 0x981fc6dc
	public Void PlaySurfEffect(ResourceID FCMOICILFBP) { }
	// RVA: 0x134486c VA: 0x981fc86c
	public Void DelayEquipBoard() { }
	// RVA: 0x1298c9c VA: 0x98150c9c
	public Void StopEquipBoardCoroutine() { }
	// RVA: 0x13448e0 VA: 0x981fc8e0
	private IEnumerator BHKKPNLLLCE() { }
	// RVA: 0x13449ac VA: 0x981fc9ac
	public Void StartCheckBooyahEmote() { }
	// RVA: 0x1345014 VA: 0x981fd014
	private Void EJMBGKMHALG() { }
	// RVA: 0x12aabb4 VA: 0x98162bb4
	public Void StopCheckBooyahEmote(Boolean MALFDKAPNJI) { }
	// RVA: 0x1345088 VA: 0x981fd088
	private IEnumerator AEIPFBNKHNE() { }
	// RVA: 0x1344fa0 VA: 0x981fcfa0
	private Void CNHNJECBGHA() { }
	// RVA: 0x1345494 VA: 0x981fd494
	private IEnumerator JDNHJGFMHOF() { }
	// RVA: 0x1345560 VA: 0x981fd560
	protected virtual Boolean DNGFIJPMFNM() { }
	// RVA: 0x13455b8 VA: 0x981fd5b8
	public Void SetObservered(Boolean EBOJJLIHHCM) { }
	// RVA: 0x1345b3c VA: 0x981fdb3c
	public Int32 get_CurRedEnvelopeUsedCnt() { }
	// RVA: 0x1345b94 VA: 0x981fdb94
	public Void UsedRedEnvelope() { }
	// RVA: 0x12bc3c4 VA: 0x981743c4
	public Void OnEnterDamageZone(LevelDamageZone BFBMOMCNAHC) { }
	// RVA: 0x12cb61c VA: 0x9818361c
	public Void OnExitDamageZone(LevelDamageZone BFBMOMCNAHC) { }
	// RVA: 0x1345bf8 VA: 0x981fdbf8
	public Player get_TrackingPlayer() { }
	// RVA: 0x1345c50 VA: 0x981fdc50
	public Void SetVehicleVisible() { }
	// RVA: 0x1345ce0 VA: 0x981fdce0
	public Void DebugPlayerVisibilityInfo() { }
	// RVA: 0x1346020 VA: 0x981fe020
	public Boolean get_CanBuyRevive() { }
	// RVA: 0x1298d2c VA: 0x98150d2c
	private Void CACDBLANLPO(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1346028 VA: 0x981fe028
	public Int32 get_PlayerPendingReviveEndTimeMs() { }
	// RVA: 0x1346080 VA: 0x981fe080
	public Void StartPendingRevive(FJNGPCLOJHC LHCHNFGKLHD) { }
	// RVA: 0x1346928 VA: 0x981fe928
	public Boolean CheckVisibleByDis(Vector3 JCIMKOJCHCF) { }
	// RVA: 0x1346be0 VA: 0x981febe0
	public Void StopPendingRevive(Boolean KNCEOGOLNFD, Vector3 JCIMKOJCHCF) { }
	// RVA: 0x1347824 VA: 0x981ff824
	public Void ReviveInitState(Vector3 ACCOJJMKKPM, Quaternion JGOGIAFGCFC, Quaternion OFGMAFLCLEH, Single OOPCGACENFJ, UInt32 DDFGMFGPDEK) { }
	// RVA: 0x13482d4 VA: 0x982002d4
	private Void EKBFEIFLJMN() { }
	// RVA: 0x12afba0 VA: 0x98167ba0
	protected Void CNAPGMNMAEJ() { }
	// RVA: 0x134838c VA: 0x9820038c
	protected Void IEIJFBGINGO() { }
	// RVA: 0x134855c VA: 0x9820055c
	public virtual Void ReviveInitMotionState(Vector3 ACCOJJMKKPM, Quaternion JGOGIAFGCFC, Quaternion OFGMAFLCLEH, UInt32 DDFGMFGPDEK) { }
	// RVA: 0x13481f0 VA: 0x982001f0
	public Void ReviveClearDamageZone() { }
	// RVA: 0x1348d94 VA: 0x98200d94
	protected Void BKNIENBDLJE() { }
	// RVA: 0x1349118 VA: 0x98201118
	public Void OnGetInCatapult(LevelCatapult BBOLNOPGKNE) { }
	// RVA: 0x12aec64 VA: 0x98166c64
	public Void OnGetOutCatapult(LevelCatapult BBOLNOPGKNE) { }
	// RVA: 0x134970c VA: 0x9820170c
	public Void OnGetInCannon(LevelCannon CBGDNCBALOD) { }
	// RVA: 0x134a238 VA: 0x98202238
	public Void TryClearTriggerEntity(UInt32 BBAFHKCBFFN) { }
	// RVA: 0x134a43c VA: 0x9820243c
	public Boolean IsWholeBodyFiring() { }
	// RVA: 0x134a4e0 VA: 0x982024e0
	public Boolean IsInExpansionAbilityMeleeCharging() { }
	// RVA: 0x134a830 VA: 0x98202830
	public Boolean IsInExpansionAbilityMeleeAttack() { }
	// RVA: 0x134ac58 VA: 0x98202c58
	public Boolean IsInExpansionAbilityMeleeAttackSlash() { }
	// RVA: 0x134afa8 VA: 0x98202fa8
	public Boolean IsWholeBodyAttackMoving() { }
	// RVA: 0x134b04c VA: 0x9820304c
	public Single WholeBodyFiringMoveSpeed() { }
	// RVA: 0x134b0f0 VA: 0x982030f0
	public Single GetCurrentFireProgressRate() { }
	// RVA: 0x134b1dc VA: 0x982031dc
	public Void OnGetOutCannon(LevelCannon CBGDNCBALOD) { }
	// RVA: 0x134bb80 VA: 0x98203b80
	public Void OnStartSkyFalling(Vector3 HODJGPBPGDH, UInt32 FDKNILEDMPG) { }
	// RVA: 0x134bf34 VA: 0x98203f34
	public Void OnStartPlatformJumping(Vector3 HODJGPBPGDH, UInt32 FDKNILEDMPG) { }
	// RVA: 0x134c2b0 VA: 0x982042b0
	public Void OnCatapultLaunch() { }
	// RVA: 0x134c894 VA: 0x98204894
	public Void OnStopCatapultFalling() { }
	// RVA: 0x129fa5c VA: 0x98157a5c
	public Boolean IsCatapultFalling() { }
	// RVA: 0x134caa4 VA: 0x98204aa4
	public Void ShowCatapultFallingTailTraceLine() { }
	// RVA: 0x134cccc VA: 0x98204ccc
	public Void RemoveCatapultFallingTailTraceLine() { }
	// RVA: 0x134ce30 VA: 0x98204e30
	public Void PlayChangeClothEffect() { }
	// RVA: 0x134c72c VA: 0x9820472c
	private Void HAHHELIFCJA() { }
	// RVA: 0x134d314 VA: 0x98205314
	private Void AFFFMLKFPFN() { }
	// RVA: 0x134d450 VA: 0x98205450
	public Boolean get_IsGod() { }
	// RVA: 0x134d4a8 VA: 0x982054a8
	private Void JMNEKEJKNOG(Boolean IMGNBGJDAHG) { }
	// RVA: 0x134d508 VA: 0x98205508
	public Void OnGodStateCome(Boolean GHDIEEIHBCK, Single OCKCJAFOINK) { }
	// RVA: 0x12ec62c VA: 0x981a462c
	private Void BFFIFDONEEL() { }
	// RVA: 0x133d240 VA: 0x981f5240
	private Void DIBEAJNLBCO(Boolean JLPFGHIEHGJ) { }
	// RVA: 0x134da44 VA: 0x98205a44
	public GameObject PlayEffect(ResourceID OBMONKFFGGI, String IBGJHGFMNBM) { }
	// RVA: 0x12f7fb0 VA: 0x981affb0
	public GameObject PlayEffect(ResourceID OBMONKFFGGI, Transform ACICLMFFFOA) { }
	// RVA: 0x12f7cb8 VA: 0x981afcb8
	public Void PlayEffectAsync(ResourceID OBMONKFFGGI, Transform ACICLMFFFOA) { }
	// RVA: 0x134dc3c VA: 0x98205c3c
	public Void PlayHitSPEffect() { }
	// RVA: 0x134defc VA: 0x98205efc
	public Void PlayCSBuffScanEnemyEffect() { }
	// RVA: 0x134e184 VA: 0x98206184
	public LevelKnockDownShield GenerateKnockDownShield() { }
	// RVA: 0x134e574 VA: 0x98206574
	public Void PlayDamageBlockEffect(Vector3 AJMAGHAIBLJ) { }
	// RVA: 0x134e854 VA: 0x98206854
	private Void PPEBJKKIJLE(UInt32 LPFMNBCHJPE, Boolean FALMPPMFJFN, Object ECINOMEHBKA) { }
	// RVA: 0x134ed98 VA: 0x98206d98
	public virtual Void UpdatePendingReviveState(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x134ee50 VA: 0x98206e50
	public virtual Boolean UpdateWaitToDestroyPlayer(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12ce4ac VA: 0x981864ac
	protected Void JKHFBGPMNPL(OFJHNKMJNGA CLJGFIOLMAK, UInt32 IEPFELEIMFE) { }
	// RVA: 0x12cba28 VA: 0x98183a28
	protected Void GLOKINIKGFH(OFJHNKMJNGA CLJGFIOLMAK, UInt32 IEPFELEIMFE) { }
	// RVA: 0x134efc4 VA: 0x98206fc4
	protected Void MDDKNBGIGGP(OFJHNKMJNGA CLJGFIOLMAK, UInt32 IEPFELEIMFE, Boolean KEJJJHEBNLF) { }
	// RVA: 0x134f250 VA: 0x98207250
	private Void MLHBFNBLAPI(LevelChair COFMFDFDICP) { }
	// RVA: 0x134f46c VA: 0x9820746c
	public Void OnGetOnChair(LevelChair COFMFDFDICP) { }
	// RVA: 0x134f588 VA: 0x98207588
	public virtual Void OnGetOffChair(LevelChair COFMFDFDICP) { }
	// RVA: 0x134f704 VA: 0x98207704
	protected Void EHKBIKJHIHI(GPGBALKIDJK PHEJDNJONIL) { }
	// RVA: 0x134f778 VA: 0x98207778
	protected Void EIIOFJOMING(GPGBALKIDJK PHEJDNJONIL) { }
	// RVA: 0x134f7ec VA: 0x982077ec
	protected Boolean CBOKAJBOGEK(GPGBALKIDJK PHEJDNJONIL) { }
	// RVA: 0x134f868 VA: 0x98207868
	protected Single LLCLNHIIDOG(GPGBALKIDJK PHEJDNJONIL) { }
	// RVA: 0x134f8dc VA: 0x982078dc
	protected Single FIHCOIOGNOB(GPGBALKIDJK PHEJDNJONIL) { }
	// RVA: 0x12a5f80 VA: 0x9815df80
	protected Void EDOHONPKCMP() { }
	// RVA: 0x134f958 VA: 0x98207958
	protected Void EHNENKLGGEJ() { }
	// RVA: 0x134f9bc VA: 0x982079bc
	public Boolean IsInNoHeadShotState() { }
	// RVA: 0x12a60b8 VA: 0x9815e0b8
	private Void BIGBIJAOIAG() { }
	// RVA: 0x134fa20 VA: 0x98207a20
	public Void RefreshCrouchScatterState() { }
	// RVA: 0x134fbc0 VA: 0x98207bc0
	public Void StopCrouchScatterState() { }
	// RVA: 0x12ef09c VA: 0x981a709c
	private Boolean DFAJGJIJAMC() { }
	// RVA: 0x134fc24 VA: 0x98207c24
	private Boolean NIDOKHKLDAN() { }
	// RVA: 0x12ef114 VA: 0x981a7114
	private Void NOEKBCDOFAF(ref Vector3 KDLAFFALFIN, Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x134fe10 VA: 0x98207e10
	public Void OnCronchToStandOrJump() { }
	// RVA: 0x134fe9c VA: 0x98207e9c
	public Void OnLyingToCrouch() { }
	// RVA: 0x134ff20 VA: 0x98207f20
	private Boolean JOOLEPFCEHO() { }
	// RVA: 0x12a6204 VA: 0x9815e204
	private Void KGMHBIHENDH() { }
	// RVA: 0x134ffbc VA: 0x98207fbc
	public Void RefreshLyingScatterState() { }
	// RVA: 0x135015c VA: 0x9820815c
	public Void StopLyingScatterState() { }
	// RVA: 0x12ef270 VA: 0x981a7270
	private Boolean CKGAABCBKCE() { }
	// RVA: 0x12ef2e8 VA: 0x981a72e8
	private Void NOBGHAPFLAE(ref Vector3 KDLAFFALFIN, Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13501c0 VA: 0x982081c0
	public Boolean GetMeshBounds(ref Bounds LPJBDMAACKB) { }
	// RVA: 0x12a6350 VA: 0x9815e350
	private Void GHLLGIJGBEB() { }
	// RVA: 0x129a6f8 VA: 0x981526f8
	private Void EMNLJIENEBB() { }
	// RVA: 0x1306754 VA: 0x981be754
	private Void OFABAECCNCM() { }
	// RVA: 0x129a098 VA: 0x98152098
	private Void DMCJJEBIJFH() { }
	// RVA: 0x13502d0 VA: 0x982082d0
	private Void GALOPPFGGBA() { }
	// RVA: 0x1350324 VA: 0x98208324
	private Void CFMAIINHIBN() { }
	// RVA: 0x1350378 VA: 0x98208378
	public Void Set1PEffect() { }
	// RVA: 0x1350484 VA: 0x98208484
	public Void Set3PEffect() { }
	// RVA: 0x1350590 VA: 0x98208590
	public Void BombModeRemoveBomb() { }
	// RVA: 0x12bc698 VA: 0x98174698
	private Void BAKBIOHIFPB(LevelEmote ONBDKOPIIHL) { }
	// RVA: 0x12cbd18 VA: 0x98183d18
	private Void PIIAMNGLDJL(LevelEmote ONBDKOPIIHL) { }
	// RVA: 0x1301234 VA: 0x981b9234
	private Void NADCALNFPJA() { }
	// RVA: 0x12d037c VA: 0x9818837c
	private Void LFAGJGBPKDP(BaseLevelObject AIFDEOPLDJM) { }
	// RVA: 0x12cc65c VA: 0x9818465c
	private Void PCLFDJNPPHE() { }
	// RVA: 0x1350af0 VA: 0x98208af0
	public virtual Void ForceUpdateAnimatorUMAChangeCallBack(UMAData AJKBOONEOAB) { }
	// RVA: 0x1350d18 VA: 0x98208d18
	public Void ForceUpdateAnimator() { }
	// RVA: 0x1350e18 VA: 0x98208e18
	public virtual Void CatchAnimComponentPlayAnimID(AnimationID MFNEABEJJCB) { }
	// RVA: 0x1350f74 VA: 0x98208f74
	public virtual Boolean IsIgonreWeaponFireControl() { }
	// RVA: 0x1350fcc VA: 0x98208fcc
	public virtual Dictionary`2 GetGameControlMappingToSkillIndexMap() { }
	// RVA: 0x1351024 VA: 0x98209024
	public virtual Dictionary`2 GetKeyCodeToSkillIndexMap() { }
	// RVA: 0x135107c VA: 0x9820907c
	public virtual Dictionary`2 GetUGCActionMappingToSkillIndexMap() { }
	// RVA: 0x13510d4 VA: 0x982090d4
	public virtual Boolean IsOverrdieFastRunControl() { }
	// RVA: 0x135112c VA: 0x9820912c
	public Void StopUseCurInventoryOnHand() { }
	// RVA: 0x1301cbc VA: 0x981b9cbc
	public Void SetAllPlayerThermalView(Boolean ELOELMEPFCN) { }
	// RVA: 0x13512a8 VA: 0x982092a8
	private Void JLOMEKDFDAN(Dictionary`2 EBMMBMJNCLA, Boolean ELOELMEPFCN) { }
	// RVA: 0x1351bc0 VA: 0x98209bc0
	public Void SetThermalView() { }
	// RVA: 0x12cc5f8 VA: 0x981845f8
	public Boolean JudgeInAttack() { }
	// RVA: 0x1351ff0 VA: 0x98209ff0
	public Boolean JudgeInDefence() { }
	// RVA: 0x135205c VA: 0x9820a05c
	public Void StartCrouching() { }
	// RVA: 0x135260c VA: 0x9820a60c
	public Void StopCrouching() { }
	// RVA: 0x12afd70 VA: 0x98167d70
	private Void LHIAJEPLEDI() { }
	// RVA: 0x129bcf8 VA: 0x98153cf8
	private Void HDKBAOPNBJK() { }
	// RVA: 0x128ecbc VA: 0x98146cbc
	public Void ClearHumanTireIAmIn(Boolean DJIFNJPMLAH, LevelTriggerHumanTire OMGKJGMEJJA) { }
	// RVA: 0x13527d8 VA: 0x9820a7d8
	public virtual Boolean IsIgnorePlayerAudioComponent() { }
	// RVA: 0x1352830 VA: 0x9820a830
	public virtual Boolean IsIgnoreHighFalling() { }
	// RVA: 0x1352888 VA: 0x9820a888
	public virtual Boolean IsNeedAimAssists() { }
	// RVA: 0x135293c VA: 0x9820a93c
	private Boolean LHFDAEJKOCH() { }
	// RVA: 0x1352bbc VA: 0x9820abbc
	public virtual BaseProfileInfo get_Profile() { }
	// RVA: 0x1352c14 VA: 0x9820ac14
	public Void SyncTeleportDoorUseInfo(AODEDBCGKCO LHCHNFGKLHD) { }
	// RVA: 0x1352cb8 VA: 0x9820acb8
	public Void SyncDriftBottleUseState(Boolean MCIEMBENCNG) { }
	// RVA: 0x1352fc0 VA: 0x9820afc0
	public Void SyncSupplyUseState() { }
	// RVA: 0x13532a4 VA: 0x9820b2a4
	public Void RecycleCurrentProp() { }
	// RVA: 0x1353310 VA: 0x9820b310
	public Void ResetSimulationHP() { }
	// RVA: 0x13533f4 VA: 0x9820b3f4
	public Void SetForceMoveVelocity(Vector3 JOGHOHLEJFL) { }
	// RVA: 0x135347c VA: 0x9820b47c
	public Vector3 GetForceMoveVelocity() { }
	// RVA: 0x13534f4 VA: 0x9820b4f4
	public List`1 GetDynamicSkills() { }
	// RVA: 0x13536f0 VA: 0x9820b6f0
	public Boolean IsActiveSkillTakingEffect(String MGIKOKDOGJG) { }
	// RVA: 0x13537e8 VA: 0x9820b7e8
	public JJHIMAEGAPA GetSkillByType(String GEPIPPKAIBK) { }
	// RVA: 0x1353afc VA: 0x9820bafc
	public JJHIMAEGAPA GetSkillById(UInt32 NEEFHHCCNNC) { }
	// RVA: 0x1353d88 VA: 0x9820bd88
	private Dictionary`2 ENFPKEKMFLI() { }
	// RVA: 0x1353e60 VA: 0x9820be60
	public Void SyncVehicleHornAccordingToDistance(Boolean NCJHJOFDMNO, Transform CODBPDFODMD, Transform MCFBKACOPOP, ref GameObject KKABPDKFDBJ, ResourceID MFENCDOADDA) { }
	// RVA: 0x12b32c0 VA: 0x9816b2c0
	public Void ClearHornPool() { }
	// RVA: 0x1354aa4 VA: 0x9820caa4
	public virtual Void ChangeFog(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1354b00 VA: 0x9820cb00
	public Void CheckAndTryGetoffAirTransporter() { }
	// RVA: 0x1354c28 VA: 0x9820cc28
	public Void PlayUseRescureZoneEffect() { }
	// RVA: 0x12b06f8 VA: 0x981686f8
	public Void ClearUseRescureZoneEffect() { }
	// RVA: 0x1354e00 VA: 0x9820ce00
	public Int32 CalKnockDownRemainingTime() { }
	// RVA: 0x1354f08 VA: 0x9820cf08
	public override Boolean CanAssitByWeapon(Player DEKAHNJALPI, GPBDEDFKJNA LPGPKFMGCBG) { }
	// RVA: 0x135524c VA: 0x9820d24c
	public virtual Void OnPlayerTriggerCheckPoint() { }
	// RVA: 0x13552a0 VA: 0x9820d2a0
	public Boolean get_IsOutlineInited() { }
	// RVA: 0x1298d34 VA: 0x98150d34
	private Void MABGFFINNNB(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13552a8 VA: 0x9820d2a8
	public Void SetOutlineVisible(UInt32 EBOJJLIHHCM, Boolean KENDCFNPDCE) { }
	// RVA: 0x13554f8 VA: 0x9820d4f8
	public Void InitOutline(AvatarTrace GCMJDPIGBOL) { }
	// RVA: 0x12add84 VA: 0x98165d84
	private Void DIGJJPLKNFN(Boolean EFOGDLEADEK) { }
	// RVA: 0x12afa38 VA: 0x98167a38
	private Void MAFJJEKJPBG(Boolean EFOGDLEADEK) { }
	// RVA: 0x1355564 VA: 0x9820d564
	public Void SetShader(String HKOPPIFIGDL, IPJMHLGGAIK FJJFAMBPAEG) { }
	// RVA: 0x12999a0 VA: 0x981519a0
	public Void RevertToDefaultShader() { }
	// RVA: 0x1356fd8 VA: 0x9820efd8
	public Void SetRenderQ(Int32 ADMHKKGGFFM) { }
	// RVA: 0x12997d8 VA: 0x981517d8
	public Void RevertToDefaultRenderQ() { }
	// RVA: 0x12fa358 VA: 0x981b2358
	public Boolean IsFullHP() { }
	// RVA: 0x1357790 VA: 0x9820f790
	public Boolean IsFullPermSP() { }
	// RVA: 0x1357968 VA: 0x9820f968
	public Boolean IsFullEP() { }
	// RVA: 0x1357c9c VA: 0x9820fc9c
	public Single GetCurEPRatio() { }
	// RVA: 0x132497c VA: 0x981dc97c
	public Void set_GetOffStropCD(Single IMGNBGJDAHG) { }
	// RVA: 0x13249ec VA: 0x981dc9ec
	public Single get_GetOffStropCD() { }
	// RVA: 0x132677c VA: 0x981de77c
	public Void set_GetOnStropCD(Single IMGNBGJDAHG) { }
	// RVA: 0x13267ec VA: 0x981de7ec
	public Single get_GetOnStropCD() { }
	// RVA: 0x12bcaa8 VA: 0x98174aa8
	protected Void HCCALLOECFC(Collider KODGAANKJBG) { }
	// RVA: 0x12cc284 VA: 0x98184284
	protected Void DEKJHKINGBJ(Collider KODGAANKJBG) { }
	// RVA: 0x132294c VA: 0x981da94c
	public Void ReTriggerLowGravityArea() { }
	// RVA: 0x1357d3c VA: 0x9820fd3c
	public Boolean get_m_IsInLowGravityArea() { }
	// RVA: 0x1357e0c VA: 0x9820fe0c
	public List`1 GetLowGravityAreasIAmIn() { }
	// RVA: 0x1357e64 VA: 0x9820fe64
	public Single get_RisingGravity() { }
	// RVA: 0x1357f8c VA: 0x9820ff8c
	public Single get_FallingGravity() { }
	// RVA: 0x13580b4 VA: 0x982100b4
	public Single get_MaxJumpHeight() { }
	// RVA: 0x1358218 VA: 0x98210218
	public Void PlayVFXJumpInLowGravityArea() { }
	// RVA: 0x1358334 VA: 0x98210334
	public Void StopVFXInLowGravityArea() { }
	// RVA: 0x1358414 VA: 0x98210414
	private Void OBIMBAMKHLC(ResourceID JPFKGCMPLLM, Transform PHLFBBIAEFE, ref GameObject EDOANCAFENC) { }
	// RVA: 0x13586ac VA: 0x982106ac
	private Void IGDKNGFGIKP(ResourceID JPFKGCMPLLM, ref GameObject EDOANCAFENC) { }
	// RVA: 0x135881c VA: 0x9821081c
	public Boolean StopRunSpeedUpSkill() { }
	// RVA: 0x1358964 VA: 0x98210964
	public Boolean WithinRunSpeedUpContinueShootInterval() { }
	// RVA: 0x13589f4 VA: 0x982109f4
	public Boolean WithinInvincibleContinusShootInterval() { }
	// RVA: 0x1358a80 VA: 0x98210a80
	public Void EnterWalking(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF) { }
	// RVA: 0x1358b0c VA: 0x98210b0c
	public Boolean WithinEnterWalkingContinueShootInterval() { }
	// RVA: 0x1358b9c VA: 0x98210b9c
	public Void SavePreparePhaseEndPos() { }
	// RVA: 0x133f124 VA: 0x981f7124
	private Void AFHGMDENCGE(Boolean GIKMGIJCDOP, CBIKNJDAGLO JMEHJCCMLAL) { }
	// RVA: 0x12b2598 VA: 0x9816a598
	private Void EAFLDDIAHPG(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x1358c2c VA: 0x98210c2c
	public Void InfectionOnPlayerBeAttacked() { }
	// RVA: 0x1358d48 VA: 0x98210d48
	public Void PlayChangeToZombieVfx() { }
	// RVA: 0x135908c VA: 0x9821108c
	public Void SetInfectionDefaultVfx() { }
	// RVA: 0x13594ac VA: 0x982114ac
	public Void RefreshHippoCrisisReviveVFX() { }
	// RVA: 0x135963c VA: 0x9821163c
	public virtual Boolean IsCameraUseTargetBackOffset() { }
	// RVA: 0x1359694 VA: 0x98211694
	public virtual Void OnEnterFlightChangeCamera() { }
	// RVA: 0x1359804 VA: 0x98211804
	public virtual Void OnExitFlightChangeCamera() { }
	// RVA: 0x1359918 VA: 0x98211918
	public virtual Boolean IsNeedOfflineInitInventory() { }
	// RVA: 0x1359970 VA: 0x98211970
	public virtual Boolean IsInitNeedEquipSound() { }
	// RVA: 0x13599c8 VA: 0x982119c8
	public Void TapTheBeat() { }
	// RVA: 0x1359ae8 VA: 0x98211ae8
	public Void RequestPlayPartyDance(UInt32 KMIPBIGPDPI, Single JOMKIGFPPGD, Boolean NJEAJOGJPLE) { }
	// RVA: 0x1359d20 VA: 0x98211d20
	private Boolean MIDFMLFGNJM() { }
	// RVA: 0x1359d78 VA: 0x98211d78
	public Void StartPartyGameSoloDanceBattling() { }
	// RVA: 0x1359e0c VA: 0x98211e0c
	public Void EndPartyGameSoloDanceBattling() { }
	// RVA: 0x12d614c VA: 0x9818e14c
	public Boolean IsPlayingDuoEmote() { }
	// RVA: 0x12d5f64 VA: 0x9818df64
	public Boolean IsPlayingMoveEmote() { }
	// RVA: 0x1359ea0 VA: 0x98211ea0
	public Boolean IsPlayingLeadEmote() { }
	// RVA: 0x1359fb8 VA: 0x98211fb8
	public Void StartJumpPadFalling() { }
	// RVA: 0x135a194 VA: 0x98212194
	public Void StopJumpPadFalling() { }
	// RVA: 0x135a3dc VA: 0x982123dc
	public Void OnStartFountainFallingDown() { }
	// RVA: 0x135a584 VA: 0x98212584
	public Void OnUseLevelInstrument() { }
	// RVA: 0x135a6cc VA: 0x982126cc
	public Void OnUseLevelWishingTree() { }
	// RVA: 0x135a814 VA: 0x98212814
	public Void OnUseWaitingCup() { }
	// RVA: 0x135a958 VA: 0x98212958
	public Void UpdatePlayerSpotLight() { }
	// RVA: 0x135a9d8 VA: 0x982129d8
	public override Boolean get_CanBeLockedByAimAssist() { }
	// RVA: 0x135ad74 VA: 0x98212d74
	public Boolean get_PickupItemDisabled() { }
	// RVA: 0x135ae60 VA: 0x98212e60
	public Boolean get_DropItemDisabled() { }
	// RVA: 0x135af4c VA: 0x98212f4c
	public Void ReStartUserController() { }
	// RVA: 0x135b148 VA: 0x98213148
	public virtual Void OnResetServerTime() { }
	// RVA: 0x135b24c VA: 0x9821324c
	public override Boolean get_IsMovableEntity() { }
	// RVA: 0x135b2a4 VA: 0x982132a4
	public Void SyncPlayerAvatar(FJIGOOPIJJD CAHPGKODCHM, Boolean EFDPMACOJFC) { }
	// RVA: 0x13023a4 VA: 0x981ba3a4
	public Boolean EnableFallingSwapWeapon() { }
	// RVA: 0x135b34c VA: 0x9821334c
	private Void KIECEPAGNLL(CJKJKAEMMAO LHCHNFGKLHD, Boolean PJHFCBJGKBF, CBIKNJDAGLO MBEEHHGHBMM) { }
	// RVA: 0x133ce84 VA: 0x981f4e84
	private Void OHHNLNHKGFG(CJKJKAEMMAO LHCHNFGKLHD, Boolean PJHFCBJGKBF, CBIKNJDAGLO MBEEHHGHBMM) { }
	// RVA: 0x135b430 VA: 0x98213430
	private Void PDMDGEKFIEL(CJKJKAEMMAO LHCHNFGKLHD, Boolean PJHFCBJGKBF, MEGPOEEMFFL CIDDIFCNHFE) { }
	// RVA: 0x135b5d8 VA: 0x982135d8
	private Void NIMPHPMHEPC(CJKJKAEMMAO LHCHNFGKLHD, Boolean PJHFCBJGKBF, MEGPOEEMFFL CIDDIFCNHFE) { }
	// RVA: 0x135b6b4 VA: 0x982136b4
	private Void PJOIEFJOHPK(CJKJKAEMMAO LHCHNFGKLHD, Boolean PJHFCBJGKBF, CBIKNJDAGLO MBEEHHGHBMM) { }
	// RVA: 0x135b9d0 VA: 0x982139d0
	private Void NAJKHBNIDEN(CJKJKAEMMAO LHCHNFGKLHD, Boolean PJHFCBJGKBF, CBIKNJDAGLO MBEEHHGHBMM) { }
	// RVA: 0x135bc34 VA: 0x98213c34
	private Void FFCALAMEMIM(CJKJKAEMMAO LHCHNFGKLHD, Boolean PJHFCBJGKBF, CBIKNJDAGLO MBEEHHGHBMM) { }
	// RVA: 0x135bcfc VA: 0x98213cfc
	public Boolean HasActionCollection() { }
	// RVA: 0x135be40 VA: 0x98213e40
	public Int32 get_CurrentUGCAnimationClipType() { }
	// RVA: 0x1298d3c VA: 0x98150d3c
	public Void ClearUGCAniClipOverride() { }
	// RVA: 0x135be98 VA: 0x98213e98
	public Dictionary`2 GetUGCAniClipOverride(Boolean CDHEPLGBMOL, Int32 PMGBACFJIHO) { }
	// RVA: 0x135c03c VA: 0x9821403c
	public Dictionary`2 GetActionCollection() { }
	// RVA: 0x135c470 VA: 0x98214470
	private Boolean DJMNJIHAHDO(UInt32 IDNEFEOPGIF, Dictionary`2 FGADGOCGCDI) { }
	// RVA: 0x135cc14 VA: 0x98214c14
	public static String GetAcitonCollectionResNameSuffix(GPBDEDFKJNA LPGPKFMGCBG, Byte KBBMIAOMMOH) { }
	// RVA: 0x135e4c0 VA: 0x982164c0
	public Void PlayCureActionCollectionEffectInternel(String JPFKGCMPLLM) { }
	// RVA: 0x135ea3c VA: 0x98216a3c
	public Void CureActionCollectionEffectEnd() { }
	// RVA: 0x12e5044 VA: 0x9819d044
	public Void DeleteCureActionCollectionEffect() { }
	// RVA: 0x135ebe8 VA: 0x98216be8
	public Void TryClearInventoryMap3P() { }
	// RVA: 0x135ec9c VA: 0x98216c9c
	public Void RemoveInventoryMap3PByDataID(UInt32 KFBALILGIIG) { }
	// RVA: 0x135ed5c VA: 0x98216d5c
	public Void TryAddInventoryMap3P(UInt32 KFBALILGIIG, UInt32 BLEAICPKPGL) { }
	// RVA: 0x135ee84 VA: 0x98216e84
	public ResourceID GetCureActionSoundRes() { }
	// RVA: 0x135f2e0 VA: 0x982172e0
	public Void PlayCureActionSoundInternel() { }
	// RVA: 0x12e51a8 VA: 0x9819d1a8
	public Void StopCureActionSound() { }
	// RVA: 0x135f4d0 VA: 0x982174d0
	public virtual Void DoEnterGameCache() { }
	// RVA: 0x135fdf4 VA: 0x98217df4
	public virtual Void DoEnterGameCache3P() { }
	// RVA: 0x135fbc4 VA: 0x98217bc4
	private Void JFGHMMLBBOF() { }
	// RVA: 0x136007c VA: 0x9821807c
	public Boolean get_IsInRestrictedArea() { }
	// RVA: 0x133fb90 VA: 0x981f7b90
	public Void AddBurnBuffCnt(Int32 IMGNBGJDAHG) { }
	// RVA: 0x12bb66c VA: 0x9817366c
	public Void AddRestrictedAreaFlag() { }
	// RVA: 0x12cae28 VA: 0x98182e28
	public Void RemoveRestrictedAreaFlag() { }
	// RVA: 0x13600f4 VA: 0x982180f4
	public Void CleanupRestrictedAreaFlag() { }
	// RVA: 0x126ebac VA: 0x98126bac
	public EntityVisualEffectManager GetVisualEffectManager() { }
	// RVA: 0x1360150 VA: 0x98218150
	public Void SetVisualEffectUniqueID(AAKEEAIMIDL FNNBNMIKGBM, UInt32 BBAFHKCBFFN) { }
	// RVA: 0x136027c VA: 0x9821827c
	public UInt32 GetVisualEffectUniqueID(AAKEEAIMIDL FNNBNMIKGBM) { }
	// RVA: 0x136037c VA: 0x9821837c
	public Void CancelOrDetachEntityVisualEffect(AAKEEAIMIDL GFLPKAFFNOL) { }
	// RVA: 0x128f9ac VA: 0x981479ac
	public String UGCEntityID() { }
	// RVA: 0x13605d4 VA: 0x982185d4
	private String COW.GamePlay.IUGCBridgingEntity.UGCArchTypeID() { }
	// RVA: 0x13606fc VA: 0x982186fc
	private Boolean COW.GamePlay.IUGCBridgingEntity.IsStatic() { }
	// RVA: 0x1360754 VA: 0x98218754
	public UGCPlayerRepItem get_PlayerCmpt() { }
	// RVA: 0x13607ac VA: 0x982187ac
	public Single GetSkillBuffWeaponScatterScale() { }
	// RVA: 0x1360b10 VA: 0x98218b10
	public Boolean TreatAs1P() { }
	// RVA: 0x1360d50 VA: 0x98218d50
	public virtual Boolean IsInHGEventTrigger() { }
	// RVA: 0x1360da8 VA: 0x98218da8
	public virtual Void TriggerHGEvent() { }
	// RVA: 0x1360dfc VA: 0x98218dfc
	private Boolean PADLFDPGHLM() { }
	// RVA: 0x131c74c VA: 0x981d474c
	public Void CheckLowGravityAreaAccidentallyClear() { }
	// RVA: 0x1276298 VA: 0x9812e298
	public MGJLFMAMIHJ GetPlayerForceMoveManager() { }
	// RVA: 0x1360f14 VA: 0x98218f14
	public Boolean IgnoreRunOrDashMaxSpeedLimit() { }
	// RVA: 0x1360f74 VA: 0x98218f74
	private Boolean NJGIOJAPJFD() { }
	// RVA: 0x1299df0 VA: 0x98151df0
	public Void StopEmoteSound() { }
	// RVA: 0x1360fe8 VA: 0x98218fe8
	public Void DeActiveWeaponStateMachineOnHand() { }
	// RVA: 0x136108c VA: 0x9821908c
	public Void OnChangeItemOnHand() { }
	// RVA: 0x12ecf18 VA: 0x981a4f18
	public Boolean get_IsLockCameraRotationUpdate() { }
	// RVA: 0x13610e0 VA: 0x982190e0
	public Void set_IsLockCameraRotationUpdate(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12ef444 VA: 0x981a7444
	public Boolean get_IsActSkillForwardFollowAimRot() { }
	// RVA: 0x13610e8 VA: 0x982190e8
	public Void set_IsActSkillForwardFollowAimRot(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13610f0 VA: 0x982190f0
	public Boolean get_IsActSkillFowardFollowMoveDirection() { }
	// RVA: 0x13610f8 VA: 0x982190f8
	public Void set_IsActSkillFowardFollowMoveDirection(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1361100 VA: 0x98219100
	public Boolean get_IsActSkillLockJump() { }
	// RVA: 0x1361108 VA: 0x98219108
	public Void set_IsActSkillLockJump(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1361110 VA: 0x98219110
	public Boolean get_IsActSkillLockMove() { }
	// RVA: 0x1361118 VA: 0x98219118
	public Void set_IsActSkillLockMove(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1361120 VA: 0x98219120
	protected FDMPBIEMHAF OGLJABHCKKA(FDMPBIEMHAF ADHJBCCFHKM, GameObject APOIADLOOAH) { }
	// RVA: 0x13612a0 VA: 0x982192a0
	protected Void MLIOJODPGLK() { }
	// RVA: 0x1361404 VA: 0x98219404
	public virtual Void OnActSkillFinished(KBJIDDDPPOO GEPIPPKAIBK) { }
	// RVA: 0x12d441c VA: 0x9818c41c
	protected Void NNFGLFGBGLJ(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x1361460 VA: 0x98219460
	public virtual Void CastSkillByIndex(Int32 HHLONFLCJBL, Boolean IMGAECDPPCF) { }
	// RVA: 0x1361600 VA: 0x98219600
	public Boolean get_IsRunningActSkill() { }
	// RVA: 0x1361754 VA: 0x98219754
	public Boolean CheckActSkillCanCast(Int32 HHLONFLCJBL) { }
	// RVA: 0x1298164 VA: 0x98150164
	public Void ResetActSkillPlayerLockState() { }
	// RVA: 0x13618b4 VA: 0x982198b4
	public Void ShowSkillVfxEffect(NOAKLBNJKAM DEEGGKFDOKA) { }
	// RVA: 0x1361bd4 VA: 0x98219bd4
	public Void ClearSkillVfxEffect(NOAKLBNJKAM DEEGGKFDOKA) { }
	// RVA: 0x136203c VA: 0x9821a03c
	public Boolean GetIsDampingNoiseBySkill(Int32 CDAKGFIJNBE, Int32 CDLMIMCKICB) { }
	// RVA: 0x1362158 VA: 0x9821a158
	private Void IGGBMJJHPFF() { }
	// RVA: 0x1362628 VA: 0x9821a628
	private Void OMIODDBGEIH(UInt32 LPFMNBCHJPE, Boolean BBFAHFFADIC, Object ECINOMEHBKA) { }
	// RVA: 0x1362be8 VA: 0x9821abe8
	private Void KEIEEMKLAPO() { }
	// RVA: 0x129f004 VA: 0x98157004
	private Void HCPLMEOKPIJ() { }
	// RVA: 0x1362d98 VA: 0x9821ad98
	private Void DHMDJFMMECK() { }
	// RVA: 0x1363268 VA: 0x9821b268
	private Void GNJJMAGKIGB(UInt32 LPFMNBCHJPE, Boolean BBFAHFFADIC, Object ECINOMEHBKA) { }
	// RVA: 0x1361e8c VA: 0x98219e8c
	private Void NJPFPNMFMJL() { }
	// RVA: 0x129f0b8 VA: 0x981570b8
	private Void AMKLHJNFEHI() { }
	// RVA: 0x1363828 VA: 0x9821b828
	public Void OnSanioSkillStateChange(MFMBECGKCNM GLDLCOBLGNF, MFMBECGKCNM JFHIANHLOFM) { }
	// RVA: 0x1363e94 VA: 0x9821be94
	public Void CreateAddIceWallEffect(Vector3 ACCOJJMKKPM) { }
	// RVA: 0x13640ac VA: 0x9821c0ac
	private Void IHIDMKOKCGM(GameObject OMDFNKNJDII) { }
	// RVA: 0x1364218 VA: 0x9821c218
	public Void SetSkillLockFireState(Boolean ADJIJHCAGAN) { }
	// RVA: 0x1364278 VA: 0x9821c278
	public Boolean GetSkillLockFireState() { }
	// RVA: 0x129dd0c VA: 0x98155d0c
	public Boolean IsTransformSkillTakingEffect() { }
	// RVA: 0x135f540 VA: 0x98217540
	public Void TryCacheSkillEffects() { }
	// RVA: 0x12f95e4 VA: 0x981b15e4
	public Void TryCacheSkillEffects3P() { }
	// RVA: 0x12f00c8 VA: 0x981a80c8
	public PFLCPEHBBLN GetActiveSkill(Int32 HHLONFLCJBL, Boolean LAHLECIGJNA) { }
	// RVA: 0x13642d0 VA: 0x9821c2d0
	public Boolean CanUseActiveSkillWhenHighFall(Int32 HHLONFLCJBL) { }
	// RVA: 0x1340c94 VA: 0x981f8c94
	public List`1 get_ActiveSkillList() { }
	// RVA: 0x128c378 VA: 0x98144378
	public PFLCPEHBBLN GetActiveSkillByType(Type PMGBACFJIHO) { }
	// RVA: 0x1364404 VA: 0x9821c404
	public Boolean HasSkill(String GEPIPPKAIBK) { }
	// RVA: 0x136462c VA: 0x9821c62c
	public Boolean HasSkillSkin(String GEPIPPKAIBK) { }
	// RVA: 0x1282664 VA: 0x9813a664
	public ResourceID GetSkillSkinResourceId(Type GEPIPPKAIBK, Int32 KDJBGPNOACO, ResourceID OKDLBBEAAOO) { }
	// RVA: 0x136487c VA: 0x9821c87c
	public PFLCPEHBBLN GetActiveSkillById(UInt32 NEEFHHCCNNC) { }
	// RVA: 0x1362100 VA: 0x9821a100
	public Boolean get_IsHideInMap() { }
	// RVA: 0x1364a94 VA: 0x9821ca94
	public Void SyncActiveSkillStatus(GPBEINJKAFN LHCHNFGKLHD) { }
	// RVA: 0x1364b24 VA: 0x9821cb24
	public ResourceID MonkeyKingTransformResID() { }
	// RVA: 0x1364d0c VA: 0x9821cd0c
	public Void BloodPoolTransformAnimExit() { }
	// RVA: 0x1364e8c VA: 0x9821ce8c
	public Transform GetSkillTransformerParent(EPDJJKGINPC PMGBACFJIHO) { }
	// RVA: 0x13650d0 VA: 0x9821d0d0
	public Void PutOnTransformer(EPDJJKGINPC EMAEDOEHEHO) { }
	// RVA: 0x1365e90 VA: 0x9821de90
	public Vector3 GetSkillTransformerCenter() { }
	// RVA: 0x1365f5c VA: 0x9821df5c
	public Void TakeOffTransformer() { }
	// RVA: 0x129dabc VA: 0x98155abc
	public Void ChangeSkillTransformVisibiliy() { }
	// RVA: 0x1366110 VA: 0x9821e110
	private Boolean PBGJKFCKABP() { }
	// RVA: 0x13557f0 VA: 0x9820d7f0
	private Void FPHPAJKKKHL(String HKOPPIFIGDL, IPJMHLGGAIK FJJFAMBPAEG) { }
	// RVA: 0x13567c0 VA: 0x9820e7c0
	private Void PHMIMPPJCIE() { }
	// RVA: 0x13571e0 VA: 0x9820f1e0
	private Void FIGLCFNFEEH(Int32 ADMHKKGGFFM) { }
	// RVA: 0x1357520 VA: 0x9820f520
	private Void ACONEDCGBBB(Boolean OEAKEKAKMPJ) { }
	// RVA: 0x1365ba0 VA: 0x9821dba0
	public Void SetVisibiliyByTransformer(Boolean NJCMEBMNPJF) { }
	// RVA: 0x1366254 VA: 0x9821e254
	public Void UpdateSkillHideInMap(Boolean FMLAEEMJLKI) { }
	// RVA: 0x13662f4 VA: 0x9821e2f4
	public Void UpdateDetectiveSkillEffect(Boolean ODOEHEHNJOG) { }
	// RVA: 0x1366ce0 VA: 0x9821ece0
	private Void ANOINLJNKDP(UInt32 LPFMNBCHJPE, Boolean BBFAHFFADIC, Object ECINOMEHBKA) { }
	// RVA: 0x13672bc VA: 0x9821f2bc
	public Int32 SetAdditiveEffect(Material HMNKPBLBCOC, Camera IFPMCEFKDEC) { }
	// RVA: 0x1368c00 VA: 0x98220c00
	public Void RemoveAdditiveEffect(Int32 HHLONFLCJBL) { }
	// RVA: 0x1368d04 VA: 0x98220d04
	private Void JLEGFCPBBOA(Int32 HHLONFLCJBL) { }
	// RVA: 0x13693c0 VA: 0x982213c0
	private Void PELIAJPEPAE(Int32 HHLONFLCJBL) { }
	// RVA: 0x1299ba0 VA: 0x98151ba0
	public Void OnEffectDestory() { }
	// RVA: 0x12e52cc VA: 0x9819d2cc
	public Void OnEffectLateUpdate() { }
	// RVA: 0x1369758 VA: 0x98221758
	private Void LOABKBJFFHF() { }
	// RVA: 0x1367acc VA: 0x9821facc
	private Void PCPFCMHHCPL() { }
	// RVA: 0x13697e0 VA: 0x982217e0
	private Void EDFEFJCABOE(UMAData MKKHKCFPBPB) { }
	// RVA: 0x136984c VA: 0x9822184c
	private Void FGCAABJBMEB(UMAData MKKHKCFPBPB) { }
	// RVA: 0x13694c4 VA: 0x982214c4
	private Void OJCLELCFPHG(Int32 HHLONFLCJBL) { }
	// RVA: 0x1367f78 VA: 0x9821ff78
	private Void BDIANNNAMKG(Int32 HHLONFLCJBL) { }
	// RVA: 0x13698bc VA: 0x982218bc
	public Boolean get_IsFallingCanEnterSlide() { }
	// RVA: 0x12981c4 VA: 0x981501c4
	public Void set_IsFallingCanEnterSlide(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13698c4 VA: 0x982218c4
	private Boolean IMNENHAAGBB() { }
	// RVA: 0x12bb2ec VA: 0x981732ec
	private Void DDEJLFLOOAC(Collider KODGAANKJBG) { }
	// RVA: 0x12caab4 VA: 0x98182ab4
	private Void GKCHGLBJEJB(Collider KODGAANKJBG) { }
	// RVA: 0x12bb438 VA: 0x98173438
	private Void ANBPDANODPB(Collider KODGAANKJBG) { }
	// RVA: 0x12cac5c VA: 0x98182c5c
	private Void KBLNLDNAFOI(Collider KODGAANKJBG) { }
	// RVA: 0x136993c VA: 0x9822193c
	public virtual Void DoGetOnSlideTriggerAction() { }
	// RVA: 0x136a090 VA: 0x98222090
	private Void LEAGECPKJLM(Boolean KMLNOHPFAKJ) { }
	// RVA: 0x136a3e0 VA: 0x982223e0
	private Boolean JOIBIINLKIE() { }
	// RVA: 0x136a530 VA: 0x98222530
	private Boolean LHLCKNDJGBD() { }
	// RVA: 0x12d4594 VA: 0x9818c594
	private Void GMDNCMFCMML() { }
	// RVA: 0x12d4bb4 VA: 0x9818cbb4
	private Void PCKFEHNHFLN() { }
	// RVA: 0x136a81c VA: 0x9822281c
	private ArcGenerator MOJJLAOFKBE() { }
	// RVA: 0x136a998 VA: 0x98222998
	private CollisionFlags DBNAMEKJPCH(Vector3 DPKGBLHFPEC) { }
	// RVA: 0x136ab64 VA: 0x98222b64
	private Boolean JBLLCFAOIGO(CollisionFlags HFKHOFBCILF, CollisionFlags JJDFNMOLBAA) { }
	// RVA: 0x136abe4 VA: 0x98222be4
	public ArcGenerator get_CurMoveOnArc() { }
	// RVA: 0x136ac3c VA: 0x98222c3c
	public BezierSlide get_CurBezierSlide() { }
	// RVA: 0x136ac94 VA: 0x98222c94
	private Vector3 PCCADLPIIJC() { }
	// RVA: 0x136ada4 VA: 0x98222da4
	private Vector3 FELHILBKJEI() { }
	// RVA: 0x12981cc VA: 0x981501cc
	private Void JMMHDKIGCBA(Vector3 IMGNBGJDAHG) { }
	// RVA: 0x136adbc VA: 0x98222dbc
	private Vector3 JCNGEBMBHFE() { }
	// RVA: 0x12981d8 VA: 0x981501d8
	private Void GADDENNFLKP(Vector3 IMGNBGJDAHG) { }
	// RVA: 0x136add8 VA: 0x98222dd8
	private Boolean GIDMBDMCCNI() { }
	// RVA: 0x12981e8 VA: 0x981501e8
	private Void PLGJAANJNAC(Boolean IMGNBGJDAHG) { }
	// RVA: 0x136ade0 VA: 0x98222de0
	private FAINJNFLPEE IHAMBGNBONJ() { }
	// RVA: 0x136aea8 VA: 0x98222ea8
	private Void DODDJDAEJEB(Vector3 PBPFHDBMOLA, Vector3 DKGPMJBJJAH) { }
	// RVA: 0x136b190 VA: 0x98223190
	private Void OMBAFBKEOCK(Vector3 PDPBPFMBFMI) { }
	// RVA: 0x136b2a4 VA: 0x982232a4
	private Void FDPGHMLLFMP(Vector3 PDPBPFMBFMI, Vector3 JCJNNLNNNDO, Single OMAFEKBHOAA, Single IEIBDCNFIGL) { }
	// RVA: 0x136b3b4 VA: 0x982233b4
	private Void EJHPMMJMJIA(ArcGenerator CGIGOGGPPAA, Vector3 PBPIIMDCPCL, KCMGGEJLNNO ELMJNNEFHFF, Boolean GBPHKKFPPGG) { }
	// RVA: 0x136a618 VA: 0x98222618
	private Void EJHPMMJMJIA(ArcGenerator CGIGOGGPPAA, Vector3 PBPIIMDCPCL, Vector3 IIBOPFMNPKL) { }
	// RVA: 0x1369e4c VA: 0x98221e4c
	private Void KANEIFEEDLE(BezierSlide PIAHOKGFLON, Vector3 GOJCLLCLPMO, KCMGGEJLNNO ELMJNNEFHFF, Single JKCNIMDGDIB, Boolean GOEJLPEAGCF) { }
	// RVA: 0x136a708 VA: 0x98222708
	private Void KANEIFEEDLE(BezierSlide PIAHOKGFLON, Vector3 PBPIIMDCPCL, Vector3 IIBOPFMNPKL, Single JKCNIMDGDIB) { }
	// RVA: 0x136b56c VA: 0x9822356c
	private Void GCMLFGGMBIG() { }
	// RVA: 0x136b604 VA: 0x98223604
	private Void NBCGPFKBEJN() { }
	// RVA: 0x136b988 VA: 0x98223988
	private Single HDLBIKLCKDM(Single OMAFEKBHOAA) { }
	// RVA: 0x136bea4 VA: 0x98223ea4
	private Void NDEMNHMDDBP() { }
	// RVA: 0x136bd40 VA: 0x98223d40
	private Void HOJNPAGKEKK(MEALBEDNBED MLBDGIHIAEJ) { }
	// RVA: 0x136be28 VA: 0x98223e28
	private Void GFJDHEMJLKB() { }
	// RVA: 0x136b124 VA: 0x98223124
	public Boolean IsArcPathMoveDirClockwise() { }
	// RVA: 0x136c4f8 VA: 0x982244f8
	private Void IPDCFCDFNAK(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12e37fc VA: 0x9819b7fc
	private Void EBCINLKPBJK(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x136d47c VA: 0x9822547c
	private Boolean JCNEPHGDFHP(ArcGenerator DPEAICOAGPO, Single AHBNNEOAMFD, Single OMAFEKBHOAA, Single IEIBDCNFIGL, Boolean MEBKFGCLCLE) { }
	// RVA: 0x136cb14 VA: 0x98224b14
	private Boolean HFCAEEFKGCD(BezierSlide DPEAICOAGPO, Single AHBNNEOAMFD, Single OMAFEKBHOAA, Single IEIBDCNFIGL, Boolean MEBKFGCLCLE) { }
	// RVA: 0x12e3aa8 VA: 0x9819baa8
	private Void PMCKDOGNIPL(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x136ce70 VA: 0x98224e70
	private Void LBIODKMHHKC() { }
	// RVA: 0x136de2c VA: 0x98225e2c
	private Boolean EGJDMHOKOCD(ArcGenerator DPEAICOAGPO, Single AHBNNEOAMFD, Single OMAFEKBHOAA, Single IEIBDCNFIGL) { }
	// RVA: 0x136d8b8 VA: 0x982258b8
	private Boolean HMFDEKBGCEF(BezierSlide DPEAICOAGPO, Single AHBNNEOAMFD, Single OMAFEKBHOAA, Single IEIBDCNFIGL) { }
	// RVA: 0x136e594 VA: 0x98226594
	private Void IONPJOFEBDG() { }
	// RVA: 0x136ca84 VA: 0x98224a84
	public Void LocalFinishArcMove() { }
	// RVA: 0x136e624 VA: 0x98226624
	private Void FIGFBOCEAJB() { }
	// RVA: 0x136e874 VA: 0x98226874
	private Void OIMJHNDLIAC() { }
	// RVA: 0x136e8d4 VA: 0x982268d4
	public Boolean LocalCheckJumpToFinishArcMove() { }
	// RVA: 0x136c9ec VA: 0x982249ec
	public Void LocalMoveEndToFinishArcMove(Vector3 COIBABAHBIF) { }
	// RVA: 0x136eb88 VA: 0x98226b88
	public Void LocalGetOffSlide(Vector3 COIBABAHBIF, Boolean JLPANHCJCPD) { }
	// RVA: 0x136ee7c VA: 0x98226e7c
	public Void LocalUseOffSlideBtn() { }
	// RVA: 0x136f128 VA: 0x98227128
	public Void LocalSwitchSlideMoveDir() { }
	// RVA: 0x136f1f8 VA: 0x982271f8
	private Void BONMPEFPPMA() { }
	// RVA: 0x136f350 VA: 0x98227350
	private Void IGGGBPEEGFC() { }
	// RVA: 0x136f5cc VA: 0x982275cc
	private Void LBJGCCHFDPJ() { }
	// RVA: 0x136c424 VA: 0x98224424
	public Void PlaySlideSpeedLowEffect() { }
	// RVA: 0x136c36c VA: 0x9822436c
	public Void HideSlideSpeedLowEffect() { }
	// RVA: 0x136f4a8 VA: 0x982274a8
	public Void LocalPlaySlideSkateBoardEffect() { }
	// RVA: 0x136c280 VA: 0x98224280
	public Void ChangeSpeedUPState(Boolean JFAABDDAPGC) { }
	// RVA: 0x136c188 VA: 0x98224188
	public Void ChangeSpeedMaxState(Boolean ALAAPKLGDGC) { }
	// RVA: 0x136f9f4 VA: 0x982279f4
	private Void JPLCICAMKJC() { }
	// RVA: 0x136fb84 VA: 0x98227b84
	private Void AHENNEAJGPP() { }
	// RVA: 0x136fcc8 VA: 0x98227cc8
	private Void BFILMILEJFE(Boolean ODOEHEHNJOG) { }
	// RVA: 0x136f6e4 VA: 0x982276e4
	private Void OFOHFEKDHDF(ResourceID JPFKGCMPLLM, Transform ALPABGAGACL) { }
	// RVA: 0x136f8e4 VA: 0x982278e4
	private Void IFFAOJFCIHE(ResourceID JPFKGCMPLLM) { }
	// RVA: 0x136fde8 VA: 0x98227de8
	public Void ClearSlidePlayerEffect() { }
	// RVA: 0x136b874 VA: 0x98223874
	private Void NGKKNMMOOFG() { }
	// RVA: 0x136e760 VA: 0x98226760
	private Void EPAGAFPLLGE() { }
	// RVA: 0x136d1dc VA: 0x982251dc
	private Void HOFFECANIBL() { }
	// RVA: 0x136d380 VA: 0x98225380
	private Void KAAGHBFCNGI() { }
	// RVA: 0x1370080 VA: 0x98228080
	private Void HJAGPBKOBLP() { }
	// RVA: 0x12b05b4 VA: 0x981685b4
	private Void NFEPOGGLNJM() { }
	// RVA: 0x12a5dd8 VA: 0x9815ddd8
	private Void DIHKICALMOP() { }
	// RVA: 0x12f900c VA: 0x981b100c
	public Void PlayAssistantShot(JIHBGIELHHG BEIOJKODJNK) { }
	// RVA: 0x12f9084 VA: 0x981b1084
	public Void ShowEventTriggerMark(HPDHMPCFMFH MNPBIOJNHME) { }
	// RVA: 0x1370224 VA: 0x98228224
	public Void ClearEventTriggerMark(HPDHMPCFMFH MNPBIOJNHME) { }
	// RVA: 0x137029c VA: 0x9822829c
	public Void ShowEventTriggerMark(HPDHMPCFMFH MNPBIOJNHME, Vector3 MLCIHBOHEHE) { }
	// RVA: 0x1370340 VA: 0x98228340
	public Void FlashEventTriggerMark(HPDHMPCFMFH MNPBIOJNHME) { }
	// RVA: 0x13703b8 VA: 0x982283b8
	public Void ShowAssistantMarkItem(DLPJLPIHNCL JKMLNPBCKHM, UInt32 BLNMJPPLIMH, String OADJHFCDPDM, UInt32 BFFPKPKDJCD, Vector3 MLCIHBOHEHE) { }
	// RVA: 0x13705b4 VA: 0x982285b4
	public Void ChangeRemoveSelfMarkEntityTime(Single OMAFEKBHOAA) { }
	// RVA: 0x137062c VA: 0x9822862c
	public Void ShowAssistantMarkForMapMark(Vector3 MLCIHBOHEHE, UInt32 CGCGNJOCEJA, UInt32 KLKLKJKAAAJ) { }
	// RVA: 0x13706e8 VA: 0x982286e8
	public Void RequestMarkEntity(DLPJLPIHNCL JKMLNPBCKHM, UInt32 BLNMJPPLIMH, UInt32 BFFPKPKDJCD, Vector3 MLCIHBOHEHE, Boolean KCBLFIJHOIA) { }
	// RVA: 0x13707bc VA: 0x982287bc
	public Void TryRemoveAssistantMark(DLPJLPIHNCL JKMLNPBCKHM, UInt32 BLNMJPPLIMH, UInt32 BFFPKPKDJCD) { }
	// RVA: 0x13709cc VA: 0x982289cc
	public Void TryPosRemoveAssistantMark(DLPJLPIHNCL JKMLNPBCKHM, UInt32 BLNMJPPLIMH, UInt32 BFFPKPKDJCD) { }
	// RVA: 0x1370bdc VA: 0x98228bdc
	public Boolean CheckMarkItemInfo(DLPJLPIHNCL JKMLNPBCKHM, UInt32 BLNMJPPLIMH, UInt32 BFFPKPKDJCD) { }
	// RVA: 0x1370c88 VA: 0x98228c88
	public Void ClearMarkItemCacheInfo() { }
	// RVA: 0x1370cf4 VA: 0x98228cf4
	public Void RemoveAssistantMark(IHAAMHPPLMG IDNEFEOPGIF, DLPJLPIHNCL JKMLNPBCKHM, UInt32 BLNMJPPLIMH, UInt32 BFFPKPKDJCD) { }
	// RVA: 0x1370ddc VA: 0x98228ddc
	public Void RequestAssistantShot(JIHBGIELHHG DIPOHFNABKH) { }
	// RVA: 0x1370e54 VA: 0x98228e54
	public Void RequestAssistantShot(JIHBGIELHHG DIPOHFNABKH, HPDHMPCFMFH NBODIICEKLJ) { }
	// RVA: 0x1370eec VA: 0x98228eec
	public Void RequestAssistantShot(JIHBGIELHHG DIPOHFNABKH, HPDHMPCFMFH NBODIICEKLJ, Vector3 CEGDIKIDIFF) { }
	// RVA: 0x1370fa0 VA: 0x98228fa0
	public Void RaycastCheckForItemMark(UInt32 ONEDHFJBCMJ, ref BaseLevelObject DHGNNKKOMND, ref Vector3 MEKPPJBENPM) { }
	// RVA: 0x1371a50 VA: 0x98229a50
	public Void RaycastCheckForItemMark(UInt32 ONEDHFJBCMJ, ref NGDMFPNOIOF DHGNNKKOMND, ref Vector3 MEKPPJBENPM) { }
	// RVA: 0x137245c VA: 0x9822a45c
	public Void RaycastCheckForItemMarkWithScreenPos(UInt32 ONEDHFJBCMJ, Vector3 BNDPJDJAFOM, ref BaseLevelObject DHGNNKKOMND, ref Vector3 MEKPPJBENPM) { }
	// RVA: 0x1372b4c VA: 0x9822ab4c
	public Void RaycastCheckForItemMarkWithScreenPos(UInt32 ONEDHFJBCMJ, Vector3 BNDPJDJAFOM, ref NGDMFPNOIOF DHGNNKKOMND, ref Vector3 MEKPPJBENPM) { }
	// RVA: 0x13718d0 VA: 0x982298d0
	private Boolean IICLDAAOBAG() { }
	// RVA: 0x137319c VA: 0x9822b19c
	public Boolean CheckContainerSame(UInt32 JAKHHJFDLKH) { }
	// RVA: 0x137321c VA: 0x9822b21c
	public Single GetMarkItemLastUseTime() { }
	// RVA: 0x12b31c0 VA: 0x9816b1c0
	public Boolean IsVehicleWeaponCanFire() { }
	// RVA: 0x1373290 VA: 0x9822b290
	public Void ShowLocalTeammateKnockDownTriggerMark() { }
	// RVA: 0x13733d4 VA: 0x9822b3d4
	public Void RemoveCurrentPlayerMarkEntityShow() { }
	// RVA: 0x1373440 VA: 0x9822b440
	public Boolean CheckCanRecoverTeamGoalPin() { }
	// RVA: 0x13734b4 VA: 0x9822b4b4
	public String GetPlayerNickName(ref Boolean PDEGCOGICNA) { }
	// RVA: 0x1373678 VA: 0x9822b678
	public Void StartSearchWithReEnter() { }
	// RVA: 0x137387c VA: 0x9822b87c
	public Void StartSearch(BKMCNDDOMDG PMGBACFJIHO, Boolean MHIMDBKBBPE) { }
	// RVA: 0x1373fe8 VA: 0x9822bfe8
	private Boolean FDEKJNJCDAP(BKMCNDDOMDG PMGBACFJIHO) { }
	// RVA: 0x1374194 VA: 0x9822c194
	public Boolean NeedCloseBySettingMode() { }
	// RVA: 0x1374280 VA: 0x9822c280
	private Boolean LNLKLMLGAHC() { }
	// RVA: 0x13743e0 VA: 0x9822c3e0
	public Void OnSearchOnce() { }
	// RVA: 0x137558c VA: 0x9822d58c
	private Boolean ANACIEENNIC(Int32 LEBMLAKBLFN, MNGBAPBBJDC DHEKIOMAHAL) { }
	// RVA: 0x1375030 VA: 0x9822d030
	private Boolean DGPCAFKEEJP(UInt32 DEPJEGCACFI) { }
	// RVA: 0x1375648 VA: 0x9822d648
	public Void SetSkipOnceItemId(UInt32 DEPJEGCACFI) { }
	// RVA: 0x1375308 VA: 0x9822d308
	private Int32 JHLLDOHBLGJ(PFMPPELJECF DEKINBCKHCE, AutoSearchItemDataIDNum NBHPCEFFMNK) { }
	// RVA: 0x13737f8 VA: 0x9822b7f8
	public Void SetStopByPlayer(Boolean BMJIAJKPAKC) { }
	// RVA: 0x12ae070 VA: 0x98166070
	public Void StopSearch(Boolean BMJIAJKPAKC) { }
	// RVA: 0x13750ac VA: 0x9822d0ac
	private Void GJMAIMFFGNO(FKGOPDGDGIJ OEECMJDBDKO, UInt32 DEPJEGCACFI, Vector3 BCDJAINDMAO, UInt32 CJDMCMOODAH, UInt32 JAKHHJFDLKH) { }
	// RVA: 0x13756a8 VA: 0x9822d6a8
	public Boolean get_IsAutoSearching() { }
	// RVA: 0x137570c VA: 0x9822d70c
	public EAvatarModelIngameType get_AvatarModelType() { }
	// RVA: 0x1375764 VA: 0x9822d764
	public AvatarTransformData get_AvaterTransformingData() { }
	// RVA: 0x1375860 VA: 0x9822d860
	private Boolean AILGAMPMDME() { }
	// RVA: 0x1375a54 VA: 0x9822da54
	private Void AOHCPIGFJCF(TransformData NLIHLJFIICP, Boolean CDAODCBMFKF) { }
	// RVA: 0x135f9fc VA: 0x982179fc
	public Void TryCacheTransformCollection() { }
	// RVA: 0x135fed0 VA: 0x98217ed0
	public Void TryCacheTransformCollection3P() { }
	// RVA: 0x1376068 VA: 0x9822e068
	public Void TrySwitchToAvatarTransformer(UInt32 ILHBGNHPAAI, UInt32 EDICHIAPABB) { }
	// RVA: 0x1377c68 VA: 0x9822fc68
	public Void OnLoadAvatarTransfromerOver(GameObject EADKFDKMKEB, Boolean PNDDCFGAABM) { }
	// RVA: 0x1376818 VA: 0x9822e818
	private Void PKFLBAGFEPO(AvatarTransformData OONNCJPMEPO, ResourceID BKJDNEBOJMF, GameObject EADKFDKMKEB) { }
	// RVA: 0x1297b98 VA: 0x9814fb98
	public Void QuitAvatarTransformer() { }
	// RVA: 0x137781c VA: 0x9822f81c
	private Void DPIJPAMCDEJ(UInt32 ILHBGNHPAAI, UInt32 EDICHIAPABB) { }
	// RVA: 0x1378b74 VA: 0x98230b74
	private Void MKIHBMBLAKH() { }
	// RVA: 0x1378c1c VA: 0x98230c1c
	private Void JOFIHBPAJKP() { }
	// RVA: 0x1376644 VA: 0x9822e644
	public Boolean canShowAvatarTransform(AvatarTransformData AJKBOONEOAB) { }
	// RVA: 0x1350b6c VA: 0x98208b6c
	private Void OKDHEBGCLPJ() { }
	// RVA: 0x1378d70 VA: 0x98230d70
	private Void PILAJPJNMPO() { }
	// RVA: 0x1379038 VA: 0x98231038
	private Void KECPMIGFAKD() { }
	// RVA: 0x1379334 VA: 0x98231334
	public override ITransformNode GetTransformNode(String HINJBPEDIAL) { }
	// RVA: 0x12a6730 VA: 0x9815e730
	public Void GetTransformNode(Dictionary`2 HMAOIGAAKJM) { }
	// RVA: 0x12a6690 VA: 0x9815e690
	public Void GetTransformNode(List`1 IDLEOFGPPGB, Dictionary`2 MDAHDIDIJAA) { }
	// RVA: 0x13793b8 VA: 0x982313b8
	public PVEEnergyBallManager get_MyPVEEnergyBallManager() { }
	// RVA: 0x12981f0 VA: 0x981501f0
	public Void set_MyPVEEnergyBallManager(PVEEnergyBallManager IMGNBGJDAHG) { }
	// RVA: 0x133d5d0 VA: 0x981f55d0
	private Void GPJAEHHIAKF(CJKJKAEMMAO LHCHNFGKLHD, CBIKNJDAGLO JMEHJCCMLAL) { }
	// RVA: 0x133d754 VA: 0x981f5754
	private Void IFHCDPDHJHP(CJKJKAEMMAO LHCHNFGKLHD, CBIKNJDAGLO JMEHJCCMLAL) { }
	// RVA: 0x133d8d0 VA: 0x981f58d0
	private Void PEFKADPOIOC(CJKJKAEMMAO LHCHNFGKLHD, CBIKNJDAGLO JMEHJCCMLAL) { }
	// RVA: 0x133da60 VA: 0x981f5a60
	private Void BIIFBHOMCDP(CJKJKAEMMAO LHCHNFGKLHD, CBIKNJDAGLO JMEHJCCMLAL) { }
	// RVA: 0x133f31c VA: 0x981f731c
	private Void HBALONPIHLP(CJKJKAEMMAO LHCHNFGKLHD, CBIKNJDAGLO JMEHJCCMLAL) { }
	// RVA: 0x13793c0 VA: 0x982313c0
	public Dictionary`2 TryGetActiveBuffs() { }
	// RVA: 0x133cc30 VA: 0x981f4c30
	private Void KFCNKDCCOHH(UInt32 FDNPHHLFCKP, Byte IDBOIIPLIAB, Single HDOLNEDLOBK) { }
	// RVA: 0x12eca18 VA: 0x981a4a18
	private Void NBIOJGFFIDC() { }
	// RVA: 0x1379498 VA: 0x98231498
	public Void SyncOwnedDebuffInfo(List`1 DIEEGKDJGFL) { }
	// RVA: 0x133fdd0 VA: 0x981f7dd0
	private Void PMKHOPBIJNF(CJKJKAEMMAO LHCHNFGKLHD) { }
	// RVA: 0x133c490 VA: 0x981f4490
	private Void LHDGJOHCIPA(CBIKNJDAGLO JMEHJCCMLAL, CJKJKAEMMAO LHCHNFGKLHD) { }
	// RVA: 0x12d2454 VA: 0x9818a454
	public Boolean get_IsReadyToClimb() { }
	// RVA: 0x12d2374 VA: 0x9818a374
	public Boolean get_IsInCrossOver() { }
	// RVA: 0x13799d0 VA: 0x982319d0
	public ClimbingTrigger get_CurrentClimbTrigger() { }
	// RVA: 0x1379a28 VA: 0x98231a28
	public Void RequestStartClimb() { }
	// RVA: 0x12ecf20 VA: 0x981a4f20
	public Void UpdateClimbCamera(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x137a5dc VA: 0x982325dc
	public Void UpdateCrossOverJumpTimeAndFallTime(Single FHHNIDDBDNG, Single JMOJNEOBPND) { }
	// RVA: 0x12d2244 VA: 0x9818a244
	public Boolean CheckPhysPose_Climb() { }
	// RVA: 0x137a708 VA: 0x98232708
	public Vector2 GetCrossOverSpeed(Single OPKNJGBDOBB) { }
	// RVA: 0x137aab4 VA: 0x98232ab4
	private Boolean HOEGDFEPCOG(Single OPKNJGBDOBB) { }
	// RVA: 0x137abd0 VA: 0x98232bd0
	public Void RequestEndClimb() { }
	// RVA: 0x137b10c VA: 0x9823310c
	private Dictionary`2 LGLFABGJJDI() { }
	// RVA: 0x137b1e4 VA: 0x982331e4
	public Dictionary`2 GetCurCommonMarkInfos() { }
	// RVA: 0x137b244 VA: 0x98233244
	public Void ClearCommonMark() { }
	// RVA: 0x137b36c VA: 0x9823336c
	public Void RefreshCommonMark(COGOECOBBCN LHCHNFGKLHD) { }
	// RVA: 0x137d57c VA: 0x9823557c
	public Void ClientMarkPlayer(IHAAMHPPLMG FJJENAHKGIP, Boolean COJPAMAEAFM, Byte MNPBIOJNHME) { }
	// RVA: 0x137d0d8 VA: 0x982350d8
	private Void KFCLGJODPHN(Dictionary`2 DIJCHNHOLIF) { }
	// RVA: 0x137e178 VA: 0x98236178
	private Void CIJBKACEAHO(IHAAMHPPLMG BIFFAIEPIND, MNNPJPGBCAO JJANBBKNOHO) { }
	// RVA: 0x137de50 VA: 0x98235e50
	private Void DNKMCAJLEDB(IHAAMHPPLMG BIFFAIEPIND, MNNPJPGBCAO JJANBBKNOHO) { }
	// RVA: 0x137e884 VA: 0x98236884
	public Boolean IsMarkTarget(IHAAMHPPLMG IEAFOKKJJNC) { }
	// RVA: 0x137e99c VA: 0x9823699c
	public Boolean HasMarkerType(IHAAMHPPLMG IEAFOKKJJNC, MNNPJPGBCAO JJANBBKNOHO) { }
	// RVA: 0x137eb40 VA: 0x98236b40
	public Boolean IsScannerMark(IHAAMHPPLMG IEAFOKKJJNC) { }
	// RVA: 0x12d0d4c VA: 0x98188d4c
	public Boolean get_IsCreep() { }
	// RVA: 0x1315bc8 VA: 0x981cdbc8
	public Boolean get_IsDuringCreepSwitch() { }
	// RVA: 0x137ec88 VA: 0x98236c88
	public virtual Boolean RequestCreep() { }
	// RVA: 0x137f110 VA: 0x98237110
	public virtual Boolean RequestUnCreep(FBCAHNCLMDC ELJBADBICJN) { }
	// RVA: 0x127d658 VA: 0x98135658
	protected Void MLGFIGJKNGN() { }
	// RVA: 0x12ee494 VA: 0x981a6494
	protected Single CMFMGFJNJAL() { }
	// RVA: 0x137a3f4 VA: 0x982323f4
	public Void RequestUnSightIfNeed() { }
	// RVA: 0x137f52c VA: 0x9823752c
	public Void RequestBackToSightingIfNeed() { }
	// RVA: 0x137f4b8 VA: 0x982374b8
	public Boolean CanUncreep(Single DGMNDPMPGLL) { }
	// RVA: 0x137f6cc VA: 0x982376cc
	public Boolean CheckCeiling(Single OHOBOOGMABH, Single DGMNDPMPGLL) { }
	// RVA: 0x137fb08 VA: 0x98237b08
	public Boolean CheckDamageHitHead(AHEKHEAHOPP AJKBOONEOAB) { }
	// RVA: 0x137fb84 VA: 0x98237b84
	public Boolean CanUseDamageReviseScaleLimitCount(AHEKHEAHOPP AJKBOONEOAB) { }
	// RVA: 0x137fc9c VA: 0x98237c9c
	public Boolean CheckDamageConditionByHeight(AHEKHEAHOPP AJKBOONEOAB) { }
	// RVA: 0x137feb4 VA: 0x98237eb4
	public Boolean CheckDamageConditionToMovingPlayer(AHEKHEAHOPP AJKBOONEOAB) { }
	// RVA: 0x13801b4 VA: 0x982381b4
	public Boolean CheckDamageConditionAfterHold(AHEKHEAHOPP AJKBOONEOAB) { }
	// RVA: 0x1380288 VA: 0x98238288
	public Boolean CheckDamageConditionAttackGreaterHP(AHEKHEAHOPP AJKBOONEOAB) { }
	// RVA: 0x13804f4 VA: 0x982384f4
	public Boolean CheckDamageConditionToLowHP(AHEKHEAHOPP AJKBOONEOAB) { }
	// RVA: 0x1380778 VA: 0x98238778
	public Boolean CheckPetSkillReduceDamageFromBack(AHEKHEAHOPP AJKBOONEOAB) { }
	// RVA: 0x1380b3c VA: 0x98238b3c
	public Boolean CheckTakeDamageByKnife(AHEKHEAHOPP AJKBOONEOAB) { }
	// RVA: 0x1380ccc VA: 0x98238ccc
	public Boolean CheckTakeDamageFromFront(AHEKHEAHOPP AJKBOONEOAB) { }
	// RVA: 0x13811c8 VA: 0x982391c8
	public Boolean CheckDamageConditionToAIByMelee(AHEKHEAHOPP AJKBOONEOAB) { }
	// RVA: 0x1381298 VA: 0x98239298
	public Boolean CheckDamageConditionToAIByShoot(AHEKHEAHOPP AJKBOONEOAB) { }
	// RVA: 0x1381374 VA: 0x98239374
	public Boolean get_CanDoubleJump() { }
	// RVA: 0x13813e4 VA: 0x982393e4
	public Boolean get_IsWearingValidJumpShoes() { }
	// RVA: 0x1381520 VA: 0x98239520
	public Void ShowDoubleJumpEffect() { }
	// RVA: 0x13816f8 VA: 0x982396f8
	public Void EndDoubleJumpEffect() { }
	// RVA: 0x1381804 VA: 0x98239804
	public AMPGCIMNMBI GetDoubleJumpData() { }
	// RVA: 0x1381930 VA: 0x98239930
	public virtual Boolean RequestStopDoubleJump() { }
	// RVA: 0x1381988 VA: 0x98239988
	public Void DuoEmoteInvite(UInt32 OMPGEJDPOGB) { }
	// RVA: 0x1381e70 VA: 0x98239e70
	public Void DuoEmoteJoin(IHAAMHPPLMG ELNBHCDMCMM) { }
	// RVA: 0x1382010 VA: 0x9823a010
	public Void DuoEmote3PInvite(UInt32 OMPGEJDPOGB, Nullable`1 ACCOJJMKKPM) { }
	// RVA: 0x13822a0 VA: 0x9823a2a0
	private Void EHPFNGJFJHL(UInt32 OMPGEJDPOGB, Nullable`1 ACCOJJMKKPM) { }
	// RVA: 0x1381b34 VA: 0x98239b34
	private Void IIMBMPCOBHJ() { }
	// RVA: 0x12981f8 VA: 0x981501f8
	public Void HideDuoEmoteInvitation() { }
	// RVA: 0x12963e0 VA: 0x9814e3e0
	public Void StopEmote(Boolean CMIKMEPACLF, UInt32 MMEEKAABEBJ) { }
	// RVA: 0x1298524 VA: 0x98150524
	public Void ClearEmoteSoundCollider() { }
	// RVA: 0x13827cc VA: 0x9823a7cc
	public AAKFAPMGNEJ GetExecuteStatus() { }
	// RVA: 0x12ae394 VA: 0x98166394
	public Boolean get_IsExecuting() { }
	// RVA: 0x1382824 VA: 0x9823a824
	public GPBDEDFKJNA get_ExecutionWeapon() { }
	// RVA: 0x138287c VA: 0x9823a87c
	public HBKDJCNCLCE get_ExecuteSkillData() { }
	// RVA: 0x13828d4 VA: 0x9823a8d4
	public Boolean get_HasExecutionKill() { }
	// RVA: 0x138294c VA: 0x9823a94c
	public Boolean get_IsExecuted() { }
	// RVA: 0x13829c4 VA: 0x9823a9c4
	public HBKDJCNCLCE GetExecutionSkillData(UInt32 NEEFHHCCNNC) { }
	// RVA: 0x1382b24 VA: 0x9823ab24
	public UInt32 GetExecutionWeaponSkin() { }
	// RVA: 0x1382bcc VA: 0x9823abcc
	public Void OnExecuteSkillEquipChanged(GPBDEDFKJNA CKLIAOIGBPK, Boolean KAMEOBLABHO) { }
	// RVA: 0x1382cc4 VA: 0x9823acc4
	protected Void HPGGGCGMKPJ() { }
	// RVA: 0x1382e98 VA: 0x9823ae98
	public Boolean IsValidToExecuteTarget(Player FFDHFKIMFDG, Single ELDLMNPCOCO) { }
	// RVA: 0x13833a0 VA: 0x9823b3a0
	public Boolean IsValidToExecuteByPose() { }
	// RVA: 0x138359c VA: 0x9823b59c
	public virtual Boolean RequestExecuteTarget(IHAAMHPPLMG FFDHFKIMFDG) { }
	// RVA: 0x1384568 VA: 0x9823c568
	public Void OnExecuteKill(GLIDOJEEJEL KMIPBIGPDPI) { }
	// RVA: 0x13847d4 VA: 0x9823c7d4
	public Void SetWeaponExecuteStatus(Boolean FJNDHBCJPEJ) { }
	// RVA: 0x1384b30 VA: 0x9823cb30
	public Single GetExecutionCameraFinishLerpTime() { }
	// RVA: 0x1384ba0 VA: 0x9823cba0
	public Void PlayExecuteAnimation() { }
	// RVA: 0x1384d4c VA: 0x9823cd4c
	public Boolean IsExecutionResReady(UInt32 AKJDPFADPGH, ResourceID KAFCGNBCHBC) { }
	// RVA: 0x1383b9c VA: 0x9823bb9c
	public Void OnExecuteStateChanged(Boolean FJNDHBCJPEJ) { }
	// RVA: 0x1385164 VA: 0x9823d164
	protected Boolean BIHDHHEKONM(IHAAMHPPLMG BECFAIOFONM) { }
	// RVA: 0x1385634 VA: 0x9823d634
	public Player GetExecutor() { }
	// RVA: 0x1384f40 VA: 0x9823cf40
	private Boolean OEBNOIMMDFP() { }
	// RVA: 0x138568c VA: 0x9823d68c
	public Void OnBeingExecutedStateChanged(Boolean FJNDHBCJPEJ) { }
	// RVA: 0x1386564 VA: 0x9823e564
	public virtual Boolean RequestStopExecute() { }
	// RVA: 0x12ae518 VA: 0x98166518
	public Void StopExecuteLocalInternal() { }
	// RVA: 0x13865f0 VA: 0x9823e5f0
	public Void ChangeExecutionCameToFollow(Boolean MPBLGIHDNEK) { }
	// RVA: 0x1385314 VA: 0x9823d314
	public static Void ChangeCameTypeFromExecutionSkillToFollow(Player FFDHFKIMFDG, Boolean MPBLGIHDNEK) { }
	// RVA: 0x13844d0 VA: 0x9823c4d0
	public Void OnStartExecutionSkill() { }
	// RVA: 0x1385b3c VA: 0x9823db3c
	private Void MEKAOKNNBGF(HBKDJCNCLCE IMLAGFCFKDJ, ref Transform AFOGJMPHIBN, Transform FENNICGJCDE, Boolean HNIGMKOINBI, Boolean AMFNDIOFOGF) { }
	// RVA: 0x129837c VA: 0x9815037c
	private Void KALLBCDNGNH() { }
	// RVA: 0x13866c4 VA: 0x9823e6c4
	public Transform GetCameraReferenceTransform() { }
	// RVA: 0x127e878 VA: 0x98136878
	public Boolean get_IsFastRunning() { }
	// RVA: 0x13867c4 VA: 0x9823e7c4
	public Boolean get_DashByMovingJoystick() { }
	// RVA: 0x12984f4 VA: 0x981504f4
	public Void set_DashByMovingJoystick(Boolean IMGNBGJDAHG) { }
	// RVA: 0x127f820 VA: 0x98137820
	public Boolean get_IsDuringFastRunSwitching() { }
	// RVA: 0x13867cc VA: 0x9823e7cc
	public Boolean CheckCanRequestFastRun() { }
	// RVA: 0x13869f4 VA: 0x9823e9f4
	public virtual Boolean RequestFastRun() { }
	// RVA: 0x1387198 VA: 0x9823f198
	public virtual Boolean RequestStopFastRun(Boolean CFDIGBCIEON) { }
	// RVA: 0x13873a0 VA: 0x9823f3a0
	public Boolean get_IsInFlightRoam() { }
	// RVA: 0x1387428 VA: 0x9823f428
	public Boolean get_IsInFlightRoamDash() { }
	// RVA: 0x13874dc VA: 0x9823f4dc
	public Boolean get_IsFlightRoamRushEnd() { }
	// RVA: 0x12984fc VA: 0x981504fc
	public Void set_IsInFlightForbiddenTrigger(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1387590 VA: 0x9823f590
	public Boolean get_IsInFlightForbiddenTrigger() { }
	// RVA: 0x1387598 VA: 0x9823f598
	public virtual Void RequestChangeFlightRoamState(Boolean OFEBJECKEBE) { }
	// RVA: 0x13876bc VA: 0x9823f6bc
	public virtual Void SetFlightRoam(Boolean KENDCFNPDCE) { }
	// RVA: 0x1387bf4 VA: 0x9823fbf4
	public virtual Boolean CanFlightRoam() { }
	// RVA: 0x1387d88 VA: 0x9823fd88
	public Void UpdateFlightRoamData(DPFDECGNHFK LHCHNFGKLHD) { }
	// RVA: 0x1387b7c VA: 0x9823fb7c
	public MILCMIMPDMG GetFlightRoamData() { }
	// RVA: 0x1326844 VA: 0x981de844
	public Boolean get_isOnFloatingLand() { }
	// RVA: 0x1387ee4 VA: 0x9823fee4
	public Byte get_floatingLandColorIndex() { }
	// RVA: 0x1387f3c VA: 0x9823ff3c
	public Boolean get_isWaitJoinFloatingLand() { }
	// RVA: 0x1387f94 VA: 0x9823ff94
	public Int32 get_waitFloatingLandTime() { }
	// RVA: 0x1387fec VA: 0x9823ffec
	public Void OnJoinFloatingLand(Byte AFMNOFGKBIN) { }
	// RVA: 0x13882e0 VA: 0x982402e0
	public Void OnLeaveFloatingLand() { }
	// RVA: 0x1388484 VA: 0x98240484
	public Void OnSuccessOnFloatingLand() { }
	// RVA: 0x13887e8 VA: 0x982407e8
	public Void OnWaitJoinFloatingLand(Int32 CAMBDLAPJDA) { }
	// RVA: 0x1388948 VA: 0x98240948
	public Void OnLeaveWaitFloatingLand() { }
	// RVA: 0x1388aa0 VA: 0x98240aa0
	public Void FaceSafeZoneCenter() { }
	// RVA: 0x1388d44 VA: 0x98240d44
	public CCGBDNBALMI get_FoldWingItemWearing() { }
	// RVA: 0x1388d9c VA: 0x98240d9c
	public Void set_FoldWingItemWearing(CCGBDNBALMI IMGNBGJDAHG) { }
	// RVA: 0x1388f54 VA: 0x98240f54
	public Boolean get_IsWearingFoldWing() { }
	// RVA: 0x135ad1c VA: 0x98212d1c
	public FoldWingConfigData get_FoldWingData() { }
	// RVA: 0x1388fb8 VA: 0x98240fb8
	public Boolean IsShowingFoldWingModel() { }
	// RVA: 0x135abb4 VA: 0x98212bb4
	public Boolean IsFoldWingGliding() { }
	// RVA: 0x135ac68 VA: 0x98212c68
	public Boolean IsFoldWingGlideFalling() { }
	// RVA: 0x138908c VA: 0x9824108c
	public Boolean get_IsReadyToGlide() { }
	// RVA: 0x13890e4 VA: 0x982410e4
	public Void set_IsReadyToGlide(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13892a4 VA: 0x982412a4
	public virtual Boolean RequestStopFoldWing() { }
	// RVA: 0x1389338 VA: 0x98241338
	public Void ShowFoldWingModel() { }
	// RVA: 0x13894b8 VA: 0x982414b8
	public Void ShowFoldWingModel(CCGBDNBALMI CMNLNABNDOM) { }
	// RVA: 0x13898ac VA: 0x982418ac
	public Void HideFoldWingModel() { }
	// RVA: 0x1389ab8 VA: 0x98241ab8
	public Void OnStopGliding() { }
	// RVA: 0x1389e5c VA: 0x98241e5c
	public Void OnStartGliding() { }
	// RVA: 0x138a588 VA: 0x98242588
	public Football get_CurFootball() { }
	// RVA: 0x131480c VA: 0x981cc80c
	public Single get_FootballRadius() { }
	// RVA: 0x12847d0 VA: 0x9813c7d0
	public Boolean get_IsFootball() { }
	// RVA: 0x138a5e0 VA: 0x982425e0
	public Void ChangeFootballVerticalSpeed(Single LBMGGMBKAEH) { }
	// RVA: 0x138a658 VA: 0x98242658
	private Boolean PAHAGEKBDOA() { }
	// RVA: 0x12de420 VA: 0x98196420
	private Void MLKEEFAMDIG(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x138aa94 VA: 0x98242a94
	public Boolean IsFootballGrounded() { }
	// RVA: 0x138acc4 VA: 0x98242cc4
	protected virtual Void JEAAMCGGCLM(Vector3 KHDDBHPLJKL) { }
	// RVA: 0x138af30 VA: 0x98242f30
	protected virtual Void MEGDHEJHOGA(Vector3 KHDDBHPLJKL) { }
	// RVA: 0x138a8ec VA: 0x982428ec
	protected Void GPILCDHEFOA() { }
	// RVA: 0x138b390 VA: 0x98243390
	protected virtual Void CHDOIKIIJNO(Single HLADFEKELKI) { }
	// RVA: 0x12aaef8 VA: 0x98162ef8
	public Void DelFootBall() { }
	// RVA: 0x138b60c VA: 0x9824360c
	protected virtual ResourceID INCIGCBAPED() { }
	// RVA: 0x138b724 VA: 0x98243724
	protected virtual Void BHFDLJAPPME() { }
	// RVA: 0x138b778 VA: 0x98243778
	protected virtual Void DGPFFIGIGIN(LevelTriggerFootball IEFAIIONNFC, Boolean MKLKBFHMNBD) { }
	// RVA: 0x138dbd4 VA: 0x98245bd4
	private Void ABGNLFFJOFF() { }
	// RVA: 0x138dd38 VA: 0x98245d38
	protected virtual Void KNEHCDIDKIO() { }
	// RVA: 0x138ed78 VA: 0x98246d78
	protected Void HHNBPEGECMG() { }
	// RVA: 0x138ee08 VA: 0x98246e08
	public Void StopFootball() { }
	// RVA: 0x129e514 VA: 0x98156514
	public Void SetVisibleForFootball(Boolean EDLIFKGBCMD) { }
	// RVA: 0x138db60 VA: 0x98245b60
	private Void HANDJAJCCLN(Vector3 ACCOJJMKKPM) { }
	// RVA: 0x138ee90 VA: 0x98246e90
	public Void OnFootballGoals() { }
	// RVA: 0x138efc8 VA: 0x98246fc8
	public Void ResetPlayerWardrobeForFootball() { }
	// RVA: 0x138f0f0 VA: 0x982470f0
	public Void UpdatePlayerWardrobe(UInt32 EIKCFIDCCMM) { }
	// RVA: 0x138f4f4 VA: 0x982474f4
	public virtual Single GetFootballAdjustAccForward() { }
	// RVA: 0x138f5cc VA: 0x982475cc
	public virtual Single GetFootballAdjustAccRight() { }
	// RVA: 0x138f6a4 VA: 0x982476a4
	public virtual Single GetFootballFadeVelocityXZScale() { }
	// RVA: 0x138f77c VA: 0x9824777c
	protected List`1 OBPOMOGHOCA() { }
	// RVA: 0x138f854 VA: 0x98247854
	public GHCOKFDGCNF get_BeneathFeet() { }
	// RVA: 0x138f9b4 VA: 0x982479b4
	protected Void ANOBCHBEIGJ(GHCOKFDGCNF IMGNBGJDAHG) { }
	// RVA: 0x138fa10 VA: 0x98247a10
	public Void AddBeneathFeet(Collider KODGAANKJBG) { }
	// RVA: 0x138fd48 VA: 0x98247d48
	public Void RemoveBeneathFeet(Collider KODGAANKJBG) { }
	// RVA: 0x138ff00 VA: 0x98247f00
	public Void OnFootstepTriggerEnter(Collider KODGAANKJBG) { }
	// RVA: 0x138ffec VA: 0x98247fec
	public Void OnFootstepTriggerExit(Collider KODGAANKJBG) { }
	// RVA: 0x13900d8 VA: 0x982480d8
	public Boolean CanPlayFPPAccurateFireAnim() { }
	// RVA: 0x13901a0 VA: 0x982481a0
	public Boolean IsFPPControllerMode() { }
	// RVA: 0x1390360 VA: 0x98248360
	private Boolean AMHBJLNPPAA() { }
	// RVA: 0x1390418 VA: 0x98248418
	public Void UpdateFPPFiringTime(Single FCIIKCHDGBA, Single OMAFEKBHOAA) { }
	// RVA: 0x1390ad8 VA: 0x98248ad8
	public Void UpdateFPPWeaponVibrateRotation(Single OMAFEKBHOAA) { }
	// RVA: 0x1391088 VA: 0x98249088
	private Transform ELHFEIDLGOC(Transform PHLFBBIAEFE) { }
	// RVA: 0x1391234 VA: 0x98249234
	public Void ChangeToFirstPersonMode() { }
	// RVA: 0x13925f8 VA: 0x9824a5f8
	public Void ChangeToThirdPersonControllerMode() { }
	// RVA: 0x139266c VA: 0x9824a66c
	public Void ChangeToThirdPersonMode() { }
	// RVA: 0x13933b4 VA: 0x9824b3b4
	public Void UGCChangeToThirdPersonModel() { }
	// RVA: 0x13936c4 VA: 0x9824b6c4
	public Single GetDashSpeedForFPPMode() { }
	// RVA: 0x1314b84 VA: 0x981ccb84
	public Single GetFPPFiringDampRadio() { }
	// RVA: 0x139381c VA: 0x9824b81c
	public Single GetMoveSpeedForFPPMode() { }
	// RVA: 0x1390ea4 VA: 0x98248ea4
	public BBDAMOCFJHI GetMoveAxisDirection() { }
	// RVA: 0x1393a3c VA: 0x9824ba3c
	public Vector3 GetFPPIceWallRealPos(Vector3 ACCOJJMKKPM) { }
	// RVA: 0x129da64 VA: 0x98155a64
	public Player_FPPModel get_PlayerFPPModel() { }
	// RVA: 0x128e3fc VA: 0x981463fc
	public Boolean get_IsFPPMode() { }
	// RVA: 0x13918c4 VA: 0x982498c4
	public Void SwitchToFPPModel() { }
	// RVA: 0x1392c30 VA: 0x9824ac30
	public Void SwitchToDefault() { }
	// RVA: 0x1393c7c VA: 0x9824bc7c
	public Void AddPlayerFPPModel() { }
	// RVA: 0x13943c8 VA: 0x9824c3c8
	public virtual Void SwitchIKTarget() { }
	// RVA: 0x13945a4 VA: 0x9824c5a4
	public virtual Void SetConstantFireLimit() { }
	// RVA: 0x13946ec VA: 0x9824c6ec
	public Void UpdateMountWeapon() { }
	// RVA: 0x13949fc VA: 0x9824c9fc
	public Void SetIKWeight(Single APEDGKHABLH) { }
	// RVA: 0x1394b04 VA: 0x9824cb04
	public Single GetIKWeight() { }
	// RVA: 0x1394c04 VA: 0x9824cc04
	public Void PlayUGC1PAim() { }
	// RVA: 0x1394ca0 VA: 0x9824cca0
	public Void MountFPPWeaponGameObject(GPBDEDFKJNA LPLPBJGAPHK) { }
	// RVA: 0x1301610 VA: 0x981b9610
	public Void OnUGCInhalerVisiblityChange(Boolean PLGKHKHBADL) { }
	// RVA: 0x13953a8 VA: 0x9824d3a8
	public Void PlayUGCInspectorAnim() { }
	// RVA: 0x133cf60 VA: 0x981f4f60
	private Void FJEFIILOMON() { }
	// RVA: 0x13957ec VA: 0x9824d7ec
	public Void PlayFPPLowHpSound() { }
	// RVA: 0x12adc28 VA: 0x98165c28
	private Void LDOEKNDBNDP() { }
	// RVA: 0x1394134 VA: 0x9824c134
	public Void UpdateFPPPlayerOffset() { }
	// RVA: 0x12ec1f8 VA: 0x981a41f8
	private Void DDGPDHDDIIK() { }
	// RVA: 0x12ebf70 VA: 0x981a3f70
	private Void IOHCBPCONAB() { }
	// RVA: 0x12ec0b4 VA: 0x981a40b4
	private Void AHLPLDKCBCK() { }
	// RVA: 0x1395ad0 VA: 0x9824dad0
	public Void SetKingScanVFX(Single LEBOAIEJCPJ) { }
	// RVA: 0x12b12b8 VA: 0x981692b8
	public Void CloseKingScanVFX() { }
	// RVA: 0x1276980 VA: 0x9812e980
	public Void ShowKingClown(Boolean ODOEHEHNJOG) { }
	// RVA: 0x1395d14 VA: 0x9824dd14
	public Void ShowAngelNDemonVfx(Byte HDNAIPBHNOL) { }
	// RVA: 0x139611c VA: 0x9824e11c
	private Boolean NFFKDCJMKJL() { }
	// RVA: 0x139622c VA: 0x9824e22c
	public Boolean HasHealingBulletSkill(Int32 CDAKGFIJNBE, Int32 BJGFGLGCEFC) { }
	// RVA: 0x12fa170 VA: 0x981b2170
	public Boolean HasHealingBulletSkill(OOIPMACFIFL JFPKMOEGDIF) { }
	// RVA: 0x13962f0 VA: 0x9824e2f0
	public Void UpdateIceWallMakerProcess(UInt16 IMGNBGJDAHG) { }
	// RVA: 0x13964c4 VA: 0x9824e4c4
	public Void UpdateIceWallMakerExp(UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13965e8 VA: 0x9824e5e8
	private Void EILHGLADIOK(Int32 DNHNPDIJHCE) { }
	// RVA: 0x12ec8e8 VA: 0x981a48e8
	private Void JGFOHBKDIOL() { }
	// RVA: 0x1396c34 VA: 0x9824ec34
	private Boolean NMJJNMFDDCD() { }
	// RVA: 0x1396e64 VA: 0x9824ee64
	private Void BPGKLOLDCII(Single BGNLOJGJPNM) { }
	// RVA: 0x1396b6c VA: 0x9824eb6c
	private Single GBJKDOCGEFA() { }
	// RVA: 0x1396378 VA: 0x9824e378
	private Void MHEJNFCNEPG(Int32 DNHNPDIJHCE, Boolean MKLKBFHMNBD) { }
	// RVA: 0x1396f50 VA: 0x9824ef50
	private Boolean BFJPEHLJPDM() { }
	// RVA: 0x13970b4 VA: 0x9824f0b4
	public Void OnIceWallCountChange(Int32 BLEAICPKPGL) { }
	// RVA: 0x1397114 VA: 0x9824f114
	public Int32 get_IceWallMakerProcess() { }
	// RVA: 0x139717c VA: 0x9824f17c
	public Int32 get_IceWallMakerExp() { }
	// RVA: 0x13971d4 VA: 0x9824f1d4
	public Int32 get_NewIceWallCount() { }
	// RVA: 0x139722c VA: 0x9824f22c
	public Single get_IceWallMakerChargeMaxModify() { }
	// RVA: 0x139729c VA: 0x9824f29c
	public Void SetUGCIceWallMakerChargeMaxModify(Single IMGNBGJDAHG) { }
	// RVA: 0x1397050 VA: 0x9824f050
	public UInt32 IceWallLimitedCount() { }
	// RVA: 0x1396fc8 VA: 0x9824efc8
	private Single HGNOBJNDHBI() { }
	// RVA: 0x13973e8 VA: 0x9824f3e8
	public Void SyncIceWallMakerParams(Byte BLEAICPKPGL, UInt16 OJGNBJELDEM) { }
	// RVA: 0x12ec528 VA: 0x981a4528
	public Boolean get_IsWearingJetFly() { }
	// RVA: 0x1312c88 VA: 0x981cac88
	public Boolean get_IsInJetFly() { }
	// RVA: 0x1386f44 VA: 0x9823ef44
	public Boolean get_IsInJetFlyDash() { }
	// RVA: 0x13870e4 VA: 0x9823f0e4
	public Boolean get_IsReadyToAdjust() { }
	// RVA: 0x1397484 VA: 0x9824f484
	public CKMBFCELDAO get_CurrentJetPackData() { }
	// RVA: 0x13974dc VA: 0x9824f4dc
	public virtual Boolean RequestStartJetFly() { }
	// RVA: 0x1397780 VA: 0x9824f780
	public virtual Boolean RequestStopJetFly() { }
	// RVA: 0x139781c VA: 0x9824f81c
	public Void ShowJetFlyEffect() { }
	// RVA: 0x1397928 VA: 0x9824f928
	public Void EndJetFlyEffect() { }
	// RVA: 0x1397a34 VA: 0x9824fa34
	public Void PlayJetFlyFlyingSound(ResourceID AHFEGJCBIHK) { }
	// RVA: 0x1397cdc VA: 0x9824fcdc
	public Boolean get_IsWearingMVE() { }
	// RVA: 0x1397e1c VA: 0x9824fe1c
	public MADMMIICBNN get_AimingInfoForVEM() { }
	// RVA: 0x1397e74 VA: 0x9824fe74
	public virtual Boolean RequestUsingVEM() { }
	// RVA: 0x127d1ac VA: 0x981351ac
	public Boolean get_CanMedkitOnMove() { }
	// RVA: 0x1398928 VA: 0x98250928
	public Boolean get_CanPEDOnMove() { }
	// RVA: 0x127d144 VA: 0x98135144
	public Boolean get_IsUsingMedKit() { }
	// RVA: 0x127d3cc VA: 0x981353cc
	public Boolean get_IsUsingPED() { }
	// RVA: 0x13989e0 VA: 0x982509e0
	public Void set_CurrentArrestTarget(Player IMGNBGJDAHG) { }
	// RVA: 0x1398a40 VA: 0x98250a40
	public Player get_CurrentArrestTarget() { }
	// RVA: 0x1398a98 VA: 0x98250a98
	public Single get_LastDoArrestTime() { }
	// RVA: 0x1398af0 VA: 0x98250af0
	public Void set_LastDoArrestTime(Single IMGNBGJDAHG) { }
	// RVA: 0x1398b60 VA: 0x98250b60
	public Single get_DoArrestNeedTime() { }
	// RVA: 0x1398d40 VA: 0x98250d40
	public Single get_LastCallWeaponTime() { }
	// RVA: 0x1398d98 VA: 0x98250d98
	public Void set_LastCallWeaponTime(Single IMGNBGJDAHG) { }
	// RVA: 0x1398e08 VA: 0x98250e08
	public Single get_CallWeaponNeedTime() { }
	// RVA: 0x1398fe8 VA: 0x98250fe8
	public Single get_LastCallVehicleTime() { }
	// RVA: 0x1399040 VA: 0x98251040
	public Void set_LastCallVehicleTime(Single IMGNBGJDAHG) { }
	// RVA: 0x13990b0 VA: 0x982510b0
	public Single get_CallVehicleNeedTime() { }
	// RVA: 0x1399290 VA: 0x98251290
	public Single get_LastCallFlightTime() { }
	// RVA: 0x13992e8 VA: 0x982512e8
	public Void set_LastCallFlightTime(Single IMGNBGJDAHG) { }
	// RVA: 0x1399354 VA: 0x98251354
	public Single get_CallFlightNeedTime() { }
	// RVA: 0x1399534 VA: 0x98251534
	public Boolean get_IsInMetropolisNeutral() { }
	// RVA: 0x139958c VA: 0x9825158c
	public Boolean get_IsInMetropolisPrison() { }
	// RVA: 0x13995e4 VA: 0x982515e4
	public Void ChangeMetropolisClothes(List`1 IGMNKAJACKJ, Boolean GBNNJEPNOJK) { }
	// RVA: 0x1382690 VA: 0x9823a690
	public Void SendMetropolisAddBuffMsg() { }
	// RVA: 0x1399788 VA: 0x98251788
	public HOHOHJMCDGA get_MetroMissionMgr() { }
	// RVA: 0x13997e0 VA: 0x982517e0
	public Void UpdateMetropolisMissionList(List`1 AIMINOJFODF) { }
	// RVA: 0x1399a44 VA: 0x98251a44
	public Void OnPlayerMetropolisZoneTypeChanged(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x1399b5c VA: 0x98251b5c
	private Void HOICLNDCLPL(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x139a24c VA: 0x9825224c
	private Void INJMIPCJLOM(UInt32 ANOEGLMLKAB, UInt32 HEBIEEOLJEF) { }
	// RVA: 0x139a974 VA: 0x98252974
	public Boolean IsInMovePlatform() { }
	// RVA: 0x12f4c3c VA: 0x981acc3c
	public UInt32 get_FootMovePlatfromID() { }
	// RVA: 0x139aa48 VA: 0x98252a48
	public Vector3 get_OffsetPositionToMovePlatform() { }
	// RVA: 0x139aac0 VA: 0x98252ac0
	public Void TryAddPlatformToPendingList(LevelMovePlatform ODDGCOJOBIC) { }
	// RVA: 0x139ac4c VA: 0x98252c4c
	public Void TryClearPendingPlatformList() { }
	// RVA: 0x139ad00 VA: 0x98252d00
	public Void TryRemovePlatformInPendingList(LevelMovePlatform ODDGCOJOBIC) { }
	// RVA: 0x139adc0 VA: 0x98252dc0
	public LevelMovePlatform TryGetPlatformInPendingList(Int32 HHLONFLCJBL) { }
	// RVA: 0x139aec0 VA: 0x98252ec0
	private Boolean GHPPBFNNOIC() { }
	// RVA: 0x12bc20c VA: 0x9817420c
	protected Void KIODAKDIAAM(LevelMovePlatform IOMFFBOHMBP) { }
	// RVA: 0x139b540 VA: 0x98253540
	public Void TryRefreshDirOnPlatform() { }
	// RVA: 0x139b30c VA: 0x9825330c
	protected Void OPBHCGIAAKP() { }
	// RVA: 0x139b62c VA: 0x9825362c
	protected Void GENOMNOEMKE() { }
	// RVA: 0x139b808 VA: 0x98253808
	public Void ForceEnterMovePlatform(LevelMovePlatform ODDGCOJOBIC) { }
	// RVA: 0x131e768 VA: 0x981d6768
	public Void ForceExitMovePlatform() { }
	// RVA: 0x139b124 VA: 0x98253124
	public Boolean get_IsOnZeppelin() { }
	// RVA: 0x139b970 VA: 0x98253970
	protected Boolean BAHMNKAGDNC() { }
	// RVA: 0x12cb2f8 VA: 0x981832f8
	public Void OnExitMovePlatform(LevelMovePlatform IOMFFBOHMBP) { }
	// RVA: 0x12d73a4 VA: 0x9818f3a4
	private Void PNNOPCNHINI(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12d7684 VA: 0x9818f684
	private Void OGBICHKMJAH(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12ef524 VA: 0x981a7524
	private Void NGNDAEMHKCI(Vector3 PHOIEBCMBCF) { }
	// RVA: 0x12b03a0 VA: 0x981683a0
	public Void GetOffMovePlatForm() { }
	// RVA: 0x139bae4 VA: 0x98253ae4
	private Void KHPLAIJJCNL(UInt32 EFFDBJAFKLG, UInt32 HCHCCLLBLLC) { }
	// RVA: 0x139bfa8 VA: 0x98253fa8
	private Void CCINBIHENAE(Boolean ELOELMEPFCN) { }
	// RVA: 0x139c2b8 VA: 0x982542b8
	private Void ENDDODBPIFK(Boolean EFFDBJAFKLG, Boolean HCHCCLLBLLC) { }
	// RVA: 0x1386930 VA: 0x9823e930
	public Boolean IsUsePersonalShop() { }
	// RVA: 0x129a7f4 VA: 0x981527f4
	private Void CAPECDIBHOJ() { }
	// RVA: 0x128d2f8 VA: 0x981452f8
	public KHDMPGBLNCM get_MyPhsXData() { }
	// RVA: 0x139c3ec VA: 0x982543ec
	protected Single CLIAKFJNPAL() { }
	// RVA: 0x139c570 VA: 0x98254570
	protected Single DFIFJMAOCBK() { }
	// RVA: 0x131e670 VA: 0x981d6670
	public Void ForceStopWalking() { }
	// RVA: 0x139c6c4 VA: 0x982546c4
	protected virtual Void OJFOCPGCHAE(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13a0fc4 VA: 0x98258fc4
	public Vector3 get_CenterOffset() { }
	// RVA: 0x139ffd8 VA: 0x98257fd8
	private Boolean JEAAOIMLEFD(Vector3 MLCIHBOHEHE, Vector3 COCOBLKAIMJ, Single IENPBCLGFKM, Int32 JEOIGHEHBGF, out RaycastHit CNJLIOOCLOA) { }
	// RVA: 0x13a0540 VA: 0x98258540
	private Boolean KKEFBGADFHK(Vector3 BCIDJPHHJMJ, Vector3 KCMGNJMNFMG) { }
	// RVA: 0x13a10c0 VA: 0x982590c0
	private Boolean CEOLEINHAIO(Vector3 BCIDJPHHJMJ, Vector3 KCMGNJMNFMG) { }
	// RVA: 0x127c080 VA: 0x98134080
	public Void UpdateFallingPose(Boolean GJMKPCAMBCJ) { }
	// RVA: 0x12dc954 VA: 0x98194954
	private Void LKGHLEJIAJJ(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13a1da0 VA: 0x98259da0
	public Boolean get_EnableAccelerationOnFalling() { }
	// RVA: 0x13a1f40 VA: 0x98259f40
	public Boolean get_FirstFastRunningFall() { }
	// RVA: 0x1298504 VA: 0x98150504
	public Void set_FirstFastRunningFall(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13a1f48 VA: 0x98259f48
	public Boolean get_FirstRunningFall() { }
	// RVA: 0x129850c VA: 0x9815050c
	public Void set_FirstRunningFall(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12d78ec VA: 0x9818f8ec
	private Void GPCIIOBELJM(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13a2258 VA: 0x9825a258
	public Void CheckNeedFakeHeight() { }
	// RVA: 0x13a1f50 VA: 0x98259f50
	private Void FPCENFCMJIK() { }
	// RVA: 0x13a26b8 VA: 0x9825a6b8
	private Void AKIELIHBPKH(Boolean OEKJAAFDBPC) { }
	// RVA: 0x12d9360 VA: 0x98191360
	private Void CLMALNBICBO(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12daa2c VA: 0x98192a2c
	private Void GKEMNJAKAIH(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12dd614 VA: 0x98195614
	protected Void BMNGLBIDCBA(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13a3598 VA: 0x9825b598
	protected Void PMADMDDBEGN(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12e30c0 VA: 0x9819b0c0
	private Void LKFDMMOGNEF(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12e14e0 VA: 0x981994e0
	private Void EBKMBJHNCBF(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13a3f30 VA: 0x9825bf30
	private Void HNCOCCHGBOF(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12e1e5c VA: 0x98199e5c
	private Void LBOKDMMKJPK(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12781e0 VA: 0x981301e0
	private Void CHEKBDJKJCB(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12e00c4 VA: 0x981980c4
	private Void CCNONFDEOOL(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13a4360 VA: 0x9825c360
	protected virtual Void MFNJELADALH(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12e0724 VA: 0x98198724
	private Void NNKKBDALFMM(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12e3c2c VA: 0x9819bc2c
	private Void MFIPNJGLAHK(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13a4b0c VA: 0x9825cb0c
	public Void SimOnFerrisWheel(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13a4b7c VA: 0x9825cb7c
	public Boolean CanOpenParachuting(Single OPKNJGBDOBB) { }
	// RVA: 0x13a4ca4 VA: 0x9825cca4
	public Void EnableSpeedLineEffect(Boolean EBOJJLIHHCM) { }
	// RVA: 0x12dae0c VA: 0x98192e0c
	private Void DFHDEDBLPHB(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x12bba44 VA: 0x98173a44
	private Void DAAANIFHMHM(LevelTriggerFountain DNEICPFHEBL) { }
	// RVA: 0x13a3140 VA: 0x9825b140
	public Void PostParachutingTransformChange(Transform CIDMLLIACLF, Single OMAFEKBHOAA) { }
	// RVA: 0x13a2e44 VA: 0x9825ae44
	private Boolean GCDOMHJEKNP(Vector3 DMAIMAGFNNG, Vector3 LINLCGGKPPL, Single DJCFCEHNOCF, UInt32 ONEDHFJBCMJ) { }
	// RVA: 0x13a4d84 VA: 0x9825cd84
	protected Void LLJNGDEELKF() { }
	// RVA: 0x13a58d8 VA: 0x9825d8d8
	public virtual Boolean IsJumpCanMove() { }
	// RVA: 0x12bcde8 VA: 0x98174de8
	private Void MCCCICMHEAG(LevelJumpPad ELGHNHEBHPK) { }
	// RVA: 0x12f84b8 VA: 0x981b04b8
	public Int32 get_CurHP() { }
	// RVA: 0x12aea34 VA: 0x98166a34
	public Void set_CurHP(Int32 IMGNBGJDAHG) { }
	// RVA: 0x12f8614 VA: 0x981b0614
	public Int32 get_MaxHP() { }
	// RVA: 0x13a5930 VA: 0x9825d930
	public Void set_MaxHP(Int32 IMGNBGJDAHG) { }
	// RVA: 0x13a5a8c VA: 0x9825da8c
	public Int32 get_RemainingCapacity() { }
	// RVA: 0x13579e4 VA: 0x9820f9e4
	public Int32 get_CurEP() { }
	// RVA: 0x13a5be8 VA: 0x9825dbe8
	public Void set_CurEP(Int32 IMGNBGJDAHG) { }
	// RVA: 0x12a6ff8 VA: 0x9815eff8
	public Int32 get_CurAP() { }
	// RVA: 0x13a5d44 VA: 0x9825dd44
	public Void set_CurAP(Int32 IMGNBGJDAHG) { }
	// RVA: 0x13a5ea0 VA: 0x9825dea0
	public Int32 get_MaxAP() { }
	// RVA: 0x12f8770 VA: 0x981b0770
	public Int32 get_CurTempSP() { }
	// RVA: 0x12f88cc VA: 0x981b08cc
	public Void set_CurTempSP(Int32 IMGNBGJDAHG) { }
	// RVA: 0x13a5ff8 VA: 0x9825dff8
	public Int32 get_MaxTempSP() { }
	// RVA: 0x13a6154 VA: 0x9825e154
	public Void set_MaxTempSP(Int32 IMGNBGJDAHG) { }
	// RVA: 0x12f8a28 VA: 0x981b0a28
	public Int32 get_CurPermSP() { }
	// RVA: 0x12f8b84 VA: 0x981b0b84
	public Void set_CurPermSP(Int32 IMGNBGJDAHG) { }
	// RVA: 0x13a62b0 VA: 0x9825e2b0
	public Boolean get_IsRMDEatFull() { }
	// RVA: 0x13a641c VA: 0x9825e41c
	public UInt32 get_SlideGroup() { }
	// RVA: 0x135780c VA: 0x9820f80c
	public Int32 get_MaxPermSP() { }
	// RVA: 0x13a6574 VA: 0x9825e574
	public Void set_MaxPermSP(Int32 IMGNBGJDAHG) { }
	// RVA: 0x130b728 VA: 0x981c3728
	public Int32 get_ReviveCount() { }
	// RVA: 0x13a66d0 VA: 0x9825e6d0
	public Boolean get_UsingRevivePoint() { }
	// RVA: 0x13a6834 VA: 0x9825e834
	public UInt32 get_UsingReivePointID() { }
	// RVA: 0x13a698c VA: 0x9825e98c
	public Int32 get_CurRebornLife() { }
	// RVA: 0x138b21c VA: 0x9824321c
	public Single get_CurFootballRadius() { }
	// RVA: 0x13a6aec VA: 0x9825eaec
	public Int32 get_CurrentDeathCount() { }
	// RVA: 0x1357b40 VA: 0x9820fb40
	public Int32 get_MaxEP() { }
	// RVA: 0x13a6c48 VA: 0x9825ec48
	public Void set_MaxEP(Int32 IMGNBGJDAHG) { }
	// RVA: 0x13a6da4 VA: 0x9825eda4
	public Int32 get_CurCoin() { }
	// RVA: 0x13a6efc VA: 0x9825eefc
	public Int32 get_CoinEarnedCurRound() { }
	// RVA: 0x12fa450 VA: 0x981b2450
	public Boolean get_InWarningZone() { }
	// RVA: 0x13a7058 VA: 0x9825f058
	public Int32 get_FactionId() { }
	// RVA: 0x1358f30 VA: 0x98210f30
	public Int32 get_Identity() { }
	// RVA: 0x13a71b4 VA: 0x9825f1b4
	public Single get_UGCWeaponDamageRate() { }
	// RVA: 0x13a730c VA: 0x9825f30c
	public Int32 get_ODFactionId() { }
	// RVA: 0x13a7468 VA: 0x9825f468
	public INNIMLNIOIA get_Status() { }
	// RVA: 0x13a75c4 VA: 0x9825f5c4
	public Int32 get_OBCount() { }
	// RVA: 0x13a7720 VA: 0x9825f720
	public Boolean get_HasTeammateOB() { }
	// RVA: 0x13a7888 VA: 0x9825f888
	public Int32 get_FriendOBCount() { }
	// RVA: 0x13a79e4 VA: 0x9825f9e4
	public Int32 get_StreamerOBCount() { }
	// RVA: 0x13a7b40 VA: 0x9825fb40
	public Int32 get_KillEnemyToAddSpKillCount() { }
	// RVA: 0x13a7c9c VA: 0x9825fc9c
	public Byte get_LikeCount() { }
	// RVA: 0x13a7df4 VA: 0x9825fdf4
	public ALAHNGGPDIE GetStartFireState() { }
	// RVA: 0x12ce978 VA: 0x98186978
	public Int32 get_CurHype() { }
	// RVA: 0x132c51c VA: 0x981e451c
	public Int32 get_CurHypeLevel() { }
	// RVA: 0x13a7e4c VA: 0x9825fe4c
	public UInt32 get_CurEpicClothLevel() { }
	// RVA: 0x13a7fa4 VA: 0x9825ffa4
	public Boolean IsDragonTaskPlayer() { }
	// RVA: 0x13a7ffc VA: 0x9825fffc
	public Boolean CanSkipragonTask() { }
	// RVA: 0x13a8074 VA: 0x98260074
	public Boolean get_StillChallengeWhenCanSkipDragonTask() { }
	// RVA: 0x1298154 VA: 0x98150154
	public Void set_StillChallengeWhenCanSkipDragonTask(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13a807c VA: 0x9826007c
	public Int32 get_MaxHype() { }
	// RVA: 0x1310d50 VA: 0x981c8d50
	public Int32 get_MaxHypeLevel() { }
	// RVA: 0x13a81d8 VA: 0x982601d8
	public Int32 get_Score() { }
	// RVA: 0x13a8330 VA: 0x98260330
	public Boolean get_LinkActivityFinished() { }
	// RVA: 0x128a9a0 VA: 0x981429a0
	public Int32 get_CurrentTrainingZoneType() { }
	// RVA: 0x13a8494 VA: 0x98260494
	public UInt32 get_TrainingGameQueueIndex() { }
	// RVA: 0x13a85f0 VA: 0x982605f0
	public Int32 get_SelectedEquipSetIndex() { }
	// RVA: 0x13a874c VA: 0x9826074c
	public UInt32 get_AndrewSkillEffectCount() { }
	// RVA: 0x12fa1fc VA: 0x981b21fc
	public Int32 get_HealGunTreatmentDecrease() { }
	// RVA: 0x13a88a4 VA: 0x982608a4
	public UInt32 get_TrainingTokenGainLeft() { }
	// RVA: 0x13a88fc VA: 0x982608fc
	public Boolean get_IsInTrap() { }
	// RVA: 0x13a8abc VA: 0x98260abc
	public Int32 get_StropDashCDEndTime() { }
	// RVA: 0x13a8c14 VA: 0x98260c14
	public UInt32 get_MatchStartBuffDataId() { }
	// RVA: 0x13a8d6c VA: 0x98260d6c
	public UInt32 get_MatchShopBuffDataId() { }
	// RVA: 0x13a8ec4 VA: 0x98260ec4
	public Byte get_ScanEnemyCount() { }
	// RVA: 0x13a901c VA: 0x9826101c
	public Int32 get_PLAYER_INGAME_SHOP_TOKEN() { }
	// RVA: 0x13a9174 VA: 0x98261174
	public Int32 get_BeHurtExpendEpMax() { }
	// RVA: 0x12b37b0 VA: 0x9816b7b0
	public Single get_BeHurtExpendEpValue() { }
	// RVA: 0x13a92d0 VA: 0x982612d0
	public Boolean GetSkillRemoteRescueCanUse() { }
	// RVA: 0x13a9428 VA: 0x98261428
	public UInt32 get_CurLeftFreeAutoReviveNum() { }
	// RVA: 0x13a9480 VA: 0x98261480
	public UInt32 get_CurMaxFreeAutoReviveNum() { }
	// RVA: 0x13a94d8 VA: 0x982614d8
	protected override Int32 GetMaxRepDataCount() { }
	// RVA: 0x13a9530 VA: 0x98261530
	protected override Void OnUserDefineReplicationInfo() { }
	// RVA: 0x12d42c0 VA: 0x9818c2c0
	public MFMBECGKCNM get_PlayerSkillImmortalityState() { }
	// RVA: 0x13b3b2c VA: 0x9826bb2c
	private Void FEKCLGDKIIB(Byte EFFDBJAFKLG, Byte HCHCCLLBLLC) { }
	// RVA: 0x13b3bb4 VA: 0x9826bbb4
	public Int32 get_IceWallMakerLevel() { }
	// RVA: 0x13b3d10 VA: 0x9826bd10
	public Boolean get_IsInBattle() { }
	// RVA: 0x13b3e68 VA: 0x9826be68
	public Boolean get_IsBeingRescued() { }
	// RVA: 0x13b40f4 VA: 0x9826c0f4
	private Void KGKMNDGJOKM(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13b42a4 VA: 0x9826c2a4
	private Void LFIHEPBDIDD(Boolean JGLJDJFHPBO, Boolean DNHNPDIJHCE) { }
	// RVA: 0x13b4314 VA: 0x9826c314
	private Void PGKGHAPIOOH(UInt32 EFFDBJAFKLG, UInt32 HCHCCLLBLLC) { }
	// RVA: 0x13b4394 VA: 0x9826c394
	private Void NOOOKBFLHPC(SByte EFFDBJAFKLG, SByte HCHCCLLBLLC) { }
	// RVA: 0x13b4404 VA: 0x9826c404
	private Void NKIEFJEKKNA(Single EFFDBJAFKLG, Single HCHCCLLBLLC) { }
	// RVA: 0x13b44b8 VA: 0x9826c4b8
	private Void DHBBPLECBLE(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13b4534 VA: 0x9826c534
	private Void HMGGKKNLFGG(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13b46d0 VA: 0x9826c6d0
	private Void HPHCBMHNLFJ(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13b4924 VA: 0x9826c924
	private Void LNIBLMDPOAK(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13b4fdc VA: 0x9826cfdc
	private Void NPKFKAOBLGD(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13b5230 VA: 0x9826d230
	private Void LLLCLIKFEAC(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13b5344 VA: 0x9826d344
	protected override Void OnPRIInitialized() { }
	// RVA: 0x13b56bc VA: 0x9826d6bc
	protected virtual Void HMGIMAFIEAP(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13b5ae0 VA: 0x9826dae0
	protected virtual Void FHGACEMABGD(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13b5ca8 VA: 0x9826dca8
	protected virtual Void MCOGDGHKENF(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13b6084 VA: 0x9826e084
	protected virtual Void JCKCGKBCMMA(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13b616c VA: 0x9826e16c
	protected virtual Void NHCDBMMHFBA(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13987cc VA: 0x982507cc
	public UInt32 get_CurVMEBullet() { }
	// RVA: 0x13b61dc VA: 0x9826e1dc
	public Single get_CurVMEEnergy() { }
	// RVA: 0x13b6350 VA: 0x9826e350
	protected Void BAJBLICMGCA(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13b6620 VA: 0x9826e620
	protected Void AAAAGONMFDE(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13b685c VA: 0x9826e85c
	protected Void FGCHDFOBPMG(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13b6a40 VA: 0x9826ea40
	protected Void MKPOHDADKNG(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13b6c24 VA: 0x9826ec24
	protected Void BLNHLHNCDMH(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13b6e08 VA: 0x9826ee08
	protected Void LBOLEPFIEOG(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13b6f80 VA: 0x9826ef80
	protected virtual Void KLLCNEHDLFP(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13b72f4 VA: 0x9826f2f4
	protected Void KNIPOHOEDBG(SByte JGLJDJFHPBO, SByte DNHNPDIJHCE) { }
	// RVA: 0x13b73a0 VA: 0x9826f3a0
	protected Void GIIHLIKKKNM(SByte JGLJDJFHPBO, SByte DNHNPDIJHCE) { }
	// RVA: 0x13b744c VA: 0x9826f44c
	protected Void AFHKNIFKGHK(SByte JGLJDJFHPBO, SByte DNHNPDIJHCE) { }
	// RVA: 0x13b74f8 VA: 0x9826f4f8
	protected virtual Void MNKMALKKPEA(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13b779c VA: 0x9826f79c
	protected virtual Void JFMCBOHJGIO(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13b7a6c VA: 0x9826fa6c
	protected virtual Void MCAOPJMILLF(UInt64 JGLJDJFHPBO, UInt64 DNHNPDIJHCE) { }
	// RVA: 0x13b83b8 VA: 0x982703b8
	protected Void PHHJDEKKDCO(UInt32 BBAFHKCBFFN, ResourceID DAOHLFEOLEK, GameObject GAHBKGJAHPJ) { }
	// RVA: 0x13b8628 VA: 0x98270628
	protected Void CNFOGOKLNID(UInt32 BBAFHKCBFFN, ResourceID DAOHLFEOLEK, GameObject GAHBKGJAHPJ) { }
	// RVA: 0x13b89c0 VA: 0x982709c0
	protected virtual Void PBMAPMDJCKA(UInt64 JGLJDJFHPBO, UInt64 DNHNPDIJHCE) { }
	// RVA: 0x13b8d24 VA: 0x98270d24
	protected Void BBOIFMGOKCD(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13b8e68 VA: 0x98270e68
	private Void MLLCKJJJEKA(UInt64 AMNHOBCDNBI, UInt64 PDCEEIDIIIG) { }
	// RVA: 0x13b9098 VA: 0x98271098
	private Void BLMCKPFHNAG(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13b9154 VA: 0x98271154
	private Void ODAPPDAMHPC(Boolean JGLJDJFHPBO, Boolean DNHNPDIJHCE) { }
	// RVA: 0x13b92c8 VA: 0x982712c8
	private Void FMMGAMGMOFI(UInt32 EFFDBJAFKLG, UInt32 HCHCCLLBLLC) { }
	// RVA: 0x13b945c VA: 0x9827145c
	private Void JKELFJJEIGO(UInt64 JGLJDJFHPBO, UInt64 DNHNPDIJHCE) { }
	// RVA: 0x13b9630 VA: 0x98271630
	private Void JOFHLFONLFC(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13855c4 VA: 0x9823d5c4
	public Void StopBeingExecuted() { }
	// RVA: 0x1383438 VA: 0x9823b438
	public Boolean IsBeingExecuted() { }
	// RVA: 0x13b96a0 VA: 0x982716a0
	public Void set_ReconnectCombineFlag(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13b9700 VA: 0x98271700
	private Void DNJCLDKLJIB(Boolean IIJMFDCBGAJ, Boolean NPLOJLCFCKO) { }
	// RVA: 0x13b9904 VA: 0x98271904
	private Void HALBBCLENGA(Boolean IIJMFDCBGAJ, Boolean NPLOJLCFCKO) { }
	// RVA: 0x13b99d4 VA: 0x982719d4
	private Void FPIONCICHLB(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13ba454 VA: 0x98272454
	private Void AGMLLEFALEF(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13ba644 VA: 0x98272644
	public Void StopSighting() { }
	// RVA: 0x13b5560 VA: 0x9826d560
	public Int32 GetKillCount() { }
	// RVA: 0x1352a60 VA: 0x9820aa60
	public Int32 GetDeathCount() { }
	// RVA: 0x13ba7b0 VA: 0x982727b0
	public Int32 GetMaxKillStacks() { }
	// RVA: 0x13ba90c VA: 0x9827290c
	public virtual Byte GetFootballGameTeamID() { }
	// RVA: 0x13ba964 VA: 0x98272964
	public virtual Int32 GetFootballGameScore() { }
	// RVA: 0x13ba9bc VA: 0x982729bc
	public virtual Int32 GetFootballGameAssist() { }
	// RVA: 0x13baa14 VA: 0x98272a14
	public Void OnKillCountChanged(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13badc0 VA: 0x98272dc0
	public Void OnPlayerDeadCountChanged(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13bb1c4 VA: 0x982731c4
	public Void OnPlayerAssistCountChanged(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13bb514 VA: 0x98273514
	public Void OnPlayerTotalDamageChanged(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13bb9c4 VA: 0x982739c4
	public Void OnPlayerCurCoinChanged(Int32 JGLJDJFHPBO, Int32 DNHNPDIJHCE) { }
	// RVA: 0x13bc124 VA: 0x98274124
	protected IEnumerator HGIIGEJBPBN(Int32 JGLJDJFHPBO, Int32 DNHNPDIJHCE) { }
	// RVA: 0x13bc23c VA: 0x9827423c
	public Void OnPlayerEarnedCoinChanged(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13bc5a0 VA: 0x982745a0
	public Void OnPlayerFactionIDChanged(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13bce04 VA: 0x98274e04
	public Void OnPlayerSyncMatchStartBuff(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13bcfbc VA: 0x98274fbc
	public Void OnScanEnemyCntChange(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13bd02c VA: 0x9827502c
	private Void DPOMJFMNONG(Int32 JGLJDJFHPBO, Int32 DNHNPDIJHCE) { }
	// RVA: 0x13bd21c VA: 0x9827521c
	public Void OnPlayerIdentityChanged(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13bdc88 VA: 0x98275c88
	public Void OnPlayerODFactionChanged(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13be1bc VA: 0x982761bc
	public UInt32 GetPVEKillCount() { }
	// RVA: 0x13be314 VA: 0x98276314
	public Void OnPlayerPVEKillCountChanged(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13be5d8 VA: 0x982765d8
	public UInt32 GetSelfReviveCount() { }
	// RVA: 0x13be734 VA: 0x98276734
	protected Void JEKAKJKEOLA(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13be994 VA: 0x98276994
	protected Void JOANAOGHDGK(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13beaac VA: 0x98276aac
	protected Void AOMDJBCDKLN(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13bec34 VA: 0x98276c34
	public Void OnPlayerThrowKnifePhaseChanged(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13bee04 VA: 0x98276e04
	public Void OnPlayerMaxHypeChanged(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13beff0 VA: 0x98276ff0
	public Void OnPLayerMaxHypeLevelChanged(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13bf1dc VA: 0x982771dc
	public Void OnPlayerCurHypeChanged(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13bf438 VA: 0x98277438
	public Void OnEscortTimeChanged(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13bf698 VA: 0x98277698
	public Void OnPlayerHypeLevelChanged(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c0834 VA: 0x98278834
	public Void OnPlayerTrainingGameQueueInfoChange(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c0a4c VA: 0x98278a4c
	public Void OnPlayerTrainingZoneTypeIamInChanged(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c0e38 VA: 0x98278e38
	protected virtual Void IKBPCFBMICE() { }
	// RVA: 0x13c0e8c VA: 0x98278e8c
	protected virtual Void PCNPOEKDIOC(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c18c4 VA: 0x982798c4
	protected virtual Void IHLIHKNLNNP(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c19f8 VA: 0x982799f8
	private Void ENAHOGHGLPI(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c1c60 VA: 0x98279c60
	public Int32 get_AssistCount() { }
	// RVA: 0x13c1dbc VA: 0x98279dbc
	public UInt32 get_TotalCaseDamage() { }
	// RVA: 0x13c1f14 VA: 0x98279f14
	public UInt32 get_EscortTime() { }
	// RVA: 0x13c2070 VA: 0x9827a070
	private Void JKOFEGECJBC(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c2144 VA: 0x9827a144
	public ALAHNGGPDIE Get3PFiringStateFromPRI() { }
	// RVA: 0x13c22a0 VA: 0x9827a2a0
	public Boolean get_IsFiringFromPRI() { }
	// RVA: 0x127d4f4 VA: 0x981354f4
	public Boolean get_IsSighting() { }
	// RVA: 0x13c2404 VA: 0x9827a404
	public Void set_IsSighting(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13c259c VA: 0x9827a59c
	private Void FACPADKPPDK(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c27e8 VA: 0x9827a7e8
	private Void KFJOIABFANO(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c2aa8 VA: 0x9827aaa8
	private Void KCMMHGMANHF(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c2c5c VA: 0x9827ac5c
	private Void NFIJCGKDKAJ(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c2f00 VA: 0x9827af00
	private Void OGMDAPMPJPP(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c30b4 VA: 0x9827b0b4
	private Void GMBNIJILJGK(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c3384 VA: 0x9827b384
	private Void CNFHAFINMMM(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13c33f4 VA: 0x9827b3f4
	private Void EGMHJHCJIKF(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c353c VA: 0x9827b53c
	private Void PHCMMIFCEIE(UInt64 JGLJDJFHPBO, UInt64 DNHNPDIJHCE) { }
	// RVA: 0x13c39ec VA: 0x9827b9ec
	private Void PJACIOJONOI(UInt64 JGLJDJFHPBO, UInt64 DNHNPDIJHCE) { }
	// RVA: 0x13c40dc VA: 0x9827c0dc
	private ResourceID PHPHECGOFKL() { }
	// RVA: 0x13c42a0 VA: 0x9827c2a0
	public Boolean ShowHandWeaponHitEffect() { }
	// RVA: 0x13c44dc VA: 0x9827c4dc
	public Void PlayHurt(ResourceID AOOKEOAMFJO, Int32 BOEIBGAABDL) { }
	// RVA: 0x13c4a00 VA: 0x9827ca00
	private Void MCEKCLPNENN(UInt32 LFKHBCOJFLP, ResourceID KNJPONEBDGA, GameObject GAHBKGJAHPJ) { }
	// RVA: 0x13c4ce0 VA: 0x9827cce0
	public Void PlayHeal() { }
	// RVA: 0x13c4f94 VA: 0x9827cf94
	private Void GGKMPOMEIKP(UInt32 LFKHBCOJFLP, ResourceID KNJPONEBDGA, GameObject GAHBKGJAHPJ) { }
	// RVA: 0x13c5274 VA: 0x9827d274
	public Void OnPlayerInRoomChanged(Boolean JGLJDJFHPBO, Boolean DNHNPDIJHCE) { }
	// RVA: 0x13c52e4 VA: 0x9827d2e4
	public Void OnPlayerTrainingTokenChanged(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c5870 VA: 0x9827d870
	public Void OnPlayerMiniGameEffectChanged(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13c5904 VA: 0x9827d904
	public Void OnPlayerAmuseLevelChanged(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c5990 VA: 0x9827d990
	public List`1 MysteryBoxQualityList() { }
	// RVA: 0x13c5a68 VA: 0x9827da68
	public Void OnPlayerMysteryBoxQualityChanged(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c5ce0 VA: 0x9827dce0
	public Void OnPlayerPickedBountyContract(Boolean JGLJDJFHPBO, Boolean DNHNPDIJHCE) { }
	// RVA: 0x13c5e68 VA: 0x9827de68
	public Void OnPlayerPickedMissionBountyContract(UInt64 JGLJDJFHPBO, UInt64 DNHNPDIJHCE) { }
	// RVA: 0x13c6378 VA: 0x9827e378
	public Void OnPlayerAndrewSkillEffectCountChange(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c6550 VA: 0x9827e550
	private Void MINCNDGPJPI(Boolean JGLJDJFHPBO, Boolean DNHNPDIJHCE) { }
	// RVA: 0x13c6710 VA: 0x9827e710
	protected virtual Void GOFCBCOIBAB(Int32 JGLJDJFHPBO, Int32 DNHNPDIJHCE) { }
	// RVA: 0x13c6780 VA: 0x9827e780
	public Single get_PlayerArmorReduceDamageIncrement() { }
	// RVA: 0x13c68d8 VA: 0x9827e8d8
	public Int32 get_LastCheckPointID() { }
	// RVA: 0x13c6a30 VA: 0x9827ea30
	public Int32 get_NextCheckPointID() { }
	// RVA: 0x13c6b88 VA: 0x9827eb88
	private Void LDDPPFOPLCD(Boolean EFFDBJAFKLG, Boolean HCHCCLLBLLC) { }
	// RVA: 0x13c6ce4 VA: 0x9827ece4
	private Void JLGFEJCLGLI(Boolean EFFDBJAFKLG, Boolean HCHCCLLBLLC) { }
	// RVA: 0x13c6f44 VA: 0x9827ef44
	public Boolean get_HasVaultKey() { }
	// RVA: 0x13c709c VA: 0x9827f09c
	private Void IKCPMDELPFN(Boolean EFFDBJAFKLG, Boolean HCHCCLLBLLC) { }
	// RVA: 0x13c7278 VA: 0x9827f278
	private Void CBPGECEEOMN(UInt32 BBAFHKCBFFN, ResourceID DAOHLFEOLEK, GameObject NLNCCOACAFF) { }
	// RVA: 0x1378df8 VA: 0x98230df8
	private Void FDAPCEGALMB(UInt32 CFKMIOCCDFM, UInt32 EDICHIAPABB) { }
	// RVA: 0x13c7458 VA: 0x9827f458
	private Void IOKDMDJLCDL(UInt64 EFFDBJAFKLG, UInt64 HCHCCLLBLLC) { }
	// RVA: 0x13c7564 VA: 0x9827f564
	private Void DFAEGFGIMHG(Single EFFDBJAFKLG, Single HCHCCLLBLLC) { }
	// RVA: 0x13c77f4 VA: 0x9827f7f4
	private Void LOLAMGPCJDE(Single EFFDBJAFKLG, Single HCHCCLLBLLC) { }
	// RVA: 0x13c78a8 VA: 0x9827f8a8
	private Void NFFJDPCCEPC(Single EFFDBJAFKLG, Single HCHCCLLBLLC) { }
	// RVA: 0x13c79e8 VA: 0x9827f9e8
	private Void ILKLJMDNFIG(Byte EFFDBJAFKLG, Byte HCHCCLLBLLC) { }
	// RVA: 0x13c7bb8 VA: 0x9827fbb8
	public Boolean get_IsEnergyStoneBoxOwner() { }
	// RVA: 0x13c7c1c VA: 0x9827fc1c
	public Byte get_EnergyStoneTeamIndex() { }
	// RVA: 0x129815c VA: 0x9815015c
	public Void set_EnergyStoneTeamIndex(Byte IMGNBGJDAHG) { }
	// RVA: 0x13c7c24 VA: 0x9827fc24
	private Void HBACFEAJPEJ(Byte EFFDBJAFKLG, Byte HCHCCLLBLLC) { }
	// RVA: 0x13c7e18 VA: 0x9827fe18
	private Void HHPJHDAJHLK(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13c7ef4 VA: 0x9827fef4
	private Void BKFGBKJIGOH(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c8070 VA: 0x98280070
	private Void NEFJJNGOMEE(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13c8144 VA: 0x98280144
	public Byte get_AutoRevivalState() { }
	// RVA: 0x13c829c VA: 0x9828029c
	public Void OnPlayerCurCapacityChange(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c83f8 VA: 0x982803f8
	public Void OnPlayerExtraCapacityChange(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c849c VA: 0x9828049c
	public Void OnPlayerMaxCapacityChange(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c8604 VA: 0x98280604
	private Void BMLOGHPHHJL(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c8840 VA: 0x98280840
	private Void KGGPFMALOCP() { }
	// RVA: 0x13c8970 VA: 0x98280970
	private Void DMOEHKKNCBP(UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c8af4 VA: 0x98280af4
	private Void DPFHOAFGCGB(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c8c98 VA: 0x98280c98
	private Void OEDBMMBHLHF(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c8e3c VA: 0x98280e3c
	private Void HKBAMBJEFOL(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13c8fe0 VA: 0x98280fe0
	private Void KHHCHEMCAEP(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c9184 VA: 0x98281184
	public Int32 get_CurMetroArrestCount() { }
	// RVA: 0x13c92dc VA: 0x982812dc
	public Void OnPlayerMetroArrestChanged(Int32 JGLJDJFHPBO, Int32 DNHNPDIJHCE) { }
	// RVA: 0x13c9528 VA: 0x98281528
	public Void OnSpecialCSBattleLevel_LevelChange(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c96cc VA: 0x982816cc
	public Void OnSpecialCSBattleLevel_ExpChange(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13c9870 VA: 0x98281870
	public Byte get_BattleLevelPlayerLevel() { }
	// RVA: 0x13c99c8 VA: 0x982819c8
	public UInt16 get_BattleLevelPlayerExp() { }
	// RVA: 0x13c9b20 VA: 0x98281b20
	public Void OnBattleStyleLevelChange(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13c9d9c VA: 0x98281d9c
	public Void OnBattleStyleExpChange(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13ca004 VA: 0x98282004
	public Boolean get_HaveBoughtInPersonalShop() { }
	// RVA: 0x13ca15c VA: 0x9828215c
	public Boolean get_IsGameGlobalMissionKing() { }
	// RVA: 0x13ca2b4 VA: 0x982822b4
	public Void OnGameGlobalMissionKingChanged(Boolean JGLJDJFHPBO, Boolean DNHNPDIJHCE) { }
	// RVA: 0x13ca694 VA: 0x98282694
	public Void OnPlayerIsRescuredStateChanged(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13ca99c VA: 0x9828299c
	private Void KKOOMACOGAG(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13cab88 VA: 0x98282b88
	public Byte get_PersonaState() { }
	// RVA: 0x13cace0 VA: 0x98282ce0
	public Byte get_BattleStylePlayerLevel() { }
	// RVA: 0x13cae38 VA: 0x98282e38
	public UInt16 get_BattleStylePlayerExp() { }
	// RVA: 0x13caf90 VA: 0x98282f90
	public Byte get_AngelNDemonIdentity() { }
	// RVA: 0x13cb0e8 VA: 0x982830e8
	private Void OKHFBAECCAC(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x1390208 VA: 0x98248208
	public Byte get_ControllerMode() { }
	// RVA: 0x13cb178 VA: 0x98283178
	private Void BKLCHHKMOBC(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x13cb21c VA: 0x9828321c
	private Void JDEOPDGCEBD(Boolean JGLJDJFHPBO, Boolean DNHNPDIJHCE) { }
	// RVA: 0x13cb45c VA: 0x9828345c
	private Void NHPDEAPNEGB(UInt16 JGLJDJFHPBO, UInt16 DNHNPDIJHCE) { }
	// RVA: 0x13cbcc8 VA: 0x98283cc8
	private Void PBOJKIBHHID(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x1316338 VA: 0x981ce338
	public UInt32 get_BooyahBountyCoin() { }
	// RVA: 0x13cbdec VA: 0x98283dec
	private Void IFAKMIMJNDJ(UInt64 EFFDBJAFKLG, UInt64 HCHCCLLBLLC) { }
	// RVA: 0x13cc030 VA: 0x98284030
	public UInt32 get_CSRefreshShopRefreshCount() { }
	// RVA: 0x13cc188 VA: 0x98284188
	private Void AJAHJNIDAJE(UInt32 EFFDBJAFKLG, UInt32 HCHCCLLBLLC) { }
	// RVA: 0x13cc3e0 VA: 0x982843e0
	public UInt64 GetIceWallModuelStartTime() { }
	// RVA: 0x13cc53c VA: 0x9828453c
	private Void PGCILCBFKKM(UInt64 JGLJDJFHPBO, UInt64 DNHNPDIJHCE) { }
	// RVA: 0x13cc6a0 VA: 0x982846a0
	private Void PCOPNDPHJAM(Boolean JGLJDJFHPBO, Boolean DNHNPDIJHCE) { }
	// RVA: 0x13cca00 VA: 0x98284a00
	private Void KPKLNJENBBE(Boolean JGLJDJFHPBO, Boolean DNHNPDIJHCE) { }
	// RVA: 0x13ccb54 VA: 0x98284b54
	private Void JHOBPNCCAOC(UInt64 JGLJDJFHPBO, UInt64 DNHNPDIJHCE) { }
	// RVA: 0x13ccd60 VA: 0x98284d60
	public UInt64 get_GetReviveZoneIndex() { }
	// RVA: 0x131a344 VA: 0x981d2344
	public Boolean get_HasGetBountyBoxShopItem() { }
	// RVA: 0x12bc950 VA: 0x98174950
	public Boolean get_NBEatedNoodle() { }
	// RVA: 0x13ccebc VA: 0x98284ebc
	public Int32 get_CSTeamIndex() { }
	// RVA: 0x13cd014 VA: 0x98285014
	public Void OnSnowmanModeSnowBallSpeedUpChange(Byte JGLJDJFHPBO, Byte DNHNPDIJHCE) { }
	// RVA: 0x138a778 VA: 0x98242778
	public Boolean IsSnowmanModeSnowBallSpeedUp() { }
	// RVA: 0x13cd304 VA: 0x98285304
	public Void OnWeRunRetreatTimeChanged(Single JGLJDJFHPBO, Single DNHNPDIJHCE) { }
	// RVA: 0x13cd4dc VA: 0x982854dc
	public Void OnCurSafeBoxMaxCapacityChanged(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13cd650 VA: 0x98285650
	public Void OnSafeBoxCapacityChanged(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13cd7c4 VA: 0x982857c4
	public Void OnBringIntoInvPriceChanged(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13cd834 VA: 0x98285834
	public Void OnSlideGroup(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13cdb0c VA: 0x98285b0c
	public UInt32 get_HippoCrisisBringIntoInvPrice() { }
	// RVA: 0x13cdc64 VA: 0x98285c64
	public Void OnAllInvPriceChanged(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13cdcd4 VA: 0x98285cd4
	public UInt32 get_HippoCrisisAllInvPrice() { }
	// RVA: 0x13cde2c VA: 0x98285e2c
	public Void OnHippoCrisisInComeScoreChanged(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13ce0e4 VA: 0x982860e4
	public UInt32 get_HippoCrisisInComeScore() { }
	// RVA: 0x13ce23c VA: 0x9828623c
	public Int32 get_HippoCrisisMaxReviveCount() { }
	// RVA: 0x13ce398 VA: 0x98286398
	private Void FBFBNGKMFGB(UInt32 JGLJDJFHPBO, UInt32 DNHNPDIJHCE) { }
	// RVA: 0x13ce4f4 VA: 0x982864f4
	public UInt32 get_CurrentUsingTechBuildPoint() { }
	// RVA: 0x13a1ad0 VA: 0x98259ad0
	public Boolean get_IsInSAPFlyJumping() { }
	// RVA: 0x1298514 VA: 0x98150514
	public Void set_IsInSAPFlyJumping(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13ce64c VA: 0x9828664c
	public Void StartSAPJumpBeforeGlid() { }
	// RVA: 0x13a1b4c VA: 0x98259b4c
	public Void StartSAPGlid() { }
	// RVA: 0x13ce92c VA: 0x9828692c
	public Boolean get_IsWearingSkateboard() { }
	// RVA: 0x1286e04 VA: 0x9813ee04
	public Boolean get_IsSkateboarding() { }
	// RVA: 0x12ec438 VA: 0x981a4438
	public Boolean get_IsSkateboardDashing() { }
	// RVA: 0x12ec4b0 VA: 0x981a44b0
	public Boolean get_IsSkateboardJumping() { }
	// RVA: 0x13ce9ec VA: 0x982869ec
	public VehicleDriverCameraTarget get_SkateBoardCameraTarget() { }
	// RVA: 0x13cea44 VA: 0x98286a44
	public Vector3 GetSyncStatePos() { }
	// RVA: 0x13cec58 VA: 0x98286c58
	protected BCIGOPJHDPB LAFJCGBFGEM() { }
	// RVA: 0x129851c VA: 0x9815051c
	protected Void GENEBNJGBBP(BCIGOPJHDPB IMGNBGJDAHG) { }
	// RVA: 0x13cec60 VA: 0x98286c60
	public Boolean IsUGCSkateBoarding() { }
	// RVA: 0x13cecc4 VA: 0x98286cc4
	protected Boolean HGFMKLPHFKM() { }
	// RVA: 0x13cee2c VA: 0x98286e2c
	public Void InitSkateboardCd(Single ONOBDJGMALA, Single OLBAMGCGOLF) { }
	// RVA: 0x13cef4c VA: 0x98286f4c
	private Void MBPOFDIKJDM() { }
	// RVA: 0x13cf0f4 VA: 0x982870f4
	public Single GetSkateboardCdSecs() { }
	// RVA: 0x13cf158 VA: 0x98287158
	public Single GetSkateboardRemainingCdSecs() { }
	// RVA: 0x13cf1bc VA: 0x982871bc
	private Void LBAPINBOAIB() { }
	// RVA: 0x13cf230 VA: 0x98287230
	public Void RequestStartSkateboarding() { }
	// RVA: 0x13cf624 VA: 0x98287624
	private Boolean LHPADLLHFGG() { }
	// RVA: 0x13d041c VA: 0x9828841c
	public Void RequestStopSkateboarding() { }
	// RVA: 0x139af9c VA: 0x98252f9c
	public Void RequestStopSkateboarding(PJGHNHFMADO OMNGGLFFMGM) { }
	// RVA: 0x13d0294 VA: 0x98288294
	public Void OnGetOnSkateboard(PJGHNHFMADO OMNGGLFFMGM) { }
	// RVA: 0x13d0480 VA: 0x98288480
	public Void OnGetOffSkateboard(PJGHNHFMADO OMNGGLFFMGM) { }
	// RVA: 0x13d06fc VA: 0x982886fc
	protected virtual Void GOPCHBGONHM() { }
	// RVA: 0x13d24a0 VA: 0x9828a4a0
	protected virtual Void CHHIDDHMGHA() { }
	// RVA: 0x13d0d1c VA: 0x98288d1c
	private Void IIECPBIFBCH() { }
	// RVA: 0x13d275c VA: 0x9828a75c
	private Void MAGMHPMKLDI() { }
	// RVA: 0x13d1974 VA: 0x98289974
	protected Void GGOJFIHAKJN(Boolean ELOELMEPFCN) { }
	// RVA: 0x13d2a80 VA: 0x9828aa80
	protected Void GGOJFIHAKJN(Boolean ELOELMEPFCN, Boolean DKPFDPJILDG) { }
	// RVA: 0x13d3cfc VA: 0x9828bcfc
	private Void JFHBMPHOHLH(GameObject OMDFNKNJDII) { }
	// RVA: 0x13d3a08 VA: 0x9828ba08
	private Void CPBEJEBGLAC() { }
	// RVA: 0x13d3b84 VA: 0x9828bb84
	private Void EABFEFKJHFM() { }
	// RVA: 0x13d342c VA: 0x9828b42c
	private static Boolean BDMEFGGMPFD(GameObject OMDFNKNJDII, Boolean ELOELMEPFCN) { }
	// RVA: 0x13d0a6c VA: 0x98288a6c
	protected Void BBOOCLIEHGE(Boolean ELOELMEPFCN) { }
	// RVA: 0x13d0be8 VA: 0x98288be8
	protected Void JJMCOAFPFAG(Boolean MPCICMINELN) { }
	// RVA: 0x13d15a0 VA: 0x982895a0
	protected Void LJKIKKFIBDJ() { }
	// RVA: 0x13d1708 VA: 0x98289708
	public Void SetupSkateboardCamera() { }
	// RVA: 0x13d3f3c VA: 0x9828bf3c
	public Boolean CanSkateboardJump() { }
	// RVA: 0x13d40e0 VA: 0x9828c0e0
	public Void RequestSkateboardJump() { }
	// RVA: 0x13d436c VA: 0x9828c36c
	public Void OnSkateboardJump() { }
	// RVA: 0x13d455c VA: 0x9828c55c
	private Void PKGJPHCIIJG() { }
	// RVA: 0x13d47f4 VA: 0x9828c7f4
	private Void IBJNFAKLOCC() { }
	// RVA: 0x13d4928 VA: 0x9828c928
	public Single GetSkateboardJumpCdSecs() { }
	// RVA: 0x13d498c VA: 0x9828c98c
	public Single GetSkateboardJumpRemainingCdSecs() { }
	// RVA: 0x13d49f0 VA: 0x9828c9f0
	public Boolean CanSkateboardDash() { }
	// RVA: 0x13d4a68 VA: 0x9828ca68
	public Void RequestSkateboardDash() { }
	// RVA: 0x13d4da4 VA: 0x9828cda4
	public Void OnStateboardDash() { }
	// RVA: 0x13d42e0 VA: 0x9828c2e0
	private Void ICEOCBNBLBJ() { }
	// RVA: 0x13d4ef0 VA: 0x9828cef0
	private Void GFPBJBLDGDI() { }
	// RVA: 0x13d4c94 VA: 0x9828cc94
	private Void DPNCHCEKIMG() { }
	// RVA: 0x13d5050 VA: 0x9828d050
	public Single GetSkateboardDashRemainingCdSecs() { }
	// RVA: 0x13d50b4 VA: 0x9828d0b4
	public Single GetSkateboardDashCdSecs() { }
	// RVA: 0x13d5118 VA: 0x9828d118
	private Boolean EMMNMEHLOPL() { }
	// RVA: 0x13d5190 VA: 0x9828d190
	protected virtual Void OCIILCDCKPB(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13d52b4 VA: 0x9828d2b4
	protected Void MMPFLCIGMLM(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13d5d3c VA: 0x9828dd3c
	private Boolean CPFIDJJHDEC() { }
	// RVA: 0x13d5ffc VA: 0x9828dffc
	private Boolean NCNGHCPNHHA() { }
	// RVA: 0x13d62e8 VA: 0x9828e2e8
	protected virtual Void PMEIEBKGCEF() { }
	// RVA: 0x13d6638 VA: 0x9828e638
	protected Void PIDPMLOGKHM() { }
	// RVA: 0x13d5c7c VA: 0x9828dc7c
	protected Void AGDJGCHAEON(out Boolean JLCFMAPHHAO, out Boolean AONJEGIKNJG) { }
	// RVA: 0x13cf4cc VA: 0x982874cc
	private Void DJKKMMBBPOF() { }
	// RVA: 0x13cf578 VA: 0x98287578
	private Void PKADHAOMLCA() { }
	// RVA: 0x13d01e8 VA: 0x982881e8
	private Void DKKIFIKCMNJ() { }
	// RVA: 0x13d4be8 VA: 0x9828cbe8
	private Void GCNEAKFMKHG() { }
	// RVA: 0x13d4034 VA: 0x9828c034
	private Void CGIIFICIDDL() { }
	// RVA: 0x13d0650 VA: 0x98288650
	private Void DEFKICNMKGP() { }
	// RVA: 0x13c55e0 VA: 0x9827d5e0
	private Void EBDFFHOBADE(String LODDOINFPPA) { }
	// RVA: 0x13d67bc VA: 0x9828e7bc
	public Void UpdateSkateboardControllerByUGC() { }
	// RVA: 0x130b884 VA: 0x981c3884
	public Boolean get_IsSkySurfing() { }
	// RVA: 0x13d6900 VA: 0x9828e900
	public Boolean get_IsDuringSkySurfingSwitch() { }
	// RVA: 0x13d6a14 VA: 0x9828ea14
	public Boolean get_IsDuringSkyDivingSwitch() { }
	// RVA: 0x13d6b2c VA: 0x9828eb2c
	public virtual Boolean RequestSkySurfing() { }
	// RVA: 0x13d6cdc VA: 0x9828ecdc
	public virtual Boolean RequestSkyDiving() { }
	// RVA: 0x13d6db0 VA: 0x9828edb0
	public AEMINKPBIIJ get_UGCPlayerState() { }
	// RVA: 0x13d6e08 VA: 0x9828ee08
	public Void set_UGCPlayerState(AEMINKPBIIJ IMGNBGJDAHG) { }
	// RVA: 0x13d6e68 VA: 0x9828ee68
	protected virtual Void CAJJAPOBLFB() { }
	// RVA: 0x12a67b4 VA: 0x9815e7b4
	public Void InitStatus(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC ELJBADBICJN) { }
	// RVA: 0x13d761c VA: 0x9828f61c
	private Boolean NAKPCACOKEH(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC JDDIEPOJPKL) { }
	// RVA: 0x13d77c8 VA: 0x9828f7c8
	public virtual Void SwitchPhysXState(DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC ELJBADBICJN) { }
	// RVA: 0x13d83e4 VA: 0x982903e4
	protected Void EIPKOCCBJNG(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF, DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC ELJBADBICJN) { }
	// RVA: 0x1286a60 VA: 0x9813ea60
	public Void CheckAuxAimStatusChanged() { }
	// RVA: 0x12ae8b4 VA: 0x981668b4
	private Void BKKJCLICECO(Boolean JIABGDLAICE) { }
	// RVA: 0x13d8868 VA: 0x98290868
	private Void EDALKAMAGCD(DFKKGHCFGNM DLECPMBKMKM, FBCAHNCLMDC LLNHEMJJNGF, DFKKGHCFGNM JEHELPNHACP, FBCAHNCLMDC ELJBADBICJN) { }
	// RVA: 0x13d8ca8 VA: 0x98290ca8
	public virtual Void SwitchPhysXPose(FBCAHNCLMDC JDDIEPOJPKL) { }
	// RVA: 0x13d8d64 VA: 0x98290d64
	public virtual IPetsPawnAnimPlayer GetPetsPawnAnimPlayer() { }
	// RVA: 0x13d8dbc VA: 0x98290dbc
	public EHEGBOKBKJG get_CurrentSuperEmoteStatus() { }
	// RVA: 0x1344dd8 VA: 0x981fcdd8
	private Boolean PKKOJCBCOPF() { }
	// RVA: 0x13d8e14 VA: 0x98290e14
	public virtual Boolean RequestPlayBooyahSuperEmote(UInt32 CHAKGHFKDAM) { }
	// RVA: 0x13da64c VA: 0x9829264c
	public Void OnRequestPlayBooyahSuperEmoteRes(AOFIKGEIHND LHCHNFGKLHD) { }
	// RVA: 0x13dabe4 VA: 0x98292be4
	private Void POAHMCOCOLF(IHAAMHPPLMG BECFAIOFONM, UInt32 CHAKGHFKDAM) { }
	// RVA: 0x13dad54 VA: 0x98292d54
	public virtual Boolean RequestPlaySuperEmote(UInt32 CHAKGHFKDAM) { }
	// RVA: 0x13daf44 VA: 0x98292f44
	public Void OnRequestPlaySuperEmoteRes1P(AOFIKGEIHND LHCHNFGKLHD) { }
	// RVA: 0x13db800 VA: 0x98293800
	public Void OnRequestPlaySuperEmoteRes3P(AOFIKGEIHND LHCHNFGKLHD) { }
	// RVA: 0x13dc064 VA: 0x98294064
	private Void BLKOEFMKCNN(IHAAMHPPLMG BECFAIOFONM, UInt32 CHAKGHFKDAM) { }
	// RVA: 0x13dcad4 VA: 0x98294ad4
	public virtual Boolean RequestPlaySuperEmoteInteractiveAnimation(UInt32 CHAKGHFKDAM, Player MELHCDNGKIE) { }
	// RVA: 0x13dceec VA: 0x98294eec
	private Void NHJKDHLMFFJ(Player MELHCDNGKIE, UInt32 MJKNGMDNEAJ) { }
	// RVA: 0x13dd244 VA: 0x98295244
	public Void OnRequestPlaySuperEmoteInteractiveAnimationRes(AOFIKGEIHND LHCHNFGKLHD) { }
	// RVA: 0x13ddac4 VA: 0x98295ac4
	private Void DPDJKFLALHO(UInt32 MJKNGMDNEAJ, IHAAMHPPLMG BECFAIOFONM, IHAAMHPPLMG EGLOOAIFNBK) { }
	// RVA: 0x13d9240 VA: 0x98291240
	public Boolean BeforePlaySuperEmoteCheck(Boolean EAAEGLPOIPC) { }
	// RVA: 0x1298684 VA: 0x98150684
	private Void MDAFLFPFJJH() { }
	// RVA: 0x13dde84 VA: 0x98295e84
	public Void OnCabinWaitingEndClearSuperEmoteStatus() { }
	// RVA: 0x13d9e80 VA: 0x98291e80
	private Void JPKAPPPPDPN() { }
	// RVA: 0x1345154 VA: 0x981fd154
	private Void AGCIGLGLCPI(UInt32 CHAKGHFKDAM) { }
	// RVA: 0x13ded48 VA: 0x98296d48
	public Transform GetSuperEmoteCameraReferenceTransform() { }
	// RVA: 0x13db6b4 VA: 0x982936b4
	private Void OPIBGAEOLKP() { }
	// RVA: 0x13d9c20 VA: 0x98291c20
	private Void COLICICMMEJ() { }
	// RVA: 0x13dc9bc VA: 0x982949bc
	private Void JFECBOGNBFA() { }
	// RVA: 0x13dee48 VA: 0x98296e48
	private Void BBDLPCPPNJP() { }
	// RVA: 0x13dfe68 VA: 0x98297e68
	private Void CCAPHDBILJP() { }
	// RVA: 0x13df588 VA: 0x98297588
	private Void AFFMPHMACMO(Boolean ABPBBCINPNI) { }
	// RVA: 0x1298810 VA: 0x98150810
	private Void ODGPJIDKCEB() { }
	// RVA: 0x13dc4a4 VA: 0x982944a4
	private Void ELIFLMHAJAI() { }
	// RVA: 0x1299f88 VA: 0x98151f88
	public Void ClearSuperEmoteSound3P() { }
	// RVA: 0x12b46e0 VA: 0x9816c6e0
	public Boolean get_IsSwimming() { }
	// RVA: 0x1312bdc VA: 0x981cabdc
	public Boolean get_CantSwimmingFire() { }
	// RVA: 0x13a1d28 VA: 0x98259d28
	private Boolean DLKCAJFHHAE() { }
	// RVA: 0x13a1cc8 VA: 0x98259cc8
	public Boolean get_IsSwimDash() { }
	// RVA: 0x13e0454 VA: 0x98298454
	private Boolean CGAHOGKAFNJ() { }
	// RVA: 0x129fb3c VA: 0x98157b3c
	public Boolean get_IsSwimSurf() { }
	// RVA: 0x12b46d8 VA: 0x9816c6d8
	public UInt32 get_WaterNoSwimForceSyncTickCount() { }
	// RVA: 0x1298ae4 VA: 0x98150ae4
	public Void set_WaterNoSwimForceSyncTickCount(UInt32 IMGNBGJDAHG) { }
	// RVA: 0x13e04cc VA: 0x982984cc
	public virtual Boolean RequestStartSwimmingSurfing() { }
	// RVA: 0x13e055c VA: 0x9829855c
	public virtual Boolean RequestStopSwimmingSurfing() { }
	// RVA: 0x13e05ec VA: 0x982985ec
	public virtual Boolean RequestStartSwimming() { }
	// RVA: 0x13e0770 VA: 0x98298770
	public virtual Boolean RequestStopSwimming() { }
	// RVA: 0x13e091c VA: 0x9829891c
	public IHAAMHPPLMG get_ParachuteFollowTargetID() { }
	// RVA: 0x13e0994 VA: 0x98298994
	public Byte get_TeamParachuteIndex() { }
	// RVA: 0x130a650 VA: 0x981c2650
	public IKBGGPAEFDO get_CurParachuteMode() { }
	// RVA: 0x13e09f4 VA: 0x982989f4
	public Transform get_ParachutingRootTF() { }
	// RVA: 0x13e0bc8 VA: 0x98298bc8
	public Void InitTeamParachuteInfo(Object JKBNDADENMG) { }
	// RVA: 0x13e12f8 VA: 0x982992f8
	public Void InitTeamParachuteInfo(Byte HHLONFLCJBL, UInt32 KCBGGCKHIGA, UInt32 NEHHMDOBIEJ) { }
	// RVA: 0x13e1428 VA: 0x98299428
	protected virtual Void NPAHMINLFJA() { }
	// RVA: 0x13e147c VA: 0x9829947c
	public Void SetTeamFlight(UInt32 NEHHMDOBIEJ, Byte GLDLCOBLGNF) { }
	// RVA: 0x129ac9c VA: 0x98152c9c
	private Void BPGPDNLDJJI() { }
	// RVA: 0x13e1110 VA: 0x98299110
	public Void SetTeamParachuteLeaderID(IHAAMHPPLMG KCBGGCKHIGA) { }
	// RVA: 0x13e1780 VA: 0x98299780
	private Void DAEGBNAGKEF(IHAAMHPPLMG CHNELIGBABK) { }
	// RVA: 0x13e20e0 VA: 0x9829a0e0
	public Void OnBecomeFree() { }
	// RVA: 0x13e2530 VA: 0x9829a530
	public Void OnBecomeLeader() { }
	// RVA: 0x13e2914 VA: 0x9829a914
	public Void OnBecomeFollower() { }
	// RVA: 0x13a2904 VA: 0x9825a904
	private Void LDICHAMJMPE(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13e2e0c VA: 0x9829ae0c
	private Boolean GAFDNABNDDD(Vector3 DMAIMAGFNNG, Vector3 OLAFGGFHKFE) { }
	// RVA: 0x13e2468 VA: 0x9829a468
	private Void PKKHAKLHKIP() { }
	// RVA: 0x13a34fc VA: 0x9825b4fc
	public Boolean get_IsPlayerCanJumpIfOnBoard() { }
	// RVA: 0x13e31e4 VA: 0x9829b1e4
	public Void ClientForceBecomeFreeMode() { }
	// RVA: 0x13e330c VA: 0x9829b30c
	public Void NotifyServerParachuteFree() { }
	// RVA: 0x13e3424 VA: 0x9829b424
	public Void NotifyServerTransferLeader(IHAAMHPPLMG KCBGGCKHIGA) { }
	// RVA: 0x13e3660 VA: 0x9829b660
	public Void NotifyServerFollowLeader() { }
	// RVA: 0x13e37f8 VA: 0x9829b7f8
	public Void OnServerTransferLeaderFail() { }
	// RVA: 0x13e3a24 VA: 0x9829ba24
	public Void OnServerFollowLeaderFail() { }
	// RVA: 0x130b910 VA: 0x981c3910
	public Void ShowParachuteActionBtn() { }
	// RVA: 0x12a1958 VA: 0x98159958
	public Boolean IsFollowTeamFlight() { }
	// RVA: 0x130af58 VA: 0x981c2f58
	public Void ResetTeamFlightAnim() { }
	// RVA: 0x13e3d68 VA: 0x9829bd68
	public AnimationID GetTeamFlightAnim() { }
	// RVA: 0x13e40f0 VA: 0x9829c0f0
	public UInt32 GetTeamFlightId() { }
	// RVA: 0x13e3f8c VA: 0x9829bf8c
	public Boolean IsSingleTeamFlight() { }
	// RVA: 0x13e4150 VA: 0x9829c150
	public PreviewTeamFlightView GetSingleTeamFlight() { }
	// RVA: 0x13e41a8 VA: 0x9829c1a8
	public Void SetTeamFlightOwner(UInt32 CEGFJDGMNPO) { }
	// RVA: 0x13e0db8 VA: 0x98298db8
	public Void SetTeamFlightSeatIndex(UInt32 DAPPBNIJGAO) { }
	// RVA: 0x13e3ffc VA: 0x9829bffc
	public Int32 GetTeamFlightSeatIndex() { }
	// RVA: 0x13e4210 VA: 0x9829c210
	public Void RequestGetOffTeamFlight() { }
	// RVA: 0x13e435c VA: 0x9829c35c
	public Boolean IsTeamFlightOwner() { }
	// RVA: 0x129f214 VA: 0x98157214
	public Boolean IsTeamFlightDriver() { }
	// RVA: 0x13e4490 VA: 0x9829c490
	public Player GetTeamFlightOwner() { }
	// RVA: 0x130aab4 VA: 0x981c2ab4
	public Void EquipTeamFlight(Boolean BCOLIPNNBOP) { }
	// RVA: 0x13e508c VA: 0x9829d08c
	public Boolean IsRealTeamFlight() { }
	// RVA: 0x1348b9c VA: 0x98200b9c
	public Boolean CheckIsInTeamFlight() { }
	// RVA: 0x12af188 VA: 0x98167188
	public Void UnEquipTeamFlight() { }
	// RVA: 0x13e4a50 VA: 0x9829ca50
	public Void SetParent(Transform PHLFBBIAEFE) { }
	// RVA: 0x130ce4c VA: 0x981c4e4c
	public Void ReInitTeamFlight(Boolean AMCEEONPGJM) { }
	// RVA: 0x13e51e8 VA: 0x9829d1e8
	public Void ExitTeamflightUnfollowPlayer(Boolean LCHPEONONHC) { }
	// RVA: 0x1351b60 VA: 0x98209b60
	public JAEAODJEENM get_TransformPawn() { }
	// RVA: 0x13e561c VA: 0x9829d61c
	public virtual Void RequestTransform(ResourceID HCMAJGGMFPI, GameObject OMDFNKNJDII) { }
	// RVA: 0x13e56a4 VA: 0x9829d6a4
	public Void EnterTransform(ResourceID HCMAJGGMFPI, GameObject OMDFNKNJDII) { }
	// RVA: 0x13e5850 VA: 0x9829d850
	public Void EnterTransform(GameObject JNLIMNHJEFC) { }
	// RVA: 0x13e5cc0 VA: 0x9829dcc0
	protected virtual Void PLDHDJBHLPC(JAEAODJEENM ELFLCIGJOBB) { }
	// RVA: 0x13e5ec0 VA: 0x9829dec0
	protected virtual Void HLFCFEDOOHH(JAEAODJEENM ELFLCIGJOBB) { }
	// RVA: 0x13e5f1c VA: 0x9829df1c
	public virtual Void RequestExitTransform() { }
	// RVA: 0x13e5f7c VA: 0x9829df7c
	public Void ExitTransform() { }
	// RVA: 0x13e6124 VA: 0x9829e124
	protected virtual Void MEJHGJPLADM() { }
	// RVA: 0x13e5c1c VA: 0x9829dc1c
	public Void SetOrgModelVisible(Boolean FKHMOFHBOCC) { }
	// RVA: 0x13e6178 VA: 0x9829e178
	public Void UpdateTransparency(Single OPKNJGBDOBB) { }
	// RVA: 0x13e6f24 VA: 0x9829ef24
	private Material AFKBONMNDGJ() { }
	// RVA: 0x13e6d60 VA: 0x9829ed60
	private Void JJDIIBBIGCF(Boolean PIJKEJBMOFH) { }
	// RVA: 0x13e747c VA: 0x9829f47c
	private String HADEPOKHPNN(String HINJBPEDIAL) { }
	// RVA: 0x13e75d0 VA: 0x9829f5d0
	private String AKJPCLIMOEG(String HINJBPEDIAL) { }
	// RVA: 0x13e710c VA: 0x9829f10c
	private Void LPMMIPHIDOP(Single HDKPAPDIIDN) { }
	// RVA: 0x13e7274 VA: 0x9829f274
	private Void CBECLIFOCHD() { }
	// RVA: 0x13e7788 VA: 0x9829f788
	public Void ClearTransprancy() { }
	// RVA: 0x132ecf4 VA: 0x981e6cf4
	public Boolean IsUGCMorphed() { }
	// RVA: 0x131b714 VA: 0x981d3714
	public Boolean IsUGCHideShadow() { }
	// RVA: 0x13e7890 VA: 0x9829f890
	public Void SetUGCFPSCameraSpecialState(Boolean IKICDPGEGBE) { }
	// RVA: 0x12ef44c VA: 0x981a744c
	public Boolean get_IsUGCKeepForwardAsAim() { }
	// RVA: 0x1298aec VA: 0x98150aec
	public Void set_IsUGCKeepForwardAsAim(Boolean IMGNBGJDAHG) { }
	// RVA: 0x139ffcc VA: 0x98257fcc
	public Boolean get_IsUGCKeepTwoSideForward() { }
	// RVA: 0x1298af8 VA: 0x98150af8
	public Void set_IsUGCKeepTwoSideForward(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13e78f8 VA: 0x9829f8f8
	public Boolean get_IsUGCAllDirAnim() { }
	// RVA: 0x1298b04 VA: 0x98150b04
	public Void set_IsUGCAllDirAnim(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1386924 VA: 0x9823e924
	public Boolean get_IsUGCDisableFastRun() { }
	// RVA: 0x1298b10 VA: 0x98150b10
	public Void set_IsUGCDisableFastRun(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13e7904 VA: 0x9829f904
	public Boolean get_IsUGCDisableSighting() { }
	// RVA: 0x1298b1c VA: 0x98150b1c
	public Void set_IsUGCDisableSighting(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13e7910 VA: 0x9829f910
	private Boolean LMAMFNOKDEG(Collider NMKHBJBBDCK) { }
	// RVA: 0x13e7ae0 VA: 0x9829fae0
	protected virtual Void ADAMHMCIOFO(Single OPKNJGBDOBB, Single OMAFEKBHOAA) { }
	// RVA: 0x13e7b50 VA: 0x9829fb50
	public virtual UGCCameraConfigRepItem get_CurrentCameraConfig() { }
	// RVA: 0x13e7ba8 VA: 0x9829fba8
	protected virtual Void BIMGDMJNINM(UGCCameraConfigRepItem IMGNBGJDAHG) { }
	// RVA: 0x13e7c04 VA: 0x9829fc04
	public virtual Int32 get_UGCFactionIndex() { }
	// RVA: 0x13e7c5c VA: 0x9829fc5c
	public virtual UGCFactionRepItem get_UGCFactionEntity() { }
	// RVA: 0x13e7cb4 VA: 0x9829fcb4
	protected virtual Void HDJOLHJJOLI(UGCFactionRepItem IMGNBGJDAHG) { }
	// RVA: 0x13e7d10 VA: 0x9829fd10
	protected virtual Boolean MBNGEEOFHKL() { }
	// RVA: 0x13e7d68 VA: 0x9829fd68
	public Boolean get_IsVoiceMute() { }
	// RVA: 0x13e7ddc VA: 0x9829fddc
	public Boolean get_IsQuickChatMute() { }
	// RVA: 0x13e7e50 VA: 0x9829fe50
	public FFPMOBMCAHM get_AttackStatus() { }
	// RVA: 0x13a1ad8 VA: 0x98259ad8
	public FFPMOBMCAHM get_JumpStatus() { }
	// RVA: 0x127ce64 VA: 0x98134e64
	public FFPMOBMCAHM get_MovementStatus() { }
	// RVA: 0x1386ff8 VA: 0x9823eff8
	public FFPMOBMCAHM get_SprintStatus() { }
	// RVA: 0x13e7ec4 VA: 0x9829fec4
	public FFPMOBMCAHM get_ClimbStatus() { }
	// RVA: 0x13e7fb0 VA: 0x9829ffb0
	public Void SetClimbButtonStatus(Boolean IMGNBGJDAHG) { }
	// RVA: 0x13e8018 VA: 0x982a0018
	public Boolean GetClimbButtonStatus() { }
	// RVA: 0x13e810c VA: 0x982a010c
	public FFPMOBMCAHM get_DriveStatus() { }
	// RVA: 0x13e81f8 VA: 0x982a01f8
	public FFPMOBMCAHM get_GetOnDrive() { }
	// RVA: 0x13e82e4 VA: 0x982a02e4
	public FFPMOBMCAHM get_GetOffDrive() { }
	// RVA: 0x13e83d0 VA: 0x982a03d0
	public FFPMOBMCAHM get_OpVehicle() { }
	// RVA: 0x13e84bc VA: 0x982a04bc
	public Boolean get_ShowDamageNum() { }
	// RVA: 0x13e8530 VA: 0x982a0530
	public Void SetPlayerHighlight(Boolean IKICDPGEGBE) { }
	// RVA: 0x13e8890 VA: 0x982a0890
	public Int32 GetBagSkinID() { }
	// RVA: 0x13e8904 VA: 0x982a0904
	public Void UGCStartParachute(HHJGHBPJOCE LBODAOKLPEH) { }
	// RVA: 0x130cdd0 VA: 0x981c4dd0
	public Boolean IsUGCParachuting() { }
	// RVA: 0x13e8a1c VA: 0x982a0a1c
	private Void JOMMLIFDOKF(Int32 IMGNBGJDAHG) { }
	// RVA: 0x13e8afc VA: 0x982a0afc
	public static Int32 get_XRayMaxResult() { }
	// RVA: 0x12b1354 VA: 0x98169354
	public Boolean get_EnableXRay() { }
	// RVA: 0x1276de8 VA: 0x9812ede8
	public Void SetXRay(Boolean MPCICMINELN, BMJDKEAIBGD GFEAFBGKGCB) { }
	// RVA: 0x13458a8 VA: 0x981fd8a8
	public Void ChangeXRayObserver(Boolean CCPCMOAEOBC) { }
	// RVA: 0x13e90b4 VA: 0x982a10b4
	private Void DPIEHIHBDEL() { }
	// RVA: 0x1298b28 VA: 0x98150b28
	private Void HPEAOGLIFEI() { }
	// RVA: 0x13e96ec VA: 0x982a16ec
	public BMJDKEAIBGD GetXRayController(UInt32 EEJMCCPGOFM) { }
	// RVA: 0x13e8ca8 VA: 0x982a0ca8
	private Void GDFLBKLJMIK(BMJDKEAIBGD GFEAFBGKGCB) { }
	// RVA: 0x13e8e78 VA: 0x982a0e78
	private Void IMNMFAACEIA(BMJDKEAIBGD GFEAFBGKGCB) { }
	// RVA: 0x13e97d4 VA: 0x982a17d4
	public Single GetXRayAlphaScale(UInt32 EEJMCCPGOFM) { }
	// RVA: 0x13e9998 VA: 0x982a1998
	public Single GetLastXRayAlphaScale(UInt32 EEJMCCPGOFM) { }
	// RVA: 0x13e9a64 VA: 0x982a1a64
	public Void SetLastXRayAlphaScale(UInt32 EEJMCCPGOFM, Single JCIGIABOGIP) { }
	// RVA: 0x13e9b90 VA: 0x982a1b90
	public Single GetXRayMixedAlphaScale(Player HJCFNMMLPJH) { }
	// RVA: 0x13e9fd8 VA: 0x982a1fd8
	public Single GetLastXRayMixedAlphaScale(Player HJCFNMMLPJH) { }
	// RVA: 0x13ea22c VA: 0x982a222c
	public Void SetLastXRayMixedAlphaScale(Player HJCFNMMLPJH, Single JCIGIABOGIP) { }
	// RVA: 0x13ea3b8 VA: 0x982a23b8
	private Void ALJDCAFJIEI() { }
	// RVA: 0x13ea73c VA: 0x982a273c
	private Void GBBOELEALEN() { }
	// RVA: 0x13eaf80 VA: 0x982a2f80
	private Void GHDGNKCELKJ() { }
	// RVA: 0x13ebcb8 VA: 0x982a3cb8
	private Void LOMKMJJAEJL() { }
	// RVA: 0x13ec348 VA: 0x982a4348
	private Void AOFLCEKJLAI() { }
	// RVA: 0x13ec600 VA: 0x982a4600
	private Void FIMDPBCFOME() { }
	// RVA: 0x13ed1e0 VA: 0x982a51e0
	private Void OMKPBIAPFKJ() { }
	// RVA: 0x13edcd0 VA: 0x982a5cd0
	private Void ILBFMFNJNEJ() { }
	// RVA: 0x13eacf8 VA: 0x982a2cf8
	private Void AKACGCKMFJN(Player KAEHJEGFKBL, GPAIIOIBCLP LOKHCAIPLBG) { }
	// RVA: 0x13e9388 VA: 0x982a1388
	public Void SetAllPlayerXRayShader(GPAIIOIBCLP LOKHCAIPLBG) { }
	// RVA: 0x13ed6e0 VA: 0x982a56e0
	private Boolean IMHADLMKLMO(IHAAMHPPLMG BECFAIOFONM) { }
	// RVA: 0x12b2bc0 VA: 0x9816abc0
	private Void ILJNLAFAMOD() { }
	// RVA: 0x13eea18 VA: 0x982a6a18
	protected Dictionary`2 BMECJBPNOAJ() { }
	// RVA: 0x13eeaf4 VA: 0x982a6af4
	protected List`1 IAEDACAAANH() { }
	// RVA: 0x13eebd0 VA: 0x982a6bd0
	public Void SendFourSymbolSelectAttribute(Byte IJMCPPFJGEP, UInt32 MOJBFDMIMLM) { }
	// RVA: 0x13eefc8 VA: 0x982a6fc8
	public Void UpdateFourSymbolPendingAttributes(List`1 EAMMBMICPCC) { }
	// RVA: 0x13ef614 VA: 0x982a7614
	public Void UpdateFourSymbolsSelectedAttributes(List`1 LHCHNFGKLHD) { }
	// RVA: 0x13ef810 VA: 0x982a7810
	public List`1 GetPlayerPendingSelectAttributes() { }
	// RVA: 0x13ef870 VA: 0x982a7870
	public Dictionary`2 GetPlayerSelectedAttributes() { }
	// RVA: 0x13eeef0 VA: 0x982a6ef0
	public Boolean HasPendingAttribute() { }
	// RVA: 0x12efd48 VA: 0x981a7d48
	public Void ShowLandingTutorialAtTutorialBR() { }
	// RVA: 0x13ef8d0 VA: 0x982a78d0
	private Void GJDPNBDODHH(Vector3 ACCOJJMKKPM) { }
	// RVA: 0x13efa1c VA: 0x982a7a1c
	public Void TeleportBotAroundPlayerAtTutorialBR() { }
	// RVA: 0x13efe70 VA: 0x982a7e70
	private Void HPGDNELNMLC(Vector3 MOIAMOFEEOF) { }
	// RVA: 0x139fe2c VA: 0x98257e2c
	public Boolean get_IsChargeSkillLockMove() { }
	// RVA: 0x13f004c VA: 0x982a804c
	public Void set_IsChargeSkillLockMove(Boolean IMGNBGJDAHG) { }
	// RVA: 0x12d607c VA: 0x9818e07c
	public Boolean get_IsChargeSkillLockAnim() { }
	// RVA: 0x13f00d8 VA: 0x982a80d8
	public Void set_IsChargeSkillLockAnim(Boolean IMGNBGJDAHG) { }
	// RVA: 0x1386994 VA: 0x9823e994
	public Boolean get_IsChargeSkillLockFastRun() { }
	// RVA: 0x13f01a0 VA: 0x982a81a0
	public Void set_IsChargeSkillLockFastRun(Boolean IMGNBGJDAHG) { }
	// RVA: 0x139fe8c VA: 0x98257e8c
	public Single get_ChargeSkillLockMoveSpeedDecay() { }
	// RVA: 0x13f0260 VA: 0x982a8260
	private Void IEJPIIKPLBG(String NPDIHKNMPDP) { }
	// RVA: 0x13f02bc VA: 0x982a82bc
	private Void INEBBJBFOIF() { }
	// RVA: 0x13f0310 VA: 0x982a8310
	public Void PlayChargeSkillAnimWholeBody(ResourceID MFNEABEJJCB, Boolean ANDPBKOAIKH, Single HIPCLFGCBNI) { }
	// RVA: 0x13f05ec VA: 0x982a85ec
	public Void PlayChargeSkillAnimUpper(ResourceID MFNEABEJJCB, Boolean ANDPBKOAIKH) { }
	// RVA: 0x13f0778 VA: 0x982a8778
	public Void StopChargeSkillAnim() { }
	// RVA: 0x13f04c0 VA: 0x982a84c0
	public Void ResetCustomAnim() { }
	// RVA: 0x13f0810 VA: 0x982a8810
	private static Void .cctor() { }
	// RVA: 0x13f1af4 VA: 0x982a9af4
	private static Int32 GGNGHFOJGFA(HIPMADOOFCD AAFBIANMEAL, HIPMADOOFCD KENDCFNPDCE) { }
	// RVA: 0x13f1b40 VA: 0x982a9b40
	private static Int32 EIFMDFBKJNK(CLAEAIOIJAI AAFBIANMEAL, CLAEAIOIJAI KENDCFNPDCE) { }
	// RVA: 0x13f1b8c VA: 0x982a9b8c
	private Void AAKJFIDIEHI(Int32 DNHNPDIJHCE) { }
	// RVA: 0x13f1bf0 VA: 0x982a9bf0
	private Void EOGKGBMOBMF(Int32 DNHNPDIJHCE) { }
	// RVA: 0x13f1e2c VA: 0x982a9e2c
	private Void AKGIALLMOEC() { }
	// RVA: 0x13f1e74 VA: 0x982a9e74
	private Void PINMFGFEJGN() { }
	// RVA: 0x13f1f30 VA: 0x982a9f30
	private Void NMBEHPENAJH() { }
	// RVA: 0x13f2034 VA: 0x982aa034
	private Void HKKJHNLOAJE() { }
	// RVA: 0x13f2340 VA: 0x982aa340
	private Void FGGBFEOMCHD() { }
	// RVA: 0x13f2348 VA: 0x982aa348
	private Void KOKAINIGCGB() { }
	// RVA: 0x13f2350 VA: 0x982aa350
	private Void PBIOJKMHAME(Boolean FAIDKECFKEA) { }
	// RVA: 0x13f23f8 VA: 0x982aa3f8
	private Void CDAKHBAGDLC(Boolean AJNNDCOCJOB) { }
	// RVA: 0x13f2490 VA: 0x982aa490
	private Boolean LFLGBPANEEM(CSVBaseData NHJNFPKBBLI) { }
	// RVA: 0x13f2578 VA: 0x982aa578
	private Void PNIGGPEDHKD(UInt32 BBAFHKCBFFN, ResourceID DAOHLFEOLEK, GameObject GAHBKGJAHPJ) { }
	// RVA: 0x13f2734 VA: 0x982aa734
	private Void BNBPHPLHEMG() { }
	// RVA: 0x13f2824 VA: 0x982aa824
	private Void NJPMHHIFFHJ(UInt32 LOOGCFMPJMA, ResourceID IEIGNKAEAPK, GameObject KCJJDBKIDNL) { }
	// RVA: 0x13f2904 VA: 0x982aa904
	private Void ABPKEOJMHJF() { }
	// RVA: 0x13f2908 VA: 0x982aa908
	private Void EJMDLKFILHP() { }
	// RVA: 0x13f2954 VA: 0x982aa954
	private Void LEKEHJCDDKI() { }
	// RVA: 0x13f295c VA: 0x982aa95c
	private Void DJCIEAMMLOP(UInt32 NMAJCLPMCDN, Boolean NLGILOONJCL, Object KMIPBIGPDPI) { }
	// RVA: 0x13f2bac VA: 0x982aabac
	private Void DGPAFMBDFCF() { }
	// RVA: 0x13f2bb0 VA: 0x982aabb0
	private Void IINJIPLGMIO() { }
	// RVA: 0x13f2bb4 VA: 0x982aabb4
	private Void GJFHFLBJEBH() { }
	// RVA: 0x13f2bb8 VA: 0x982aabb8
	private Void AICDKPOBIKD() { }
	// RVA: 0x13f2bbc VA: 0x982aabbc
	private Void FEHDHHABOJL() { }
	// RVA: 0x13f2bc0 VA: 0x982aabc0
	private static Int32 MOPGDOIMAPB(UInt32 NHJNFPKBBLI, UInt32 LGALHNNDGNE) { }
	// RVA: 0x13f2be4 VA: 0x982aabe4
	private static Int32 MKLNHBCCIBM(EBDLMAHABAD NHJNFPKBBLI, EBDLMAHABAD LGALHNNDGNE) { }
	// RVA: 0x13f2c2c VA: 0x982aac2c
	private Void JFDBCEOLAIL() { }
	// RVA: 0x13f2c34 VA: 0x982aac34
	public Vector3 <>iFixBaseProxy_GetAttackableCenterWS() { }
	// RVA: 0x13f2c48 VA: 0x982aac48
	public Single <>iFixBaseProxy_GetAttackableRadius() { }
	// RVA: 0x13f2c50 VA: 0x982aac50
	public Boolean <>iFixBaseProxy_IsVisible() { }
	// RVA: 0x13f2c58 VA: 0x982aac58
	public Boolean <>iFixBaseProxy_IsStreamerVisible() { }
	// RVA: 0x13f2c60 VA: 0x982aac60
	public Void <>iFixBaseProxy_InitEntityInfo() { }
	// RVA: 0x13f2c68 VA: 0x982aac68
	public Void <>iFixBaseProxy_ReUse() { }
	// RVA: 0x13f2c70 VA: 0x982aac70
	public Boolean <>iFixBaseProxy_Recycle() { }
	// RVA: 0x13f2c78 VA: 0x982aac78
	public Void <>iFixBaseProxy_OnRecycle() { }
	// RVA: 0x13f2c80 VA: 0x982aac80
	public Void <>iFixBaseProxy_OnOnDestroy() { }
	// RVA: 0x13f2c88 VA: 0x982aac88
	public Void <>iFixBaseProxy_RecycleForInGameReload() { }
	// RVA: 0x13f2c90 VA: 0x982aac90
	public Void <>iFixBaseProxy_OnAwake() { }
	// RVA: 0x13f2c98 VA: 0x982aac98
	public Void <>iFixBaseProxy_OnUpdate(Single P0, Single P1) { }
	// RVA: 0x13f2ca0 VA: 0x982aaca0
	public Void <>iFixBaseProxy_OnFixedUpdate(Single P0, Single P1) { }
	// RVA: 0x13f2ca8 VA: 0x982aaca8
	public Void <>iFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List`1 P2, UInt32 P3) { }
	// RVA: 0x13f2ccc VA: 0x982aaccc
	public Void <>iFixBaseProxy_TakeHealing(FFLDLNDNFCO P0, List`1 P1) { }
	// RVA: 0x13f2cd4 VA: 0x982aacd4
	public Void <>iFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1) { }
	// RVA: 0x13f2d08 VA: 0x982aad08
	public Boolean <>iFixBaseProxy_CanAssitByWeapon(Player P0, GPBDEDFKJNA P1) { }
	// RVA: 0x13f2d10 VA: 0x982aad10
	public Boolean <>iFixBaseProxy_get_CanBeLockedByAimAssist() { }
	// RVA: 0x13f2d18 VA: 0x982aad18
	public Boolean <>iFixBaseProxy_get_IsMovableEntity() { }
	// RVA: 0x13f2d20 VA: 0x982aad20
	public ITransformNode <>iFixBaseProxy_GetTransformNode(String P0) { }
	// RVA: 0x13f2d28 VA: 0x982aad28
	public Void <>iFixBaseProxy_OnUserDefineReplicationInfo() { }
	// RVA: 0x13f2d30 VA: 0x982aad30
	public Void <>iFixBaseProxy_OnPRIInitialized() { }
}