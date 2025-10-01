// OfficeDBContext.cs
using CabPwaApi.Models.Office.Tables;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office;

public partial class OfficeDBContext : DbContext
{
    public OfficeDBContext()
    {
    }

    public OfficeDBContext(DbContextOptions<OfficeDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessAuthority> AccessAuthority { get; set; }

    public virtual DbSet<AccessSubjects> AccessSubjects { get; set; }

    public virtual DbSet<AccountOwners> AccountOwners { get; set; }

    public virtual DbSet<AccountTrans> AccountTrans { get; set; }

    public virtual DbSet<AccountTransWares> AccountTransWares { get; set; }

    public virtual DbSet<AccountTypeNames> AccountTypeNames { get; set; }

    public virtual DbSet<Accounts> Accounts { get; set; }

    public virtual DbSet<ActLimits> ActLimits { get; set; }

    public virtual DbSet<Afs> Afs { get; set; }

    public virtual DbSet<AlcoWareType> AlcoWareType { get; set; }

    public virtual DbSet<AltWareGroups> AltWareGroups { get; set; }

    public virtual DbSet<AltWareGroupsMapping> AltWareGroupsMapping { get; set; }

    public virtual DbSet<AuditLog> AuditLog { get; set; }

    public virtual DbSet<BalanceByClientsPurses> BalanceByClientsPurses { get; set; }

    public virtual DbSet<BarCodes> BarCodes { get; set; }

    public virtual DbSet<BonusAddSchema> BonusAddSchema { get; set; }

    public virtual DbSet<BonusCardCaterory> BonusCardCaterory { get; set; }

    public virtual DbSet<BonusInformForAccounts> BonusInformForAccounts { get; set; }

    public virtual DbSet<BonusSchemCardRange> BonusSchemCardRange { get; set; }

    public virtual DbSet<BonusSchemPaymentTypes> BonusSchemPaymentTypes { get; set; }

    public virtual DbSet<BonusSchemWares> BonusSchemWares { get; set; }

    public virtual DbSet<BonusTrans> BonusTrans { get; set; }

    public virtual DbSet<BonusWriteOffByAccount> BonusWriteOffByAccount { get; set; }

    public virtual DbSet<BonusWriteOffSchema> BonusWriteOffSchema { get; set; }

    public virtual DbSet<BorderValueForDiscount> BorderValueForDiscount { get; set; }

    public virtual DbSet<CalTables> CalTables { get; set; }

    public virtual DbSet<CalcDiscountSchema> CalcDiscountSchema { get; set; }

    public virtual DbSet<CalcDiscountTable> CalcDiscountTable { get; set; }

    public virtual DbSet<CancelledFuelWholesales> CancelledFuelWholesales { get; set; }

    public virtual DbSet<CardHistory> CardHistory { get; set; }

    public virtual DbSet<CardInfoTemplate> CardInfoTemplate { get; set; }

    public virtual DbSet<CardPurseTemplate> CardPurseTemplate { get; set; }

    public virtual DbSet<CardStopList> CardStopList { get; set; }

    public virtual DbSet<CashCollections> CashCollections { get; set; }

    public virtual DbSet<CashRealization> CashRealization { get; set; }

    public virtual DbSet<ClientFuelDrivers> ClientFuelDrivers { get; set; }

    public virtual DbSet<ClientFuelLimits> ClientFuelLimits { get; set; }

    public virtual DbSet<ClientFuelPaymentDetails> ClientFuelPaymentDetails { get; set; }

    public virtual DbSet<ClientFuelPayments> ClientFuelPayments { get; set; }

    public virtual DbSet<ClientFuelPriceContracts> ClientFuelPriceContracts { get; set; }

    public virtual DbSet<ClientFuelPrices> ClientFuelPrices { get; set; }

    public virtual DbSet<ClientFuelRemainderCorrectionDetails> ClientFuelRemainderCorrectionDetails { get; set; }

    public virtual DbSet<ClientFuelRemainderCorrections> ClientFuelRemainderCorrections { get; set; }

    public virtual DbSet<ClientFuelRemainders> ClientFuelRemainders { get; set; }

    public virtual DbSet<ClientFuelSupplies> ClientFuelSupplies { get; set; }

    public virtual DbSet<ClientFuelSupplyDetails> ClientFuelSupplyDetails { get; set; }

    public virtual DbSet<ClientFuelTransferDetails> ClientFuelTransferDetails { get; set; }

    public virtual DbSet<ClientFuelTransfers> ClientFuelTransfers { get; set; }

    public virtual DbSet<ClientLimits> ClientLimits { get; set; }

    public virtual DbSet<ClientTradePlaces> ClientTradePlaces { get; set; }

    public virtual DbSet<ClientTrucks> ClientTrucks { get; set; }

    public virtual DbSet<Clients> Clients { get; set; }

    public virtual DbSet<ClientsThresholdDiscount> ClientsThresholdDiscount { get; set; }

    public virtual DbSet<Contractors> Contractors { get; set; }

    public virtual DbSet<Contracts> Contracts { get; set; }

    public virtual DbSet<CouponDiscounts> CouponDiscounts { get; set; }

    public virtual DbSet<CouponSeries> CouponSeries { get; set; }

    public virtual DbSet<Coupons> Coupons { get; set; }

    public virtual DbSet<CouponsNotUsingPlace> CouponsNotUsingPlace { get; set; }

    public virtual DbSet<CouponsStore> CouponsStore { get; set; }

    public virtual DbSet<CurAccountTrans> CurAccountTrans { get; set; }

    public virtual DbSet<CurBonusTrans> CurBonusTrans { get; set; }

    public virtual DbSet<CurCredit> CurCredit { get; set; }

    public virtual DbSet<CurEventSize> CurEventSize { get; set; }

    public virtual DbSet<CurEvents> CurEvents { get; set; }

    public virtual DbSet<CurProdStat> CurProdStat { get; set; }

    public virtual DbSet<CurPumpStat> CurPumpStat { get; set; }

    public virtual DbSet<CurRelays> CurRelays { get; set; }

    public virtual DbSet<CurRest> CurRest { get; set; }

    public virtual DbSet<CurTankStat> CurTankStat { get; set; }

    public virtual DbSet<DbautoUpgrade> DbautoUpgrade { get; set; }

    public virtual DbSet<DelayedBonusAdditions> DelayedBonusAdditions { get; set; }

    public virtual DbSet<DelayedCardAdditions> DelayedCardAdditions { get; set; }

    public virtual DbSet<DeletedItems> DeletedItems { get; set; }

    public virtual DbSet<DirAttributeOverridesByAfs> DirAttributeOverridesByAfs { get; set; }

    public virtual DbSet<DiscountSchemCardRange> DiscountSchemCardRange { get; set; }

    public virtual DbSet<DiscountSchemPaymentTypes> DiscountSchemPaymentTypes { get; set; }

    public virtual DbSet<DiscountSchemWares> DiscountSchemWares { get; set; }

    public virtual DbSet<Discounts> Discounts { get; set; }

    public virtual DbSet<DraftFuelWholesales> DraftFuelWholesales { get; set; }

    public virtual DbSet<DscCardStopList> DscCardStopList { get; set; }

    public virtual DbSet<EcrSectionSums> EcrSectionSums { get; set; }

    public virtual DbSet<EventLogs> EventLogs { get; set; }

    public virtual DbSet<ExternalCardOperations> ExternalCardOperations { get; set; }

    public virtual DbSet<ExternalWareSupplyDetails> ExternalWareSupplyDetails { get; set; }

    public virtual DbSet<ExtraCardPurses> ExtraCardPurses { get; set; }

    public virtual DbSet<FuelBases> FuelBases { get; set; }

    public virtual DbSet<FuelBasesDeliveryPrices> FuelBasesDeliveryPrices { get; set; }

    public virtual DbSet<FuelDrivers> FuelDrivers { get; set; }

    public virtual DbSet<FuelInventorySchedule> FuelInventorySchedule { get; set; }

    public virtual DbSet<FuelProviders> FuelProviders { get; set; }

    public virtual DbSet<FuelSell> FuelSell { get; set; }

    public virtual DbSet<FuelSupplies> FuelSupplies { get; set; }

    public virtual DbSet<FuelSupplyDetails> FuelSupplyDetails { get; set; }

    public virtual DbSet<FuelWholesaleDetails> FuelWholesaleDetails { get; set; }

    public virtual DbSet<FuelWholesaleQueue> FuelWholesaleQueue { get; set; }

    public virtual DbSet<FuelWholesales> FuelWholesales { get; set; }

    public virtual DbSet<GivenCoupons> GivenCoupons { get; set; }

    public virtual DbSet<Globals> Globals { get; set; }

    public virtual DbSet<GrpDiscounts> GrpDiscounts { get; set; }

    public virtual DbSet<ImportedLogs> ImportedLogs { get; set; }

    public virtual DbSet<InOut> InOut { get; set; }

    public virtual DbSet<Invoice> Invoice { get; set; }

    public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }

