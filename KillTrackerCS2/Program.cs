using Swed64;

public class KillTracker
{
    public const nint dwLocalPlayerController = 0x1919588;
    public const nint dwLocalPlayerPawn = 0x173D5A8;
    public static class CCSPlayerController
    {
        public const nint m_pInGameMoneyServices = 0x6F8; // CCSPlayerController_InGameMoneyServices*
        public const nint m_pInventoryServices = 0x700; // CCSPlayerController_InventoryServices*
        public const nint m_pActionTrackingServices = 0x708; // CCSPlayerController_ActionTrackingServices*
        public const nint m_pDamageServices = 0x710; // CCSPlayerController_DamageServices*
        public const nint m_iPing = 0x718; // uint32
        public const nint m_bHasCommunicationAbuseMute = 0x71C; // bool
        public const nint m_szCrosshairCodes = 0x720; // CUtlSymbolLarge
        public const nint m_iPendingTeamNum = 0x728; // uint8
        public const nint m_flForceTeamTime = 0x72C; // GameTime_t
        public const nint m_iCompTeammateColor = 0x730; // int32
        public const nint m_bEverPlayedOnTeam = 0x734; // bool
        public const nint m_flPreviousForceJoinTeamTime = 0x738; // GameTime_t
        public const nint m_szClan = 0x740; // CUtlSymbolLarge
        public const nint m_sSanitizedPlayerName = 0x748; // CUtlString
        public const nint m_iCoachingTeam = 0x750; // int32
        public const nint m_nPlayerDominated = 0x758; // uint64
        public const nint m_nPlayerDominatingMe = 0x760; // uint64
        public const nint m_iCompetitiveRanking = 0x768; // int32
        public const nint m_iCompetitiveWins = 0x76C; // int32
        public const nint m_iCompetitiveRankType = 0x770; // int8
        public const nint m_iCompetitiveRankingPredicted_Win = 0x774; // int32
        public const nint m_iCompetitiveRankingPredicted_Loss = 0x778; // int32
        public const nint m_iCompetitiveRankingPredicted_Tie = 0x77C; // int32
        public const nint m_nEndMatchNextMapVote = 0x780; // int32
        public const nint m_unActiveQuestId = 0x784; // uint16
        public const nint m_nQuestProgressReason = 0x788; // QuestProgress::Reason
        public const nint m_unPlayerTvControlFlags = 0x78C; // uint32
        public const nint m_iDraftIndex = 0x7B8; // int32
        public const nint m_msQueuedModeDisconnectionTimestamp = 0x7BC; // uint32
        public const nint m_uiAbandonRecordedReason = 0x7C0; // uint32
        public const nint m_bCannotBeKicked = 0x7C4; // bool
        public const nint m_bEverFullyConnected = 0x7C5; // bool
        public const nint m_bAbandonAllowsSurrender = 0x7C6; // bool
        public const nint m_bAbandonOffersInstantSurrender = 0x7C7; // bool
        public const nint m_bDisconnection1MinWarningPrinted = 0x7C8; // bool
        public const nint m_bScoreReported = 0x7C9; // bool
        public const nint m_nDisconnectionTick = 0x7CC; // int32
        public const nint m_bControllingBot = 0x7D8; // bool
        public const nint m_bHasControlledBotThisRound = 0x7D9; // bool
        public const nint m_bHasBeenControlledByPlayerThisRound = 0x7DA; // bool
        public const nint m_nBotsControlledThisRound = 0x7DC; // int32
        public const nint m_bCanControlObservedBot = 0x7E0; // bool
        public const nint m_hPlayerPawn = 0x7E4; // CHandle<C_CSPlayerPawn>
        public const nint m_hObserverPawn = 0x7E8; // CHandle<C_CSObserverPawn>
        public const nint m_bPawnIsAlive = 0x7EC; // bool
        public const nint m_iPawnHealth = 0x7F0; // uint32
        public const nint m_iPawnArmor = 0x7F4; // int32
        public const nint m_bPawnHasDefuser = 0x7F8; // bool
        public const nint m_bPawnHasHelmet = 0x7F9; // bool
        public const nint m_nPawnCharacterDefIndex = 0x7FA; // uint16
        public const nint m_iPawnLifetimeStart = 0x7FC; // int32
        public const nint m_iPawnLifetimeEnd = 0x800; // int32
        public const nint m_iPawnBotDifficulty = 0x804; // int32
        public const nint m_hOriginalControllerOfCurrentPawn = 0x808; // CHandle<CCSPlayerController>
        public const nint m_iScore = 0x80C; // int32
        public const nint m_vecKills = 0x810; // C_NetworkUtlVectorBase<EKillTypes_t>
        public const nint m_bMvpNoMusic = 0x828; // bool
        public const nint m_eMvpReason = 0x82C; // int32
        public const nint m_iMusicKitID = 0x830; // int32
        public const nint m_iMusicKitMVPs = 0x834; // int32
        public const nint m_iMVPs = 0x838; // int32
        public const nint m_bIsPlayerNameDirty = 0x83C; // bool
    }
    public static class CCSPlayerController_ActionTrackingServices
    {
        public const nint m_perRoundStats = 0x40; // C_UtlVectorEmbeddedNetworkVar<CSPerRoundStats_t>
        public const nint m_matchStats = 0x90; // CSMatchStats_t
        public const nint m_iNumRoundKills = 0x110; // int32
        public const nint m_iNumRoundKillsHeadshots = 0x114; // int32
        public const nint m_unTotalRoundDamageDealt = 0x118; // uint32
    }
    public static class CSPerRoundStats_t
    {
        public const nint m_iKills = 0x30; // int32
        public const nint m_iDeaths = 0x34; // int32
        public const nint m_iAssists = 0x38; // int32
        public const nint m_iDamage = 0x3C; // int32
        public const nint m_iEquipmentValue = 0x40; // int32
        public const nint m_iMoneySaved = 0x44; // int32
        public const nint m_iKillReward = 0x48; // int32
        public const nint m_iLiveTime = 0x4C; // int32
        public const nint m_iHeadShotKills = 0x50; // int32
        public const nint m_iObjective = 0x54; // int32
        public const nint m_iCashEarned = 0x58; // int32
        public const nint m_iUtilityDamage = 0x5C; // int32
        public const nint m_iEnemiesFlashed = 0x60; // int32
    }
    public static Swed sw = new Swed("cs2");
    public static IntPtr baseAddress = sw.GetModuleBase("client.dll");
    static int frags = 0;
    static int assists = 0;
    static int deaths = 0;
    private static void Main(string[] args)
    {
        
        sw.GetProcess();
        while(true)
        {
            nint pawn = sw.ReadPointer(baseAddress,(int)dwLocalPlayerController);
            Console.Clear();
            nint m_pActionTrackingServicesptr = sw.ReadPointer(pawn, (int)CCSPlayerController.m_pActionTrackingServices);
            nint MatchStats = m_pActionTrackingServicesptr + CCSPlayerController_ActionTrackingServices.m_matchStats;
            frags = sw.ReadInt(MatchStats + (int)CSPerRoundStats_t.m_iKills);
            assists = sw.ReadInt(MatchStats + (int)CSPerRoundStats_t.m_iAssists);
            deaths = sw.ReadInt(MatchStats + (int)CSPerRoundStats_t.m_iDeaths);
            Console.WriteLine("\n"+frags+"\n"+assists+"\n"+deaths); // we got em
            Thread.Sleep(500);
        }
    }
}