using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsCatalog.Persistance.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyLogo", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "ShortDescription", "StatusId" },
                values: new object[,]
                {
                    { 5, "SoftMatter", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 726, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 0, 0, 0, 0)), "Admin", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 726, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Soft Matter", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.", 1 },
                    { 3, "Creativity", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 726, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 0, 0, 0, 0)), "Admin", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 726, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Creativity", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.", 1 },
                    { 2, "SwissUnionBank", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 726, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 0, 0, 0, 0)), "Admin", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 726, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Swiss Union Bank", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.", 1 },
                    { 1, "SoftwareSolution", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 726, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 0, 0, 0, 0)), "Admin", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 726, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Software Solution", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.", 1 },
                    { 4, "ItOpportunity", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 726, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 0, 0, 0, 0)), "Admin", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 726, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "It Opportunity", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dignissim nulla tempor, varius neque at, bibendum mi. Suspendisse efficitur blandit pharetra. Quisque non commodo ante, ut volutpat arcu. Vestibulum mi magna, commodo nec dolor vitae, gravida sagittis nisi. Phasellus vulputate, dolor eget cursus dignissim, ligula augue porta ante, sit amet semper lacus enim ac tortor. Nullam congue auctor erat, volutpat pharetra tellus pretium dignissim.", 1 }
                });

            migrationBuilder.InsertData(
                table: "ExperienceLeves",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Junior" },
                    { 2, "Mid" },
                    { 3, "Senior" },
                    { 4, "Expert" }
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 3, "Python", "Python" },
                    { 4, "JavaScript", "JavaScript" },
                    { 5, "CPlusPlus", "C++" },
                    { 1, "CSharp", "C#" },
                    { 2, "Java", "Java" }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 19, "C++ 17" },
                    { 18, "Django" },
                    { 17, "Flask" },
                    { 16, "AWS" },
                    { 15, "Moq" },
                    { 14, "XUnit" },
                    { 13, "Mockito" },
                    { 11, "Spring" },
                    { 10, "Hibernate" },
                    { 9, "Angular" },
                    { 7, "Docker" },
                    { 6, "Azure" },
                    { 5, "CSS" },
                    { 4, "HTML" },
                    { 3, "Entity Framwork" },
                    { 2, "SQL" },
                    { 1, "ASP.Net" },
                    { 12, "JUnit" },
                    { 8, "React" }
                });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "City", "CompanyId", "Created", "CreatedBy", "ExperienceLevelId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PositionName", "ProgrammingLanguageId", "SalaryMax", "SalaryMin", "StatusId" },
                values: new object[,]
                {
                    { 1, "Wroclaw", 1, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Junior .Net Developer", 1, 8000, 6000, 1 },
                    { 2, "Wroclaw", 2, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", ".Net Developer", 1, 15000, 10000, 1 },
                    { 4, "Warsaw", 2, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Java Developer", 2, 15000, 10000, 1 },
                    { 5, "Warsaw", 2, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Senior Java Developer", 2, 20000, 15000, 1 },
                    { 6, "Warsaw", 2, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Java Tech Lead", 2, 30000, 20000, 1 },
                    { 3, "Wroclaw", 3, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Senior .Net Developer", 1, 20000, 15000, 1 },
                    { 7, "Remote", 3, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", ".Net Developer", 1, 15000, 10000, 1 },
                    { 8, "Poznan", 3, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Python Developer", 3, 15000, 10000, 1 },
                    { 9, "Remote", 4, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "C++ Tech Lead", 5, 30000, 20000, 1 },
                    { 10, "Poznan", 4, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Junior JavaScript Developer", 4, 8000, 6000, 1 },
                    { 11, "Gdansk", 4, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Senior JavaScript Developer", 4, 20000, 15000, 1 },
                    { 12, "Katowice", 4, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Java Tech Lead", 2, 30000, 20000, 1 },
                    { 13, "Crakow", 5, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", ".Net Tech Lead", 1, 30000, 20000, 1 },
                    { 14, "Remote", 5, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Python Developer", 3, 15000, 10000, 1 },
                    { 15, "Crakow", 5, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 727, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "JavaScript Developer", 4, 15000, 10000, 1 }
                });

            migrationBuilder.InsertData(
                table: "JobDescriptions",
                columns: new[] { "Id", "About", "Created", "CreatedBy", "Expectation", "Inactivated", "InactivatedBy", "JobOfferId", "Modified", "ModifiedBy", "Offer", "Responsibilities", "StatusId" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 1, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 10, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 10, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 8, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 11, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 11, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 7, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 7, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 12, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 12, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 3, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 6, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 13, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 13, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 5, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 14, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 14, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 9, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 9, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 4, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 2, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 },
                    { 15, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id viverra erat. Nulla euismod laoreet metus vitae mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nulla maximus libero non elementum congue. Vestibulum dignissim pellentesque mauris non molestie. Aliquam neque ligula, rutrum at tincidunt ut, fringilla posuere risus. Aenean porta convallis turpis, et ornare nisl finibus ac. Maecenas volutpat tortor vel sagittis aliquam.", new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nam ut justo id nisl egestas mattis.Proin ac ipsum eget velit varius pretium.Nam porta ligula vitae diam auctor dictum.Nulla varius nunc in velit ultrices ullamcorper.", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 15, new DateTimeOffset(new DateTime(2022, 1, 30, 18, 37, 15, 728, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "Admin", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas in lacus id ex iaculis iaculis vel ac metus.Morbi ut tellus accumsan, vehicula mi volutpat, lobortis leo.Aenean sodales massa ac risus tincidunt, in malesuada est tincidunt.Donec eget turpis tincidunt, tempus erat at, venenatis erat.Duis ultricies dui ac tempor placerat.Cras sollicitudin ligula in turpis aliquam luctus at quis lacus.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lorem lorem, volutpat facilisis fringilla et, molestie in nunc. Cras ac nunc imperdiet, euismod lorem vitae, maximus nulla. Etiam porttitor elit vitae purus dapibus consectetur. Fusce imperdiet turpis a lectus scelerisque, vel ultrices odio vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque nisi nisl, fringilla in luctus eget, cursus congue augue. Integer condimentum sollicitudin nunc in tristique. Integer id justo leo. Morbi vel lacus sagittis, venenatis ex eget, porta risus. Nunc suscipit dignissim magna at commodo. Sed iaculis, turpis quis ornare luctus, massa orci tempor tellus, consequat gravida nisi nibh et dui. Integer eu metus sem. Morbi auctor ex est, vel aliquam arcu vulputate eu. Fusce aliquam eros quis ipsum iaculis aliquet. Nullam et auctor lorem, sit amet tempor lorem. Praesent nec nisl in ipsum accumsan sollicitudin.", 1 }
                });

            migrationBuilder.InsertData(
                table: "JobOfferTechnologies",
                columns: new[] { "JobOfferId", "TechnologyId" },
                values: new object[,]
                {
                    { 11, 16 },
                    { 11, 7 },
                    { 11, 6 },
                    { 11, 13 },
                    { 11, 12 },
                    { 11, 11 },
                    { 11, 10 },
                    { 10, 9 },
                    { 10, 8 },
                    { 10, 5 },
                    { 15, 4 },
                    { 10, 4 },
                    { 15, 5 },
                    { 14, 16 },
                    { 13, 7 },
                    { 14, 7 },
                    { 12, 2 },
                    { 13, 6 },
                    { 13, 15 },
                    { 13, 14 },
                    { 14, 17 },
                    { 13, 3 },
                    { 13, 2 },
                    { 13, 1 },
                    { 14, 18 },
                    { 12, 16 },
                    { 14, 2 }
                });

            migrationBuilder.InsertData(
                table: "JobOfferTechnologies",
                columns: new[] { "JobOfferId", "TechnologyId" },
                values: new object[,]
                {
                    { 12, 7 },
                    { 9, 19 },
                    { 12, 15 },
                    { 12, 14 },
                    { 12, 3 },
                    { 12, 1 },
                    { 12, 6 },
                    { 8, 18 },
                    { 8, 7 },
                    { 5, 2 },
                    { 5, 13 },
                    { 5, 12 },
                    { 5, 11 },
                    { 5, 10 },
                    { 4, 2 },
                    { 4, 13 },
                    { 4, 12 },
                    { 6, 10 },
                    { 4, 11 },
                    { 2, 15 },
                    { 2, 14 },
                    { 2, 3 },
                    { 2, 2 },
                    { 2, 1 },
                    { 1, 3 },
                    { 1, 2 },
                    { 1, 1 },
                    { 4, 10 },
                    { 8, 16 },
                    { 6, 11 },
                    { 6, 13 },
                    { 8, 2 },
                    { 15, 8 },
                    { 8, 17 },
                    { 7, 7 },
                    { 7, 6 },
                    { 7, 15 },
                    { 7, 14 },
                    { 7, 3 },
                    { 6, 12 },
                    { 7, 2 },
                    { 3, 15 }
                });

            migrationBuilder.InsertData(
                table: "JobOfferTechnologies",
                columns: new[] { "JobOfferId", "TechnologyId" },
                values: new object[,]
                {
                    { 3, 14 },
                    { 3, 3 },
                    { 3, 2 },
                    { 3, 1 },
                    { 6, 7 },
                    { 6, 6 },
                    { 6, 2 },
                    { 7, 1 },
                    { 15, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 8, 18 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 9, 19 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 11, 12 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 11, 16 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 13, 15 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 14, 16 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 14, 17 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 14, 18 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "JobOfferTechnologies",
                keyColumns: new[] { "JobOfferId", "TechnologyId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExperienceLeves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExperienceLeves",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExperienceLeves",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExperienceLeves",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
