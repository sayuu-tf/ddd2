﻿using DDD2.Domain.Entities;
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

            var shopMock = new Mock<IShopRepository>();
            shopMock.Setup(x => x.GetDataSingle(1)).Returns(
                new ShopEntity(1, "ルタオ", 1, "小樽")
            );
            shopMock.Setup(x => x.GetDataSingle(2)).Returns(
                new ShopEntity(2, "六花亭", 2, "帯広")
            );

            var viewModel = new ShopSelectViewModel(shopMock.Object);


            //初期値は空
            Assert.AreEqual("", viewModel.SelectedShopId);
            Assert.AreEqual("", viewModel.ShopNameText);
            Assert.AreEqual("", viewModel.LocationNameText);            

            //1を入れて、ボタンを押すと、
            viewModel.SelectedShopId = "1";
            viewModel.Search();

            //表示が変更される
            Assert.AreEqual("1", viewModel.SelectedShopId);
            Assert.AreEqual("ルタオ", viewModel.ShopNameText);
            Assert.AreEqual("小樽", viewModel.LocationNameText);

        }
    }
}
