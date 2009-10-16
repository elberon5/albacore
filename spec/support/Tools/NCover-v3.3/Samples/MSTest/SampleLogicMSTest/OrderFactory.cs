﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObjects;

namespace SampleLogicMSTest {

    /// <summary>
    /// Static Methods to allow you to obtain orders based on your needs.
    /// </summary>
    public static class OrderFactory {

        /// <summary>
        /// The purpose of this is to show no coverage, that the lamba will show no coverage and no coverage exists for products.
        /// </summary>
        /// <returns></returns>
        public static Order GetOrderNoItemsNoProductsNoCustomer(DateTime orderDate) {
            Order retVal = new Order();
            retVal.OrderID = 1;
            retVal.OrderDate = orderDate;
            return retVal;
        }

        public static Order GetOrderWithItemsAndProductAndCustomer(DateTime orderDate) {
            Order retVal = new Order();
            retVal.OrderID = 1;
            retVal.OrderDate = orderDate;
            retVal.Customer = GetCustomer1();
            retVal.OrderDetails.Add(GetOrderDetail1());
            retVal.OrderDetails.Add(GetOrderDetail2());

            return retVal;
        }

        public static Customer GetCustomer1() {
            var retVal = new Customer() {
                CustomerId = 1,
                CustomerName = "Customer 1"
            };
            return retVal;
        }

        public static Product GetProduct1() {
            //show that you can get coverage on property initializers.
            var retVal = new Product() {
                Cost = 7,
                Name = "Sample Product 1",
                Price = 11.50m,
                ProductId = 1
            };

            return retVal;
        }

        public static OrderDetail GetOrderDetail1() {
            return GetOrderDetail1(GetProduct1());
        }

        public static OrderDetail GetOrderDetail1(Product product) {
            //show that you can get coverage on property initializers.
            var retVal = new OrderDetail() {
                Product = product,
                Quantity = 4,
                UnitPrice = 12
            };

            return retVal;
        }

        public static Product GetProduct2() {
            //show that you can get coverage on property initializers.
            var retVal = new Product() {
                Cost = 3,
                Name = "Sample Product 2",
                Price = 13.75m
            };

            return retVal;
        }

        public static OrderDetail GetOrderDetail2() {
            return GetOrderDetail2(GetProduct2());
        }

        public static OrderDetail GetOrderDetail2(Product product) {
            //show that you can get coverage on property initializers.
            var retVal = new OrderDetail() {
                Product = product,
                Quantity = 5,
                UnitPrice = 15
            };

            return retVal;
        }


    }
}