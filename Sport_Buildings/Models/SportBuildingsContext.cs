using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sport_Buildings.Models
{
    public partial class SportBuildingsContext : DbContext
    {
        public SportBuildingsContext()
        {
        }

        public SportBuildingsContext(DbContextOptions<SportBuildingsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BuildingFoto> BuildingFoto { get; set; }
        public virtual DbSet<BuildingSportType> BuildingSportType { get; set; }
        public virtual DbSet<Buldings> Buldings { get; set; }
        public virtual DbSet<DamxmareNageboba> DamxmareNageboba { get; set; }
        public virtual DbSet<Dbtune> Dbtune { get; set; }
        public virtual DbSet<DeviceCodes> DeviceCodes { get; set; }
        public virtual DbSet<GdbItemrelationships> GdbItemrelationships { get; set; }
        public virtual DbSet<GdbItemrelationshiptypes> GdbItemrelationshiptypes { get; set; }
        public virtual DbSet<GdbItems> GdbItems { get; set; }
        public virtual DbSet<GdbItemtypes> GdbItemtypes { get; set; }
        public virtual DbSet<GdbReplicalog> GdbReplicalog { get; set; }
        public virtual DbSet<GdbTablesLastModified> GdbTablesLastModified { get; set; }
        public virtual DbSet<I10> I10 { get; set; }
        public virtual DbSet<I11> I11 { get; set; }
        public virtual DbSet<I12> I12 { get; set; }
        public virtual DbSet<I13> I13 { get; set; }
        public virtual DbSet<I14> I14 { get; set; }
        public virtual DbSet<I15> I15 { get; set; }
        public virtual DbSet<I16> I16 { get; set; }
        public virtual DbSet<I17> I17 { get; set; }
        public virtual DbSet<I2> I2 { get; set; }
        public virtual DbSet<I3> I3 { get; set; }
        public virtual DbSet<I4> I4 { get; set; }
        public virtual DbSet<I5> I5 { get; set; }
        public virtual DbSet<I6> I6 { get; set; }
        public virtual DbSet<I7> I7 { get; set; }
        public virtual DbSet<I8> I8 { get; set; }
        public virtual DbSet<I9> I9 { get; set; }
        public virtual DbSet<Lkpdaba> Lkpdaba { get; set; }
        public virtual DbSet<LkpdamxmareNagebobebi> LkpdamxmareNagebobebi { get; set; }
        public virtual DbSet<LkpmayureblistvisNageboba> LkpmayureblistvisNageboba { get; set; }
        public virtual DbSet<Lkpqalaqi> Lkpqalaqi { get; set; }
        public virtual DbSet<Lkpregion> Lkpregion { get; set; }
        public virtual DbSet<Lkpregioni> Lkpregioni { get; set; }
        public virtual DbSet<Lkpsofeli> Lkpsofeli { get; set; }
        public virtual DbSet<LkpsxvaShenobaNagebobebi> LkpsxvaShenobaNagebobebi { get; set; }
        public virtual DbSet<NabebobaMayureblebi> NabebobaMayureblebi { get; set; }
        public virtual DbSet<NagebobaSatavsoebi> NagebobaSatavsoebi { get; set; }
        public virtual DbSet<PersistedGrants> PersistedGrants { get; set; }
        public virtual DbSet<SdeArchives> SdeArchives { get; set; }
        public virtual DbSet<SdeColumnRegistry> SdeColumnRegistry { get; set; }
        public virtual DbSet<SdeDbtune> SdeDbtune { get; set; }
        public virtual DbSet<SdeGenerateGuid> SdeGenerateGuid { get; set; }
        public virtual DbSet<SdeGeometry1> SdeGeometry1 { get; set; }
        public virtual DbSet<SdeGeometry2> SdeGeometry2 { get; set; }
        public virtual DbSet<SdeGeometry3> SdeGeometry3 { get; set; }
        public virtual DbSet<SdeGeometry4> SdeGeometry4 { get; set; }
        public virtual DbSet<SdeGeometryColumns> SdeGeometryColumns { get; set; }
        public virtual DbSet<SdeLayerLocks> SdeLayerLocks { get; set; }
        public virtual DbSet<SdeLayerStats> SdeLayerStats { get; set; }
        public virtual DbSet<SdeLayers> SdeLayers { get; set; }
        public virtual DbSet<SdeLineagesModified> SdeLineagesModified { get; set; }
        public virtual DbSet<SdeLocators> SdeLocators { get; set; }
        public virtual DbSet<SdeLogfilePool> SdeLogfilePool { get; set; }
        public virtual DbSet<SdeMetadata> SdeMetadata { get; set; }
        public virtual DbSet<SdeMvtablesModified> SdeMvtablesModified { get; set; }
        public virtual DbSet<SdeObjectIds> SdeObjectIds { get; set; }
        public virtual DbSet<SdeObjectLocks> SdeObjectLocks { get; set; }
        public virtual DbSet<SdeProcessInformation> SdeProcessInformation { get; set; }
        public virtual DbSet<SdeRasterColumns> SdeRasterColumns { get; set; }
        public virtual DbSet<SdeServerConfig> SdeServerConfig { get; set; }
        public virtual DbSet<SdeSpatialReferences> SdeSpatialReferences { get; set; }
        public virtual DbSet<SdeStateLineages> SdeStateLineages { get; set; }
        public virtual DbSet<SdeStateLocks> SdeStateLocks { get; set; }
        public virtual DbSet<SdeStates> SdeStates { get; set; }
        public virtual DbSet<SdeTableLocks> SdeTableLocks { get; set; }
        public virtual DbSet<SdeTableRegistry> SdeTableRegistry { get; set; }
        public virtual DbSet<SdeTablesModified> SdeTablesModified { get; set; }
        public virtual DbSet<SdeVersion> SdeVersion { get; set; }
        public virtual DbSet<SdeVersions> SdeVersions { get; set; }
        public virtual DbSet<SdeXmlColumns> SdeXmlColumns { get; set; }
        public virtual DbSet<SdeXmlIndexTags> SdeXmlIndexTags { get; set; }
        public virtual DbSet<SdeXmlIndexes> SdeXmlIndexes { get; set; }
        public virtual DbSet<SportBuildings> SportBuildings { get; set; }
        public virtual DbSet<SportBuildingspoints> SportBuildingspoints { get; set; }
        public virtual DbSet<SportType> SportType { get; set; }
        public virtual DbSet<StGeometryColumns> StGeometryColumns { get; set; }
        public virtual DbSet<StSpatialReferenceSystems> StSpatialReferenceSystems { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<WebpagesMembership> WebpagesMembership { get; set; }
        public virtual DbSet<WebpagesOauthMembership> WebpagesOauthMembership { get; set; }
        public virtual DbSet<WebpagesRoles> WebpagesRoles { get; set; }
        public virtual DbSet<WebpagesUsersInRoles> WebpagesUsersInRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ALEKSANDRE;Database=SportBuildings;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<BuildingFoto>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Objectid)
                    .HasName("R12_SDE_ROWID_UK")
                    .IsUnique();

                entity.Property(e => e.BuildingCodeId).HasColumnName("BuildingCodeID");

                entity.Property(e => e.BuildingId)
                    .HasColumnName("BuildingID")
                    .HasMaxLength(50);

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");
            });

            modelBuilder.Entity<BuildingSportType>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Objectid)
                    .HasName("R10_SDE_ROWID_UK")
                    .IsUnique();

                entity.Property(e => e.BuildingId)
                    .HasColumnName("BuildingID")
                    .HasMaxLength(10);

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Saxeoba).HasMaxLength(60);

                entity.Property(e => e.SaxeobaOld).HasMaxLength(255);
            });

            modelBuilder.Entity<Buldings>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("R8_pk");

                entity.ToTable("BULDINGS");

                entity.Property(e => e.Objectid)
                    .HasColumnName("OBJECTID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.BuildingId)
                    .HasColumnName("BuildingID")
                    .HasMaxLength(50);

                entity.Property(e => e.DaniSnuleba).HasMaxLength(50);

                entity.Property(e => e.Dasaxeleba).HasMaxLength(50);

                entity.Property(e => e.FloorNumber)
                    .HasColumnName("Floor_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.PlaceNumber)
                    .HasColumnName("Place_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.RoomNumber)
                    .HasColumnName("Room_Number")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DamxmareNageboba>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("damxmare_nageboba");

                entity.HasIndex(e => e.Objectid)
                    .HasName("R9_SDE_ROWID_UK")
                    .IsUnique();

                entity.Property(e => e.Area).HasColumnType("numeric(38, 8)");

                entity.Property(e => e.BuildingId)
                    .HasColumnName("BuildingID")
                    .HasMaxLength(50);

                entity.Property(e => e.BuildingIdunic)
                    .HasColumnName("BuildingIDUnic")
                    .HasMaxLength(50);

                entity.Property(e => e.Danishnuleba)
                    .HasColumnName("danishnuleba")
                    .HasMaxLength(50);

                entity.Property(e => e.Dasaxeleba)
                    .HasColumnName("dasaxeleba")
                    .HasMaxLength(50);

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Raodenoba)
                    .HasColumnName("raodenoba")
                    .HasMaxLength(50);

                entity.Property(e => e.Shenishvna)
                    .HasColumnName("shenishvna")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dbtune>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("dbtune");

                entity.Property(e => e.ConfigString)
                    .HasColumnName("config_string")
                    .HasMaxLength(2048);

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasColumnName("keyword")
                    .HasMaxLength(32);

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasColumnName("parameter_name")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<DeviceCodes>(entity =>
            {
                entity.HasKey(e => e.UserCode);

                entity.HasIndex(e => e.DeviceCode)
                    .IsUnique();

                entity.HasIndex(e => e.Expiration);

                entity.Property(e => e.UserCode).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.DeviceCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SubjectId).HasMaxLength(200);
            });

            modelBuilder.Entity<GdbItemrelationships>(entity =>
            {
                entity.HasKey(e => e.ObjectId)
                    .HasName("R3_pk");

                entity.ToTable("GDB_ITEMRELATIONSHIPS");

                entity.HasIndex(e => e.Attributes)
                    .HasName("xmlval_GDB_ITEMRELATIONSHIPS_Attributes");

                entity.HasIndex(e => e.DestId)
                    .HasName("GDB_ItemRel_DestID_idx");

                entity.HasIndex(e => e.OriginId)
                    .HasName("GDB_ItemRel_OriginID_idx");

                entity.HasIndex(e => e.Type)
                    .HasName("GDB_ItemRel_Type_idx");

                entity.HasIndex(e => e.Uuid)
                    .HasName("GDB_ItemRelationships_UUID_idx")
                    .IsUnique();

                entity.Property(e => e.ObjectId)
                    .HasColumnName("ObjectID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Attributes).HasColumnType("xml");

                entity.Property(e => e.DestId).HasColumnName("DestID");

                entity.Property(e => e.OriginId).HasColumnName("OriginID");

                entity.Property(e => e.Uuid).HasColumnName("UUID");
            });

            modelBuilder.Entity<GdbItemrelationshiptypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GDB_ITEMRELATIONSHIPTYPES");

                entity.HasIndex(e => e.BackwardLabel)
                    .HasName("ItmRTypes_BackwardLabel_idx");

                entity.HasIndex(e => e.DestItemTypeId)
                    .HasName("ItmRTypes_DestItemTypeID_idx");

                entity.HasIndex(e => e.ForwardLabel)
                    .HasName("ItmRTypes_ForwardLabel_idx");

                entity.HasIndex(e => e.Name)
                    .HasName("ItmRTypes_Name_idx");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("R5_SDE_ROWID_UK")
                    .IsUnique();

                entity.HasIndex(e => e.OrigItemTypeId)
                    .HasName("ItmRTypes_OrigItemTypeID_idx");

                entity.HasIndex(e => e.Uuid)
                    .HasName("ItmRTypes_UUID_idx")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.BackwardLabel).HasMaxLength(226);

                entity.Property(e => e.DestItemTypeId).HasColumnName("DestItemTypeID");

                entity.Property(e => e.ForwardLabel).HasMaxLength(226);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(226);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.OrigItemTypeId).HasColumnName("OrigItemTypeID");

                entity.Property(e => e.Uuid).HasColumnName("UUID");
            });

            modelBuilder.Entity<GdbItems>(entity =>
            {
                entity.HasKey(e => e.ObjectId)
                    .HasName("R2_pk");

                entity.ToTable("GDB_ITEMS");

                entity.HasIndex(e => e.Definition)
                    .HasName("xmlval_GDB_ITEMS_Definition");

                entity.HasIndex(e => e.Documentation)
                    .HasName("xmlval_GDB_ITEMS_Documentation");

                entity.HasIndex(e => e.ItemInfo)
                    .HasName("xmlval_GDB_ITEMS_ItemInfo");

                entity.HasIndex(e => e.Name)
                    .HasName("Items_Name_idx");

                entity.HasIndex(e => e.PhysicalName)
                    .HasName("Items_PhysicalName_idx");

                entity.HasIndex(e => e.Type)
                    .HasName("Items_Type_idx");

                entity.HasIndex(e => e.Uuid)
                    .HasName("GDB_Items_UUID_idx")
                    .IsUnique();

                entity.Property(e => e.ObjectId)
                    .HasColumnName("ObjectID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatasetInfo1).HasMaxLength(255);

                entity.Property(e => e.DatasetInfo2).HasMaxLength(255);

                entity.Property(e => e.Definition).HasColumnType("xml");

                entity.Property(e => e.Documentation).HasColumnType("xml");

                entity.Property(e => e.ItemInfo).HasColumnType("xml");

                entity.Property(e => e.Name).HasMaxLength(226);

                entity.Property(e => e.Path).HasMaxLength(512);

                entity.Property(e => e.PhysicalName).HasMaxLength(226);

                entity.Property(e => e.Url).HasMaxLength(255);

                entity.Property(e => e.Uuid).HasColumnName("UUID");
            });

            modelBuilder.Entity<GdbItemtypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GDB_ITEMTYPES");

                entity.HasIndex(e => e.Name)
                    .HasName("ItemTypes_Name_idx");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("R4_SDE_ROWID_UK")
                    .IsUnique();

                entity.HasIndex(e => e.ParentTypeId)
                    .HasName("ItemTypes_ParentTypeID_idx");

                entity.HasIndex(e => e.Uuid)
                    .HasName("ItemTypes_UUID_idx")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(226);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.ParentTypeId).HasColumnName("ParentTypeID");

                entity.Property(e => e.Uuid).HasColumnName("UUID");
            });

            modelBuilder.Entity<GdbReplicalog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GDB_REPLICALOG");

                entity.HasIndex(e => e.Id)
                    .HasName("R6_SDE_ROWID_UK")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReplicaId).HasColumnName("ReplicaID");
            });

            modelBuilder.Entity<GdbTablesLastModified>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GDB_TABLES_LAST_MODIFIED");

                entity.HasIndex(e => e.TableName)
                    .HasName("GDB_LMODIFIED_IX1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.LastModifiedCount).HasColumnName("last_modified_count");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("table_name")
                    .HasMaxLength(160);
            });

            modelBuilder.Entity<I10>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i10_pk");

                entity.ToTable("i10");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I11>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i11_pk");

                entity.ToTable("i11");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I12>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i12_pk");

                entity.ToTable("i12");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I13>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i13_pk");

                entity.ToTable("i13");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I14>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i14_pk");

                entity.ToTable("i14");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I15>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i15_pk");

                entity.ToTable("i15");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I16>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i16_pk");

                entity.ToTable("i16");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I17>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i17_pk");

                entity.ToTable("i17");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I2>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i2_pk");

                entity.ToTable("i2");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I3>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i3_pk");

                entity.ToTable("i3");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I4>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i4_pk");

                entity.ToTable("i4");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I5>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i5_pk");

                entity.ToTable("i5");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I6>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i6_pk");

                entity.ToTable("i6");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I7>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i7_pk");

                entity.ToTable("i7");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I8>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i8_pk");

                entity.ToTable("i8");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<I9>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.NumIds, e.BaseId })
                    .HasName("i9_pk");

                entity.ToTable("i9");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.NumIds).HasColumnName("num_ids");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.LastId).HasColumnName("last_id");
            });

            modelBuilder.Entity<Lkpdaba>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LKPDaba");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            });

            modelBuilder.Entity<LkpdamxmareNagebobebi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LKPDamxmareNagebobebi");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            });

            modelBuilder.Entity<LkpmayureblistvisNageboba>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LKPMayureblistvisNageboba");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            });

            modelBuilder.Entity<Lkpqalaqi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LKPQalaqi");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            });

            modelBuilder.Entity<Lkpregion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LKPRegion");

                entity.HasIndex(e => e.Objectid)
                    .HasName("R13_SDE_ROWID_UK")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");
            });

            modelBuilder.Entity<Lkpregioni>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LKPRegioni");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            });

            modelBuilder.Entity<Lkpsofeli>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LKPSofeli");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            });

            modelBuilder.Entity<LkpsxvaShenobaNagebobebi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LKPSxvaShenobaNagebobebi");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            });

            modelBuilder.Entity<NabebobaMayureblebi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Nabeboba_Mayureblebi");

                entity.HasIndex(e => e.Objectid)
                    .HasName("R15_SDE_ROWID_UK")
                    .IsUnique();

                entity.Property(e => e.AdgilebisRaodenoba)
                    .HasColumnName("Adgilebis_Raodenoba")
                    .HasMaxLength(50);

                entity.Property(e => e.BuildingId)
                    .HasColumnName("BuildingID")
                    .HasMaxLength(50);

                entity.Property(e => e.BuildingIdunic)
                    .HasColumnName("BuildingIDUnic")
                    .HasMaxLength(50);

                entity.Property(e => e.KonsTipi)
                    .HasColumnName("Kons_Tipi")
                    .HasMaxLength(50);

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Raodenoba).HasMaxLength(50);

                entity.Property(e => e.RigebisRaodenoba)
                    .HasColumnName("Rigebis_Raodenoba")
                    .HasMaxLength(50);

                entity.Property(e => e.SheniSvna).HasMaxLength(50);
            });

            modelBuilder.Entity<NagebobaSatavsoebi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Nageboba_Satavsoebi");

                entity.HasIndex(e => e.Objectid)
                    .HasName("R14_SDE_ROWID_UK")
                    .IsUnique();

                entity.Property(e => e.BuildingId)
                    .HasColumnName("BuildingID")
                    .HasMaxLength(50);

                entity.Property(e => e.BuildingIdunic)
                    .HasColumnName("BuildingIDUnic")
                    .HasMaxLength(50);

                entity.Property(e => e.DaniSnuleba).HasMaxLength(50);

                entity.Property(e => e.Dasaxeleba).HasMaxLength(50);

                entity.Property(e => e.Drenaji)
                    .HasColumnName("drenaji")
                    .HasMaxLength(50);

                entity.Property(e => e.Eleqtrotablo)
                    .HasColumnName("eleqtrotablo")
                    .HasMaxLength(50);

                entity.Property(e => e.GanatebaLuqsi)
                    .HasColumnName("ganateba_Luqsi")
                    .HasMaxLength(50);

                entity.Property(e => e.GantarianobaOvarjishe)
                    .HasColumnName("gantarianoba_ovarjishe")
                    .HasMaxLength(50);

                entity.Property(e => e.Interneti)
                    .HasColumnName("interneti")
                    .HasMaxLength(50);

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Raodenoba).HasColumnName("raodenoba");

                entity.Property(e => e.Safari)
                    .HasColumnName("safari")
                    .HasMaxLength(50);

                entity.Property(e => e.Shenishvna)
                    .HasColumnName("shenishvna")
                    .HasMaxLength(50);

                entity.Property(e => e.Sigane)
                    .HasColumnName("sigane")
                    .HasMaxLength(50);

                entity.Property(e => e.Sigrdze)
                    .HasColumnName("sigrdze")
                    .HasMaxLength(50);

                entity.Property(e => e.Simagle)
                    .HasColumnName("simagle")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PersistedGrants>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => e.Expiration);

                entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type });

                entity.Property(e => e.Key).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SdeArchives>(entity =>
            {
                entity.HasKey(e => e.ArchivingRegid)
                    .HasName("archives_pk");

                entity.ToTable("SDE_archives");

                entity.HasIndex(e => e.HistoryRegid)
                    .HasName("archives_uk")
                    .IsUnique();

                entity.Property(e => e.ArchivingRegid)
                    .HasColumnName("archiving_regid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArchiveDate).HasColumnName("archive_date");

                entity.Property(e => e.ArchiveFlags).HasColumnName("archive_flags");

                entity.Property(e => e.FromDate)
                    .IsRequired()
                    .HasColumnName("from_date")
                    .HasMaxLength(32);

                entity.Property(e => e.HistoryRegid).HasColumnName("history_regid");

                entity.Property(e => e.ToDate)
                    .IsRequired()
                    .HasColumnName("to_date")
                    .HasMaxLength(32);

                entity.HasOne(d => d.ArchivingReg)
                    .WithOne(p => p.SdeArchivesArchivingReg)
                    .HasForeignKey<SdeArchives>(d => d.ArchivingRegid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("archives_fk1");

                entity.HasOne(d => d.HistoryReg)
                    .WithOne(p => p.SdeArchivesHistoryReg)
                    .HasForeignKey<SdeArchives>(d => d.HistoryRegid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("archives_fk2");
            });

            modelBuilder.Entity<SdeColumnRegistry>(entity =>
            {
                entity.HasKey(e => new { e.DatabaseName, e.TableName, e.Owner, e.ColumnName })
                    .HasName("colregistry_pk");

                entity.ToTable("SDE_column_registry");

                entity.Property(e => e.DatabaseName)
                    .HasColumnName("database_name")
                    .HasMaxLength(32);

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(128);

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(32);

                entity.Property(e => e.ColumnName)
                    .HasColumnName("column_name")
                    .HasMaxLength(32);

                entity.Property(e => e.ColumnSize).HasColumnName("column_size");

                entity.Property(e => e.DecimalDigits).HasColumnName("decimal_digits");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(65);

                entity.Property(e => e.ObjectFlags).HasColumnName("object_flags");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.SdeType).HasColumnName("sde_type");

                entity.HasOne(d => d.SdeTableRegistry)
                    .WithMany(p => p.SdeColumnRegistry)
                    .HasPrincipalKey(p => new { p.TableName, p.Owner, p.DatabaseName })
                    .HasForeignKey(d => new { d.TableName, d.Owner, d.DatabaseName })
                    .HasConstraintName("colregistry_fk");
            });

            modelBuilder.Entity<SdeDbtune>(entity =>
            {
                entity.HasKey(e => new { e.Keyword, e.ParameterName })
                    .HasName("dbtune_pk");

                entity.ToTable("SDE_dbtune");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasMaxLength(32);

                entity.Property(e => e.ParameterName)
                    .HasColumnName("parameter_name")
                    .HasMaxLength(32);

                entity.Property(e => e.ConfigString)
                    .HasColumnName("config_string")
                    .HasMaxLength(2048);
            });

            modelBuilder.Entity<SdeGenerateGuid>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SDE_generate_guid");

                entity.Property(e => e.Guidstr)
                    .HasColumnName("guidstr")
                    .HasMaxLength(38);
            });

            modelBuilder.Entity<SdeGeometry1>(entity =>
            {
                entity.HasKey(e => e.GeometryId)
                    .HasName("geom1_idx");

                entity.ToTable("SDE_GEOMETRY1");

                entity.Property(e => e.GeometryId)
                    .HasColumnName("GEOMETRY_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cad).HasColumnName("CAD");
            });

            modelBuilder.Entity<SdeGeometry2>(entity =>
            {
                entity.HasKey(e => e.GeometryId)
                    .HasName("geom2_idx");

                entity.ToTable("SDE_GEOMETRY2");

                entity.Property(e => e.GeometryId)
                    .HasColumnName("GEOMETRY_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cad).HasColumnName("CAD");
            });

            modelBuilder.Entity<SdeGeometry3>(entity =>
            {
                entity.HasKey(e => e.GeometryId)
                    .HasName("geom3_idx");

                entity.ToTable("SDE_GEOMETRY3");

                entity.Property(e => e.GeometryId)
                    .HasColumnName("GEOMETRY_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cad).HasColumnName("CAD");
            });

            modelBuilder.Entity<SdeGeometry4>(entity =>
            {
                entity.HasKey(e => e.GeometryId)
                    .HasName("geom4_idx");

                entity.ToTable("SDE_GEOMETRY4");

                entity.Property(e => e.GeometryId)
                    .HasColumnName("GEOMETRY_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cad).HasColumnName("CAD");
            });

            modelBuilder.Entity<SdeGeometryColumns>(entity =>
            {
                entity.HasKey(e => new { e.FTableCatalog, e.FTableSchema, e.FTableName, e.FGeometryColumn })
                    .HasName("geocol_pk");

                entity.ToTable("SDE_geometry_columns");

                entity.Property(e => e.FTableCatalog)
                    .HasColumnName("f_table_catalog")
                    .HasMaxLength(32);

                entity.Property(e => e.FTableSchema)
                    .HasColumnName("f_table_schema")
                    .HasMaxLength(32);

                entity.Property(e => e.FTableName)
                    .HasColumnName("f_table_name")
                    .HasMaxLength(128);

                entity.Property(e => e.FGeometryColumn)
                    .HasColumnName("f_geometry_column")
                    .HasMaxLength(32);

                entity.Property(e => e.CoordDimension).HasColumnName("coord_dimension");

                entity.Property(e => e.GTableCatalog)
                    .HasColumnName("g_table_catalog")
                    .HasMaxLength(32);

                entity.Property(e => e.GTableName)
                    .IsRequired()
                    .HasColumnName("g_table_name")
                    .HasMaxLength(128);

                entity.Property(e => e.GTableSchema)
                    .IsRequired()
                    .HasColumnName("g_table_schema")
                    .HasMaxLength(32);

                entity.Property(e => e.GeometryType).HasColumnName("geometry_type");

                entity.Property(e => e.MaxPpr).HasColumnName("max_ppr");

                entity.Property(e => e.Srid).HasColumnName("srid");

                entity.Property(e => e.StorageType).HasColumnName("storage_type");

                entity.HasOne(d => d.Sr)
                    .WithMany(p => p.SdeGeometryColumns)
                    .HasForeignKey(d => d.Srid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("geocol_fk");
            });

            modelBuilder.Entity<SdeLayerLocks>(entity =>
            {
                entity.HasKey(e => new { e.SdeId, e.LayerId, e.Autolock, e.LockType })
                    .HasName("layer_locks_pk");

                entity.ToTable("SDE_layer_locks");

                entity.Property(e => e.SdeId).HasColumnName("sde_id");

                entity.Property(e => e.LayerId).HasColumnName("layer_id");

                entity.Property(e => e.Autolock)
                    .HasColumnName("autolock")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LockType)
                    .HasColumnName("lock_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LockTime)
                    .HasColumnName("lock_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Maxx).HasColumnName("maxx");

                entity.Property(e => e.Maxy).HasColumnName("maxy");

                entity.Property(e => e.Minx).HasColumnName("minx");

                entity.Property(e => e.Miny).HasColumnName("miny");
            });

            modelBuilder.Entity<SdeLayerStats>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("sdelayer_stats_pk");

                entity.ToTable("SDE_layer_stats");

                entity.HasIndex(e => new { e.LayerId, e.VersionId })
                    .HasName("sdelayer_stats_uk")
                    .IsUnique();

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.LastAnalyzed)
                    .HasColumnName("last_analyzed")
                    .HasColumnType("datetime");

                entity.Property(e => e.LayerId).HasColumnName("layer_id");

                entity.Property(e => e.Maxm).HasColumnName("maxm");

                entity.Property(e => e.Maxx).HasColumnName("maxx");

                entity.Property(e => e.Maxy).HasColumnName("maxy");

                entity.Property(e => e.Maxz).HasColumnName("maxz");

                entity.Property(e => e.Minm).HasColumnName("minm");

                entity.Property(e => e.Minx).HasColumnName("minx");

                entity.Property(e => e.Miny).HasColumnName("miny");

                entity.Property(e => e.Minz).HasColumnName("minz");

                entity.Property(e => e.TotalFeatures).HasColumnName("total_features");

                entity.Property(e => e.TotalPoints).HasColumnName("total_points");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.HasOne(d => d.Layer)
                    .WithMany(p => p.SdeLayerStats)
                    .HasPrincipalKey(p => p.LayerId)
                    .HasForeignKey(d => d.LayerId)
                    .HasConstraintName("sdelayer_stats_fk1");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.SdeLayerStats)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("sdelayer_stats_fk2");
            });

            modelBuilder.Entity<SdeLayers>(entity =>
            {
                entity.HasKey(e => new { e.DatabaseName, e.TableName, e.Owner, e.SpatialColumn })
                    .HasName("layers_pk");

                entity.ToTable("SDE_layers");

                entity.HasIndex(e => e.LayerId)
                    .HasName("layers_uk")
                    .IsUnique();

                entity.Property(e => e.DatabaseName)
                    .HasColumnName("database_name")
                    .HasMaxLength(128);

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(128);

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(128);

                entity.Property(e => e.SpatialColumn)
                    .HasColumnName("spatial_column")
                    .HasMaxLength(128);

                entity.Property(e => e.BaseLayerId).HasColumnName("base_layer_id");

                entity.Property(e => e.Cdate).HasColumnName("cdate");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(65);

                entity.Property(e => e.Eflags).HasColumnName("eflags");

                entity.Property(e => e.Gsize1).HasColumnName("gsize1");

                entity.Property(e => e.Gsize2).HasColumnName("gsize2");

                entity.Property(e => e.Gsize3).HasColumnName("gsize3");

                entity.Property(e => e.LayerConfig)
                    .HasColumnName("layer_config")
                    .HasMaxLength(32);

                entity.Property(e => e.LayerId).HasColumnName("layer_id");

                entity.Property(e => e.LayerMask).HasColumnName("layer_mask");

                entity.Property(e => e.Maxm).HasColumnName("maxm");

                entity.Property(e => e.Maxx).HasColumnName("maxx");

                entity.Property(e => e.Maxy).HasColumnName("maxy");

                entity.Property(e => e.Maxz).HasColumnName("maxz");

                entity.Property(e => e.MinimumId).HasColumnName("minimum_id");

                entity.Property(e => e.Minm).HasColumnName("minm");

                entity.Property(e => e.Minx).HasColumnName("minx");

                entity.Property(e => e.Miny).HasColumnName("miny");

                entity.Property(e => e.Minz).HasColumnName("minz");

                entity.Property(e => e.OptimalArraySize).HasColumnName("optimal_array_size");

                entity.Property(e => e.SecondarySrid).HasColumnName("secondary_srid");

                entity.Property(e => e.Srid).HasColumnName("srid");

                entity.Property(e => e.StatsDate).HasColumnName("stats_date");

                entity.HasOne(d => d.SecondarySr)
                    .WithMany(p => p.SdeLayersSecondarySr)
                    .HasForeignKey(d => d.SecondarySrid)
                    .HasConstraintName("layers_sfk");

                entity.HasOne(d => d.Sr)
                    .WithMany(p => p.SdeLayersSr)
                    .HasForeignKey(d => d.Srid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("layers_fk");
            });

            modelBuilder.Entity<SdeLineagesModified>(entity =>
            {
                entity.HasKey(e => e.LineageName)
                    .HasName("lineages_mod_pk");

                entity.ToTable("SDE_lineages_modified");

                entity.Property(e => e.LineageName)
                    .HasColumnName("lineage_name")
                    .ValueGeneratedNever();

                entity.Property(e => e.TimeLastModified)
                    .HasColumnName("time_last_modified")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SdeLocators>(entity =>
            {
                entity.HasKey(e => e.LocatorId)
                    .HasName("sdelocators_pk");

                entity.ToTable("SDE_locators");

                entity.HasIndex(e => new { e.Name, e.Owner })
                    .HasName("sdelocators_uk")
                    .IsUnique();

                entity.Property(e => e.LocatorId)
                    .HasColumnName("locator_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(32);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32);

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("owner")
                    .HasMaxLength(32);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SdeLogfilePool>(entity =>
            {
                entity.HasKey(e => e.TableId)
                    .HasName("logfile_pool_pk");

                entity.ToTable("SDE_logfile_pool");

                entity.Property(e => e.TableId)
                    .HasColumnName("table_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SdeId).HasColumnName("sde_id");
            });

            modelBuilder.Entity<SdeMetadata>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("sdemetadata_pk");

                entity.ToTable("SDE_metadata");

                entity.Property(e => e.RecordId)
                    .HasColumnName("record_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .HasColumnName("class_name")
                    .HasMaxLength(32);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(65);

                entity.Property(e => e.ObjectDatabase)
                    .HasColumnName("object_database")
                    .HasMaxLength(32);

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasColumnName("object_name")
                    .HasMaxLength(160);

                entity.Property(e => e.ObjectOwner)
                    .IsRequired()
                    .HasColumnName("object_owner")
                    .HasMaxLength(32);

                entity.Property(e => e.ObjectType).HasColumnName("object_type");

                entity.Property(e => e.PropValue)
                    .HasColumnName("prop_value")
                    .HasMaxLength(255);

                entity.Property(e => e.Property)
                    .HasColumnName("property")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<SdeMvtablesModified>(entity =>
            {
                entity.HasKey(e => new { e.StateId, e.RegistrationId })
                    .HasName("mvtables_modified_pk");

                entity.ToTable("SDE_mvtables_modified");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.RegistrationId).HasColumnName("registration_id");

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.SdeMvtablesModified)
                    .HasForeignKey(d => d.RegistrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mvtables_modified_fk2");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.SdeMvtablesModified)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mvtables_modified_fk1");
            });

            modelBuilder.Entity<SdeObjectIds>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("object_ids_pk");

                entity.ToTable("SDE_object_ids");

                entity.Property(e => e.IdType)
                    .HasColumnName("id_type")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasColumnName("object_type")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SdeObjectLocks>(entity =>
            {
                entity.HasKey(e => new { e.SdeId, e.ObjectId, e.ObjectType, e.ApplicationId, e.Autolock, e.LockType })
                    .HasName("object_locks_pk");

                entity.ToTable("SDE_object_locks");

                entity.Property(e => e.SdeId).HasColumnName("sde_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectType).HasColumnName("object_type");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.Autolock)
                    .HasColumnName("autolock")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LockType)
                    .HasColumnName("lock_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LockTime)
                    .HasColumnName("lock_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SdeProcessInformation>(entity =>
            {
                entity.HasKey(e => e.SdeId)
                    .HasName("process_pk");

                entity.ToTable("SDE_process_information");

                entity.Property(e => e.SdeId)
                    .HasColumnName("sde_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DirectConnect)
                    .IsRequired()
                    .HasColumnName("direct_connect")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FbCount).HasColumnName("fb_count");

                entity.Property(e => e.FbFcount).HasColumnName("fb_fcount");

                entity.Property(e => e.FbKbytes).HasColumnName("fb_kbytes");

                entity.Property(e => e.FbPartial).HasColumnName("fb_partial");

                entity.Property(e => e.Nodename)
                    .IsRequired()
                    .HasColumnName("nodename")
                    .HasMaxLength(256);

                entity.Property(e => e.Numlocks).HasColumnName("numlocks");

                entity.Property(e => e.Opcount).HasColumnName("opcount");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("owner")
                    .HasMaxLength(30);

                entity.Property(e => e.Rcount).HasColumnName("rcount");

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.Spid).HasColumnName("spid");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasColumnName("sysname")
                    .HasMaxLength(32);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("table_name")
                    .HasMaxLength(95);

                entity.Property(e => e.Wcount).HasColumnName("wcount");

                entity.Property(e => e.XdrNeeded)
                    .IsRequired()
                    .HasColumnName("xdr_needed")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SdeRasterColumns>(entity =>
            {
                entity.HasKey(e => new { e.DatabaseName, e.Owner, e.TableName, e.RasterColumn })
                    .HasName("rascol_pk");

                entity.ToTable("SDE_raster_columns");

                entity.HasIndex(e => e.RastercolumnId)
                    .HasName("rascol_uk")
                    .IsUnique();

                entity.Property(e => e.DatabaseName)
                    .HasColumnName("database_name")
                    .HasMaxLength(32);

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(32);

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(128);

                entity.Property(e => e.RasterColumn)
                    .HasColumnName("raster_column")
                    .HasMaxLength(32);

                entity.Property(e => e.BaseRastercolumnId).HasColumnName("base_rastercolumn_id");

                entity.Property(e => e.Cdate).HasColumnName("cdate");

                entity.Property(e => e.ConfigKeyword)
                    .HasColumnName("config_keyword")
                    .HasMaxLength(32);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(65);

                entity.Property(e => e.MinimumId).HasColumnName("minimum_id");

                entity.Property(e => e.RastercolumnId).HasColumnName("rastercolumn_id");

                entity.Property(e => e.RastercolumnMask).HasColumnName("rastercolumn_mask");

                entity.Property(e => e.Srid).HasColumnName("srid");

                entity.HasOne(d => d.Sr)
                    .WithMany(p => p.SdeRasterColumns)
                    .HasForeignKey(d => d.Srid)
                    .HasConstraintName("rascol_fk");
            });

            modelBuilder.Entity<SdeServerConfig>(entity =>
            {
                entity.HasKey(e => e.PropName)
                    .HasName("server_config_pk");

                entity.ToTable("SDE_server_config");

                entity.Property(e => e.PropName)
                    .HasColumnName("prop_name")
                    .HasMaxLength(32);

                entity.Property(e => e.CharPropValue)
                    .HasColumnName("char_prop_value")
                    .HasMaxLength(512);

                entity.Property(e => e.NumPropValue).HasColumnName("num_prop_value");
            });

            modelBuilder.Entity<SdeSpatialReferences>(entity =>
            {
                entity.HasKey(e => e.Srid)
                    .HasName("spatial_ref_pk");

                entity.ToTable("SDE_spatial_references");

                entity.Property(e => e.Srid)
                    .HasColumnName("srid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthName)
                    .HasColumnName("auth_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AuthSrid).HasColumnName("auth_srid");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(64);

                entity.Property(e => e.Falsem).HasColumnName("falsem");

                entity.Property(e => e.Falsex).HasColumnName("falsex");

                entity.Property(e => e.Falsey).HasColumnName("falsey");

                entity.Property(e => e.Falsez).HasColumnName("falsez");

                entity.Property(e => e.MclusterTol).HasColumnName("mcluster_tol");

                entity.Property(e => e.Munits).HasColumnName("munits");

                entity.Property(e => e.ObjectFlags).HasColumnName("object_flags");

                entity.Property(e => e.Srtext)
                    .IsRequired()
                    .HasColumnName("srtext")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.XyclusterTol).HasColumnName("xycluster_tol");

                entity.Property(e => e.Xyunits).HasColumnName("xyunits");

                entity.Property(e => e.ZclusterTol).HasColumnName("zcluster_tol");

                entity.Property(e => e.Zunits).HasColumnName("zunits");
            });

            modelBuilder.Entity<SdeStateLineages>(entity =>
            {
                entity.HasKey(e => new { e.LineageName, e.LineageId })
                    .HasName("state_lineages_pk");

                entity.ToTable("SDE_state_lineages");

                entity.HasIndex(e => e.LineageId)
                    .HasName("lineage_id_idx2");

                entity.Property(e => e.LineageName).HasColumnName("lineage_name");

                entity.Property(e => e.LineageId).HasColumnName("lineage_id");
            });

            modelBuilder.Entity<SdeStateLocks>(entity =>
            {
                entity.HasKey(e => new { e.SdeId, e.StateId, e.Autolock, e.LockType })
                    .HasName("state_locks_pk");

                entity.ToTable("SDE_state_locks");

                entity.Property(e => e.SdeId).HasColumnName("sde_id");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.Autolock)
                    .HasColumnName("autolock")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LockType)
                    .HasColumnName("lock_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LockTime)
                    .HasColumnName("lock_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SdeStates>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("states_pk");

                entity.ToTable("SDE_states");

                entity.HasIndex(e => new { e.ParentStateId, e.LineageName })
                    .HasName("states_cuk")
                    .IsUnique();

                entity.Property(e => e.StateId)
                    .HasColumnName("state_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClosingTime)
                    .HasColumnName("closing_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreationTime)
                    .HasColumnName("creation_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LineageName).HasColumnName("lineage_name");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("owner")
                    .HasMaxLength(32);

                entity.Property(e => e.ParentStateId).HasColumnName("parent_state_id");
            });

            modelBuilder.Entity<SdeTableLocks>(entity =>
            {
                entity.HasKey(e => new { e.SdeId, e.RegistrationId, e.LockType })
                    .HasName("table_locks_pk");

                entity.ToTable("SDE_table_locks");

                entity.Property(e => e.SdeId).HasColumnName("sde_id");

                entity.Property(e => e.RegistrationId).HasColumnName("registration_id");

                entity.Property(e => e.LockType)
                    .HasColumnName("lock_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LockTime)
                    .HasColumnName("lock_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SdeTableRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistrationId)
                    .HasName("registry_pk");

                entity.ToTable("SDE_table_registry");

                entity.HasIndex(e => new { e.TableName, e.Owner, e.DatabaseName })
                    .HasName("registry_uk2")
                    .IsUnique();

                entity.Property(e => e.RegistrationId)
                    .HasColumnName("registration_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfigKeyword)
                    .HasColumnName("config_keyword")
                    .HasMaxLength(32);

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasColumnName("database_name")
                    .HasMaxLength(32);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(65);

                entity.Property(e => e.ImvViewName)
                    .HasColumnName("imv_view_name")
                    .HasMaxLength(128);

                entity.Property(e => e.MinimumId).HasColumnName("minimum_id");

                entity.Property(e => e.ObjectFlags).HasColumnName("object_flags");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("owner")
                    .HasMaxLength(32);

                entity.Property(e => e.RegistrationDate).HasColumnName("registration_date");

                entity.Property(e => e.RowidColumn)
                    .HasColumnName("rowid_column")
                    .HasMaxLength(32);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("table_name")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<SdeTablesModified>(entity =>
            {
                entity.HasKey(e => e.TableName)
                    .HasName("tables_modified_pk");

                entity.ToTable("SDE_tables_modified");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(128);

                entity.Property(e => e.TimeLastModified)
                    .HasColumnName("time_last_modified")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SdeVersion>(entity =>
            {
                entity.HasKey(e => e.Major)
                    .HasName("version_pk");

                entity.ToTable("SDE_version");

                entity.Property(e => e.Major)
                    .HasColumnName("MAJOR")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bugfix).HasColumnName("BUGFIX");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(96);

                entity.Property(e => e.Minor).HasColumnName("MINOR");

                entity.Property(e => e.Release).HasColumnName("RELEASE");

                entity.Property(e => e.SdesvrRelLow).HasColumnName("SDESVR_REL_LOW");
            });

            modelBuilder.Entity<SdeVersions>(entity =>
            {
                entity.HasKey(e => e.VersionId)
                    .HasName("versions_pk");

                entity.ToTable("SDE_versions");

                entity.HasIndex(e => e.StateId)
                    .HasName("ver_state_ix");

                entity.HasIndex(e => new { e.Name, e.Owner })
                    .HasName("versions_uk")
                    .IsUnique();

                entity.Property(e => e.VersionId)
                    .HasColumnName("version_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationTime)
                    .HasColumnName("creation_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64);

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("owner")
                    .HasMaxLength(32);

                entity.Property(e => e.ParentName)
                    .HasColumnName("parent_name")
                    .HasMaxLength(64);

                entity.Property(e => e.ParentOwner)
                    .HasColumnName("parent_owner")
                    .HasMaxLength(32);

                entity.Property(e => e.ParentVersionId).HasColumnName("parent_version_id");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<SdeXmlColumns>(entity =>
            {
                entity.HasKey(e => e.ColumnId)
                    .HasName("xml_columns_pk")
                    .IsClustered(false);

                entity.ToTable("SDE_xml_columns");

                entity.HasIndex(e => new { e.RegistrationId, e.ColumnName })
                    .HasName("xml_columns_uk")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ColumnId).HasColumnName("column_id");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasColumnName("column_name")
                    .HasMaxLength(32);

                entity.Property(e => e.ConfigKeyword)
                    .HasColumnName("config_keyword")
                    .HasMaxLength(32);

                entity.Property(e => e.IndexId).HasColumnName("index_id");

                entity.Property(e => e.MinimumId).HasColumnName("minimum_id");

                entity.Property(e => e.RegistrationId).HasColumnName("registration_id");

                entity.Property(e => e.Xflags).HasColumnName("xflags");

                entity.HasOne(d => d.Index)
                    .WithMany(p => p.SdeXmlColumns)
                    .HasForeignKey(d => d.IndexId)
                    .HasConstraintName("xml_columns_fk2");

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.SdeXmlColumns)
                    .HasForeignKey(d => d.RegistrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("xml_columns_fk1");
            });

            modelBuilder.Entity<SdeXmlIndexTags>(entity =>
            {
                entity.HasKey(e => new { e.IndexId, e.TagId })
                    .HasName("xml_indextags_pk");

                entity.ToTable("SDE_xml_index_tags");

                entity.HasIndex(e => e.TagAlias)
                    .HasName("xml_indextags_ix2");

                entity.HasIndex(e => e.TagName)
                    .HasName("xml_indextags_ix1");

                entity.Property(e => e.IndexId).HasColumnName("index_id");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DataType).HasColumnName("data_type");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(64);

                entity.Property(e => e.IsExcluded).HasColumnName("is_excluded");

                entity.Property(e => e.TagAlias).HasColumnName("tag_alias");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasColumnName("tag_name")
                    .HasMaxLength(1024);

                entity.HasOne(d => d.Index)
                    .WithMany(p => p.SdeXmlIndexTags)
                    .HasForeignKey(d => d.IndexId)
                    .HasConstraintName("xml_indextags_fk1");
            });

            modelBuilder.Entity<SdeXmlIndexes>(entity =>
            {
                entity.HasKey(e => e.IndexId)
                    .HasName("xml_indexes_pk");

                entity.ToTable("SDE_xml_indexes");

                entity.HasIndex(e => new { e.Owner, e.IndexName })
                    .HasName("xml_indexes_uk")
                    .IsUnique();

                entity.Property(e => e.IndexId).HasColumnName("index_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(64);

                entity.Property(e => e.IndexName)
                    .IsRequired()
                    .HasColumnName("index_name")
                    .HasMaxLength(32);

                entity.Property(e => e.IndexType).HasColumnName("index_type");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("owner")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<SportBuildings>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("R7_pk");

                entity.ToTable("SPORT_BUILDINGS");

                entity.Property(e => e.Objectid)
                    .HasColumnName("OBJECTID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BuildingId)
                    .HasColumnName("BuildingID")
                    .HasMaxLength(50);

                entity.Property(e => e.BuildingName)
                    .HasColumnName("Building_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.Daba).HasMaxLength(50);

                entity.Property(e => e.DawesebulebisXelmdzgvaneli)
                    .HasColumnName("Dawesebulebis_Xelmdzgvaneli")
                    .HasMaxLength(100);

                entity.Property(e => e.ElKveba)
                    .HasColumnName("el_Kveba")
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EqspSesvlisTariRi)
                    .HasColumnName("Eqsp_Sesvlis_TariRi")
                    .HasMaxLength(50);

                entity.Property(e => e.Gatboba)
                    .HasColumnName("gatboba")
                    .HasMaxLength(10);

                entity.Property(e => e.Gengegma)
                    .HasColumnName("gengegma")
                    .HasMaxLength(50);

                entity.Property(e => e.GoogleMapCoordinates).HasMaxLength(200);

                entity.Property(e => e.Interneti)
                    .HasColumnName("interneti")
                    .HasMaxLength(50);

                entity.Property(e => e.Kondicireba)
                    .HasColumnName("kondicireba")
                    .HasMaxLength(50);

                entity.Property(e => e.NagebobisMdgomareoba).HasMaxLength(100);

                entity.Property(e => e.NagebobisStatusi).HasMaxLength(150);

                entity.Property(e => e.OrganizaciisIuridiuliSaxelwodeba).HasMaxLength(200);

                entity.Property(e => e.OrganizaciisIuridiuliStatusi).HasMaxLength(100);

                entity.Property(e => e.OrganizaciisXelmdzgvaneli).HasMaxLength(150);

                entity.Property(e => e.OrganizaciisXelmdzgvanelisStatusi).HasMaxLength(100);

                entity.Property(e => e.OwnedBy)
                    .HasColumnName("Owned_by")
                    .HasMaxLength(50);

                entity.Property(e => e.ParcelArea)
                    .HasColumnName("Parcel_Area")
                    .HasMaxLength(50);

                entity.Property(e => e.PassNumber).HasColumnName("Pass_Number");

                entity.Property(e => e.Pictures).HasMaxLength(150);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.Qalaqi).HasMaxLength(50);

                entity.Property(e => e.Qucha).HasMaxLength(50);

                entity.Property(e => e.Radioficireba)
                    .HasColumnName("radioficireba")
                    .HasMaxLength(50);

                entity.Property(e => e.Raioni).HasMaxLength(50);

                entity.Property(e => e.Regioni).HasMaxLength(255);

                entity.Property(e => e.SabalansoRirebuleba)
                    .HasColumnName("Sabalanso_Rirebuleba")
                    .HasMaxLength(50);

                entity.Property(e => e.Sakutreba).HasMaxLength(255);

                entity.Property(e => e.SaqKodi)
                    .HasColumnName("saq_kodi")
                    .HasMaxLength(50);

                entity.Property(e => e.Saxli).HasMaxLength(50);

                entity.Property(e => e.Sofeli).HasMaxLength(50);

                entity.Property(e => e.SportTypeId).HasColumnName("SportTypeID");

                entity.Property(e => e.TelNumber)
                    .HasColumnName("Tel_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.TeqnikuriAgwera)
                    .HasColumnName("Teqnikuri_Agwera")
                    .HasMaxLength(250);

                entity.Property(e => e.TeritorisSemogobva)
                    .HasColumnName("teritoris_Semogobva")
                    .HasMaxLength(50);

                entity.Property(e => e.Ventilacia)
                    .HasColumnName("ventilacia")
                    .HasMaxLength(50);

                entity.Property(e => e.WebSite).HasMaxLength(100);

                entity.Property(e => e.Wyalmomarageba)
                    .HasColumnName("wyalmomarageba")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SportBuildingspoints>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("R16_pk");

                entity.ToTable("SPORT_BUILDINGSPOINTS");

                entity.Property(e => e.Objectid)
                    .HasColumnName("OBJECTID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BuildingId)
                    .HasColumnName("BuildingID")
                    .HasMaxLength(50);

                entity.Property(e => e.BuildingName)
                    .HasColumnName("Building_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.Daba).HasMaxLength(50);

                entity.Property(e => e.ElKveba)
                    .HasColumnName("el_Kveba")
                    .HasMaxLength(50);

                entity.Property(e => e.EqspSesvlisTariRi)
                    .HasColumnName("Eqsp_Sesvlis_TariRi")
                    .HasMaxLength(50);

                entity.Property(e => e.Gatboba)
                    .HasColumnName("gatboba")
                    .HasMaxLength(10);

                entity.Property(e => e.Gengegma)
                    .HasColumnName("gengegma")
                    .HasMaxLength(50);

                entity.Property(e => e.Interneti)
                    .HasColumnName("interneti")
                    .HasMaxLength(50);

                entity.Property(e => e.Kondicireba)
                    .HasColumnName("kondicireba")
                    .HasMaxLength(50);

                entity.Property(e => e.OrigFid).HasColumnName("ORIG_FID");

                entity.Property(e => e.OwnedBy)
                    .HasColumnName("Owned_by")
                    .HasMaxLength(50);

                entity.Property(e => e.ParcelArea)
                    .HasColumnName("Parcel_Area")
                    .HasMaxLength(50);

                entity.Property(e => e.PassNumber).HasColumnName("Pass_Number");

                entity.Property(e => e.Pictures).HasMaxLength(150);

                entity.Property(e => e.Qalaqi).HasMaxLength(50);

                entity.Property(e => e.Qucha).HasMaxLength(50);

                entity.Property(e => e.Radioficireba)
                    .HasColumnName("radioficireba")
                    .HasMaxLength(50);

                entity.Property(e => e.Raioni).HasMaxLength(50);

                entity.Property(e => e.Regioni).HasMaxLength(255);

                entity.Property(e => e.SabalansoRirebuleba)
                    .HasColumnName("Sabalanso_Rirebuleba")
                    .HasMaxLength(50);

                entity.Property(e => e.Sakutreba).HasMaxLength(255);

                entity.Property(e => e.SaqKodi)
                    .HasColumnName("saq_kodi")
                    .HasMaxLength(50);

                entity.Property(e => e.Saxli).HasMaxLength(50);

                entity.Property(e => e.Sofeli).HasMaxLength(50);

                entity.Property(e => e.SportTypeId).HasColumnName("SportTypeID");

                entity.Property(e => e.TelNumber)
                    .HasColumnName("Tel_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.TeqnikuriAgwera)
                    .HasColumnName("Teqnikuri_Agwera")
                    .HasMaxLength(250);

                entity.Property(e => e.TeritorisSemogobva)
                    .HasColumnName("teritoris_Semogobva")
                    .HasMaxLength(50);

                entity.Property(e => e.Ventilacia)
                    .HasColumnName("ventilacia")
                    .HasMaxLength(50);

                entity.Property(e => e.Wyalmomarageba)
                    .HasColumnName("wyalmomarageba")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SportType>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Objectid)
                    .HasName("R17_SDE_ROWID_UK")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");
            });

            modelBuilder.Entity<StGeometryColumns>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ST_GEOMETRY_COLUMNS");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasColumnName("column_name")
                    .HasMaxLength(32);

                entity.Property(e => e.SrsId).HasColumnName("srs_id");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("table_name")
                    .HasMaxLength(128);

                entity.Property(e => e.TableSchema)
                    .IsRequired()
                    .HasColumnName("table_schema")
                    .HasMaxLength(32);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("type_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TypeSchema)
                    .IsRequired()
                    .HasColumnName("type_schema")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StSpatialReferenceSystems>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ST_SPATIAL_REFERENCE_SYSTEMS");

                entity.Property(e => e.Definition)
                    .IsRequired()
                    .HasColumnName("definition")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.MOffset).HasColumnName("m_offset");

                entity.Property(e => e.MScale).HasColumnName("m_scale");

                entity.Property(e => e.Organization)
                    .HasColumnName("organization")
                    .HasMaxLength(255);

                entity.Property(e => e.OrganizationCoordsysId).HasColumnName("organization_coordsys_id");

                entity.Property(e => e.SrsId).HasColumnName("srs_id");

                entity.Property(e => e.XOffset).HasColumnName("x_offset");

                entity.Property(e => e.XScale).HasColumnName("x_scale");

                entity.Property(e => e.YOffset).HasColumnName("y_offset");

                entity.Property(e => e.YScale).HasColumnName("y_scale");

                entity.Property(e => e.ZOffset).HasColumnName("z_offset");

                entity.Property(e => e.ZScale).HasColumnName("z_scale");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserProf__1788CC4C345EC57D");

                entity.HasIndex(e => e.UserName)
                    .HasName("UQ__UserProf__C9F28456373B3228")
                    .IsUnique();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(56);
            });

            modelBuilder.Entity<WebpagesMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__webpages__1788CC4C3EDC53F0");

                entity.ToTable("webpages_Membership");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.ConfirmationToken).HasMaxLength(128);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsConfirmed).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastPasswordFailureDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationToken).HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationTokenExpirationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WebpagesOauthMembership>(entity =>
            {
                entity.HasKey(e => new { e.Provider, e.ProviderUserId })
                    .HasName("PK__webpages__F53FC0ED3B0BC30C");

                entity.ToTable("webpages_OAuthMembership");

                entity.Property(e => e.Provider).HasMaxLength(30);

                entity.Property(e => e.ProviderUserId).HasMaxLength(100);
            });

            modelBuilder.Entity<WebpagesRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__webpages__8AFACE1A44952D46");

                entity.ToTable("webpages_Roles");

                entity.HasIndex(e => e.RoleName)
                    .HasName("UQ__webpages__8A2B6160477199F1")
                    .IsUnique();

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<WebpagesUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__webpages__AF2760AD4B422AD5");

                entity.ToTable("webpages_UsersInRoles");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.WebpagesUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebpagesUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UserId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
