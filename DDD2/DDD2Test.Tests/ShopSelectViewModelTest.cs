using DDD2.Domain.Entities;
using DDD2.Domain.Repositories;
using DDD2.WinForm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace DDD2Test.Tests
{
    [TestClass]
    public class ShopSelectViewModelTest
    {
        [TestMethod]
        public void お店選択画面シナリオ()
        {

            var shopList = new List<ShopEntity>();
            shopList.Add(new ShopEntity(1, "ルタオ", 1, "道央", 3000));
            shopList.Add(new ShopEntity(2, "六花亭", 2, "道東", 3900));
            shopList.Add(new ShopEntity(3, "柳月", 2, "道東", 1000));
            shopList.Add(new ShopEntity(4, "きのとや", 1, "道央", 5000));

            var shopMock = new Mock<IShopRepository>();
            shopMock.Setup(x => x.GetDataSingle(1)).Returns(
                shopList[0]
            );
            shopMock.Setup(x => x.GetDataSingle(2)).Returns(
                shopList[1]
            );

            shopMock.Setup(x => x.GetData()).Returns(shopList);


            var locationList = new List<LocationEntity>();
            locationList.Add(new LocationEntity(1, "道央"));
            locationList.Add(new LocationEntity(2, "道東"));

            var locationMock = new Mock<ILocationRepository>();
            locationMock.Setup(x => x.GetData()).Returns(locationList);

            var viewModel = new ShopSelectViewModel(shopMock.Object, locationMock.Object);


            //初期値は空
            Assert.AreEqual("", viewModel.SelectedShopId);
            Assert.AreEqual("", viewModel.ShopNameText);
            Assert.AreEqual("", viewModel.LocationNameText);
            Assert.AreEqual("", viewModel.ProfitText);

            Assert.AreEqual(4, viewModel.Shops.Count);
            Assert.AreEqual(2, viewModel.Locations.Count);
            Assert.AreEqual(1, viewModel.Locations[0].LocationId);
            Assert.AreEqual("道央", viewModel.Locations[0].LocationName);
            Assert.AreEqual(2, viewModel.Locations[1].LocationId);
            Assert.AreEqual("道東", viewModel.Locations[1].LocationName);


            //1を入れて、ボタンを押すと、
            viewModel.SelectedShopId = "1";
            viewModel.Search();

            //表示が変更される
            Assert.AreEqual("1", viewModel.SelectedShopId);
            Assert.AreEqual("ルタオ", viewModel.ShopNameText);
            Assert.AreEqual("道央", viewModel.LocationNameText);
            Assert.AreEqual("3000", viewModel.ProfitText);

        }
    }
}
