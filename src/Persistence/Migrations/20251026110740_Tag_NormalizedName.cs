using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Tag_NormalizedName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("066f6038-e920-4885-8186-67ae881c1f60"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("066f6038-e920-4885-8186-67ae881c1f60"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("066f6038-e920-4885-8186-67ae881c1f60"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("066f6038-e920-4885-8186-67ae881c1f60"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("08135a0e-e395-47f1-b3e1-65e93b42c721"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("08135a0e-e395-47f1-b3e1-65e93b42c721"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("08135a0e-e395-47f1-b3e1-65e93b42c721"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("1083361d-74af-422d-8f76-96b5de333422"), new Guid("0d2425e8-6548-469e-a581-598a65336047") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("1083361d-74af-422d-8f76-96b5de333422"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("1083361d-74af-422d-8f76-96b5de333422"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("15ef6d7d-07c1-458e-9a2b-507ceda36e39"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("15ef6d7d-07c1-458e-9a2b-507ceda36e39"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("15ef6d7d-07c1-458e-9a2b-507ceda36e39"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("15ef6d7d-07c1-458e-9a2b-507ceda36e39"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("2b69b5ad-d319-4276-aa1b-d31028f1feff"), new Guid("0d2425e8-6548-469e-a581-598a65336047") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("2b69b5ad-d319-4276-aa1b-d31028f1feff"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("2b69b5ad-d319-4276-aa1b-d31028f1feff"), new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("2c75cd8c-7d1f-430b-b7ef-c1877e79ee03"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("2c75cd8c-7d1f-430b-b7ef-c1877e79ee03"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("2c75cd8c-7d1f-430b-b7ef-c1877e79ee03"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("2c75cd8c-7d1f-430b-b7ef-c1877e79ee03"), new Guid("b289c6e5-ea00-4666-9e87-50720a94a2fe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("38ed607a-e9a4-4103-ab96-2cf3c01900ca"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("38ed607a-e9a4-4103-ab96-2cf3c01900ca"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("38ed607a-e9a4-4103-ab96-2cf3c01900ca"), new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("38ed607a-e9a4-4103-ab96-2cf3c01900ca"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3a9a17c3-7c99-4743-9c2e-f28f79195b12"), new Guid("0d2425e8-6548-469e-a581-598a65336047") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3a9a17c3-7c99-4743-9c2e-f28f79195b12"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3a9a17c3-7c99-4743-9c2e-f28f79195b12"), new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3c432d39-6e83-40cc-b7ad-9cccb3ab374c"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3c432d39-6e83-40cc-b7ad-9cccb3ab374c"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3c432d39-6e83-40cc-b7ad-9cccb3ab374c"), new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3c432d39-6e83-40cc-b7ad-9cccb3ab374c"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3faa286f-7921-46c7-8752-64e535e1a5b0"), new Guid("0d2425e8-6548-469e-a581-598a65336047") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3faa286f-7921-46c7-8752-64e535e1a5b0"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3faa286f-7921-46c7-8752-64e535e1a5b0"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3faa286f-7921-46c7-8752-64e535e1a5b0"), new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3faa286f-7921-46c7-8752-64e535e1a5b0"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("42a5302b-0b3c-4074-ab75-9c7f5933823b"), new Guid("0d2425e8-6548-469e-a581-598a65336047") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("42a5302b-0b3c-4074-ab75-9c7f5933823b"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("42a5302b-0b3c-4074-ab75-9c7f5933823b"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("42a5302b-0b3c-4074-ab75-9c7f5933823b"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("4d1bd7bd-0155-4ce8-921b-c32f690c57d8"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("4d1bd7bd-0155-4ce8-921b-c32f690c57d8"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("4d1bd7bd-0155-4ce8-921b-c32f690c57d8"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("50c6cff8-1c29-43f4-b39a-6c29285c9f3d"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("50c6cff8-1c29-43f4-b39a-6c29285c9f3d"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("50c6cff8-1c29-43f4-b39a-6c29285c9f3d"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("50c6cff8-1c29-43f4-b39a-6c29285c9f3d"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("50c6cff8-1c29-43f4-b39a-6c29285c9f3d"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("55f4780d-60c4-41f8-96bd-14a899b8ed6d"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("55f4780d-60c4-41f8-96bd-14a899b8ed6d"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("55f4780d-60c4-41f8-96bd-14a899b8ed6d"), new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5a9b8b61-cce5-4b1f-ae04-5a4258bef4b6"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5a9b8b61-cce5-4b1f-ae04-5a4258bef4b6"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5a9b8b61-cce5-4b1f-ae04-5a4258bef4b6"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5a9b8b61-cce5-4b1f-ae04-5a4258bef4b6"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5fa6e1e2-8da2-4934-ad96-99135d4cb5cf"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5fa6e1e2-8da2-4934-ad96-99135d4cb5cf"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5fa6e1e2-8da2-4934-ad96-99135d4cb5cf"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6199c1cc-a926-4aaf-acda-37a1e2dcf462"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6199c1cc-a926-4aaf-acda-37a1e2dcf462"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6199c1cc-a926-4aaf-acda-37a1e2dcf462"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6199c1cc-a926-4aaf-acda-37a1e2dcf462"), new Guid("b289c6e5-ea00-4666-9e87-50720a94a2fe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("65b334c7-20be-4c4e-adbc-e8d15bba901c"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("65b334c7-20be-4c4e-adbc-e8d15bba901c"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("65b334c7-20be-4c4e-adbc-e8d15bba901c"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("65b334c7-20be-4c4e-adbc-e8d15bba901c"), new Guid("b289c6e5-ea00-4666-9e87-50720a94a2fe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("65d7b78f-626e-4d21-83a7-53902ca0f671"), new Guid("0d2425e8-6548-469e-a581-598a65336047") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("65d7b78f-626e-4d21-83a7-53902ca0f671"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("65d7b78f-626e-4d21-83a7-53902ca0f671"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("8cee860b-00a0-4135-ab15-91791ceaf03f"), new Guid("0d2425e8-6548-469e-a581-598a65336047") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("8cee860b-00a0-4135-ab15-91791ceaf03f"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("8cee860b-00a0-4135-ab15-91791ceaf03f"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("94975050-c7ed-47f2-94ed-6aff44b6b855"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("94975050-c7ed-47f2-94ed-6aff44b6b855"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("94975050-c7ed-47f2-94ed-6aff44b6b855"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("94975050-c7ed-47f2-94ed-6aff44b6b855"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("95130403-cc55-4ad0-9ed1-551e384b43c8"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("95130403-cc55-4ad0-9ed1-551e384b43c8"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("a164386e-5195-4999-9469-4b2c206bb12b"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("a164386e-5195-4999-9469-4b2c206bb12b"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("a164386e-5195-4999-9469-4b2c206bb12b"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("b848f0cb-5532-4522-93b4-39812aa4c9ba"), new Guid("0d2425e8-6548-469e-a581-598a65336047") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("b848f0cb-5532-4522-93b4-39812aa4c9ba"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("b848f0cb-5532-4522-93b4-39812aa4c9ba"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("b848f0cb-5532-4522-93b4-39812aa4c9ba"), new Guid("b289c6e5-ea00-4666-9e87-50720a94a2fe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("bc596c43-46a0-4070-8418-2786848a24ac"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("bc596c43-46a0-4070-8418-2786848a24ac"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("bc596c43-46a0-4070-8418-2786848a24ac"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("bc596c43-46a0-4070-8418-2786848a24ac"), new Guid("b289c6e5-ea00-4666-9e87-50720a94a2fe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c187e77c-1079-43b9-a57e-3f6a2dc155df"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c187e77c-1079-43b9-a57e-3f6a2dc155df"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c187e77c-1079-43b9-a57e-3f6a2dc155df"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c187e77c-1079-43b9-a57e-3f6a2dc155df"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c3edb965-429a-4cdb-95ff-3bea931ab589"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c3edb965-429a-4cdb-95ff-3bea931ab589"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c3edb965-429a-4cdb-95ff-3bea931ab589"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c3edb965-429a-4cdb-95ff-3bea931ab589"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("d1dfed48-5cf2-4be0-9999-f2aea14b6d68"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("d1dfed48-5cf2-4be0-9999-f2aea14b6d68"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("d1dfed48-5cf2-4be0-9999-f2aea14b6d68"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("d6af4d6f-80e6-4892-9513-f6fe1c2e2b76"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("d6af4d6f-80e6-4892-9513-f6fe1c2e2b76"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("d6af4d6f-80e6-4892-9513-f6fe1c2e2b76"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("d6af4d6f-80e6-4892-9513-f6fe1c2e2b76"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("ddf18263-d0c8-47e1-9305-929dffa78c60"), new Guid("0d2425e8-6548-469e-a581-598a65336047") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("ddf18263-d0c8-47e1-9305-929dffa78c60"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("ddf18263-d0c8-47e1-9305-929dffa78c60"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("ddf18263-d0c8-47e1-9305-929dffa78c60"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("f9625c06-96a5-420c-b6ab-d267ef45c9a3"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("f9625c06-96a5-420c-b6ab-d267ef45c9a3"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("f9625c06-96a5-420c-b6ab-d267ef45c9a3"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("f9625c06-96a5-420c-b6ab-d267ef45c9a3"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe") });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("066f6038-e920-4885-8186-67ae881c1f60"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("08135a0e-e395-47f1-b3e1-65e93b42c721"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("1083361d-74af-422d-8f76-96b5de333422"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("15ef6d7d-07c1-458e-9a2b-507ceda36e39"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("2b69b5ad-d319-4276-aa1b-d31028f1feff"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("2c75cd8c-7d1f-430b-b7ef-c1877e79ee03"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("38ed607a-e9a4-4103-ab96-2cf3c01900ca"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3a9a17c3-7c99-4743-9c2e-f28f79195b12"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3c432d39-6e83-40cc-b7ad-9cccb3ab374c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3faa286f-7921-46c7-8752-64e535e1a5b0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("42a5302b-0b3c-4074-ab75-9c7f5933823b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("4d1bd7bd-0155-4ce8-921b-c32f690c57d8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("50c6cff8-1c29-43f4-b39a-6c29285c9f3d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("55f4780d-60c4-41f8-96bd-14a899b8ed6d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5a9b8b61-cce5-4b1f-ae04-5a4258bef4b6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5fa6e1e2-8da2-4934-ad96-99135d4cb5cf"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("6199c1cc-a926-4aaf-acda-37a1e2dcf462"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("65b334c7-20be-4c4e-adbc-e8d15bba901c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("65d7b78f-626e-4d21-83a7-53902ca0f671"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("8cee860b-00a0-4135-ab15-91791ceaf03f"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("94975050-c7ed-47f2-94ed-6aff44b6b855"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("95130403-cc55-4ad0-9ed1-551e384b43c8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("a164386e-5195-4999-9469-4b2c206bb12b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b848f0cb-5532-4522-93b4-39812aa4c9ba"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("bc596c43-46a0-4070-8418-2786848a24ac"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c187e77c-1079-43b9-a57e-3f6a2dc155df"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c3edb965-429a-4cdb-95ff-3bea931ab589"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d1dfed48-5cf2-4be0-9999-f2aea14b6d68"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d6af4d6f-80e6-4892-9513-f6fe1c2e2b76"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("ddf18263-d0c8-47e1-9305-929dffa78c60"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f9625c06-96a5-420c-b6ab-d267ef45c9a3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0d2425e8-6548-469e-a581-598a65336047"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("42468792-408c-40e6-b488-c0a87408fbb7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b289c6e5-ea00-4666-9e87-50720a94a2fe"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a60ee7e-01a5-49a0-ad6f-0a356101ff6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("970427a2-f8e8-4b3f-8f80-6ef23b443635"));

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "Tags",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("077fc647-953a-4caf-9f34-da90f8de3105"), "Food & Drink", "food&drink" },
                    { new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911"), "Technology", "technology" },
                    { new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), "Business", "business" },
                    { new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f"), "Travel", "travel" },
                    { new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f"), "Art", "art" },
                    { new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), "Networking", "networking" },
                    { new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821"), "Health", "health" },
                    { new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727"), "Music", "music" },
                    { new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), "Education", "education" },
                    { new Guid("d1ff6e85-8f3a-45a1-beea-8546b23ee5d0"), "Sports", "sports" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), "john.doe@example.com", "John", "Doe", "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue" },
                    { new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), "jane.smith@example.com", "Jane", "Smith", "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue" },
                    { new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), "alice.johnson@example.com", "Alice", "Johnson", "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Capacity", "Date", "Description", "IsPublic", "Location", "OrganizerId", "Title" },
                values: new object[,]
                {
                    { new Guid("0a3d8b7b-cbd2-485d-906f-9da922cce946"), 40, new DateTime(2025, 11, 13, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3223), "Private team building activities.", false, "Adventure Park", new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), "Corporate Team Building" },
                    { new Guid("13195e38-b24b-4e99-b2f3-1f0d82f2d279"), 35, new DateTime(2025, 12, 15, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3249), "Celebrating 25 years together with close family.", false, "Garden Venue", new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), "Wedding Anniversary" },
                    { new Guid("1db4bcd6-26f4-46e4-a373-ab833fb61586"), null, new DateTime(2025, 11, 5, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3195), "Monthly book club discussion.", false, "Library Private Room", new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), "Book Club Meeting" },
                    { new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), 25, new DateTime(2025, 10, 30, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3246), "Learn salsa dancing from scratch.", true, "Dance Studio", new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), "Dance Class Beginner" },
                    { new Guid("29b4ee74-5cf1-49a1-90d5-c4049459d0c5"), 20, new DateTime(2025, 10, 28, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3184), "Morning yoga session for all levels.", true, "Wellness Center", new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), "Yoga Class" },
                    { new Guid("2f39ff8d-1733-4672-927a-e11f6696e606"), null, new DateTime(2025, 12, 20, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3299), "Private weekend meditation and mindfulness retreat.", false, "Mountain Retreat Center", new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), "Meditation Retreat" },
                    { new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"), null, new DateTime(2025, 11, 16, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3295), "Independent film screening and Q&A.", true, "Indie Cinema", new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), "Film Screening" },
                    { new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), 200, new DateTime(2025, 11, 23, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3287), "Annual science fair for students and enthusiasts.", true, "Science Museum", new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), "Science Fair" },
                    { new Guid("378199c1-8040-444d-8e98-527b2652e646"), 50, new DateTime(2026, 1, 4, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3305), "Private reunion for class of 2010.", false, "University Hall", new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), "Alumni Gathering" },
                    { new Guid("4af46aff-b36e-4ad3-ba92-f95b8923ab17"), 25, new DateTime(2025, 11, 25, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3188), "Annual family gathering.", false, "Family Home", new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), "Family Reunion" },
                    { new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), null, new DateTime(2025, 11, 20, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3226), "Explore diverse street food from around the world.", true, "Downtown Plaza", new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), "Street Food Festival" },
                    { new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), 50, new DateTime(2025, 11, 2, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3066), "Annual technology conference.", true, "Convention Hall", new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), "Tech Conference" },
                    { new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), 12, new DateTime(2025, 11, 10, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3220), "Professional photography workshop.", true, "Photography Studio", new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), "Photography Masterclass" },
                    { new Guid("5d4ea2ba-8279-4bb0-a787-1597b39759f1"), null, new DateTime(2025, 11, 6, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3283), "Quarterly business strategy meeting.", false, "Conference Room A", new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), "Strategy Planning Session" },
                    { new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"), 15, new DateTime(2025, 11, 4, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3234), "Private celebration for the groom-to-be.", false, "Resort", new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), "Bachelor Party" },
                    { new Guid("64dc086c-1c92-42e5-b252-05d2b8b49b40"), null, new DateTime(2025, 11, 17, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3242), "Private launch event for new product line.", false, "Luxury Hotel Ballroom", new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), "Exclusive Product Launch" },
                    { new Guid("6b5d6067-1a6b-467f-874c-e7bc67a3022c"), null, new DateTime(2025, 10, 29, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3098), "An exclusive dinner party for close friends.", false, "Home", new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), "Private Dinner Party" },
                    { new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), null, new DateTime(2025, 12, 5, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3238), "Community charity walk for local hospital.", true, "City Park Trail", new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), "Charity Walk" },
                    { new Guid("773695e9-13e4-453c-824d-31495b91223c"), null, new DateTime(2025, 10, 29, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3252), "Showcase your talent at our weekly open mic.", true, "Jazz Club", new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), "Open Mic Night" },
                    { new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), 100, new DateTime(2025, 11, 30, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3231), "Learn about blockchain technology and cryptocurrency.", true, "Tech Hub", new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), "Blockchain Summit" },
                    { new Guid("7969299d-5850-4fbe-9224-c03e7e283764"), 8, new DateTime(2025, 10, 31, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3161), "Private board game session.", false, "Game Cafe", new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), "Board Game Night" },
                    { new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"), 30, new DateTime(2025, 11, 15, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3209), "Private investment strategy seminar.", false, "Financial Center", new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), "Investment Seminar" },
                    { new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), 15, new DateTime(2025, 11, 7, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3205), "Learn to cook Italian cuisine.", true, "Culinary Institute", new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), "Cooking Workshop" },
                    { new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), null, new DateTime(2025, 12, 25, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3191), "Annual city-wide marathon event.", true, "City Streets", new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), "City Marathon" },
                    { new Guid("aeb49686-550e-48e1-af38-5d287839a05a"), 20, new DateTime(2025, 11, 8, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3290), "Secret birthday celebration.", false, "Friend's House", new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), "Birthday Surprise Party" },
                    { new Guid("af63d331-5308-4e96-9be4-e441409940db"), null, new DateTime(2025, 10, 27, 11, 7, 39, 586, DateTimeKind.Utc).AddTicks(5920), "A meetup for community members.", true, "Community Center", new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), "Community Meetup" },
                    { new Guid("c2a9a83e-0d4b-4735-8e79-9405547f46f2"), null, new DateTime(2025, 11, 1, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3228), "Intimate poetry reading and discussion.", false, "Cozy Bookshop", new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), "Poetry Reading Circle" },
                    { new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), null, new DateTime(2025, 12, 10, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3214), "Open air music festival with multiple bands.", true, "Park Amphitheater", new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), "Music Festival" },
                    { new Guid("d8cd84bb-e04d-43b1-8b3c-45a3e56d58d0"), null, new DateTime(2025, 11, 3, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3217), "Exclusive wine tasting for connoisseurs.", false, "Private Wine Cellar", new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), "Wine Tasting Evening" },
                    { new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), 500, new DateTime(2025, 11, 12, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3302), "Connect with top employers in the region.", true, "Convention Center", new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), "Job Fair" },
                    { new Guid("fa2d488f-7db0-4723-a663-8b7806a99014"), null, new DateTime(2025, 11, 9, 11, 7, 39, 587, DateTimeKind.Utc).AddTicks(3088), "A workshop for art enthusiasts.", true, "Art Studio", new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), "Art Workshop" }
                });

            migrationBuilder.InsertData(
                table: "EventParticipants",
                columns: new[] { "Id", "EventId", "JoinedAt", "UserId", "VisitorEmail", "VisitorFirstName", "VisitorId", "VisitorLastName" },
                values: new object[,]
                {
                    { new Guid("0034e9ac-0caf-4c99-82b0-1eda410b6135"), new Guid("6b5d6067-1a6b-467f-874c-e7bc67a3022c"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6671), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("00677002-54db-4a15-ac9f-ebe0f3611a26"), new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6827), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("01f43951-0da5-4f51-a8b2-34f5256102a9"), new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6721), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("023f2f99-496a-4a64-97f1-5503346534b7"), new Guid("378199c1-8040-444d-8e98-527b2652e646"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6902), null, "michael.brown@example.com", "Michael", new Guid("10000000-0000-0000-0000-000000000001"), "Brown" },
                    { new Guid("045df9c3-3620-4ef5-ac97-a98f3f418340"), new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6740), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("066cd356-e5ac-425e-bd68-76710de72174"), new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6810), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("0ab77e40-048d-4c0e-8bb0-be7f5a983e7d"), new Guid("7969299d-5850-4fbe-9224-c03e7e283764"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6674), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("0acacb7a-9ce3-4ea0-9ecb-526966f660f5"), new Guid("378199c1-8040-444d-8e98-527b2652e646"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6900), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("105dbc34-94b3-4ba2-90b7-eb28f5201c08"), new Guid("378199c1-8040-444d-8e98-527b2652e646"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6901), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("13f00f36-9049-4f46-876e-eddb89b67e0c"), new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6664), null, "james.anderson@example.com", "James", new Guid("10000000-0000-0000-0000-000000000005"), "Anderson" },
                    { new Guid("17b505e6-5183-40cb-92fc-3d45daaac31c"), new Guid("1db4bcd6-26f4-46e4-a373-ab833fb61586"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6719), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("19fcb0d8-bab5-42c2-897b-3a0a341c6427"), new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6730), null, "lucas.king@example.com", "Lucas", new Guid("10000000-0000-0000-0000-000000000015"), "King" },
                    { new Guid("1a9420a6-4306-4d7f-a6fe-45238fea05d0"), new Guid("d8cd84bb-e04d-43b1-8b3c-45a3e56d58d0"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6748), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("1bb3a070-e66d-4208-bd77-1a6b33bc4ab2"), new Guid("773695e9-13e4-453c-824d-31495b91223c"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6857), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("1e97a1e0-7f07-43be-8fc9-2b18c7cf158c"), new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6888), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("1f0c52cc-d7f2-4508-9d91-b25c626c1f61"), new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6803), null, "michael.brown@example.com", "Michael", new Guid("10000000-0000-0000-0000-000000000001"), "Brown" },
                    { new Guid("1fe5a181-3ca6-409d-97f4-5ff63e70ec94"), new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6718), null, "amelia.hall@example.com", "Amelia", new Guid("10000000-0000-0000-0000-000000000013"), "Hall" },
                    { new Guid("26e65b7d-a1f8-41d8-a6f3-89780c0c78bb"), new Guid("5d4ea2ba-8279-4bb0-a787-1597b39759f1"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6865), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("2cc6259b-081c-411b-ba32-d39dc7bf89ee"), new Guid("29b4ee74-5cf1-49a1-90d5-c4049459d0c5"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6689), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("2e2d9762-72bf-475a-93f0-68166ca0bc1c"), new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6661), null, "david.martinez@example.com", "David", new Guid("10000000-0000-0000-0000-000000000003"), "Martinez" },
                    { new Guid("2eb69c99-d33d-462f-8e01-69edce21890b"), new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6801), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("3268b0f7-78a6-47d8-9fd6-92eaf618126f"), new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6703), null, "michael.brown@example.com", "Michael", new Guid("10000000-0000-0000-0000-000000000001"), "Brown" },
                    { new Guid("32f00f8a-a70d-4165-a112-97967c53c8e5"), new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6812), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("3353d142-1b11-4473-8a9e-e9501795e98b"), new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6896), null, "david.martinez@example.com", "David", new Guid("10000000-0000-0000-0000-000000000003"), "Martinez" },
                    { new Guid("374e5d25-3118-4aa3-b649-e2f8c12bd818"), new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6832), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("3918632f-df75-4fb0-8501-8e3de8de006a"), new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6660), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("3a3f8a1b-04f2-4664-9e2c-a83a8e642145"), new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6853), null, "ryan.evans@example.com", "Ryan", new Guid("10000000-0000-0000-0000-000000000024"), "Evans" },
                    { new Guid("4315b740-f2ee-411e-901c-03b32670abd2"), new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6753), null, "henry.scott@example.com", "Henry", new Guid("10000000-0000-0000-0000-000000000017"), "Scott" },
                    { new Guid("46d3a14b-95ce-423c-a438-3766ae569bc9"), new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6741), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("46f62864-40a6-4d1c-9a58-cb0d4a9dc4f9"), new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6723), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("47088a24-3455-4a6e-9b56-e1f786b823a5"), new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6823), null, "james.anderson@example.com", "James", new Guid("10000000-0000-0000-0000-000000000005"), "Anderson" },
                    { new Guid("47bd5b48-de82-4837-9089-c8a2df73ee63"), new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6899), null, "scarlett.cook@example.com", "Scarlett", new Guid("10000000-0000-0000-0000-000000000028"), "Cook" },
                    { new Guid("49ce9cf8-f4f0-42a6-922d-de5947c88bfa"), new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6851), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("4a76d886-4cf1-44a8-afe6-b3aa3d440d8e"), new Guid("af63d331-5308-4e96-9be4-e441409940db"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6643), null, "sarah.wilson@example.com", "Sarah", new Guid("10000000-0000-0000-0000-000000000002"), "Wilson" },
                    { new Guid("4bb08a80-4ce7-497e-8aa3-e960c3b61e1d"), new Guid("af63d331-5308-4e96-9be4-e441409940db"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6593), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("51a5f66d-c6f7-4d88-ba7a-8b09b92aed66"), new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6878), null, "hannah.collins@example.com", "Hannah", new Guid("10000000-0000-0000-0000-000000000025"), "Collins" },
                    { new Guid("56f6b118-761a-4a3a-9573-160bc098cbf0"), new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6830), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("58c8c0f2-2f6b-42db-8d10-17f4786b66a3"), new Guid("29b4ee74-5cf1-49a1-90d5-c4049459d0c5"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6692), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("5a3e3182-d4f6-4cf1-8955-1ec1a3832c88"), new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6893), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("5e2b07f8-2254-4c2a-ba05-0e63903e51f7"), new Guid("13195e38-b24b-4e99-b2f3-1f0d82f2d279"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6854), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("5fc7ab6c-3693-47f7-afa7-7d4151bb7348"), new Guid("fa2d488f-7db0-4723-a663-8b7806a99014"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6665), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("60424b5b-6c14-474c-93f1-118e082c17b6"), new Guid("29b4ee74-5cf1-49a1-90d5-c4049459d0c5"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6693), null, "emma.garcia@example.com", "Emma", new Guid("10000000-0000-0000-0000-000000000004"), "Garcia" },
                    { new Guid("627a5118-6515-4769-a23a-340cade64efc"), new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6745), null, "james.anderson@example.com", "James", new Guid("10000000-0000-0000-0000-000000000005"), "Anderson" },
                    { new Guid("67280327-8cff-4d79-a1c9-111328519ecb"), new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6887), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("68737ca5-3f56-45e7-bd85-227a0402ea7d"), new Guid("13195e38-b24b-4e99-b2f3-1f0d82f2d279"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6856), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("688441b2-e6fb-443d-9596-96f6093999b9"), new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6717), null, "ethan.walker@example.com", "Ethan", new Guid("10000000-0000-0000-0000-000000000012"), "Walker" },
                    { new Guid("71dba159-2133-402a-be65-8119b19a5ec9"), new Guid("af63d331-5308-4e96-9be4-e441409940db"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6635), null, "michael.brown@example.com", "Michael", new Guid("10000000-0000-0000-0000-000000000001"), "Brown" },
                    { new Guid("720b59bd-4bf4-49a9-b4ad-b4ca0de032bb"), new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6877), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("723e0a6f-dac9-4602-9f24-c18c5ab964fc"), new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6729), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("7a3e1bc2-c3ef-44a1-82d5-b5642d6a3ea3"), new Guid("d8cd84bb-e04d-43b1-8b3c-45a3e56d58d0"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6749), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("7b4656f5-aff3-4979-99a1-2c7f2055c3ff"), new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6880), null, "ethan.walker@example.com", "Ethan", new Guid("10000000-0000-0000-0000-000000000012"), "Walker" },
                    { new Guid("7d61e06c-23b7-4be9-92eb-6d836ac67c31"), new Guid("29b4ee74-5cf1-49a1-90d5-c4049459d0c5"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6694), null, "william.martin@example.com", "William", new Guid("10000000-0000-0000-0000-000000000009"), "Martin" },
                    { new Guid("7de5af76-0353-482a-8bbb-82ee5da578b6"), new Guid("64dc086c-1c92-42e5-b252-05d2b8b49b40"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6837), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("86a52960-7f7b-4054-810f-d207f1f00e3d"), new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6725), null, "david.martinez@example.com", "David", new Guid("10000000-0000-0000-0000-000000000003"), "Martinez" },
                    { new Guid("87fd7416-d30c-4fa3-b17a-aa76895ca822"), new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6757), null, "emma.garcia@example.com", "Emma", new Guid("10000000-0000-0000-0000-000000000004"), "Garcia" },
                    { new Guid("88581f9c-c715-4139-a625-9156fc2256ca"), new Guid("4af46aff-b36e-4ad3-ba92-f95b8923ab17"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6695), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("8c5471f7-f9db-4732-98be-057a26a080e4"), new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6836), null, "jackson.campbell@example.com", "Jackson", new Guid("10000000-0000-0000-0000-000000000023"), "Campbell" },
                    { new Guid("8d5a66ee-6de2-49bf-bada-a848b9674f2f"), new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6805), null, "daniel.nelson@example.com", "Daniel", new Guid("10000000-0000-0000-0000-000000000019"), "Nelson" },
                    { new Guid("8f3c12c8-e4f4-4e28-bb83-27ef0790e12f"), new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6699), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("91109b23-97ba-4082-822b-3e6990cafadf"), new Guid("7969299d-5850-4fbe-9224-c03e7e283764"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6675), null, "liam.thomas@example.com", "Liam", new Guid("10000000-0000-0000-0000-000000000006"), "Thomas" },
                    { new Guid("91d29abc-4572-4f25-93e2-411ee7fdc948"), new Guid("c2a9a83e-0d4b-4735-8e79-9405547f46f2"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6806), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("92bca96a-8021-492f-952f-e6596e855ef9"), new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6727), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("980cac9b-7d48-4bdf-8110-5c0ad211cbe5"), new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6662), null, "emma.garcia@example.com", "Emma", new Guid("10000000-0000-0000-0000-000000000004"), "Garcia" },
                    { new Guid("98369cfa-a201-42ad-82a9-5999cd69ede9"), new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6743), null, "sarah.wilson@example.com", "Sarah", new Guid("10000000-0000-0000-0000-000000000002"), "Wilson" },
                    { new Guid("9ab92d0a-aa11-49d8-82b6-648eb21bee06"), new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6898), null, "caleb.reed@example.com", "Caleb", new Guid("10000000-0000-0000-0000-000000000027"), "Reed" },
                    { new Guid("9ea66487-5114-4097-a178-4539be8df2d1"), new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6700), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("a154b4c4-3b42-462c-b63d-9d6a3ed2269b"), new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6849), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("a40d73b3-a73d-4d97-9bcd-c60495a941ea"), new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6658), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("a5a2492a-8477-4799-bfca-1a896b79c944"), new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6895), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("a72526ca-b6e7-4f82-bd35-4f409965c134"), new Guid("7969299d-5850-4fbe-9224-c03e7e283764"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6673), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("a76e332d-0068-4c17-9a4b-ab376e80ebb8"), new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6867), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("ab915dae-c1c4-42bd-bb47-0d0edf2b6851"), new Guid("1db4bcd6-26f4-46e4-a373-ab833fb61586"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6720), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("aba7d6b4-2975-4b16-b380-b18daf7a2bbc"), new Guid("c2a9a83e-0d4b-4735-8e79-9405547f46f2"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6809), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("abecae27-9baa-4338-bc16-e92e49829b03"), new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6802), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("ac1e1852-9abd-4d29-9215-068c6bdafad3"), new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6879), null, "isaac.stewart@example.com", "Isaac", new Guid("10000000-0000-0000-0000-000000000026"), "Stewart" },
                    { new Guid("af7eca22-d4f5-4e6e-813b-6c8b1e40cc4e"), new Guid("5d4ea2ba-8279-4bb0-a787-1597b39759f1"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6864), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("b1453308-ff9a-46a0-a6ee-154be57b7153"), new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6826), null, "lily.roberts@example.com", "Lily", new Guid("10000000-0000-0000-0000-000000000021"), "Roberts" },
                    { new Guid("ba517247-07b4-4df2-8511-7af1adfac518"), new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6726), null, "mia.young@example.com", "Mia", new Guid("10000000-0000-0000-0000-000000000014"), "Young" },
                    { new Guid("bd775055-5416-4b46-b244-959461fb7c24"), new Guid("4af46aff-b36e-4ad3-ba92-f95b8923ab17"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6697), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("c130e7f4-3c08-4864-978e-5f9ca8e48507"), new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6824), null, "samuel.perez@example.com", "Samuel", new Guid("10000000-0000-0000-0000-000000000020"), "Perez" },
                    { new Guid("c410d265-e2a4-428b-a1ce-ef870eeea0e0"), new Guid("7969299d-5850-4fbe-9224-c03e7e283764"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6686), null, "sophia.jackson@example.com", "Sophia", new Guid("10000000-0000-0000-0000-000000000007"), "Jackson" },
                    { new Guid("c762fd2e-431d-4ba7-99e6-c24fab38f299"), new Guid("7969299d-5850-4fbe-9224-c03e7e283764"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6687), null, "noah.white@example.com", "Noah", new Guid("10000000-0000-0000-0000-000000000008"), "White" },
                    { new Guid("cd00abbe-1eb7-4a95-9a3b-219f883e967d"), new Guid("fa2d488f-7db0-4723-a663-8b7806a99014"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6666), null, "sarah.wilson@example.com", "Sarah", new Guid("10000000-0000-0000-0000-000000000002"), "Wilson" },
                    { new Guid("ce2bef60-b280-4cd4-b663-032f7c206bc8"), new Guid("aeb49686-550e-48e1-af38-5d287839a05a"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6885), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("ceea6c44-fbc6-4eb4-9598-68ee33d13010"), new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6889), null, "evelyn.hill@example.com", "Evelyn", new Guid("10000000-0000-0000-0000-000000000016"), "Hill" },
                    { new Guid("d64170fd-408e-406e-8518-6c747ea24820"), new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6835), null, "charlotte.lee@example.com", "Charlotte", new Guid("10000000-0000-0000-0000-000000000011"), "Lee" },
                    { new Guid("d8eb5bbe-2905-4161-b0f4-ff5f3200bf2d"), new Guid("af63d331-5308-4e96-9be4-e441409940db"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6632), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("da9d2a1c-f4b1-4530-a80e-197caa72db9c"), new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6813), null, "david.martinez@example.com", "David", new Guid("10000000-0000-0000-0000-000000000003"), "Martinez" },
                    { new Guid("df852e79-3e48-4c9d-bdef-d1fe56dade01"), new Guid("4af46aff-b36e-4ad3-ba92-f95b8923ab17"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6698), null, "isabella.thompson@example.com", "Isabella", new Guid("10000000-0000-0000-0000-000000000010"), "Thompson" },
                    { new Guid("df98484a-da6e-4c42-a419-3b1563ce21af"), new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6752), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("e0b46bfc-397d-4418-b601-e321eda207b3"), new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6834), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("e1d6498b-4ea9-438c-a554-8c902211d4c9"), new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6747), null, "evelyn.hill@example.com", "Evelyn", new Guid("10000000-0000-0000-0000-000000000016"), "Hill" },
                    { new Guid("e25cf310-878a-4f2f-8701-9c330bf1d825"), new Guid("0a3d8b7b-cbd2-485d-906f-9da922cce946"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6797), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("e4b25cd0-ec96-4b5e-a942-9d61158d3b6a"), new Guid("773695e9-13e4-453c-824d-31495b91223c"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6859), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("e5c770c9-e83d-45da-9bd3-0f99af22b871"), new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6831), null, "matthew.turner@example.com", "Matthew", new Guid("10000000-0000-0000-0000-000000000022"), "Turner" },
                    { new Guid("e7a2e55a-1cf9-439a-98cc-26c3a7429f62"), new Guid("2f39ff8d-1733-4672-927a-e11f6696e606"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6892), new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"), null, null, null, null },
                    { new Guid("e9a25885-75f4-47df-8652-b23c9bf7c7f1"), new Guid("64dc086c-1c92-42e5-b252-05d2b8b49b40"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6838), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("e9c71818-88d2-4866-b17d-ca70feea04c4"), new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6852), null, "ella.green@example.com", "Ella", new Guid("10000000-0000-0000-0000-000000000018"), "Green" },
                    { new Guid("eb212798-f59b-4120-8c95-8396026c78cd"), new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6754), null, "ella.green@example.com", "Ella", new Guid("10000000-0000-0000-0000-000000000018"), "Green" },
                    { new Guid("eee702a5-1aa0-4294-9812-6dc09a990736"), new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6715), null, "charlotte.lee@example.com", "Charlotte", new Guid("10000000-0000-0000-0000-000000000011"), "Lee" },
                    { new Guid("f0db844c-bf4b-49b6-a995-55c37d297c7c"), new Guid("0a3d8b7b-cbd2-485d-906f-9da922cce946"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6799), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("f1b59a19-aab1-4f3a-a824-4f19afd633ab"), new Guid("773695e9-13e4-453c-824d-31495b91223c"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6862), null, "sarah.wilson@example.com", "Sarah", new Guid("10000000-0000-0000-0000-000000000002"), "Wilson" },
                    { new Guid("f72ab51c-69d5-4936-a3d0-4e76f7c790f5"), new Guid("6b5d6067-1a6b-467f-874c-e7bc67a3022c"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6669), new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"), null, null, null, null },
                    { new Guid("f88f7cd9-9e99-4c50-9ff4-e6834b573f95"), new Guid("2f39ff8d-1733-4672-927a-e11f6696e606"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6890), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("fa4b02b9-e2c1-4837-8fda-0dd3732f3fbc"), new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6750), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null },
                    { new Guid("fc0daf68-fb81-468d-bc40-216160c3c4cf"), new Guid("aeb49686-550e-48e1-af38-5d287839a05a"), new DateTime(2025, 10, 26, 11, 7, 39, 592, DateTimeKind.Utc).AddTicks(6884), new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"), null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "EventTags",
                columns: new[] { "EventId", "TagId", "Id" },
                values: new object[,]
                {
                    { new Guid("0a3d8b7b-cbd2-485d-906f-9da922cce946"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("118ad4bf-dcec-4c42-8ab7-96450ae5ea92") },
                    { new Guid("0a3d8b7b-cbd2-485d-906f-9da922cce946"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("f54d8e68-5f0d-414e-ad3b-9791b9c1bcc8") },
                    { new Guid("0a3d8b7b-cbd2-485d-906f-9da922cce946"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821"), new Guid("f11032a8-d6ea-4bd1-95c4-942bfbe66879") },
                    { new Guid("0a3d8b7b-cbd2-485d-906f-9da922cce946"), new Guid("d1ff6e85-8f3a-45a1-beea-8546b23ee5d0"), new Guid("16acc132-49df-44b3-9f6b-1262296d9368") },
                    { new Guid("13195e38-b24b-4e99-b2f3-1f0d82f2d279"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105"), new Guid("9d453d1a-7582-4c00-a5fa-5eb8bf5784ca") },
                    { new Guid("13195e38-b24b-4e99-b2f3-1f0d82f2d279"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f"), new Guid("4c942e4b-f33e-48ec-823f-7b689e34918f") },
                    { new Guid("13195e38-b24b-4e99-b2f3-1f0d82f2d279"), new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727"), new Guid("033e69fb-a245-4441-8e9e-efe29783d60b") },
                    { new Guid("1db4bcd6-26f4-46e4-a373-ab833fb61586"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("53068921-b47e-44f6-b15f-ea565344c57f") },
                    { new Guid("1db4bcd6-26f4-46e4-a373-ab833fb61586"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821"), new Guid("6082ec79-8e33-437d-b96f-11d352d06c68") },
                    { new Guid("1db4bcd6-26f4-46e4-a373-ab833fb61586"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("05051fa8-6165-4fdb-8c88-7068014ad93e") },
                    { new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f"), new Guid("74fa9e0f-537e-43c7-85de-512b380f4049") },
                    { new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821"), new Guid("5d1e3173-cd4d-4406-94a9-adfa20f48a1f") },
                    { new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727"), new Guid("01620d91-3ac2-440e-bfc5-d7486d2674e3") },
                    { new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("a9109872-d44d-4aaf-a6ed-963ad8ece086") },
                    { new Guid("29b4ee74-5cf1-49a1-90d5-c4049459d0c5"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821"), new Guid("223b157a-07cc-4f94-b767-50472de7e7ef") },
                    { new Guid("29b4ee74-5cf1-49a1-90d5-c4049459d0c5"), new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727"), new Guid("cae01591-86df-47c7-a06e-8caa0ae6ed84") },
                    { new Guid("29b4ee74-5cf1-49a1-90d5-c4049459d0c5"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("24f6ce05-c063-4067-8b3a-ce05e484a936") },
                    { new Guid("2f39ff8d-1733-4672-927a-e11f6696e606"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f"), new Guid("fa58bbbc-413b-4b3f-af9f-84460565b7f1") },
                    { new Guid("2f39ff8d-1733-4672-927a-e11f6696e606"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821"), new Guid("b7ce82ac-f53c-4f5d-8c5d-2071db177fc2") },
                    { new Guid("2f39ff8d-1733-4672-927a-e11f6696e606"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("8dd3172c-2c16-4222-a9e9-970e99cd33de") },
                    { new Guid("2f39ff8d-1733-4672-927a-e11f6696e606"), new Guid("d1ff6e85-8f3a-45a1-beea-8546b23ee5d0"), new Guid("ba807fe3-487e-4dcf-9c2d-6872e50c4123") },
                    { new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("890100d4-fe2a-43dc-ab67-14f6190e033c") },
                    { new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f"), new Guid("ca605047-83f1-48b9-91c6-a247e3eea4aa") },
                    { new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821"), new Guid("d65ed40f-4d90-43e8-8325-2a6ade8e6973") },
                    { new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("28c00acd-a6b4-411d-ba40-b828bab807dd") },
                    { new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911"), new Guid("5ec29bf2-283c-4e8c-81be-da9c3d0ed134") },
                    { new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f"), new Guid("4bedd439-851b-4686-b7ed-832e166d74a0") },
                    { new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("5e17079d-e8ae-494a-89a4-51fcff2c060d") },
                    { new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("9a252968-db42-44e6-8e9d-e79bc267403f") },
                    { new Guid("378199c1-8040-444d-8e98-527b2652e646"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("32707aa4-4300-4bb7-aff7-d6ef406fe575") },
                    { new Guid("378199c1-8040-444d-8e98-527b2652e646"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f"), new Guid("506ecb1d-38a7-4b55-87b8-bcb09110fdff") },
                    { new Guid("378199c1-8040-444d-8e98-527b2652e646"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("c410a3a2-4538-4a9f-9449-eb6013c451d8") },
                    { new Guid("378199c1-8040-444d-8e98-527b2652e646"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("1821c45c-ffe9-4470-8922-0ee0df614bdd") },
                    { new Guid("4af46aff-b36e-4ad3-ba92-f95b8923ab17"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105"), new Guid("eb59485a-0d5b-49b8-86e6-4d9cfe497a34") },
                    { new Guid("4af46aff-b36e-4ad3-ba92-f95b8923ab17"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f"), new Guid("e3ae8b30-a4fd-4100-bf5c-cb6304d2dd35") },
                    { new Guid("4af46aff-b36e-4ad3-ba92-f95b8923ab17"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("45d18b54-11b3-4a5a-b303-bafb4003368e") },
                    { new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105"), new Guid("33d19033-dedc-4025-a606-6f8b48c846d5") },
                    { new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("76e5af5f-bf24-432a-a699-2bbc71a2ffd8") },
                    { new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f"), new Guid("221caf98-ad63-45bd-8071-70c3eb429f7d") },
                    { new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("1d346c16-86b3-4c93-82f3-a7563f5e2bf7") },
                    { new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911"), new Guid("ea150330-a0a7-4f15-b7aa-4778b31a1949") },
                    { new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("15cb3ea5-6be1-439e-8c33-3f33983fb4a1") },
                    { new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("5bec06ef-29c5-46a8-94d8-5b0b845a6a8c") },
                    { new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("2e4fd261-93c5-453f-8f11-8baac1f4d90b") },
                    { new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911"), new Guid("d6f6e104-474a-4d02-8794-b5592ba66ae0") },
                    { new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("5f111e83-7ad1-4a15-abce-06e7bcf25d52") },
                    { new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f"), new Guid("1381b3aa-a6fa-4f2c-8a16-632228d983c8") },
                    { new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("f8fb57b9-19ab-4afe-9113-c2d8599fa664") },
                    { new Guid("5d4ea2ba-8279-4bb0-a787-1597b39759f1"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("fda43f1f-35e1-4401-97b6-c12f1672f877") },
                    { new Guid("5d4ea2ba-8279-4bb0-a787-1597b39759f1"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("872a2f40-87b7-4185-b153-9ca411c2ab4f") },
                    { new Guid("5d4ea2ba-8279-4bb0-a787-1597b39759f1"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("444b1679-5692-4563-87f6-0919d4fbd3d3") },
                    { new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105"), new Guid("6d093c38-01a9-4891-930e-130a986753e9") },
                    { new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911"), new Guid("dc07d203-9a14-4017-a43c-d0afd6948107") },
                    { new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f"), new Guid("06a8a7d5-242e-49d7-8b7a-bf370894db19") },
                    { new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"), new Guid("d1ff6e85-8f3a-45a1-beea-8546b23ee5d0"), new Guid("412b07b3-5e9c-42df-b4f1-275c3062d21f") },
                    { new Guid("64dc086c-1c92-42e5-b252-05d2b8b49b40"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911"), new Guid("0c51c567-ba37-49c7-8ce4-2f649c25379f") },
                    { new Guid("64dc086c-1c92-42e5-b252-05d2b8b49b40"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("6096455e-b6de-4ff7-9d19-177a2090f68c") },
                    { new Guid("64dc086c-1c92-42e5-b252-05d2b8b49b40"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f"), new Guid("eaa41823-bc7f-4f78-bb62-bbe89e3acf2d") },
                    { new Guid("64dc086c-1c92-42e5-b252-05d2b8b49b40"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("59a3d07d-d1ef-48ad-b27d-95a31c99a885") },
                    { new Guid("6b5d6067-1a6b-467f-874c-e7bc67a3022c"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105"), new Guid("f7f95d27-d05b-4777-b9be-2cc87e7d17d3") },
                    { new Guid("6b5d6067-1a6b-467f-874c-e7bc67a3022c"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("032783e0-e791-449b-b004-9293272db489") },
                    { new Guid("6b5d6067-1a6b-467f-874c-e7bc67a3022c"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("faea2050-d853-493f-b95e-cb64b1c3e8dc") },
                    { new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("73be02db-9893-42c9-85d8-b6672d70807e") },
                    { new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("f98697ab-3de8-46da-865d-ca79f0e63aa3") },
                    { new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821"), new Guid("3e6dc133-cd08-43ef-8a02-85fe9f6c8d9c") },
                    { new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), new Guid("d1ff6e85-8f3a-45a1-beea-8546b23ee5d0"), new Guid("b0eaff3f-b5e1-47b0-b126-ac02bff8f533") },
                    { new Guid("773695e9-13e4-453c-824d-31495b91223c"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f"), new Guid("5b9d5a24-8246-48e6-b6f0-1d9aa3283fec") },
                    { new Guid("773695e9-13e4-453c-824d-31495b91223c"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("368a0ba3-c9e7-4a36-8deb-72cb8ba1e756") },
                    { new Guid("773695e9-13e4-453c-824d-31495b91223c"), new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727"), new Guid("8d52b0aa-1bba-4546-a5b1-fa8ec3363482") },
                    { new Guid("773695e9-13e4-453c-824d-31495b91223c"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("6ee7d07e-763a-43ff-b1c6-3f711354837a") },
                    { new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911"), new Guid("c9f75b51-7014-4c7a-8858-20119b4158b1") },
                    { new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("c69ff4f8-e8cf-4af8-a48b-11da84802320") },
                    { new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("c5b1597c-7eb5-43b9-b4f8-4bfa88f19dff") },
                    { new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821"), new Guid("8f64e513-2eb9-4d01-899c-6fcb1d4746c4") },
                    { new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("1afdc7fe-6644-4623-982d-dcc7437158cc") },
                    { new Guid("7969299d-5850-4fbe-9224-c03e7e283764"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("36ce1848-5da9-4d0e-a9d9-24b5fd59ba24") },
                    { new Guid("7969299d-5850-4fbe-9224-c03e7e283764"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("a0f04940-bcc4-45a0-af53-e40f7935bf36") },
                    { new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911"), new Guid("c80b327d-23af-48b8-90a3-02fad1cdd327") },
                    { new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("7b3459c2-952b-40fc-afa4-4dffc15e53bb") },
                    { new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("93660bca-93ca-474c-9919-017fc9ebfab1") },
                    { new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("626fe2f7-a71e-4613-b362-6234b46c45eb") },
                    { new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105"), new Guid("897ed9c4-f33c-41b9-9869-6c7c764bfdd1") },
                    { new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911"), new Guid("3bb46466-abc9-48e8-a86b-04bc9c3dcdde") },
                    { new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("b036aaa6-eae9-431f-9b5e-37f5b4cd560e") },
                    { new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("ae39c002-f12f-4dac-af9c-14cd86f1e0b8") },
                    { new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("78b027d7-968b-43a3-b1ea-594d7a9d729f") },
                    { new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f"), new Guid("f3ebcc53-0924-42a2-9c64-305eccbe2056") },
                    { new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821"), new Guid("2039a224-a9aa-486e-be9e-7d2901cb183b") },
                    { new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new Guid("d1ff6e85-8f3a-45a1-beea-8546b23ee5d0"), new Guid("d805c1c6-7bf8-4ff4-be53-11e1de5f6b8c") },
                    { new Guid("aeb49686-550e-48e1-af38-5d287839a05a"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105"), new Guid("532bbde0-2a0a-4817-90d4-d86ed81b8fd0") },
                    { new Guid("aeb49686-550e-48e1-af38-5d287839a05a"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f"), new Guid("c59f4712-8eda-4499-bb28-19fa88fea912") },
                    { new Guid("aeb49686-550e-48e1-af38-5d287839a05a"), new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727"), new Guid("7e63a111-08af-4ecc-8433-dd856d1b0cef") },
                    { new Guid("af63d331-5308-4e96-9be4-e441409940db"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("12f96369-112b-4e28-8331-e6840c20587f") },
                    { new Guid("af63d331-5308-4e96-9be4-e441409940db"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("30f2ca0c-7564-4591-86bf-d1ed91541ad7") },
                    { new Guid("af63d331-5308-4e96-9be4-e441409940db"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("92666c5a-c7dd-4a8c-99ac-188f9a615bcf") },
                    { new Guid("c2a9a83e-0d4b-4735-8e79-9405547f46f2"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f"), new Guid("66c58485-342a-4f92-8058-7000745d5847") },
                    { new Guid("c2a9a83e-0d4b-4735-8e79-9405547f46f2"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f"), new Guid("243ac2d5-0fe6-4a6f-a107-4927689a69c6") },
                    { new Guid("c2a9a83e-0d4b-4735-8e79-9405547f46f2"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("f27a565c-902b-434a-bb5b-5bf44e106c6f") },
                    { new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105"), new Guid("0f5d6381-4f9a-4294-8627-d5e2db182102") },
                    { new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("5d69b761-908c-4010-8143-6f364429c771") },
                    { new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f"), new Guid("8dfb3d4d-834e-48fc-956c-49071b688b12") },
                    { new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f"), new Guid("c92bfbae-bdb1-40e9-88be-1bfdeb112a48") },
                    { new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727"), new Guid("be14c3e5-ff78-407e-a51c-79694b9ba6ed") },
                    { new Guid("d8cd84bb-e04d-43b1-8b3c-45a3e56d58d0"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105"), new Guid("56d3e998-fd44-4265-9c86-69966e44d332") },
                    { new Guid("d8cd84bb-e04d-43b1-8b3c-45a3e56d58d0"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("f2a2fac6-c784-46be-89e7-69685ddd4027") },
                    { new Guid("d8cd84bb-e04d-43b1-8b3c-45a3e56d58d0"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("01c4672f-104c-4b6f-ba48-8ca83781d837") },
                    { new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911"), new Guid("df237170-5cef-485c-ace9-61d371e0d6dd") },
                    { new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"), new Guid("e2e03b0c-b7f1-4666-ac1f-8860304eb7f8") },
                    { new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("31a729b0-6546-4943-8c48-6399133c2432") },
                    { new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("34389003-d246-4e67-9d80-fe145a48d94d") },
                    { new Guid("fa2d488f-7db0-4723-a663-8b7806a99014"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f"), new Guid("d4268751-03f2-4861-8d37-9b2a26ea4ff7") },
                    { new Guid("fa2d488f-7db0-4723-a663-8b7806a99014"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"), new Guid("c62b00cd-7a89-4dcc-81ac-0a5d0ec9f18d") },
                    { new Guid("fa2d488f-7db0-4723-a663-8b7806a99014"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"), new Guid("7752596a-e071-4a7f-bec1-50e84d059862") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_NormalizedName",
                table: "Tags",
                column: "NormalizedName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tags_NormalizedName",
                table: "Tags");

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("0034e9ac-0caf-4c99-82b0-1eda410b6135"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("00677002-54db-4a15-ac9f-ebe0f3611a26"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("01f43951-0da5-4f51-a8b2-34f5256102a9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("023f2f99-496a-4a64-97f1-5503346534b7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("045df9c3-3620-4ef5-ac97-a98f3f418340"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("066cd356-e5ac-425e-bd68-76710de72174"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("0ab77e40-048d-4c0e-8bb0-be7f5a983e7d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("0acacb7a-9ce3-4ea0-9ecb-526966f660f5"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("105dbc34-94b3-4ba2-90b7-eb28f5201c08"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("13f00f36-9049-4f46-876e-eddb89b67e0c"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("17b505e6-5183-40cb-92fc-3d45daaac31c"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("19fcb0d8-bab5-42c2-897b-3a0a341c6427"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("1a9420a6-4306-4d7f-a6fe-45238fea05d0"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("1bb3a070-e66d-4208-bd77-1a6b33bc4ab2"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("1e97a1e0-7f07-43be-8fc9-2b18c7cf158c"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("1f0c52cc-d7f2-4508-9d91-b25c626c1f61"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("1fe5a181-3ca6-409d-97f4-5ff63e70ec94"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("26e65b7d-a1f8-41d8-a6f3-89780c0c78bb"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("2cc6259b-081c-411b-ba32-d39dc7bf89ee"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("2e2d9762-72bf-475a-93f0-68166ca0bc1c"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("2eb69c99-d33d-462f-8e01-69edce21890b"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("3268b0f7-78a6-47d8-9fd6-92eaf618126f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("32f00f8a-a70d-4165-a112-97967c53c8e5"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("3353d142-1b11-4473-8a9e-e9501795e98b"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("374e5d25-3118-4aa3-b649-e2f8c12bd818"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("3918632f-df75-4fb0-8501-8e3de8de006a"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("3a3f8a1b-04f2-4664-9e2c-a83a8e642145"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("4315b740-f2ee-411e-901c-03b32670abd2"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("46d3a14b-95ce-423c-a438-3766ae569bc9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("46f62864-40a6-4d1c-9a58-cb0d4a9dc4f9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("47088a24-3455-4a6e-9b56-e1f786b823a5"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("47bd5b48-de82-4837-9089-c8a2df73ee63"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("49ce9cf8-f4f0-42a6-922d-de5947c88bfa"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("4a76d886-4cf1-44a8-afe6-b3aa3d440d8e"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("4bb08a80-4ce7-497e-8aa3-e960c3b61e1d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("51a5f66d-c6f7-4d88-ba7a-8b09b92aed66"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("56f6b118-761a-4a3a-9573-160bc098cbf0"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("58c8c0f2-2f6b-42db-8d10-17f4786b66a3"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("5a3e3182-d4f6-4cf1-8955-1ec1a3832c88"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("5e2b07f8-2254-4c2a-ba05-0e63903e51f7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("5fc7ab6c-3693-47f7-afa7-7d4151bb7348"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("60424b5b-6c14-474c-93f1-118e082c17b6"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("627a5118-6515-4769-a23a-340cade64efc"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("67280327-8cff-4d79-a1c9-111328519ecb"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("68737ca5-3f56-45e7-bd85-227a0402ea7d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("688441b2-e6fb-443d-9596-96f6093999b9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("71dba159-2133-402a-be65-8119b19a5ec9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("720b59bd-4bf4-49a9-b4ad-b4ca0de032bb"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("723e0a6f-dac9-4602-9f24-c18c5ab964fc"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("7a3e1bc2-c3ef-44a1-82d5-b5642d6a3ea3"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("7b4656f5-aff3-4979-99a1-2c7f2055c3ff"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("7d61e06c-23b7-4be9-92eb-6d836ac67c31"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("7de5af76-0353-482a-8bbb-82ee5da578b6"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("86a52960-7f7b-4054-810f-d207f1f00e3d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("87fd7416-d30c-4fa3-b17a-aa76895ca822"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("88581f9c-c715-4139-a625-9156fc2256ca"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("8c5471f7-f9db-4732-98be-057a26a080e4"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("8d5a66ee-6de2-49bf-bada-a848b9674f2f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("8f3c12c8-e4f4-4e28-bb83-27ef0790e12f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("91109b23-97ba-4082-822b-3e6990cafadf"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("91d29abc-4572-4f25-93e2-411ee7fdc948"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("92bca96a-8021-492f-952f-e6596e855ef9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("980cac9b-7d48-4bdf-8110-5c0ad211cbe5"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("98369cfa-a201-42ad-82a9-5999cd69ede9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("9ab92d0a-aa11-49d8-82b6-648eb21bee06"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("9ea66487-5114-4097-a178-4539be8df2d1"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("a154b4c4-3b42-462c-b63d-9d6a3ed2269b"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("a40d73b3-a73d-4d97-9bcd-c60495a941ea"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("a5a2492a-8477-4799-bfca-1a896b79c944"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("a72526ca-b6e7-4f82-bd35-4f409965c134"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("a76e332d-0068-4c17-9a4b-ab376e80ebb8"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ab915dae-c1c4-42bd-bb47-0d0edf2b6851"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("aba7d6b4-2975-4b16-b380-b18daf7a2bbc"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("abecae27-9baa-4338-bc16-e92e49829b03"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ac1e1852-9abd-4d29-9215-068c6bdafad3"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("af7eca22-d4f5-4e6e-813b-6c8b1e40cc4e"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("b1453308-ff9a-46a0-a6ee-154be57b7153"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ba517247-07b4-4df2-8511-7af1adfac518"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("bd775055-5416-4b46-b244-959461fb7c24"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c130e7f4-3c08-4864-978e-5f9ca8e48507"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c410d265-e2a4-428b-a1ce-ef870eeea0e0"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c762fd2e-431d-4ba7-99e6-c24fab38f299"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("cd00abbe-1eb7-4a95-9a3b-219f883e967d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ce2bef60-b280-4cd4-b663-032f7c206bc8"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ceea6c44-fbc6-4eb4-9598-68ee33d13010"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d64170fd-408e-406e-8518-6c747ea24820"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d8eb5bbe-2905-4161-b0f4-ff5f3200bf2d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("da9d2a1c-f4b1-4530-a80e-197caa72db9c"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("df852e79-3e48-4c9d-bdef-d1fe56dade01"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("df98484a-da6e-4c42-a419-3b1563ce21af"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("e0b46bfc-397d-4418-b601-e321eda207b3"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("e1d6498b-4ea9-438c-a554-8c902211d4c9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("e25cf310-878a-4f2f-8701-9c330bf1d825"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("e4b25cd0-ec96-4b5e-a942-9d61158d3b6a"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("e5c770c9-e83d-45da-9bd3-0f99af22b871"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("e7a2e55a-1cf9-439a-98cc-26c3a7429f62"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("e9a25885-75f4-47df-8652-b23c9bf7c7f1"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("e9c71818-88d2-4866-b17d-ca70feea04c4"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("eb212798-f59b-4120-8c95-8396026c78cd"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("eee702a5-1aa0-4294-9812-6dc09a990736"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("f0db844c-bf4b-49b6-a995-55c37d297c7c"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("f1b59a19-aab1-4f3a-a824-4f19afd633ab"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("f72ab51c-69d5-4936-a3d0-4e76f7c790f5"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("f88f7cd9-9e99-4c50-9ff4-e6834b573f95"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("fa4b02b9-e2c1-4837-8fda-0dd3732f3fbc"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("fc0daf68-fb81-468d-bc40-216160c3c4cf"));

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("0a3d8b7b-cbd2-485d-906f-9da922cce946"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("0a3d8b7b-cbd2-485d-906f-9da922cce946"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("0a3d8b7b-cbd2-485d-906f-9da922cce946"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("0a3d8b7b-cbd2-485d-906f-9da922cce946"), new Guid("d1ff6e85-8f3a-45a1-beea-8546b23ee5d0") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("13195e38-b24b-4e99-b2f3-1f0d82f2d279"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("13195e38-b24b-4e99-b2f3-1f0d82f2d279"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("13195e38-b24b-4e99-b2f3-1f0d82f2d279"), new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("1db4bcd6-26f4-46e4-a373-ab833fb61586"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("1db4bcd6-26f4-46e4-a373-ab833fb61586"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("1db4bcd6-26f4-46e4-a373-ab833fb61586"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("29b4ee74-5cf1-49a1-90d5-c4049459d0c5"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("29b4ee74-5cf1-49a1-90d5-c4049459d0c5"), new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("29b4ee74-5cf1-49a1-90d5-c4049459d0c5"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("2f39ff8d-1733-4672-927a-e11f6696e606"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("2f39ff8d-1733-4672-927a-e11f6696e606"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("2f39ff8d-1733-4672-927a-e11f6696e606"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("2f39ff8d-1733-4672-927a-e11f6696e606"), new Guid("d1ff6e85-8f3a-45a1-beea-8546b23ee5d0") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("378199c1-8040-444d-8e98-527b2652e646"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("378199c1-8040-444d-8e98-527b2652e646"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("378199c1-8040-444d-8e98-527b2652e646"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("378199c1-8040-444d-8e98-527b2652e646"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("4af46aff-b36e-4ad3-ba92-f95b8923ab17"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("4af46aff-b36e-4ad3-ba92-f95b8923ab17"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("4af46aff-b36e-4ad3-ba92-f95b8923ab17"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5d4ea2ba-8279-4bb0-a787-1597b39759f1"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5d4ea2ba-8279-4bb0-a787-1597b39759f1"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("5d4ea2ba-8279-4bb0-a787-1597b39759f1"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"), new Guid("d1ff6e85-8f3a-45a1-beea-8546b23ee5d0") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("64dc086c-1c92-42e5-b252-05d2b8b49b40"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("64dc086c-1c92-42e5-b252-05d2b8b49b40"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("64dc086c-1c92-42e5-b252-05d2b8b49b40"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("64dc086c-1c92-42e5-b252-05d2b8b49b40"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6b5d6067-1a6b-467f-874c-e7bc67a3022c"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6b5d6067-1a6b-467f-874c-e7bc67a3022c"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6b5d6067-1a6b-467f-874c-e7bc67a3022c"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"), new Guid("d1ff6e85-8f3a-45a1-beea-8546b23ee5d0") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("773695e9-13e4-453c-824d-31495b91223c"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("773695e9-13e4-453c-824d-31495b91223c"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("773695e9-13e4-453c-824d-31495b91223c"), new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("773695e9-13e4-453c-824d-31495b91223c"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("7969299d-5850-4fbe-9224-c03e7e283764"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("7969299d-5850-4fbe-9224-c03e7e283764"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"), new Guid("d1ff6e85-8f3a-45a1-beea-8546b23ee5d0") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("aeb49686-550e-48e1-af38-5d287839a05a"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("aeb49686-550e-48e1-af38-5d287839a05a"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("aeb49686-550e-48e1-af38-5d287839a05a"), new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("af63d331-5308-4e96-9be4-e441409940db"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("af63d331-5308-4e96-9be4-e441409940db"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("af63d331-5308-4e96-9be4-e441409940db"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c2a9a83e-0d4b-4735-8e79-9405547f46f2"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c2a9a83e-0d4b-4735-8e79-9405547f46f2"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c2a9a83e-0d4b-4735-8e79-9405547f46f2"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"), new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("d8cd84bb-e04d-43b1-8b3c-45a3e56d58d0"), new Guid("077fc647-953a-4caf-9f34-da90f8de3105") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("d8cd84bb-e04d-43b1-8b3c-45a3e56d58d0"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("d8cd84bb-e04d-43b1-8b3c-45a3e56d58d0"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("fa2d488f-7db0-4723-a663-8b7806a99014"), new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("fa2d488f-7db0-4723-a663-8b7806a99014"), new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37") });

            migrationBuilder.DeleteData(
                table: "EventTags",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { new Guid("fa2d488f-7db0-4723-a663-8b7806a99014"), new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124") });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("0a3d8b7b-cbd2-485d-906f-9da922cce946"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("13195e38-b24b-4e99-b2f3-1f0d82f2d279"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("1db4bcd6-26f4-46e4-a373-ab833fb61586"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("283086a6-96f7-4230-914d-8036f4ae9c40"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("29b4ee74-5cf1-49a1-90d5-c4049459d0c5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("2f39ff8d-1733-4672-927a-e11f6696e606"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3587b020-bb1f-47bb-9f10-a3097302b602"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3778639c-37a3-428e-8a3d-ee8b40e05ef7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("378199c1-8040-444d-8e98-527b2652e646"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("4af46aff-b36e-4ad3-ba92-f95b8923ab17"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("4bf1cdad-9c5a-4352-b4bc-f25831f11a42"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("516a6bc6-78b8-4318-951d-b1ac575111c6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5b3ea27b-0ac1-4406-8176-62f89208a5bf"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5d4ea2ba-8279-4bb0-a787-1597b39759f1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("6397aeab-34fd-49ab-8a0b-643ca8023a67"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("64dc086c-1c92-42e5-b252-05d2b8b49b40"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("6b5d6067-1a6b-467f-874c-e7bc67a3022c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("6d5182e6-e0a9-493f-8bf1-4fb0d892e953"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("773695e9-13e4-453c-824d-31495b91223c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("780eaf65-0e23-4be4-85fb-fa675089d5c5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("7969299d-5850-4fbe-9224-c03e7e283764"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("9a38a96e-3b06-41e4-b0bb-dd063f7a5443"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("a2cb6607-1ae0-48fc-8f51-d8a117d76ee9"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("a413782a-b2f1-42d0-ae50-6f7f8c76e47c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("aeb49686-550e-48e1-af38-5d287839a05a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("af63d331-5308-4e96-9be4-e441409940db"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c2a9a83e-0d4b-4735-8e79-9405547f46f2"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c345d4b3-c229-4a27-9801-f1738184b60a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d8cd84bb-e04d-43b1-8b3c-45a3e56d58d0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e62ae0ce-a05d-41da-be3b-f751f870ae17"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("fa2d488f-7db0-4723-a663-8b7806a99014"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("077fc647-953a-4caf-9f34-da90f8de3105"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1a8f0b11-4af4-4a1a-8e12-0bc489c95911"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3ffc2fab-a55d-4ab9-9026-2750f8d26b3b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("84424dbb-8f39-4032-8ad1-52b5c9af089f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a58f18d8-8cbb-4a4b-94dd-dafbcef1171f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b0a6f2e1-e344-44f9-8fe3-414d5f341a37"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b0adbc3e-7c90-4d47-a7ee-2a41b98da821"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c20d5800-fffb-47ee-99b0-a5b761c08727"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cfeea1c8-7f1d-4884-b2dd-9d5f52491124"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d1ff6e85-8f3a-45a1-beea-8546b23ee5d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ca4b27b-7f2d-47b5-9bd2-b4039edce573"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3b5b1d4-b8bf-4701-ae9f-08750f929197"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd68c999-f0f0-44f0-94fd-150f46b9166a"));

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "Tags");

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d2425e8-6548-469e-a581-598a65336047"), "Food & Drink" },
                    { new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31"), "Technology" },
                    { new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6"), "Health" },
                    { new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), "Networking" },
                    { new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), "Business" },
                    { new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d"), "Travel" },
                    { new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), "Education" },
                    { new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d"), "Music" },
                    { new Guid("b289c6e5-ea00-4666-9e87-50720a94a2fe"), "Sports" },
                    { new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb"), "Art" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("1a60ee7e-01a5-49a0-ad6f-0a356101ff6f"), "alice.johnson@example.com", "Alice", "Johnson", "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue" },
                    { new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"), "john.doe@example.com", "John", "Doe", "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue" },
                    { new Guid("970427a2-f8e8-4b3f-8f80-6ef23b443635"), "jane.smith@example.com", "Jane", "Smith", "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Capacity", "Date", "Description", "IsPublic", "Location", "OrganizerId", "Title" },
                values: new object[,]
                {
                    { new Guid("066f6038-e920-4885-8186-67ae881c1f60"), 50, new DateTime(2025, 10, 31, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7598), "Annual technology conference.", true, "Convention Hall", new Guid("970427a2-f8e8-4b3f-8f80-6ef23b443635"), "Tech Conference" },
                    { new Guid("08135a0e-e395-47f1-b3e1-65e93b42c721"), null, new DateTime(2025, 11, 3, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7715), "Monthly book club discussion.", false, "Library Private Room", new Guid("1a60ee7e-01a5-49a0-ad6f-0a356101ff6f"), "Book Club Meeting" },
                    { new Guid("1083361d-74af-422d-8f76-96b5de333422"), null, new DateTime(2025, 10, 27, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7623), "An exclusive dinner party for close friends.", false, "Home", new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"), "Private Dinner Party" },
                    { new Guid("15ef6d7d-07c1-458e-9a2b-507ceda36e39"), 30, new DateTime(2025, 11, 13, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7720), "Private investment strategy seminar.", false, "Financial Center", new Guid("970427a2-f8e8-4b3f-8f80-6ef23b443635"), "Investment Seminar" },
                    { new Guid("2b69b5ad-d319-4276-aa1b-d31028f1feff"), 20, new DateTime(2025, 11, 6, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7770), "Secret birthday celebration.", false, "Friend's House", new Guid("1a60ee7e-01a5-49a0-ad6f-0a356101ff6f"), "Birthday Surprise Party" },
                    { new Guid("2c75cd8c-7d1f-430b-b7ef-c1877e79ee03"), null, new DateTime(2025, 12, 18, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7778), "Private weekend meditation and mindfulness retreat.", false, "Mountain Retreat Center", new Guid("970427a2-f8e8-4b3f-8f80-6ef23b443635"), "Meditation Retreat" },
                    { new Guid("38ed607a-e9a4-4103-ab96-2cf3c01900ca"), null, new DateTime(2025, 10, 27, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7762), "Showcase your talent at our weekly open mic.", true, "Jazz Club", new Guid("1a60ee7e-01a5-49a0-ad6f-0a356101ff6f"), "Open Mic Night" },
                    { new Guid("3a9a17c3-7c99-4743-9c2e-f28f79195b12"), 35, new DateTime(2025, 12, 13, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7759), "Celebrating 25 years together with close family.", false, "Garden Venue", new Guid("970427a2-f8e8-4b3f-8f80-6ef23b443635"), "Wedding Anniversary" },
                    { new Guid("3c432d39-6e83-40cc-b7ad-9cccb3ab374c"), 25, new DateTime(2025, 10, 28, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7757), "Learn salsa dancing from scratch.", true, "Dance Studio", new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"), "Dance Class Beginner" },
                    { new Guid("3faa286f-7921-46c7-8752-64e535e1a5b0"), null, new DateTime(2025, 12, 8, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7724), "Open air music festival with multiple bands.", true, "Park Amphitheater", new Guid("1a60ee7e-01a5-49a0-ad6f-0a356101ff6f"), "Music Festival" },
                    { new Guid("42a5302b-0b3c-4074-ab75-9c7f5933823b"), 15, new DateTime(2025, 11, 5, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7717), "Learn to cook Italian cuisine.", true, "Culinary Institute", new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"), "Cooking Workshop" },
                    { new Guid("4d1bd7bd-0155-4ce8-921b-c32f690c57d8"), null, new DateTime(2025, 10, 30, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7740), "Intimate poetry reading and discussion.", false, "Cozy Bookshop", new Guid("970427a2-f8e8-4b3f-8f80-6ef23b443635"), "Poetry Reading Circle" },
                    { new Guid("50c6cff8-1c29-43f4-b39a-6c29285c9f3d"), 100, new DateTime(2025, 11, 28, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7742), "Learn about blockchain technology and cryptocurrency.", true, "Tech Hub", new Guid("1a60ee7e-01a5-49a0-ad6f-0a356101ff6f"), "Blockchain Summit" },
                    { new Guid("55f4780d-60c4-41f8-96bd-14a899b8ed6d"), 20, new DateTime(2025, 10, 26, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7660), "Morning yoga session for all levels.", true, "Wellness Center", new Guid("1a60ee7e-01a5-49a0-ad6f-0a356101ff6f"), "Yoga Class" },
                    { new Guid("5a9b8b61-cce5-4b1f-ae04-5a4258bef4b6"), null, new DateTime(2025, 11, 15, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7754), "Private launch event for new product line.", false, "Luxury Hotel Ballroom", new Guid("1a60ee7e-01a5-49a0-ad6f-0a356101ff6f"), "Exclusive Product Launch" },
                    { new Guid("5fa6e1e2-8da2-4934-ad96-99135d4cb5cf"), null, new DateTime(2025, 11, 7, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7619), "A workshop for art enthusiasts.", true, "Art Studio", new Guid("1a60ee7e-01a5-49a0-ad6f-0a356101ff6f"), "Art Workshop" },
                    { new Guid("6199c1cc-a926-4aaf-acda-37a1e2dcf462"), null, new DateTime(2025, 12, 23, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7711), "Annual city-wide marathon event.", true, "City Streets", new Guid("970427a2-f8e8-4b3f-8f80-6ef23b443635"), "City Marathon" },
                    { new Guid("65b334c7-20be-4c4e-adbc-e8d15bba901c"), 40, new DateTime(2025, 11, 11, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7734), "Private team building activities.", false, "Adventure Park", new Guid("1a60ee7e-01a5-49a0-ad6f-0a356101ff6f"), "Corporate Team Building" },
                    { new Guid("65d7b78f-626e-4d21-83a7-53902ca0f671"), 25, new DateTime(2025, 11, 23, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7663), "Annual family gathering.", false, "Family Home", new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"), "Family Reunion" },
                    { new Guid("8cee860b-00a0-4135-ab15-91791ceaf03f"), null, new DateTime(2025, 11, 1, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7728), "Exclusive wine tasting for connoisseurs.", false, "Private Wine Cellar", new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"), "Wine Tasting Evening" },
                    { new Guid("94975050-c7ed-47f2-94ed-6aff44b6b855"), 12, new DateTime(2025, 11, 8, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7731), "Professional photography workshop.", true, "Photography Studio", new Guid("970427a2-f8e8-4b3f-8f80-6ef23b443635"), "Photography Masterclass" },
                    { new Guid("95130403-cc55-4ad0-9ed1-551e384b43c8"), 8, new DateTime(2025, 10, 29, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7635), "Private board game session.", false, "Game Cafe", new Guid("970427a2-f8e8-4b3f-8f80-6ef23b443635"), "Board Game Night" },
                    { new Guid("a164386e-5195-4999-9469-4b2c206bb12b"), null, new DateTime(2025, 10, 25, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(932), "A meetup for community members.", true, "Community Center", new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"), "Community Meetup" },
                    { new Guid("b848f0cb-5532-4522-93b4-39812aa4c9ba"), 15, new DateTime(2025, 11, 2, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7746), "Private celebration for the groom-to-be.", false, "Resort", new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"), "Bachelor Party" },
                    { new Guid("bc596c43-46a0-4070-8418-2786848a24ac"), null, new DateTime(2025, 12, 3, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7749), "Community charity walk for local hospital.", true, "City Park Trail", new Guid("970427a2-f8e8-4b3f-8f80-6ef23b443635"), "Charity Walk" },
                    { new Guid("c187e77c-1079-43b9-a57e-3f6a2dc155df"), 200, new DateTime(2025, 11, 21, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7768), "Annual science fair for students and enthusiasts.", true, "Science Museum", new Guid("970427a2-f8e8-4b3f-8f80-6ef23b443635"), "Science Fair" },
                    { new Guid("c3edb965-429a-4cdb-95ff-3bea931ab589"), 500, new DateTime(2025, 11, 10, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7805), "Connect with top employers in the region.", true, "Convention Center", new Guid("1a60ee7e-01a5-49a0-ad6f-0a356101ff6f"), "Job Fair" },
                    { new Guid("d1dfed48-5cf2-4be0-9999-f2aea14b6d68"), null, new DateTime(2025, 11, 4, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7765), "Quarterly business strategy meeting.", false, "Conference Room A", new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"), "Strategy Planning Session" },
                    { new Guid("d6af4d6f-80e6-4892-9513-f6fe1c2e2b76"), null, new DateTime(2025, 11, 14, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7774), "Independent film screening and Q&A.", true, "Indie Cinema", new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"), "Film Screening" },
                    { new Guid("ddf18263-d0c8-47e1-9305-929dffa78c60"), null, new DateTime(2025, 11, 18, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7737), "Explore diverse street food from around the world.", true, "Downtown Plaza", new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"), "Street Food Festival" },
                    { new Guid("f9625c06-96a5-420c-b6ab-d267ef45c9a3"), 50, new DateTime(2026, 1, 2, 9, 28, 37, 107, DateTimeKind.Utc).AddTicks(7809), "Private reunion for class of 2010.", false, "University Hall", new Guid("6b1a61c0-3478-49f5-81c2-8700d3e16242"), "Alumni Gathering" }
                });

            migrationBuilder.InsertData(
                table: "EventTags",
                columns: new[] { "EventId", "TagId", "Id" },
                values: new object[,]
                {
                    { new Guid("066f6038-e920-4885-8186-67ae881c1f60"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31"), new Guid("398c3da3-0f74-4eae-a134-50d2188f8456") },
                    { new Guid("066f6038-e920-4885-8186-67ae881c1f60"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("5b0b663e-835e-4105-91c7-4e5d60f371af") },
                    { new Guid("066f6038-e920-4885-8186-67ae881c1f60"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("041f6a2c-d4a4-4e45-8702-1dbf6f0ca902") },
                    { new Guid("066f6038-e920-4885-8186-67ae881c1f60"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("96ad7a9a-d389-4e1b-aef1-02a4fa9bd4b0") },
                    { new Guid("08135a0e-e395-47f1-b3e1-65e93b42c721"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6"), new Guid("d1356d2d-1ba2-4821-aa59-5abfd96eb527") },
                    { new Guid("08135a0e-e395-47f1-b3e1-65e93b42c721"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("50593eda-9f3d-437d-a521-d85790334cd8") },
                    { new Guid("08135a0e-e395-47f1-b3e1-65e93b42c721"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("7cdec4c8-1f7c-47f9-a402-3f2fcb9e565e") },
                    { new Guid("1083361d-74af-422d-8f76-96b5de333422"), new Guid("0d2425e8-6548-469e-a581-598a65336047"), new Guid("bcc028b5-d08b-4f8c-a811-13fdc4341945") },
                    { new Guid("1083361d-74af-422d-8f76-96b5de333422"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("1585f821-8803-4c80-9223-e8d8723d0dbb") },
                    { new Guid("1083361d-74af-422d-8f76-96b5de333422"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("dd387f86-b970-4551-9dbf-91ad3f6c8388") },
                    { new Guid("15ef6d7d-07c1-458e-9a2b-507ceda36e39"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31"), new Guid("0a9473b7-99ef-4101-8777-7f83d0c9da27") },
                    { new Guid("15ef6d7d-07c1-458e-9a2b-507ceda36e39"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("7622ecc3-0e19-4f1d-83ac-3a0fde6b4311") },
                    { new Guid("15ef6d7d-07c1-458e-9a2b-507ceda36e39"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("a468f09d-3a49-4488-97ff-979e485c5417") },
                    { new Guid("15ef6d7d-07c1-458e-9a2b-507ceda36e39"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("04ac4bdf-e204-4062-b198-96069356d93e") },
                    { new Guid("2b69b5ad-d319-4276-aa1b-d31028f1feff"), new Guid("0d2425e8-6548-469e-a581-598a65336047"), new Guid("d1d91cbc-e071-43ce-83a3-2da3ac19f74a") },
                    { new Guid("2b69b5ad-d319-4276-aa1b-d31028f1feff"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d"), new Guid("131a1534-0eca-4d72-a5de-4803e1645fca") },
                    { new Guid("2b69b5ad-d319-4276-aa1b-d31028f1feff"), new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d"), new Guid("a6c2459b-37f2-41ee-a007-0cf8ee9896b1") },
                    { new Guid("2c75cd8c-7d1f-430b-b7ef-c1877e79ee03"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6"), new Guid("690b6582-6311-4fd4-8f90-cf72763057b4") },
                    { new Guid("2c75cd8c-7d1f-430b-b7ef-c1877e79ee03"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d"), new Guid("b7babf30-5781-44b6-8240-4315747626f1") },
                    { new Guid("2c75cd8c-7d1f-430b-b7ef-c1877e79ee03"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("caef7031-6928-4f5c-b443-930d13f4a3cc") },
                    { new Guid("2c75cd8c-7d1f-430b-b7ef-c1877e79ee03"), new Guid("b289c6e5-ea00-4666-9e87-50720a94a2fe"), new Guid("6ae75659-2689-44df-808d-bb84f5c40163") },
                    { new Guid("38ed607a-e9a4-4103-ab96-2cf3c01900ca"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("349664b0-6ec7-45d2-b2fb-c92b31c9557c") },
                    { new Guid("38ed607a-e9a4-4103-ab96-2cf3c01900ca"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("ce4e0d11-fc4f-40d2-ab39-1dd79ae0b7b5") },
                    { new Guid("38ed607a-e9a4-4103-ab96-2cf3c01900ca"), new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d"), new Guid("07030452-fa02-4ae1-8708-986f8c226792") },
                    { new Guid("38ed607a-e9a4-4103-ab96-2cf3c01900ca"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb"), new Guid("53816e70-698f-41de-ae17-0ac6a7f2255f") },
                    { new Guid("3a9a17c3-7c99-4743-9c2e-f28f79195b12"), new Guid("0d2425e8-6548-469e-a581-598a65336047"), new Guid("4d398043-a7fb-46c9-902b-bddf8b65e0c7") },
                    { new Guid("3a9a17c3-7c99-4743-9c2e-f28f79195b12"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d"), new Guid("06a4f4de-95f9-455e-b0ae-0ea172a6cf92") },
                    { new Guid("3a9a17c3-7c99-4743-9c2e-f28f79195b12"), new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d"), new Guid("260e2e97-8e62-4e8b-aa3a-fe3674b38fb0") },
                    { new Guid("3c432d39-6e83-40cc-b7ad-9cccb3ab374c"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6"), new Guid("eabeda31-a329-48f6-887b-b2c4c6bb884b") },
                    { new Guid("3c432d39-6e83-40cc-b7ad-9cccb3ab374c"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("58e4289d-924e-4aa5-8c2d-9fba670a90d9") },
                    { new Guid("3c432d39-6e83-40cc-b7ad-9cccb3ab374c"), new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d"), new Guid("5b5fcc57-1d58-4df3-8476-ce7edea3b56e") },
                    { new Guid("3c432d39-6e83-40cc-b7ad-9cccb3ab374c"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb"), new Guid("bc880d3b-c0ee-42ea-bfd1-487dd91432da") },
                    { new Guid("3faa286f-7921-46c7-8752-64e535e1a5b0"), new Guid("0d2425e8-6548-469e-a581-598a65336047"), new Guid("68fdc1ce-8382-4321-8930-21146a3e41ad") },
                    { new Guid("3faa286f-7921-46c7-8752-64e535e1a5b0"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("5ceca2a2-35bd-4835-a407-a3dbfa49070a") },
                    { new Guid("3faa286f-7921-46c7-8752-64e535e1a5b0"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d"), new Guid("72ee4044-c060-4249-aa8b-05bae2bb8906") },
                    { new Guid("3faa286f-7921-46c7-8752-64e535e1a5b0"), new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d"), new Guid("18543483-e156-4d5f-9da0-04dd649fb08a") },
                    { new Guid("3faa286f-7921-46c7-8752-64e535e1a5b0"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb"), new Guid("efe3b8f0-a152-443d-8fd0-c787378053b5") },
                    { new Guid("42a5302b-0b3c-4074-ab75-9c7f5933823b"), new Guid("0d2425e8-6548-469e-a581-598a65336047"), new Guid("44ca58a7-e6df-40cc-82f1-d2edc4a5e394") },
                    { new Guid("42a5302b-0b3c-4074-ab75-9c7f5933823b"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31"), new Guid("930675b8-5a5e-42e2-8713-b598950dbed6") },
                    { new Guid("42a5302b-0b3c-4074-ab75-9c7f5933823b"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("ff6eb810-1015-432b-a157-4b8f2bbd37e3") },
                    { new Guid("42a5302b-0b3c-4074-ab75-9c7f5933823b"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("211c3faf-c750-4fc7-ad60-5ab9fdf1b57a") },
                    { new Guid("4d1bd7bd-0155-4ce8-921b-c32f690c57d8"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d"), new Guid("edc13a09-8779-4b97-a322-1f07abccb2d7") },
                    { new Guid("4d1bd7bd-0155-4ce8-921b-c32f690c57d8"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("0fb02fad-e7a6-427d-959c-131bd6147638") },
                    { new Guid("4d1bd7bd-0155-4ce8-921b-c32f690c57d8"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb"), new Guid("9ca8d024-55fb-4e55-b561-230ba47839f6") },
                    { new Guid("50c6cff8-1c29-43f4-b39a-6c29285c9f3d"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31"), new Guid("a62268f9-ce40-4410-8fef-c4bca7554ca2") },
                    { new Guid("50c6cff8-1c29-43f4-b39a-6c29285c9f3d"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6"), new Guid("7e068c47-e284-43d6-a30d-44dc9ce1eee5") },
                    { new Guid("50c6cff8-1c29-43f4-b39a-6c29285c9f3d"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("ff65fc9f-1689-4c1d-bcd8-b2f56ec2666c") },
                    { new Guid("50c6cff8-1c29-43f4-b39a-6c29285c9f3d"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("648107a6-6e8e-4698-9690-035ec6027efc") },
                    { new Guid("50c6cff8-1c29-43f4-b39a-6c29285c9f3d"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("2277c9a2-2d6f-4e30-8807-393f25e3777e") },
                    { new Guid("55f4780d-60c4-41f8-96bd-14a899b8ed6d"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6"), new Guid("cb4e37e2-b087-4ec6-a0b2-fe6f2c0c70c6") },
                    { new Guid("55f4780d-60c4-41f8-96bd-14a899b8ed6d"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("4e3ea5ef-69ce-4c60-a77b-b63bb7faeb4d") },
                    { new Guid("55f4780d-60c4-41f8-96bd-14a899b8ed6d"), new Guid("939a6e9f-5623-4263-9861-4ea02bbc238d"), new Guid("ce797dc4-1aeb-4e9d-89d3-1c981a315073") },
                    { new Guid("5a9b8b61-cce5-4b1f-ae04-5a4258bef4b6"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31"), new Guid("15c0a463-6254-4ec8-af4f-d0fe71f8eed2") },
                    { new Guid("5a9b8b61-cce5-4b1f-ae04-5a4258bef4b6"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("bee19f9f-8a18-4273-a3e5-a4755dbddb16") },
                    { new Guid("5a9b8b61-cce5-4b1f-ae04-5a4258bef4b6"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("03025194-6eda-4471-b0bb-ea645a84ad00") },
                    { new Guid("5a9b8b61-cce5-4b1f-ae04-5a4258bef4b6"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb"), new Guid("da63a14c-3230-472c-8bc7-b09e7904cbbd") },
                    { new Guid("5fa6e1e2-8da2-4934-ad96-99135d4cb5cf"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("26b514f1-bcea-4c35-80c6-c70074d2ce5f") },
                    { new Guid("5fa6e1e2-8da2-4934-ad96-99135d4cb5cf"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("c2238224-5ec3-4790-bf14-5c963c61831d") },
                    { new Guid("5fa6e1e2-8da2-4934-ad96-99135d4cb5cf"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb"), new Guid("026e7d94-7e29-478c-b10f-c22f841e6da2") },
                    { new Guid("6199c1cc-a926-4aaf-acda-37a1e2dcf462"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6"), new Guid("dea341ab-a640-4a50-8a10-e2993cb9291e") },
                    { new Guid("6199c1cc-a926-4aaf-acda-37a1e2dcf462"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("f47dd1ed-2194-4e20-9e8b-ee69b7b72d96") },
                    { new Guid("6199c1cc-a926-4aaf-acda-37a1e2dcf462"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d"), new Guid("66e9e4cc-608b-43d9-9f50-b1df2b4dab76") },
                    { new Guid("6199c1cc-a926-4aaf-acda-37a1e2dcf462"), new Guid("b289c6e5-ea00-4666-9e87-50720a94a2fe"), new Guid("7a87ca6f-fb4f-45eb-af89-bf8840f789af") },
                    { new Guid("65b334c7-20be-4c4e-adbc-e8d15bba901c"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6"), new Guid("f67961b0-dfd8-4d9d-8c49-cc82841a1b20") },
                    { new Guid("65b334c7-20be-4c4e-adbc-e8d15bba901c"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("818ab4be-14e2-4117-83b8-a14e023dd0a3") },
                    { new Guid("65b334c7-20be-4c4e-adbc-e8d15bba901c"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("3a2a52b2-311e-40c0-a457-ec678d6b6ff9") },
                    { new Guid("65b334c7-20be-4c4e-adbc-e8d15bba901c"), new Guid("b289c6e5-ea00-4666-9e87-50720a94a2fe"), new Guid("ee3a1c28-410a-48c4-bbdb-bc4b080586f0") },
                    { new Guid("65d7b78f-626e-4d21-83a7-53902ca0f671"), new Guid("0d2425e8-6548-469e-a581-598a65336047"), new Guid("7637872c-62aa-4770-bdec-5a74bce5e1e7") },
                    { new Guid("65d7b78f-626e-4d21-83a7-53902ca0f671"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("c96260f7-4a81-4de4-b59f-4c4a1145c161") },
                    { new Guid("65d7b78f-626e-4d21-83a7-53902ca0f671"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d"), new Guid("1bb96de4-5470-41c0-a7d9-0ea824c8895a") },
                    { new Guid("8cee860b-00a0-4135-ab15-91791ceaf03f"), new Guid("0d2425e8-6548-469e-a581-598a65336047"), new Guid("a8111b50-c723-44f6-9bf0-3e81abb9edc8") },
                    { new Guid("8cee860b-00a0-4135-ab15-91791ceaf03f"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("c404664d-a341-4a0c-9a77-ab9816ba8a11") },
                    { new Guid("8cee860b-00a0-4135-ab15-91791ceaf03f"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("7f0a4701-b760-46c9-981c-236fdfd9b9c3") },
                    { new Guid("94975050-c7ed-47f2-94ed-6aff44b6b855"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31"), new Guid("ca2f1cbb-65b0-4dfe-bd57-d030c0bef28e") },
                    { new Guid("94975050-c7ed-47f2-94ed-6aff44b6b855"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("5417f3e7-ab3c-42bb-b0fd-793a0f359867") },
                    { new Guid("94975050-c7ed-47f2-94ed-6aff44b6b855"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("12c16f11-6b47-4874-b1d4-5de804d58e01") },
                    { new Guid("94975050-c7ed-47f2-94ed-6aff44b6b855"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb"), new Guid("aacc028b-9d47-4c69-9c31-0a8caf1d87cd") },
                    { new Guid("95130403-cc55-4ad0-9ed1-551e384b43c8"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("1d74237c-59e5-4110-a4f2-b6c7bdb0f12a") },
                    { new Guid("95130403-cc55-4ad0-9ed1-551e384b43c8"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("3372cf3b-5dc3-4123-8290-c75e6347e41a") },
                    { new Guid("a164386e-5195-4999-9469-4b2c206bb12b"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("8f2df889-c180-44e8-a727-6e5401b5ce90") },
                    { new Guid("a164386e-5195-4999-9469-4b2c206bb12b"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("b283fda1-c164-4f57-9525-78cfedc8ac39") },
                    { new Guid("a164386e-5195-4999-9469-4b2c206bb12b"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("f3f14426-50bf-4bc5-a78d-bfc06b43cdac") },
                    { new Guid("b848f0cb-5532-4522-93b4-39812aa4c9ba"), new Guid("0d2425e8-6548-469e-a581-598a65336047"), new Guid("4f70d996-147c-4c67-a2bf-db9af1eb444c") },
                    { new Guid("b848f0cb-5532-4522-93b4-39812aa4c9ba"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31"), new Guid("4e841c1c-9fd5-4f71-a3e6-3425fc76f3be") },
                    { new Guid("b848f0cb-5532-4522-93b4-39812aa4c9ba"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d"), new Guid("0582c822-9176-41bf-b66e-e3df1aec0994") },
                    { new Guid("b848f0cb-5532-4522-93b4-39812aa4c9ba"), new Guid("b289c6e5-ea00-4666-9e87-50720a94a2fe"), new Guid("dbe9c5d7-1757-4b31-bd09-5749470e6600") },
                    { new Guid("bc596c43-46a0-4070-8418-2786848a24ac"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6"), new Guid("7e3c68ac-d0ab-4179-9922-19e5cd4c9c31") },
                    { new Guid("bc596c43-46a0-4070-8418-2786848a24ac"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("11ae5dd8-f58a-424b-a522-9b067a7ae9ea") },
                    { new Guid("bc596c43-46a0-4070-8418-2786848a24ac"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("e1c668db-6f37-410c-bac4-78f354de5ec8") },
                    { new Guid("bc596c43-46a0-4070-8418-2786848a24ac"), new Guid("b289c6e5-ea00-4666-9e87-50720a94a2fe"), new Guid("c5acdc1b-bc7e-49fa-82b7-fd11d93fa4ff") },
                    { new Guid("c187e77c-1079-43b9-a57e-3f6a2dc155df"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31"), new Guid("c72b6f58-b712-4e6c-b82e-477b0f10979c") },
                    { new Guid("c187e77c-1079-43b9-a57e-3f6a2dc155df"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("12c36a82-3628-422e-9462-76c38c6fc13e") },
                    { new Guid("c187e77c-1079-43b9-a57e-3f6a2dc155df"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("2552d54c-dbdb-4457-97ee-f002779b8f97") },
                    { new Guid("c187e77c-1079-43b9-a57e-3f6a2dc155df"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb"), new Guid("f0f0b93c-7b55-4623-875c-d4ab925d6439") },
                    { new Guid("c3edb965-429a-4cdb-95ff-3bea931ab589"), new Guid("148fd4b3-6fa8-4bec-94e2-0c3324228d31"), new Guid("0488c32b-e5ea-4e10-950e-690184d4e07f") },
                    { new Guid("c3edb965-429a-4cdb-95ff-3bea931ab589"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("e3f96e1e-22eb-4b7f-80f9-af87adc283b2") },
                    { new Guid("c3edb965-429a-4cdb-95ff-3bea931ab589"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("464cdfd2-2ced-4968-ae97-2f15caa8f2b5") },
                    { new Guid("c3edb965-429a-4cdb-95ff-3bea931ab589"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("fe88f19a-c3e7-498b-b12d-fd6e88ee8a0d") },
                    { new Guid("d1dfed48-5cf2-4be0-9999-f2aea14b6d68"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("3d0142b0-39e7-4e64-9069-5d1979433e3a") },
                    { new Guid("d1dfed48-5cf2-4be0-9999-f2aea14b6d68"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("675e8671-f3b0-4f21-904b-a9bc5a521dab") },
                    { new Guid("d1dfed48-5cf2-4be0-9999-f2aea14b6d68"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("4d53b16f-c580-4598-8d03-fb821688c303") },
                    { new Guid("d6af4d6f-80e6-4892-9513-f6fe1c2e2b76"), new Guid("20e96d1f-0434-4b80-b84b-56da7777d7c6"), new Guid("956aefe3-801c-4c7a-9329-26b9b7f1947c") },
                    { new Guid("d6af4d6f-80e6-4892-9513-f6fe1c2e2b76"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("20214e33-5568-4cf2-93ca-632dcfa9cf3c") },
                    { new Guid("d6af4d6f-80e6-4892-9513-f6fe1c2e2b76"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("d003dcd9-dbb0-4984-b25f-3eb71543766f") },
                    { new Guid("d6af4d6f-80e6-4892-9513-f6fe1c2e2b76"), new Guid("c9359f9c-fb39-4887-8e20-c6af7e8aa5cb"), new Guid("e41d07dc-ebf9-488a-b2f5-efdc79783d87") },
                    { new Guid("ddf18263-d0c8-47e1-9305-929dffa78c60"), new Guid("0d2425e8-6548-469e-a581-598a65336047"), new Guid("97ab0944-3c21-4730-869c-4c30b04eb8c9") },
                    { new Guid("ddf18263-d0c8-47e1-9305-929dffa78c60"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("99f5bc92-e5f7-4c38-90b6-0d02ccc5c4d8") },
                    { new Guid("ddf18263-d0c8-47e1-9305-929dffa78c60"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d"), new Guid("53a88253-fb0b-4c22-8506-971035961b98") },
                    { new Guid("ddf18263-d0c8-47e1-9305-929dffa78c60"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("cc02b13a-dcaa-4166-8de8-d75292b04ef3") },
                    { new Guid("f9625c06-96a5-420c-b6ab-d267ef45c9a3"), new Guid("42468792-408c-40e6-b488-c0a87408fbb7"), new Guid("4475b1b8-2d87-40dc-943a-f40191356c62") },
                    { new Guid("f9625c06-96a5-420c-b6ab-d267ef45c9a3"), new Guid("5f2e6e37-aff2-4c71-a666-0ea6e8d72db9"), new Guid("0cfa3ac6-b82d-40b1-81af-dd1e7755cc29") },
                    { new Guid("f9625c06-96a5-420c-b6ab-d267ef45c9a3"), new Guid("787fa4db-6546-40a3-90bb-343b2b5cc54d"), new Guid("dacbd1df-832f-4812-898e-93eaaf5e7178") },
                    { new Guid("f9625c06-96a5-420c-b6ab-d267ef45c9a3"), new Guid("86f5b247-a4d0-45ea-8a64-b46a91ef8bfe"), new Guid("2c5effed-de2e-4ef7-924e-7fdcbb1bc628") }
                });
        }
    }
}