    public virtual DbSet<JobTypes> JobTypes { get; set; }

    public virtual DbSet<Keys> Keys { get; set; }

    public virtual DbSet<LinkSessions> LinkSessions { get; set; }

    public virtual DbSet<LnrcardDirectory> LnrcardDirectory { get; set; }

    public virtual DbSet<LoadingPoints> LoadingPoints { get; set; }

    public virtual DbSet<Manufacturers> Manufacturers { get; set; }

    public virtual DbSet<MsgAdressat> MsgAdressat { get; set; }

    public virtual DbSet<MsgAttachedFiles> MsgAttachedFiles { get; set; }

    public virtual DbSet<MsgInBox> MsgInBox { get; set; }

    public virtual DbSet<MsgMessages> MsgMessages { get; set; }

    public virtual DbSet<MsgOutBox> MsgOutBox { get; set; }

    public virtual DbSet<MsgSplitFile32k> MsgSplitFile32k { get; set; }

    public virtual DbSet<MsgVAdressat> MsgVAdressat { get; set; }

    public virtual DbSet<MsgVInboxMessage> MsgVInboxMessage { get; set; }

    public virtual DbSet<MsgVOutboxMessage> MsgVOutboxMessage { get; set; }

    public virtual DbSet<Operators> Operators { get; set; }

    public virtual DbSet<PaymentTypeGroups> PaymentTypeGroups { get; set; }

    public virtual DbSet<PaymentTypeGroupsDetail> PaymentTypeGroupsDetail { get; set; }

    public virtual DbSet<PaymentTypes> PaymentTypes { get; set; }

    public virtual DbSet<PaymentsInfo> PaymentsInfo { get; set; }

    public virtual DbSet<PersonnelWorkPlaces> PersonnelWorkPlaces { get; set; }

    public virtual DbSet<Prices> Prices { get; set; }

    public virtual DbSet<ProdStat> ProdStat { get; set; }

    public virtual DbSet<Products> Products { get; set; }

    public virtual DbSet<PropDefs> PropDefs { get; set; }

    public virtual DbSet<PropsForWares> PropsForWares { get; set; }

    public virtual DbSet<PumpStat> PumpStat { get; set; }

    public virtual DbSet<Pumps> Pumps { get; set; }

    public virtual DbSet<PurseBonusAddFormula> PurseBonusAddFormula { get; set; }

    public virtual DbSet<QtyDiscounts> QtyDiscounts { get; set; }

    public virtual DbSet<Realization> Realization { get; set; }

    public virtual DbSet<RelayWsInfo> RelayWsInfo { get; set; }

    public virtual DbSet<Relays> Relays { get; set; }

    public virtual DbSet<RequiredTradeObjFlags> RequiredTradeObjFlags { get; set; }

    public virtual DbSet<RevaluationDocs> RevaluationDocs { get; set; }

    public virtual DbSet<SingleWareSells> SingleWareSells { get; set; }

    public virtual DbSet<Smstemplates> Smstemplates { get; set; }

    public virtual DbSet<SstfuelAdvanceOperation> SstfuelAdvanceOperation { get; set; }

    public virtual DbSet<Tags> Tags { get; set; }

    public virtual DbSet<TankBookRemainderOffsets> TankBookRemainderOffsets { get; set; }

    public virtual DbSet<TankMeasurements> TankMeasurements { get; set; }

    public virtual DbSet<TankStat> TankStat { get; set; }

    public virtual DbSet<TankTrucks> TankTrucks { get; set; }

    public virtual DbSet<Tanks> Tanks { get; set; }

    public virtual DbSet<TimeLimitForBonus> TimeLimitForBonus { get; set; }

    public virtual DbSet<TimeLimitForDiscount> TimeLimitForDiscount { get; set; }

    public virtual DbSet<TradeObjGrouping> TradeObjGrouping { get; set; }

    public virtual DbSet<TradeObjGroups> TradeObjGroups { get; set; }

    public virtual DbSet<TradeObjToApplyRevDoc> TradeObjToApplyRevDoc { get; set; }

