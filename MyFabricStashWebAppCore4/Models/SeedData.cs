using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MyFabricStashWebAppCore4.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Fabrics.Any())
            {
                context.Fabrics.AddRange(
                    new Fabric
                    {
                        ItemCode = GenerateItemCode(),
                        Name = "TestFabricName1",
                        MainCategory = "TestMainCategory1",
                        SubCategory = "TestSubCategory1",
                        ImagePath = "https://via.placeholder.com/100x100.jpg?text=Test+1",
                        Type = "TestType1",
                        Weight = "TestWeight1",
                        Content = "TestContent1",
                        Design = "TestDesign1",
                        Brand = "TestBrand1",
                        Width = 40,
                        Colors = "TestColor1, TestColor2, TestColor3",
                        BackgroundColor = "TestBkgrdColor1",
                        Notes = "These are some test notes."
                    },
                    new Fabric
                    {
                        ItemCode = GenerateItemCode(),
                        Name = "TestFabricName2",
                        MainCategory = "TestMainCategory2",
                        SubCategory = "TestSubCategory2",
                        ImagePath = "https://via.placeholder.com/100x100.jpg?text=Test+2",
                        Type = "TestType2",
                        Weight = "TestWeight2",
                        Content = "TestContent2",
                        Design = "TestDesign2",
                        Brand = "TestBrand2",
                        Width = 40,
                        Colors = "TestColor1, TestColor2, TestColor3",
                        BackgroundColor = "TestBkgrdColor2",
                        Notes = "These are some test notes."
                    },
                    new Fabric
                    {
                        ItemCode = GenerateItemCode(),
                        Name = "TestFabricName3",
                        MainCategory = "TestMainCategory3",
                        SubCategory = "TestSubCategory3",
                        ImagePath = "https://via.placeholder.com/100x100.jpg?text=Test+3",
                        Type = "TestType3",
                        Weight = "TestWeight3",
                        Content = "TestContent3",
                        Design = "TestDesign3",
                        Brand = "TestBrand3",
                        Width = 40,
                        Colors = "TestColor1, TestColor2, TestColor3",
                        BackgroundColor = "TestBkgrdColor3",
                        Notes = "These are some test notes."
                    },
                    new Fabric
                    {
                        ItemCode = GenerateItemCode(),
                        Name = "TestFabricName4",
                        MainCategory = "TestMainCategory4",
                        SubCategory = "TestSubCategory4",
                        ImagePath = "https://via.placeholder.com/100x100.jpg?text=Test+4",
                        Type = "TestType4",
                        Weight = "TestWeight4",
                        Content = "TestContent4",
                        Design = "TestDesign4",
                        Brand = "TestBrand4",
                        Width = 40,
                        Colors = "TestColor1, TestColor2, TestColor3",
                        BackgroundColor = "TestBkgrdColor4",
                        Notes = "These are some test notes."
                    },
                    new Fabric
                    {
                        ItemCode = GenerateItemCode(),
                        Name = "TestFabricName5",
                        MainCategory = "TestMainCategory5",
                        SubCategory = "TestSubCategory5",
                        ImagePath = "https://via.placeholder.com/100x100.jpg?text=Test+5",
                        Type = "TestType5",
                        Weight = "TestWeight5",
                        Content = "TestContent5",
                        Design = "TestDesign5",
                        Brand = "TestBrand5",
                        Width = 40,
                        Colors = "TestColor1, TestColor2, TestColor3",
                        BackgroundColor = "TestBkgrdColor5",
                        Notes = "These are some test notes."
                    },
                    new Fabric
                    {
                        ItemCode = GenerateItemCode(),
                        Name = "TestFabricName6",
                        MainCategory = "TestMainCategory6",
                        SubCategory = "TestSubCategory6",
                        ImagePath = "https://via.placeholder.com/100x100.jpg?text=Test+6",
                        Type = "TestType6",
                        Weight = "TestWeight6",
                        Content = "TestContent6",
                        Design = "TestDesign6",
                        Brand = "TestBrand6",
                        Width = 40,
                        Colors = "TestColor1, TestColor2, TestColor3",
                        BackgroundColor = "TestBkgrdColor6",
                        Notes = "These are some test notes."
                    },
                    new Fabric
                    {
                        ItemCode = GenerateItemCode(),
                        Name = "TestFabricName7",
                        MainCategory = "TestMainCategory7",
                        SubCategory = "TestSubCategory7",
                        ImagePath = "https://via.placeholder.com/100x100.jpg?text=Test+7",
                        Type = "TestType7",
                        Weight = "TestWeight7",
                        Content = "TestContent7",
                        Design = "TestDesign7",
                        Brand = "TestBrand7",
                        Width = 40,
                        Colors = "TestColor1, TestColor2, TestColor3",
                        BackgroundColor = "TestBkgrdColor7",
                        Notes = "These are some test notes."
                    },
                    new Fabric
                    {
                        ItemCode = GenerateItemCode(),
                        Name = "TestFabricName8",
                        MainCategory = "TestMainCategory8",
                        SubCategory = "TestSubCategory8",
                        ImagePath = "https://via.placeholder.com/100x100.jpg?text=Test+8",
                        Type = "TestType8",
                        Weight = "TestWeight8",
                        Content = "TestContent8",
                        Design = "TestDesign8",
                        Brand = "TestBrand8",
                        Width = 40,
                        Colors = "TestColor1, TestColor2, TestColor3",
                        BackgroundColor = "TestBkgrdColor8",
                        Notes = "These are some test notes."
                    },
                    new Fabric
                    {
                        ItemCode = GenerateItemCode(),
                        Name = "TestFabricName9",
                        MainCategory = "TestMainCategory9",
                        SubCategory = "TestSubCategory9",
                        ImagePath = "https://via.placeholder.com/100x100.jpg?text=Test+9",
                        Type = "TestType9",
                        Weight = "TestWeight9",
                        Content = "TestContent9",
                        Design = "TestDesign9",
                        Brand = "TestBrand9",
                        Width = 40,
                        Colors = "TestColor1, TestColor2, TestColor3",
                        BackgroundColor = "TestBkgrdColor9",
                        Notes = "These are some test notes."
                    },
                    new Fabric
                    {
                        ItemCode = GenerateItemCode(),
                        Name = "TestFabricName10",
                        MainCategory = "TestMainCategory10",
                        SubCategory = "TestSubCategory10",
                        ImagePath = "https://via.placeholder.com/100x100.jpg?text=Test+10",
                        Type = "TestType10",
                        Weight = "TestWeight10",
                        Content = "TestContent10",
                        Design = "TestDesign10",
                        Brand = "TestBrand10",
                        Width = 40,
                        Colors = "TestColor1, TestColor2, TestColor3",
                        BackgroundColor = "TestBkgrdColor10",
                        Notes = "These are some test notes."
                    }
                );
                context.SaveChanges();
            }
        } //end EnsurePopulated
        private static string GenerateItemCode()
        {

            string itemCode = Guid.NewGuid().ToString().Replace("-", string.Empty).Replace("+", string.Empty).Substring(0, 6).ToUpper();

            return itemCode;
        }
    }
}
