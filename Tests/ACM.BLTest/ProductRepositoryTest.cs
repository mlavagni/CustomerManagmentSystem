﻿using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted sizes",
                ProductName = "Sunflowers"
            };
            //--Act
            var actual = productRepository.Retrieve(2);
            //--Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);

        }


        [TestMethod]
        public void SaveTestValid()
        {
            //--Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "tomatoes",
                ProductName = "Sunflowers",
                HasChanges = true
            };
            //--Act
            var actual = productRepository.Save(updateProduct);
            //--Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveMissingPrice()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "tomatoes",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //-- Assert
            Assert.AreEqual(false, actual);
        }
    }
}