    public virtual DbSet<TradeObjVerInfo> TradeObjVerInfo { get; set; }

    public virtual DbSet<TradeObjectWares> TradeObjectWares { get; set; }

    public virtual DbSet<UsedCoupons> UsedCoupons { get; set; }

    public virtual DbSet<VAccountTrans> VAccountTrans { get; set; }

    public virtual DbSet<VAccountTransBalanceByProduct> VAccountTransBalanceByProduct { get; set; }

    public virtual DbSet<VActiveAfs> VActiveAfs { get; set; }

    public virtual DbSet<VAfsInGroup> VAfsInGroup { get; set; }

    public virtual DbSet<VAfsOutGroup> VAfsOutGroup { get; set; }

    public virtual DbSet<VAllAfs> VAllAfs { get; set; }

    public virtual DbSet<VBonusAddSchema> VBonusAddSchema { get; set; }

    public virtual DbSet<VBonusSchemPaymentTypes> VBonusSchemPaymentTypes { get; set; }

    public virtual DbSet<VBonusSchemWares> VBonusSchemWares { get; set; }

    public virtual DbSet<VCalcDiscountSchema> VCalcDiscountSchema { get; set; }

    public virtual DbSet<VCardHistory> VCardHistory { get; set; }

    public virtual DbSet<VClientBalance> VClientBalance { get; set; }

    public virtual DbSet<VClients> VClients { get; set; }

    public virtual DbSet<VClientsTags> VClientsTags { get; set; }

    public virtual DbSet<VContractors> VContractors { get; set; }

    public virtual DbSet<VContractorsShort> VContractorsShort { get; set; }

    public virtual DbSet<VContracts> VContracts { get; set; }

    public virtual DbSet<VDiscountSchemPaymentTypes> VDiscountSchemPaymentTypes { get; set; }

    public virtual DbSet<VDiscountSchemWares> VDiscountSchemWares { get; set; }

    public virtual DbSet<VExternalCardRefunds> VExternalCardRefunds { get; set; }

    public virtual DbSet<VFuelProviders> VFuelProviders { get; set; }

    public virtual DbSet<VManufacturers> VManufacturers { get; set; }

    public virtual DbSet<VMoneyAndProducts> VMoneyAndProducts { get; set; }

    public virtual DbSet<VOurFirms> VOurFirms { get; set; }

    public virtual DbSet<VPaymentTypeGroups> VPaymentTypeGroups { get; set; }

    public virtual DbSet<VPaymentsTrans> VPaymentsTrans { get; set; }

    public virtual DbSet<VProducts> VProducts { get; set; }

    public virtual DbSet<VPurseNames> VPurseNames { get; set; }

    public virtual DbSet<VPurseProducts> VPurseProducts { get; set; }

    public virtual DbSet<VSbfuelSell> VSbfuelSell { get; set; }

    public virtual DbSet<VSbsingleWareSell> VSbsingleWareSell { get; set; }

    public virtual DbSet<VTimeLimitForBonus> VTimeLimitForBonus { get; set; }

    public virtual DbSet<VTimeLimitForDiscount> VTimeLimitForDiscount { get; set; }

    public virtual DbSet<VWareGroups> VWareGroups { get; set; }

    public virtual DbSet<VWareRemainderAfterLastRelay> VWareRemainderAfterLastRelay { get; set; }

    public virtual DbSet<VWaresAssembleWareSetJournalDoc> VWaresAssembleWareSetJournalDoc { get; set; }

    public virtual DbSet<VWaresCashlessExpenditureJournalDoc> VWaresCashlessExpenditureJournalDoc { get; set; }

    public virtual DbSet<VWaresCookingJournalDoc> VWaresCookingJournalDoc { get; set; }

    public virtual DbSet<VWaresDisAssembleWareSetJournalDoc> VWaresDisAssembleWareSetJournalDoc { get; set; }

    public virtual DbSet<VWaresExternalIncomeJournalDoc> VWaresExternalIncomeJournalDoc { get; set; }

    public virtual DbSet<VWaresInternalIncomeJournalDoc> VWaresInternalIncomeJournalDoc { get; set; }

    public virtual DbSet<VWaresInventoryJournalDoc> VWaresInventoryJournalDoc { get; set; }

    public virtual DbSet<VWaresJournalDocItems> VWaresJournalDocItems { get; set; }

    public virtual DbSet<VWaresMovementJournalDoc> VWaresMovementJournalDoc { get; set; }

    public virtual DbSet<VWaresProviderReturnJournalDoc> VWaresProviderReturnJournalDoc { get; set; }

    public virtual DbSet<VWaresReceptionJournalDoc> VWaresReceptionJournalDoc { get; set; }

    public virtual DbSet<VWaresRequestJournalDoc> VWaresRequestJournalDoc { get; set; }

    public virtual DbSet<VWaresRevJournalDocItems> VWaresRevJournalDocItems { get; set; }

    public virtual DbSet<VWaresRevaluationJournalDoc> VWaresRevaluationJournalDoc { get; set; }

    public virtual DbSet<VWaresSellsJournalDocItems> VWaresSellsJournalDocItems { get; set; }

    public virtual DbSet<VWaresWareSellJournalDoc> VWaresWareSellJournalDoc { get; set; }

    public virtual DbSet<VWaresWriteOffJournalDoc> VWaresWriteOffJournalDoc { get; set; }

    public virtual DbSet<VWebLoginsAndAccounts> VWebLoginsAndAccounts { get; set; }

    public virtual DbSet<VWebLoginsAndAllAccounts> VWebLoginsAndAllAccounts { get; set; }

    public virtual DbSet<Vcards> Vcards { get; set; }

    public virtual DbSet<WareGroupPropsByAfs> WareGroupPropsByAfs { get; set; }

    public virtual DbSet<WareGroups> WareGroups { get; set; }

    public virtual DbSet<WareOrigins> WareOrigins { get; set; }

    public virtual DbSet<WareProps> WareProps { get; set; }

    public virtual DbSet<WareRemainders> WareRemainders { get; set; }

    public virtual DbSet<WareRev> WareRev { get; set; }

    public virtual DbSet<WareRevItems> WareRevItems { get; set; }

    public virtual DbSet<WareSell> WareSell { get; set; }

    public virtual DbSet<WareSellChecks> WareSellChecks { get; set; }

    public virtual DbSet<WareSellEx> WareSellEx { get; set; }

    public virtual DbSet<WareSliceItems> WareSliceItems { get; set; }

