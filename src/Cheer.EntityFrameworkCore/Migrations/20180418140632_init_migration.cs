using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Cheer.Migrations
{
    public partial class init_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ABP");

            migrationBuilder.CreateTable(
                name: "SysAuditLogs",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BrowserInfo = table.Column<string>(maxLength: 256, nullable: true),
                    ClientIpAddress = table.Column<string>(maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(maxLength: 128, nullable: true),
                    CustomData = table.Column<string>(maxLength: 2000, nullable: true),
                    Exception = table.Column<string>(maxLength: 2000, nullable: true),
                    ExecutionDuration = table.Column<int>(nullable: false),
                    ExecutionTime = table.Column<DateTime>(nullable: false),
                    ImpersonatorTenantId = table.Column<int>(nullable: true),
                    ImpersonatorUserId = table.Column<long>(nullable: true),
                    MethodName = table.Column<string>(maxLength: 256, nullable: true),
                    Parameters = table.Column<string>(maxLength: 1024, nullable: true),
                    ServiceName = table.Column<string>(maxLength: 256, nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysAuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysBackgroundJobs",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    IsAbandoned = table.Column<bool>(nullable: false),
                    JobArgs = table.Column<string>(maxLength: 1048576, nullable: false),
                    JobType = table.Column<string>(maxLength: 512, nullable: false),
                    LastTryTime = table.Column<DateTime>(nullable: true),
                    NextTryTime = table.Column<DateTime>(nullable: false),
                    Priority = table.Column<byte>(nullable: false),
                    TryCount = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysBackgroundJobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysEditions",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    DisplayName = table.Column<string>(maxLength: 64, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysEditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysEntityChangeSets",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BrowserInfo = table.Column<string>(maxLength: 256, nullable: true),
                    ClientIpAddress = table.Column<string>(maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(maxLength: 128, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    ExtensionData = table.Column<string>(nullable: true),
                    ImpersonatorTenantId = table.Column<int>(nullable: true),
                    ImpersonatorUserId = table.Column<long>(nullable: true),
                    Reason = table.Column<string>(maxLength: 256, nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysEntityChangeSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysLanguages",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    DisplayName = table.Column<string>(maxLength: 64, nullable: false),
                    Icon = table.Column<string>(maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsDisabled = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 10, nullable: false),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysLanguages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysLanguageTexts",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Key = table.Column<string>(maxLength: 256, nullable: false),
                    LanguageName = table.Column<string>(maxLength: 10, nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Source = table.Column<string>(maxLength: 128, nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    Value = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysLanguageTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysNotifications",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Data = table.Column<string>(maxLength: 1048576, nullable: true),
                    DataTypeName = table.Column<string>(maxLength: 512, nullable: true),
                    EntityId = table.Column<string>(maxLength: 96, nullable: true),
                    EntityTypeAssemblyQualifiedName = table.Column<string>(maxLength: 512, nullable: true),
                    EntityTypeName = table.Column<string>(maxLength: 250, nullable: true),
                    ExcludedUserIds = table.Column<string>(maxLength: 131072, nullable: true),
                    NotificationName = table.Column<string>(maxLength: 96, nullable: false),
                    Severity = table.Column<byte>(nullable: false),
                    TenantIds = table.Column<string>(maxLength: 131072, nullable: true),
                    UserIds = table.Column<string>(maxLength: 131072, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysNotificationSubscriptions",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    EntityId = table.Column<string>(maxLength: 96, nullable: true),
                    EntityTypeAssemblyQualifiedName = table.Column<string>(maxLength: 512, nullable: true),
                    EntityTypeName = table.Column<string>(maxLength: 250, nullable: true),
                    NotificationName = table.Column<string>(maxLength: 96, nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysNotificationSubscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysOrganizationUnits",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Code = table.Column<string>(maxLength: 95, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    ParentId = table.Column<long>(nullable: true),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysOrganizationUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysOrganizationUnits_SysOrganizationUnits_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "ABP",
                        principalTable: "SysOrganizationUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysTenantNotifications",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Data = table.Column<string>(maxLength: 1048576, nullable: true),
                    DataTypeName = table.Column<string>(maxLength: 512, nullable: true),
                    EntityId = table.Column<string>(maxLength: 96, nullable: true),
                    EntityTypeAssemblyQualifiedName = table.Column<string>(maxLength: 512, nullable: true),
                    EntityTypeName = table.Column<string>(maxLength: 250, nullable: true),
                    NotificationName = table.Column<string>(maxLength: 96, nullable: false),
                    Severity = table.Column<byte>(nullable: false),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysTenantNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysUserAccounts",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 256, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastLoginTime = table.Column<DateTime>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false),
                    UserLinkId = table.Column<long>(nullable: true),
                    UserName = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUserAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysUserLoginAttempts",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BrowserInfo = table.Column<string>(maxLength: 256, nullable: true),
                    ClientIpAddress = table.Column<string>(maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(maxLength: 128, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Result = table.Column<byte>(nullable: false),
                    TenancyName = table.Column<string>(maxLength: 64, nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: true),
                    UserNameOrEmailAddress = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUserLoginAttempts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysUserNotifications",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    TenantNotificationId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUserNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysUserOrganizationUnits",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OrganizationUnitId = table.Column<long>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUserOrganizationUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysUsers",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    AuthenticationSource = table.Column<string>(maxLength: 64, nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 128, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 256, nullable: false),
                    EmailConfirmationCode = table.Column<string>(maxLength: 328, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsEmailConfirmed = table.Column<bool>(nullable: false),
                    IsLockoutEnabled = table.Column<bool>(nullable: false),
                    IsPhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    IsTwoFactorEnabled = table.Column<bool>(nullable: false),
                    LastLoginTime = table.Column<DateTime>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LockoutEndDateUtc = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    NormalizedEmailAddress = table.Column<string>(maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(maxLength: 32, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: false),
                    PasswordResetCode = table.Column<string>(maxLength: 328, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 32, nullable: true),
                    SecurityStamp = table.Column<string>(maxLength: 128, nullable: true),
                    Surname = table.Column<string>(maxLength: 32, nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    UserName = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysUsers_SysUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SysUsers_SysUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SysUsers_SysUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysFeatures",
                schema: "ABP",
                columns: table => new
                {
                    EditionId = table.Column<int>(nullable: true),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    Value = table.Column<string>(maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysFeatures_SysEditions_EditionId",
                        column: x => x.EditionId,
                        principalSchema: "ABP",
                        principalTable: "SysEditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysEntityChanges",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ChangeTime = table.Column<DateTime>(nullable: false),
                    ChangeType = table.Column<byte>(nullable: false),
                    EntityChangeSetId = table.Column<long>(nullable: false),
                    EntityId = table.Column<string>(maxLength: 48, nullable: true),
                    EntityTypeFullName = table.Column<string>(maxLength: 192, nullable: true),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysEntityChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysEntityChanges_SysEntityChangeSets_EntityChangeSetId",
                        column: x => x.EntityChangeSetId,
                        principalSchema: "ABP",
                        principalTable: "SysEntityChangeSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysRoles",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ConcurrencyStamp = table.Column<string>(maxLength: 128, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 5000, nullable: true),
                    DisplayName = table.Column<string>(maxLength: 64, nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsStatic = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    NormalizedName = table.Column<string>(maxLength: 32, nullable: false),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysRoles_SysUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SysRoles_SysUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SysRoles_SysUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysSettings",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: true),
                    Value = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysSettings_SysUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysTenants",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ConnectionString = table.Column<string>(maxLength: 1024, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EditionId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    TenancyName = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysTenants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysTenants_SysUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SysTenants_SysUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SysTenants_SysEditions_EditionId",
                        column: x => x.EditionId,
                        principalSchema: "ABP",
                        principalTable: "SysEditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SysTenants_SysUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysUserClaims",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ClaimType = table.Column<string>(maxLength: 256, nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysUserClaims_SysUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysUserLogins",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 256, nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysUserLogins_SysUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysUserRoles",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysUserRoles_SysUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysUserTokens",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LoginProvider = table.Column<string>(maxLength: 64, nullable: true),
                    Name = table.Column<string>(maxLength: 128, nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: false),
                    Value = table.Column<string>(maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUserTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysUserTokens_SysUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysEntityPropertyChanges",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EntityChangeId = table.Column<long>(nullable: false),
                    NewValue = table.Column<string>(maxLength: 512, nullable: true),
                    OriginalValue = table.Column<string>(maxLength: 512, nullable: true),
                    PropertyName = table.Column<string>(maxLength: 96, nullable: true),
                    PropertyTypeFullName = table.Column<string>(maxLength: 192, nullable: true),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysEntityPropertyChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysEntityPropertyChanges_SysEntityChanges_EntityChangeId",
                        column: x => x.EntityChangeId,
                        principalSchema: "ABP",
                        principalTable: "SysEntityChanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysPermissions",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    IsGranted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    RoleId = table.Column<int>(nullable: true),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysPermissions_SysRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "ABP",
                        principalTable: "SysRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SysPermissions_SysUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "ABP",
                        principalTable: "SysUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SysRoleClaims",
                schema: "ABP",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ClaimType = table.Column<string>(maxLength: 256, nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysRoleClaims_SysRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "ABP",
                        principalTable: "SysRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SysAuditLogs_TenantId_ExecutionDuration",
                schema: "ABP",
                table: "SysAuditLogs",
                columns: new[] { "TenantId", "ExecutionDuration" });

            migrationBuilder.CreateIndex(
                name: "IX_SysAuditLogs_TenantId_ExecutionTime",
                schema: "ABP",
                table: "SysAuditLogs",
                columns: new[] { "TenantId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_SysAuditLogs_TenantId_UserId",
                schema: "ABP",
                table: "SysAuditLogs",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysBackgroundJobs_IsAbandoned_NextTryTime",
                schema: "ABP",
                table: "SysBackgroundJobs",
                columns: new[] { "IsAbandoned", "NextTryTime" });

            migrationBuilder.CreateIndex(
                name: "IX_SysEntityChanges_EntityChangeSetId",
                schema: "ABP",
                table: "SysEntityChanges",
                column: "EntityChangeSetId");

            migrationBuilder.CreateIndex(
                name: "IX_SysEntityChanges_EntityTypeFullName_EntityId",
                schema: "ABP",
                table: "SysEntityChanges",
                columns: new[] { "EntityTypeFullName", "EntityId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysEntityChangeSets_TenantId_CreationTime",
                schema: "ABP",
                table: "SysEntityChangeSets",
                columns: new[] { "TenantId", "CreationTime" });

            migrationBuilder.CreateIndex(
                name: "IX_SysEntityChangeSets_TenantId_Reason",
                schema: "ABP",
                table: "SysEntityChangeSets",
                columns: new[] { "TenantId", "Reason" });

            migrationBuilder.CreateIndex(
                name: "IX_SysEntityChangeSets_TenantId_UserId",
                schema: "ABP",
                table: "SysEntityChangeSets",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysEntityPropertyChanges_EntityChangeId",
                schema: "ABP",
                table: "SysEntityPropertyChanges",
                column: "EntityChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_SysFeatures_EditionId_Name",
                schema: "ABP",
                table: "SysFeatures",
                columns: new[] { "EditionId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_SysFeatures_TenantId_Name",
                schema: "ABP",
                table: "SysFeatures",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_SysLanguages_TenantId_Name",
                schema: "ABP",
                table: "SysLanguages",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_SysLanguageTexts_TenantId_Source_LanguageName_Key",
                schema: "ABP",
                table: "SysLanguageTexts",
                columns: new[] { "TenantId", "Source", "LanguageName", "Key" });

            migrationBuilder.CreateIndex(
                name: "IX_SysNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                schema: "ABP",
                table: "SysNotificationSubscriptions",
                columns: new[] { "NotificationName", "EntityTypeName", "EntityId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                schema: "ABP",
                table: "SysNotificationSubscriptions",
                columns: new[] { "TenantId", "NotificationName", "EntityTypeName", "EntityId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysOrganizationUnits_ParentId",
                schema: "ABP",
                table: "SysOrganizationUnits",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_SysOrganizationUnits_TenantId_Code",
                schema: "ABP",
                table: "SysOrganizationUnits",
                columns: new[] { "TenantId", "Code" });

            migrationBuilder.CreateIndex(
                name: "IX_SysPermissions_TenantId_Name",
                schema: "ABP",
                table: "SysPermissions",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_SysPermissions_RoleId",
                schema: "ABP",
                table: "SysPermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SysPermissions_UserId",
                schema: "ABP",
                table: "SysPermissions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysRoleClaims_RoleId",
                schema: "ABP",
                table: "SysRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SysRoleClaims_TenantId_ClaimType",
                schema: "ABP",
                table: "SysRoleClaims",
                columns: new[] { "TenantId", "ClaimType" });

            migrationBuilder.CreateIndex(
                name: "IX_SysRoles_CreatorUserId",
                schema: "ABP",
                table: "SysRoles",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysRoles_DeleterUserId",
                schema: "ABP",
                table: "SysRoles",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysRoles_LastModifierUserId",
                schema: "ABP",
                table: "SysRoles",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysRoles_TenantId_NormalizedName",
                schema: "ABP",
                table: "SysRoles",
                columns: new[] { "TenantId", "NormalizedName" });

            migrationBuilder.CreateIndex(
                name: "IX_SysSettings_UserId",
                schema: "ABP",
                table: "SysSettings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysSettings_TenantId_Name",
                schema: "ABP",
                table: "SysSettings",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_SysTenantNotifications_TenantId",
                schema: "ABP",
                table: "SysTenantNotifications",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_SysTenants_CreatorUserId",
                schema: "ABP",
                table: "SysTenants",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysTenants_DeleterUserId",
                schema: "ABP",
                table: "SysTenants",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysTenants_EditionId",
                schema: "ABP",
                table: "SysTenants",
                column: "EditionId");

            migrationBuilder.CreateIndex(
                name: "IX_SysTenants_LastModifierUserId",
                schema: "ABP",
                table: "SysTenants",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysTenants_TenancyName",
                schema: "ABP",
                table: "SysTenants",
                column: "TenancyName");

            migrationBuilder.CreateIndex(
                name: "IX_SysUserAccounts_EmailAddress",
                schema: "ABP",
                table: "SysUserAccounts",
                column: "EmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_SysUserAccounts_UserName",
                schema: "ABP",
                table: "SysUserAccounts",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_SysUserAccounts_TenantId_EmailAddress",
                schema: "ABP",
                table: "SysUserAccounts",
                columns: new[] { "TenantId", "EmailAddress" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserAccounts_TenantId_UserId",
                schema: "ABP",
                table: "SysUserAccounts",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserAccounts_TenantId_UserName",
                schema: "ABP",
                table: "SysUserAccounts",
                columns: new[] { "TenantId", "UserName" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserClaims_UserId",
                schema: "ABP",
                table: "SysUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysUserClaims_TenantId_ClaimType",
                schema: "ABP",
                table: "SysUserClaims",
                columns: new[] { "TenantId", "ClaimType" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserLoginAttempts_UserId_TenantId",
                schema: "ABP",
                table: "SysUserLoginAttempts",
                columns: new[] { "UserId", "TenantId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                schema: "ABP",
                table: "SysUserLoginAttempts",
                columns: new[] { "TenancyName", "UserNameOrEmailAddress", "Result" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserLogins_UserId",
                schema: "ABP",
                table: "SysUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysUserLogins_TenantId_UserId",
                schema: "ABP",
                table: "SysUserLogins",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserLogins_TenantId_LoginProvider_ProviderKey",
                schema: "ABP",
                table: "SysUserLogins",
                columns: new[] { "TenantId", "LoginProvider", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserNotifications_UserId_State_CreationTime",
                schema: "ABP",
                table: "SysUserNotifications",
                columns: new[] { "UserId", "State", "CreationTime" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserOrganizationUnits_TenantId_OrganizationUnitId",
                schema: "ABP",
                table: "SysUserOrganizationUnits",
                columns: new[] { "TenantId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserOrganizationUnits_TenantId_UserId",
                schema: "ABP",
                table: "SysUserOrganizationUnits",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserRoles_UserId",
                schema: "ABP",
                table: "SysUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysUserRoles_TenantId_RoleId",
                schema: "ABP",
                table: "SysUserRoles",
                columns: new[] { "TenantId", "RoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserRoles_TenantId_UserId",
                schema: "ABP",
                table: "SysUserRoles",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUsers_CreatorUserId",
                schema: "ABP",
                table: "SysUsers",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysUsers_DeleterUserId",
                schema: "ABP",
                table: "SysUsers",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysUsers_LastModifierUserId",
                schema: "ABP",
                table: "SysUsers",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysUsers_TenantId_NormalizedEmailAddress",
                schema: "ABP",
                table: "SysUsers",
                columns: new[] { "TenantId", "NormalizedEmailAddress" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUsers_TenantId_NormalizedUserName",
                schema: "ABP",
                table: "SysUsers",
                columns: new[] { "TenantId", "NormalizedUserName" });

            migrationBuilder.CreateIndex(
                name: "IX_SysUserTokens_UserId",
                schema: "ABP",
                table: "SysUserTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SysUserTokens_TenantId_UserId",
                schema: "ABP",
                table: "SysUserTokens",
                columns: new[] { "TenantId", "UserId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SysAuditLogs",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysBackgroundJobs",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysEntityPropertyChanges",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysFeatures",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysLanguages",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysLanguageTexts",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysNotifications",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysNotificationSubscriptions",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysOrganizationUnits",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysPermissions",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysRoleClaims",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysSettings",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysTenantNotifications",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysTenants",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysUserAccounts",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysUserClaims",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysUserLoginAttempts",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysUserLogins",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysUserNotifications",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysUserOrganizationUnits",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysUserRoles",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysUserTokens",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysEntityChanges",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysRoles",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysEditions",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysEntityChangeSets",
                schema: "ABP");

            migrationBuilder.DropTable(
                name: "SysUsers",
                schema: "ABP");
        }
    }
}
