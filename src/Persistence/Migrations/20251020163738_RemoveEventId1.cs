using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveEventId1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventParticipants_Events_EventId1",
                table: "EventParticipants");

            migrationBuilder.DropIndex(
                name: "IX_EventParticipants_EventId1",
                table: "EventParticipants");

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("02319015-ce5b-4a96-b0da-697424210a62"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("0394507a-980a-43b8-9dd7-6f5c87fffaa1"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("054878d3-6e9b-4312-bfd0-6de5712a7a18"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("055b9a80-39d1-4d47-9288-91db52ad40c8"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("0aabc434-6679-47c4-a1c8-30ec2c95e455"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("0cbb463e-8641-416e-917a-dd246e0919fc"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("1047f2f0-a83d-4b9d-9417-3c42882617ae"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("11871be9-92bc-44b6-9ad8-a73d56f7a270"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("12c78b0b-350f-4b43-bc6a-6a6f74367b28"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("156b0b66-a677-4711-b9ff-18b55a2f26e2"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("2189d742-bf6e-4934-9477-c5a2e2fcb9aa"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("2740cb7f-67d6-496c-ae8b-40eb129983a3"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("2b0a9746-77c4-4628-bbd8-9a6ca2184421"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("30995362-cb04-4e90-b8f1-0551a3643fad"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("30c546b4-3aa4-413c-ad20-fa7995f58204"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("32d3f4c5-cc1b-4735-9de2-33d15f21f57e"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("367ebccd-51d2-4e4c-b3ea-91cc11b6b9b2"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("38b5756e-ef36-4469-9f29-c80b609c2f12"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("39bfab60-d6e9-469f-9f16-05f3b259991c"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("3a9ede9e-d039-49f9-815b-39e78b2a2eea"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("3ba4b10a-bf6a-4a6f-b123-8594b7150f1f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("3ccfc262-27d7-48d1-9cc9-77ba2f8107a2"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("3cd42438-6c4c-4cc3-8996-1dd612d84a0e"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("405b89ad-4209-4c35-aea0-998e76998ec4"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("41e4d341-dc8b-443b-93de-572686c0ded0"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("449a0345-be8a-4e38-9000-8dc235eae561"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("44bc2eaf-64c3-4ee1-a831-d4928deb7b55"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("4858bf43-1460-466c-984b-6ce5722406aa"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("4891b81b-e1a7-4c0f-b8d8-22816b5526e8"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("4a3fddf5-ab7d-4804-8aea-1f8e0403d4d5"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("4a539104-647a-47b9-882d-6e23da3c89a1"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("5051869b-1a99-4427-979e-aa5e110598b4"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("5270716f-930b-4cbe-8e4b-a8ae81a9439f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("5417a803-b2c1-4823-b08a-ba7a11b952a6"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("55244de2-ca4d-4503-b913-f4c672e018a7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("555d7f4f-5e61-4709-804d-bad32d2653df"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("56412e32-cd2c-42be-a92e-cfbc3da7b035"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("57dcaf9c-0e45-4f1d-8216-536aa65ca5ac"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("59e4743e-26ee-453f-a6bb-02d442c35be2"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("5f8d1844-4fd9-41d2-8204-2f9f49130218"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("6079475a-f4ef-4aa4-bda0-1d5509f18ae3"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("61494a35-26ad-4add-a8c3-76a55e5dcf64"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("64625196-f130-48e9-9098-dcc0e2c0444e"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("68b1a4eb-dafc-43bc-9caa-b73839a8099b"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("6df3109e-e47c-4f59-bcfc-49b399459d8d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("6e09214b-cb58-4251-8e11-775d6a60c106"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("6e375e58-9a07-452a-bfd3-96be1cc8bb95"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("71bf4aff-6bf0-4824-9878-21ce8d115c9f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("72bcf2a2-0b55-49a6-bf32-6713495b2be9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("758ff923-edb4-4a80-af75-d84c0a3761e3"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("7c7e145f-e5a1-4892-94bd-23a93310d38d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("7dc117e1-9f66-41ad-b3b0-8a20295a9d9d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("828fe674-103b-4463-9169-f9dd73aa51d9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("83520fd6-d45e-4da6-a481-56e0a386acfe"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("84226374-533f-4028-909c-687f58c9753a"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("8432c00a-693c-4bea-8615-966055fe8749"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("85671f3f-a9ff-4966-ae89-e91c76fdb8d7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("881451d8-eac6-487d-8acf-ab8c1205547f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("883b1a33-2b61-43e9-8409-391311cef80a"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("891d73a1-38ab-42e7-8d2f-f8926841c2a1"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("899f0ae4-d09d-4c8f-bb96-86051269a1e7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("91c9854c-34eb-4094-afc7-84d1193816d5"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("92077a22-4bae-4d01-8cb0-0154e89d5d82"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("958f3ab1-83dd-4cb4-97ab-322bf8345452"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("960ef1cb-8600-42ed-8518-5d29ca3896bf"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("9dcc1724-de84-4405-9c83-72fc4d1aaad0"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("a1ce9857-49dc-4999-80ce-11ab54937ff1"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("a2aba7bf-0c05-4fae-9aeb-f4a8f58b9968"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("a3884dd4-4262-4e15-a55c-ef10586df099"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("a90fc315-648d-4e30-9cb1-b3bfba096436"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("a9cc9a10-e606-4907-acdc-5c3f8e946566"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ab45bef3-dfaa-4a25-8b05-b404eae9f3b0"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ab8656c9-d533-4626-b994-3dd6fcb87c39"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ada4cc12-0e47-4cdd-b529-14fae9f54c49"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ae80eadb-7acb-4189-82ee-c4759c0cb3c6"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("af8165b5-0316-465b-a8fc-ef83ff2fe8f7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("b97e0c4d-0094-43ba-adf4-75061b8f5d77"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ba23dcba-9d9c-4143-ba7f-5b40995d51b7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("bc06a49b-4621-4829-a718-cc9356a192f6"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("befcac07-c759-499c-bc0e-e3b4f0c30198"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c1e982ec-a37f-4b69-85d2-8c3399ddc76c"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c40f29ba-2b16-4823-a941-a2cea3415da9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c4423572-fd76-45b6-8f0f-ed45a9dcba16"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c6f5f166-090f-4dc1-87b1-bae870909df7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c70b1b83-4187-4b79-a75e-656c5ac3143f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ca12990c-a2ba-4e6d-9d5d-42cdd9198e9f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("cfa6598a-4c7e-4983-b43d-20119a953db0"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d0adfdd2-ab86-4007-8cb9-40843592258c"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d28b5083-31e2-449d-b1ee-37a31413245e"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d2e27f8a-a681-49c3-b2a0-babbc4096f17"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d43f674a-ea92-4aba-bc09-a927d5c1bf8d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d52b1c9d-eb81-4cd2-9ebf-2e1a3b349332"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d5396665-2af9-4ddc-a587-8af37d98f27b"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d91e9e51-8f9c-4e9e-9a44-3ddd7b39fc0d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d98fad0d-e7e3-4ff2-ab6d-9abf4b614052"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("db5ed79f-5a8e-449c-bc82-350984aa90cf"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("dd993e6c-f763-4231-a061-66d1656fdc69"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("dfb56d9a-3fce-4c15-ac93-d0e6201c1b00"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("e2811cf7-acd9-452a-9b21-9f1278b582e9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("e697a966-ed8a-4cb7-88dd-f84a795b1682"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("e7adac48-fdbd-4c7a-a9a0-2fc16b02756b"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("eae3bd96-f5a7-4333-8955-845e2fcc91ed"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("f161de15-0590-4993-94e5-a07337149418"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("f5e6c64d-8722-4fee-9b74-2a5fad7c7f85"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("f79b901d-fdbe-46a0-82aa-7aa3343ba56d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("fa9af00d-f12c-4009-ac2c-7d7073f9b180"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("0397e27e-fb26-4b17-921e-d50489efcf99"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("05534e12-a419-4a80-9299-8677f17879dc"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("0f8e5c73-05d1-46c9-9b2d-e65aea98c80a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("202e3ac6-1d44-4154-803c-2a8b74742f7c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("207403de-e129-4985-b6e2-b4dba076be82"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("23c1e0ed-74ab-47ad-b2ed-9ecce8b99d97"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3aa1f8da-c834-4c99-9559-8d32db64e337"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3dd4a1ef-9eaf-46cd-93ab-efc323f7c114"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("417fed05-5862-48f7-ae02-179cc7c79c71"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("492f8a7d-abd8-4dda-9237-eb9eccfc6be5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("4d0043a3-b721-4d5e-ae48-330f64a37ea8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5fc8aa3e-4da7-4a26-a961-046cb3881f6d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("630e1c97-0e60-4b78-a321-cd25ce86e7e3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("69355c02-06d9-4c07-af4c-5e44e9f82282"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("7058015f-33ca-4da7-8b5d-a8d63dfd21b5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("7d595805-51f8-45f3-9652-d1b9336689f6"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("805fd53a-e4f4-47e3-8fe9-795bf5c50c3d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("83d8a607-feba-465a-ac42-5d031446225a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("8d1ae803-e6e8-417f-96b6-94a00fbbbd89"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("accb2146-ab97-4947-8c4f-00b65fdff3ce"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b7c0bdf9-4f4e-48e4-9525-5d4e99fef16d"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("ba91c424-b9d0-48ac-aceb-72d6438d1a28"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("ca0bfc7d-d69e-457e-a615-7bf76a7fe302"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("ce470e6d-3d74-4fac-b542-b21f9eb44186"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d5610a25-697b-4e79-8751-9c501c07c89b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("dd90b841-5d30-4235-a29c-046e8da496b1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e08e16b1-1a2d-4e4c-9b70-979d5cac1e6b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f0029ae0-3d6e-44f0-a000-59e9379d78c1"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f77b8c32-37d5-4259-9f5c-00242d6ed13a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("fc35537a-4342-4234-a4d4-76022157d207"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("fc4b234d-2b08-4106-9af9-4830406e713b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"));

            migrationBuilder.DropColumn(
                name: "EventId1",
                table: "EventParticipants");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("524d798e-f599-4594-9824-e75ec3d22229"), "jane.smith@example.com", "Jane", "Smith", "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue" },
                    { new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), "alice.johnson@example.com", "Alice", "Johnson", "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue" },
                    { new Guid("ef6765de-e98d-4896-939d-58a46be39203"), "john.doe@example.com", "John", "Doe", "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Capacity", "Date", "Description", "IsPublic", "Location", "OrganizerId", "Title" },
                values: new object[,]
                {
                    { new Guid("012740e4-3721-49ea-b91d-6b3bc0b8dc95"), 20, new DateTime(2025, 11, 2, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1458), "Secret birthday celebration.", false, "Friend's House", new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), "Birthday Surprise Party" },
                    { new Guid("0792ae44-85dc-4e58-97ef-39ebf3f34444"), 15, new DateTime(2025, 10, 29, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1415), "Private celebration for the groom-to-be.", false, "Resort", new Guid("ef6765de-e98d-4896-939d-58a46be39203"), "Bachelor Party" },
                    { new Guid("09189be9-c6ff-4f4c-9c6c-db8517d9530b"), null, new DateTime(2025, 10, 23, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1430), "Showcase your talent at our weekly open mic.", true, "Jazz Club", new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), "Open Mic Night" },
                    { new Guid("0b3441a6-b2b0-4e22-ac78-a93286c3ee08"), null, new DateTime(2025, 11, 14, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1407), "Explore diverse street food from around the world.", true, "Downtown Plaza", new Guid("ef6765de-e98d-4896-939d-58a46be39203"), "Street Food Festival" },
                    { new Guid("0b5063d3-cf21-4c5a-9c40-4f7418ff5948"), 200, new DateTime(2025, 11, 17, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1455), "Annual science fair for students and enthusiasts.", true, "Science Museum", new Guid("524d798e-f599-4594-9824-e75ec3d22229"), "Science Fair" },
                    { new Guid("0e5b218c-bca8-4989-8454-ed869ff1f951"), null, new DateTime(2025, 10, 31, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1433), "Quarterly business strategy meeting.", false, "Conference Room A", new Guid("ef6765de-e98d-4896-939d-58a46be39203"), "Strategy Planning Session" },
                    { new Guid("11d38f7b-5d07-45d4-a39f-545e382c63f7"), null, new DateTime(2025, 12, 4, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1393), "Open air music festival with multiple bands.", true, "Park Amphitheater", new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), "Music Festival" },
                    { new Guid("346809a6-4d97-48e3-ba23-6854ee999f94"), null, new DateTime(2025, 10, 28, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1397), "Exclusive wine tasting for connoisseurs.", false, "Private Wine Cellar", new Guid("ef6765de-e98d-4896-939d-58a46be39203"), "Wine Tasting Evening" },
                    { new Guid("3667ca74-37f6-45b4-b7ce-fe902c2b1b2c"), 12, new DateTime(2025, 11, 4, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1399), "Professional photography workshop.", true, "Photography Studio", new Guid("524d798e-f599-4594-9824-e75ec3d22229"), "Photography Masterclass" },
                    { new Guid("3f78e6a7-9fa3-4934-b9d3-54f7b0bdaff0"), null, new DateTime(2025, 10, 30, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1380), "Monthly book club discussion.", false, "Library Private Room", new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), "Book Club Meeting" },
                    { new Guid("45d0162b-5f24-4881-a2c5-0426608656b5"), null, new DateTime(2025, 12, 14, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1464), "Private weekend meditation and mindfulness retreat.", false, "Mountain Retreat Center", new Guid("524d798e-f599-4594-9824-e75ec3d22229"), "Meditation Retreat" },
                    { new Guid("556144b0-e80d-4608-9849-d0aaac573ecb"), 25, new DateTime(2025, 10, 24, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1423), "Learn salsa dancing from scratch.", true, "Dance Studio", new Guid("ef6765de-e98d-4896-939d-58a46be39203"), "Dance Class Beginner" },
                    { new Guid("5d00efb4-7e0f-4b5b-8895-32b2056de4c8"), 25, new DateTime(2025, 11, 19, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1363), "Annual family gathering.", false, "Family Home", new Guid("ef6765de-e98d-4896-939d-58a46be39203"), "Family Reunion" },
                    { new Guid("838a0093-0d94-43b6-8036-3c6f48eb3818"), null, new DateTime(2025, 10, 26, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1409), "Intimate poetry reading and discussion.", false, "Cozy Bookshop", new Guid("524d798e-f599-4594-9824-e75ec3d22229"), "Poetry Reading Circle" },
                    { new Guid("9d1fcacd-47ce-4bbf-b692-785e84451c5e"), 50, new DateTime(2025, 12, 29, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1471), "Private reunion for class of 2010.", false, "University Hall", new Guid("ef6765de-e98d-4896-939d-58a46be39203"), "Alumni Gathering" },
                    { new Guid("a8e253b6-ec75-4f46-ac7d-b365afcd5e22"), null, new DateTime(2025, 11, 11, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1420), "Private launch event for new product line.", false, "Luxury Hotel Ballroom", new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), "Exclusive Product Launch" },
                    { new Guid("ab531bc9-33db-49e4-8e93-d89f1962e5a8"), 50, new DateTime(2025, 10, 27, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1282), "Annual technology conference.", true, "Convention Hall", new Guid("524d798e-f599-4594-9824-e75ec3d22229"), "Tech Conference" },
                    { new Guid("b0f8fd5f-9535-44eb-9814-31c8b060a928"), null, new DateTime(2025, 11, 29, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1417), "Community charity walk for local hospital.", true, "City Park Trail", new Guid("524d798e-f599-4594-9824-e75ec3d22229"), "Charity Walk" },
                    { new Guid("b2dd7112-93f2-4246-a34d-974bade50a76"), null, new DateTime(2025, 10, 21, 16, 37, 37, 373, DateTimeKind.Utc).AddTicks(4286), "A meetup for community members.", true, "Community Center", new Guid("ef6765de-e98d-4896-939d-58a46be39203"), "Community Meetup" },
                    { new Guid("c58dda12-1562-4a73-bd57-02ff9f1b3e57"), 35, new DateTime(2025, 12, 9, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1427), "Celebrating 25 years together with close family.", false, "Garden Venue", new Guid("524d798e-f599-4594-9824-e75ec3d22229"), "Wedding Anniversary" },
                    { new Guid("c6ac8b54-5627-44a7-9a3a-960f2573ec7a"), 30, new DateTime(2025, 11, 9, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1386), "Private investment strategy seminar.", false, "Financial Center", new Guid("524d798e-f599-4594-9824-e75ec3d22229"), "Investment Seminar" },
                    { new Guid("c811e049-c654-478b-a6f6-b736a1237024"), 15, new DateTime(2025, 11, 1, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1383), "Learn to cook Italian cuisine.", true, "Culinary Institute", new Guid("ef6765de-e98d-4896-939d-58a46be39203"), "Cooking Workshop" },
                    { new Guid("c9ae2a15-74c4-4c45-b9ee-4460881e7480"), 40, new DateTime(2025, 11, 7, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1404), "Private team building activities.", false, "Adventure Park", new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), "Corporate Team Building" },
                    { new Guid("ceda62e1-9ab2-4920-9465-cb049e79dfc3"), 100, new DateTime(2025, 11, 24, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1412), "Learn about blockchain technology and cryptocurrency.", true, "Tech Hub", new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), "Blockchain Summit" },
                    { new Guid("d70f4151-99a8-4aaf-a4ba-251243e4673c"), null, new DateTime(2025, 10, 23, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1344), "An exclusive dinner party for close friends.", false, "Home", new Guid("ef6765de-e98d-4896-939d-58a46be39203"), "Private Dinner Party" },
                    { new Guid("de1c7bff-bff3-4761-9c1b-5c1f458d5cc0"), null, new DateTime(2025, 11, 3, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1340), "A workshop for art enthusiasts.", true, "Art Studio", new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), "Art Workshop" },
                    { new Guid("df0d4bee-0633-4653-bd37-488873be94b7"), 8, new DateTime(2025, 10, 25, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1348), "Private board game session.", false, "Game Cafe", new Guid("524d798e-f599-4594-9824-e75ec3d22229"), "Board Game Night" },
                    { new Guid("e26d21a7-cb03-49fd-b551-35422fe177a4"), null, new DateTime(2025, 12, 19, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1366), "Annual city-wide marathon event.", true, "City Streets", new Guid("524d798e-f599-4594-9824-e75ec3d22229"), "City Marathon" },
                    { new Guid("e5081037-258b-4944-854a-36542c9eb709"), null, new DateTime(2025, 11, 10, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1461), "Independent film screening and Q&A.", true, "Indie Cinema", new Guid("ef6765de-e98d-4896-939d-58a46be39203"), "Film Screening" },
                    { new Guid("e7c06fc3-4ba4-4179-a38c-2dc285710dd5"), 500, new DateTime(2025, 11, 6, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1466), "Connect with top employers in the region.", true, "Convention Center", new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), "Job Fair" },
                    { new Guid("e919e0e9-4b90-4188-bc98-9174f316908c"), 20, new DateTime(2025, 10, 22, 16, 37, 37, 374, DateTimeKind.Utc).AddTicks(1352), "Morning yoga session for all levels.", true, "Wellness Center", new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), "Yoga Class" }
                });

            migrationBuilder.InsertData(
                table: "EventParticipants",
                columns: new[] { "Id", "EventId", "JoinedAt", "UserId", "VisitorEmail", "VisitorFirstName", "VisitorId", "VisitorLastName" },
                values: new object[,]
                {
                    { new Guid("030adbfc-1005-4d17-bf65-ccd0c9b85242"), new Guid("3667ca74-37f6-45b4-b7ce-fe902c2b1b2c"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6419), null, "henry.scott@example.com", "Henry", new Guid("10000000-0000-0000-0000-000000000017"), "Scott" },
                    { new Guid("035a7ca3-656f-44c0-a8ca-99040ab84925"), new Guid("e7c06fc3-4ba4-4179-a38c-2dc285710dd5"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6566), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("05d15b3e-bf49-48a8-b599-bcbf492c6abd"), new Guid("0792ae44-85dc-4e58-97ef-39ebf3f34444"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6463), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("05f78387-815d-4151-a6f8-10ac4a2bfe79"), new Guid("d70f4151-99a8-4aaf-a4ba-251243e4673c"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6196), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("08f51c89-78d7-4c78-8c42-52b6128f0680"), new Guid("0b5063d3-cf21-4c5a-9c40-4f7418ff5948"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6554), null, "ethan.walker@example.com", "Ethan", new Guid("10000000-0000-0000-0000-000000000012"), "Walker" },
                    { new Guid("0e3360b8-95f6-4a21-b0c1-3c21f4e9be59"), new Guid("0b5063d3-cf21-4c5a-9c40-4f7418ff5948"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6551), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("11e65a86-39ef-4046-89de-862961ac4e21"), new Guid("11d38f7b-5d07-45d4-a39f-545e382c63f7"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6408), null, "james.anderson@example.com", "James", new Guid("10000000-0000-0000-0000-000000000005"), "Anderson" },
                    { new Guid("13673fc6-e196-4874-b571-c738437f20b9"), new Guid("ceda62e1-9ab2-4920-9465-cb049e79dfc3"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6462), null, "lily.roberts@example.com", "Lily", new Guid("10000000-0000-0000-0000-000000000021"), "Roberts" },
                    { new Guid("13952bae-54f0-47a3-8420-4bc2b842fb4c"), new Guid("ab531bc9-33db-49e4-8e93-d89f1962e5a8"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6175), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("15b66dce-1411-429e-9656-fcaaf8b81a55"), new Guid("9d1fcacd-47ce-4bbf-b692-785e84451c5e"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6575), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("15edc414-6c3b-4f3c-b4dd-53d47b8151d1"), new Guid("e7c06fc3-4ba4-4179-a38c-2dc285710dd5"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6567), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("1659021e-8f50-4ef5-8806-ac5ffd8a5e5f"), new Guid("0e5b218c-bca8-4989-8454-ed869ff1f951"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6538), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("1667da5a-64d3-449b-bcb4-e1a78d169413"), new Guid("c58dda12-1562-4a73-bd57-02ff9f1b3e57"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6496), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("17a27259-515f-49e8-8651-f04b00e941e0"), new Guid("11d38f7b-5d07-45d4-a39f-545e382c63f7"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6409), null, "evelyn.hill@example.com", "Evelyn", new Guid("10000000-0000-0000-0000-000000000016"), "Hill" },
                    { new Guid("1ae54910-f164-4355-9c47-2d6e17904e0b"), new Guid("5d00efb4-7e0f-4b5b-8895-32b2056de4c8"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6222), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("1be4cf63-3387-4d6b-8b12-dd5cd469e95d"), new Guid("c811e049-c654-478b-a6f6-b736a1237024"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6386), null, "david.martinez@example.com", "David", new Guid("10000000-0000-0000-0000-000000000003"), "Martinez" },
                    { new Guid("1e708072-d408-435a-8b94-a7fa71bca25a"), new Guid("c6ac8b54-5627-44a7-9a3a-960f2573ec7a"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6389), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("22f6b3e6-be68-411b-a731-303d02736ea7"), new Guid("09189be9-c6ff-4f4c-9c6c-db8517d9530b"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6531), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("230c4027-a046-41c9-9931-d17323606181"), new Guid("0b3441a6-b2b0-4e22-ac78-a93286c3ee08"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6436), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("232c3d29-2ccc-42c2-bb06-c23e344deefe"), new Guid("b0f8fd5f-9535-44eb-9814-31c8b060a928"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6471), null, "charlotte.lee@example.com", "Charlotte", new Guid("10000000-0000-0000-0000-000000000011"), "Lee" },
                    { new Guid("27e5d7cf-cd8e-42ff-913a-9ed5807dc3f6"), new Guid("838a0093-0d94-43b6-8036-3c6f48eb3818"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6444), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("2b74166d-0639-4875-aada-6d74e3e1a245"), new Guid("5d00efb4-7e0f-4b5b-8895-32b2056de4c8"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6360), null, "isabella.thompson@example.com", "Isabella", new Guid("10000000-0000-0000-0000-000000000010"), "Thompson" },
                    { new Guid("2cf0beec-2af7-4c21-8ef0-8e13c6f53a08"), new Guid("ab531bc9-33db-49e4-8e93-d89f1962e5a8"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6187), null, "james.anderson@example.com", "James", new Guid("10000000-0000-0000-0000-000000000005"), "Anderson" },
                    { new Guid("3047cb8d-9aea-46ff-9f8f-5581e658e4cc"), new Guid("ceda62e1-9ab2-4920-9465-cb049e79dfc3"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6446), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("31926d34-4547-4f6f-99a2-aa421f1d3a27"), new Guid("a8e253b6-ec75-4f46-ac7d-b365afcd5e22"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6475), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("3246a508-3848-408a-8a73-2480d797958b"), new Guid("c9ae2a15-74c4-4c45-b9ee-4460881e7480"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6433), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("352e9b51-c685-4762-9c5b-f605d5cf2e1a"), new Guid("556144b0-e80d-4608-9849-d0aaac573ecb"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6489), null, "ryan.evans@example.com", "Ryan", new Guid("10000000-0000-0000-0000-000000000024"), "Evans" },
                    { new Guid("4334f768-d253-44c6-9daf-8cfc3fa9896f"), new Guid("e26d21a7-cb03-49fd-b551-35422fe177a4"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6378), null, "amelia.hall@example.com", "Amelia", new Guid("10000000-0000-0000-0000-000000000013"), "Hall" },
                    { new Guid("471f1301-d706-4998-9d80-e4a16e058bc6"), new Guid("3f78e6a7-9fa3-4934-b9d3-54f7b0bdaff0"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6381), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("4a404139-5640-4a6a-a80f-0c53909a275a"), new Guid("3667ca74-37f6-45b4-b7ce-fe902c2b1b2c"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6420), null, "ella.green@example.com", "Ella", new Guid("10000000-0000-0000-0000-000000000018"), "Green" },
                    { new Guid("512e98a2-9fe8-4d76-8fd9-c41f956e5a93"), new Guid("3667ca74-37f6-45b4-b7ce-fe902c2b1b2c"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6416), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("522c3879-2abe-4b29-8dfb-d7711e487536"), new Guid("df0d4bee-0633-4653-bd37-488873be94b7"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6201), null, "liam.thomas@example.com", "Liam", new Guid("10000000-0000-0000-0000-000000000006"), "Thomas" },
                    { new Guid("52871682-2916-463f-98ab-ea76d3eab2c3"), new Guid("0792ae44-85dc-4e58-97ef-39ebf3f34444"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6466), null, "matthew.turner@example.com", "Matthew", new Guid("10000000-0000-0000-0000-000000000022"), "Turner" },
                    { new Guid("566fca94-58e8-476f-a331-d2cf4c33a3d5"), new Guid("e7c06fc3-4ba4-4179-a38c-2dc285710dd5"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6568), null, "david.martinez@example.com", "David", new Guid("10000000-0000-0000-0000-000000000003"), "Martinez" },
                    { new Guid("579980e4-f12f-44d6-9bc5-0264aa5533b9"), new Guid("b2dd7112-93f2-4246-a34d-974bade50a76"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6162), null, "sarah.wilson@example.com", "Sarah", new Guid("10000000-0000-0000-0000-000000000002"), "Wilson" },
                    { new Guid("5832ce42-3788-45f7-b191-fc2dd86124fc"), new Guid("0b3441a6-b2b0-4e22-ac78-a93286c3ee08"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6440), null, "michael.brown@example.com", "Michael", new Guid("10000000-0000-0000-0000-000000000001"), "Brown" },
                    { new Guid("5b101f47-7f18-4783-9c42-b2b886db9a16"), new Guid("838a0093-0d94-43b6-8036-3c6f48eb3818"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6443), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("5cd5e2e7-18c4-40b7-b272-d7a519b4ea3b"), new Guid("c811e049-c654-478b-a6f6-b736a1237024"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6387), null, "mia.young@example.com", "Mia", new Guid("10000000-0000-0000-0000-000000000014"), "Young" },
                    { new Guid("62bf6b53-0074-417f-8cef-c438d41a9313"), new Guid("df0d4bee-0633-4653-bd37-488873be94b7"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6197), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("63554936-ec27-4fb6-9f63-351b52328730"), new Guid("e919e0e9-4b90-4188-bc98-9174f316908c"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6216), null, "emma.garcia@example.com", "Emma", new Guid("10000000-0000-0000-0000-000000000004"), "Garcia" },
                    { new Guid("642e9536-22b8-4b5b-ab4a-319e6e1052d7"), new Guid("c6ac8b54-5627-44a7-9a3a-960f2573ec7a"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6391), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("673fb09a-2dd8-42c8-8868-040bc0352d0c"), new Guid("de1c7bff-bff3-4761-9c1b-5c1f458d5cc0"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6192), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("68f4d5d5-7285-4046-8b25-ac8246f35008"), new Guid("de1c7bff-bff3-4761-9c1b-5c1f458d5cc0"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6193), null, "sarah.wilson@example.com", "Sarah", new Guid("10000000-0000-0000-0000-000000000002"), "Wilson" },
                    { new Guid("69167eca-85b7-4ed1-b5f0-2335448c464a"), new Guid("11d38f7b-5d07-45d4-a39f-545e382c63f7"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6406), null, "sarah.wilson@example.com", "Sarah", new Guid("10000000-0000-0000-0000-000000000002"), "Wilson" },
                    { new Guid("6cae62e3-04e8-4876-95dd-effef6b84bca"), new Guid("346809a6-4d97-48e3-ba23-6854ee999f94"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6411), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("6e45f3e5-decc-4377-8d7c-c0b39f15a359"), new Guid("0e5b218c-bca8-4989-8454-ed869ff1f951"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6535), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("704c39e1-131d-4205-896f-1c4dbc4e4d50"), new Guid("e919e0e9-4b90-4188-bc98-9174f316908c"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6218), null, "william.martin@example.com", "William", new Guid("10000000-0000-0000-0000-000000000009"), "Martin" },
                    { new Guid("718964f9-8f07-40a2-b5ee-4fa7a9b4127a"), new Guid("c9ae2a15-74c4-4c45-b9ee-4460881e7480"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6435), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("7250f6ed-5da0-4030-b555-9255fc1d52a9"), new Guid("0b5063d3-cf21-4c5a-9c40-4f7418ff5948"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6553), null, "isaac.stewart@example.com", "Isaac", new Guid("10000000-0000-0000-0000-000000000026"), "Stewart" },
                    { new Guid("74876f61-b204-410a-acf6-cee76bbc7ffa"), new Guid("b0f8fd5f-9535-44eb-9814-31c8b060a928"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6467), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("7b519f50-bb8f-4889-a256-077471f17d99"), new Guid("e26d21a7-cb03-49fd-b551-35422fe177a4"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6376), null, "charlotte.lee@example.com", "Charlotte", new Guid("10000000-0000-0000-0000-000000000011"), "Lee" },
                    { new Guid("7bec266d-9eb2-4848-89d2-e28b95f551c8"), new Guid("df0d4bee-0633-4653-bd37-488873be94b7"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6212), null, "noah.white@example.com", "Noah", new Guid("10000000-0000-0000-0000-000000000008"), "White" },
                    { new Guid("8028b52e-6fd6-4d2b-a7c0-fdbff818bfe3"), new Guid("3f78e6a7-9fa3-4934-b9d3-54f7b0bdaff0"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6382), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("81ecc259-fa61-40c3-b426-1e56a5dac401"), new Guid("3667ca74-37f6-45b4-b7ce-fe902c2b1b2c"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6414), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("825f1e2b-e4fd-427f-9fd6-581ca075b49f"), new Guid("e919e0e9-4b90-4188-bc98-9174f316908c"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6215), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("83c66ad2-d8d4-4e45-86d6-d79848df7e25"), new Guid("09189be9-c6ff-4f4c-9c6c-db8517d9530b"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6532), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("8424013f-0e07-4176-918f-82b987e01ea7"), new Guid("ceda62e1-9ab2-4920-9465-cb049e79dfc3"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6447), null, "david.martinez@example.com", "David", new Guid("10000000-0000-0000-0000-000000000003"), "Martinez" },
                    { new Guid("90344166-2fae-43aa-a3be-a152ae7e9096"), new Guid("0b5063d3-cf21-4c5a-9c40-4f7418ff5948"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6552), null, "hannah.collins@example.com", "Hannah", new Guid("10000000-0000-0000-0000-000000000025"), "Collins" },
                    { new Guid("943b8415-39ec-4ad1-ab86-fa551d2a323f"), new Guid("9d1fcacd-47ce-4bbf-b692-785e84451c5e"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6577), null, "michael.brown@example.com", "Michael", new Guid("10000000-0000-0000-0000-000000000001"), "Brown" },
                    { new Guid("94cbe845-a891-485f-87b7-11e6801ef95f"), new Guid("09189be9-c6ff-4f4c-9c6c-db8517d9530b"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6533), null, "sarah.wilson@example.com", "Sarah", new Guid("10000000-0000-0000-0000-000000000002"), "Wilson" },
                    { new Guid("9800fc2b-5003-45fd-ac6a-f4c974f5b530"), new Guid("556144b0-e80d-4608-9849-d0aaac573ecb"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6485), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("9a996f11-789e-41ba-820a-bec9c08c86a1"), new Guid("e919e0e9-4b90-4188-bc98-9174f316908c"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6214), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("9ab90b8f-c8dd-4ec5-9386-4c6d58b1c5e6"), new Guid("b2dd7112-93f2-4246-a34d-974bade50a76"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6120), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("9e1f72c9-88e3-4a7a-838f-de0efd091054"), new Guid("ceda62e1-9ab2-4920-9465-cb049e79dfc3"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6445), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("9e97df8d-ccee-4098-8d0c-9ef486aea7a1"), new Guid("0792ae44-85dc-4e58-97ef-39ebf3f34444"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6464), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("aa71eec5-5b7d-46b2-b959-4f8c0ce22c56"), new Guid("c811e049-c654-478b-a6f6-b736a1237024"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6384), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("ae51bc20-ebd0-4842-8bb3-3ed3bc3e077e"), new Guid("b2dd7112-93f2-4246-a34d-974bade50a76"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6156), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("b057508c-d7f6-40c4-953c-578d04cb57b4"), new Guid("e26d21a7-cb03-49fd-b551-35422fe177a4"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6364), null, "michael.brown@example.com", "Michael", new Guid("10000000-0000-0000-0000-000000000001"), "Brown" },
                    { new Guid("b0873bd6-96b2-4340-ab31-e2b6655ae2ae"), new Guid("e5081037-258b-4944-854a-36542c9eb709"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6562), null, "evelyn.hill@example.com", "Evelyn", new Guid("10000000-0000-0000-0000-000000000016"), "Hill" },
                    { new Guid("b1c034b5-b011-4960-a5b7-077c4740acda"), new Guid("a8e253b6-ec75-4f46-ac7d-b365afcd5e22"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6474), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("b8070290-f815-4b77-9a99-e729c70b4403"), new Guid("346809a6-4d97-48e3-ba23-6854ee999f94"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6410), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("bb8c8f43-48cc-4d23-8ab5-f09651c0b18e"), new Guid("012740e4-3721-49ea-b91d-6b3bc0b8dc95"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6557), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("bd32c1f5-99aa-46b7-ad11-97a42198e2ff"), new Guid("e7c06fc3-4ba4-4179-a38c-2dc285710dd5"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6570), null, "caleb.reed@example.com", "Caleb", new Guid("10000000-0000-0000-0000-000000000027"), "Reed" },
                    { new Guid("bea70451-8ee0-4fbc-ae94-aad6a1cb8ae7"), new Guid("c811e049-c654-478b-a6f6-b736a1237024"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6385), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("c096526b-a7af-43b5-a934-f6fc7b0fb1f8"), new Guid("e26d21a7-cb03-49fd-b551-35422fe177a4"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6361), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("c26c8aa0-6183-4dc3-bf9a-8fe28233d704"), new Guid("df0d4bee-0633-4653-bd37-488873be94b7"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6211), null, "sophia.jackson@example.com", "Sophia", new Guid("10000000-0000-0000-0000-000000000007"), "Jackson" },
                    { new Guid("c3a5b44e-f454-412c-a969-becb06073adc"), new Guid("11d38f7b-5d07-45d4-a39f-545e382c63f7"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6404), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("c77f54d9-9e98-42c5-86e8-3585fbd90cf7"), new Guid("45d0162b-5f24-4881-a2c5-0426608656b5"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6565), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("c899d159-eed2-4904-8a9f-b9f52a1e4c33"), new Guid("11d38f7b-5d07-45d4-a39f-545e382c63f7"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6405), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("c8f7362c-c3cd-437d-915c-966249e6c2c5"), new Guid("ab531bc9-33db-49e4-8e93-d89f1962e5a8"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6176), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("c914fa0a-6857-4ba8-93c2-fe695357c273"), new Guid("ab531bc9-33db-49e4-8e93-d89f1962e5a8"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6178), null, "david.martinez@example.com", "David", new Guid("10000000-0000-0000-0000-000000000003"), "Martinez" },
                    { new Guid("ca931f3b-54f4-4b68-8d0b-229d5f3f5231"), new Guid("5d00efb4-7e0f-4b5b-8895-32b2056de4c8"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6219), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("caba3952-6f7b-4743-bc05-9fa7092cfa8d"), new Guid("9d1fcacd-47ce-4bbf-b692-785e84451c5e"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6574), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("cbd79b12-41dd-4166-971c-9008708b1434"), new Guid("45d0162b-5f24-4881-a2c5-0426608656b5"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6564), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("cdb0d883-8112-4001-93a3-63def7623e14"), new Guid("0b5063d3-cf21-4c5a-9c40-4f7418ff5948"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6548), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("d07a98ed-c1fe-4bcd-abb2-566eae061997"), new Guid("d70f4151-99a8-4aaf-a4ba-251243e4673c"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6195), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("d3c5720e-9833-4289-ae26-8ceba05df6a7"), new Guid("c6ac8b54-5627-44a7-9a3a-960f2573ec7a"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6394), null, "lucas.king@example.com", "Lucas", new Guid("10000000-0000-0000-0000-000000000015"), "King" },
                    { new Guid("d44dbdb2-3e48-43ee-9778-25146c077a70"), new Guid("b2dd7112-93f2-4246-a34d-974bade50a76"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6160), null, "michael.brown@example.com", "Michael", new Guid("10000000-0000-0000-0000-000000000001"), "Brown" },
                    { new Guid("d4e46fad-587f-41cc-82ba-89cfbc402623"), new Guid("ceda62e1-9ab2-4920-9465-cb049e79dfc3"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6461), null, "samuel.perez@example.com", "Samuel", new Guid("10000000-0000-0000-0000-000000000020"), "Perez" },
                    { new Guid("d4e92965-61f9-484f-942b-3a4b33cb5b6c"), new Guid("556144b0-e80d-4608-9849-d0aaac573ecb"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6486), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("d769c4a3-3e28-4bf2-8988-ed276562265b"), new Guid("012740e4-3721-49ea-b91d-6b3bc0b8dc95"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6556), new Guid("ef6765de-e98d-4896-939d-58a46be39203"), null, null, null, null },
                    { new Guid("d8b6266a-eaf4-4c7b-91a1-c9eb00ce1e53"), new Guid("df0d4bee-0633-4653-bd37-488873be94b7"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6198), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("d8fce23c-83dc-474e-8995-480bcd91fd85"), new Guid("b0f8fd5f-9535-44eb-9814-31c8b060a928"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6468), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("db5cfef8-7ce4-4879-9b77-1a2a1a3574bf"), new Guid("c58dda12-1562-4a73-bd57-02ff9f1b3e57"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6497), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("dca5c675-37bb-41e1-9877-5941a36b050f"), new Guid("ab531bc9-33db-49e4-8e93-d89f1962e5a8"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6185), null, "emma.garcia@example.com", "Emma", new Guid("10000000-0000-0000-0000-000000000004"), "Garcia" },
                    { new Guid("ddd9fae1-2a88-4459-bd6b-0c6a553f0259"), new Guid("b0f8fd5f-9535-44eb-9814-31c8b060a928"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6473), null, "jackson.campbell@example.com", "Jackson", new Guid("10000000-0000-0000-0000-000000000023"), "Campbell" },
                    { new Guid("e202b5f6-b3a6-403b-9a6d-1117337744b1"), new Guid("e26d21a7-cb03-49fd-b551-35422fe177a4"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6377), null, "ethan.walker@example.com", "Ethan", new Guid("10000000-0000-0000-0000-000000000012"), "Walker" },
                    { new Guid("efb8b1d9-b298-4638-9df5-4d4f6e48a641"), new Guid("e5081037-258b-4944-854a-36542c9eb709"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6558), new Guid("524d798e-f599-4594-9824-e75ec3d22229"), null, null, null, null },
                    { new Guid("f4614ba4-264a-4b53-aceb-7c64faa7cce9"), new Guid("3667ca74-37f6-45b4-b7ce-fe902c2b1b2c"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6431), null, "emma.garcia@example.com", "Emma", new Guid("10000000-0000-0000-0000-000000000004"), "Garcia" },
                    { new Guid("f5edd7de-bb4a-4e97-9e9f-b45d0f9b547a"), new Guid("ceda62e1-9ab2-4920-9465-cb049e79dfc3"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6459), null, "james.anderson@example.com", "James", new Guid("10000000-0000-0000-0000-000000000005"), "Anderson" },
                    { new Guid("f9a5b9c8-ffa7-43e5-b1a9-6741b26448e8"), new Guid("556144b0-e80d-4608-9849-d0aaac573ecb"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6488), null, "ella.green@example.com", "Ella", new Guid("10000000-0000-0000-0000-000000000018"), "Green" },
                    { new Guid("fa57dddd-c17f-45e0-92cc-3157a0aa5e50"), new Guid("e26d21a7-cb03-49fd-b551-35422fe177a4"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6363), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("facc3602-8f42-49ae-b982-5faca5f3fd7d"), new Guid("e5081037-258b-4944-854a-36542c9eb709"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6560), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("fc336f60-5380-4c54-bddd-702666e9b151"), new Guid("0b3441a6-b2b0-4e22-ac78-a93286c3ee08"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6439), new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"), null, null, null, null },
                    { new Guid("fccf7a7f-0776-4040-a336-e831dfaaf5d4"), new Guid("0b3441a6-b2b0-4e22-ac78-a93286c3ee08"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6441), null, "daniel.nelson@example.com", "Daniel", new Guid("10000000-0000-0000-0000-000000000019"), "Nelson" },
                    { new Guid("ffc0dc6c-94f8-460b-9f49-ea232741890b"), new Guid("e7c06fc3-4ba4-4179-a38c-2dc285710dd5"), new DateTime(2025, 10, 20, 16, 37, 37, 377, DateTimeKind.Utc).AddTicks(6571), null, "scarlett.cook@example.com", "Scarlett", new Guid("10000000-0000-0000-0000-000000000028"), "Cook" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("030adbfc-1005-4d17-bf65-ccd0c9b85242"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("035a7ca3-656f-44c0-a8ca-99040ab84925"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("05d15b3e-bf49-48a8-b599-bcbf492c6abd"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("05f78387-815d-4151-a6f8-10ac4a2bfe79"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("08f51c89-78d7-4c78-8c42-52b6128f0680"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("0e3360b8-95f6-4a21-b0c1-3c21f4e9be59"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("11e65a86-39ef-4046-89de-862961ac4e21"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("13673fc6-e196-4874-b571-c738437f20b9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("13952bae-54f0-47a3-8420-4bc2b842fb4c"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("15b66dce-1411-429e-9656-fcaaf8b81a55"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("15edc414-6c3b-4f3c-b4dd-53d47b8151d1"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("1659021e-8f50-4ef5-8806-ac5ffd8a5e5f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("1667da5a-64d3-449b-bcb4-e1a78d169413"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("17a27259-515f-49e8-8651-f04b00e941e0"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("1ae54910-f164-4355-9c47-2d6e17904e0b"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("1be4cf63-3387-4d6b-8b12-dd5cd469e95d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("1e708072-d408-435a-8b94-a7fa71bca25a"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("22f6b3e6-be68-411b-a731-303d02736ea7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("230c4027-a046-41c9-9931-d17323606181"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("232c3d29-2ccc-42c2-bb06-c23e344deefe"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("27e5d7cf-cd8e-42ff-913a-9ed5807dc3f6"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("2b74166d-0639-4875-aada-6d74e3e1a245"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("2cf0beec-2af7-4c21-8ef0-8e13c6f53a08"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("3047cb8d-9aea-46ff-9f8f-5581e658e4cc"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("31926d34-4547-4f6f-99a2-aa421f1d3a27"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("3246a508-3848-408a-8a73-2480d797958b"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("352e9b51-c685-4762-9c5b-f605d5cf2e1a"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("4334f768-d253-44c6-9daf-8cfc3fa9896f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("471f1301-d706-4998-9d80-e4a16e058bc6"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("4a404139-5640-4a6a-a80f-0c53909a275a"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("512e98a2-9fe8-4d76-8fd9-c41f956e5a93"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("522c3879-2abe-4b29-8dfb-d7711e487536"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("52871682-2916-463f-98ab-ea76d3eab2c3"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("566fca94-58e8-476f-a331-d2cf4c33a3d5"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("579980e4-f12f-44d6-9bc5-0264aa5533b9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("5832ce42-3788-45f7-b191-fc2dd86124fc"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("5b101f47-7f18-4783-9c42-b2b886db9a16"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("5cd5e2e7-18c4-40b7-b272-d7a519b4ea3b"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("62bf6b53-0074-417f-8cef-c438d41a9313"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("63554936-ec27-4fb6-9f63-351b52328730"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("642e9536-22b8-4b5b-ab4a-319e6e1052d7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("673fb09a-2dd8-42c8-8868-040bc0352d0c"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("68f4d5d5-7285-4046-8b25-ac8246f35008"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("69167eca-85b7-4ed1-b5f0-2335448c464a"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("6cae62e3-04e8-4876-95dd-effef6b84bca"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("6e45f3e5-decc-4377-8d7c-c0b39f15a359"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("704c39e1-131d-4205-896f-1c4dbc4e4d50"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("718964f9-8f07-40a2-b5ee-4fa7a9b4127a"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("7250f6ed-5da0-4030-b555-9255fc1d52a9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("74876f61-b204-410a-acf6-cee76bbc7ffa"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("7b519f50-bb8f-4889-a256-077471f17d99"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("7bec266d-9eb2-4848-89d2-e28b95f551c8"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("8028b52e-6fd6-4d2b-a7c0-fdbff818bfe3"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("81ecc259-fa61-40c3-b426-1e56a5dac401"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("825f1e2b-e4fd-427f-9fd6-581ca075b49f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("83c66ad2-d8d4-4e45-86d6-d79848df7e25"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("8424013f-0e07-4176-918f-82b987e01ea7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("90344166-2fae-43aa-a3be-a152ae7e9096"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("943b8415-39ec-4ad1-ab86-fa551d2a323f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("94cbe845-a891-485f-87b7-11e6801ef95f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("9800fc2b-5003-45fd-ac6a-f4c974f5b530"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("9a996f11-789e-41ba-820a-bec9c08c86a1"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("9ab90b8f-c8dd-4ec5-9386-4c6d58b1c5e6"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("9e1f72c9-88e3-4a7a-838f-de0efd091054"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("9e97df8d-ccee-4098-8d0c-9ef486aea7a1"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("aa71eec5-5b7d-46b2-b959-4f8c0ce22c56"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ae51bc20-ebd0-4842-8bb3-3ed3bc3e077e"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("b057508c-d7f6-40c4-953c-578d04cb57b4"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("b0873bd6-96b2-4340-ab31-e2b6655ae2ae"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("b1c034b5-b011-4960-a5b7-077c4740acda"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("b8070290-f815-4b77-9a99-e729c70b4403"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("bb8c8f43-48cc-4d23-8ab5-f09651c0b18e"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("bd32c1f5-99aa-46b7-ad11-97a42198e2ff"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("bea70451-8ee0-4fbc-ae94-aad6a1cb8ae7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c096526b-a7af-43b5-a934-f6fc7b0fb1f8"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c26c8aa0-6183-4dc3-bf9a-8fe28233d704"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c3a5b44e-f454-412c-a969-becb06073adc"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c77f54d9-9e98-42c5-86e8-3585fbd90cf7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c899d159-eed2-4904-8a9f-b9f52a1e4c33"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c8f7362c-c3cd-437d-915c-966249e6c2c5"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("c914fa0a-6857-4ba8-93c2-fe695357c273"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ca931f3b-54f4-4b68-8d0b-229d5f3f5231"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("caba3952-6f7b-4743-bc05-9fa7092cfa8d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("cbd79b12-41dd-4166-971c-9008708b1434"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("cdb0d883-8112-4001-93a3-63def7623e14"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d07a98ed-c1fe-4bcd-abb2-566eae061997"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d3c5720e-9833-4289-ae26-8ceba05df6a7"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d44dbdb2-3e48-43ee-9778-25146c077a70"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d4e46fad-587f-41cc-82ba-89cfbc402623"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d4e92965-61f9-484f-942b-3a4b33cb5b6c"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d769c4a3-3e28-4bf2-8988-ed276562265b"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d8b6266a-eaf4-4c7b-91a1-c9eb00ce1e53"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("d8fce23c-83dc-474e-8995-480bcd91fd85"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("db5cfef8-7ce4-4879-9b77-1a2a1a3574bf"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("dca5c675-37bb-41e1-9877-5941a36b050f"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ddd9fae1-2a88-4459-bd6b-0c6a553f0259"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("e202b5f6-b3a6-403b-9a6d-1117337744b1"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("efb8b1d9-b298-4638-9df5-4d4f6e48a641"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("f4614ba4-264a-4b53-aceb-7c64faa7cce9"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("f5edd7de-bb4a-4e97-9e9f-b45d0f9b547a"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("f9a5b9c8-ffa7-43e5-b1a9-6741b26448e8"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("fa57dddd-c17f-45e0-92cc-3157a0aa5e50"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("facc3602-8f42-49ae-b982-5faca5f3fd7d"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("fc336f60-5380-4c54-bddd-702666e9b151"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("fccf7a7f-0776-4040-a336-e831dfaaf5d4"));

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "Id",
                keyValue: new Guid("ffc0dc6c-94f8-460b-9f49-ea232741890b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("012740e4-3721-49ea-b91d-6b3bc0b8dc95"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("0792ae44-85dc-4e58-97ef-39ebf3f34444"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("09189be9-c6ff-4f4c-9c6c-db8517d9530b"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("0b3441a6-b2b0-4e22-ac78-a93286c3ee08"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("0b5063d3-cf21-4c5a-9c40-4f7418ff5948"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("0e5b218c-bca8-4989-8454-ed869ff1f951"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("11d38f7b-5d07-45d4-a39f-545e382c63f7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("346809a6-4d97-48e3-ba23-6854ee999f94"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3667ca74-37f6-45b4-b7ce-fe902c2b1b2c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3f78e6a7-9fa3-4934-b9d3-54f7b0bdaff0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("45d0162b-5f24-4881-a2c5-0426608656b5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("556144b0-e80d-4608-9849-d0aaac573ecb"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5d00efb4-7e0f-4b5b-8895-32b2056de4c8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("838a0093-0d94-43b6-8036-3c6f48eb3818"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("9d1fcacd-47ce-4bbf-b692-785e84451c5e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("a8e253b6-ec75-4f46-ac7d-b365afcd5e22"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("ab531bc9-33db-49e4-8e93-d89f1962e5a8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b0f8fd5f-9535-44eb-9814-31c8b060a928"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b2dd7112-93f2-4246-a34d-974bade50a76"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c58dda12-1562-4a73-bd57-02ff9f1b3e57"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c6ac8b54-5627-44a7-9a3a-960f2573ec7a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c811e049-c654-478b-a6f6-b736a1237024"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c9ae2a15-74c4-4c45-b9ee-4460881e7480"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("ceda62e1-9ab2-4920-9465-cb049e79dfc3"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d70f4151-99a8-4aaf-a4ba-251243e4673c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("de1c7bff-bff3-4761-9c1b-5c1f458d5cc0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("df0d4bee-0633-4653-bd37-488873be94b7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e26d21a7-cb03-49fd-b551-35422fe177a4"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e5081037-258b-4944-854a-36542c9eb709"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e7c06fc3-4ba4-4179-a38c-2dc285710dd5"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e919e0e9-4b90-4188-bc98-9174f316908c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("524d798e-f599-4594-9824-e75ec3d22229"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95da1d65-6add-43aa-b507-cd653e2c6b39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef6765de-e98d-4896-939d-58a46be39203"));

            migrationBuilder.AddColumn<Guid>(
                name: "EventId1",
                table: "EventParticipants",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), "jane.smith@example.com", "Jane", "Smith", "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue" },
                    { new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), "john.doe@example.com", "John", "Doe", "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue" },
                    { new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), "alice.johnson@example.com", "Alice", "Johnson", "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Capacity", "Date", "Description", "IsPublic", "Location", "OrganizerId", "Title" },
                values: new object[,]
                {
                    { new Guid("0397e27e-fb26-4b17-921e-d50489efcf99"), null, new DateTime(2025, 10, 30, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8030), "Monthly book club discussion.", false, "Library Private Room", new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), "Book Club Meeting" },
                    { new Guid("05534e12-a419-4a80-9299-8677f17879dc"), null, new DateTime(2025, 12, 14, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8168), "Private weekend meditation and mindfulness retreat.", false, "Mountain Retreat Center", new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), "Meditation Retreat" },
                    { new Guid("0f8e5c73-05d1-46c9-9b2d-e65aea98c80a"), null, new DateTime(2025, 10, 21, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(281), "A meetup for community members.", true, "Community Center", new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), "Community Meetup" },
                    { new Guid("202e3ac6-1d44-4154-803c-2a8b74742f7c"), 200, new DateTime(2025, 11, 17, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8158), "Annual science fair for students and enthusiasts.", true, "Science Museum", new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), "Science Fair" },
                    { new Guid("207403de-e129-4985-b6e2-b4dba076be82"), null, new DateTime(2025, 10, 23, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8151), "Showcase your talent at our weekly open mic.", true, "Jazz Club", new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), "Open Mic Night" },
                    { new Guid("23c1e0ed-74ab-47ad-b2ed-9ecce8b99d97"), 15, new DateTime(2025, 10, 29, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8136), "Private celebration for the groom-to-be.", false, "Resort", new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), "Bachelor Party" },
                    { new Guid("3aa1f8da-c834-4c99-9559-8d32db64e337"), null, new DateTime(2025, 11, 14, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8124), "Explore diverse street food from around the world.", true, "Downtown Plaza", new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), "Street Food Festival" },
                    { new Guid("3dd4a1ef-9eaf-46cd-93ab-efc323f7c114"), 25, new DateTime(2025, 10, 24, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8144), "Learn salsa dancing from scratch.", true, "Dance Studio", new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), "Dance Class Beginner" },
                    { new Guid("417fed05-5862-48f7-ae02-179cc7c79c71"), 35, new DateTime(2025, 12, 9, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8147), "Celebrating 25 years together with close family.", false, "Garden Venue", new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), "Wedding Anniversary" },
                    { new Guid("492f8a7d-abd8-4dda-9237-eb9eccfc6be5"), 12, new DateTime(2025, 11, 4, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8070), "Professional photography workshop.", true, "Photography Studio", new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), "Photography Masterclass" },
                    { new Guid("4d0043a3-b721-4d5e-ae48-330f64a37ea8"), 40, new DateTime(2025, 11, 7, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8073), "Private team building activities.", false, "Adventure Park", new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), "Corporate Team Building" },
                    { new Guid("5fc8aa3e-4da7-4a26-a961-046cb3881f6d"), 500, new DateTime(2025, 11, 6, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8170), "Connect with top employers in the region.", true, "Convention Center", new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), "Job Fair" },
                    { new Guid("630e1c97-0e60-4b78-a321-cd25ce86e7e3"), 8, new DateTime(2025, 10, 25, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8016), "Private board game session.", false, "Game Cafe", new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), "Board Game Night" },
                    { new Guid("69355c02-06d9-4c07-af4c-5e44e9f82282"), null, new DateTime(2025, 11, 10, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8165), "Independent film screening and Q&A.", true, "Indie Cinema", new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), "Film Screening" },
                    { new Guid("7058015f-33ca-4da7-8b5d-a8d63dfd21b5"), null, new DateTime(2025, 10, 31, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8154), "Quarterly business strategy meeting.", false, "Conference Room A", new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), "Strategy Planning Session" },
                    { new Guid("7d595805-51f8-45f3-9652-d1b9336689f6"), null, new DateTime(2025, 10, 23, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8012), "An exclusive dinner party for close friends.", false, "Home", new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), "Private Dinner Party" },
                    { new Guid("805fd53a-e4f4-47e3-8fe9-795bf5c50c3d"), 25, new DateTime(2025, 11, 19, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8024), "Annual family gathering.", false, "Family Home", new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), "Family Reunion" },
                    { new Guid("83d8a607-feba-465a-ac42-5d031446225a"), null, new DateTime(2025, 12, 4, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8064), "Open air music festival with multiple bands.", true, "Park Amphitheater", new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), "Music Festival" },
                    { new Guid("8d1ae803-e6e8-417f-96b6-94a00fbbbd89"), null, new DateTime(2025, 10, 28, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8067), "Exclusive wine tasting for connoisseurs.", false, "Private Wine Cellar", new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), "Wine Tasting Evening" },
                    { new Guid("accb2146-ab97-4947-8c4f-00b65fdff3ce"), null, new DateTime(2025, 11, 11, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8141), "Private launch event for new product line.", false, "Luxury Hotel Ballroom", new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), "Exclusive Product Launch" },
                    { new Guid("b7c0bdf9-4f4e-48e4-9525-5d4e99fef16d"), 15, new DateTime(2025, 11, 1, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8054), "Learn to cook Italian cuisine.", true, "Culinary Institute", new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), "Cooking Workshop" },
                    { new Guid("ba91c424-b9d0-48ac-aceb-72d6438d1a28"), null, new DateTime(2025, 10, 26, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8127), "Intimate poetry reading and discussion.", false, "Cozy Bookshop", new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), "Poetry Reading Circle" },
                    { new Guid("ca0bfc7d-d69e-457e-a615-7bf76a7fe302"), null, new DateTime(2025, 11, 29, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8138), "Community charity walk for local hospital.", true, "City Park Trail", new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), "Charity Walk" },
                    { new Guid("ce470e6d-3d74-4fac-b542-b21f9eb44186"), null, new DateTime(2025, 11, 3, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8007), "A workshop for art enthusiasts.", true, "Art Studio", new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), "Art Workshop" },
                    { new Guid("d5610a25-697b-4e79-8751-9c501c07c89b"), null, new DateTime(2025, 12, 19, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8027), "Annual city-wide marathon event.", true, "City Streets", new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), "City Marathon" },
                    { new Guid("dd90b841-5d30-4235-a29c-046e8da496b1"), 20, new DateTime(2025, 11, 2, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8162), "Secret birthday celebration.", false, "Friend's House", new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), "Birthday Surprise Party" },
                    { new Guid("e08e16b1-1a2d-4e4c-9b70-979d5cac1e6b"), 100, new DateTime(2025, 11, 24, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8130), "Learn about blockchain technology and cryptocurrency.", true, "Tech Hub", new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), "Blockchain Summit" },
                    { new Guid("f0029ae0-3d6e-44f0-a000-59e9379d78c1"), 50, new DateTime(2025, 12, 29, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8173), "Private reunion for class of 2010.", false, "University Hall", new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), "Alumni Gathering" },
                    { new Guid("f77b8c32-37d5-4259-9f5c-00242d6ed13a"), 30, new DateTime(2025, 11, 9, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8061), "Private investment strategy seminar.", false, "Financial Center", new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), "Investment Seminar" },
                    { new Guid("fc35537a-4342-4234-a4d4-76022157d207"), 50, new DateTime(2025, 10, 27, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(7975), "Annual technology conference.", true, "Convention Hall", new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), "Tech Conference" },
                    { new Guid("fc4b234d-2b08-4106-9af9-4830406e713b"), 20, new DateTime(2025, 10, 22, 16, 20, 18, 226, DateTimeKind.Utc).AddTicks(8020), "Morning yoga session for all levels.", true, "Wellness Center", new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), "Yoga Class" }
                });

            migrationBuilder.InsertData(
                table: "EventParticipants",
                columns: new[] { "Id", "EventId", "EventId1", "JoinedAt", "UserId", "VisitorEmail", "VisitorFirstName", "VisitorId", "VisitorLastName" },
                values: new object[,]
                {
                    { new Guid("02319015-ce5b-4a96-b0da-697424210a62"), new Guid("492f8a7d-abd8-4dda-9237-eb9eccfc6be5"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4150), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("0394507a-980a-43b8-9dd7-6f5c87fffaa1"), new Guid("b7c0bdf9-4f4e-48e4-9525-5d4e99fef16d"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4120), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("054878d3-6e9b-4312-bfd0-6de5712a7a18"), new Guid("accb2146-ab97-4947-8c4f-00b65fdff3ce"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4232), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("055b9a80-39d1-4d47-9288-91db52ad40c8"), new Guid("0397e27e-fb26-4b17-921e-d50489efcf99"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4116), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("0aabc434-6679-47c4-a1c8-30ec2c95e455"), new Guid("3dd4a1ef-9eaf-46cd-93ab-efc323f7c114"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4243), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("0cbb463e-8641-416e-917a-dd246e0919fc"), new Guid("0397e27e-fb26-4b17-921e-d50489efcf99"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4117), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("1047f2f0-a83d-4b9d-9417-3c42882617ae"), new Guid("83d8a607-feba-465a-ac42-5d031446225a"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4139), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("11871be9-92bc-44b6-9ad8-a73d56f7a270"), new Guid("7058015f-33ca-4da7-8b5d-a8d63dfd21b5"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4258), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("12c78b0b-350f-4b43-bc6a-6a6f74367b28"), new Guid("b7c0bdf9-4f4e-48e4-9525-5d4e99fef16d"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4124), null, "mia.young@example.com", "Mia", new Guid("10000000-0000-0000-0000-000000000014"), "Young" },
                    { new Guid("156b0b66-a677-4711-b9ff-18b55a2f26e2"), new Guid("5fc8aa3e-4da7-4a26-a961-046cb3881f6d"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4291), null, "caleb.reed@example.com", "Caleb", new Guid("10000000-0000-0000-0000-000000000027"), "Reed" },
                    { new Guid("2189d742-bf6e-4934-9477-c5a2e2fcb9aa"), new Guid("d5610a25-697b-4e79-8751-9c501c07c89b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4097), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("2740cb7f-67d6-496c-ae8b-40eb129983a3"), new Guid("b7c0bdf9-4f4e-48e4-9525-5d4e99fef16d"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4118), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("2b0a9746-77c4-4628-bbd8-9a6ca2184421"), new Guid("23c1e0ed-74ab-47ad-b2ed-9ecce8b99d97"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4222), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("30995362-cb04-4e90-b8f1-0551a3643fad"), new Guid("b7c0bdf9-4f4e-48e4-9525-5d4e99fef16d"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4123), null, "david.martinez@example.com", "David", new Guid("10000000-0000-0000-0000-000000000003"), "Martinez" },
                    { new Guid("30c546b4-3aa4-413c-ad20-fa7995f58204"), new Guid("5fc8aa3e-4da7-4a26-a961-046cb3881f6d"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4286), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("32d3f4c5-cc1b-4735-9de2-33d15f21f57e"), new Guid("630e1c97-0e60-4b78-a321-cd25ce86e7e3"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4083), null, "noah.white@example.com", "Noah", new Guid("10000000-0000-0000-0000-000000000008"), "White" },
                    { new Guid("367ebccd-51d2-4e4c-b3ea-91cc11b6b9b2"), new Guid("f0029ae0-3d6e-44f0-a000-59e9379d78c1"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4297), null, "michael.brown@example.com", "Michael", new Guid("10000000-0000-0000-0000-000000000001"), "Brown" },
                    { new Guid("38b5756e-ef36-4469-9f29-c80b609c2f12"), new Guid("ce470e6d-3d74-4fac-b542-b21f9eb44186"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4062), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("39bfab60-d6e9-469f-9f16-05f3b259991c"), new Guid("e08e16b1-1a2d-4e4c-9b70-979d5cac1e6b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4217), null, "samuel.perez@example.com", "Samuel", new Guid("10000000-0000-0000-0000-000000000020"), "Perez" },
                    { new Guid("3a9ede9e-d039-49f9-815b-39e78b2a2eea"), new Guid("630e1c97-0e60-4b78-a321-cd25ce86e7e3"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4071), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("3ba4b10a-bf6a-4a6f-b123-8594b7150f1f"), new Guid("8d1ae803-e6e8-417f-96b6-94a00fbbbd89"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4147), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("3ccfc262-27d7-48d1-9cc9-77ba2f8107a2"), new Guid("ba91c424-b9d0-48ac-aceb-72d6438d1a28"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4200), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("3cd42438-6c4c-4cc3-8996-1dd612d84a0e"), new Guid("202e3ac6-1d44-4154-803c-2a8b74742f7c"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4259), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("405b89ad-4209-4c35-aea0-998e76998ec4"), new Guid("ba91c424-b9d0-48ac-aceb-72d6438d1a28"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4197), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("41e4d341-dc8b-443b-93de-572686c0ded0"), new Guid("e08e16b1-1a2d-4e4c-9b70-979d5cac1e6b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4203), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("449a0345-be8a-4e38-9000-8dc235eae561"), new Guid("fc35537a-4342-4234-a4d4-76022157d207"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4059), null, "emma.garcia@example.com", "Emma", new Guid("10000000-0000-0000-0000-000000000004"), "Garcia" },
                    { new Guid("44bc2eaf-64c3-4ee1-a831-d4928deb7b55"), new Guid("202e3ac6-1d44-4154-803c-2a8b74742f7c"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4271), null, "isaac.stewart@example.com", "Isaac", new Guid("10000000-0000-0000-0000-000000000026"), "Stewart" },
                    { new Guid("4858bf43-1460-466c-984b-6ce5722406aa"), new Guid("805fd53a-e4f4-47e3-8fe9-795bf5c50c3d"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4092), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("4891b81b-e1a7-4c0f-b8d8-22816b5526e8"), new Guid("ca0bfc7d-d69e-457e-a615-7bf76a7fe302"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4227), null, "charlotte.lee@example.com", "Charlotte", new Guid("10000000-0000-0000-0000-000000000011"), "Lee" },
                    { new Guid("4a3fddf5-ab7d-4804-8aea-1f8e0403d4d5"), new Guid("e08e16b1-1a2d-4e4c-9b70-979d5cac1e6b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4207), null, "james.anderson@example.com", "James", new Guid("10000000-0000-0000-0000-000000000005"), "Anderson" },
                    { new Guid("4a539104-647a-47b9-882d-6e23da3c89a1"), new Guid("5fc8aa3e-4da7-4a26-a961-046cb3881f6d"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4289), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("5051869b-1a99-4427-979e-aa5e110598b4"), new Guid("e08e16b1-1a2d-4e4c-9b70-979d5cac1e6b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4218), null, "lily.roberts@example.com", "Lily", new Guid("10000000-0000-0000-0000-000000000021"), "Roberts" },
                    { new Guid("5270716f-930b-4cbe-8e4b-a8ae81a9439f"), new Guid("202e3ac6-1d44-4154-803c-2a8b74742f7c"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4270), null, "hannah.collins@example.com", "Hannah", new Guid("10000000-0000-0000-0000-000000000025"), "Collins" },
                    { new Guid("5417a803-b2c1-4823-b08a-ba7a11b952a6"), new Guid("83d8a607-feba-465a-ac42-5d031446225a"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4141), null, "sarah.wilson@example.com", "Sarah", new Guid("10000000-0000-0000-0000-000000000002"), "Wilson" },
                    { new Guid("55244de2-ca4d-4503-b913-f4c672e018a7"), new Guid("f0029ae0-3d6e-44f0-a000-59e9379d78c1"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4294), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("555d7f4f-5e61-4709-804d-bad32d2653df"), new Guid("0f8e5c73-05d1-46c9-9b2d-e65aea98c80a"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4033), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("56412e32-cd2c-42be-a92e-cfbc3da7b035"), new Guid("f0029ae0-3d6e-44f0-a000-59e9379d78c1"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4295), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("57dcaf9c-0e45-4f1d-8216-536aa65ca5ac"), new Guid("630e1c97-0e60-4b78-a321-cd25ce86e7e3"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4073), null, "sophia.jackson@example.com", "Sophia", new Guid("10000000-0000-0000-0000-000000000007"), "Jackson" },
                    { new Guid("59e4743e-26ee-453f-a6bb-02d442c35be2"), new Guid("3aa1f8da-c834-4c99-9559-8d32db64e337"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4170), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("5f8d1844-4fd9-41d2-8204-2f9f49130218"), new Guid("05534e12-a419-4a80-9299-8677f17879dc"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4285), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("6079475a-f4ef-4aa4-bda0-1d5509f18ae3"), new Guid("e08e16b1-1a2d-4e4c-9b70-979d5cac1e6b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4206), null, "david.martinez@example.com", "David", new Guid("10000000-0000-0000-0000-000000000003"), "Martinez" },
                    { new Guid("61494a35-26ad-4add-a8c3-76a55e5dcf64"), new Guid("d5610a25-697b-4e79-8751-9c501c07c89b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4112), null, "ethan.walker@example.com", "Ethan", new Guid("10000000-0000-0000-0000-000000000012"), "Walker" },
                    { new Guid("64625196-f130-48e9-9098-dcc0e2c0444e"), new Guid("4d0043a3-b721-4d5e-ae48-330f64a37ea8"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4166), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("68b1a4eb-dafc-43bc-9caa-b73839a8099b"), new Guid("ca0bfc7d-d69e-457e-a615-7bf76a7fe302"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4226), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("6df3109e-e47c-4f59-bcfc-49b399459d8d"), new Guid("202e3ac6-1d44-4154-803c-2a8b74742f7c"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4269), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("6e09214b-cb58-4251-8e11-775d6a60c106"), new Guid("ca0bfc7d-d69e-457e-a615-7bf76a7fe302"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4229), null, "jackson.campbell@example.com", "Jackson", new Guid("10000000-0000-0000-0000-000000000023"), "Campbell" },
                    { new Guid("6e375e58-9a07-452a-bfd3-96be1cc8bb95"), new Guid("5fc8aa3e-4da7-4a26-a961-046cb3881f6d"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4293), null, "scarlett.cook@example.com", "Scarlett", new Guid("10000000-0000-0000-0000-000000000028"), "Cook" },
                    { new Guid("71bf4aff-6bf0-4824-9878-21ce8d115c9f"), new Guid("fc35537a-4342-4234-a4d4-76022157d207"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4057), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("72bcf2a2-0b55-49a6-bf32-6713495b2be9"), new Guid("7d595805-51f8-45f3-9652-d1b9336689f6"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4066), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("758ff923-edb4-4a80-af75-d84c0a3761e3"), new Guid("3dd4a1ef-9eaf-46cd-93ab-efc323f7c114"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4245), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("7c7e145f-e5a1-4892-94bd-23a93310d38d"), new Guid("8d1ae803-e6e8-417f-96b6-94a00fbbbd89"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4146), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("7dc117e1-9f66-41ad-b3b0-8a20295a9d9d"), new Guid("69355c02-06d9-4c07-af4c-5e44e9f82282"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4282), null, "evelyn.hill@example.com", "Evelyn", new Guid("10000000-0000-0000-0000-000000000016"), "Hill" },
                    { new Guid("828fe674-103b-4463-9169-f9dd73aa51d9"), new Guid("fc4b234d-2b08-4106-9af9-4830406e713b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4088), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("83520fd6-d45e-4da6-a481-56e0a386acfe"), new Guid("23c1e0ed-74ab-47ad-b2ed-9ecce8b99d97"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4223), null, "matthew.turner@example.com", "Matthew", new Guid("10000000-0000-0000-0000-000000000022"), "Turner" },
                    { new Guid("84226374-533f-4028-909c-687f58c9753a"), new Guid("3dd4a1ef-9eaf-46cd-93ab-efc323f7c114"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4248), null, "ryan.evans@example.com", "Ryan", new Guid("10000000-0000-0000-0000-000000000024"), "Evans" },
                    { new Guid("8432c00a-693c-4bea-8615-966055fe8749"), new Guid("ca0bfc7d-d69e-457e-a615-7bf76a7fe302"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4225), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("85671f3f-a9ff-4966-ae89-e91c76fdb8d7"), new Guid("69355c02-06d9-4c07-af4c-5e44e9f82282"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4278), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("881451d8-eac6-487d-8acf-ab8c1205547f"), new Guid("e08e16b1-1a2d-4e4c-9b70-979d5cac1e6b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4204), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("883b1a33-2b61-43e9-8409-391311cef80a"), new Guid("fc4b234d-2b08-4106-9af9-4830406e713b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4090), null, "william.martin@example.com", "William", new Guid("10000000-0000-0000-0000-000000000009"), "Martin" },
                    { new Guid("891d73a1-38ab-42e7-8d2f-f8926841c2a1"), new Guid("dd90b841-5d30-4235-a29c-046e8da496b1"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4277), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("899f0ae4-d09d-4c8f-bb96-86051269a1e7"), new Guid("83d8a607-feba-465a-ac42-5d031446225a"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4138), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("91c9854c-34eb-4094-afc7-84d1193816d5"), new Guid("492f8a7d-abd8-4dda-9237-eb9eccfc6be5"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4151), null, "henry.scott@example.com", "Henry", new Guid("10000000-0000-0000-0000-000000000017"), "Scott" },
                    { new Guid("92077a22-4bae-4d01-8cb0-0154e89d5d82"), new Guid("7058015f-33ca-4da7-8b5d-a8d63dfd21b5"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4257), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("958f3ab1-83dd-4cb4-97ab-322bf8345452"), new Guid("630e1c97-0e60-4b78-a321-cd25ce86e7e3"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4069), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("960ef1cb-8600-42ed-8518-5d29ca3896bf"), new Guid("d5610a25-697b-4e79-8751-9c501c07c89b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4114), null, "amelia.hall@example.com", "Amelia", new Guid("10000000-0000-0000-0000-000000000013"), "Hall" },
                    { new Guid("9dcc1724-de84-4405-9c83-72fc4d1aaad0"), new Guid("f77b8c32-37d5-4259-9f5c-00242d6ed13a"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4126), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("a1ce9857-49dc-4999-80ce-11ab54937ff1"), new Guid("7d595805-51f8-45f3-9652-d1b9336689f6"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4068), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("a2aba7bf-0c05-4fae-9aeb-f4a8f58b9968"), new Guid("fc35537a-4342-4234-a4d4-76022157d207"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4044), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("a3884dd4-4262-4e15-a55c-ef10586df099"), new Guid("83d8a607-feba-465a-ac42-5d031446225a"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4144), null, "james.anderson@example.com", "James", new Guid("10000000-0000-0000-0000-000000000005"), "Anderson" },
                    { new Guid("a90fc315-648d-4e30-9cb1-b3bfba096436"), new Guid("fc4b234d-2b08-4106-9af9-4830406e713b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4085), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("a9cc9a10-e606-4907-acdc-5c3f8e946566"), new Guid("69355c02-06d9-4c07-af4c-5e44e9f82282"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4281), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("ab45bef3-dfaa-4a25-8b05-b404eae9f3b0"), new Guid("dd90b841-5d30-4235-a29c-046e8da496b1"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4275), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("ab8656c9-d533-4626-b994-3dd6fcb87c39"), new Guid("ce470e6d-3d74-4fac-b542-b21f9eb44186"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4063), null, "sarah.wilson@example.com", "Sarah", new Guid("10000000-0000-0000-0000-000000000002"), "Wilson" },
                    { new Guid("ada4cc12-0e47-4cdd-b529-14fae9f54c49"), new Guid("417fed05-5862-48f7-ae02-179cc7c79c71"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4250), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("ae80eadb-7acb-4189-82ee-c4759c0cb3c6"), new Guid("05534e12-a419-4a80-9299-8677f17879dc"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4284), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("af8165b5-0316-465b-a8fc-ef83ff2fe8f7"), new Guid("fc35537a-4342-4234-a4d4-76022157d207"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4060), null, "james.anderson@example.com", "James", new Guid("10000000-0000-0000-0000-000000000005"), "Anderson" },
                    { new Guid("b97e0c4d-0094-43ba-adf4-75061b8f5d77"), new Guid("805fd53a-e4f4-47e3-8fe9-795bf5c50c3d"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4094), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("ba23dcba-9d9c-4143-ba7f-5b40995d51b7"), new Guid("83d8a607-feba-465a-ac42-5d031446225a"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4145), null, "evelyn.hill@example.com", "Evelyn", new Guid("10000000-0000-0000-0000-000000000016"), "Hill" },
                    { new Guid("bc06a49b-4621-4829-a718-cc9356a192f6"), new Guid("0f8e5c73-05d1-46c9-9b2d-e65aea98c80a"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4035), null, "michael.brown@example.com", "Michael", new Guid("10000000-0000-0000-0000-000000000001"), "Brown" },
                    { new Guid("befcac07-c759-499c-bc0e-e3b4f0c30198"), new Guid("accb2146-ab97-4947-8c4f-00b65fdff3ce"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4230), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("c1e982ec-a37f-4b69-85d2-8c3399ddc76c"), new Guid("3aa1f8da-c834-4c99-9559-8d32db64e337"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4172), null, "michael.brown@example.com", "Michael", new Guid("10000000-0000-0000-0000-000000000001"), "Brown" },
                    { new Guid("c40f29ba-2b16-4823-a941-a2cea3415da9"), new Guid("5fc8aa3e-4da7-4a26-a961-046cb3881f6d"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4290), null, "david.martinez@example.com", "David", new Guid("10000000-0000-0000-0000-000000000003"), "Martinez" },
                    { new Guid("c4423572-fd76-45b6-8f0f-ed45a9dcba16"), new Guid("492f8a7d-abd8-4dda-9237-eb9eccfc6be5"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4153), null, "ella.green@example.com", "Ella", new Guid("10000000-0000-0000-0000-000000000018"), "Green" },
                    { new Guid("c6f5f166-090f-4dc1-87b1-bae870909df7"), new Guid("3dd4a1ef-9eaf-46cd-93ab-efc323f7c114"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4246), null, "ella.green@example.com", "Ella", new Guid("10000000-0000-0000-0000-000000000018"), "Green" },
                    { new Guid("c70b1b83-4187-4b79-a75e-656c5ac3143f"), new Guid("4d0043a3-b721-4d5e-ae48-330f64a37ea8"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4167), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("ca12990c-a2ba-4e6d-9d5d-42cdd9198e9f"), new Guid("fc4b234d-2b08-4106-9af9-4830406e713b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4089), null, "emma.garcia@example.com", "Emma", new Guid("10000000-0000-0000-0000-000000000004"), "Garcia" },
                    { new Guid("cfa6598a-4c7e-4983-b43d-20119a953db0"), new Guid("492f8a7d-abd8-4dda-9237-eb9eccfc6be5"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4156), null, "emma.garcia@example.com", "Emma", new Guid("10000000-0000-0000-0000-000000000004"), "Garcia" },
                    { new Guid("d0adfdd2-ab86-4007-8cb9-40843592258c"), new Guid("3aa1f8da-c834-4c99-9559-8d32db64e337"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4173), null, "daniel.nelson@example.com", "Daniel", new Guid("10000000-0000-0000-0000-000000000019"), "Nelson" },
                    { new Guid("d28b5083-31e2-449d-b1ee-37a31413245e"), new Guid("207403de-e129-4985-b6e2-b4dba076be82"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4253), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("d2e27f8a-a681-49c3-b2a0-babbc4096f17"), new Guid("630e1c97-0e60-4b78-a321-cd25ce86e7e3"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4072), null, "liam.thomas@example.com", "Liam", new Guid("10000000-0000-0000-0000-000000000006"), "Thomas" },
                    { new Guid("d43f674a-ea92-4aba-bc09-a927d5c1bf8d"), new Guid("207403de-e129-4985-b6e2-b4dba076be82"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4255), null, "sarah.wilson@example.com", "Sarah", new Guid("10000000-0000-0000-0000-000000000002"), "Wilson" },
                    { new Guid("d52b1c9d-eb81-4cd2-9ebf-2e1a3b349332"), new Guid("fc35537a-4342-4234-a4d4-76022157d207"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4058), null, "david.martinez@example.com", "David", new Guid("10000000-0000-0000-0000-000000000003"), "Martinez" },
                    { new Guid("d5396665-2af9-4ddc-a587-8af37d98f27b"), new Guid("0f8e5c73-05d1-46c9-9b2d-e65aea98c80a"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(3956), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("d91e9e51-8f9c-4e9e-9a44-3ddd7b39fc0d"), new Guid("492f8a7d-abd8-4dda-9237-eb9eccfc6be5"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4149), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("d98fad0d-e7e3-4ff2-ab6d-9abf4b614052"), new Guid("d5610a25-697b-4e79-8751-9c501c07c89b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4111), null, "charlotte.lee@example.com", "Charlotte", new Guid("10000000-0000-0000-0000-000000000011"), "Lee" },
                    { new Guid("db5ed79f-5a8e-449c-bc82-350984aa90cf"), new Guid("805fd53a-e4f4-47e3-8fe9-795bf5c50c3d"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4095), null, "isabella.thompson@example.com", "Isabella", new Guid("10000000-0000-0000-0000-000000000010"), "Thompson" },
                    { new Guid("dd993e6c-f763-4231-a061-66d1656fdc69"), new Guid("f77b8c32-37d5-4259-9f5c-00242d6ed13a"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4125), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("dfb56d9a-3fce-4c15-ac93-d0e6201c1b00"), new Guid("202e3ac6-1d44-4154-803c-2a8b74742f7c"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4273), null, "ethan.walker@example.com", "Ethan", new Guid("10000000-0000-0000-0000-000000000012"), "Walker" },
                    { new Guid("e2811cf7-acd9-452a-9b21-9f1278b582e9"), new Guid("23c1e0ed-74ab-47ad-b2ed-9ecce8b99d97"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4219), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("e697a966-ed8a-4cb7-88dd-f84a795b1682"), new Guid("d5610a25-697b-4e79-8751-9c501c07c89b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4098), new Guid("e264cae1-afd4-441f-980b-fe47baf5bf51"), null, null, null, null },
                    { new Guid("e7adac48-fdbd-4c7a-a9a0-2fc16b02756b"), new Guid("417fed05-5862-48f7-ae02-179cc7c79c71"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4249), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("eae3bd96-f5a7-4333-8955-845e2fcc91ed"), new Guid("207403de-e129-4985-b6e2-b4dba076be82"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4251), new Guid("8c965145-0305-4c1f-8456-f73495e4bed0"), null, null, null, null },
                    { new Guid("f161de15-0590-4993-94e5-a07337149418"), new Guid("0f8e5c73-05d1-46c9-9b2d-e65aea98c80a"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4043), null, "sarah.wilson@example.com", "Sarah", new Guid("10000000-0000-0000-0000-000000000002"), "Wilson" },
                    { new Guid("f5e6c64d-8722-4fee-9b74-2a5fad7c7f85"), new Guid("3aa1f8da-c834-4c99-9559-8d32db64e337"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4169), new Guid("156156c5-b131-425a-bed4-7cfaaa7434bd"), null, null, null, null },
                    { new Guid("f79b901d-fdbe-46a0-82aa-7aa3343ba56d"), new Guid("d5610a25-697b-4e79-8751-9c501c07c89b"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4101), null, "michael.brown@example.com", "Michael", new Guid("10000000-0000-0000-0000-000000000001"), "Brown" },
                    { new Guid("fa9af00d-f12c-4009-ac2c-7d7073f9b180"), new Guid("f77b8c32-37d5-4259-9f5c-00242d6ed13a"), null, new DateTime(2025, 10, 20, 16, 20, 18, 230, DateTimeKind.Utc).AddTicks(4127), null, "lucas.king@example.com", "Lucas", new Guid("10000000-0000-0000-0000-000000000015"), "King" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipants_EventId1",
                table: "EventParticipants",
                column: "EventId1");

            migrationBuilder.AddForeignKey(
                name: "FK_EventParticipants_Events_EventId1",
                table: "EventParticipants",
                column: "EventId1",
                principalTable: "Events",
                principalColumn: "Id");
        }
    }
}