    public virtual DbSet<WareSlices> WareSlices { get; set; }

    public virtual DbSet<WareSupply> WareSupply { get; set; }

    public virtual DbSet<WareSupplyItems> WareSupplyItems { get; set; }

    public virtual DbSet<WareTypes> WareTypes { get; set; }

    public virtual DbSet<WareUnits> WareUnits { get; set; }

    public virtual DbSet<Wares> Wares { get; set; }

    public virtual DbSet<WaresBundling> WaresBundling { get; set; }

    public virtual DbSet<WaresPriceSetting> WaresPriceSetting { get; set; }

    public virtual DbSet<WebAccessLogins> WebAccessLogins { get; set; }

    public virtual DbSet<WorkTime> WorkTime { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => base.OnConfiguring(optionsBuilder);
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Cyrillic_General_CI_AI");

        modelBuilder.Entity<AccountOwners>(entity =>
        {
            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.Sex).HasDefaultValue((short)-1);

            entity.HasOne(d => d.AccountNumberNavigation).WithOne(p => p.AccountOwners).HasConstraintName("FK_AccountOwners");
        });

        modelBuilder.Entity<AccountTrans>(entity =>
        {
            entity.Property(e => e.TransTime).ValueGeneratedNever();
        });

        modelBuilder.Entity<AccountTypeNames>(entity =>
        {
            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        modelBuilder.Entity<Accounts>(entity =>
        {
            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CardHasBonusPurse).HasDefaultValue((short)0);
            entity.Property(e => e.CardHasNoPurse).HasDefaultValue((short)0);

            entity.HasMany(d => d.Tag).WithMany(p => p.AccountNumber)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountsTags",
                    r => r.HasOne<Tags>().WithMany()
                        .HasForeignKey("TagId")
                        .HasConstraintName("AccountsTags_Tags_FK"),
                    l => l.HasOne<Accounts>().WithMany()
                        .HasForeignKey("AccountNumber")
                        .HasConstraintName("AccountsTags_Accounts_FK"),
                    j =>
                    {
                        j.HasKey("AccountNumber", "TagId").HasName("PK__Accounts__932008AD1B7E091A");
                        j.IndexerProperty<int>("TagId").HasColumnName("Tag_ID");
                    });
        });

        modelBuilder.Entity<Afs>(entity =>
        {
            entity.Property(e => e.AfsId).ValueGeneratedNever();
            entity.Property(e => e.AdminPassword).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.UserPassword).UseCollation("Cyrillic_General_CI_AS");
        });

        modelBuilder.Entity<AlcoWareType>(entity =>
        {
            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        modelBuilder.Entity<AltWareGroups>(entity =>
        {
            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        modelBuilder.Entity<BalanceByClientsPurses>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BalanceByProducts");

            entity.ToTable(tb => tb.HasTrigger("TR_BalanceByClientsPurses_U"));

            entity.Property(e => e.BalanceUpdateTime).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ClientCodeNavigation).WithMany(p => p.BalanceByClientsPurses).HasConstraintName("FK_BalanceByClientsPurses_Clients");
        });

        modelBuilder.Entity<BonusAddSchema>(entity =>
        {
            entity.Property(e => e.SchemaId).ValueGeneratedNever();
            entity.Property(e => e.NotInUse).HasDefaultValue((short)0);
            entity.Property(e => e.SaleType).HasDefaultValue(2);
        });

        modelBuilder.Entity<BonusCardCaterory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<BonusInformForAccounts>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<BonusSchemCardRange>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<BonusSchemPaymentTypes>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<BonusSchemWares>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<BonusTrans>(entity =>
        {
            entity.Property(e => e.TransTime).ValueGeneratedNever();
        });

        modelBuilder.Entity<BonusWriteOffByAccount>(entity =>
        {
            entity.Property(e => e.WriteOffDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<BonusWriteOffSchema>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_BonusWriteOffSchema_D"));

            entity.Property(e => e.DateBegin).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<BorderValueForDiscount>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CalcDiscountSchema>(entity =>
        {
            entity.Property(e => e.SchemaId).ValueGeneratedNever();
            entity.Property(e => e.DiscountType).HasDefaultValue(1);
            entity.Property(e => e.DynamicDiscountCalculation).HasDefaultValue((byte)0);
            entity.Property(e => e.IsBonusDiscount).HasDefaultValue((short)0);
            entity.Property(e => e.NotInUse).HasDefaultValue((short)0);
            entity.Property(e => e.SaleType).HasDefaultValue(2);
        });

        modelBuilder.Entity<CalcDiscountTable>(entity =>
        {
            entity.Property(e => e.TableId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CancelledFuelWholesales>(entity =>
        {
            entity.HasKey(e => e.FuelWholesaleId).HasName("PkCancelledFuelWholesales");

            entity.Property(e => e.FuelWholesaleId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CardHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CardHist__3214EC274A18FC72");

            entity.Property(e => e.Operation).HasComment("\r\n0 - инициализация истории (пишется дата открытия счета)\r\n1 - выдача карты\r\n2 - перевыдача карты\r\n3 - возврат карты\r\n4 - Ообновление пина и т.п.\r\n5 - Добавление в стоп-лист\r\n6 - Удаление из стоп-листа");

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.CardHistory).HasConstraintName("CardHistory_fk");
        });

        modelBuilder.Entity<CardStopList>(entity =>
        {
            entity.Property(e => e.CardNumber).ValueGeneratedNever();
        });

        modelBuilder.Entity<ClientFuelDrivers>(entity =>
        {
            entity.HasKey(e => new { e.ClientCode, e.FuelDriverCode }).HasName("PkClientFuelDrivers");
        });

        modelBuilder.Entity<ClientFuelLimits>(entity =>
        {
            entity.HasKey(e => new { e.ClientCode, e.ProductCode }).HasName("PkClientFuelLimits");

            entity.Property(e => e.Gid).IsFixedLength();
        });

        modelBuilder.Entity<ClientFuelPaymentDetails>(entity =>
        {
            entity.HasKey(e => new { e.FuelPaymentId, e.ProductCode }).HasName("PkClientFuelPaymentDetails");
        });

        modelBuilder.Entity<ClientFuelPayments>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PkClientFuelPayments");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Gid).IsFixedLength();
        });

        modelBuilder.Entity<ClientFuelPriceContracts>(entity =>
        {
            entity.HasKey(e => new { e.ClientCode, e.Id }).HasName("PkClientFuelPriceContracts");

            entity.Property(e => e.Gid).IsFixedLength();
        });

        modelBuilder.Entity<ClientFuelPrices>(entity =>
        {
            entity.HasKey(e => new { e.PriceContractId, e.ProductCode }).HasName("PkClientFuelPrices");
        });

        modelBuilder.Entity<ClientFuelRemainderCorrectionDetails>(entity =>
        {
            entity.HasKey(e => new { e.CorrectionId, e.ProductCode }).HasName("PkClientFuelRemainderCorrectionDetails");
        });

        modelBuilder.Entity<ClientFuelRemainderCorrections>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PkClientFuelRemainerCorrections");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Gid).IsFixedLength();
        });

        modelBuilder.Entity<ClientFuelRemainders>(entity =>
        {
            entity.HasKey(e => new { e.ClientCode, e.ProductCode, e.RemainderType }).HasName("PkClientFuelRemainders");
        });

        modelBuilder.Entity<ClientFuelSupplies>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PkClientFuelSupplies");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Gid).IsFixedLength();
        });

        modelBuilder.Entity<ClientFuelSupplyDetails>(entity =>
        {
            entity.HasKey(e => new { e.ClientFuelSupplyId, e.ProductCode }).HasName("PkClientFuelIncomingDetails");
        });

        modelBuilder.Entity<ClientFuelTransferDetails>(entity =>
        {
            entity.HasKey(e => new { e.TransferId, e.ProductCode }).HasName("PkClientFuelTransferDetails");
        });

        modelBuilder.Entity<ClientFuelTransfers>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PkClientFuelTransfers");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Gid).IsFixedLength();
        });

        modelBuilder.Entity<ClientLimits>(entity =>
        {
            entity.Property(e => e.LimitType).HasDefaultValue((short)3);
        });

        modelBuilder.Entity<ClientTrucks>(entity =>
        {
            entity.HasKey(e => new { e.ClientCode, e.TruckId }).HasName("PkClientTrucks");
        });

        modelBuilder.Entity<Clients>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_Clients_IU"));

            entity.Property(e => e.ClientCode).ValueGeneratedNever();
            entity.Property(e => e.AddInStopListAutomatic).HasDefaultValue((short)0);

            entity.HasMany(d => d.Tag).WithMany(p => p.ClientCodeNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "ClientsTags",
                    r => r.HasOne<Tags>().WithMany()
                        .HasForeignKey("TagId")
                        .HasConstraintName("ClientsTags_Tags_FK"),
                    l => l.HasOne<Clients>().WithMany()
                        .HasForeignKey("ClientCode")
                        .HasConstraintName("ClientsTags_Client_FR"),
                    j =>
                    {
                        j.HasKey("ClientCode", "TagId").HasName("PK__ClientsTags");
                        j.IndexerProperty<int>("TagId").HasColumnName("Tag_ID");
                    });
        });

        modelBuilder.Entity<ClientsThresholdDiscount>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Contractors>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_Contractors_U"));

            entity.Property(e => e.Address).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Bank).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.BankAccount).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ContactFace).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ContractNumber).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.CorrAccount).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.CorrBank).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.FullName).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Inn).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.IsClientOnly).HasDefaultValue((byte)1);
            entity.Property(e => e.Kpp).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Name).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Okonh).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Okpo).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Phones).UseCollation("Cyrillic_General_CI_AS");
        });

        modelBuilder.Entity<Contracts>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_Contracts_IU"));
        });

        modelBuilder.Entity<CouponDiscounts>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CouponDiscounts_pk");
        });

        modelBuilder.Entity<CouponSeries>(entity =>
        {
            entity.Property(e => e.SeriesId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Coupons>(entity =>
        {
            entity.Property(e => e.CouponCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<CouponsStore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CouponsS__3214EC27440B1D61");
        });

        modelBuilder.Entity<CurAccountTrans>(entity =>
        {
            entity.Property(e => e.TransTime).ValueGeneratedNever();
        });

        modelBuilder.Entity<CurBonusTrans>(entity =>
        {
            entity.Property(e => e.TransTime).ValueGeneratedNever();
        });

        modelBuilder.Entity<CurEventSize>(entity =>
        {
            entity.Property(e => e.EvtGuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<CurEvents>(entity =>
        {
            entity.Property(e => e.ObjId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CurRelays>(entity =>
        {
            entity.Property(e => e.AfsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<DbautoUpgrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DBUpgradeLog");

            entity.ToTable("DBAutoUpgrade", tb => tb.HasTrigger("TR_DBAutoUpgrade_D"));
        });

        modelBuilder.Entity<DelayedBonusAdditions>(entity =>
        {
            entity.Property(e => e.RecId).ValueGeneratedNever();
        });

        modelBuilder.Entity<DelayedCardAdditions>(entity =>
        {
            entity.Property(e => e.IsUnreturnedRest).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<DeletedItems>(entity =>
        {
            entity.Property(e => e.DeletionTime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<DiscountSchemCardRange>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<DiscountSchemPaymentTypes>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<DiscountSchemWares>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Discounts>(entity =>
        {
            entity.Property(e => e.RecNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DraftFuelWholesales>(entity =>
        {
            entity.HasKey(e => e.FuelWholesaleId).HasName("PkDraftFuelWholesales");

            entity.Property(e => e.FuelWholesaleId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ExternalCardOperations>(entity =>
        {
            entity.Property(e => e.OperationId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ExternalWareSupplyDetails>(entity =>
        {
            entity.Property(e => e.SupplyCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<FuelBases>(entity =>
        {
            entity.Property(e => e.Active).HasDefaultValue((byte)1);
        });

        modelBuilder.Entity<FuelBasesDeliveryPrices>(entity =>
        {
            entity.HasOne(d => d.FuelBase).WithMany(p => p.FuelBasesDeliveryPrices).HasConstraintName("FK_DeliveryPrices_FuelBases");
        });

        modelBuilder.Entity<FuelDrivers>(entity =>
        {
            entity.Property(e => e.FdrvCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<FuelProviders>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_FuelProviders_IU"));

            entity.Property(e => e.ProviderCode).ValueGeneratedNever();
            entity.Property(e => e.ProviderName).HasDefaultValue("не используется");

            entity.HasOne(d => d.Contractor).WithMany(p => p.FuelProviders).HasConstraintName("FK_FuelProviders_Contractors");
        });

        modelBuilder.Entity<FuelSell>(entity =>
        {
            entity.HasIndex(e => e.AccountNumber, "IX_FuelSell_By_AccountNumber").HasFilter("([AccountNumber] IS NOT NULL)");
        });

        modelBuilder.Entity<FuelSupplies>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PkFuelSupplies");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Gid).IsFixedLength();
        });

        modelBuilder.Entity<FuelSupplyDetails>(entity =>
        {
            entity.HasKey(e => new { e.SupplyId, e.SourceInfoCode }).HasName("PkFuelSupplyDetails");
        });

        modelBuilder.Entity<FuelWholesaleDetails>(entity =>
        {
            entity.HasKey(e => new { e.FuelWholesaleId, e.SectionId }).HasName("PkFuelWholesaleDetails");
        });

        modelBuilder.Entity<FuelWholesaleQueue>(entity =>
        {
            entity.HasKey(e => e.FuelWholesaleId).HasName("PkFuelWholesaleQueue");

            entity.Property(e => e.FuelWholesaleId).ValueGeneratedNever();
        });

        modelBuilder.Entity<FuelWholesales>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PkFuelWholesales");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Gid).IsFixedLength();
        });

        modelBuilder.Entity<GivenCoupons>(entity =>
        {
            entity.Property(e => e.RecId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Globals>(entity =>
        {
            entity.Property(e => e.Pkey).ValueGeneratedNever();
            entity.Property(e => e.AdminSmsnextTime).HasDefaultValueSql("('20170101 00:00')");
            entity.Property(e => e.LastAfscontrolHash).HasDefaultValue("");
            entity.Property(e => e.SmsbonusMsgTemplate).HasDefaultValue("Уважаемый %FIO%! Вам начислено %ADDED_BONUSES% бонусов, списано %REMOVED_BONUSES% бонусов. Время операции %OPERATION_DATE%. Всего на карте %TOTAL_BONUSES% бонусов");
            entity.Property(e => e.SmsproviderLogin).HasDefaultValue("");
            entity.Property(e => e.SmsproviderPassword).HasDefaultValue("");
        });

        modelBuilder.Entity<ImportedLogs>(entity =>
        {
            entity.Property(e => e.RecId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Invoice__3214EC27361203C5");
        });

        modelBuilder.Entity<InvoiceDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceD__3214EC273BCADD1B");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceDetail).HasConstraintName("InvoiceDetail_fk");
        });

        modelBuilder.Entity<JobTypes>(entity =>
        {
            entity.Property(e => e.JobId).ValueGeneratedNever();
        });

        modelBuilder.Entity<LinkSessions>(entity =>
        {
            entity.Property(e => e.EndTime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<LnrcardDirectory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<LoadingPoints>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PkLoadingPoints");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Gid).IsFixedLength();
        });

        modelBuilder.Entity<Manufacturers>(entity =>
        {
            entity.HasKey(e => e.ContractorId).HasName("PK_Manufacturer");

            entity.Property(e => e.ContractorId).ValueGeneratedNever();

            entity.HasOne(d => d.Contractor).WithOne(p => p.Manufacturers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Manufacturers_fk");
        });

        modelBuilder.Entity<MsgAdressat>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.AfsId }).HasName("PK_MSG_ADRESSAT");

            entity.HasOne(d => d.Afs).WithMany(p => p.MsgAdressat).HasConstraintName("FK_MSG_ADRESSAT_AFS");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.MsgAdressat).HasConstraintName("FK_MSG_ADRESSAT_MSG_MESSAGES");
        });

        modelBuilder.Entity<MsgAttachedFiles>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MSG_ATTACHEDFILES");

            entity.HasOne(d => d.MsgMessages).WithMany(p => p.MsgAttachedFiles).HasConstraintName("FK_MSG_ATTACHEDFIL_MSG_MESSAGES");
        });

        modelBuilder.Entity<MsgInBox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MSG_INBOX");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.MsgInBox).HasConstraintName("FK_MSG_INBOX_MSG_MESSAGES");
        });

        modelBuilder.Entity<MsgMessages>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MSG_MESSAGES");
        });

        modelBuilder.Entity<MsgOutBox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MSG_OUTBOX");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.MsgOutBox).HasConstraintName("FK_MSG_OUTBOX_MSG_MESSAGES");
        });

        modelBuilder.Entity<MsgSplitFile32k>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MSG_SPLITFILE32K");

            entity.HasOne(d => d.MsgAttachedFiles).WithMany(p => p.MsgSplitFile32k).HasConstraintName("FK_MSG_SPLITFILE32_MSG_ATTACHEDFIL");
        });

        modelBuilder.Entity<MsgVAdressat>(entity =>
        {
            entity.ToView("Msg_V_Adressat");
        });

        modelBuilder.Entity<MsgVInboxMessage>(entity =>
        {
            entity.ToView("Msg_V_InboxMessage");
        });

        modelBuilder.Entity<MsgVOutboxMessage>(entity =>
        {
            entity.ToView("Msg_V_OutboxMessage");
        });

        modelBuilder.Entity<Operators>(entity =>
        {
            entity.Property(e => e.OperatorCode).ValueGeneratedNever();
            entity.Property(e => e.HireDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<PaymentTypeGroups>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PaymentTypeGroups_PK");
        });

        modelBuilder.Entity<PaymentTypeGroupsDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PaymentTypeGroupsDetail_PK");

            entity.Property(e => e.IsActive).HasDefaultValue((byte)1);

            entity.HasOne(d => d.PaymentTypeGroup).WithMany(p => p.PaymentTypeGroupsDetail).HasConstraintName("PaymentTypeGroupsDetail_fk");
        });

        modelBuilder.Entity<PaymentTypes>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PaymentsInfo>(entity =>
        {
            entity.Property(e => e.Rtime).ValueGeneratedNever();
        });

        modelBuilder.Entity<Products>(entity =>
        {
            entity.Property(e => e.ProductCode).ValueGeneratedNever();
            entity.Property(e => e.EcrItemType).HasDefaultValue(2);
        });

        modelBuilder.Entity<PropsForWares>(entity =>
        {
            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        modelBuilder.Entity<PurseBonusAddFormula>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Relays>(entity =>
        {
            entity.Property(e => e.Rid).ValueGeneratedNever();
        });

        modelBuilder.Entity<RequiredTradeObjFlags>(entity =>
        {
            entity.HasKey(e => new { e.AfsId, e.NumPochunk }).HasName("PK_REQUIREDTRADEOBJFLAGS");

            entity.HasOne(d => d.Afs).WithMany(p => p.RequiredTradeObjFlags).HasConstraintName("FK_REQUIREDTRADEOB_AFS");
        });

        modelBuilder.Entity<RevaluationDocs>(entity =>
        {
            entity.Property(e => e.DocId).ValueGeneratedNever();
            entity.Property(e => e.AlwaysSet).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<SingleWareSells>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK_SingleWareSells");
        });

        modelBuilder.Entity<Smstemplates>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SMSTempl__3214EC2724B26D99");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SstfuelAdvanceOperation>(entity =>
        {
            entity.Property(e => e.UpdateCount).HasDefaultValue(1);
        });

        modelBuilder.Entity<Tags>(entity =>
        {
            entity.Property(e => e.ClientCode).HasComment("Код клиент, внутри которого действуют данные тэги, назначаются на счета");
        });

        modelBuilder.Entity<TankTrucks>(entity =>
        {
            entity.Property(e => e.TtCode).ValueGeneratedNever();
            entity.Property(e => e.IsActive).HasDefaultValue((byte)1);
            entity.Property(e => e.IsTrailer).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<Tanks>(entity =>
        {
            entity.Property(e => e.LmCorrection).HasDefaultValue(0);
        });

        modelBuilder.Entity<TimeLimitForBonus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LimitType).HasDefaultValue(0);
            entity.Property(e => e.WkDay).HasDefaultValue(0);

            entity.HasOne(d => d.Schema).WithMany(p => p.TimeLimitForBonus).HasConstraintName("FK_TimeLimitForBonus_BonusAddSchema");
        });

        modelBuilder.Entity<TimeLimitForDiscount>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LimitType).HasDefaultValue(0);
            entity.Property(e => e.WkDay).HasDefaultValue(0);
        });

        modelBuilder.Entity<TradeObjGroups>(entity =>
        {
            entity.Property(e => e.GroupId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TradeObjToApplyRevDoc>(entity =>
        {
            entity.Property(e => e.Guid).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.WasSet).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<VAccountTrans>(entity =>
        {
            entity.ToView("V_AccountTrans");
        });

        modelBuilder.Entity<VAccountTransBalanceByProduct>(entity =>
        {
            entity.ToView("V_AccountTransBalanceByProduct");
        });

        modelBuilder.Entity<VActiveAfs>(entity =>
        {
            entity.ToView("V_ActiveAfs");

            entity.Property(e => e.AdminPassword).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.UserPassword).UseCollation("Cyrillic_General_CI_AS");
        });

        modelBuilder.Entity<VAfsInGroup>(entity =>
        {
            entity.ToView("V_AfsInGroup");
        });

        modelBuilder.Entity<VAfsOutGroup>(entity =>
        {
            entity.ToView("V_AfsOutGroup");
        });

        modelBuilder.Entity<VAllAfs>(entity =>
        {
            entity.ToView("V_AllAfs");
        });

        modelBuilder.Entity<VBonusAddSchema>(entity =>
        {
            entity.ToView("V_BonusAddSchema");
        });

        modelBuilder.Entity<VBonusSchemPaymentTypes>(entity =>
        {
            entity.ToView("V_BonusSchemPaymentTypes");
        });

        modelBuilder.Entity<VBonusSchemWares>(entity =>
        {
            entity.ToView("V_BonusSchemWares");
        });

        modelBuilder.Entity<VCalcDiscountSchema>(entity =>
        {
            entity.ToView("V_CalcDiscountSchema");
        });

        modelBuilder.Entity<VCardHistory>(entity =>
        {
            entity.ToView("V_CardHistory");
        });

        modelBuilder.Entity<VClientBalance>(entity =>
        {
            entity.ToView("V_ClientBalance");
        });

        modelBuilder.Entity<VClients>(entity =>
        {
            entity.ToView("V_Clients");

            entity.Property(e => e.Address).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Bank).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.BankAccount).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ClientName).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ContactFace).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ContractNumber).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.CorrAccount).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.CorrBank).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.FullName).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Inn).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Kpp).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Okonh).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Okpo).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Phones).UseCollation("Cyrillic_General_CI_AS");
        });

        modelBuilder.Entity<VClientsTags>(entity =>
        {
            entity.ToView("V_ClientsTags");
        });

        modelBuilder.Entity<VContractors>(entity =>
        {
            entity.ToView("V_Contractors");

            entity.Property(e => e.Address).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Bank).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.BankAccount).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ContactFace).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ContractNumber).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.CorrAccount).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.CorrBank).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.FullName).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Inn).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Kpp).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Name).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Okonh).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Okpo).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Phones).UseCollation("Cyrillic_General_CI_AS");
        });

        modelBuilder.Entity<VContractorsShort>(entity =>
        {
            entity.ToView("V_ContractorsShort");

            entity.Property(e => e.Address).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ContactFace).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Inn).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Name).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Phones).UseCollation("Cyrillic_General_CI_AS");
        });

        modelBuilder.Entity<VContracts>(entity =>
        {
            entity.ToView("V_Contracts");
        });

        modelBuilder.Entity<VDiscountSchemPaymentTypes>(entity =>
        {
            entity.ToView("V_DiscountSchemPaymentTypes");
        });

        modelBuilder.Entity<VDiscountSchemWares>(entity =>
        {
            entity.ToView("V_DiscountSchemWares");
        });

        modelBuilder.Entity<VExternalCardRefunds>(entity =>
        {
            entity.ToView("V_ExternalCardRefunds");
        });

        modelBuilder.Entity<VFuelProviders>(entity =>
        {
            entity.ToView("V_FuelProviders");

            entity.Property(e => e.Address).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Bank).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.BankAccount).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ContactFace).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ContractNumber).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.CorrAccount).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.CorrBank).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.FullName).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Inn).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Kpp).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Okonh).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Okpo).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Phones).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ProviderName).UseCollation("Cyrillic_General_CI_AS");
        });

        modelBuilder.Entity<VManufacturers>(entity =>
        {
            entity.ToView("V_Manufacturers");

            entity.Property(e => e.Address).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Bank).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.BankAccount).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ContactFace).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.ContractNumber).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.CorrAccount).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.CorrBank).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.FullName).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Inn).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Kpp).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Name).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Okonh).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Okpo).UseCollation("Cyrillic_General_CI_AS");
            entity.Property(e => e.Phones).UseCollation("Cyrillic_General_CI_AS");
        });

        modelBuilder.Entity<VMoneyAndProducts>(entity =>
        {
            entity.ToView("V_MoneyAndProducts");
        });

        modelBuilder.Entity<VOurFirms>(entity =>
        {
            entity.ToView("V_OurFirms");
        });

        modelBuilder.Entity<VPaymentTypeGroups>(entity =>
        {
            entity.ToView("V_PaymentTypeGroups");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VPaymentsTrans>(entity =>
        {
            entity.ToView("V_PaymentsTrans");
        });

        modelBuilder.Entity<VProducts>(entity =>
        {
            entity.ToView("V_Products");
        });

        modelBuilder.Entity<VPurseNames>(entity =>
        {
            entity.ToView("V_PurseNames");
        });

        modelBuilder.Entity<VPurseProducts>(entity =>
        {
            entity.ToView("V_PurseProducts");
        });

        modelBuilder.Entity<VSbfuelSell>(entity =>
        {
            entity.ToView("V_SBFuelSell");
        });

        modelBuilder.Entity<VSbsingleWareSell>(entity =>
        {
            entity.ToView("V_SBSingleWareSell");
        });

        modelBuilder.Entity<VTimeLimitForBonus>(entity =>
        {
            entity.ToView("V_TimeLimitForBonus");
        });

        modelBuilder.Entity<VTimeLimitForDiscount>(entity =>
        {
            entity.ToView("V_TimeLimitForDiscount");
        });

        modelBuilder.Entity<VWareGroups>(entity =>
        {
            entity.ToView("V_WareGroups");
        });

        modelBuilder.Entity<VWareRemainderAfterLastRelay>(entity =>
        {
            entity.ToView("V_WareRemainderAfterLastRelay");
        });

        modelBuilder.Entity<VWaresAssembleWareSetJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_AssembleWareSetJournalDoc");
        });

        modelBuilder.Entity<VWaresCashlessExpenditureJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_CashlessExpenditureJournalDoc");
        });

        modelBuilder.Entity<VWaresCookingJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_CookingJournalDoc");
        });

        modelBuilder.Entity<VWaresDisAssembleWareSetJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_DisAssembleWareSetJournalDoc");
        });

        modelBuilder.Entity<VWaresExternalIncomeJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_ExternalIncomeJournalDoc");
        });

        modelBuilder.Entity<VWaresInternalIncomeJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_InternalIncomeJournalDoc");
        });

        modelBuilder.Entity<VWaresInventoryJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_InventoryJournalDoc");
        });

        modelBuilder.Entity<VWaresJournalDocItems>(entity =>
        {
            entity.ToView("V_Wares_JournalDocItems");
        });

        modelBuilder.Entity<VWaresMovementJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_MovementJournalDoc");
        });

        modelBuilder.Entity<VWaresProviderReturnJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_ProviderReturnJournalDoc");
        });

        modelBuilder.Entity<VWaresReceptionJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_ReceptionJournalDoc");
        });

        modelBuilder.Entity<VWaresRequestJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_RequestJournalDoc");
        });

        modelBuilder.Entity<VWaresRevJournalDocItems>(entity =>
        {
            entity.ToView("V_Wares_RevJournalDocItems");
        });

        modelBuilder.Entity<VWaresRevaluationJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_RevaluationJournalDoc");
        });

        modelBuilder.Entity<VWaresSellsJournalDocItems>(entity =>
        {
            entity.ToView("V_Wares_SellsJournalDocItems");
        });

        modelBuilder.Entity<VWaresWareSellJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_WareSellJournalDoc");
        });

        modelBuilder.Entity<VWaresWriteOffJournalDoc>(entity =>
        {
            entity.ToView("V_Wares_WriteOffJournalDoc");
        });

        modelBuilder.Entity<VWebLoginsAndAccounts>(entity =>
        {
            entity.ToView("V_WebLoginsAndAccounts");
        });

        modelBuilder.Entity<VWebLoginsAndAllAccounts>(entity =>
        {
            entity.ToView("V_WebLoginsAndAllAccounts");
        });

        modelBuilder.Entity<Vcards>(entity =>
        {
            entity.Property(e => e.AccountNumber).ValueGeneratedNever();

            entity.HasOne(d => d.AccountNumberNavigation).WithOne(p => p.Vcards).HasConstraintName("FK_VCards_Accounts");
        });

        modelBuilder.Entity<WareGroupPropsByAfs>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WareGroupsPropsByAFS");
        });

        modelBuilder.Entity<WareGroups>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_WareGroups_D"));

            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        modelBuilder.Entity<WareOrigins>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WareOrig__3214EC071A69E950");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<WareRemainders>(entity =>
        {
            entity.HasKey(e => new { e.WareCode, e.AfsId }).HasName("PK_WareRemainder");
        });

        modelBuilder.Entity<WareRev>(entity =>
        {
            entity.Property(e => e.OpId).ValueGeneratedNever();
            entity.Property(e => e.IsReversed).HasDefaultValue((byte)0);
        });

        modelBuilder.Entity<WareSupply>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_WareSupply_IU"));

            entity.Property(e => e.OpId).ValueGeneratedNever();
            entity.Property(e => e.IsReversed).HasDefaultValue((byte)0);
            entity.Property(e => e.JournalDocKind).HasDefaultValue((byte)0);
        });

        modelBuilder.Entity<WareTypes>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<WareUnits>(entity =>
        {
            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        modelBuilder.Entity<Wares>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_Wares_D"));

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.EnableFreePrice).HasDefaultValue((short)0);
            entity.Property(e => e.SellOnlyInBundling).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<WebAccessLogins>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WEBACCESSLOGINS");

            entity.Property(e => e.IsActive).HasDefaultValue((short)1);
            entity.Property(e => e.PassHash).IsFixedLength();

            entity.HasOne(d => d.ClientCodeNavigation).WithMany(p => p.WebAccessLogins).HasConstraintName("FK_WEBACCESSLOGINS_CLIENTS");

            entity.HasMany(d => d.AccountNumber).WithMany(p => p.Id)
                .UsingEntity<Dictionary<string, object>>(
                    "WebLoginsAndAccounts",
                    r => r.HasOne<Accounts>().WithMany()
                        .HasForeignKey("AccountNumber")
                        .HasConstraintName("FK_WEBLOGINSANDACC_ACCOUNTS"),
                    l => l.HasOne<WebAccessLogins>().WithMany()
                        .HasForeignKey("Id")
                        .HasConstraintName("FK_WEBLOGINSANDACC_WEBACCESSLOGINS"),
                    j =>
                    {
                        j.HasKey("Id", "AccountNumber").HasName("PK_WEBLOGINSANDACCOUNTS");
                        j.IndexerProperty<int>("Id").HasColumnName("ID");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
